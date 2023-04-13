using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Newtonsoft.Json.Linq;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using WordAssistedTools.Utils;
using WordAssistedTools.ViewModels;
using WordAssistedTools.Views;
using WordAssistedTools.Properties;
using static WordAssistedTools.Utils.Methods;

namespace WordAssistedTools {
  public partial class RibbonTools {
    private Word.Application _mainWordApp;

    private Word.Document _document;

    private void RibbonTools_Load(object sender, RibbonUIEventArgs e) {
#if !DEBUG
      btnToolsTest.Visible = false;
#endif

      _mainWordApp = Globals.ThisAddIn.Application;
    }

    private void RefreshDocument() {
      _document = _mainWordApp.ActiveDocument;
    }

    private void btnToolsAutoPlan_Click(object sender, RibbonControlEventArgs e) {
      RefreshDocument();

      AutoPlan autoPlan = new();
      AutoPlanViewModel autoPlanViewModel = new(_document);
      autoPlan.DataContext = autoPlanViewModel;
      autoPlan.ShowDialog();
    }

    private void btnSetsSettings_Click(object sender, RibbonControlEventArgs e) {
      UserSettings userSettings = new();
      UserSettingsViewModel userSettingsViewModel = new();
      userSettings.DataContext = userSettingsViewModel;
      userSettings.ShowDialog();
    }

    private void btnToolsDelete_Click(object sender, RibbonControlEventArgs e) {
      RefreshDocument();
      DialogResult result = ShowMsgBox.QuestionOkCancel("此操作将清空所有的规划信息，确定继续吗？\r\n点击“确定”删除；\r\n点击“取消”放弃操作。");
      if (result == DialogResult.Cancel) {
        return;
      }

      Word.Paragraphs paragraphs = _document.Paragraphs;
      foreach (Word.Paragraph paragraph in paragraphs) {
        if (paragraph.Range.ComputeStatistics(Word.WdStatistic.wdStatisticWords) < 2) {
          continue;
        }

        string text = paragraph.Range.Text;
        if (text.StartsWith("(")) {
          int rightBraceIndex = text.IndexOf(")");
          if (rightBraceIndex > 0) {
            string originTimeWithBraces = text.Substring(0, rightBraceIndex + 1);
            string originTime = text.Substring(1, rightBraceIndex - 1);
            if (TryConvertTimeStrToDouble(originTime, out double _)) {
              Word.Range range = paragraph.Range;
              range.Find.Execute(originTimeWithBraces, MatchWholeWord: false);
              if (range.Text == originTimeWithBraces) {
                range.Text = string.Empty;
              }
            }
          }
        }

        if (text.TrimEnd().EndsWith(")")) {
          int leftBraceIndex = text.LastIndexOf("(");
          if (leftBraceIndex > 0) {
            string originEndTimeWithBraces = text.Substring(leftBraceIndex, text.TrimEnd().Length - leftBraceIndex);
            string originEndTime = text.Substring(leftBraceIndex + 1, text.TrimEnd().Length - 2 - leftBraceIndex);
            if (TryConvertTimeStrToDouble(originEndTime, out double _)) {
              Word.Range range = paragraph.Range;
              range.Find.Execute(originEndTimeWithBraces, MatchWholeWord: false);
              if (range.Text == originEndTimeWithBraces) {
                range.Text = string.Empty;
              }
            }
          }
        }

      }
    }

    private void btnExportToPpt_Click(object sender, RibbonControlEventArgs e) {
      RefreshDocument();
      ExportToPpt exportToPpt = new();
      ExportToPptViewModel exportToPptViewModel = new(_document);
      exportToPpt.DataContext = exportToPptViewModel;
      exportToPpt.ShowDialog();
    }

    private void btnToolsTest_Click(object sender, RibbonControlEventArgs e) {
      RefreshDocument();
      //
    }

    private void btnHelpAbout_Click(object sender, RibbonControlEventArgs e) {
      AboutInfo aboutInfo = new();
      aboutInfo.ShowDialog();
    }
  }
}

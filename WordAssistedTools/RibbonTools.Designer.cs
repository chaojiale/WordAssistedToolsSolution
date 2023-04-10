namespace WordAssistedTools {
  partial class RibbonTools : Microsoft.Office.Tools.Ribbon.RibbonBase {
    /// <summary>
    /// 必需的设计器变量。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public RibbonTools()
        : base(Globals.Factory.GetRibbonFactory()) {
      InitializeComponent();
    }

    /// <summary> 
    /// 清理所有正在使用的资源。
    /// </summary>
    /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region 组件设计器生成的代码

    /// <summary>
    /// 设计器支持所需的方法 - 不要修改
    /// 使用代码编辑器修改此方法的内容。
    /// </summary>
    private void InitializeComponent() {
      this.tabTools = this.Factory.CreateRibbonTab();
      this.group1 = this.Factory.CreateRibbonGroup();
      this.btnToolsAutoPlan = this.Factory.CreateRibbonButton();
      this.btnToolsDelete = this.Factory.CreateRibbonButton();
      this.btnExportToPpt = this.Factory.CreateRibbonButton();
      this.btnToolsTest = this.Factory.CreateRibbonButton();
      this.group2 = this.Factory.CreateRibbonGroup();
      this.btnSetsSettings = this.Factory.CreateRibbonButton();
      this.group3 = this.Factory.CreateRibbonGroup();
      this.btnHelpAbout = this.Factory.CreateRibbonButton();
      this.tabTools.SuspendLayout();
      this.group1.SuspendLayout();
      this.group2.SuspendLayout();
      this.group3.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabTools
      // 
      this.tabTools.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
      this.tabTools.Groups.Add(this.group1);
      this.tabTools.Groups.Add(this.group2);
      this.tabTools.Groups.Add(this.group3);
      this.tabTools.Label = "Pre辅助";
      this.tabTools.Name = "tabTools";
      // 
      // group1
      // 
      this.group1.Items.Add(this.btnToolsAutoPlan);
      this.group1.Items.Add(this.btnToolsDelete);
      this.group1.Items.Add(this.btnExportToPpt);
      this.group1.Items.Add(this.btnToolsTest);
      this.group1.Label = "工具";
      this.group1.Name = "group1";
      // 
      // btnToolsAutoPlan
      // 
      this.btnToolsAutoPlan.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
      this.btnToolsAutoPlan.Label = "演讲时间自动规划";
      this.btnToolsAutoPlan.Name = "btnToolsAutoPlan";
      this.btnToolsAutoPlan.OfficeImageId = "TimeScaleMenu";
      this.btnToolsAutoPlan.ShowImage = true;
      this.btnToolsAutoPlan.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnToolsAutoPlan_Click);
      // 
      // btnToolsDelete
      // 
      this.btnToolsDelete.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
      this.btnToolsDelete.Label = "清除所有规划信息";
      this.btnToolsDelete.Name = "btnToolsDelete";
      this.btnToolsDelete.OfficeImageId = "ViewDeleteCurrent";
      this.btnToolsDelete.ShowImage = true;
      this.btnToolsDelete.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnToolsDelete_Click);
      // 
      // btnExportToPpt
      // 
      this.btnExportToPpt.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
      this.btnExportToPpt.Label = "导出至PPT";
      this.btnExportToPpt.Name = "btnExportToPpt";
      this.btnExportToPpt.OfficeImageId = "ExportFile";
      this.btnExportToPpt.ShowImage = true;
      this.btnExportToPpt.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnExportToPpt_Click);
      // 
      // btnToolsTest
      // 
      this.btnToolsTest.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
      this.btnToolsTest.Label = "测试";
      this.btnToolsTest.Name = "btnToolsTest";
      this.btnToolsTest.OfficeImageId = "ScriptDebugger";
      this.btnToolsTest.ShowImage = true;
      this.btnToolsTest.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnToolsTest_Click);
      // 
      // group2
      // 
      this.group2.Items.Add(this.btnSetsSettings);
      this.group2.Label = "设置";
      this.group2.Name = "group2";
      // 
      // btnSetsSettings
      // 
      this.btnSetsSettings.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
      this.btnSetsSettings.Label = "设置";
      this.btnSetsSettings.Name = "btnSetsSettings";
      this.btnSetsSettings.OfficeImageId = "GroupSettings";
      this.btnSetsSettings.ShowImage = true;
      this.btnSetsSettings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSetsSettings_Click);
      // 
      // group3
      // 
      this.group3.Items.Add(this.btnHelpAbout);
      this.group3.Label = "帮助";
      this.group3.Name = "group3";
      // 
      // btnHelpAbout
      // 
      this.btnHelpAbout.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
      this.btnHelpAbout.Label = "关于";
      this.btnHelpAbout.Name = "btnHelpAbout";
      this.btnHelpAbout.OfficeImageId = "About";
      this.btnHelpAbout.ShowImage = true;
      this.btnHelpAbout.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnHelpAbout_Click);
      // 
      // RibbonTools
      // 
      this.Name = "RibbonTools";
      this.RibbonType = "Microsoft.Word.Document";
      this.Tabs.Add(this.tabTools);
      this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonTools_Load);
      this.tabTools.ResumeLayout(false);
      this.tabTools.PerformLayout();
      this.group1.ResumeLayout(false);
      this.group1.PerformLayout();
      this.group2.ResumeLayout(false);
      this.group2.PerformLayout();
      this.group3.ResumeLayout(false);
      this.group3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    internal Microsoft.Office.Tools.Ribbon.RibbonTab tabTools;
    internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
    internal Microsoft.Office.Tools.Ribbon.RibbonButton btnToolsAutoPlan;
    internal Microsoft.Office.Tools.Ribbon.RibbonButton btnExportToPpt;
    internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
    internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSetsSettings;
    internal Microsoft.Office.Tools.Ribbon.RibbonButton btnToolsDelete;
    internal Microsoft.Office.Tools.Ribbon.RibbonButton btnToolsTest;
    internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
    internal Microsoft.Office.Tools.Ribbon.RibbonButton btnHelpAbout;
  }

  partial class ThisRibbonCollection {
    internal RibbonTools RibbonTools {
      get { return this.GetRibbon<RibbonTools>(); }
    }
  }
}

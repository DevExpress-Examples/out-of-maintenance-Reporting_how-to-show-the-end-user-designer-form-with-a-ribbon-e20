using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
// ...

namespace EUD_ShowRibbonForm {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            // It's required to enable form skins in the application.
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        }

        // Show XRDesignRibbonFormEx.
        private void button1_Click(object sender, EventArgs e) {
            // Create an End-User Designer Form with a Ribbon.
            XRDesignRibbonFormEx form = new XRDesignRibbonFormEx();

            // Create a new blank report.
            form.OpenReport(new XtraReport());

            // Show the End-User Designer Form with a Ribbon
            form.Show();
        }
        
        // Show XRDesignRibbonFormEx modally.
        private void button2_Click(object sender, EventArgs e) {
            // Create an End-User Designer Form with a Ribbon.
            XRDesignRibbonFormEx form = new XRDesignRibbonFormEx();

            // Create a new blank report.
            form.OpenReport(new XtraReport());

            // Show the End-User Designer Form with a Ribbon
            form.ShowDialog();
        }

        // Call the ShowRibbonDesigner() method for the existing report.
        private void button3_Click(object sender, EventArgs e) {
            ReportDesignTool dt = new ReportDesignTool(new XtraReport1());
            dt.ShowRibbonDesigner();
        }
        
        // Call ShowRibbonDesignerDialog() method for the existing report.
        private void button4_Click(object sender, EventArgs e) {
            ReportDesignTool dt = new ReportDesignTool(new XtraReport1());
            dt.ShowRibbonDesignerDialog();
        }

    }
}
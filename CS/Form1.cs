using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
// ...

namespace EUD_ShowRibbonForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            // It's required to enable form skins in the application.
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        }

        // Show a report in a Ribbon End-User Designer form.
        private void button1_Click(object sender, EventArgs e) {
            new XtraReport1().ShowRibbonDesigner();
        }

        // Show a report in a Ribbon End-User Designer form, modally.
        private void button2_Click(object sender, EventArgs e) {
            new XtraReport1().ShowRibbonDesignerDialog();
        }

        // Use a ReportDesignTool, to show a report in a Ribbon End-User Designer form.
        private void button3_Click(object sender, EventArgs e) {
            ReportDesignTool dt = new ReportDesignTool(new XtraReport1());
            dt.ShowRibbonDesigner();
        }

        // Use a ReportDesignTool, to show a report in a Ribbon End-User Designer form.
        private void button4_Click(object sender, EventArgs e) {
            ReportDesignTool dt = new ReportDesignTool(new XtraReport1());
            dt.ShowRibbonDesignerDialog();
        }

        // Show an XRDesignRibbonForm.
        private void button5_Click(object sender, EventArgs e) {
            XRDesignRibbonForm form = new XRDesignRibbonForm();
            form.OpenReport(new XtraReport());
            form.Show();
        }

        // Show an XRDesignRibbonForm, modally.
        private void button6_Click(object sender, EventArgs e) {
            XRDesignRibbonForm form = new XRDesignRibbonForm();
            form.OpenReport(new XtraReport());
            form.ShowDialog();
        }

    }
}
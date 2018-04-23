Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner
' ...

Namespace EUD_ShowRibbonForm
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' It's required to enable form skins in the application.
			DevExpress.Skins.SkinManager.EnableFormSkins()
			DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
		End Sub

		' Show a report in a Ribbon End-User Designer form.
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			CType(New XtraReport1(), XtraReport1).ShowRibbonDesigner()
		End Sub

		' Show a report in a Ribbon End-User Designer form, modally.
		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			CType(New XtraReport1(), XtraReport1).ShowRibbonDesignerDialog()
		End Sub

		' Use a ReportDesignTool, to show a report in a Ribbon End-User Designer form.
		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			Dim dt As New ReportDesignTool(New XtraReport1())
			dt.ShowRibbonDesigner()
		End Sub

		' Use a ReportDesignTool, to show a report in a Ribbon End-User Designer form.
		Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button4.Click
			Dim dt As New ReportDesignTool(New XtraReport1())
			dt.ShowRibbonDesignerDialog()
		End Sub

		' Show an XRDesignRibbonForm.
		Private Sub button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button5.Click
			Dim form As New XRDesignRibbonForm()
			form.OpenReport(New XtraReport())
			form.Show()
		End Sub

		' Show an XRDesignRibbonForm, modally.
		Private Sub button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button6.Click
			Dim form As New XRDesignRibbonForm()
			form.OpenReport(New XtraReport())
			form.ShowDialog()
		End Sub

	End Class
End Namespace
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

		' Show XRDesignRibbonFormEx.
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			' Create an End-User Designer Form with a Ribbon.
			Dim form As New XRDesignRibbonFormEx()

			' Create a new blank report.
			form.OpenReport(New XtraReport())

			' Show the End-User Designer Form with a Ribbon
			form.Show()
		End Sub

		' Show XRDesignRibbonFormEx modally.
		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			' Create an End-User Designer Form with a Ribbon.
			Dim form As New XRDesignRibbonFormEx()

			' Create a new blank report.
			form.OpenReport(New XtraReport())

			' Show the End-User Designer Form with a Ribbon
			form.ShowDialog()
		End Sub

		' Call the ShowRibbonDesigner() method for the existing report.
		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			Dim dt As New ReportDesignTool(New XtraReport1())
			dt.ShowRibbonDesigner()
		End Sub

		' Call ShowRibbonDesignerDialog() method for the existing report.
		Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button4.Click
			Dim dt As New ReportDesignTool(New XtraReport1())
			dt.ShowRibbonDesignerDialog()
		End Sub

	End Class
End Namespace
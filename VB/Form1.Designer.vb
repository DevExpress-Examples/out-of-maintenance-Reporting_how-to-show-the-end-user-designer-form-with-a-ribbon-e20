Imports Microsoft.VisualBasic
Imports System
Namespace EUD_ShowRibbonForm
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.button5 = New System.Windows.Forms.Button()
			Me.button6 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			Me.button4 = New System.Windows.Forms.Button()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' button5
			' 
			Me.button5.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button5.Location = New System.Drawing.Point(12, 187)
			Me.button5.Name = "button5"
			Me.button5.Size = New System.Drawing.Size(318, 30)
			Me.button5.TabIndex = 0
			Me.button5.Text = "Show XRDesignRibbonForm"
			Me.button5.UseVisualStyleBackColor = True
'			Me.button5.Click += New System.EventHandler(Me.button5_Click);
			' 
			' button6
			' 
			Me.button6.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button6.Location = New System.Drawing.Point(12, 223)
			Me.button6.Name = "button6"
			Me.button6.Size = New System.Drawing.Size(318, 30)
			Me.button6.TabIndex = 0
			Me.button6.Text = "Show XRDesignRibbonForm Modally"
			Me.button6.UseVisualStyleBackColor = True
'			Me.button6.Click += New System.EventHandler(Me.button6_Click);
			' 
			' button3
			' 
			Me.button3.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button3.Location = New System.Drawing.Point(12, 99)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(318, 30)
			Me.button3.TabIndex = 0
			Me.button3.Text = "Call ReportDesignTool.ShowRibbonDesigner"
			Me.button3.UseVisualStyleBackColor = True
'			Me.button3.Click += New System.EventHandler(Me.button3_Click);
			' 
			' button4
			' 
			Me.button4.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button4.Location = New System.Drawing.Point(12, 135)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(318, 30)
			Me.button4.TabIndex = 0
			Me.button4.Text = "Call ReportDesignTool.ShowRibbonDesignerDialog"
			Me.button4.UseVisualStyleBackColor = True
'			Me.button4.Click += New System.EventHandler(Me.button4_Click);
			' 
			' button1
			' 
			Me.button1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button1.Location = New System.Drawing.Point(12, 12)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(318, 30)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Call XtraReport.ShowRibbonDesigner"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button2.Location = New System.Drawing.Point(12, 46)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(318, 30)
			Me.button2.TabIndex = 0
			Me.button2.Text = "Call XtraReport.ShowRibbonDesignerDialog"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(356, 285)
			Me.Controls.Add(Me.button6)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.button4)
			Me.Controls.Add(Me.button3)
			Me.Controls.Add(Me.button5)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents button5 As System.Windows.Forms.Button
		Private WithEvents button6 As System.Windows.Forms.Button
		Private WithEvents button3 As System.Windows.Forms.Button
		Private WithEvents button4 As System.Windows.Forms.Button
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
	End Class
End Namespace


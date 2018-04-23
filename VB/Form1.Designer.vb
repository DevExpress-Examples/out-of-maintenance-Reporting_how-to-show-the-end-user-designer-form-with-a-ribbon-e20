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
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			Me.button4 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button1.Location = New System.Drawing.Point(24, 39)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(256, 30)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Show XRDesignRibbonFormEx"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button2.Location = New System.Drawing.Point(24, 75)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(256, 30)
			Me.button2.TabIndex = 0
			Me.button2.Text = "Show XRDesignRibbonFormEx Modally"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' button3
			' 
			Me.button3.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button3.Location = New System.Drawing.Point(24, 144)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(256, 30)
			Me.button3.TabIndex = 0
			Me.button3.Text = "Call ShowRibbonDesigner"
			Me.button3.UseVisualStyleBackColor = True
'			Me.button3.Click += New System.EventHandler(Me.button3_Click);
			' 
			' button4
			' 
			Me.button4.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button4.Location = New System.Drawing.Point(24, 180)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(256, 30)
			Me.button4.TabIndex = 0
			Me.button4.Text = "Call ShowRibbonDesignerDialog"
			Me.button4.UseVisualStyleBackColor = True
'			Me.button4.Click += New System.EventHandler(Me.button4_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(311, 234)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button4)
			Me.Controls.Add(Me.button3)
			Me.Controls.Add(Me.button1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents button3 As System.Windows.Forms.Button
		Private WithEvents button4 As System.Windows.Forms.Button
	End Class
End Namespace


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Dice1Roll = New System.Windows.Forms.PictureBox()
        Me.Rolldice1 = New System.Windows.Forms.PictureBox()
        Me.Dice2Roll = New System.Windows.Forms.PictureBox()
        Me.Dice3Roll = New System.Windows.Forms.PictureBox()
        Me.Dice5Roll = New System.Windows.Forms.PictureBox()
        Me.Dice6Roll = New System.Windows.Forms.PictureBox()
        Me.lbltogether = New System.Windows.Forms.Label()
        Me.BtnRollDice2 = New System.Windows.Forms.Button()
        CType(Me.Dice1Roll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rolldice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice2Roll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice3Roll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice5Roll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice6Roll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dice1Roll
        '
        Me.Dice1Roll.Image = Global.WindowsApp11.My.Resources.Resources.dice1
        Me.Dice1Roll.Location = New System.Drawing.Point(290, 81)
        Me.Dice1Roll.Name = "Dice1Roll"
        Me.Dice1Roll.Size = New System.Drawing.Size(222, 233)
        Me.Dice1Roll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice1Roll.TabIndex = 13
        Me.Dice1Roll.TabStop = False
        '
        'Rolldice1
        '
        Me.Rolldice1.Image = Global.WindowsApp11.My.Resources.Resources.dice4
        Me.Rolldice1.Location = New System.Drawing.Point(290, 81)
        Me.Rolldice1.Name = "Rolldice1"
        Me.Rolldice1.Size = New System.Drawing.Size(213, 233)
        Me.Rolldice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Rolldice1.TabIndex = 12
        Me.Rolldice1.TabStop = False
        '
        'Dice2Roll
        '
        Me.Dice2Roll.Image = Global.WindowsApp11.My.Resources.Resources.dice2
        Me.Dice2Roll.Location = New System.Drawing.Point(290, 81)
        Me.Dice2Roll.Name = "Dice2Roll"
        Me.Dice2Roll.Size = New System.Drawing.Size(222, 233)
        Me.Dice2Roll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice2Roll.TabIndex = 14
        Me.Dice2Roll.TabStop = False
        '
        'Dice3Roll
        '
        Me.Dice3Roll.Image = Global.WindowsApp11.My.Resources.Resources.dice3
        Me.Dice3Roll.Location = New System.Drawing.Point(290, 81)
        Me.Dice3Roll.Name = "Dice3Roll"
        Me.Dice3Roll.Size = New System.Drawing.Size(222, 233)
        Me.Dice3Roll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice3Roll.TabIndex = 15
        Me.Dice3Roll.TabStop = False
        '
        'Dice5Roll
        '
        Me.Dice5Roll.Image = Global.WindowsApp11.My.Resources.Resources.dice5
        Me.Dice5Roll.Location = New System.Drawing.Point(290, 81)
        Me.Dice5Roll.Name = "Dice5Roll"
        Me.Dice5Roll.Size = New System.Drawing.Size(222, 233)
        Me.Dice5Roll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice5Roll.TabIndex = 16
        Me.Dice5Roll.TabStop = False
        '
        'Dice6Roll
        '
        Me.Dice6Roll.Image = Global.WindowsApp11.My.Resources.Resources.dice6
        Me.Dice6Roll.Location = New System.Drawing.Point(290, 81)
        Me.Dice6Roll.Name = "Dice6Roll"
        Me.Dice6Roll.Size = New System.Drawing.Size(222, 233)
        Me.Dice6Roll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice6Roll.TabIndex = 17
        Me.Dice6Roll.TabStop = False
        '
        'lbltogether
        '
        Me.lbltogether.AutoSize = True
        Me.lbltogether.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltogether.Location = New System.Drawing.Point(674, 200)
        Me.lbltogether.Name = "lbltogether"
        Me.lbltogether.Size = New System.Drawing.Size(54, 58)
        Me.lbltogether.TabIndex = 18
        Me.lbltogether.Text = "0"
        '
        'BtnRollDice2
        '
        Me.BtnRollDice2.Font = New System.Drawing.Font("Showcard Gothic", 14.0!)
        Me.BtnRollDice2.Location = New System.Drawing.Point(294, 363)
        Me.BtnRollDice2.Name = "BtnRollDice2"
        Me.BtnRollDice2.Size = New System.Drawing.Size(209, 54)
        Me.BtnRollDice2.TabIndex = 19
        Me.BtnRollDice2.Text = "Roll Dice"
        Me.BtnRollDice2.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnRollDice2)
        Me.Controls.Add(Me.lbltogether)
        Me.Controls.Add(Me.Dice6Roll)
        Me.Controls.Add(Me.Dice5Roll)
        Me.Controls.Add(Me.Dice3Roll)
        Me.Controls.Add(Me.Dice2Roll)
        Me.Controls.Add(Me.Dice1Roll)
        Me.Controls.Add(Me.Rolldice1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.Dice1Roll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rolldice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice2Roll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice3Roll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice5Roll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice6Roll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Rolldice1 As PictureBox
    Friend WithEvents Dice1Roll As PictureBox
    Friend WithEvents Dice2Roll As PictureBox
    Friend WithEvents Dice3Roll As PictureBox
    Friend WithEvents Dice5Roll As PictureBox
    Friend WithEvents Dice6Roll As PictureBox
    Friend WithEvents lbltogether As Label
    Friend WithEvents BtnRollDice2 As Button
End Class

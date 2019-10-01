<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblNumber1 = New System.Windows.Forms.Label()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnQuotient = New System.Windows.Forms.Button()
        Me.btnPower = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.lblOperation = New System.Windows.Forms.Label()
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblResultOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNumber1
        '
        Me.lblNumber1.AutoSize = True
        Me.lblNumber1.Location = New System.Drawing.Point(27, 48)
        Me.lblNumber1.Name = "lblNumber1"
        Me.lblNumber1.Size = New System.Drawing.Size(59, 13)
        Me.lblNumber1.TabIndex = 0
        Me.lblNumber1.Text = "Number 1 :"
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(92, 45)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber1.TabIndex = 1
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(92, 87)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(25, 23)
        Me.btnPlus.TabIndex = 2
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(143, 87)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(25, 23)
        Me.btnMinus.TabIndex = 3
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(195, 87)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(25, 23)
        Me.btnMultiply.TabIndex = 4
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(245, 87)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(25, 23)
        Me.btnDivide.TabIndex = 5
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnQuotient
        '
        Me.btnQuotient.Location = New System.Drawing.Point(92, 125)
        Me.btnQuotient.Name = "btnQuotient"
        Me.btnQuotient.Size = New System.Drawing.Size(25, 23)
        Me.btnQuotient.TabIndex = 6
        Me.btnQuotient.Text = "\"
        Me.btnQuotient.UseVisualStyleBackColor = True
        '
        'btnPower
        '
        Me.btnPower.Location = New System.Drawing.Point(143, 125)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(25, 23)
        Me.btnPower.TabIndex = 7
        Me.btnPower.Text = "^"
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(195, 125)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(45, 23)
        Me.btnMod.TabIndex = 8
        Me.btnMod.Text = "Mod"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'lblOperation
        '
        Me.lblOperation.AutoSize = True
        Me.lblOperation.Location = New System.Drawing.Point(27, 106)
        Me.lblOperation.Name = "lblOperation"
        Me.lblOperation.Size = New System.Drawing.Size(59, 13)
        Me.lblOperation.TabIndex = 9
        Me.lblOperation.Text = "Operation :"
        '
        'lblNumber2
        '
        Me.lblNumber2.AutoSize = True
        Me.lblNumber2.Location = New System.Drawing.Point(30, 165)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(59, 13)
        Me.lblNumber2.TabIndex = 10
        Me.lblNumber2.Text = "Number 2 :"
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(92, 162)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber2.TabIndex = 11
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(30, 214)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(43, 13)
        Me.lblResult.TabIndex = 12
        Me.lblResult.Text = "Result :"
        '
        'lblResultOutput
        '
        Me.lblResultOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultOutput.Location = New System.Drawing.Point(92, 214)
        Me.lblResultOutput.Name = "lblResultOutput"
        Me.lblResultOutput.Size = New System.Drawing.Size(100, 20)
        Me.lblResultOutput.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 283)
        Me.Controls.Add(Me.lblResultOutput)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.lblNumber2)
        Me.Controls.Add(Me.lblOperation)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnPower)
        Me.Controls.Add(Me.btnQuotient)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.lblNumber1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Simple Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumber1 As Label
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnQuotient As Button
    Friend WithEvents btnPower As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents lblOperation As Label
    Friend WithEvents lblNumber2 As Label
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents lblResultOutput As Label
End Class

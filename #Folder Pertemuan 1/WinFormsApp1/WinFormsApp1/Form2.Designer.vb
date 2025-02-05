<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        txtInput = New TextBox()
        Panel1 = New Panel()
        cmdBackspace = New Button()
        Panel2 = New Panel()
        cmdCalculatorSuhu = New Button()
        ButtonCubeRoot = New Button()
        ButtonFactorial = New Button()
        CmdEqual = New Button()
        CmdAddition = New Button()
        CmdInverse = New Button()
        CmdSubtract = New Button()
        CmdSqrt = New Button()
        CmdMultiply = New Button()
        CmdPowerOf = New Button()
        CmdDivision = New Button()
        cmdC = New Button()
        cmdCE = New Button()
        cmdDecimal = New Button()
        CmdSign = New Button()
        Cmd0 = New Button()
        Cmd3 = New Button()
        Cmd2 = New Button()
        Cmd1 = New Button()
        Cmd6 = New Button()
        Cmd5 = New Button()
        Cmd4 = New Button()
        Cmd9 = New Button()
        Cmd8 = New Button()
        Cmd7 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtInput
        ' 
        txtInput.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtInput.Location = New Point(13, 17)
        txtInput.Multiline = True
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(383, 95)
        txtInput.TabIndex = 0
        txtInput.Text = "0"
        txtInput.TextAlign = HorizontalAlignment.Right
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtInput)
        Panel1.Location = New Point(13, 29)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(409, 125)
        Panel1.TabIndex = 1
        ' 
        ' cmdBackspace
        ' 
        cmdBackspace.Location = New Point(14, 15)
        cmdBackspace.Name = "cmdBackspace"
        cmdBackspace.Size = New Size(142, 60)
        cmdBackspace.TabIndex = 2
        cmdBackspace.Text = "Backspace"
        cmdBackspace.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(cmdCalculatorSuhu)
        Panel2.Controls.Add(ButtonCubeRoot)
        Panel2.Controls.Add(ButtonFactorial)
        Panel2.Controls.Add(CmdEqual)
        Panel2.Controls.Add(CmdAddition)
        Panel2.Controls.Add(CmdInverse)
        Panel2.Controls.Add(CmdSubtract)
        Panel2.Controls.Add(CmdSqrt)
        Panel2.Controls.Add(CmdMultiply)
        Panel2.Controls.Add(CmdPowerOf)
        Panel2.Controls.Add(CmdDivision)
        Panel2.Controls.Add(cmdC)
        Panel2.Controls.Add(cmdCE)
        Panel2.Controls.Add(cmdDecimal)
        Panel2.Controls.Add(CmdSign)
        Panel2.Controls.Add(Cmd0)
        Panel2.Controls.Add(Cmd3)
        Panel2.Controls.Add(Cmd2)
        Panel2.Controls.Add(Cmd1)
        Panel2.Controls.Add(cmdBackspace)
        Panel2.Controls.Add(Cmd6)
        Panel2.Controls.Add(Cmd5)
        Panel2.Controls.Add(Cmd4)
        Panel2.Controls.Add(Cmd9)
        Panel2.Controls.Add(Cmd8)
        Panel2.Controls.Add(Cmd7)
        Panel2.Location = New Point(12, 170)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(409, 408)
        Panel2.TabIndex = 3
        ' 
        ' cmdCalculatorSuhu
        ' 
        cmdCalculatorSuhu.Location = New Point(14, 353)
        cmdCalculatorSuhu.Name = "cmdCalculatorSuhu"
        cmdCalculatorSuhu.Size = New Size(216, 44)
        cmdCalculatorSuhu.TabIndex = 4
        cmdCalculatorSuhu.Text = "Calculator Suhu"
        cmdCalculatorSuhu.UseVisualStyleBackColor = True
        ' 
        ' ButtonCubeRoot
        ' 
        ButtonCubeRoot.Location = New Point(329, 345)
        ButtonCubeRoot.Name = "ButtonCubeRoot"
        ButtonCubeRoot.Size = New Size(68, 60)
        ButtonCubeRoot.TabIndex = 27
        ButtonCubeRoot.Text = "X^3"
        ButtonCubeRoot.UseVisualStyleBackColor = True
        ' 
        ' ButtonFactorial
        ' 
        ButtonFactorial.Location = New Point(255, 345)
        ButtonFactorial.Name = "ButtonFactorial"
        ButtonFactorial.Size = New Size(68, 60)
        ButtonFactorial.TabIndex = 26
        ButtonFactorial.Text = "n!"
        ButtonFactorial.UseVisualStyleBackColor = True
        ' 
        ' CmdEqual
        ' 
        CmdEqual.Location = New Point(329, 279)
        CmdEqual.Name = "CmdEqual"
        CmdEqual.Size = New Size(68, 60)
        CmdEqual.TabIndex = 25
        CmdEqual.Text = "="
        CmdEqual.UseVisualStyleBackColor = True
        ' 
        ' CmdAddition
        ' 
        CmdAddition.Location = New Point(255, 279)
        CmdAddition.Name = "CmdAddition"
        CmdAddition.Size = New Size(68, 60)
        CmdAddition.TabIndex = 24
        CmdAddition.Text = "+"
        CmdAddition.UseVisualStyleBackColor = True
        ' 
        ' CmdInverse
        ' 
        CmdInverse.Location = New Point(329, 213)
        CmdInverse.Name = "CmdInverse"
        CmdInverse.Size = New Size(68, 60)
        CmdInverse.TabIndex = 23
        CmdInverse.Text = "1/X"
        CmdInverse.UseVisualStyleBackColor = True
        ' 
        ' CmdSubtract
        ' 
        CmdSubtract.Location = New Point(255, 213)
        CmdSubtract.Name = "CmdSubtract"
        CmdSubtract.Size = New Size(68, 60)
        CmdSubtract.TabIndex = 22
        CmdSubtract.Text = "-"
        CmdSubtract.UseVisualStyleBackColor = True
        ' 
        ' CmdSqrt
        ' 
        CmdSqrt.Location = New Point(329, 147)
        CmdSqrt.Name = "CmdSqrt"
        CmdSqrt.Size = New Size(68, 60)
        CmdSqrt.TabIndex = 21
        CmdSqrt.Text = "SQRT"
        CmdSqrt.UseVisualStyleBackColor = True
        ' 
        ' CmdMultiply
        ' 
        CmdMultiply.Location = New Point(255, 147)
        CmdMultiply.Name = "CmdMultiply"
        CmdMultiply.Size = New Size(68, 60)
        CmdMultiply.TabIndex = 20
        CmdMultiply.Text = "*"
        CmdMultiply.UseVisualStyleBackColor = True
        ' 
        ' CmdPowerOf
        ' 
        CmdPowerOf.Location = New Point(329, 81)
        CmdPowerOf.Name = "CmdPowerOf"
        CmdPowerOf.Size = New Size(68, 60)
        CmdPowerOf.TabIndex = 19
        CmdPowerOf.Text = "X^"
        CmdPowerOf.UseVisualStyleBackColor = True
        ' 
        ' CmdDivision
        ' 
        CmdDivision.Location = New Point(255, 81)
        CmdDivision.Name = "CmdDivision"
        CmdDivision.Size = New Size(68, 60)
        CmdDivision.TabIndex = 18
        CmdDivision.Text = "/"
        CmdDivision.UseVisualStyleBackColor = True
        ' 
        ' cmdC
        ' 
        cmdC.Location = New Point(329, 15)
        cmdC.Name = "cmdC"
        cmdC.Size = New Size(68, 60)
        cmdC.TabIndex = 17
        cmdC.Text = "C"
        cmdC.UseVisualStyleBackColor = True
        ' 
        ' cmdCE
        ' 
        cmdCE.Location = New Point(255, 15)
        cmdCE.Name = "cmdCE"
        cmdCE.Size = New Size(68, 60)
        cmdCE.TabIndex = 16
        cmdCE.Text = "CE"
        cmdCE.UseVisualStyleBackColor = True
        ' 
        ' cmdDecimal
        ' 
        cmdDecimal.Location = New Point(162, 279)
        cmdDecimal.Name = "cmdDecimal"
        cmdDecimal.Size = New Size(68, 60)
        cmdDecimal.TabIndex = 15
        cmdDecimal.Text = "."
        cmdDecimal.UseVisualStyleBackColor = True
        ' 
        ' CmdSign
        ' 
        CmdSign.Location = New Point(88, 279)
        CmdSign.Name = "CmdSign"
        CmdSign.Size = New Size(68, 60)
        CmdSign.TabIndex = 14
        CmdSign.Text = "+/-"
        CmdSign.UseVisualStyleBackColor = True
        ' 
        ' Cmd0
        ' 
        Cmd0.Location = New Point(14, 279)
        Cmd0.Name = "Cmd0"
        Cmd0.Size = New Size(68, 60)
        Cmd0.TabIndex = 13
        Cmd0.Text = "0"
        Cmd0.UseVisualStyleBackColor = True
        ' 
        ' Cmd3
        ' 
        Cmd3.Location = New Point(162, 213)
        Cmd3.Name = "Cmd3"
        Cmd3.Size = New Size(68, 60)
        Cmd3.TabIndex = 12
        Cmd3.Text = "3"
        Cmd3.UseVisualStyleBackColor = True
        ' 
        ' Cmd2
        ' 
        Cmd2.Location = New Point(88, 213)
        Cmd2.Name = "Cmd2"
        Cmd2.Size = New Size(68, 60)
        Cmd2.TabIndex = 11
        Cmd2.Text = "2"
        Cmd2.UseVisualStyleBackColor = True
        ' 
        ' Cmd1
        ' 
        Cmd1.Location = New Point(14, 213)
        Cmd1.Name = "Cmd1"
        Cmd1.Size = New Size(68, 60)
        Cmd1.TabIndex = 10
        Cmd1.Text = "1"
        Cmd1.UseVisualStyleBackColor = True
        ' 
        ' Cmd6
        ' 
        Cmd6.Location = New Point(162, 147)
        Cmd6.Name = "Cmd6"
        Cmd6.Size = New Size(68, 60)
        Cmd6.TabIndex = 9
        Cmd6.Text = "6"
        Cmd6.UseVisualStyleBackColor = True
        ' 
        ' Cmd5
        ' 
        Cmd5.Location = New Point(88, 147)
        Cmd5.Name = "Cmd5"
        Cmd5.Size = New Size(68, 60)
        Cmd5.TabIndex = 8
        Cmd5.Text = "5"
        Cmd5.UseVisualStyleBackColor = True
        ' 
        ' Cmd4
        ' 
        Cmd4.Location = New Point(14, 147)
        Cmd4.Name = "Cmd4"
        Cmd4.Size = New Size(68, 60)
        Cmd4.TabIndex = 7
        Cmd4.Text = "4"
        Cmd4.UseVisualStyleBackColor = True
        ' 
        ' Cmd9
        ' 
        Cmd9.Location = New Point(162, 81)
        Cmd9.Name = "Cmd9"
        Cmd9.Size = New Size(68, 60)
        Cmd9.TabIndex = 6
        Cmd9.Text = "9"
        Cmd9.UseVisualStyleBackColor = True
        ' 
        ' Cmd8
        ' 
        Cmd8.Location = New Point(88, 81)
        Cmd8.Name = "Cmd8"
        Cmd8.Size = New Size(68, 60)
        Cmd8.TabIndex = 5
        Cmd8.Text = "8"
        Cmd8.UseVisualStyleBackColor = True
        ' 
        ' Cmd7
        ' 
        Cmd7.Location = New Point(14, 81)
        Cmd7.Name = "Cmd7"
        Cmd7.Size = New Size(68, 60)
        Cmd7.TabIndex = 4
        Cmd7.Text = "7"
        Cmd7.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(433, 594)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdBackspace As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CmdEqual As Button
    Friend WithEvents CmdAddition As Button
    Friend WithEvents CmdInverse As Button
    Friend WithEvents CmdSubtract As Button
    Friend WithEvents CmdSqrt As Button
    Friend WithEvents CmdMultiply As Button
    Friend WithEvents CmdPowerOf As Button
    Friend WithEvents CmdDivision As Button
    Friend WithEvents cmdC As Button
    Friend WithEvents cmdCE As Button
    Friend WithEvents cmdDecimal As Button
    Friend WithEvents CmdSign As Button
    Friend WithEvents Cmd0 As Button
    Friend WithEvents Cmd3 As Button
    Friend WithEvents Cmd2 As Button
    Friend WithEvents Cmd1 As Button
    Friend WithEvents Cmd6 As Button
    Friend WithEvents Cmd5 As Button
    Friend WithEvents Cmd4 As Button
    Friend WithEvents Cmd9 As Button
    Friend WithEvents Cmd8 As Button
    Friend WithEvents Cmd7 As Button
    Friend WithEvents cmdCalculatorSuhu As Button
    Friend WithEvents ButtonCubeRoot As Button
    Friend WithEvents ButtonFactorial As Button
End Class

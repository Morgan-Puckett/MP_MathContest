<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MP_MathContest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StudentInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.CurrentMathProbGroupBox = New System.Windows.Forms.GroupBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.StudentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.MathProbTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.ButtonsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.StuduntInputGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentSubmit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StudentInfoGroupBox.SuspendLayout()
        Me.CurrentMathProbGroupBox.SuspendLayout()
        Me.MathProbTypeGroupBox.SuspendLayout()
        Me.ButtonsGroupBox.SuspendLayout()
        Me.StuduntInputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentInfoGroupBox
        '
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameLabel)
        Me.StudentInfoGroupBox.Location = New System.Drawing.Point(30, 34)
        Me.StudentInfoGroupBox.Name = "StudentInfoGroupBox"
        Me.StudentInfoGroupBox.Size = New System.Drawing.Size(454, 183)
        Me.StudentInfoGroupBox.TabIndex = 0
        Me.StudentInfoGroupBox.TabStop = False
        Me.StudentInfoGroupBox.Text = "Student Information"
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(210, 85)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(62, 27)
        Me.GradeTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.GradeTextBox, "Enter Student Grade. Must be in 1st through 4th grade. ")
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(104, 85)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(62, 27)
        Me.AgeTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.AgeTextBox, "Enter Students Age. Must be between 7 and 11")
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(15, 85)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(62, 27)
        Me.NameTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.NameTextBox, "Enter Students Name")
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(219, 42)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(49, 20)
        Me.GradeLabel.TabIndex = 2
        Me.GradeLabel.Text = "Grade"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(113, 42)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(36, 20)
        Me.AgeLabel.TabIndex = 1
        Me.AgeLabel.Text = "Age"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(15, 42)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(49, 20)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name"
        '
        'CurrentMathProbGroupBox
        '
        Me.CurrentMathProbGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.CurrentMathProbGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.CurrentMathProbGroupBox.Controls.Add(Me.StudentAnswerTextBox)
        Me.CurrentMathProbGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.CurrentMathProbGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.CurrentMathProbGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.CurrentMathProbGroupBox.Location = New System.Drawing.Point(28, 223)
        Me.CurrentMathProbGroupBox.Name = "CurrentMathProbGroupBox"
        Me.CurrentMathProbGroupBox.Size = New System.Drawing.Size(267, 195)
        Me.CurrentMathProbGroupBox.TabIndex = 1
        Me.CurrentMathProbGroupBox.TabStop = False
        Me.CurrentMathProbGroupBox.Text = "Current Math Problem"
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(156, 70)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(90, 27)
        Me.SecondNumberTextBox.TabIndex = 7
        Me.SecondNumberTextBox.Text = "4"
        Me.ToolTip1.SetToolTip(Me.SecondNumberTextBox, "Enter Second Varible in equation ")
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(156, 43)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(90, 27)
        Me.FirstNumberTextBox.TabIndex = 6
        Me.FirstNumberTextBox.Text = "5"
        Me.ToolTip1.SetToolTip(Me.FirstNumberTextBox, "Enter First Varible in equation")
        '
        'StudentAnswerTextBox
        '
        Me.StudentAnswerTextBox.Location = New System.Drawing.Point(156, 146)
        Me.StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        Me.StudentAnswerTextBox.Size = New System.Drawing.Size(90, 27)
        Me.StudentAnswerTextBox.TabIndex = 0
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(25, 149)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(112, 20)
        Me.StudentAnswerLabel.TabIndex = 5
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(45, 70)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(92, 20)
        Me.SecondNumberLabel.TabIndex = 4
        Me.SecondNumberLabel.Text = "2nd Number"
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(51, 43)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(86, 20)
        Me.FirstNumberLabel.TabIndex = 3
        Me.FirstNumberLabel.Text = "1st Number"
        '
        'MathProbTypeGroupBox
        '
        Me.MathProbTypeGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.MathProbTypeGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.MathProbTypeGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.MathProbTypeGroupBox.Controls.Add(Me.AddRadioButton)
        Me.MathProbTypeGroupBox.Location = New System.Drawing.Point(301, 223)
        Me.MathProbTypeGroupBox.Name = "MathProbTypeGroupBox"
        Me.MathProbTypeGroupBox.Size = New System.Drawing.Size(183, 195)
        Me.MathProbTypeGroupBox.TabIndex = 2
        Me.MathProbTypeGroupBox.TabStop = False
        Me.MathProbTypeGroupBox.Text = "Math Problem Type"
        Me.ToolTip1.SetToolTip(Me.MathProbTypeGroupBox, "Choose the function of equation")
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(20, 124)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(73, 24)
        Me.DivideRadioButton.TabIndex = 3
        Me.DivideRadioButton.Text = "Divide"
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(20, 94)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(84, 24)
        Me.MultiplyRadioButton.TabIndex = 2
        Me.MultiplyRadioButton.Text = "Multiply"
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(20, 66)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(85, 24)
        Me.SubtractRadioButton.TabIndex = 1
        Me.SubtractRadioButton.Text = "Subtract"
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Checked = True
        Me.AddRadioButton.Location = New System.Drawing.Point(20, 36)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(58, 24)
        Me.AddRadioButton.TabIndex = 0
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'ButtonsGroupBox
        '
        Me.ButtonsGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonsGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonsGroupBox.Controls.Add(Me.SubmitButton)
        Me.ButtonsGroupBox.Controls.Add(Me.SummaryButton)
        Me.ButtonsGroupBox.Location = New System.Drawing.Point(501, 41)
        Me.ButtonsGroupBox.Name = "ButtonsGroupBox"
        Me.ButtonsGroupBox.Size = New System.Drawing.Size(152, 252)
        Me.ButtonsGroupBox.TabIndex = 3
        Me.ButtonsGroupBox.TabStop = False
        Me.ButtonsGroupBox.Text = "Teacher Controls"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(20, 195)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(110, 50)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit Contest")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(20, 134)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(110, 50)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear history for a new student")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.ImageKey = "(none)"
        Me.SubmitButton.Location = New System.Drawing.Point(20, 20)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(110, 50)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "Submit Student Info"
        Me.ToolTip1.SetToolTip(Me.SubmitButton, "Submit Student information ")
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(20, 78)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(110, 50)
        Me.SummaryButton.TabIndex = 1
        Me.SummaryButton.Text = "S&ummary"
        Me.ToolTip1.SetToolTip(Me.SummaryButton, "Show results of student wins vs. attempts")
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'StuduntInputGroupBox
        '
        Me.StuduntInputGroupBox.Controls.Add(Me.StudentSubmit)
        Me.StuduntInputGroupBox.Location = New System.Drawing.Point(503, 308)
        Me.StuduntInputGroupBox.Name = "StuduntInputGroupBox"
        Me.StuduntInputGroupBox.Size = New System.Drawing.Size(149, 109)
        Me.StuduntInputGroupBox.TabIndex = 4
        Me.StuduntInputGroupBox.TabStop = False
        Me.StuduntInputGroupBox.Text = "Student Input"
        '
        'StudentSubmit
        '
        Me.StudentSubmit.Location = New System.Drawing.Point(18, 32)
        Me.StudentSubmit.Name = "StudentSubmit"
        Me.StudentSubmit.Size = New System.Drawing.Size(110, 71)
        Me.StudentSubmit.TabIndex = 1
        Me.StudentSubmit.Text = "&Submit Student Answer"
        Me.ToolTip1.SetToolTip(Me.StudentSubmit, "Add new attempt to total. Compares answer to student input")
        Me.StudentSubmit.UseVisualStyleBackColor = True
        '
        'MP_MathContest
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(676, 439)
        Me.Controls.Add(Me.StuduntInputGroupBox)
        Me.Controls.Add(Me.ButtonsGroupBox)
        Me.Controls.Add(Me.MathProbTypeGroupBox)
        Me.Controls.Add(Me.CurrentMathProbGroupBox)
        Me.Controls.Add(Me.StudentInfoGroupBox)
        Me.Name = "MP_MathContest"
        Me.Text = "MP_MathContest"
        Me.StudentInfoGroupBox.ResumeLayout(False)
        Me.StudentInfoGroupBox.PerformLayout()
        Me.CurrentMathProbGroupBox.ResumeLayout(False)
        Me.CurrentMathProbGroupBox.PerformLayout()
        Me.MathProbTypeGroupBox.ResumeLayout(False)
        Me.MathProbTypeGroupBox.PerformLayout()
        Me.ButtonsGroupBox.ResumeLayout(False)
        Me.StuduntInputGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentInfoGroupBox As GroupBox
    Friend WithEvents CurrentMathProbGroupBox As GroupBox
    Friend WithEvents MathProbTypeGroupBox As GroupBox
    Friend WithEvents ButtonsGroupBox As GroupBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents StuduntInputGroupBox As GroupBox
    Friend WithEvents StudentSubmit As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class

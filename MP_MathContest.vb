'Morgan Puckett
'RCET0265
'March 2022
'Math Contest
'

'This program is meant for teacher use, once the student name is submitted the student can 
'interact with the program 

'add menu? 
'documenataiion
Public Class MP_MathContest
    'Global since they are used throughout may functions to compile messages
    Dim errorMsg As String = ""
    Dim result As String = "bingbong"

    'j determins how many are right out of the total, i 
    Dim j As Integer = 0
    Dim i As Integer = 0

    'Checks to see if Name is Entered
    Function NameCheck(er As Boolean)

        Select Case NameTextBox.Text
            Case ""
                er = True
                errorMsg += vbCrLf + "Name Is not valid"
                NameTextBox.Focus()
            Case Else
                er = False
        End Select
        Return er
    End Function

    'Checks to see if age is an integer between 7 - 11
    Function AgeCheck(er As Boolean)
        Try
            AgeTextBox.Text = CInt(AgeTextBox.Text)
            er = False
            If AgeTextBox.Text < 7 Or AgeTextBox.Text > 11 Then
                er = True
                errorMsg += vbCrLf + "Age Must be between 7-11"
                AgeTextBox.Clear()
                AgeTextBox.Focus()
            End If
        Catch
            AgeTextBox.Focus()
            er = True
            errorMsg += vbCrLf + "Age is not valid"
            AgeTextBox.Clear()
        End Try
        Return er
    End Function

    'Checks to see if grade is an integer between 1 - 4
    Function GradeCheck(er As Boolean)
        Try
            GradeTextBox.Text = CInt(GradeTextBox.Text)
            er = False
            If GradeTextBox.Text < 1 Or GradeTextBox.Text > 4 Then
                er = True
                GradeTextBox.Clear()
                GradeTextBox.Focus()
                errorMsg += vbCrLf + "Grade must be between 1 - 4"
            End If

        Catch
            er = True
            GradeTextBox.Clear()
            GradeTextBox.Focus()
            errorMsg += vbCrLf + "Grade is not Valid number"
        End Try
        Return er
    End Function

    'Checks to see that Both Numbers are filled in and integers
    Function FirstSecondInputCheck(er As Boolean)
        Try
            SecondNumberTextBox.Text = CInt(SecondNumberTextBox.Text)
            FirstNumberTextBox.Text = CInt(FirstNumberTextBox.Text)
            er = False
        Catch
            FirstNumberTextBox.Clear()
            SecondNumberTextBox.Clear()
            FirstNumberTextBox.Focus()
            SecondNumberTextBox.Focus()
            er = True
            errorMsg += vbCrLf + "Problem Numbers are not valid"
        End Try
        Return er
    End Function

    'Clears all textboxes and memory
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        AddRadioButton.Checked = True
        NameTextBox.Clear()
        AgeTextBox.Clear()
        GradeTextBox.Clear()
        FirstNumberTextBox.Clear()
        SecondNumberTextBox.Clear()
        StudentAnswerTextBox.Clear()
        i = 0
        j = 0
        result = 0
        StudentAnswerTextBox.Enabled = False
        FirstNumberTextBox.Enabled = True
        SecondNumberTextBox.Enabled = True

    End Sub

    'Displays correct(j) out of total(i)
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        MsgBox($"{NameTextBox.Text} got {j} out of {i} attempts correct")
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim er As Boolean

        'Checks all fuctions and determines whether or not to return an error message
        If FirstSecondInputCheck(er) Or GradeCheck(er) Or AgeCheck(er) Or NameCheck(er) = True Then
            er = True
        End If

        'MAKE MESSAGE BOX in VALID ORDER?????????
        If er = True Then
            MsgBox($"Student is not eligible to compete for following reasons...{vbCrLf} {errorMsg}")
            errorMsg = ""
        Else
            FirstNumberTextBox.Enabled = False
            SecondNumberTextBox.Enabled = False
            StudentAnswerTextBox.Enabled = True
            StudentSubmit.Enabled = True
            ' MathProbTypeGroupBox.Enabled = False
        End If
    End Sub

    'Next 4 Subs determine the correct answer
    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged
        result = $"{CInt(FirstNumberTextBox.Text) + CInt(SecondNumberTextBox.Text)}"
    End Sub
    Private Sub SubtractRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractRadioButton.CheckedChanged
        result = $"{CInt(FirstNumberTextBox.Text) - CInt(SecondNumberTextBox.Text)}"
    End Sub
    Private Sub MultiplyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplyRadioButton.CheckedChanged
        result = $"{CInt(FirstNumberTextBox.Text) * CInt(SecondNumberTextBox.Text)}"
    End Sub
    Private Sub DivideRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivideRadioButton.CheckedChanged
        result = $"{CInt(FirstNumberTextBox.Text) / CInt(SecondNumberTextBox.Text)}"
    End Sub

    'Submits and compares student input to result
    Private Sub StudentSubmit_Click(sender As Object, e As EventArgs) Handles StudentSubmit.Click
        i += 1
        If StudentAnswerTextBox.Text = result Then
            j += 1
            MsgBox("Congrats! That is Correct!! Here is $1000000000")
        Else
            j = j
            MsgBox($"That is incorrect. {result} was the correct answer")
        End If

    End Sub

    Private Sub MP_MathContest_Load(sender As Object, e As EventArgs) Handles Me.Load
        StudentAnswerTextBox.Enabled = False
        StudentSubmit.Enabled = False
    End Sub
End Class

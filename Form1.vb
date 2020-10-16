Public Class Form1
    Private Sub markTxt_TextChanged(sender As Object, e As EventArgs) Handles markTxt.TextChanged

        Dim mark As Integer
        mark = markTxt.Text

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim mark As Integer = Val(markTxt.Text)
        Call checkgrade(mark)


    End Sub

    Private Sub checkgrade(ByVal mark As Integer)


        Select Case mark
            Case 80 To 100
                gradeTxt.Text = "A"
            Case 60 To 79
                gradeTxt.Text = "B"
            Case 50 To 59
                gradeTxt.Text = "C"
            Case 40 To 49
                gradeTxt.Text = "D"
            Case Is < 39
                gradeTxt.Text = "E"

        End Select

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub
End Class

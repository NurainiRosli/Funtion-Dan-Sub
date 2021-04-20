Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        lbl1.Text = "Data 1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim strText1 As String
        strText1 = txt1.Text
        lbl2.Text = strText1
    End Sub

    Private Function btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        lbl3.Text = "Data 2"
        Return lbl3
    End Function

    Private Function btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Dim strText2 As String
        strText2 = txt2.Text
        lbl4.Text = strText2
        Return lbl4
    End Function
End Class

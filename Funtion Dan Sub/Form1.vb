Public Class Form1

    Private Sub SubMaklumat1()
        lbl1.Text = "Data 1"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        SubMaklumat1()
    End Sub

    Private Sub SubMaklumat2()
        Dim strText1 As String
        strText1 = txt1.Text
        lbl2.Text = strText1
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        SubMaklumat2()
    End Sub

    Private Function FunMaklumat3()
        Return "Data 2"
    End Function

    Private Function btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        lbl3.Text = FunMaklumat3()
    End Function

    Private Function FunMaklumat4()
        Dim strText2 As String
        strText2 = txt2.Text
        Return strText2
    End Function

    Private Function btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        lbl4.Text = FunMaklumat4()
    End Function

End Class

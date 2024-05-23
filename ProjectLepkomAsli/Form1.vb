Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Admin" And TextBox2.Text = "123" Then
            Form3.Show()
            Me.Hide()
        Else
            MsgBox("Username atau Password salah")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Anda yakin akan keluar dari aplikasi?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
            End
        End If
    End Sub

End Class

Public Class Form2

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Format(Now, "d - MMMM - yyyy")
        'Label17.Text = Format(Format(Now, "HH:mm:ss"))
        waktu()

    End Sub
    Sub waktu()
        'HR'
        Dim hr As String = TimeOfDay.Hour
        If hr = 1 Then
            hr = "0" + hr
        End If
        If hr = 2 Then
            hr = "0" + hr
        End If
        If hr = 3 Then
            hr = "0" + hr
        End If
        If hr = 4 Then
            hr = "0" + hr
        End If
        If hr = 5 Then
            hr = "0" + hr
        End If
        If hr = 6 Then
            hr = "0" + hr
        End If
        If hr = 7 Then
            hr = "0" + hr
        End If
        If hr = 8 Then
            hr = "0" + hr
        End If
        If hr = 9 Then
            hr = "0" + hr
        End If
        If hr = 0 Then
            hr = "0" + hr
        End If
        'MN'
        Dim mn As String = TimeOfDay.Minute
        If mn = 1 Then
            mn = "0" + mn
        End If
        If mn = 2 Then
            mn = "0" + mn
        End If
        If mn = 3 Then
            mn = "0" + mn
        End If
        If mn = 4 Then
            mn = "0" + mn
        End If
        If mn = 5 Then
            mn = "0" + mn
        End If
        If mn = 6 Then
            mn = "0" + mn
        End If
        If mn = 7 Then
            mn = "0" + mn
        End If
        If mn = 8 Then
            mn = "0" + mn
        End If
        If mn = 9 Then
            mn = "0" + mn
        End If
        If mn = 0 Then
            mn = "0" + mn
        End If
        'SC'
        Dim sc As String = TimeOfDay.Second
        If sc = 1 Then
            sc = "0" + sc
        End If
        If sc = 2 Then
            sc = "0" + sc
        End If
        If sc = 3 Then
            sc = "0" + sc
        End If
        If sc = 4 Then
            sc = "0" + sc
        End If
        If sc = 5 Then
            sc = "0" + sc
        End If
        If sc = 6 Then
            sc = "0" + sc
        End If
        If sc = 7 Then
            sc = "0" + sc
        End If
        If sc = 8 Then
            sc = "0" + sc
        End If
        If sc = 9 Then
            sc = "0" + sc
        End If
        If sc = 0 Then
            sc = "0" + sc
        End If
        Label17.Text = hr + ":" + mn + ":" + sc
    End Sub

    Private Sub Label2_Load(sender As Object, e As EventArgs)
        Dim currentDate As DateTime = DateTime.Now
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TextBox4.ReadOnly = True
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult = MessageBox.Show("Anda harus login kembali saat keluar dari aplikasi ini, anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            e.Cancel = True ' Membatalkan proses penutupan form
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        waktu()
    End Sub

    Dim harga, antar As Long

    Private Sub Refill2_CheckedChanged(sender As Object, e As EventArgs) Handles Refill2.CheckedChanged
        harga = 5000
        If Refill1.Checked = True Then
            antar = antar + harga
        Else
            antar = antar - harga
        End If
    End Sub

    Private Sub Refill1_CheckedChanged(sender As Object, e As EventArgs) Handles Refill1.CheckedChanged
        harga = 0
        If Refill1.Checked = True Then
            antar = antar + harga
        Else
            antar = antar - harga
        End If
    End Sub

End Class
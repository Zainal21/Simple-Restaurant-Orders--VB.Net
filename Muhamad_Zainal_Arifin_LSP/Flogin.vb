Public Class Flogin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And Textbox2.Text = "" Then
            is_clear()
            MsgBox("Akses ditolak, kolom username dan password wajib diisi !!", MsgBoxStyle.Critical, MsgBoxResult.Yes)
        ElseIf TextBox1.Text = "admin" And Textbox2.Text = "admin" Then
            MsgBox("Login Berhasil, Halaman akan segera dialihkan", MsgBoxStyle.Information, MsgBoxResult.Yes)
            is_clear()
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("Akses ditolak, username dan password anda salah !!", MsgBoxStyle.Critical, MsgBoxResult.Yes)
            is_clear()
        End If
    End Sub

    Sub is_clear()
        TextBox1.Clear()
        Textbox2.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
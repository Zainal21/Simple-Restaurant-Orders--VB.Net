Public Class Form1

    Dim ck As CheckBox()
    Dim jm As TextBox()
    Dim harga As TextBox()
    Dim total, bayar, kembali As Double

    Sub FetchData()
        ck = New CheckBox() {ck1, ck2, ck3, ck4, ck5, ck6, ck7, ck8, ck9, ck10, ck11, ck12}
        harga = New TextBox() {harga1, harga2, harga3, harga4, harga5, harga6, harga7, harga8, harga9, harga10, harga11, harga12}
        jm = New TextBox() {jml1, jml2, jml3, jml4, jml5, jml6, jml7, jml8, jml9, jml10, jml11, jml12}
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles harga6.TextChanged

    End Sub
    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles ck6.CheckedChanged

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles ck11.CheckedChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim i As Integer
            total = 0
            For i = 0 To 11
                If ck(i).Checked Then
                    total += (Val(harga(i).Text) * Val(jm(i).Text))
                    TxtTotalBayar.Text = "Rp." & Format(total, "#,#.###")
                End If
            Next
        Catch ex As Exception
            MsgBox("Maaf, Terjadi Kesalahan Sistem", MsgBoxStyle.Critical, MsgBoxResult.Yes)
        End Try
    End Sub

    Private Sub txtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBayar.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                kembali = Val(txtBayar.Text) - total
                If txtBayar.Text < total Then
                    MsgBox("jumlah pembayaran lebih kecil dari tagihan, periksa kembali", MsgBoxStyle.Critical, MsgBoxResult.Yes)
                Else
                    Txtkembali.Text = "Rp." & Format(kembali, "#,#.###")
                    MsgBox("Pembayaran Berhasil, Terimakasih telah berkunjung", MsgBoxStyle.Information, MsgBoxResult.Yes)
                End If         
            End If
        Catch ex As Exception
            MsgBox("Maaf, Terjadi Kesalahan Sistem", MsgBoxStyle.Critical, MsgBoxResult.Yes)
        End Try
    End Sub
    Private Sub txtBayar_TextChanged(sender As Object, e As EventArgs) Handles txtBayar.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class

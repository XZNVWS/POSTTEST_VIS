Public Class Form1

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click

        NamaUser = TextBoxNama.Text
        UmurUser = TextBoxUmur.Text
        TglLahirUser = DateTimePicker1.Value.ToLongDateString
        AlamatUser = TextBoxAlamat.Text
        TeleponUser = TextBoxTelepon.Text

        If RadioButtonPria.Checked Then
            KelaminUser = "Pria"
        ElseIf RadioButtonWanita.Checked Then
            KelaminUser = "Wanita"
        End If

        Dim daftarHobi As String = ""

        If CheckBoxGaming.Checked Then
            daftarHobi &= "Gaming "
        End If

        If CheckBoxCoding.Checked Then
            daftarHobi &= "Coding "
        End If

        If CheckBoxMemancing.Checked Then
            daftarHobi &= "Memancing "
        End If

        If CheckBoxMembaca.Checked Then
            daftarHobi &= "Membaca "
        End If

        HobiUser = daftarHobi

        Form2.Show()

    End Sub

End Class
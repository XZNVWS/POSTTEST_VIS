Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBoxNamaForm2.Text = NamaUser
        TextBoxUmurForm2.Text = UmurUser
        TextBoxTglForm2.Text = TglLahirUser
        TextBoxKelaminForm2.Text = KelaminUser
        TextBoxHobiForm2.Text = HobiUser
        TextBoxAlamatForm2.Text = AlamatUser
        TextBoxTeleponForm2.Text = TeleponUser

        TextBoxNamaForm2.ReadOnly = True
        TextBoxUmurForm2.ReadOnly = True
        TextBoxTglForm2.ReadOnly = True
        TextBoxKelaminForm2.ReadOnly = True
        TextBoxHobiForm2.ReadOnly = True
        TextBoxAlamatForm2.ReadOnly = True
        TextBoxTeleponForm2.ReadOnly = True

    End Sub

End Class
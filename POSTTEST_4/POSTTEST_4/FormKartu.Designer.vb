<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKartu))
        picHasilFoto = New PictureBox()
        lblHasilNama = New Label()
        lblHasilID = New Label()
        lblHasilKomunitas = New Label()
        lblHasilKontak = New Label()
        lblHasilHobi = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(picHasilFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picHasilFoto
        ' 
        picHasilFoto.Location = New Point(25, 26)
        picHasilFoto.Name = "picHasilFoto"
        picHasilFoto.Size = New Size(172, 139)
        picHasilFoto.SizeMode = PictureBoxSizeMode.Zoom
        picHasilFoto.TabIndex = 0
        picHasilFoto.TabStop = False
        ' 
        ' lblHasilNama
        ' 
        lblHasilNama.AutoSize = True
        lblHasilNama.BackColor = Color.Transparent
        lblHasilNama.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblHasilNama.ForeColor = SystemColors.ActiveCaptionText
        lblHasilNama.Location = New Point(230, 115)
        lblHasilNama.Name = "lblHasilNama"
        lblHasilNama.Size = New Size(275, 39)
        lblHasilNama.TabIndex = 1
        lblHasilNama.Text = "[ Nama Lengkap ]"
        ' 
        ' lblHasilID
        ' 
        lblHasilID.AutoSize = True
        lblHasilID.BackColor = Color.Transparent
        lblHasilID.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblHasilID.ForeColor = SystemColors.ActiveCaptionText
        lblHasilID.Location = New Point(230, 169)
        lblHasilID.Name = "lblHasilID"
        lblHasilID.Size = New Size(222, 39)
        lblHasilID.TabIndex = 2
        lblHasilID.Text = "[ ID Anggota ]"
        ' 
        ' lblHasilKomunitas
        ' 
        lblHasilKomunitas.AutoSize = True
        lblHasilKomunitas.BackColor = Color.Transparent
        lblHasilKomunitas.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblHasilKomunitas.ForeColor = SystemColors.ActiveCaptionText
        lblHasilKomunitas.Location = New Point(230, 222)
        lblHasilKomunitas.Name = "lblHasilKomunitas"
        lblHasilKomunitas.Size = New Size(137, 39)
        lblHasilKomunitas.TabIndex = 3
        lblHasilKomunitas.Text = "[ Divisi ]"
        ' 
        ' lblHasilKontak
        ' 
        lblHasilKontak.AutoSize = True
        lblHasilKontak.BackColor = Color.Transparent
        lblHasilKontak.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblHasilKontak.ForeColor = SystemColors.ActiveCaptionText
        lblHasilKontak.Location = New Point(230, 277)
        lblHasilKontak.Name = "lblHasilKontak"
        lblHasilKontak.Size = New Size(378, 39)
        lblHasilKontak.TabIndex = 4
        lblHasilKontak.Text = "[ Nomor Telepon & Email ]"
        ' 
        ' lblHasilHobi
        ' 
        lblHasilHobi.AutoSize = True
        lblHasilHobi.BackColor = Color.Transparent
        lblHasilHobi.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblHasilHobi.ForeColor = SystemColors.ActiveCaptionText
        lblHasilHobi.Location = New Point(230, 333)
        lblHasilHobi.Name = "lblHasilHobi"
        lblHasilHobi.Size = New Size(126, 39)
        lblHasilHobi.TabIndex = 5
        lblHasilHobi.Text = "[ Hobi ]"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(247, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(393, 50)
        Label1.TabIndex = 6
        Label1.Text = "KOMUNITAS DIGITAL"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(650, 333)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(138, 103)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(lblHasilHobi)
        Controls.Add(lblHasilKontak)
        Controls.Add(lblHasilKomunitas)
        Controls.Add(lblHasilID)
        Controls.Add(lblHasilNama)
        Controls.Add(picHasilFoto)
        Controls.Add(PictureBox1)
        Name = "FormKartu"
        Text = "FormKartu"
        CType(picHasilFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picHasilFoto As PictureBox
    Friend WithEvents lblHasilNama As Label
    Friend WithEvents lblHasilID As Label
    Friend WithEvents lblHasilKomunitas As Label
    Friend WithEvents lblHasilKontak As Label
    Friend WithEvents lblHasilHobi As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

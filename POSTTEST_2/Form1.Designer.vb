<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        ListBox1 = New ListBox()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 20)
        Label2.TabIndex = 1
        Label2.Text = "Judul Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 20)
        Label3.TabIndex = 2
        Label3.Text = "Genre"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(378, 75)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 20)
        Label5.TabIndex = 4
        Label5.Text = "Judul Buku"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(137, 123)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 5
        Button1.Text = "Tambah"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(131, 123)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 6
        Button2.Text = "Hapus"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(149, 112)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(186, 27)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(149, 72)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(186, 27)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(499, 72)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(186, 27)
        TextBox3.TabIndex = 9
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(149, 214)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(427, 224)
        ListBox1.TabIndex = 10
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonFace
        GroupBox1.Controls.Add(Button1)
        GroupBox1.ForeColor = SystemColors.ControlText
        GroupBox1.Location = New Point(12, 31)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(350, 168)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Location = New Point(368, 31)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(350, 168)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(742, 450)
        Controls.Add(ListBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox

End Class

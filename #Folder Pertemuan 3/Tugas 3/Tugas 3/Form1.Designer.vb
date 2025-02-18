<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPemesanan
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        CariMeja = New Button()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        Panel2 = New Panel()
        RadioButton9 = New RadioButton()
        RadioButton10 = New RadioButton()
        RadioButton11 = New RadioButton()
        RadioButton12 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton6 = New RadioButton()
        RadioButton7 = New RadioButton()
        RadioButton8 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Panel3 = New Panel()
        TextBox7 = New TextBox()
        Label12 = New Label()
        TextBox8 = New TextBox()
        Label13 = New Label()
        TextBox9 = New TextBox()
        Label14 = New Label()
        TextBox10 = New TextBox()
        Label15 = New Label()
        TextBox11 = New TextBox()
        Label16 = New Label()
        TextBox6 = New TextBox()
        Label11 = New Label()
        TextBox4 = New TextBox()
        Label9 = New Label()
        TextBox5 = New TextBox()
        Label10 = New Label()
        TextBox3 = New TextBox()
        Label8 = New Label()
        TextBox2 = New TextBox()
        Label7 = New Label()
        Label5 = New Label()
        KonfirmasiPesanan = New Button()
        TextBox12 = New TextBox()
        Label6 = New Label()
        Label17 = New Label()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        ComboBox4 = New ComboBox()
        ComboBox5 = New ComboBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("STFangsong", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(42, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(461, 34)
        Label1.TabIndex = 0
        Label1.Text = "PEMESANAN TEMPAT DUDUK"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 20)
        Label2.TabIndex = 1
        Label2.Text = "Jumlah Kursi Meja :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 149)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 20)
        Label3.TabIndex = 2
        Label3.Text = "Jumlah Tamu :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(159, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(183, 20)
        Label4.TabIndex = 3
        Label4.Text = "Daftar Meja yang Tersedia"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(ComboBox5)
        Panel1.Controls.Add(Label20)
        Panel1.Controls.Add(ComboBox4)
        Panel1.Controls.Add(Label19)
        Panel1.Controls.Add(ComboBox3)
        Panel1.Controls.Add(Label18)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(TextBox12)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(CariMeja)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(20, 65)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(484, 198)
        Panel1.TabIndex = 4
        ' 
        ' CariMeja
        ' 
        CariMeja.FlatStyle = FlatStyle.System
        CariMeja.Location = New Point(361, 146)
        CariMeja.Name = "CariMeja"
        CariMeja.Size = New Size(106, 27)
        CariMeja.TabIndex = 8
        CariMeja.Text = "Cari Meja"
        CariMeja.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(159, 146)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(194, 27)
        TextBox1.TabIndex = 8
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", ">= 5"})
        ComboBox1.Location = New Point(159, 112)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(308, 28)
        ComboBox1.TabIndex = 7
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(RadioButton9)
        Panel2.Controls.Add(RadioButton10)
        Panel2.Controls.Add(RadioButton11)
        Panel2.Controls.Add(RadioButton12)
        Panel2.Controls.Add(RadioButton5)
        Panel2.Controls.Add(RadioButton6)
        Panel2.Controls.Add(RadioButton7)
        Panel2.Controls.Add(RadioButton8)
        Panel2.Controls.Add(RadioButton4)
        Panel2.Controls.Add(RadioButton3)
        Panel2.Controls.Add(RadioButton2)
        Panel2.Controls.Add(RadioButton1)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(20, 269)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(484, 187)
        Panel2.TabIndex = 5
        ' 
        ' RadioButton9
        ' 
        RadioButton9.AutoSize = True
        RadioButton9.Location = New Point(315, 133)
        RadioButton9.Name = "RadioButton9"
        RadioButton9.Size = New Size(141, 24)
        RadioButton9.TabIndex = 17
        RadioButton9.TabStop = True
        RadioButton9.Text = "Meja 12 - 8 Kursi"
        RadioButton9.UseVisualStyleBackColor = True
        ' 
        ' RadioButton10
        ' 
        RadioButton10.AutoSize = True
        RadioButton10.Location = New Point(315, 103)
        RadioButton10.Name = "RadioButton10"
        RadioButton10.Size = New Size(141, 24)
        RadioButton10.TabIndex = 16
        RadioButton10.TabStop = True
        RadioButton10.Text = "Meja 11 - 8 Kursi"
        RadioButton10.UseVisualStyleBackColor = True
        ' 
        ' RadioButton11
        ' 
        RadioButton11.AutoSize = True
        RadioButton11.Location = New Point(315, 73)
        RadioButton11.Name = "RadioButton11"
        RadioButton11.Size = New Size(141, 24)
        RadioButton11.TabIndex = 15
        RadioButton11.TabStop = True
        RadioButton11.Text = "Meja 10 - 6 Kursi"
        RadioButton11.UseVisualStyleBackColor = True
        ' 
        ' RadioButton12
        ' 
        RadioButton12.AutoSize = True
        RadioButton12.Location = New Point(315, 43)
        RadioButton12.Name = "RadioButton12"
        RadioButton12.Size = New Size(133, 24)
        RadioButton12.TabIndex = 14
        RadioButton12.TabStop = True
        RadioButton12.Text = "Meja 9 - 6 Kursi"
        RadioButton12.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(168, 133)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(133, 24)
        RadioButton5.TabIndex = 13
        RadioButton5.TabStop = True
        RadioButton5.Text = "Meja 8 - 2 Kursi"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Location = New Point(168, 103)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(133, 24)
        RadioButton6.TabIndex = 12
        RadioButton6.TabStop = True
        RadioButton6.Text = "Meja 7 - 2 Kursi"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.Location = New Point(168, 73)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(133, 24)
        RadioButton7.TabIndex = 11
        RadioButton7.TabStop = True
        RadioButton7.Text = "Meja 6 - 2 Kursi"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' RadioButton8
        ' 
        RadioButton8.AutoSize = True
        RadioButton8.Location = New Point(168, 43)
        RadioButton8.Name = "RadioButton8"
        RadioButton8.Size = New Size(133, 24)
        RadioButton8.TabIndex = 10
        RadioButton8.TabStop = True
        RadioButton8.Text = "Meja 5 - 2 Kursi"
        RadioButton8.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(22, 133)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(133, 24)
        RadioButton4.TabIndex = 9
        RadioButton4.TabStop = True
        RadioButton4.Text = "Meja 4 - 4 Kursi"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(22, 103)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(133, 24)
        RadioButton3.TabIndex = 8
        RadioButton3.TabStop = True
        RadioButton3.Text = "Meja 3 - 4 Kursi"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(22, 73)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(133, 24)
        RadioButton2.TabIndex = 7
        RadioButton2.TabStop = True
        RadioButton2.Text = "Meja 2 - 4 Kursi"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(22, 43)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(133, 24)
        RadioButton1.TabIndex = 6
        RadioButton1.TabStop = True
        RadioButton1.Text = "Meja 1 - 4 Kursi"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(TextBox7)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(TextBox8)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(TextBox9)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(TextBox10)
        Panel3.Controls.Add(Label15)
        Panel3.Controls.Add(TextBox11)
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(TextBox6)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(TextBox4)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(TextBox5)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(TextBox3)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(20, 462)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(484, 215)
        Panel3.TabIndex = 6
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(423, 177)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(34, 27)
        TextBox7.TabIndex = 27
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(261, 181)
        Label12.Name = "Label12"
        Label12.Size = New Size(61, 20)
        Label12.TabIndex = 26
        Label12.Text = "Pempek"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(423, 144)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(34, 27)
        TextBox8.TabIndex = 25
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(261, 148)
        Label13.Name = "Label13"
        Label13.Size = New Size(106, 20)
        Label13.TabIndex = 24
        Label13.Text = "Coto Makassar"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(423, 110)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(34, 27)
        TextBox9.TabIndex = 23
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(261, 114)
        Label14.Name = "Label14"
        Label14.Size = New Size(60, 20)
        Label14.TabIndex = 22
        Label14.Text = "Sop Iga"
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(423, 77)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(34, 27)
        TextBox10.TabIndex = 21
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(261, 81)
        Label15.Name = "Label15"
        Label15.Size = New Size(40, 20)
        Label15.TabIndex = 20
        Label15.Text = "Soto"
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(423, 43)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(34, 27)
        TextBox11.TabIndex = 19
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(261, 47)
        Label16.Name = "Label16"
        Label16.Size = New Size(151, 20)
        Label16.TabIndex = 18
        Label16.Text = "Ayam Goreng Spesial"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(184, 177)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(34, 27)
        TextBox6.TabIndex = 17
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(22, 181)
        Label11.Name = "Label11"
        Label11.Size = New Size(65, 20)
        Label11.TabIndex = 16
        Label11.Text = "Sup Ikan"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(184, 144)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(34, 27)
        TextBox4.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(22, 148)
        Label9.Name = "Label9"
        Label9.Size = New Size(87, 20)
        Label9.TabIndex = 14
        Label9.Text = "Mie Goreng"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(184, 110)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(34, 27)
        TextBox5.TabIndex = 13
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(22, 114)
        Label10.Name = "Label10"
        Label10.Size = New Size(80, 20)
        Label10.TabIndex = 12
        Label10.Text = "Sate Ayam"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(184, 77)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(34, 27)
        TextBox3.TabIndex = 11
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(22, 80)
        Label8.Name = "Label8"
        Label8.Size = New Size(88, 20)
        Label8.TabIndex = 10
        Label8.Text = "Ayam Bakar"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(184, 43)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(34, 27)
        TextBox2.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(22, 46)
        Label7.Name = "Label7"
        Label7.Size = New Size(142, 20)
        Label7.TabIndex = 4
        Label7.Text = "Nasi Goreng Spesial"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(169, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(156, 20)
        Label5.TabIndex = 3
        Label5.Text = "Daftar Menu Makanan"
        ' 
        ' KonfirmasiPesanan
        ' 
        KonfirmasiPesanan.FlatStyle = FlatStyle.System
        KonfirmasiPesanan.Location = New Point(20, 683)
        KonfirmasiPesanan.Name = "KonfirmasiPesanan"
        KonfirmasiPesanan.Size = New Size(484, 58)
        KonfirmasiPesanan.TabIndex = 7
        KonfirmasiPesanan.Text = "Konfirmasi Pesanan"
        KonfirmasiPesanan.UseVisualStyleBackColor = True
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(159, 13)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(308, 27)
        TextBox12.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(22, 16)
        Label6.Name = "Label6"
        Label6.Size = New Size(95, 20)
        Label6.TabIndex = 9
        Label6.Text = "Nama Tamu :"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(22, 51)
        Label17.Name = "Label17"
        Label17.Size = New Size(68, 20)
        Label17.TabIndex = 11
        Label17.Text = "Tanggal :"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        ComboBox2.Location = New Point(159, 48)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(59, 28)
        ComboBox2.TabIndex = 12
        ComboBox2.Text = "DD"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"10:00", "12:00", "14:00", "16:00", "18:00", "20:00"})
        ComboBox3.Location = New Point(159, 79)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(80, 28)
        ComboBox3.TabIndex = 14
        ComboBox3.Text = "00:00"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(22, 82)
        Label18.Name = "Label18"
        Label18.Size = New Size(57, 20)
        Label18.TabIndex = 13
        Label18.Text = "Waktu :"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(224, 51)
        Label19.Name = "Label19"
        Label19.Size = New Size(15, 20)
        Label19.TabIndex = 15
        Label19.Text = "/"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(307, 51)
        Label20.Name = "Label20"
        Label20.Size = New Size(15, 20)
        Label20.TabIndex = 17
        Label20.Text = "/"
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        ComboBox4.Location = New Point(242, 48)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(59, 28)
        ComboBox4.TabIndex = 16
        ComboBox4.Text = "MM"
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Items.AddRange(New Object() {"2025"})
        ComboBox5.Location = New Point(328, 48)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(59, 28)
        ComboBox5.TabIndex = 18
        ComboBox5.Text = "YYYY"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.png_transparent_star_golden_stars_angle_3d_computer_graphics_symmetry_thumbnail
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(116, 78)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(24, 23)
        PictureBox1.TabIndex = 28
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.png_transparent_star_golden_stars_angle_3d_computer_graphics_symmetry_thumbnail
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(327, 114)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(24, 23)
        PictureBox2.TabIndex = 29
        PictureBox2.TabStop = False
        ' 
        ' FormPemesanan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(518, 761)
        Controls.Add(KonfirmasiPesanan)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "FormPemesanan"
        Text = "Form Pemesanan"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents KonfirmasiPesanan As Button
    Friend WithEvents CariMeja As Button
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox

End Class

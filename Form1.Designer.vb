<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ButtonKomis1 = New System.Windows.Forms.Button()
        Me.ButtonKomis2 = New System.Windows.Forms.Button()
        Me.DataGridViewKomis = New System.Windows.Forms.DataGridView()
        Me.BindingSourceKomis1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Komis1DataSet = New Komis12.Komis1DataSet()
        Me.BindingSourceKomis2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Komis2DataSet = New Komis12.Komis2DataSet()
        Me.ButtonKomis3 = New System.Windows.Forms.Button()
        Me.BindingSourceKomis3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Komis3DataSet = New Komis12.Komis3DataSet()
        Me.TextBoxMarka = New System.Windows.Forms.TextBox()
        Me.TextBoxModel = New System.Windows.Forms.TextBox()
        Me.TextBoxRok = New System.Windows.Forms.TextBox()
        Me.TextBoxSilnik = New System.Windows.Forms.TextBox()
        Me.TextBoxLakier = New System.Windows.Forms.TextBox()
        Me.TextBoxCena = New System.Windows.Forms.TextBox()
        Me.LabelMarka = New System.Windows.Forms.Label()
        Me.LabelModel = New System.Windows.Forms.Label()
        Me.LabelRok = New System.Windows.Forms.Label()
        Me.LabelSilnik = New System.Windows.Forms.Label()
        Me.LabelLakier = New System.Windows.Forms.Label()
        Me.LabelCena = New System.Windows.Forms.Label()
        Me.CheckBoxMetalic = New System.Windows.Forms.CheckBox()
        Me.ButtonDodaj = New System.Windows.Forms.Button()
        Me.ButtonEdytuj = New System.Windows.Forms.Button()
        Me.ButtonZapiszDodaj = New System.Windows.Forms.Button()
        Me.ButtonAnuluj = New System.Windows.Forms.Button()
        Me.ButtonUsun = New System.Windows.Forms.Button()
        Me.PictureBoxMini = New System.Windows.Forms.PictureBox()
        Me.ButtonPierwszy = New System.Windows.Forms.Button()
        Me.ButtonPoprzedni = New System.Windows.Forms.Button()
        Me.ButtonNastepny = New System.Windows.Forms.Button()
        Me.ButtonOstatni = New System.Windows.Forms.Button()
        Me.ButtonZaloguj = New System.Windows.Forms.Button()
        Me.LabelRekord = New System.Windows.Forms.Label()
        Me.TextBoxKtory = New System.Windows.Forms.TextBox()
        Me.TextBoxIle = New System.Windows.Forms.TextBox()
        Me.LabelZ = New System.Windows.Forms.Label()
        Me.ButtonWybierz = New System.Windows.Forms.Button()
        Me.TabelaTableAdapter = New Komis12.Komis1DataSetTableAdapters.TabelaTableAdapter()
        Me.TabelaTableAdapter1 = New Komis12.Komis2DataSetTableAdapters.TabelaTableAdapter()
        Me.TabelaTableAdapter2 = New Komis12.Komis3DataSetTableAdapters.TabelaTableAdapter()
        Me.TextBoxFoto = New System.Windows.Forms.TextBox()
        Me.ButtonKomis4 = New System.Windows.Forms.Button()
        Me.TextBoxHaslo = New System.Windows.Forms.TextBox()
        Me.LabelHaslo = New System.Windows.Forms.Label()
        Me.LabelHasloAdm = New System.Windows.Forms.Label()
        Me.TextBoxHasloAdm = New System.Windows.Forms.TextBox()
        Me.ButtonWyloguj = New System.Windows.Forms.Button()
        Me.LabelFoto = New System.Windows.Forms.Label()
        Me.LabelId = New System.Windows.Forms.Label()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.ButtonZapiszEdytuj = New System.Windows.Forms.Button()
        CType(Me.DataGridViewKomis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceKomis1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Komis1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceKomis2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Komis2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceKomis3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Komis3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonKomis1
        '
        Me.ButtonKomis1.Location = New System.Drawing.Point(894, 13)
        Me.ButtonKomis1.Name = "ButtonKomis1"
        Me.ButtonKomis1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonKomis1.TabIndex = 0
        Me.ButtonKomis1.Text = "Komis 1"
        Me.ButtonKomis1.UseVisualStyleBackColor = True
        '
        'ButtonKomis2
        '
        Me.ButtonKomis2.Location = New System.Drawing.Point(894, 43)
        Me.ButtonKomis2.Name = "ButtonKomis2"
        Me.ButtonKomis2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonKomis2.TabIndex = 1
        Me.ButtonKomis2.Text = "Komis 2"
        Me.ButtonKomis2.UseVisualStyleBackColor = True
        '
        'DataGridViewKomis
        '
        Me.DataGridViewKomis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKomis.Location = New System.Drawing.Point(13, 13)
        Me.DataGridViewKomis.Name = "DataGridViewKomis"
        Me.DataGridViewKomis.Size = New System.Drawing.Size(845, 147)
        Me.DataGridViewKomis.TabIndex = 2
        '
        'BindingSourceKomis1
        '
        Me.BindingSourceKomis1.DataMember = "Tabela"
        Me.BindingSourceKomis1.DataSource = Me.Komis1DataSet
        '
        'Komis1DataSet
        '
        Me.Komis1DataSet.DataSetName = "Komis1DataSet"
        Me.Komis1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSourceKomis2
        '
        Me.BindingSourceKomis2.DataMember = "Tabela"
        Me.BindingSourceKomis2.DataSource = Me.Komis2DataSet
        '
        'Komis2DataSet
        '
        Me.Komis2DataSet.DataSetName = "Komis2DataSet"
        Me.Komis2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonKomis3
        '
        Me.ButtonKomis3.Location = New System.Drawing.Point(894, 73)
        Me.ButtonKomis3.Name = "ButtonKomis3"
        Me.ButtonKomis3.Size = New System.Drawing.Size(75, 23)
        Me.ButtonKomis3.TabIndex = 3
        Me.ButtonKomis3.Text = "Komis 3"
        Me.ButtonKomis3.UseVisualStyleBackColor = True
        '
        'BindingSourceKomis3
        '
        Me.BindingSourceKomis3.DataMember = "Tabela"
        Me.BindingSourceKomis3.DataSource = Me.Komis3DataSet
        '
        'Komis3DataSet
        '
        Me.Komis3DataSet.DataSetName = "Komis3DataSet"
        Me.Komis3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBoxMarka
        '
        Me.TextBoxMarka.Location = New System.Drawing.Point(109, 185)
        Me.TextBoxMarka.Name = "TextBoxMarka"
        Me.TextBoxMarka.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMarka.TabIndex = 4
        '
        'TextBoxModel
        '
        Me.TextBoxModel.Location = New System.Drawing.Point(109, 212)
        Me.TextBoxModel.Name = "TextBoxModel"
        Me.TextBoxModel.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxModel.TabIndex = 5
        '
        'TextBoxRok
        '
        Me.TextBoxRok.Location = New System.Drawing.Point(109, 239)
        Me.TextBoxRok.Name = "TextBoxRok"
        Me.TextBoxRok.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxRok.TabIndex = 6
        '
        'TextBoxSilnik
        '
        Me.TextBoxSilnik.Location = New System.Drawing.Point(109, 266)
        Me.TextBoxSilnik.Name = "TextBoxSilnik"
        Me.TextBoxSilnik.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSilnik.TabIndex = 7
        '
        'TextBoxLakier
        '
        Me.TextBoxLakier.Location = New System.Drawing.Point(109, 293)
        Me.TextBoxLakier.Name = "TextBoxLakier"
        Me.TextBoxLakier.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLakier.TabIndex = 8
        '
        'TextBoxCena
        '
        Me.TextBoxCena.Location = New System.Drawing.Point(109, 343)
        Me.TextBoxCena.Name = "TextBoxCena"
        Me.TextBoxCena.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCena.TabIndex = 9
        '
        'LabelMarka
        '
        Me.LabelMarka.AutoSize = True
        Me.LabelMarka.Location = New System.Drawing.Point(10, 188)
        Me.LabelMarka.Name = "LabelMarka"
        Me.LabelMarka.Size = New System.Drawing.Size(37, 13)
        Me.LabelMarka.TabIndex = 10
        Me.LabelMarka.Text = "Marka"
        '
        'LabelModel
        '
        Me.LabelModel.AutoSize = True
        Me.LabelModel.Location = New System.Drawing.Point(10, 215)
        Me.LabelModel.Name = "LabelModel"
        Me.LabelModel.Size = New System.Drawing.Size(36, 13)
        Me.LabelModel.TabIndex = 11
        Me.LabelModel.Text = "Model"
        '
        'LabelRok
        '
        Me.LabelRok.AutoSize = True
        Me.LabelRok.Location = New System.Drawing.Point(10, 242)
        Me.LabelRok.Name = "LabelRok"
        Me.LabelRok.Size = New System.Drawing.Size(73, 13)
        Me.LabelRok.TabIndex = 12
        Me.LabelRok.Text = "Rok produkcji"
        '
        'LabelSilnik
        '
        Me.LabelSilnik.AutoSize = True
        Me.LabelSilnik.Location = New System.Drawing.Point(10, 269)
        Me.LabelSilnik.Name = "LabelSilnik"
        Me.LabelSilnik.Size = New System.Drawing.Size(91, 13)
        Me.LabelSilnik.TabIndex = 13
        Me.LabelSilnik.Text = "Pojemność silnika"
        '
        'LabelLakier
        '
        Me.LabelLakier.AutoSize = True
        Me.LabelLakier.Location = New System.Drawing.Point(10, 296)
        Me.LabelLakier.Name = "LabelLakier"
        Me.LabelLakier.Size = New System.Drawing.Size(65, 13)
        Me.LabelLakier.TabIndex = 14
        Me.LabelLakier.Text = "Kolor lakieru"
        '
        'LabelCena
        '
        Me.LabelCena.AutoSize = True
        Me.LabelCena.Location = New System.Drawing.Point(10, 346)
        Me.LabelCena.Name = "LabelCena"
        Me.LabelCena.Size = New System.Drawing.Size(32, 13)
        Me.LabelCena.TabIndex = 15
        Me.LabelCena.Text = "Cena"
        '
        'CheckBoxMetalic
        '
        Me.CheckBoxMetalic.AutoSize = True
        Me.CheckBoxMetalic.Location = New System.Drawing.Point(13, 318)
        Me.CheckBoxMetalic.Name = "CheckBoxMetalic"
        Me.CheckBoxMetalic.Size = New System.Drawing.Size(60, 17)
        Me.CheckBoxMetalic.TabIndex = 16
        Me.CheckBoxMetalic.Text = "Metalic"
        Me.CheckBoxMetalic.UseVisualStyleBackColor = True
        '
        'ButtonDodaj
        '
        Me.ButtonDodaj.Location = New System.Drawing.Point(894, 242)
        Me.ButtonDodaj.Name = "ButtonDodaj"
        Me.ButtonDodaj.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDodaj.TabIndex = 17
        Me.ButtonDodaj.Text = "Dodaj"
        Me.ButtonDodaj.UseVisualStyleBackColor = True
        '
        'ButtonEdytuj
        '
        Me.ButtonEdytuj.Location = New System.Drawing.Point(894, 272)
        Me.ButtonEdytuj.Name = "ButtonEdytuj"
        Me.ButtonEdytuj.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdytuj.TabIndex = 18
        Me.ButtonEdytuj.Text = "Edytuj"
        Me.ButtonEdytuj.UseVisualStyleBackColor = True
        '
        'ButtonZapiszDodaj
        '
        Me.ButtonZapiszDodaj.Location = New System.Drawing.Point(813, 243)
        Me.ButtonZapiszDodaj.Name = "ButtonZapiszDodaj"
        Me.ButtonZapiszDodaj.Size = New System.Drawing.Size(75, 23)
        Me.ButtonZapiszDodaj.TabIndex = 19
        Me.ButtonZapiszDodaj.Text = "Zapisz"
        Me.ButtonZapiszDodaj.UseVisualStyleBackColor = True
        '
        'ButtonAnuluj
        '
        Me.ButtonAnuluj.Location = New System.Drawing.Point(894, 301)
        Me.ButtonAnuluj.Name = "ButtonAnuluj"
        Me.ButtonAnuluj.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAnuluj.TabIndex = 20
        Me.ButtonAnuluj.Text = "Anuluj"
        Me.ButtonAnuluj.UseVisualStyleBackColor = True
        '
        'ButtonUsun
        '
        Me.ButtonUsun.Location = New System.Drawing.Point(894, 331)
        Me.ButtonUsun.Name = "ButtonUsun"
        Me.ButtonUsun.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUsun.TabIndex = 21
        Me.ButtonUsun.Text = "Usuń"
        Me.ButtonUsun.UseVisualStyleBackColor = True
        '
        'PictureBoxMini
        '
        Me.PictureBoxMini.Location = New System.Drawing.Point(245, 185)
        Me.PictureBoxMini.Name = "PictureBoxMini"
        Me.PictureBoxMini.Size = New System.Drawing.Size(508, 233)
        Me.PictureBoxMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxMini.TabIndex = 22
        Me.PictureBoxMini.TabStop = False
        '
        'ButtonPierwszy
        '
        Me.ButtonPierwszy.Location = New System.Drawing.Point(296, 478)
        Me.ButtonPierwszy.Name = "ButtonPierwszy"
        Me.ButtonPierwszy.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPierwszy.TabIndex = 23
        Me.ButtonPierwszy.Text = "<<"
        Me.ButtonPierwszy.UseVisualStyleBackColor = True
        '
        'ButtonPoprzedni
        '
        Me.ButtonPoprzedni.Location = New System.Drawing.Point(401, 478)
        Me.ButtonPoprzedni.Name = "ButtonPoprzedni"
        Me.ButtonPoprzedni.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPoprzedni.TabIndex = 24
        Me.ButtonPoprzedni.Text = "<"
        Me.ButtonPoprzedni.UseVisualStyleBackColor = True
        '
        'ButtonNastepny
        '
        Me.ButtonNastepny.Location = New System.Drawing.Point(507, 478)
        Me.ButtonNastepny.Name = "ButtonNastepny"
        Me.ButtonNastepny.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNastepny.TabIndex = 25
        Me.ButtonNastepny.Text = ">"
        Me.ButtonNastepny.UseVisualStyleBackColor = True
        '
        'ButtonOstatni
        '
        Me.ButtonOstatni.Location = New System.Drawing.Point(616, 478)
        Me.ButtonOstatni.Name = "ButtonOstatni"
        Me.ButtonOstatni.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOstatni.TabIndex = 26
        Me.ButtonOstatni.Text = ">>"
        Me.ButtonOstatni.UseVisualStyleBackColor = True
        '
        'ButtonZaloguj
        '
        Me.ButtonZaloguj.Location = New System.Drawing.Point(894, 360)
        Me.ButtonZaloguj.Name = "ButtonZaloguj"
        Me.ButtonZaloguj.Size = New System.Drawing.Size(75, 23)
        Me.ButtonZaloguj.TabIndex = 27
        Me.ButtonZaloguj.Text = "Zaloguj"
        Me.ButtonZaloguj.UseVisualStyleBackColor = True
        '
        'LabelRekord
        '
        Me.LabelRekord.AutoSize = True
        Me.LabelRekord.Location = New System.Drawing.Point(360, 436)
        Me.LabelRekord.Name = "LabelRekord"
        Me.LabelRekord.Size = New System.Drawing.Size(42, 13)
        Me.LabelRekord.TabIndex = 28
        Me.LabelRekord.Text = "Rekord"
        '
        'TextBoxKtory
        '
        Me.TextBoxKtory.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBoxKtory.Location = New System.Drawing.Point(409, 433)
        Me.TextBoxKtory.Name = "TextBoxKtory"
        Me.TextBoxKtory.Size = New System.Drawing.Size(30, 20)
        Me.TextBoxKtory.TabIndex = 29
        Me.TextBoxKtory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxIle
        '
        Me.TextBoxIle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBoxIle.Location = New System.Drawing.Point(476, 433)
        Me.TextBoxIle.Name = "TextBoxIle"
        Me.TextBoxIle.Size = New System.Drawing.Size(30, 20)
        Me.TextBoxIle.TabIndex = 30
        Me.TextBoxIle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelZ
        '
        Me.LabelZ.AutoSize = True
        Me.LabelZ.Location = New System.Drawing.Point(452, 436)
        Me.LabelZ.Name = "LabelZ"
        Me.LabelZ.Size = New System.Drawing.Size(12, 13)
        Me.LabelZ.TabIndex = 31
        Me.LabelZ.Text = "z"
        '
        'ButtonWybierz
        '
        Me.ButtonWybierz.Location = New System.Drawing.Point(530, 431)
        Me.ButtonWybierz.Name = "ButtonWybierz"
        Me.ButtonWybierz.Size = New System.Drawing.Size(75, 23)
        Me.ButtonWybierz.TabIndex = 32
        Me.ButtonWybierz.Text = "Wybierz"
        Me.ButtonWybierz.UseVisualStyleBackColor = True
        '
        'TabelaTableAdapter
        '
        Me.TabelaTableAdapter.ClearBeforeFill = True
        '
        'TabelaTableAdapter1
        '
        Me.TabelaTableAdapter1.ClearBeforeFill = True
        '
        'TabelaTableAdapter2
        '
        Me.TabelaTableAdapter2.ClearBeforeFill = True
        '
        'TextBoxFoto
        '
        Me.TextBoxFoto.Location = New System.Drawing.Point(109, 369)
        Me.TextBoxFoto.Name = "TextBoxFoto"
        Me.TextBoxFoto.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxFoto.TabIndex = 33
        '
        'ButtonKomis4
        '
        Me.ButtonKomis4.Location = New System.Drawing.Point(894, 102)
        Me.ButtonKomis4.Name = "ButtonKomis4"
        Me.ButtonKomis4.Size = New System.Drawing.Size(75, 23)
        Me.ButtonKomis4.TabIndex = 34
        Me.ButtonKomis4.Text = "Komis 4"
        Me.ButtonKomis4.UseVisualStyleBackColor = True
        '
        'TextBoxHaslo
        '
        Me.TextBoxHaslo.Location = New System.Drawing.Point(875, 181)
        Me.TextBoxHaslo.Name = "TextBoxHaslo"
        Me.TextBoxHaslo.Size = New System.Drawing.Size(117, 20)
        Me.TextBoxHaslo.TabIndex = 35
        '
        'LabelHaslo
        '
        Me.LabelHaslo.AutoSize = True
        Me.LabelHaslo.Location = New System.Drawing.Point(872, 152)
        Me.LabelHaslo.Name = "LabelHaslo"
        Me.LabelHaslo.Size = New System.Drawing.Size(114, 26)
        Me.LabelHaslo.TabIndex = 36
        Me.LabelHaslo.Text = "Hasło do bazy danych" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Komis 4:"
        '
        'LabelHasloAdm
        '
        Me.LabelHasloAdm.AutoSize = True
        Me.LabelHasloAdm.Location = New System.Drawing.Point(872, 402)
        Me.LabelHasloAdm.Name = "LabelHasloAdm"
        Me.LabelHasloAdm.Size = New System.Drawing.Size(91, 26)
        Me.LabelHasloAdm.TabIndex = 37
        Me.LabelHasloAdm.Text = "Hasło do panelu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "administracyjnego"
        '
        'TextBoxHasloAdm
        '
        Me.TextBoxHasloAdm.Location = New System.Drawing.Point(875, 431)
        Me.TextBoxHasloAdm.Name = "TextBoxHasloAdm"
        Me.TextBoxHasloAdm.Size = New System.Drawing.Size(117, 20)
        Me.TextBoxHasloAdm.TabIndex = 38
        '
        'ButtonWyloguj
        '
        Me.ButtonWyloguj.Location = New System.Drawing.Point(894, 213)
        Me.ButtonWyloguj.Name = "ButtonWyloguj"
        Me.ButtonWyloguj.Size = New System.Drawing.Size(75, 23)
        Me.ButtonWyloguj.TabIndex = 39
        Me.ButtonWyloguj.Text = "Wyloguj"
        Me.ButtonWyloguj.UseVisualStyleBackColor = True
        '
        'LabelFoto
        '
        Me.LabelFoto.AutoSize = True
        Me.LabelFoto.Location = New System.Drawing.Point(10, 369)
        Me.LabelFoto.Name = "LabelFoto"
        Me.LabelFoto.Size = New System.Drawing.Size(28, 13)
        Me.LabelFoto.TabIndex = 40
        Me.LabelFoto.Text = "Foto"
        '
        'LabelId
        '
        Me.LabelId.AutoSize = True
        Me.LabelId.Location = New System.Drawing.Point(10, 395)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(16, 13)
        Me.LabelId.TabIndex = 41
        Me.LabelId.Text = "Id"
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(109, 395)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxId.TabIndex = 42
        '
        'ButtonZapiszEdytuj
        '
        Me.ButtonZapiszEdytuj.Location = New System.Drawing.Point(813, 272)
        Me.ButtonZapiszEdytuj.Name = "ButtonZapiszEdytuj"
        Me.ButtonZapiszEdytuj.Size = New System.Drawing.Size(75, 23)
        Me.ButtonZapiszEdytuj.TabIndex = 43
        Me.ButtonZapiszEdytuj.Text = "Zapisz"
        Me.ButtonZapiszEdytuj.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 515)
        Me.Controls.Add(Me.ButtonZapiszEdytuj)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.LabelId)
        Me.Controls.Add(Me.LabelFoto)
        Me.Controls.Add(Me.ButtonWyloguj)
        Me.Controls.Add(Me.TextBoxHasloAdm)
        Me.Controls.Add(Me.LabelHasloAdm)
        Me.Controls.Add(Me.LabelHaslo)
        Me.Controls.Add(Me.TextBoxHaslo)
        Me.Controls.Add(Me.ButtonKomis4)
        Me.Controls.Add(Me.TextBoxFoto)
        Me.Controls.Add(Me.ButtonWybierz)
        Me.Controls.Add(Me.LabelZ)
        Me.Controls.Add(Me.TextBoxIle)
        Me.Controls.Add(Me.TextBoxKtory)
        Me.Controls.Add(Me.LabelRekord)
        Me.Controls.Add(Me.ButtonZaloguj)
        Me.Controls.Add(Me.ButtonOstatni)
        Me.Controls.Add(Me.ButtonNastepny)
        Me.Controls.Add(Me.ButtonPoprzedni)
        Me.Controls.Add(Me.ButtonPierwszy)
        Me.Controls.Add(Me.PictureBoxMini)
        Me.Controls.Add(Me.ButtonUsun)
        Me.Controls.Add(Me.ButtonAnuluj)
        Me.Controls.Add(Me.ButtonZapiszDodaj)
        Me.Controls.Add(Me.ButtonEdytuj)
        Me.Controls.Add(Me.ButtonDodaj)
        Me.Controls.Add(Me.CheckBoxMetalic)
        Me.Controls.Add(Me.LabelCena)
        Me.Controls.Add(Me.LabelLakier)
        Me.Controls.Add(Me.LabelSilnik)
        Me.Controls.Add(Me.LabelRok)
        Me.Controls.Add(Me.LabelModel)
        Me.Controls.Add(Me.LabelMarka)
        Me.Controls.Add(Me.TextBoxCena)
        Me.Controls.Add(Me.TextBoxLakier)
        Me.Controls.Add(Me.TextBoxSilnik)
        Me.Controls.Add(Me.TextBoxRok)
        Me.Controls.Add(Me.TextBoxModel)
        Me.Controls.Add(Me.TextBoxMarka)
        Me.Controls.Add(Me.ButtonKomis3)
        Me.Controls.Add(Me.DataGridViewKomis)
        Me.Controls.Add(Me.ButtonKomis2)
        Me.Controls.Add(Me.ButtonKomis1)
        Me.Name = "Form1"
        Me.Text = "Przeglądarka ofert samochodów"
        CType(Me.DataGridViewKomis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceKomis1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Komis1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceKomis2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Komis2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceKomis3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Komis3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonKomis1 As Button
    Friend WithEvents ButtonKomis2 As Button
    Friend WithEvents DataGridViewKomis As DataGridView
    Friend WithEvents BindingSourceKomis1 As BindingSource
    Friend WithEvents BindingSourceKomis2 As BindingSource
    Friend WithEvents ButtonKomis3 As Button
    Friend WithEvents BindingSourceKomis3 As BindingSource
    Friend WithEvents TextBoxMarka As TextBox
    Friend WithEvents TextBoxModel As TextBox
    Friend WithEvents TextBoxRok As TextBox
    Friend WithEvents TextBoxSilnik As TextBox
    Friend WithEvents TextBoxLakier As TextBox
    Friend WithEvents TextBoxCena As TextBox
    Friend WithEvents LabelMarka As Label
    Friend WithEvents LabelModel As Label
    Friend WithEvents LabelRok As Label
    Friend WithEvents LabelSilnik As Label
    Friend WithEvents LabelLakier As Label
    Friend WithEvents LabelCena As Label
    Friend WithEvents CheckBoxMetalic As CheckBox
    Friend WithEvents ButtonDodaj As Button
    Friend WithEvents ButtonEdytuj As Button
    Friend WithEvents ButtonZapiszDodaj As Button
    Friend WithEvents ButtonAnuluj As Button
    Friend WithEvents ButtonUsun As Button
    Friend WithEvents PictureBoxMini As PictureBox
    Friend WithEvents ButtonPierwszy As Button
    Friend WithEvents ButtonPoprzedni As Button
    Friend WithEvents ButtonNastepny As Button
    Friend WithEvents ButtonOstatni As Button
    Friend WithEvents ButtonZaloguj As Button
    Friend WithEvents LabelRekord As Label
    Friend WithEvents TextBoxKtory As TextBox
    Friend WithEvents TextBoxIle As TextBox
    Friend WithEvents LabelZ As Label
    Friend WithEvents ButtonWybierz As Button
    Friend WithEvents Komis1DataSet As Komis1DataSet
    Friend WithEvents TabelaTableAdapter As Komis1DataSetTableAdapters.TabelaTableAdapter
    Friend WithEvents Komis2DataSet As Komis2DataSet
    Friend WithEvents TabelaTableAdapter1 As Komis2DataSetTableAdapters.TabelaTableAdapter
    Friend WithEvents Komis3DataSet As Komis3DataSet
    Friend WithEvents TabelaTableAdapter2 As Komis3DataSetTableAdapters.TabelaTableAdapter
    Friend WithEvents TextBoxFoto As TextBox
    Friend WithEvents ButtonKomis4 As Button
    Friend WithEvents TextBoxHaslo As TextBox
    Friend WithEvents LabelHaslo As Label
    Friend WithEvents LabelHasloAdm As Label
    Friend WithEvents TextBoxHasloAdm As TextBox
    Friend WithEvents ButtonWyloguj As Button
    Friend WithEvents LabelFoto As Label
    Friend WithEvents LabelId As Label
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents ButtonZapiszEdytuj As Button
End Class

Imports MySql.Data.MySqlClient

Public Class Form1
    Dim actdb As String
    Dim oleconn As New OleDb.OleDbConnection
    Dim conn As New MySqlConnection
    Dim db As String = "dbName"
    Dim server As String = "serverName"
    Dim user As String = "userName"
    Dim pass As String
	Dim passAdm = "1234"
    Dim ds As New DataSet()
    Dim da As New MySqlDataAdapter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TabelaTableAdapter2.Fill(Me.Komis3DataSet.Tabela)
        Me.TabelaTableAdapter1.Fill(Me.Komis2DataSet.Tabela)
        Me.TabelaTableAdapter.Fill(Me.Komis1DataSet.Tabela)
        UkryjPrzyciskiAdm()
        ButtonZapiszDodaj.Enabled = False
        ButtonZapiszEdytuj.Enabled = False
        ButtonAnuluj.Enabled = False
        UkryjLogowanie()
        ZablokujPrzyciskiNawigacji()
        ZablokujTextboxy()
        LabelFoto.Visible = False
        TextBoxFoto.Visible = False
        LabelId.Visible = False
        TextBoxId.Visible = False
        TextBoxIle.ReadOnly = True
        TextBoxKtory.AcceptsReturn = True
        TextBoxKtory.ShortcutsEnabled = False
        TextBoxHaslo.PasswordChar = "*"
        TextBoxHasloAdm.PasswordChar = "*"
    End Sub

    Private Sub ButtonKomis1_Click(sender As Object, e As EventArgs) Handles ButtonKomis1.Click
        actdb = ButtonKomis1.Text
        Dim bs As New BindingSource
        bs.DataSource = Komis1DataSet
        bs.DataMember = "Tabela"
        DataGridViewKomis.DataSource = bs
        OdblokujKomisy()
        ButtonKomis1.Enabled = False
        PokazLogowanie()
        OdblokujPrzyciskiNawigacji()
        TextBoxKtory.Text = bs.Position + 1
        TextBoxIle.Text = bs.Count
        PobierzDaneSamochodu(Komis1DataSet)
        WyswietlDaneSamochodu(Komis1DataSet, 0)
    End Sub

    Private Sub ButtonKomis2_Click(sender As Object, e As EventArgs) Handles ButtonKomis2.Click
        actdb = ButtonKomis2.Text
        Dim bs As New BindingSource
        bs.DataSource = Komis2DataSet
        bs.DataMember = "Tabela"
        DataGridViewKomis.DataSource = bs
        OdblokujKomisy()
        ButtonKomis2.Enabled = False
        PokazLogowanie()
        OdblokujPrzyciskiNawigacji()
        TextBoxKtory.Text = bs.Position + 1
        TextBoxIle.Text = bs.Count
        PobierzDaneSamochodu(Komis2DataSet)
        WyswietlDaneSamochodu(Komis2DataSet, 0)
    End Sub

    Private Sub ButtonKomis3_Click(sender As Object, e As EventArgs) Handles ButtonKomis3.Click
        actdb = ButtonKomis3.Text
        Dim bs As New BindingSource
        bs.DataSource = Komis3DataSet
        bs.DataMember = "Tabela"
        DataGridViewKomis.DataSource = bs
        OdblokujKomisy()
        ButtonKomis3.Enabled = False
        PokazLogowanie()
        OdblokujPrzyciskiNawigacji()
        TextBoxKtory.Text = bs.Position + 1
        TextBoxIle.Text = bs.Count
        PobierzDaneSamochodu(Komis3DataSet)
        WyswietlDaneSamochodu(Komis3DataSet, 0)
    End Sub

    Private Sub ButtonKomis4_Click(sender As Object, e As EventArgs) Handles ButtonKomis4.Click
        actdb = ButtonKomis4.Text
        pass = TextBoxHaslo.Text
        TextBoxHaslo.Text = ""
        Dim qry As String = "SELECT * FROM Tabela;"
        Dim bs As New BindingSource

        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format(
            "server={0}; user id={1}; password={2}; database={3}; pooling=false", server, user, pass, db)

        Try
            conn.Open()
            'MsgBox("Połączono z bazą danych.")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ds.Clear()
        da = New MySqlDataAdapter(qry, conn)
        da.Fill(ds, "Tabela")
        conn.Close()

        bs.DataSource = ds
        bs.DataMember = "Tabela"
        DataGridViewKomis.DataSource = bs
        OdblokujKomisy()
        ButtonKomis4.Enabled = False
        LabelHaslo.Visible = False
        TextBoxHaslo.Visible = False
        PokazLogowanie()
        OdblokujPrzyciskiNawigacji()
        TextBoxKtory.Text = bs.Position + 1
        TextBoxIle.Text = bs.Count
        PobierzDaneSamochodu(ds)
        WyswietlDaneSamochodu(ds, 0)
    End Sub

    Private Sub ButtonWyloguj_Click(sender As Object, e As EventArgs) Handles ButtonWyloguj.Click
        UkryjPrzyciskiAdm()

        If actdb = ButtonKomis1.Text Then
            ButtonKomis1.Enabled = False
        ElseIf actdb = ButtonKomis2.Text Then
            ButtonKomis2.Enabled = False
        ElseIf actdb = ButtonKomis3.Text Then
            ButtonKomis3.Enabled = False
        ElseIf actdb = ButtonKomis4.Text Then
            ButtonKomis4.Enabled = False
        End If
    End Sub

    Private Sub ButtonDodaj_Click(sender As Object, e As EventArgs) Handles ButtonDodaj.Click
        ZablokujKomisy()
        ZablokujPrzyciskiNawigacji()
        ZablokujPrzyciskiAdm()
        ButtonZapiszDodaj.Enabled = True
        ButtonAnuluj.Enabled = True
        OdblokujTextboxy()
        ResetujTextboxy()
        TextBoxMarka.Select()
    End Sub

    Private Sub ButtonEdytuj_Click(sender As Object, e As EventArgs) Handles ButtonEdytuj.Click
        ZablokujKomisy()
        ZablokujPrzyciskiNawigacji()
        ZablokujPrzyciskiAdm()
        ButtonZapiszEdytuj.Enabled = True
        ButtonAnuluj.Enabled = True
        OdblokujTextboxy()
        TextBoxMarka.Select()
    End Sub

    Private Sub ButtonZapiszDodaj_Click(sender As Object, e As EventArgs) Handles ButtonZapiszDodaj.Click
        If TextBoxMarka.Text = "" Or TextBoxModel.Text = "" Then
            MessageBox.Show("Pola Marka i Model nie mogą być puste!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If actdb = ButtonKomis1.Text Then
                'Dim olecb As New OleDb.OleDbCommandBuilder(Komis1DataSetTableAdapters.TabelaTableAdapter)
            ElseIf actdb = ButtonKomis4.Text Then
                Dim cb As New MySqlCommandBuilder(da)

                Dim rekord As DataRow
                rekord = ds.Tables("Tabela").NewRow()
                rekord.Item("Marka") = TextBoxMarka.Text
                rekord.Item("Model") = TextBoxModel.Text
                rekord.Item("Rok") = TextBoxRok.Text
                rekord.Item("Silnik") = TextBoxSilnik.Text
                rekord.Item("Lakier") = TextBoxLakier.Text
                rekord.Item("Metalic") = CheckBoxMetalic.Checked
                rekord.Item("Cena") = TextBoxCena.Text
                rekord.Item("Foto") = TextBoxFoto.Text

                ds.Tables("Tabela").Rows.Add(rekord)
                da.Update(ds, "Tabela")

                OdblokujKomisy()
                OdblokujPrzyciskiNawigacji()
                OdblokujPrzyciskiAdm()
                ButtonZapiszDodaj.Enabled = False
                ButtonAnuluj.Enabled = False
                ZablokujTextboxy()

                TextBoxIle.Text = TextBoxIle.Text + 1
                TextBoxKtory.Text = TextBoxIle.Text

                WyswietlDaneSamochodu(ds, TextBoxKtory.Text - 1)
            End If

            MessageBox.Show("Nowy rekord został dodany do bazy danych " & actdb & ".", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub ButtonZapiszEdytuj_Click(sender As Object, e As EventArgs) Handles ButtonZapiszEdytuj.Click
        If TextBoxMarka.Text = "" Or TextBoxModel.Text = "" Then
            MessageBox.Show("Pola Marka i Model nie mogą być puste!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If actdb = ButtonKomis1.Text Then
                '
            ElseIf actdb = ButtonKomis4.Text Then
                Dim cb As New MySqlCommandBuilder(da)
                ds.Tables("Tabela").Rows(TextBoxKtory.Text - 1).Item("Marka") = TextBoxMarka.Text
                ds.Tables("Tabela").Rows(TextBoxKtory.Text - 1).Item("Model") = TextBoxModel.Text
                ds.Tables("Tabela").Rows(TextBoxKtory.Text - 1).Item("Rok") = TextBoxRok.Text
                ds.Tables("Tabela").Rows(TextBoxKtory.Text - 1).Item("Silnik") = TextBoxSilnik.Text
                ds.Tables("Tabela").Rows(TextBoxKtory.Text - 1).Item("Lakier") = TextBoxLakier.Text
                ds.Tables("Tabela").Rows(TextBoxKtory.Text - 1).Item("Metalic") = CheckBoxMetalic.Checked
                ds.Tables("Tabela").Rows(TextBoxKtory.Text - 1).Item("Cena") = TextBoxCena.Text
                ds.Tables("Tabela").Rows(TextBoxKtory.Text - 1).Item("Foto") = TextBoxFoto.Text

                da.Update(ds, "Tabela")

                OdblokujKomisy()
                OdblokujPrzyciskiNawigacji()
                OdblokujPrzyciskiAdm()
                ButtonZapiszEdytuj.Enabled = False
                ButtonAnuluj.Enabled = False
                ZablokujTextboxy()

                MessageBox.Show("Rekord został zaktualizowany w bazie danych " & actdb & ".", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub ButtonAnuluj_Click(sender As Object, e As EventArgs) Handles ButtonAnuluj.Click
        OdblokujKomisy()
        OdblokujPrzyciskiNawigacji()
        OdblokujPrzyciskiAdm()
        ButtonZapiszDodaj.Enabled = False
        ButtonZapiszEdytuj.Enabled = False
        ButtonAnuluj.Enabled = False
        ZablokujTextboxy()

        If actdb = ButtonKomis1.Text Then
            ButtonKomis1.Enabled = False
        ElseIf actdb = ButtonKomis2.Text Then
            ButtonKomis2.Enabled = False
        ElseIf actdb = ButtonKomis3.Text Then
            ButtonKomis3.Enabled = False
        ElseIf actdb = ButtonKomis4.Text Then
            ButtonKomis4.Enabled = False
        End If

        ButtonWybierz_Click(True, e)
    End Sub

    Private Sub ButtonUsun_Click(sender As Object, e As EventArgs) Handles ButtonUsun.Click
        If actdb = ButtonKomis1.Text Then
            '
        ElseIf actdb = ButtonKomis4.Text Then
            Dim rep As Integer
            rep = MsgBox("Czy na pewno chcesz usunąć zaznaczony rekord z bazy danych " & actdb & "?",
                         vbYesNo + vbQuestion, "Pytanie")

            If rep = vbYes Then
                Dim cb As New MySqlCommandBuilder(da)

                ds.Tables("Tabela").Rows(TextBoxKtory.Text - 1).Delete()
                da.Update(ds, "Tabela")
                TextBoxIle.Text = TextBoxIle.Text - 1

                WyswietlDaneSamochodu(ds, TextBoxKtory.Text - 1)

                MessageBox.Show("Rekord został usunięty z bazy danych " & actdb & ".", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub ButtonZaloguj_Click(sender As Object, e As EventArgs) Handles ButtonZaloguj.Click
        Dim passadm As String
        passadm = TextBoxHasloAdm.Text
        TextBoxHasloAdm.Text = ""

        If passadm <> passAdm Then
            MessageBox.Show("Nieprawidłowe hasło. Nie zalogowano do panelu administracyjnego.", "Odmowa dostępu",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            PokazPrzyciskiAdm()
        End If
    End Sub

    Private Sub ButtonWybierz_Click(sender As Object, e As EventArgs) Handles ButtonWybierz.Click
        Dim bs As BindingSource
        bs = DataGridViewKomis.DataSource

        If TextBoxKtory.Text = "" Then
            MessageBox.Show("Nie wprowadzono numeru rekordu!", "Błąd",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (TextBoxKtory.Text < 1 Or TextBoxKtory.Text > bs.Count) Then
            MessageBox.Show("Wprowadzono numer rekordu spoza zakresu!", "Błąd",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            bs.Position = TextBoxKtory.Text - 1
            WyswietlDaneSamochodu(bs.DataSource, bs.Position)
        End If
    End Sub

    Private Sub ButtonPierwszy_Click(sender As Object, e As EventArgs) Handles ButtonPierwszy.Click
        Dim bs As New BindingSource
        bs = DataGridViewKomis.DataSource
        bs.Position = 0
        TextBoxKtory.Text = bs.Position + 1
        WyswietlDaneSamochodu(bs.DataSource, bs.Position)
    End Sub

    Private Sub ButtonOstatni_Click(sender As Object, e As EventArgs) Handles ButtonOstatni.Click
        Dim bs As New BindingSource
        bs = DataGridViewKomis.DataSource
        bs.Position = bs.Count - 1
        TextBoxKtory.Text = bs.Position + 1
        WyswietlDaneSamochodu(bs.DataSource, bs.Position)
    End Sub

    Private Sub ButtonPoprzedni_Click(sender As Object, e As EventArgs) Handles ButtonPoprzedni.Click
        Dim bs As New BindingSource
        bs = DataGridViewKomis.DataSource
        bs.Position -= 1
        TextBoxKtory.Text = bs.Position + 1
        WyswietlDaneSamochodu(bs.DataSource, bs.Position)
    End Sub

    Private Sub ButtonNastepny_Click(sender As Object, e As EventArgs) Handles ButtonNastepny.Click
        Dim bs As New BindingSource
        bs = DataGridViewKomis.DataSource
        bs.Position += 1
        TextBoxKtory.Text = bs.Position + 1
        WyswietlDaneSamochodu(bs.DataSource, bs.Position)
    End Sub

    Private Sub TextBoxKtory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxKtory.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            ButtonWybierz_Click(True, e)
        ElseIf (IsNumeric(e.KeyChar()) Or e.KeyChar = ChrW(Keys.Back)) Then
            If (TextBoxKtory.Text = "" And e.KeyChar = ChrW(Keys.D0)) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxRok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxRok.KeyPress
        If (IsNumeric(e.KeyChar()) Or e.KeyChar = ChrW(Keys.Back)) Then
            If (TextBoxRok.Text = "" And e.KeyChar = ChrW(Keys.D0)) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxSilnik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSilnik.KeyPress
        If (IsNumeric(e.KeyChar()) Or e.KeyChar = ChrW(Keys.Back)) Then
            If (TextBoxSilnik.Text = "" And e.KeyChar = ChrW(Keys.D0)) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxCena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCena.KeyPress
        If (IsNumeric(e.KeyChar()) Or e.KeyChar = ChrW(Keys.Back)) Then
            If (TextBoxCena.Text = "" And e.KeyChar = ChrW(Keys.D0)) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub PobierzDaneSamochodu(xds As DataSet)
        TextBoxMarka.DataBindings.Clear()
        TextBoxModel.DataBindings.Clear()
        TextBoxRok.DataBindings.Clear()
        TextBoxSilnik.DataBindings.Clear()
        TextBoxLakier.DataBindings.Clear()
        CheckBoxMetalic.DataBindings.Clear()
        TextBoxCena.DataBindings.Clear()
        TextBoxFoto.DataBindings.Clear()
        TextBoxMarka.DataBindings.Add(New Binding("Text", xds, "Tabela.Marka", True))
        TextBoxModel.DataBindings.Add(New Binding("Text", xds, "Tabela.Model", True))
        TextBoxRok.DataBindings.Add(New Binding("Text", xds, "Tabela.Rok", True))
        TextBoxSilnik.DataBindings.Add(New Binding("Text", xds, "Tabela.Silnik", True))
        TextBoxLakier.DataBindings.Add(New Binding("Text", xds, "Tabela.Lakier", True))
        CheckBoxMetalic.DataBindings.Add(New Binding("Checked", xds, "Tabela.Metalic", True))
        TextBoxCena.DataBindings.Add(New Binding("Text", xds, "Tabela.Cena", True))
        TextBoxFoto.DataBindings.Add(New Binding("Text", xds, "Tabela.Foto", True))
    End Sub

    Private Sub WyswietlDaneSamochodu(xds As DataSet, i As Integer)
        TextBoxMarka.Text = xds.Tables("Tabela").Rows(i).Item("Marka")
        TextBoxModel.Text = xds.Tables("Tabela").Rows(i).Item("Model")
        TextBoxRok.Text = xds.Tables("Tabela").Rows(i).Item("Rok")
        TextBoxSilnik.Text = xds.Tables("Tabela").Rows(i).Item("Silnik")
        TextBoxLakier.Text = xds.Tables("Tabela").Rows(i).Item("Lakier")
        CheckBoxMetalic.Checked = xds.Tables("Tabela").Rows(i).Item("Metalic")
        TextBoxCena.Text = xds.Tables("Tabela").Rows(i).Item("Cena")
        TextBoxFoto.Text = xds.Tables("Tabela").Rows(i).Item("Foto")
        Podglad(TextBoxFoto.Text)
    End Sub

    Private Sub Podglad(plik As String)
        PictureBoxMini.ImageLocation = CurDir() & "\Foto\" & plik

        Try
            PictureBoxMini.Load()
        Catch blad As Exception
            PictureBoxMini.ImageLocation = CurDir() & "\Foto\" & "noimage.jpg"
            PictureBoxMini.Load()
            'MessageBox.Show("Brak zdjęcia samochodu.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ZablokujKomisy()
        ButtonKomis1.Enabled = False
        ButtonKomis2.Enabled = False
        ButtonKomis3.Enabled = False
        ButtonKomis4.Enabled = False
        LabelHaslo.Visible = False
        TextBoxHaslo.Visible = False
    End Sub

    Private Sub OdblokujKomisy()
        ButtonKomis1.Enabled = True
        ButtonKomis2.Enabled = True
        ButtonKomis3.Enabled = True
        ButtonKomis4.Enabled = True
        LabelHaslo.Visible = True
        TextBoxHaslo.Visible = True
    End Sub

    Private Sub ZablokujTextboxy()
        TextBoxMarka.ReadOnly = True
        TextBoxModel.ReadOnly = True
        TextBoxRok.ReadOnly = True
        TextBoxSilnik.ReadOnly = True
        TextBoxLakier.ReadOnly = True
        CheckBoxMetalic.AutoCheck = False
        TextBoxCena.ReadOnly = True
        TextBoxFoto.ReadOnly = True
    End Sub

    Private Sub OdblokujTextboxy()
        TextBoxMarka.DataBindings.Clear()
        TextBoxModel.DataBindings.Clear()
        TextBoxRok.DataBindings.Clear()
        TextBoxSilnik.DataBindings.Clear()
        TextBoxLakier.DataBindings.Clear()
        CheckBoxMetalic.DataBindings.Clear()
        TextBoxCena.DataBindings.Clear()
        TextBoxFoto.DataBindings.Clear()

        TextBoxMarka.ReadOnly = False
        TextBoxModel.ReadOnly = False
        TextBoxRok.ReadOnly = False
        TextBoxSilnik.ReadOnly = False
        TextBoxLakier.ReadOnly = False
        CheckBoxMetalic.AutoCheck = True
        TextBoxCena.ReadOnly = False
        TextBoxFoto.ReadOnly = False
    End Sub

    Private Sub ResetujTextboxy()
        TextBoxMarka.Text = ""
        TextBoxModel.Text = ""
        TextBoxRok.Text = ""
        TextBoxSilnik.Text = ""
        TextBoxLakier.Text = ""
        CheckBoxMetalic.Checked = False
        TextBoxCena.Text = ""
        TextBoxFoto.Text = ""
    End Sub

    Private Sub ZablokujPrzyciskiNawigacji()
        ButtonPierwszy.Enabled = False
        ButtonPoprzedni.Enabled = False
        ButtonNastepny.Enabled = False
        ButtonOstatni.Enabled = False
        TextBoxKtory.ReadOnly = True
        ButtonWybierz.Enabled = False
        PictureBoxMini.Image = Nothing
    End Sub

    Private Sub OdblokujPrzyciskiNawigacji()
        ButtonPierwszy.Enabled = True
        ButtonPoprzedni.Enabled = True
        ButtonNastepny.Enabled = True
        ButtonOstatni.Enabled = True
        TextBoxKtory.ReadOnly = False
        ButtonWybierz.Enabled = True
    End Sub

    Private Sub UkryjPrzyciskiAdm()
        ButtonWyloguj.Visible = False
        ButtonDodaj.Visible = False
        ButtonEdytuj.Visible = False
        ButtonZapiszDodaj.Visible = False
        ButtonZapiszEdytuj.Visible = False
        ButtonAnuluj.Visible = False
        ButtonUsun.Visible = False
        LabelFoto.Visible = False
        TextBoxFoto.Visible = False
        PokazLogowanie()
    End Sub

    Private Sub PokazPrzyciskiAdm()
        ButtonWyloguj.Visible = True
        ButtonDodaj.Visible = True
        ButtonEdytuj.Visible = True
        ButtonZapiszDodaj.Visible = True
        ButtonZapiszEdytuj.Visible = True
        ButtonAnuluj.Visible = True
        ButtonUsun.Visible = True
        LabelFoto.Visible = True
        TextBoxFoto.Visible = True
        UkryjLogowanie()
    End Sub

    Private Sub ZablokujPrzyciskiAdm()
        ButtonWyloguj.Enabled = False
        ButtonDodaj.Enabled = False
        ButtonEdytuj.Enabled = False
        ButtonUsun.Enabled = False
    End Sub

    Private Sub OdblokujPrzyciskiAdm()
        ButtonWyloguj.Enabled = True
        ButtonDodaj.Enabled = True
        ButtonEdytuj.Enabled = True
        ButtonUsun.Enabled = True
    End Sub

    Private Sub UkryjLogowanie()
        ButtonZaloguj.Visible = False
        LabelHasloAdm.Visible = False
        TextBoxHasloAdm.Visible = False
    End Sub

    Private Sub PokazLogowanie()
        If ButtonWyloguj.Visible = False Then
            ButtonZaloguj.Visible = True
            LabelHasloAdm.Visible = True
            TextBoxHasloAdm.Visible = True
        End If
    End Sub

End Class

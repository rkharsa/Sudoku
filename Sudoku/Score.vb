Public Class Score

    Private Sub Retour_Click(sender As Object, e As EventArgs) Handles Retour.Click
        Me.Hide()
        Accueil.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Nbpart.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles NomList.SelectedIndexChanged
        MsgBox(NomList.Text)
    End Sub

    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        '   Me.NomList.Items.Add(Accueil.NomJ.Text)
        ''  Me.Nbpart.Items.Add(1)
        '   Me.Temps.Items.Add(Resultat.Time.Text)
        '   Me.Niveau.Items.Add(Accueil.Niveau.Text)
        '  Me.Remplie.Items.Add(Resultat.remplie.Text)
        InitialisationDonnees()

    End Sub

    Private Sub Rechercher_Click(sender As Object, e As EventArgs) Handles Rechercher.Click
        NomR.Items.Clear()
        Dim count As Integer = (NomList.Items.Count - 1)
        Dim nom As String
        For a As Integer = 0 To count
            nom = NomList.Items.Item(a)
            If InStr(nom.ToLower, recherche.Text.ToLower) Then
                NomR.Items.Add(nom)
                TempsR.Items.Add(Temps.Items.Item(a))
                NiveauR.Items.Add(Niveau.Items.Item(a))
                NBpartie.Items.Add(Nbpart.Items.Item(a))
                RemplieR.Items.Add(Remplie.Items.Item(a))
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub recherche_SelectedIndexChanged(sender As Object, e As EventArgs) Handles recherche.SelectedIndexChanged

    End Sub
End Class
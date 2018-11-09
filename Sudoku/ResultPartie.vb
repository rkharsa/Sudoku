Public Class ResultPartie
    Private Sub ResulatPartie_Load(sender As Object, e As EventArgs) Handles Me.Load
        Seconde.Text = Jeu.Minuteur.Text
        If Jeu.GrilleRempli() = True Then
            GrilleRemplie.Text = "Reussi"
        Else
            GrilleRemplie.Text = "Echec"
        End If

        NIveau.Text = Accueil.Niveau.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Sauvegarde.Click
        Me.Close()
        Accueil.Show()


    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Accueil.Show()
    End Sub
End Class
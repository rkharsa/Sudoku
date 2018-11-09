Public Class Resultat
    Private Sub Resultat_Load(sender As Object, e As EventArgs) Handles MyBase.Shown

        Jeu.EffacerTout()

        level.Text = Accueil.Niveau.Text
        Time.Text = Jeu.Minuteur.Text
        If Jeu.Minuteur.Text > 0 Then
            remplie.Text = "Reussi"
        Else
            remplie.Text = "Echec"
        End If

    End Sub

    Private Sub Sauvegarde_Click(sender As Object, e As EventArgs) Handles Sauvegard.Click
        sauvegarde.sauvegarde()
        Me.Close()
        Accueil.Show()

    End Sub

    Private Sub AccueilR_Click(sender As Object, e As EventArgs) Handles AccueilR.Click
        Me.Hide()
        Accueil.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Resultat_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
Imports System.IO
Public Class Accueil
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Arret.Click
        Dim Rep As String
        Rep = MsgBox("Voulez-vous vraiment quitter l'application?", vbYesNo, "Quitter")
        If Rep = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub LesReglesDuJeuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LesReglesDuJeuToolStripMenuItem.Click
        MsgBox("Un sudoku classique contient neuf lignes et neuf colonnes, donc 81 cases au total. Le but du jeu est de remplir ces cases avec des chiffres allant de 1 à 9 en veillant toujours à ce qu'un même chiffre ne figure qu'une seule fois par colonne, une seule fois par ligne, et une seule fois par carré de neuf cases.", vbOKOnly, "Regles du jeu")
    End Sub

    Private Sub CopyrigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyrigToolStripMenuItem.Click
        MsgBox("le Sudoku a été conu  au vu d'un projet en IHM  par Rani Kharsa Groupe 104 et julien ", vbOKOnly, "Copyright")
    End Sub

    Private Sub Jouer_Click(sender As Object, e As EventArgs) Handles Jouer.Click
        verification()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        CreationGrille.Show()
    End Sub

    Public Sub verification()
        If NomJ.Text <> "" And Niveau.Text <> "" And TimerOnOFF.Text <> "" Then
            Me.Hide()
            Jeu.Show()

            Me.NomJ.Items.Add(NomJ.Text)
        Else
            MsgBox("Entrer un nom,un niveau et choisir le temps", vbOKOnly, "Erreur")
        End If
    End Sub
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles Me.Shown
        InitialisationDonnees()
        Dim path As String = "..\..\..\GrilleSudo\NomGrille.txt"
        Using sr As StreamReader = File.OpenText(path)
            Dim Compteurtours As Integer = -1
            Do While sr.Peek() >= 0
                Niveau.Items.Add(sr.ReadLine())
            Loop
        End Using
        Score.Close()
    End Sub

    Private Sub Score_Click(sender As Object, e As EventArgs) Handles Scores.Click
        Me.Hide()
        Score.Show()
    End Sub

    Private Sub Accueil_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


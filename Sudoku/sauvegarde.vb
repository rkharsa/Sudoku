Imports System.IO
Module sauvegarde
    Dim nbrJ As Integer
    Public Structure joueur
        Dim nom As String
        Dim meilleurTemps As String
        Dim nbPartie As Integer
        Dim Niveau As String
        Dim GrilleRempli As String
    End Structure
    Dim trouverNumJ As Integer
    Dim j(1000) As joueur
    Private Sub ecrireFichierJoueur()
        Using sw As StreamWriter = File.AppendText("..\..\..\joueur\joueur.txt")
            sw.Write(j(nbrJ).nom)
            sw.Write(",")
            sw.Write(j(nbrJ).meilleurTemps)
            sw.Write(",")
            sw.Write(j(nbrJ).nbPartie)
            sw.Write(",")
            sw.Write(j(nbrJ).Niveau)
            sw.Write(",")
            sw.Write(j(nbrJ).GrilleRempli)
            sw.Write(",")

        End Using

    End Sub
    Public Sub InitialisationDonnees()
        Score.NomList.Items.Clear()

        Accueil.NomJ.Items.Clear()
        Score.Niveau.Items.Clear()
        Score.Temps.Items.Clear()
        Score.Remplie.Items.Clear()
        Score.Nbpart.Items.Clear()
        Dim Path As String = "..\..\..\Joueur\joueur.txt"
        Using sr As StreamReader = File.OpenText(path)
            Dim Compteurtours As Integer = -1
            Do While sr.Peek() >= 0
                Dim separator = sr.ReadLine.Split(",")
                Compteurtours = Compteurtours + 1
                ReDim Preserve j(Compteurtours)

                j(Compteurtours).nom = separator(0)
                Accueil.NomJ.Items.Add(separator(0))
                Score.recherche.Items.Add(separator(0))
                Score.NomList.Items.Add(separator(0))

                j(Compteurtours).meilleurTemps = separator(1)
                Score.Temps.Items.Add(separator(1))

                j(Compteurtours).nbPartie = separator(2)
                Score.Nbpart.Items.Add(separator(2))

                j(Compteurtours).Niveau = separator(3)
                Score.Niveau.Items.Add(separator(3))

                j(Compteurtours).GrilleRempli = separator(4)
                Score.Remplie.Items.Add(separator(4))
                '  


                nbrJ = Compteurtours
            Loop
        End Using
    End Sub


    Public Sub sauvegarde()
        Dim nbpartie As Integer
        For i As Integer = 0 To nbrJ
            If Accueil.NomJ.Items(i) = Accueil.NomJ.Text Then
                nbpartie = j(i).nbPartie + 1
            End If
        Next
        nbrJ = nbrJ + 1
        ReDim Preserve j(nbrJ)
        j(nbrJ).nom = Accueil.NomJ.Text
        j(nbrJ).meilleurTemps = Resultat.Time.Text
        j(nbrJ).nbPartie = nbpartie
        j(nbrJ).Niveau = Accueil.Niveau.Text
        j(nbrJ).GrilleRempli = Resultat.remplie.Text

        ecrireFichierJoueur()
    End Sub
End Module

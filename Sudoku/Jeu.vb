
Public Class Jeu

    Dim Sudo(0 To 8, 0 To 8) As TextBox
    Dim erreur2 As Boolean
    Dim NbrErreur As Integer
    Public Decompte As Integer
    Dim EnPause As Boolean
    Dim timerOFF As Boolean
    Public Function getdecompte() As Integer
        Return Decompte
    End Function
    '----------------------------------------------------------------------------------'
    '-------------------Initialisation du jeu---------------------------------------  -'
    '----------------------------------------------------------------------------------'
    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles Me.Shown
        Decompte = 60
        NbrErreur = 0
        EnPause = True
        Dim increm As Integer = 0
        Dim x1, y1 As Integer
        For x As Integer = 0 To 8
            For y As Integer = 0 To 8

                x1 = 0
                y1 = 0
                If x > 2 Then
                    x1 = 4
                End If
                If x > 5 Then
                    x1 = 8
                End If
                If y > 2 Then
                    y1 = 4
                End If
                If y > 5 Then
                    y1 = 8
                End If
                Sudo(x, y) = New TextBox
                CaracteristiqueTextbox(x, y, increm)
                Sudo(x, y).Location = New Point(175 + x * 30 + x1, 150 + y * 20 + y1)
                Me.Controls.Add(Sudo(x, y))
                increm = increm + 1
                AddHandler Sudo(x, y).KeyPress, AddressOf sudo_KeyPress
                AddHandler Sudo(x, y).TextChanged, AddressOf Backtracking
            Next
        Next
        NomJJ.Text = Accueil.NomJ.Text
        initialisationPauseONOFF()
    End Sub
    Private Sub initialisationPauseONOFF()
        If Accueil.TimerOnOFF.Text = Accueil.TimerOnOFF.Items(1) Then
            timerOFF = True
        Else
            timerOFF = False
        End If
    End Sub
    Private Sub CaracteristiqueTextbox(ByVal x As Integer, ByVal y As Integer, ByVal increm As Integer)
        With Sudo(x, y)
            Initialisation(x, y, increm)
            .TextAlign = HorizontalAlignment.Center
            .MaxLength = 1
            .Width = 30
            .Height = 35
            .Name = x
            .Tag = y
            .ReadOnly = True
        End With
    End Sub
    Private Function LireFichierLetterByLetter(ByVal NomFichier As String, ByVal i As Integer) As Char
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("..\..\..\GrilleSudo\" + NomFichier + ".txt").Chars(i)
        Return fileReader
    End Function
    Private Sub Initialisation(ByVal x As Integer, ByVal y As Integer, ByVal increm As Integer)
        If LireFichierLetterByLetter(Accueil.Niveau.Text, increm) = "X" Then
            Sudo(x, y).Text = Nothing
        Else
            Sudo(x, y).Text = LireFichierLetterByLetter(Accueil.Niveau.Text, increm)
        End If
    End Sub
    '----------------------------------------------------------------------------------'
    '--------------Restriction de saisie  et redirection en cas de fin de partie  ---'
    '----------------------------------------------------------------------------------'
    Private Sub sudo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = vbBack Then Exit Sub
        If e.KeyChar < "1" OrElse e.KeyChar > "9" Then
            e.Handled = True
        End If
        If SudoFini() = True Then
            RedirectionResultat()
        End If
    End Sub
    Private Sub RedirectionResultat()
        Me.Hide()
        Resultat.Show()
        '  Dim temps As String = Minuteur.Text
        '  Dim reussie As Boolean = GrilleRempli()
        '' MsgBox(temps, vbOK)
        ' MsgBox(reussie)
    End Sub
    '----------------------------------------------------------------------------------'
    '-Backtraking Pour trouver les erreurs(sur une ligne ,une colone, et une region ---'
    '----------------------------------------------------------------------------------'
    Private Sub Backtracking()
        For x As Integer = 0 To 8
            For y As Integer = 0 To 8
                If Sudo(x, y).Text <> "" Then
                    Sudo(x, y).ForeColor = Color.Black
                End If
            Next
        Next
        For x As Integer = 0 To 8
            For y As Integer = 0 To 8
                If VerifLigneBacktracking(x, y, Sudo(x, y).Text) = True Or VerifColoneBacktracking(x, y, Sudo(x, y).Text) = True Or VerifBoxBacktracking(x, y, Sudo(x, y).Text) = True Then
                    Sudo(x, y).ForeColor = Color.Red
                    NbrErreur = NbrErreur + 1
                End If
            Next
        Next
    End Sub
    Private Function VerifLigneBacktracking(ByVal x As Integer, ByVal y As Integer, ByVal value As String) As Boolean
        Dim erreur As Boolean = False
        For x1 As Integer = 0 To 8
            If Sudo(x1, y).Text <> "" Then
                If x1 <> x Then
                    If Sudo(x1, y).Text = value Then
                        Sudo(x1, y).ForeColor = Color.Red
                        erreur = True
                    End If
                End If
            End If
        Next
        Return erreur
    End Function
    Private Function VerifColoneBacktracking(ByVal x As Integer, ByVal y As Integer, ByVal value As String) As Boolean
        Dim erreur As Boolean = False
        For y1 As Integer = 0 To 8
            If Sudo(x, y1).Text <> "" Then
                If y1 <> y Then
                    If Sudo(x, y1).Text = value Then
                        Sudo(x, y1).ForeColor = Color.Red
                        erreur = True
                    End If
                End If
            End If
        Next
        Return erreur
    End Function
    Private Function VerifBoxBacktracking(ByVal x As Integer, ByVal y As Integer, ByVal value As String)
        Dim FinRegionX As Integer
        Dim FinRegionY As Integer
        Dim erreur As Boolean = False
        Dim debutRegionX As Integer
        Dim debutRegionY As Integer
        If x < 3 And x >= 0 Then
            debutRegionX = 0
        ElseIf x < 6 And x >= 3 Then
            debutRegionX = 3

        Else
            debutRegionX = 6
        End If

        If y < 3 And y >= 0 Then
            debutRegionY = 0
        ElseIf y < 6 And y >= 3 Then
            debutRegionY = 3
        Else
            debutRegionY = 6
        End If
        FinRegionX = debutRegionX + 2
        FinRegionY = debutRegionY + 2
        For debutX As Integer = debutRegionX To FinRegionX 'colone
            For debutY As Integer = debutRegionY To FinRegionY 'ligne
                If Sudo(debutX, debutY).Text <> "" Then
                    If debutX <> x And debutY <> y Then
                        If Sudo(debutX, debutY).Text = value Then
                            Sudo(debutX, debutY).ForeColor = Color.Red
                            erreur = True
                        End If
                    End If
                End If
            Next
        Next
        Return erreur
    End Function

    '----------------------------------------------------------------------'
    '-------------------------MenuStrip------------------------------------'
    '----------------------------------------------------------------------'

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub LesReglesDuJeuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LesReglesDuJeuToolStripMenuItem.Click
        MsgBox("Un sudoku classique contient neuf lignes et neuf colonnes, donc 81 cases au total. Le but du jeu est de remplir ces cases avec des chiffres allant de 1 à 9 en veillant toujours à ce qu'un même chiffre ne figure qu'une seule fois par colonne, une seule fois par ligne, et une seule fois par carré de neuf cases.", vbOKOnly, "Regles du jeu")
    End Sub

    Private Sub CopyrigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyrigToolStripMenuItem.Click
        MsgBox("le Sudoku a été conu  au vu d'un projet en IHM  par Rani Kharsa Groupe 104", vbOKOnly, "Copyright")
    End Sub

    Private Sub QuitterLapplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterLapplicationToolStripMenuItem.Click
        Dim Rep As String
        Rep = MsgBox("Voulez-vous vraiment quitter l'application?", vbYesNo, "Quitter")
        If Rep = vbYes Then
            Me.Close()
            Accueil.Close()
        End If
    End Sub

    '----------------------------------------------------------------------'
    '-------------------------Indicateur de  fin de partie ----------------'
    '----------------------------------------------------------------------'

    Private Function SudoFini() As Boolean
        Dim fini As Boolean = False
        If GrilleRempli() = True Or MinuteurFin() = True Then
            fini = True
        End If
        Return fini
    End Function
    Private Function ErreurVerif() As Boolean
        Dim Erreur As Boolean = False
        For x As Integer = 0 To 8
            For y As Integer = 0 To 8
                If Sudo(x, y).Text <> "" Then
                    If Sudo(x, y).ForeColor = Color.Red Then
                        Erreur = True
                    End If
                End If
            Next
        Next
        Return Erreur
    End Function
    Public Function GrilleRempli() As Boolean
        Dim NbrCaseRemplie As Integer = 0
        Dim finGrille As Boolean = True
        For x As Integer = 0 To 8
            For y As Integer = 0 To 8
                If Sudo(x, y).Text <> "" Then
                    finGrille = False
                    NbrCaseRemplie = NbrCaseRemplie + 1
                    If NbrCaseRemplie = 81 And ErreurVerif() = False Then
                        finGrille = True
                    End If

                End If
            Next
        Next

        Return finGrille
    End Function


    '----------------------------------------------------------------------'
    '-------------------------Button CLEAR------------------------------------'
    '----------------------------------------------------------------------'
    Private Sub clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        EffacerTout()
    End Sub

    Public Sub EffacerTout()
        For x As Integer = 0 To 8
            For y As Integer = 0 To 8
                If Sudo(x, y).ReadOnly = False Then
                    Sudo(x, y).Text = ""
                End If
            Next
        Next
    End Sub

    '----------------------------------------------------------------------'
    '-------------------------Button Reload------------------------------------'
    '----------------------------------------------------------------------'
    Private Sub s_Click(sender As Object, e As EventArgs) Handles Reload.Click
        Dim rep As String
        rep = MsgBox("Voulez-vous Recommencer?", vbYesNo)
        If rep = vbYes Then
            EffacerTout()
            EteindreTimer()
            Decompte = 60
            Minuteur.Text = Decompte
        End If
    End Sub
    '----------------------------------------------------------------------'
    '-------------------------Button Abandonner----------------------------'
    '----------------------------------------------------------------------'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Abandonner.Click
        Dim msg, titre, rep As String
        msg = "Voulez-vous  abandonner?"
        titre = "Abandonner"
        rep = MsgBox(msg, vbYesNo, titre)
        If rep = vbYes Then
            Me.Close()
            Accueil.Show()
        End If
    End Sub

    '----------------------------------------------------------------------'
    '-----------------Le Decompte du Sudoku--------------------------------'
    '----------------------------------------------------------------------'

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If timerOFF = False Then
            If MinuteurFin() = True Then
                Timer1.Stop()
            Else
                Decompte = Decompte - 1
                Minuteur.Text = Decompte
                ChangementCouleurMinuteur()

            End If
        Else
            Minuteur.Text = "illimité"
        End If

    End Sub
    Private Sub EteindreTimer()
        Timer1.Stop()
        Dim increm As Integer = 0
        For x As Integer = 0 To 8
            For y As Integer = 0 To 8

                If Sudo(x, y).Text <> LireFichierLetterByLetter(Accueil.Niveau.Text, increm) Then
                    Sudo(x, y).ReadOnly = True
                End If
                increm = increm + 1
            Next
        Next
        cache.Visible = True
        EnPause = True
    End Sub
    Private Sub AllumerTimer()
        Timer1.Start()
        Dim increm As Integer = 0
        For x As Integer = 0 To 8
            For y As Integer = 0 To 8
                If Sudo(x, y).Text <> LireFichierLetterByLetter(Accueil.Niveau.Text, increm) Then
                    Sudo(x, y).ReadOnly = False
                End If
                increm = increm + 1
            Next
        Next
        cache.Visible = False
        EnPause = False
    End Sub
    ' La fin du decompte true si le decompte est finis 
    Private Function MinuteurFin() As Boolean
        If timerOFF = False Then
            If Decompte <= 0 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
    'Changement ded couleur du decompte en foncction de l'avancé
    Private Sub ChangementCouleurMinuteur()
        If timerOFF = False Then
            If Decompte < 40 And Decompte > 15 Then
                Me.Minuteur.ForeColor = Color.Tomato
            End If
            If Decompte < 15 And Decompte > 0 Then
                Me.Minuteur.ForeColor = Color.Firebrick
            End If
        End If
    End Sub
    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        If timerOFF = False Then
            If EnPause = True Then
                AllumerTimer()
                start.Text = "Pause"

            Else
                EteindreTimer()
                start.Text = "Play"
            End If
        Else
            AllumerTimer()
            start.Text = "Pause"
        End If

    End Sub

    Private Sub Jeu_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class



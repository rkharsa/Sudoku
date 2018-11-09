Imports System.IO
Public Class CreationGrille
    Dim nouvelleGrille(0 To 8, 0 To 8) As TextBox
    Private Sub CreationGrille_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                nouvelleGrille(x, y) = New TextBox
                caracteristiqueGrille(x, y)
                nouvelleGrille(x, y).Location = New Point(280 + x * 30 + x1, 125 + y * 20 + y1)
                Controls.Add(nouvelleGrille(x, y))
                AddHandler nouvelleGrille(x, y).TextChanged, AddressOf backtracking
                AddHandler nouvelleGrille(x, y).KeyPress, AddressOf nouvelleGrille_Keypress

            Next
        Next
    End Sub
    Private Sub nouvelleGrille_Keypress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = vbBack Then Exit Sub
        If e.KeyChar < "1" OrElse e.KeyChar > "9" Then
            e.Handled = True
        End If
    End Sub
    Private Sub caracteristiqueGrille(x, y)
        With nouvelleGrille(x, y)
            .Text = ""
            .TextAlign = HorizontalAlignment.Center
            .MaxLength = 1
            .Width = 30
            .Height = 35
            .Name = x
            .Tag = y
            .ReadOnly = False
        End With
    End Sub


    Private Sub Creer_Click(sender As Object, e As EventArgs) Handles Creer.Click
        Dim sw As New StreamWriter("..\..\..\GrilleSudo\" + NomFichier.Text + ".txt")
        If ErreurVerif() = False Then

            For x As Integer = 0 To 8
                For y As Integer = 0 To 8
                    If nouvelleGrille(x, y).Text = "" Then
                        sw.Write("X")
                    Else
                        sw.Write(nouvelleGrille(x, y).Text)
                    End If
                Next
            Next
            sw.Close()
            Accueil.Niveau.Items.Add(NomFichier)
            Using nomfichierE As StreamWriter = File.AppendText("..\..\..\GrilleSudo\NomGrille.txt")
                nomfichierE.WriteLine(NomFichier.Text)
            End Using
            MsgBox("Sudoku Creer!! Vous pouvez le retrouver dans l'accueil dans la liste deroulante Niveau!")
            Me.Close()
            Accueil.Show()
        Else
            MsgBox("Le sudoku doit etre valide!")
        End If

    End Sub

    Private Sub Retour_Click(sender As Object, e As EventArgs) Handles Retour.Click
        Me.Close()
        Accueil.Show()
    End Sub

    Private Function ErreurVerif() As Boolean
        Dim Erreur As Boolean = False
        For x As Integer = 0 To 8
            For y As Integer = 0 To 8
                If nouvelleGrille(x, y).Text <> "" Then
                    If nouvelleGrille(x, y).ForeColor = Color.Red Then
                        Erreur = True
                    End If
                End If
            Next
        Next
        Return Erreur
    End Function
    Private Sub backtracking()
        For x As Integer = 0 To 8
            For y As Integer = 0 To 8
                If nouvelleGrille(x, y).Text <> "" Then
                    nouvelleGrille(x, y).ForeColor = Color.Black
                End If


            Next
        Next
        For x As Integer = 0 To 8
            For y As Integer = 0 To 8
                If VerifLigneBacktracking(x, y, nouvelleGrille(x, y).Text) = True Or VerifColoneBacktracking(x, y, nouvelleGrille(x, y).Text) = True Or VerifBoxBacktracking(x, y, nouvelleGrille(x, y).Text) = True Then
                    nouvelleGrille(x, y).ForeColor = Color.Red
                End If
            Next
        Next
    End Sub
    Private Function VerifLigneBacktracking(ByVal x As Integer, ByVal y As Integer, ByVal value As String) As Boolean
        Dim erreur As Boolean = False
        For x1 As Integer = 0 To 8
            'Sudo(x1, sender.tag).BackColor = Color.DarkGray
            If nouvelleGrille(x1, y).Text <> "" Then
                If x1 <> x Then
                    If nouvelleGrille(x1, y).Text = value Then
                        nouvelleGrille(x1, y).ForeColor = Color.Red
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
            'Sudo(x1, sender.tag).BackColor = Color.DarkGray
            If nouvelleGrille(x, y1).Text <> "" Then
                If y1 <> y Then
                    If nouvelleGrille(x, y1).Text = value Then
                        nouvelleGrille(x, y1).ForeColor = Color.Red
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
                If nouvelleGrille(debutX, debutY).Text <> "" Then
                    If debutX <> x And debutY <> y Then
                        If nouvelleGrille(debutX, debutY).Text = value Then
                            nouvelleGrille(debutX, debutY).ForeColor = Color.Red
                            erreur = True
                        End If
                    End If
                End If
            Next
        Next
        Return erreur
    End Function
End Class
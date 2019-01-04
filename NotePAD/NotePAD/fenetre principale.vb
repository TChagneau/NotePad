Imports System.IO
Module var
    Public id = "chagneau", pass = "9029"
    Public Name, Path As String, Path2
    Public FichierNom As String
End Module
Public Class fenetre_principale
    Public Sub fenetre_principale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Path = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\"
        If System.IO.Directory.Exists(Path & "NotePAD") = False Then
            System.IO.Directory.CreateDirectory(Path & "NotePAD")
        End If
        If System.IO.Directory.Exists("C:\NotePAD") = False Then
            System.IO.Directory.CreateDirectory("C:\NotePAD")
        End If

    End Sub
    Sub RecupNom()
        Dim StreamFichier As System.IO.StreamReader
        StreamFichier = My.Computer.FileSystem.OpenTextFileReader(Path & "NotePAD\" & FichierNom & ".txt")
        FichierNom = StreamFichier.ReadLine() 'lit la 1ère ligne
        TextBox1.Text = FichierNom
        StreamFichier.Close()
    End Sub
    Sub OuvrirFichier()
        Dim Fichier As DialogResult = OpenFileDialog1.ShowDialog()
        If Fichier = Windows.Forms.DialogResult.OK Then
            Path2 = OpenFileDialog1.FileName
            Try
                Dim text As String = File.ReadAllText(Path2) 'lit toutes les lignes
                Me.Text = text.Length.ToString
                edit.Text = text
                TextBox1.Text = OpenFileDialog1.FileName
            Catch ex As Exception
                Me.Text = "Error"
                edit.Text = Text
            End Try
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        FichierNom = TextBox1.Text
        If System.IO.File.Exists(Path & "NotePAD\" & FichierNom & ".txt") = False Then
            File.CreateText(Path & "NotePAD\" & FichierNom & ".txt")
        End If
        OuvrirFichier()
    End Sub
    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        OuvrirFichier()
    End Sub
    Private Sub ToolStripTextBox2_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox2.Click
        Dim file_number As Integer
        SaveFileDialog1.ShowDialog()
        file_number = FreeFile()
        FileOpen(file_number, SaveFileDialog1.FileName, OpenMode.Output)
        Print(file_number, edit.Text)
        Print(file_number, Chr(10))
    End Sub
    Private Sub fenetre_principale_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Close()
    End Sub

    Private Sub ToolStripTextBox7_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox7.Click
        Admin.Show()
    End Sub
End Class
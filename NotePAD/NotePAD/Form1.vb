Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim id = "chagneau", pass = "9029"
        Dim id2 = "yuno", pass2 = "chagneau"

        If TextBox1.Text = id And TextBox2.Text = pass Then
            fenetre_principale.Show()
            Me.Hide()
        ElseIf TextBox1.Text = id2 And TextBox2.Text = pass2 Then
            fenetre_principale.Show()
            Me.Hide()
        Else
            MsgBox("error")
        End If


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Admin.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists("C:\NotePAD\utilisateur.txt") = False Then
            File.CreateText("C:\NotePAD\utilisateur.txt")
        End If
    End Sub
End Class

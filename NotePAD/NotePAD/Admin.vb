Imports System.IO
Public Class Admin
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmd.KeyPress
        If cmd.Text = "help" Then
            cmd.Text = ""
            logs.AppendText("Cmd admin > Voici le menu d'aide contextuelle " & vbCrLf)
            logs.AppendText("Cmd admin > -------------------------------------------------" & vbCrLf)
            logs.AppendText("Cmd admin > add user   : permet d'ajouter un utilisateur" & vbCrLf)
            logs.AppendText("Cmd admin > del user   : permet de supprimer un utilisateur" & vbCrLf)
            logs.AppendText("Cmd admin > user list  : affiche la liste de tous les utilisateurs" & vbCrLf)


        End If
    End Sub
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logs.AppendText("Cmd admin > _" & vbCrLf)
    End Sub
End Class
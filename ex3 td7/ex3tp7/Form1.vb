Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = CInt(moy.Text)
        Dim aff As String
        If a >= 10 Then
            aff = "admis"
        ElseIf a >= 8 And a < 10 Then
            aff = "rattrapage"
        Else
            aff = "ajourné"
        End If
        MessageBox.Show(aff, "votre resultat:")
    End Sub
End Class

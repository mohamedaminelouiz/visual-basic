Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(nomtxt.Text) Then
            MessageBox.Show("tapez nom", "error")
        ElseIf String.IsNullOrEmpty(agetxt.Text) Then
            MessageBox.Show("tapez votre age", "error")
        ElseIf CInt(agetxt.text) < 0 Then
            MessageBox.Show("votre age est positif et un entier", "error")
        Else
            MessageBox.Show("bonjour " + nomtxt.Text + ",vouz avez " + agetxt.Text + " ans", "affichage")
        End If
    End Sub
End Class

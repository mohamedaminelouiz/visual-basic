Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim article As article
        initArticle(article)
        Dim test As Boolean = False
        For Each ctrl In grvetement.Controls
            If ctrl.checked Then
                article.vetement = ctrl.text
                test = True
            End If
        Next
        If test = False Then
            ErrorProvider1.SetError(grvetement, "veuillez choisir un vetemens")
            Return
        End If
        test = False
        For Each ctrl In grtype.Controls
            If ctrl.checked Then
                article.typeNettoyage = ctrl.text
                test = True
            End If
        Next
        If test = False Then
            ErrorProvider1.SetError(grtype, "veuillez choisir un type")
            Return
        End If
        Dim nb As Integer
        nb = CInt(num.Text)
        If nb = 0 Then
            ErrorProvider1.SetError(num, "veuillez donner un nombre>0")
            Return
        End If
        If chdefroissage.Checked Then
            article.supplement(0) = True
        End If
        If chtraitement.Checked Then
            article.supplement(1) = True
        End If
        ajouterArticle(article)


    End Sub
End Class

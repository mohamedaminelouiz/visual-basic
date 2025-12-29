Module Articles

    Public Structure article
        Dim code As String
        Dim vetement As String
        Dim typeNettoyage As String
        Dim nombre As Integer
        Dim supplement() As Boolean
    End Structure

    Public Sub initArticle(A As article)
        A.supplement(0) = False
        A.supplement(1) = False
    End Sub

    Public listeArticles As New List(Of article)

    Public Sub ajouterArticle(A As article)
        A.code = A.vetement.Substring(1, 2) & "_" & listeArticles.Count
        listeArticles.Add(A)
    End Sub

End Module

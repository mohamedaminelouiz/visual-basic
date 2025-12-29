Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboisson.Items.Add("cafe")
        txtboisson.Items.Add("jus d'orange")
        txtboisson.Items.Add("eau minerale")
        txtboisson.Items.Add("citronade")
    End Sub

    Dim prix As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim commande As String
        If rdpizza.Checked Then
            commande = "pizza"
            prix = 10
        ElseIf rdburger.Checked Then
            commande = "burger"
            prix = 8
        Else
            commande = "pates"
            prix = 15
        End If
        For Each ctrl In grsupplements.Controls
            If ctrl.checked Then
                commande = commande + " " + ctrl.text
                If ctrl.text = "frommage" Then
                    prix = prix + 2
                ElseIf ctrl.text = "frites" Then
                    prix = prix + 2
                Else
                    prix = prix + 4
                End If
            End If
        Next
        commande = commande & " " & txtboisson.selectedItem
        prix = prix + 10
        lblafficher.Text = commande & " totals=" & prix
    End Sub
End Class

Public Class Form1
    Private Sub Exit1_Click(sender As Object, e As EventArgs) Handles Exit1.Click
        End
    End Sub

    Private Sub Bold_Click(sender As Object, e As EventArgs) Handles Bold1.Click
        TextBox1.Font = New Font(Font, FontStyle.Bold)
        TextBox1.ForeColor = Color.Black
    End Sub

    Private Sub Italic_Click(sender As Object, e As EventArgs) Handles Italic1.Click
        TextBox1.Font = New Font(Font, FontStyle.Italic)
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear1.Click
        TextBox1.Text = " "
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

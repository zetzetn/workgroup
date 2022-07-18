Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim animal1 As Animal
        animal1 = New Animal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim animal1 As Animal
        Dim animal2 As Animal
        Dim animal3 As Animal
        animal1 = New Cat()
        animal2 = New Dog()
        animal3 = New Bird()
        TextBox1.Text = animal1.Sing()
        TextBox2.Text = animal2.Sing()
        TextBox3.Text = animal3.Sing()
    End Sub
End Class

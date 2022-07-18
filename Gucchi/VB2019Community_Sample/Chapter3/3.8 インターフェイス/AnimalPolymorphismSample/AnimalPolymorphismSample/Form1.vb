Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim animal1 As Animal
        Dim animal2 As Animal
        Dim animal3 As Animal

        animal1 = New Cat()         ' 猫クラスのインスタンスを生成し、動物クラスのインスタンス（入れ物）に代入
        animal2 = New Dog()         ' 犬クラスのインスタンスを生成し、動物クラスのインスタンス（入れ物）に代入
        animal3 = New Bird()        ' 鳥クラスのインスタンスを生成し、動物クラスのインスタンス（入れ物）に代入

        TextBox1.Text = animal1.Sing()  ' 動物クラスのインスタンス.鳴く() で鳴き声を表示
        TextBox2.Text = animal2.Sing()  ' 動物クラスのインスタンス.鳴く() で鳴き声を表示
        TextBox3.Text = animal3.Sing()  ' 動物クラスのインスタンス.鳴く() で鳴き声を表示

        TextBox4.Text = animal1.WrapChocolate() ' 動物クラスのインスタンス.WrapChocolate() でトッピングを表示
        TextBox5.Text = animal2.WrapChocolate() ' 動物クラスのインスタンス.WrapChocolate() でトッピングを表示
        TextBox6.Text = animal3.WrapChocolate() ' 動物クラスのインスタンス.WrapChocolate() でトッピングを表示
    End Sub
End Class

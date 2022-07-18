Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Hide()
        MessageBox.Show("こんにちは")
    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown

    End Sub

    ' 自分で作成したMyMethodを書く例
    Public Sub MyMethod()
        ' 処理
    End Sub

    'Private _myBackColor As Color
    'Public Property MyBackColor() As Color
    '    Get
    '        Return _myBackColor
    '    End Get
    '    Set(value As Color)
    '        _myBackColor = value
    '    End Set
    'End Property
    Public Property MyBackColor As Color

    Private newPropertyValue As String
    Public Property NewProperty() As String
        Get
            Return newPropertyValue
        End Get
        Set(ByVal value As String)
            newPropertyValue = value
        End Set
    End Property

End Class

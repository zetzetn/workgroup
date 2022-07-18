' 動物クラス
Public Class Animal
    Public color As String  '色
    Public smell As String  '匂い
    Public taste As String  '味

    Public Overridable Function Sing() As String
        Return "動物の鳴き声"
    End Function
End Class

' 猫クラス
'   動物クラスを継承しています。
'   クッキーインターフェースを継承（実装）しています。
Public Class Cat
    Inherits Animal

    Public ear As String '耳の形
    Public Overrides Function Sing() As String
        Return "ニャー"
    End Function
End Class

' 犬クラス
'   動物クラスを継承しています。
Public Class Dog
    Inherits Animal
    Public nose As String '鼻の形

    Public Overrides Function Sing() As String
        Return "ワン"
    End Function
End Class


' 鳥クラス
'   動物クラスを継承しています。
Public Class Bird
    Inherits Animal
    Public beak As String 'くちばしの形

    Public Overrides Function Sing() As String
        Return "ピヨ"
    End Function
End Class
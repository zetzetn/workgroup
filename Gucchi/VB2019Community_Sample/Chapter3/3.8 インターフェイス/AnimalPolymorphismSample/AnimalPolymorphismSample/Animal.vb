' クッキーインターフェース
Imports AnimalPolymorphismSample

' トッピングインターフェイス
Public Interface ITopping
    Sub WrappChocolate() ' チョコレートで包む
End Interface

' 動物クラス
Public MustInherit Class Animal
    Implements ITopping

    Public color As String  ' 色
    Public smell As String  ' 匂い
    Public taste As String  ' 味

    Public Sub WrappChocolate() Implements ITopping.WrappChocolate
        Throw New NotImplementedException()
    End Sub

    Public Overridable Function Sing() As String
        Return "動物の鳴き声"
    End Function

    Public Overridable Function WrapChocolate() As String
        Return "トッピング"
    End Function
End Class

' 猫クラス
'   動物クラスを継承しています。
'   クッキーインターフェースを継承（実装）しています。
Public Class Cat
    Inherits Animal
    Implements ITopping

    Public ear As String '耳の形
    Public Overrides Function Sing() As String
        Return "ニャー"
    End Function

    Public Overrides Function WrapChocolate() As String
        Return "ホワイトチョコ"
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

    Public Overrides Function WrapChocolate() As String
        Return "ビターチョコ"
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

    Public Overrides Function WrapChocolate() As String
        Return "チョコ"
    End Function
End Class



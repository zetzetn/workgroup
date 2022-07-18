Public Class ItemForm
    Public Sub New(ByVal dsCategory As CategoryDataSet)
        InitializeComponent() ' 初期化処理
        CategoryDataSet.Merge(dsCategory)
    End Sub
End Class
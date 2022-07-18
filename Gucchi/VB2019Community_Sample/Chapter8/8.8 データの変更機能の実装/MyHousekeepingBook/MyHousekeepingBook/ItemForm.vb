Public Class ItemForm
    Public Sub New(ByVal dsCategory As CategoryDataSet)
        InitializeComponent() ' 初期化処理
        CategoryDataSet.Merge(dsCategory)
    End Sub

    Public Sub New(dsCategory As CategoryDataSet,
                   nowDate As Date,
                   category As String,
                   item As String,
                   money As Integer,
                   remarks As String)

        InitializeComponent()   ' 初期化処理
        CategoryDataSet.Merge(dsCategory)
        monCalendar.SetDate(nowDate)
        cmbCategory.Text = category
        txtItem.Text = item
        mtxtMoney.Text = money.ToString()
        txtRemarks.Text = remarks
    End Sub

    Private Sub New()
    End Sub
End Class
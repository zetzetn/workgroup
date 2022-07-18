Public Class Form1
    Private Sub buttonAdd_Click(sender As Object,
                                e As EventArgs) Handles buttonAdd.Click
        Dim frmItem As ItemForm = New ItemForm(CategoryDataSet1)
        Dim drRet As DialogResult = frmItem.ShowDialog()

        If drRet = System.Windows.Forms.DialogResult.OK Then
            MoneyDataSet.moneyDataTable.AddmoneyDataTableRow(
                frmItem.monCalendar.SelectionRange.Start(),
                frmItem.cmbCategory.Text,
                frmItem.txtItem.Text,
                Integer.Parse(frmItem.mtxtMoney.Text),
                frmItem.txtRemarks.Text)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("給料", "入金")
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("食費", "出金")
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("雑費", "出金")
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("住居", "出金")
    End Sub
End Class

Public Class Form1
    Public Sub New()
        InitializeComponent()
        MoneyDataSet1.moneyDataTable.AddmoneyDataTableRow(DateTime.Today, "分類", "品名", 500, "備考")
    End Sub
    Private Sub butSec3List2_Click(sender As Object, e As EventArgs) Handles butSec3List2.Click
        Dim strData As String ' 変換後の値を入れる変数

        ' 日付型を文字列型に変換する例
        Dim dtmEntryDate As Date = Date.Today()
        strData = dtmEntryDate.ToString()
        MessageBox.Show(strData)

        ' 整数型を文字列型に変換する例
        Dim intDataCount As Integer = 10
        strData = intDataCount.ToString()
        MessageBox.Show(strData)
    End Sub

    Private Sub butSec3List3_Click(sender As Object, e As EventArgs) Handles butSec3List3.Click
        Dim strData As String ' 変換後の値を入れる変数

        ' 文字列を日付型に変換
        strData = "2017/07/07" ' 文字列
        Dim dtmEntryDate As Date
        dtmEntryDate = Date.Parse(strData)

        '文字列を整数型に変換
        strData = "1000" ' 文字列
        Dim intDataCount As Integer
        intDataCount = Integer.Parse(strData)
    End Sub

    Private Sub butSec3List4_Click(sender As Object, e As EventArgs) Handles butSec3List4.Click
        Dim strData As String ' 変換後の値を入れる変数

        strData = MoneyDataSet1.moneyDataTable(0).日付.ToShortDateString() + "," +
                  MoneyDataSet1.moneyDataTable(0).分類 + "," +
                  MoneyDataSet1.moneyDataTable(0).品名 + "," +
                  MoneyDataSet1.moneyDataTable(0).金額.ToString() + "," +
                  MoneyDataSet1.moneyDataTable(0).備考

        MessageBox.Show(strData)
    End Sub

    Private Sub butSec3List5_Click(sender As Object, e As EventArgs) Handles butSec3List5.Click
        Dim delimiter() As Char = {","c}
        Dim strData() As String
        Dim strLine As String = "2017/07/07,食事,カレー,750,大盛"

        strData = strLine.Split(delimiter)
        MoneyDataSet1.moneyDataTable.AddmoneyDataTableRow(
                                        Date.Parse(strData(0)),
                                        strData(1).ToString(),
                                        strData(2).ToString(),
                                        Integer.Parse(strData(3)),
                                        strData(4).ToString()
                                     )
    End Sub

    Private Sub butSec4List1_Click(sender As Object, e As EventArgs) Handles butSec4List1.Click
        Dim moneySun As Integer = 1200  ' 日曜日の出費
        Dim moneyMon As Integer = 750   ' 月曜日の出費
        Dim moneyTue As Integer = 650   ' 火曜日の出費
        Dim moneyWed As Integer = 680   ' 水曜日の出費
        Dim moneyThu As Integer = 760   ' 木曜日の出費
        Dim moneyFri As Integer = 980   ' 金曜日の出費
        Dim moneySat As Integer = 1050  ' 土曜日の出費

        Dim sum As Integer              ' 一週間の出費合計
        Dim average As Double           ' 一週間に使用した金額の平均値。小数以下も扱うデータ型
        sum = moneySun + moneyMon + moneyTue + moneyWed _
            + moneyThu + moneyFri + moneySat
        average = sum / 7

        MessageBox.Show(average.ToString())
    End Sub

    Private Sub butSec4List2_Click(sender As Object, e As EventArgs) Handles butSec4List2.Click
        Dim moneyArray(6) As Integer
        moneyArray(0) = 1200    ' 日曜日の出費
        moneyArray(1) = 750     ' 月曜日の出費
        moneyArray(2) = 650     ' 火曜日の出費
        moneyArray(3) = 680     ' 水曜日の出費
        moneyArray(4) = 760     ' 木曜日の出費
        moneyArray(5) = 980     ' 金曜日の出費
        moneyArray(6) = 1050    ' 土曜日の出費

        Dim sum As Integer      ' 一週間の出費合計
        Dim average As Double   ' 一週間に使用した金額の平均値。小数以下も扱うデータ型
        sum = moneyArray(0) _
    + moneyArray(1) _
    + moneyArray(2) _
    + moneyArray(3) _
    + moneyArray(4) _
    + moneyArray(5) _
    + moneyArray(6)
        average = sum / 7

        MessageBox.Show(average.ToString())
    End Sub

    Private Sub butSec5List1_Click(sender As Object, e As EventArgs) Handles butSec5List1.Click
        Dim moneyArray(6) As Integer

        moneyArray(0) = 1200    ' 日曜日の出費
        moneyArray(1) = 750     ' 月曜日の出費
        moneyArray(2) = 650     ' 火曜日の出費
        moneyArray(3) = 680     ' 水曜日の出費
        moneyArray(4) = 760     ' 木曜日の出費
        moneyArray(5) = 980     ' 金曜日の出費
        moneyArray(6) = 1050    ' 土曜日の出費

        Dim sum As Integer      ' 一週間の出費合計
        Dim average As Double   ' 一週間に使用した金額の平均値。小数以下も扱うデータ型
        sum = 0
        For i As Integer = 0 To 6
            sum = sum + moneyArray(i)
        Next
        average = sum / 7

        MessageBox.Show(average.ToString())
    End Sub

    Private Sub butSec5List2_Click(sender As Object, e As EventArgs) Handles butSec5List2.Click
        Dim i As Integer = 0

        Do
            MessageBox.Show(i.ToString())   ' 1回目,4回目,7回目
            i = i + 1                       ' 2回目,5回目,8回目
        Loop While i < 3                    ' 3回目,6回目,9回目

        MessageBox.Show("Doループ終了:" + i.ToString()) ' 10回目
    End Sub

    Private Sub butSec5List3_Click(sender As Object, e As EventArgs) Handles butSec5List3.Click
        Dim i As Integer = 0

        While i < 3                         ' 1回目,4回目,7回目,10回目
            MessageBox.Show(i.ToString())   ' 2回目,5回目,8回目
            i = i + 1                       ' 3回目,6回目,9回目
        End While

        MessageBox.Show("Whileループ終了:" + i.ToString())    ' 11回目
    End Sub

    Private Sub butSec5List4_Click(sender As Object, e As EventArgs) Handles butSec5List4.Click
        For i As Integer = 0 To MoneyDataSet1.moneyDataTable.Rows.Count - 1
            MoneyDataSet1.moneyDataTable(i).品名 = "みかん"
        Next
    End Sub

    Private Sub butSec5List5_Click(sender As Object, e As EventArgs) Handles butSec5List5.Click
        For Each dr As MoneyDataSet.moneyDataTableRow In MoneyDataSet1.moneyDataTable
            dr.品名 = "みかん"
        Next
    End Sub

    Private Sub butSec6List1_Click(sender As Object, e As EventArgs) Handles butSec6List1.Click
        Dim sw As System.IO.StreamWriter _
            = New System.IO.StreamWriter("C:\Users\Win10User\Documents\TestFile.txt",
                                         False, System.Text.Encoding.Default)
        sw.WriteLine("テキストデータ ")
        sw.Close()
    End Sub

    Private Sub butSec7List1_Click(sender As Object, e As EventArgs) Handles butSec7List1.Click
        Dim sr As System.IO.StreamReader _
            = New System.IO.StreamReader("C:\Users\Win10User\Documents\TestFile.txt",
                                         System.Text.Encoding.Default)
        Dim strLine As String
        strLine = sr.ReadLine()
        sr.Close()
        MessageBox.Show(strLine)
    End Sub
End Class

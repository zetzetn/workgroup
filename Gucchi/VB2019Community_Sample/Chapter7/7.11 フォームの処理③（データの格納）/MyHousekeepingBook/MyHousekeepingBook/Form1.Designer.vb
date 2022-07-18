<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mainMenu = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.保存SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.終了XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.編集EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.追加AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.変更CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.削除DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.表示VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.一覧表示LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.集計表示SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.バージョン情報VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.日付DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.分類DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.品名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.金額DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.備考DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoneyDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoneyDataSet = New MyHousekeepingBook.MoneyDataSet()
        Me.buttonAdd = New System.Windows.Forms.Button()
        Me.buttonChange = New System.Windows.Forms.Button()
        Me.buttonDelete = New System.Windows.Forms.Button()
        Me.buttonEnd = New System.Windows.Forms.Button()
        Me.CategoryDataSet1 = New MyHousekeepingBook.CategoryDataSet()
        Me.mainMenu.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainMenu
        '
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem, Me.編集EToolStripMenuItem, Me.表示VToolStripMenuItem, Me.ヘルプVToolStripMenuItem})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(800, 24)
        Me.mainMenu.TabIndex = 0
        Me.mainMenu.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.保存SToolStripMenuItem, Me.ToolStripSeparator1, Me.終了XToolStripMenuItem})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        '保存SToolStripMenuItem
        '
        Me.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem"
        Me.保存SToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.保存SToolStripMenuItem.Text = "保存(&S)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(110, 6)
        '
        '終了XToolStripMenuItem
        '
        Me.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem"
        Me.終了XToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.終了XToolStripMenuItem.Text = "終了(&X)"
        '
        '編集EToolStripMenuItem
        '
        Me.編集EToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.追加AToolStripMenuItem, Me.変更CToolStripMenuItem, Me.削除DToolStripMenuItem})
        Me.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem"
        Me.編集EToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.編集EToolStripMenuItem.Text = "編集(&E)"
        '
        '追加AToolStripMenuItem
        '
        Me.追加AToolStripMenuItem.Name = "追加AToolStripMenuItem"
        Me.追加AToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.追加AToolStripMenuItem.Text = "追加(&A)"
        '
        '変更CToolStripMenuItem
        '
        Me.変更CToolStripMenuItem.Name = "変更CToolStripMenuItem"
        Me.変更CToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.変更CToolStripMenuItem.Text = "変更(&C)"
        '
        '削除DToolStripMenuItem
        '
        Me.削除DToolStripMenuItem.Name = "削除DToolStripMenuItem"
        Me.削除DToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.削除DToolStripMenuItem.Text = "削除(&D)"
        '
        '表示VToolStripMenuItem
        '
        Me.表示VToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.一覧表示LToolStripMenuItem, Me.集計表示SToolStripMenuItem})
        Me.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem"
        Me.表示VToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.表示VToolStripMenuItem.Text = "表示(&V)"
        '
        '一覧表示LToolStripMenuItem
        '
        Me.一覧表示LToolStripMenuItem.Name = "一覧表示LToolStripMenuItem"
        Me.一覧表示LToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.一覧表示LToolStripMenuItem.Text = "一覧表示(&L)"
        '
        '集計表示SToolStripMenuItem
        '
        Me.集計表示SToolStripMenuItem.Name = "集計表示SToolStripMenuItem"
        Me.集計表示SToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.集計表示SToolStripMenuItem.Text = "集計表示(&S)"
        '
        'ヘルプVToolStripMenuItem
        '
        Me.ヘルプVToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.バージョン情報VToolStripMenuItem})
        Me.ヘルプVToolStripMenuItem.Name = "ヘルプVToolStripMenuItem"
        Me.ヘルプVToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ヘルプVToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'バージョン情報VToolStripMenuItem
        '
        Me.バージョン情報VToolStripMenuItem.Name = "バージョン情報VToolStripMenuItem"
        Me.バージョン情報VToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.バージョン情報VToolStripMenuItem.Text = "バージョン情報(&V)"
        '
        'dgv
        '
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.日付DataGridViewTextBoxColumn, Me.分類DataGridViewTextBoxColumn, Me.品名DataGridViewTextBoxColumn, Me.金額DataGridViewTextBoxColumn, Me.備考DataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.MoneyDataTableBindingSource
        Me.dgv.Location = New System.Drawing.Point(12, 27)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 21
        Me.dgv.Size = New System.Drawing.Size(776, 382)
        Me.dgv.TabIndex = 1
        '
        '日付DataGridViewTextBoxColumn
        '
        Me.日付DataGridViewTextBoxColumn.DataPropertyName = "日付"
        Me.日付DataGridViewTextBoxColumn.HeaderText = "日付"
        Me.日付DataGridViewTextBoxColumn.Name = "日付DataGridViewTextBoxColumn"
        '
        '分類DataGridViewTextBoxColumn
        '
        Me.分類DataGridViewTextBoxColumn.DataPropertyName = "分類"
        Me.分類DataGridViewTextBoxColumn.HeaderText = "分類"
        Me.分類DataGridViewTextBoxColumn.Name = "分類DataGridViewTextBoxColumn"
        '
        '品名DataGridViewTextBoxColumn
        '
        Me.品名DataGridViewTextBoxColumn.DataPropertyName = "品名"
        Me.品名DataGridViewTextBoxColumn.HeaderText = "品名"
        Me.品名DataGridViewTextBoxColumn.Name = "品名DataGridViewTextBoxColumn"
        '
        '金額DataGridViewTextBoxColumn
        '
        Me.金額DataGridViewTextBoxColumn.DataPropertyName = "金額"
        Me.金額DataGridViewTextBoxColumn.HeaderText = "金額"
        Me.金額DataGridViewTextBoxColumn.Name = "金額DataGridViewTextBoxColumn"
        '
        '備考DataGridViewTextBoxColumn
        '
        Me.備考DataGridViewTextBoxColumn.DataPropertyName = "備考"
        Me.備考DataGridViewTextBoxColumn.HeaderText = "備考"
        Me.備考DataGridViewTextBoxColumn.Name = "備考DataGridViewTextBoxColumn"
        '
        'MoneyDataTableBindingSource
        '
        Me.MoneyDataTableBindingSource.DataMember = "moneyDataTable"
        Me.MoneyDataTableBindingSource.DataSource = Me.MoneyDataSet
        '
        'MoneyDataSet
        '
        Me.MoneyDataSet.DataSetName = "MoneyDataSet"
        Me.MoneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'buttonAdd
        '
        Me.buttonAdd.Location = New System.Drawing.Point(12, 415)
        Me.buttonAdd.Name = "buttonAdd"
        Me.buttonAdd.Size = New System.Drawing.Size(75, 23)
        Me.buttonAdd.TabIndex = 2
        Me.buttonAdd.Text = "追加"
        Me.buttonAdd.UseVisualStyleBackColor = True
        '
        'buttonChange
        '
        Me.buttonChange.Location = New System.Drawing.Point(93, 415)
        Me.buttonChange.Name = "buttonChange"
        Me.buttonChange.Size = New System.Drawing.Size(75, 23)
        Me.buttonChange.TabIndex = 3
        Me.buttonChange.Text = "変更"
        Me.buttonChange.UseVisualStyleBackColor = True
        '
        'buttonDelete
        '
        Me.buttonDelete.Location = New System.Drawing.Point(174, 415)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(75, 23)
        Me.buttonDelete.TabIndex = 4
        Me.buttonDelete.Text = "削除"
        Me.buttonDelete.UseVisualStyleBackColor = True
        '
        'buttonEnd
        '
        Me.buttonEnd.Location = New System.Drawing.Point(700, 415)
        Me.buttonEnd.Name = "buttonEnd"
        Me.buttonEnd.Size = New System.Drawing.Size(75, 23)
        Me.buttonEnd.TabIndex = 5
        Me.buttonEnd.Text = "終了"
        Me.buttonEnd.UseVisualStyleBackColor = True
        '
        'CategoryDataSet1
        '
        Me.CategoryDataSet1.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.buttonEnd)
        Me.Controls.Add(Me.buttonDelete)
        Me.Controls.Add(Me.buttonChange)
        Me.Controls.Add(Me.buttonAdd)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.mainMenu)
        Me.MainMenuStrip = Me.mainMenu
        Me.Name = "Form1"
        Me.Text = "簡易家計簿"
        Me.mainMenu.ResumeLayout(False)
        Me.mainMenu.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainMenu As MenuStrip
    Friend WithEvents dgv As DataGridView
    Friend WithEvents buttonAdd As Button
    Friend WithEvents buttonChange As Button
    Friend WithEvents buttonDelete As Button
    Friend WithEvents buttonEnd As Button
    Friend WithEvents ファイルFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 保存SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 終了XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 編集EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 追加AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 変更CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 削除DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 表示VToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 一覧表示LToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 集計表示SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents バージョン情報VToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 日付DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 分類DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 品名DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 金額DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 備考DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MoneyDataTableBindingSource As BindingSource
    Friend WithEvents MoneyDataSet As MoneyDataSet
    Friend WithEvents CategoryDataSet1 As CategoryDataSet
End Class

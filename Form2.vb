Public Class Form2

    Private mdt審査結果 As New DataTable
    Private mbIsFirstActivate As Boolean = False '初回起動時のチェック　コンボボックスロードの処理を二度行わないため


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtAPIKey.Text = "" Then
            MsgBox("APIキーを入力してください。")
            Exit Sub
        End If

        DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If mbIsFirstActivate = False Then
            SubSetComboBox_GPTModel()
            mbIsFirstActivate = True
        End If

    End Sub


    '//===================================================================================================
    '// コンボボックスに表示するGPTモデルを設定
    '//===================================================================================================
    Private Sub SubSetComboBox_GPTModel()


        'データテーブルを一度クリアする
        mdt審査結果.Rows.Clear()
        mdt審査結果.Clear()

        ' 列の定義
        mdt審査結果.Columns.Add("名称", GetType(String))
        mdt審査結果.Columns.Add("モデル", GetType(String))

        ' データの追加
        mdt審査結果.Rows.Add("GPT3.5 (高速)", "gpt-3.5-turbo")
        mdt審査結果.Rows.Add("GPT4 (高性能)", "gpt-4-turbo")

        cmbModel.DataSource = mdt審査結果
        cmbModel.DisplayMember = "名称"
        cmbModel.ValueMember = "モデル"


    End Sub



End Class
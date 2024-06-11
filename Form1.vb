Imports System
Imports System.Net.Http
Imports System.Text
Imports System.Text.Json
Imports System.Threading.Tasks
Imports Newtonsoft.Json
'----------メール送信
Imports System.Net
Imports System.Net.Mail
'--------------------

Public Class Form1

    Dim sAPIKey As String
    Dim lMessages As New List(Of Object) 'AIは会話の内容を覚えられないのでお互いのメッセージをリストに格納する
    Dim sCompany As String
    Dim sSenderName As String
    Dim sPhoneNumber As String
    Dim sCustomer As String
    Dim sRecieverName As String
    Dim sPurpuse As String
    Dim sApoDate As String
    Dim sApoTime As String
    Dim sSenderMailAddress As String
    Dim sRecieverMailAddress As String
    Dim sModelId As String
    Dim f2 As New Form2

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInfo()
    End Sub



    Private Async Sub LoadInfo()

        f2.ShowDialog() ' Form2をモーダルダイアログとして開く

        If f2.DialogResult = DialogResult.OK Then
            'form2で入力された情報をfomr1の変数に格納する
            sCompany = f2.txtCompany.Text                           '自社名
            sSenderName = f2.txtSenderName.Text                     '送信者名
            sPhoneNumber = f2.txtPhoneNumber.Text                   '電話番号
            sCustomer = f2.txtCustomer.Text                         '客先名
            sRecieverName = f2.txtRecieverName.Text                 '宛名
            sPurpuse = f2.cmbPurpuse.Text                           '目的
            sApoDate = f2.DateTimePicker0.Value.Date.ToString       '日付
            sApoTime = f2.txtHour.Text & ":" & f2.txtMinute.Text    '時分
            sSenderMailAddress = f2.txtSenderMail.Text              '自社メールアドレス
            sRecieverMailAddress = f2.txtRecieverMail.Text          '客先メールアドレス
            sAPIKey = f2.txtAPIKey.Text                             'APIキー
            sModelId = f2.cmbModel.SelectedValue.ToString           'AIモデル

            txtRecieverMail.Text = sRecieverMailAddress             'テキストインプットにメールアドレスを格納（後で宛名を確認、触れるように）


            '件名に目的を格納する----------------------------------------------------------------
            Dim kenmei As String = ""
            Select Case sPurpuse
                Case "訪問のためのアポイントの確認"
                    kenmei = "訪問日時の調整について"
                Case Else
                    kenmei = sPurpuse
            End Select
            txtTitle.Text = kenmei
            '------------------------------------------------------------------------------------
        Else
            Me.Close()
            Form2.Close()
            Exit Sub
        End If

        'ChatGPTに対して初期のメッセージを送る
        lMessages.Add(New With {.role = "system", .content = "You are assisting in generating an email."})
        lMessages.Add(New With {.role = "user", .content = "以下の条件でメール文を生成してください。_
ただし、役職や住所など、提供されていない情報は使用せず、勝手に補完もしないで生成しなさい。件名は不要です。_
自社の名前=" & sCompany & ",メール送信者の名前=" & sSenderName & ",メール送信者の電話番号=" & sPhoneNumber &
", 客先の会社名=" & sCustomer & ", 客先の宛名=" & sRecieverName & ",メール文の目的=" & sPurpuse &
",約束の日付=" & sApoDate & ",約束の時間=" & sApoTime & ",自社のメールアドレス=" & sSenderMailAddress & ",客先のメールアドレス=" & sRecieverMailAddress})

        '
        Dim TResponse As Task(Of String) = GetChatGPTResponse(lMessages, sAPIKey, sModelId)
        Dim sChatResponse As String = Await TResponse

        txtSubject.Text = "" 'メール本文を初期化
        txtSubject.AppendText(sChatResponse & vbCrLf) 'メール本文にGPTからの返信を表示
        txtSubject.Text = txtSubject.Text.Replace(vbLf, vbCrLf) '改行を読み込み

        ActiveControl = txtFix 'ChatGPTに対しての命令入力欄にフォーカス

    End Sub

    'メッセージ内容に修正が必要である場合
    Private Async Sub btnFix_Click(sender As Object, e As EventArgs) Handles btnFix.Click
        If String.IsNullOrEmpty(txtFix.Text) Or txtFix.Text.Contains(vbCrLf) Then Return '質問が空欄なら実行しない

        Dim sUserInput As String = txtFix.Text

        txtSubject.Text &= sUserInput
        btnFix.Text = "送信中..."

        lMessages.Add(New With {.role = "user", .content = sUserInput})

        Dim TResponse As Task(Of String) = GetChatGPTResponse(lMessages, sAPIKey, sModelId)

        Try
            Dim sFixedChatResponse As String = Await TResponse
            txtSubject.Text = sFixedChatResponse

            txtSubject.Text = txtSubject.Text.Replace(vbLf, vbCrLf) ' 改行コードを統一し、テキストボックスの内容を更新
            btnFix.Text = "メール文の内容を修正する"

        Catch ex As Exception

            Dim lines() As String = txtSubject.Lines
            ReDim Preserve lines(lines.Length - 3)
            txtSubject.Lines = lines
            MsgBox("文章生成のペースが速すぎたため、ChatGPTが応対しませんでした。少し待ってからもう一度入力してください。")
        End Try
    End Sub

    Public Async Function GetChatGPTResponse(messages As List(Of Object), apiKey As String, modelId As String) As Task(Of String)
        Dim apiUrl As String = "https://api.openai.com/v1/chat/completions"
        Dim maxTokens As Integer = 1024
        Dim jsonRequestBody As String = JsonConvert.SerializeObject(New With {
            .model = modelId,
            .messages = messages,
            .max_tokens = maxTokens ' 追加したmaxTokens
        })

        Using httpClient As New HttpClient()
            Try
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " & apiKey)
                Dim response = Await httpClient.PostAsync(apiUrl, New StringContent(jsonRequestBody, Encoding.UTF8, "application/json"))
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                Dim jsonDocument As JsonDocument = JsonDocument.Parse(jsonResponse)
                Dim root As JsonElement = jsonDocument.RootElement
                Dim reply As String = root.GetProperty("choices")(0).GetProperty("message").GetProperty("content").GetString()
                messages.Add(New With {.role = "assistant", .content = reply})
                Return reply

            Catch ex As Exception
                MsgBox("API呼び出しまたはレスポンスの処理中にエラーが発生しました。")
                'Throw New ApplicationException("API呼び出しまたはレスポンスの処理中にエラーが発生しました。", ex)
                reset()
            End Try

        End Using
    End Function


    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        reset()

    End Sub
    Sub reset()
        ' 対話の内容と変数を初期化
        lMessages.Clear()
        sCompany = ""
        sSenderName = ""
        sPhoneNumber = ""
        sCustomer = ""
        sRecieverName = ""
        sPurpuse = ""
        sApoDate = ""
        sApoTime = ""
        sSenderMailAddress = ""
        sRecieverMailAddress = ""
        txtSubject.Text = "文章を生成中..."                                                 'メール本文を初期化
        lblCover.Text = "           ChatGPTに対して修正内容がある場合はここに入力         " '修正内容ラベルを初期化
        sAPIKey = ""
        sModelId = ""
        LoadInfo()

    End Sub

    'VB.NETのテキストボックスコントロールでは薄字の初期値を設定できないのでラベルで代用する------------------------------------------------------------------
    Private Sub txtFix_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFix.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtFix.Text = "" Then Exit Sub
            btnFix.PerformClick()
        End If
    End Sub
    Private Sub txtFix_TextChanged(sender As Object, e As EventArgs) Handles txtFix.TextChanged
        If Me.txtFix.Text = String.Empty Then
            Me.Label1.Visible = True
        Else
            Me.lblCover.Visible = False
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblCover.Click
        Me.txtFix.Focus()
        lblCover.Visible = False
    End Sub
    '--------------------------------------------------------------------------------------------------------------------------


    Private Sub 送信_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        sRecieverMailAddress = txtRecieverMail.Text
        Try
            Dim smtpClient As New SmtpClient()
            Dim mail As New MailMessage()

            ' 送信者の設定

            Dim PWD As String = "xxxx" 'SMTPのパスワード

            mail.From = New MailAddress(sSenderMailAddress)

            ' 宛先の設定

            mail.To.Add(sRecieverMailAddress)

            ' メールの件名と本文の設定
            mail.Subject = sPurpuse
            mail.Body = txtSubject.Text

            ' SMTPサーバーの設定
            smtpClient.Host = "smtp.xxxx.co.jp"
            smtpClient.Port = 587

            ' 送信者の認証情報（SMTPサーバーへのログイン情報）
            smtpClient.Credentials = New NetworkCredential(sSenderMailAddress, PWD)

            ' SSLを使用するかどうか
            smtpClient.EnableSsl = False

            ' メールを送信
            smtpClient.Send(mail)

            MessageBox.Show("メールが送信されました。")
        Catch ex As Exception
            MessageBox.Show("エラーが発生しました: " & ex.Message)
        End Try
    End Sub

End Class
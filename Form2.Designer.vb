<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label0 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker0 = New System.Windows.Forms.DateTimePicker()
        Me.cmbPurpuse = New System.Windows.Forms.ComboBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRecieverMail = New System.Windows.Forms.TextBox()
        Me.txtHour = New System.Windows.Forms.TextBox()
        Me.txtMinute = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSenderName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSenderMail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtRecieverName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbModel = New System.Windows.Forms.ComboBox()
        Me.txtAPIKey = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(101, 533)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(662, 52)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "上記の条件でメール文を作成する"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label0
        '
        Me.Label0.AutoSize = True
        Me.Label0.BackColor = System.Drawing.SystemColors.Control
        Me.Label0.Font = New System.Drawing.Font("MS UI Gothic", 14.25!)
        Me.Label0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label0.Location = New System.Drawing.Point(13, 13)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(85, 19)
        Me.Label0.TabIndex = 7
        Me.Label0.Text = "■会社名"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 14.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(13, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "■客先名"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 14.25!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(13, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 19)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "■要件"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 14.25!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(13, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 19)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "■日時"
        '
        'DateTimePicker0
        '
        Me.DateTimePicker0.Location = New System.Drawing.Point(183, 164)
        Me.DateTimePicker0.Name = "DateTimePicker0"
        Me.DateTimePicker0.Size = New System.Drawing.Size(237, 19)
        Me.DateTimePicker0.TabIndex = 11
        '
        'cmbPurpuse
        '
        Me.cmbPurpuse.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPurpuse.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.cmbPurpuse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbPurpuse.FormattingEnabled = True
        Me.cmbPurpuse.Items.AddRange(New Object() {"訪問のアポ取り", "オンラインミーティングの日程調整", "ゴルフのお誘い", "添付している資料を確認してもらう", "訪問後の議事録送信（URL）", "訪問後のお礼", "リスケジューリング"})
        Me.cmbPurpuse.Location = New System.Drawing.Point(183, 126)
        Me.cmbPurpuse.Name = "cmbPurpuse"
        Me.cmbPurpuse.Size = New System.Drawing.Size(567, 20)
        Me.cmbPurpuse.TabIndex = 5
        Me.cmbPurpuse.Text = "訪問のためのアポイントの確認"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(184, 13)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(567, 19)
        Me.txtCompany.TabIndex = 12
        Me.txtCompany.Text = "株式会社ABC"
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(183, 15)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(567, 19)
        Me.txtCustomer.TabIndex = 13
        Me.txtCustomer.Text = "XYZカンパニー"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 14.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(13, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "■客先メールアドレス"
        '
        'txtRecieverMail
        '
        Me.txtRecieverMail.Location = New System.Drawing.Point(183, 89)
        Me.txtRecieverMail.Name = "txtRecieverMail"
        Me.txtRecieverMail.Size = New System.Drawing.Size(567, 19)
        Me.txtRecieverMail.TabIndex = 15
        Me.txtRecieverMail.Text = "xxxx@xyz.co.jp"
        '
        'txtHour
        '
        Me.txtHour.Location = New System.Drawing.Point(431, 164)
        Me.txtHour.Name = "txtHour"
        Me.txtHour.Size = New System.Drawing.Size(38, 19)
        Me.txtHour.TabIndex = 16
        Me.txtHour.Text = "13"
        '
        'txtMinute
        '
        Me.txtMinute.Location = New System.Drawing.Point(502, 164)
        Me.txtMinute.Name = "txtMinute"
        Me.txtMinute.Size = New System.Drawing.Size(38, 19)
        Me.txtMinute.TabIndex = 17
        Me.txtMinute.Text = "00"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(480, 167)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(11, 12)
        Me.label9.TabIndex = 18
        Me.label9.Text = "："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(13, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "■送信者名"
        '
        'txtSenderName
        '
        Me.txtSenderName.Location = New System.Drawing.Point(184, 45)
        Me.txtSenderName.Name = "txtSenderName"
        Me.txtSenderName.Size = New System.Drawing.Size(567, 19)
        Me.txtSenderName.TabIndex = 20
        Me.txtSenderName.Text = "吉本"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 14.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(13, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 19)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "■自社メールアドレス"
        '
        'txtSenderMail
        '
        Me.txtSenderMail.Location = New System.Drawing.Point(183, 119)
        Me.txtSenderMail.Name = "txtSenderMail"
        Me.txtSenderMail.Size = New System.Drawing.Size(568, 19)
        Me.txtSenderMail.TabIndex = 22
        Me.txtSenderMail.Text = "xxxx@abc.co.jp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(13, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 19)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "■電話番号"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(184, 79)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(567, 19)
        Me.txtPhoneNumber.TabIndex = 24
        Me.txtPhoneNumber.Text = "0566-12-3456"
        '
        'txtRecieverName
        '
        Me.txtRecieverName.Location = New System.Drawing.Point(184, 52)
        Me.txtRecieverName.Name = "txtRecieverName"
        Me.txtRecieverName.Size = New System.Drawing.Size(567, 19)
        Me.txtRecieverName.TabIndex = 26
        Me.txtRecieverName.Text = "山田"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 14.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(13, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "■宛名"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCompany)
        Me.GroupBox1.Controls.Add(Me.Label0)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSenderMail)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSenderName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(864, 151)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "自社情報"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmbPurpuse)
        Me.GroupBox2.Controls.Add(Me.txtRecieverName)
        Me.GroupBox2.Controls.Add(Me.txtCustomer)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.label9)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker0)
        Me.GroupBox2.Controls.Add(Me.txtMinute)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtHour)
        Me.GroupBox2.Controls.Add(Me.txtRecieverMail)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(864, 198)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "客先情報"
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.SystemColors.Control
        Me.LabelTitle.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LabelTitle.Location = New System.Drawing.Point(329, 9)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(211, 24)
        Me.LabelTitle.TabIndex = 3
        Me.LabelTitle.Text = "--ChatGPT体験--"
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.BackColor = System.Drawing.SystemColors.Control
        Me.LabelDescription.Font = New System.Drawing.Font("MS UI Gothic", 14.25!)
        Me.LabelDescription.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelDescription.Location = New System.Drawing.Point(149, 33)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(591, 38)
        Me.LabelDescription.TabIndex = 29
        Me.LabelDescription.Text = "会社名、客先、要件、日時などを設定することで自動的に文書を生成します。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "メールアドレスを設定した場合、自動的にメールを送信します。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LabelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbModel)
        Me.GroupBox3.Controls.Add(Me.txtAPIKey)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 438)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(864, 59)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ChatGPTの要件"
        '
        'cmbModel
        '
        Me.cmbModel.BackColor = System.Drawing.SystemColors.Window
        Me.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModel.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.cmbModel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Location = New System.Drawing.Point(643, 19)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(108, 20)
        Me.cmbModel.TabIndex = 5
        '
        'txtAPIKey
        '
        Me.txtAPIKey.Location = New System.Drawing.Point(199, 18)
        Me.txtAPIKey.Name = "txtAPIKey"
        Me.txtAPIKey.Size = New System.Drawing.Size(341, 19)
        Me.txtAPIKey.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("MS UI Gothic", 14.25!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(546, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 19)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "■AIモデル"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 14.25!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(28, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 19)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "■APIキー"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 634)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label0 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker0 As DateTimePicker
    Friend WithEvents cmbPurpuse As ComboBox
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRecieverMail As TextBox
    Friend WithEvents txtHour As TextBox
    Friend WithEvents txtMinute As TextBox
    Friend WithEvents label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSenderName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSenderMail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtRecieverName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelDescription As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbModel As ComboBox
    Friend WithEvents txtAPIKey As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
End Class

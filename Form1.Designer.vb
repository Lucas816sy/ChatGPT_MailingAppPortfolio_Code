<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnFix = New System.Windows.Forms.Button()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtFix = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtRecieverMail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblCover = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFix
        '
        Me.btnFix.Font = New System.Drawing.Font("MS UI Gothic", 15.75!)
        Me.btnFix.Location = New System.Drawing.Point(792, 404)
        Me.btnFix.Name = "btnFix"
        Me.btnFix.Size = New System.Drawing.Size(245, 28)
        Me.btnFix.TabIndex = 0
        Me.btnFix.Text = "メール文の内容を修正する"
        Me.btnFix.UseVisualStyleBackColor = True
        '
        'txtSubject
        '
        Me.txtSubject.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.Location = New System.Drawing.Point(41, 50)
        Me.txtSubject.Multiline = True
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSubject.Size = New System.Drawing.Size(996, 350)
        Me.txtSubject.TabIndex = 1
        Me.txtSubject.Text = "文章を生成中..."
        '
        'txtFix
        '
        Me.txtFix.Font = New System.Drawing.Font("MS UI Gothic", 15.75!)
        Me.txtFix.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtFix.Location = New System.Drawing.Point(103, 404)
        Me.txtFix.Name = "txtFix"
        Me.txtFix.Size = New System.Drawing.Size(683, 28)
        Me.txtFix.TabIndex = 2
        Me.txtFix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSend
        '
        Me.btnSend.Enabled = False
        Me.btnSend.Font = New System.Drawing.Font("MS UI Gothic", 15.75!)
        Me.btnSend.Location = New System.Drawing.Point(241, 496)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(585, 70)
        Me.btnSend.TabIndex = 3
        Me.btnSend.Text = "送信"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtRecieverMail
        '
        Me.txtRecieverMail.Font = New System.Drawing.Font("MS UI Gothic", 15.75!)
        Me.txtRecieverMail.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtRecieverMail.Location = New System.Drawing.Point(103, 453)
        Me.txtRecieverMail.Name = "txtRecieverMail"
        Me.txtRecieverMail.Size = New System.Drawing.Size(683, 28)
        Me.txtRecieverMail.TabIndex = 4
        Me.txtRecieverMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.75!)
        Me.Label1.Location = New System.Drawing.Point(41, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "件名:"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("MS UI Gothic", 15.75!)
        Me.txtTitle.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtTitle.Location = New System.Drawing.Point(103, 10)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(915, 28)
        Me.txtTitle.TabIndex = 6
        Me.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCover
        '
        Me.lblCover.AutoSize = True
        Me.lblCover.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCover.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.lblCover.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblCover.Location = New System.Drawing.Point(117, 408)
        Me.lblCover.Name = "lblCover"
        Me.lblCover.Size = New System.Drawing.Size(603, 22)
        Me.lblCover.TabIndex = 7
        Me.lblCover.Text = "           ChatGPTに対して修正内容がある場合はここに入力         "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 15.75!)
        Me.Label3.Location = New System.Drawing.Point(41, 457)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "宛先:"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(874, 516)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(163, 50)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "リセット"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 578)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCover)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRecieverMail)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtFix)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.btnFix)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFix As Button
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtFix As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents txtRecieverMail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblCover As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnReset As Button
End Class

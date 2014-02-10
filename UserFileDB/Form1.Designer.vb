<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.loadPlainBtn = New System.Windows.Forms.Button()
        Me.loadEncryptedBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.passTxt = New System.Windows.Forms.TextBox()
        Me.newPlainBtn = New System.Windows.Forms.Button()
        Me.userEncyptedBtn = New System.Windows.Forms.Button()
        Me.binBtn = New System.Windows.Forms.Button()
        Me.loadBinBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File Content:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(335, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'loadPlainBtn
        '
        Me.loadPlainBtn.Location = New System.Drawing.Point(15, 192)
        Me.loadPlainBtn.Name = "loadPlainBtn"
        Me.loadPlainBtn.Size = New System.Drawing.Size(75, 23)
        Me.loadPlainBtn.TabIndex = 2
        Me.loadPlainBtn.Text = "Load Plain"
        Me.loadPlainBtn.UseVisualStyleBackColor = True
        '
        'loadEncryptedBtn
        '
        Me.loadEncryptedBtn.Location = New System.Drawing.Point(96, 192)
        Me.loadEncryptedBtn.Name = "loadEncryptedBtn"
        Me.loadEncryptedBtn.Size = New System.Drawing.Size(96, 23)
        Me.loadEncryptedBtn.TabIndex = 3
        Me.loadEncryptedBtn.Text = "Load Encypted"
        Me.loadEncryptedBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(372, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username:"
        '
        'userTxt
        '
        Me.userTxt.Location = New System.Drawing.Point(436, 33)
        Me.userTxt.Name = "userTxt"
        Me.userTxt.Size = New System.Drawing.Size(100, 20)
        Me.userTxt.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(372, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password:"
        '
        'passTxt
        '
        Me.passTxt.Location = New System.Drawing.Point(436, 60)
        Me.passTxt.Name = "passTxt"
        Me.passTxt.Size = New System.Drawing.Size(100, 20)
        Me.passTxt.TabIndex = 7
        Me.passTxt.UseSystemPasswordChar = True
        '
        'newPlainBtn
        '
        Me.newPlainBtn.Location = New System.Drawing.Point(375, 101)
        Me.newPlainBtn.Name = "newPlainBtn"
        Me.newPlainBtn.Size = New System.Drawing.Size(75, 23)
        Me.newPlainBtn.TabIndex = 8
        Me.newPlainBtn.Text = "Plain User"
        Me.newPlainBtn.UseVisualStyleBackColor = True
        '
        'userEncyptedBtn
        '
        Me.userEncyptedBtn.Location = New System.Drawing.Point(461, 101)
        Me.userEncyptedBtn.Name = "userEncyptedBtn"
        Me.userEncyptedBtn.Size = New System.Drawing.Size(75, 23)
        Me.userEncyptedBtn.TabIndex = 9
        Me.userEncyptedBtn.Text = "Encypted User"
        Me.userEncyptedBtn.UseVisualStyleBackColor = True
        '
        'binBtn
        '
        Me.binBtn.Location = New System.Drawing.Point(542, 101)
        Me.binBtn.Name = "binBtn"
        Me.binBtn.Size = New System.Drawing.Size(75, 23)
        Me.binBtn.TabIndex = 10
        Me.binBtn.Text = "Binary"
        Me.binBtn.UseVisualStyleBackColor = True
        '
        'loadBinBtn
        '
        Me.loadBinBtn.Location = New System.Drawing.Point(198, 192)
        Me.loadBinBtn.Name = "loadBinBtn"
        Me.loadBinBtn.Size = New System.Drawing.Size(75, 23)
        Me.loadBinBtn.TabIndex = 11
        Me.loadBinBtn.Text = "Load Binary"
        Me.loadBinBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 225)
        Me.Controls.Add(Me.loadBinBtn)
        Me.Controls.Add(Me.binBtn)
        Me.Controls.Add(Me.userEncyptedBtn)
        Me.Controls.Add(Me.newPlainBtn)
        Me.Controls.Add(Me.passTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.userTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.loadEncryptedBtn)
        Me.Controls.Add(Me.loadPlainBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents loadPlainBtn As System.Windows.Forms.Button
    Friend WithEvents loadEncryptedBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents userTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents passTxt As System.Windows.Forms.TextBox
    Friend WithEvents newPlainBtn As System.Windows.Forms.Button
    Friend WithEvents userEncyptedBtn As System.Windows.Forms.Button
    Friend WithEvents binBtn As System.Windows.Forms.Button
    Friend WithEvents loadBinBtn As System.Windows.Forms.Button

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtFilePath = New TextBox()
        btnBrowse = New Button()
        Label2 = New Label()
        lstResult = New ListBox()
        lblStatus = New Label()
        lblStat = New Label()
        btnReset = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        btnSave = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(28, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(211, 37)
        Label1.TabIndex = 0
        Label1.Text = "LOG ANALYZER"
        ' 
        ' txtFilePath
        ' 
        txtFilePath.Location = New Point(28, 83)
        txtFilePath.Name = "txtFilePath"
        txtFilePath.ReadOnly = True
        txtFilePath.Size = New Size(229, 23)
        txtFilePath.TabIndex = 1
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(263, 83)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(75, 23)
        btnBrowse.TabIndex = 2
        btnBrowse.Text = "BROWSE"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(28, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 32)
        Label2.TabIndex = 3
        Label2.Text = "Hasil Analisis:"
        ' 
        ' lstResult
        ' 
        lstResult.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstResult.FormattingEnabled = True
        lstResult.ItemHeight = 21
        lstResult.Location = New Point(28, 181)
        lstResult.Name = "lstResult"
        lstResult.Size = New Size(569, 130)
        lstResult.TabIndex = 4
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(31, 385)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(0, 15)
        lblStatus.TabIndex = 5
        ' 
        ' lblStat
        ' 
        lblStat.AutoSize = True
        lblStat.Location = New Point(28, 349)
        lblStat.Name = "lblStat"
        lblStat.Size = New Size(114, 15)
        lblStat.TabIndex = 6
        lblStat.Text = "Menunggu file log..."
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(341, 349)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 23)
        btnReset.TabIndex = 7
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "Log Files (*.log;*.txt)|*.log;*.txt|All Files (*.*)|*.*"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(434, 349)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 8
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSave)
        Controls.Add(btnReset)
        Controls.Add(lblStat)
        Controls.Add(lblStatus)
        Controls.Add(lstResult)
        Controls.Add(Label2)
        Controls.Add(btnBrowse)
        Controls.Add(txtFilePath)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lstResult As ListBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblStat As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnSave As Button

End Class

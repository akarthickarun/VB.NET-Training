<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        StartButton = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label1 = New Label()
        lblFilesCount = New Label()
        Label3 = New Label()
        lblTotalSize = New Label()
        StopButton = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(130, 59)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(404, 27)
        TextBox1.TabIndex = 0
        TextBox1.Text = "D:\Karthick\Data\enron_mail_20150507"
        ' 
        ' StartButton
        ' 
        StartButton.Location = New Point(130, 92)
        StartButton.Name = "StartButton"
        StartButton.Size = New Size(94, 29)
        StartButton.TabIndex = 1
        StartButton.Text = "&Start"
        StartButton.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(lblFilesCount, 1, 0)
        TableLayoutPanel1.Controls.Add(Label3, 0, 1)
        TableLayoutPanel1.Controls.Add(lblTotalSize, 1, 1)
        TableLayoutPanel1.Location = New Point(130, 237)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(404, 187)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' lblFilesCount
        ' 
        lblFilesCount.AutoSize = True
        lblFilesCount.Location = New Point(205, 0)
        lblFilesCount.Name = "lblFilesCount"
        lblFilesCount.Size = New Size(53, 20)
        lblFilesCount.TabIndex = 1
        lblFilesCount.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 2
        Label3.Text = "Label3"
        ' 
        ' lblTotalSize
        ' 
        lblTotalSize.AutoSize = True
        lblTotalSize.Location = New Point(205, 93)
        lblTotalSize.Name = "lblTotalSize"
        lblTotalSize.Size = New Size(53, 20)
        lblTotalSize.TabIndex = 3
        lblTotalSize.Text = "Label4"
        ' 
        ' StopButton
        ' 
        StopButton.Location = New Point(440, 92)
        StopButton.Name = "StopButton"
        StopButton.Size = New Size(94, 29)
        StopButton.TabIndex = 3
        StopButton.Text = "Sto&p"
        StopButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(StopButton)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(StartButton)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents StartButton As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFilesCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalSize As Label
    Friend WithEvents StopButton As Button

End Class

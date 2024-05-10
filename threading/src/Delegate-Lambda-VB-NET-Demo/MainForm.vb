Imports System.IO
Imports System.Threading
Imports System.Threading.Tasks

Public Class MainForm

    Private _cts As CancellationTokenSource = Nothing

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Dim folderPath As String = TextBox1.Text

        If Not Directory.Exists(folderPath) Then
            MessageBox.Show("Folder does not exist")
            Return
        End If

        ' Start a new thread to enumerate files
        'Dim thread As New Thread(Sub() EnumerateFiles(folderPath))
        'thread.Start()

        ' Create a task cancellation token source
        If _cts Is Nothing Then _cts = New CancellationTokenSource
        Dim token As CancellationToken = _cts.Token

        ' Create a task creation options for long running tasks
        Dim options As New TaskCreationOptions
        options = TaskCreationOptions.LongRunning

        ' Create a new long running task
        Task.Factory.StartNew(
            Sub() EnumerateFiles(folderPath, token),
            token,
            options,
            TaskScheduler.Default)

    End Sub

    Private Sub EnumerateFiles(folderPath As String, token As CancellationToken)
        ' Displaying the loading message
        BeginInvoke(Sub() lblFilesCount.Text = "Loading...")

        ' Get all files in the folder
        Dim files As IEnumerable(Of String) = Directory.EnumerateFiles(folderPath, "*", SearchOption.AllDirectories)

        ' Displaying the loading message
        BeginInvoke(Sub() Label3.Text = "Loaded.")

        ' Keep the total length of all files
        Dim fileLength As Long = 0

        ' Total number of files
        Dim fileCount As Integer = 0

        ' Loop through each file
        For Each file As String In files
            ' Get the file name
            Dim fileName As String = Path.GetFileName(file)

            ' Get the file extension
            Dim fileExtension As String = Path.GetExtension(file)

            ' Get the file size
            Dim fileSize As Long = New FileInfo(file).Length

            ' Get the file creation date
            Dim fileCreationDate As Date = System.IO.File.GetCreationTime(file)

            ' Get the file last access date
            Dim fileLastAccessDate As Date = System.IO.File.GetLastAccessTime(file)

            ' Get the file last write date
            Dim fileLastWriteDate As Date = System.IO.File.GetLastWriteTime(file)

            ' Accumulate the file length
            fileLength += fileSize

            ' Increment the file count
            fileCount += 1

            ' Update the UI on the main thread for 100 files
            If fileCount Mod 100 = 0 Then
                BeginInvoke(Sub()
                                lblFilesCount.Text = $"Total Files: {fileCount}"
                                lblTotalSize.Text = $"Total Size: {fileLength} bytes"
                            End Sub)
            End If

            If token.IsCancellationRequested Then Exit For

        Next

        BeginInvoke(Sub()
                        lblFilesCount.Text = $"Total Files: {fileCount}"
                        lblTotalSize.Text = $"Total Size: {fileLength} bytes"
                    End Sub)

    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        If _cts IsNot Nothing Then
            _cts.Cancel()
            _cts.Dispose()
            _cts = Nothing
        End If
    End Sub

End Class

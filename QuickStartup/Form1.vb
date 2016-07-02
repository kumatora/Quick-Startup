Imports System.IO

Public Class startupForm

    Private Sub addFileButton_Click(sender As System.Object, e As System.EventArgs) Handles addFileButton.Click

        Try
            Dim fd As OpenFileDialog = New OpenFileDialog()
            Dim strFileName As String = ""

            fd.Title = "Select a file"
            fd.InitialDirectory = Directory.GetCurrentDirectory
            fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"

            If fd.ShowDialog() = DialogResult.OK Then
                strFileName = fd.FileName
            End If

            filesListBox.Items.Add(strFileName)

        Catch ex As Exception
            MsgBox("Exception caught: " & ex.Message)
        End Try

    End Sub

    Private Sub generateButton_Click(sender As System.Object, e As System.EventArgs) Handles generateButton.Click

        Try
            If (nameFileTextbox.Text <> "") Then
                Dim fd = File.Create(Directory.GetCurrentDirectory & "/" & nameFileTextbox.Text & ".bat")
                fd.Close()

                Dim newFile As New StreamWriter(Directory.GetCurrentDirectory & "/" & nameFileTextbox.Text & ".bat")

                For Each i In filesListBox.Items()
                    newFile.WriteLine("START """" """ & i & """")
                Next

                newFile.Close()

            Else
                MsgBox("Startup requires a name!")
            End If

        Catch ex As Exception
            MsgBox("Exception caught: " & ex.Message)
        End Try

    End Sub

    Private Sub closeButton_Click(sender As System.Object, e As System.EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        nameFileTextbox.Clear()
        filesListBox.Items.Clear()
    End Sub
End Class

Imports System.IO
Imports System.Windows.Forms
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Wordprocessing

Public Class Form1
    Private Sub btnSelectFolder_Click(sender As Object, e As EventArgs)

        Dim folderBrowserDialog As New FolderBrowserDialog()
        folderBrowserDialog.Description = "Select the folder"
        folderBrowserDialog.ShowNewFolderButton = False
        folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop


        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            txtFolder.Text = folderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub btnProcessFolder_Click(sender As Object, e As EventArgs)
        Dim filesInFolder As String() = Directory.GetFiles(txtFolder.Text)

        txtProcessFileNumber.Text = filesInFolder.Length & " file(s) Processed"

        For Each file As String In filesInFolder

            Dim fileName As String = Path.GetFileName(file)

            Dim fileExtension As String = Path.GetExtension(file)


            Select Case fileExtension
                Case ".txt", ".xlsx", ".docx", ".pptx"
                    If Not Directory.Exists(txtFolder.Text & "\Docs") Then
                        Directory.CreateDirectory(txtFolder.Text & "\Docs")
                    End If
                    file.Remove(file, Path.Combine(txtFolder.Text, "Docs", fileName))

                Case ".jpg", ".jpeg", ".png"
                    If Not Directory.Exists(txtFolder.Text & "\Pics") Then
                        Directory.CreateDirectory(txtFolder.Text & "\Pics")
                    End If
                    file.Remove(file, Path.Combine(txtFolder.Text, "Pics", fileName))

                Case Else
                    If Not Directory.Exists(txtFolder.Text & "\Other") Then
                        Directory.CreateDirectory(txtFolder.Text & "\Other")
                    End If
                    file.Remove(file, Path.Combine(txtFolder.Text, "Other", fileName))
            End Select
        Next
    End Sub

    Private Sub btnOpenTextFile_Click(sender As Object, e As EventArgs)
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "Text Files|*.txt"
        dialog.Title = "Select a text file"

        If dialog.ShowDialog() = DialogResult.OK Then
            txtContent.Text = File.ReadAllText(dialog.FileName)
        End If
    End Sub

    Private Sub btnSaveTextFile_Click(sender As Object, e As EventArgs)
        Dim dialog As New SaveFileDialog()
        dialog.Filter = "Text Files|*.txt"
        dialog.Title = "Save the text file"

        If dialog.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(dialog.FileName, txtContent.Text)
        End If
    End Sub

    Private Sub btnSave_document_Click(sender As Object, e As EventArgs)
        Dim text As String = txtContent.Text
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Word Document (*.docx)|*.docx"
        saveFileDialog1.ShowDialog()

        If saveFileDialog1.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Using wordDocument As WordprocessingDocument = WordprocessingDocument.Create(saveFileDialog1.FileName, DocumentFormat.OpenXml.WordprocessingDocumentType.Document)
            Dim mainPart As MainDocumentPart = wordDocument.AddMainDocumentPart()
            mainPart.Document = New Document()
            Dim body As Body = mainPart.Document.AppendChild(New Body())
            Dim paragraph As Paragraph = body.AppendChild(New Paragraph())
            Dim run As Run = paragraph.AppendChild(New Run())
            run.AppendChild(New Text(text))
        End Using

        MessageBox.Show("Document saved successfully")
    End Sub
End Class
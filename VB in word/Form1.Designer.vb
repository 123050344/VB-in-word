<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtFolder = New TextBox()
        btnOpenTextFile = New Button()
        btnSelectFolder = New Button()
        btnProcessFolder = New Button()
        txtProcessFileNumber = New TextBox()
        btnSave_document = New Button()
        btnSaveTextFile = New Button()
        txtContent = New TextBox()
        SuspendLayout()
        ' 
        ' txtFolder
        ' 
        txtFolder.Location = New Point(30, 143)
        txtFolder.Multiline = True
        txtFolder.Name = "txtFolder"
        txtFolder.Size = New Size(312, 23)
        txtFolder.TabIndex = 1
        ' 
        ' btnOpenTextFile
        ' 
        btnOpenTextFile.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnOpenTextFile.Location = New Point(418, 18)
        btnOpenTextFile.Name = "btnOpenTextFile"
        btnOpenTextFile.Size = New Size(155, 44)
        btnOpenTextFile.TabIndex = 2
        btnOpenTextFile.Text = "Open Text File"
        btnOpenTextFile.UseVisualStyleBackColor = True
        ' 
        ' btnSelectFolder
        ' 
        btnSelectFolder.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSelectFolder.Location = New Point(45, 18)
        btnSelectFolder.Name = "btnSelectFolder"
        btnSelectFolder.Size = New Size(155, 44)
        btnSelectFolder.TabIndex = 4
        btnSelectFolder.Text = "Select Folder"
        btnSelectFolder.UseVisualStyleBackColor = True
        ' 
        ' btnProcessFolder
        ' 
        btnProcessFolder.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnProcessFolder.Location = New Point(595, 18)
        btnProcessFolder.Name = "btnProcessFolder"
        btnProcessFolder.Size = New Size(155, 44)
        btnProcessFolder.TabIndex = 7
        btnProcessFolder.Text = "Process Folder"
        btnProcessFolder.UseVisualStyleBackColor = True
        ' 
        ' txtProcessFileNumber
        ' 
        txtProcessFileNumber.Location = New Point(455, 143)
        txtProcessFileNumber.Multiline = True
        txtProcessFileNumber.Name = "txtProcessFileNumber"
        txtProcessFileNumber.Size = New Size(312, 23)
        txtProcessFileNumber.TabIndex = 8
        ' 
        ' btnSave_document
        ' 
        btnSave_document.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave_document.Location = New Point(239, 18)
        btnSave_document.Name = "btnSave_document"
        btnSave_document.Size = New Size(155, 44)
        btnSave_document.TabIndex = 9
        btnSave_document.Text = " Save document"
        btnSave_document.UseVisualStyleBackColor = True
        ' 
        ' btnSaveTextFile
        ' 
        btnSaveTextFile.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSaveTextFile.Location = New Point(323, 81)
        btnSaveTextFile.Name = "btnSaveTextFile"
        btnSaveTextFile.Size = New Size(155, 44)
        btnSaveTextFile.TabIndex = 10
        btnSaveTextFile.Text = "Save Text File"
        btnSaveTextFile.UseVisualStyleBackColor = True
        ' 
        ' txtContent
        ' 
        txtContent.Location = New Point(61, 187)
        txtContent.Multiline = True
        txtContent.Name = "txtContent"
        txtContent.Size = New Size(676, 225)
        txtContent.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtContent)
        Controls.Add(btnSaveTextFile)
        Controls.Add(btnSave_document)
        Controls.Add(txtProcessFileNumber)
        Controls.Add(btnProcessFolder)
        Controls.Add(btnSelectFolder)
        Controls.Add(btnOpenTextFile)
        Controls.Add(txtFolder)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtFolder As TextBox
    Friend WithEvents btnOpenTextFile As Button
    Friend WithEvents btnSelectFolder As Button
    Friend WithEvents btnProcessFolder As Button
    Friend WithEvents txtProcessFileNumber As TextBox
    Friend WithEvents btnSave_document As Button
    Friend WithEvents btnSaveTextFile As Button
    Friend WithEvents txtContent As TextBox
End Class

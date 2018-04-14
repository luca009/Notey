Imports System.IO
Imports System.IO.File
Imports System.IO.Path
Public Class Form1
	Dim sMsg As String = ""
	Dim CurrentFile As String
	Dim extention As String
	Dim OpenResult As Boolean
	Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
		If Not sfdSave.ShowDialog = DialogResult.Cancel Then
			OpenResult = True
			rtbMain.SaveFile(sfdSave.FileName)
		End If

	End Sub
    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFontSize.SelectedIndexChanged
        rtbMain.SelectionFont = New Font("Microsoft Sans Serif", cbFontSize.Text)
    End Sub

	Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
		OpenResult = False
		rtbMain.Clear()
	End Sub

	Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
		If Not ofdOpen.ShowDialog = DialogResult.Cancel Then
			extention = IO.Path.GetExtension(ofdOpen.FileName)
			OpenResult = True
			If extention = ".rtf" Then
				CurrentFile = ofdOpen.FileName
				rtbMain.LoadFile(ofdOpen.FileName)
			End If
		End If
	End Sub

	Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
		Me.Close()
	End Sub

	Private Sub AboutNoteydToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutNoteydToolStripMenuItem.Click
		AboutBox1.Show()
	End Sub

	Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
		If OpenResult Then
			rtbMain.SaveFile(CurrentFile)
		ElseIf OpenResult Then
			rtbMain.SaveFile(CurrentFile)
		Else
			If Not sfdSave.ShowDialog = DialogResult.Cancel Then
				OpenResult = True
				CurrentFile = sfdSave.FileName
				rtbMain.SaveFile(sfdSave.FileName)
			End If
		End If
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		For Each sArg As String In My.Application.CommandLineArgs
			sMsg &= sArg & ""
		Next
		If Not sMsg = Nothing Then
            OpenResult = True
            extention = IO.Path.GetExtension(sMsg)
            If extention = ".rtf" Then
                CurrentFile = sMsg
                rtbMain.LoadFile(sMsg)
            End If
        End If
	End Sub

	Private Sub WebBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebBrowserToolStripMenuItem.Click
		Form2.Show()
	End Sub
End Class

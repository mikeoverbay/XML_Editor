

Imports System.IO
Imports System.String
Imports System.Text
Imports FastColoredTextBoxNS
Imports System.Linq
Imports System.Diagnostics
Imports System.Drawing
Imports System.Collections.Generic
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text.RegularExpressions
Imports System.Drawing.Drawing2D
Imports System.Xml
Imports System.Windows.Forms.SystemInformation

Public Class frmSetColors
	Dim otag As String
	Dim c_copy As Panel = Nothing

	Private Sub frmSetColors_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		e.Cancel = True
		Me.Hide()
	End Sub


	Private Sub frmSetColors_Load(sender As Object, e As EventArgs) Handles Me.Load

		assign_events()
		add_color_labels()

	End Sub
	Private Sub assign_events()
		AddHandler nums_.MouseClick, AddressOf switch_button
		AddHandler tags_.MouseClick, AddressOf switch_button
		AddHandler texture_.MouseClick, AddressOf switch_button
		AddHandler properties_.MouseClick, AddressOf switch_button
		AddHandler allother.MouseClick, AddressOf switch_button
	End Sub
	Private Sub add_color_labels()
		Dim colorname As String
		Dim x = Panel2.Width
		Dim y As Integer = 30 ' we will what to change this
		Dim v As Integer = 0
		For c As Integer = 28 To 167
			colorname = Convert.ToString(Color.FromKnownColor(CType(c, KnownColor)))

			colorname = colorname.Substring(7, colorname.Length - 8)
			Dim l As New Label
			l.Width = x - VerticalScrollBarWidth
			l.Height = y
			l.Parent = Panel2
			l.Location = New Point(0, v * y)
			l.BackColor = Color.FromName(colorname)
			l.Text = colorname
			l.ForeColor = InvertColor(Color.FromName(colorname))
			AddHandler l.MouseClick, AddressOf colorChange

			v += 1
		Next
	End Sub
	Private Function InvertColor(ByVal sourceColor As Color) As Color
		Dim l = Math.Sqrt((sourceColor.R ^ 2) + (sourceColor.G ^ 2) + (sourceColor.B ^ 2)) / 3
		Dim r, g, b As Byte
		If l > 0 Then
			r = sourceColor.R / l
			g = sourceColor.G / l
			b = sourceColor.B / l
		Else
			r = 255
			g = 255
			b = 255
		End If
		Return Color.FromArgb(r, g, b)
	End Function

	Private Sub colorChange(sender As Object, e As System.EventArgs)
		If c_copy Is Nothing Then
			MsgBox("Select the style you want to set this color to first.", MsgBoxStyle.OkOnly, " ")
			Return
		End If
		c_copy.BackColor = sender.BackColor
		colors(CInt(c_copy.Tag)) = c_copy.BackColor
		frmMain.set_styles()
	End Sub
	Private Sub switch_button(sender As Object, e As System.EventArgs)
		If otag = sender.tag Then
			Return
		End If
		If c_copy Is Nothing Then
			c_copy = sender
			c_copy.BorderStyle = BorderStyle.Fixed3D
			Return
		End If
		c_copy.BorderStyle = BorderStyle.None
		c_copy = sender
		otag = sender.tag
		c_copy.BorderStyle = BorderStyle.Fixed3D

	End Sub
	Private Sub set_boxes()
		frmMain.set_styles()
	End Sub

	Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
		If sender.checked Then
			text_style(0) = 1
		Else
			text_style(0) = 0
		End If
		set_boxes()
	End Sub

	Private Sub cb2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
		If sender.checked Then
			text_style(1) = 1
		Else
			text_style(1) = 0
		End If
		set_boxes()
	End Sub

	Private Sub cb3_CheckedChanged(sender As Object, e As EventArgs) Handles cb3.CheckedChanged
		If sender.checked Then
			text_style(2) = 1
		Else
			text_style(2) = 0
		End If
		set_boxes()
	End Sub

	Private Sub cb4_CheckedChanged(sender As Object, e As EventArgs) Handles cb4.CheckedChanged
		If sender.checked Then
			text_style(3) = 1
		Else
			text_style(3) = 0
		End If
		set_boxes()
	End Sub

	Private Sub cb5_CheckedChanged(sender As Object, e As EventArgs) Handles cb5.CheckedChanged
		If sender.checked Then
			text_style(4) = 1
		Else
			text_style(4) = 0
		End If
		set_boxes()
	End Sub


End Class
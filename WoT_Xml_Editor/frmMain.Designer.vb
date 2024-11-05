<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.m_search_text = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.m_Select_Font = New System.Windows.Forms.ToolStripSeparator()
        Me.m_edit_Filter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.fctb = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.fctb_context_strip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.seperator = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.cm_cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.cm_copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.cm_paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.cm_delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.cm_undo = New System.Windows.Forms.ToolStripMenuItem()
        Me.cm_redo = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.m_save_as = New System.Windows.Forms.ToolStripButton()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.m_Delete = New System.Windows.Forms.ToolStripButton()
        Me.m_undo = New System.Windows.Forms.ToolStripButton()
        Me.m_redo = New System.Windows.Forms.ToolStripButton()
        Me.m_search = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.m_set_colors = New System.Windows.Forms.ToolStripButton()
        Me.m_help = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.fctb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fctb_context_strip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripButton, Me.SaveToolStripButton, Me.m_save_as, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.m_Delete, Me.ToolStripSeparator3, Me.m_undo, Me.m_redo, Me.ToolStripSeparator2, Me.m_search_text, Me.m_search, Me.ToolStripSeparator5, Me.ToolStripButton1, Me.m_Select_Font, Me.m_edit_Filter, Me.m_set_colors, Me.ToolStripSeparator6, Me.m_help})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(5, 0, 1, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(749, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'm_search_text
        '
        Me.m_search_text.AcceptsReturn = True
        Me.m_search_text.AutoSize = False
        Me.m_search_text.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.m_search_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.m_search_text.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.m_search_text.Name = "m_search_text"
        Me.m_search_text.Size = New System.Drawing.Size(199, 23)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'm_Select_Font
        '
        Me.m_Select_Font.Name = "m_Select_Font"
        Me.m_Select_Font.Size = New System.Drawing.Size(6, 25)
        '
        'm_edit_Filter
        '
        Me.m_edit_Filter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.m_edit_Filter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_edit_Filter.Name = "m_edit_Filter"
        Me.m_edit_Filter.Size = New System.Drawing.Size(99, 22)
        Me.m_edit_Filter.Text = "Edit Filter Strings"
        Me.m_edit_Filter.ToolTipText = "Edit Filter List" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "These are the tags tags that usually follow the <property> tag" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "They mess up the XML format and have to be handled."
        Me.m_edit_Filter.Visible = False
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'fctb
        '
        Me.fctb.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.fctb.AutoIndent = False
        Me.fctb.AutoIndentChars = False
        Me.fctb.AutoIndentCharsPatterns = ""
        Me.fctb.AutoIndentExistingLines = False
        Me.fctb.AutoScrollMinSize = New System.Drawing.Size(27, 12)
        Me.fctb.BackBrush = Nothing
        Me.fctb.BackColor = System.Drawing.Color.Black
        Me.fctb.CaretColor = System.Drawing.Color.White
        Me.fctb.CharHeight = 12
        Me.fctb.CharWidth = 8
        Me.fctb.CommentPrefix = Nothing
        Me.fctb.ContextMenuStrip = Me.fctb_context_strip
        Me.fctb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fctb.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.fctb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fctb.Font = New System.Drawing.Font("Lucida Console", 9.75!)
        Me.fctb.ForeColor = System.Drawing.Color.White
        Me.fctb.HighlightFoldingIndicator = False
        Me.fctb.IndentBackColor = System.Drawing.Color.DimGray
        Me.fctb.IsReplaceMode = False
        Me.fctb.LeftBracket = Global.Microsoft.VisualBasic.ChrW(60)
        Me.fctb.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(40)
        Me.fctb.LineNumberColor = System.Drawing.Color.White
        Me.fctb.Location = New System.Drawing.Point(0, 25)
        Me.fctb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.fctb.Name = "fctb"
        Me.fctb.PaddingBackColor = System.Drawing.SystemColors.WindowFrame
        Me.fctb.Paddings = New System.Windows.Forms.Padding(0)
        Me.fctb.RightBracket = Global.Microsoft.VisualBasic.ChrW(62)
        Me.fctb.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(41)
        Me.fctb.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.fctb.ServiceColors = CType(resources.GetObject("fctb.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.fctb.Size = New System.Drawing.Size(749, 480)
        Me.fctb.TabIndex = 1
        Me.fctb.TabLength = 3
        Me.fctb.Zoom = 100
        '
        'fctb_context_strip
        '
        Me.fctb_context_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cm_cut, Me.cm_copy, Me.cm_paste, Me.ToolStripSeparator4, Me.cm_delete, Me.seperator, Me.cm_undo, Me.cm_redo})
        Me.fctb_context_strip.Name = "ContextMenuStrip1"
        Me.fctb_context_strip.Size = New System.Drawing.Size(108, 148)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(104, 6)
        '
        'seperator
        '
        Me.seperator.Name = "seperator"
        Me.seperator.Size = New System.Drawing.Size(104, 6)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cm_cut
        '
        Me.cm_cut.Image = CType(resources.GetObject("cm_cut.Image"), System.Drawing.Image)
        Me.cm_cut.Name = "cm_cut"
        Me.cm_cut.Size = New System.Drawing.Size(107, 22)
        Me.cm_cut.Text = "Cut"
        '
        'cm_copy
        '
        Me.cm_copy.Image = CType(resources.GetObject("cm_copy.Image"), System.Drawing.Image)
        Me.cm_copy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cm_copy.Name = "cm_copy"
        Me.cm_copy.Size = New System.Drawing.Size(107, 22)
        Me.cm_copy.Text = "Copy"
        '
        'cm_paste
        '
        Me.cm_paste.Image = CType(resources.GetObject("cm_paste.Image"), System.Drawing.Image)
        Me.cm_paste.Name = "cm_paste"
        Me.cm_paste.Size = New System.Drawing.Size(107, 22)
        Me.cm_paste.Text = "Paste"
        '
        'cm_delete
        '
        Me.cm_delete.Image = Global.xml_editor.My.Resources.Resources.delete
        Me.cm_delete.Name = "cm_delete"
        Me.cm_delete.Size = New System.Drawing.Size(107, 22)
        Me.cm_delete.Text = "Delete"
        '
        'cm_undo
        '
        Me.cm_undo.Image = Global.xml_editor.My.Resources.Resources.Undo_16x_32
        Me.cm_undo.ImageTransparentColor = System.Drawing.Color.Black
        Me.cm_undo.Name = "cm_undo"
        Me.cm_undo.Size = New System.Drawing.Size(107, 22)
        Me.cm_undo.Text = "Undo"
        '
        'cm_redo
        '
        Me.cm_redo.Image = Global.xml_editor.My.Resources.Resources.Redo_16x_32
        Me.cm_redo.ImageTransparentColor = System.Drawing.Color.Black
        Me.cm_redo.Name = "cm_redo"
        Me.cm_redo.Size = New System.Drawing.Size(107, 22)
        Me.cm_redo.Text = "Redo"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'm_save_as
        '
        Me.m_save_as.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.m_save_as.Image = Global.xml_editor.My.Resources.Resources.disk
        Me.m_save_as.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_save_as.Name = "m_save_as"
        Me.m_save_as.Size = New System.Drawing.Size(23, 22)
        Me.m_save_as.Text = "ToolStripButton2"
        Me.m_save_as.ToolTipText = "Save As..."
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CutToolStripButton.Text = "C&ut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'm_Delete
        '
        Me.m_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.m_Delete.Image = Global.xml_editor.My.Resources.Resources.delete
        Me.m_Delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_Delete.Name = "m_Delete"
        Me.m_Delete.Size = New System.Drawing.Size(23, 22)
        Me.m_Delete.Text = "ToolStripButton2"
        Me.m_Delete.ToolTipText = "Delete"
        '
        'm_undo
        '
        Me.m_undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.m_undo.Image = Global.xml_editor.My.Resources.Resources.Undo_16x_32
        Me.m_undo.ImageTransparentColor = System.Drawing.Color.Black
        Me.m_undo.Name = "m_undo"
        Me.m_undo.Size = New System.Drawing.Size(23, 22)
        Me.m_undo.Text = "ToolStripButton1"
        Me.m_undo.ToolTipText = "Undo"
        '
        'm_redo
        '
        Me.m_redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.m_redo.Image = Global.xml_editor.My.Resources.Resources.Redo_16x_32
        Me.m_redo.ImageTransparentColor = System.Drawing.Color.Black
        Me.m_redo.Name = "m_redo"
        Me.m_redo.Size = New System.Drawing.Size(23, 22)
        Me.m_redo.Text = "ToolStripButton1"
        Me.m_redo.ToolTipText = "Redo"
        '
        'm_search
        '
        Me.m_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.m_search.Image = Global.xml_editor.My.Resources.Resources.Find
        Me.m_search.ImageTransparentColor = System.Drawing.Color.Black
        Me.m_search.Name = "m_search"
        Me.m_search.Size = New System.Drawing.Size(23, 22)
        Me.m_search.Text = "ToolStripButton1"
        Me.m_search.ToolTipText = "Seaarch"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.xml_editor.My.Resources.Resources.fonfont
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Font"
        '
        'm_set_colors
        '
        Me.m_set_colors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.m_set_colors.Image = Global.xml_editor.My.Resources.Resources.ColorDialog_671_24
        Me.m_set_colors.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_set_colors.Name = "m_set_colors"
        Me.m_set_colors.Size = New System.Drawing.Size(23, 22)
        Me.m_set_colors.ToolTipText = "Set Colors"
        '
        'm_help
        '
        Me.m_help.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.m_help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.m_help.Image = Global.xml_editor.My.Resources.Resources.AllAnnotations_Help_24x24_72
        Me.m_help.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_help.Name = "m_help"
        Me.m_help.Size = New System.Drawing.Size(23, 22)
        Me.m_help.Text = "ToolStripButton2"
        Me.m_help.ToolTipText = "Help"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 505)
        Me.Controls.Add(Me.fctb)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmMain"
        Me.Text = "Wot XML Editor"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.fctb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fctb_context_strip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
	Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
	Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents CutToolStripButton As System.Windows.Forms.ToolStripButton
	Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
	Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
	Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents fctb As FastColoredTextBoxNS.FastColoredTextBox
	Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
	Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
	Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents m_search_text As System.Windows.Forms.ToolStripTextBox
	Friend WithEvents m_search As System.Windows.Forms.ToolStripButton
	Friend WithEvents m_Delete As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents m_undo As System.Windows.Forms.ToolStripButton
	Friend WithEvents m_redo As System.Windows.Forms.ToolStripButton
	Friend WithEvents m_edit_Filter As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
	Friend WithEvents m_Select_Font As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
	Friend WithEvents fctb_context_strip As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents cm_cut As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents cm_copy As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents cm_paste As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents cm_delete As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents seperator As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents cm_undo As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents cm_redo As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents m_set_colors As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents m_help As System.Windows.Forms.ToolStripButton
    Friend WithEvents m_save_as As ToolStripButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetColors
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
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.cb5 = New System.Windows.Forms.CheckBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.cb4 = New System.Windows.Forms.CheckBox()
		Me.cb3 = New System.Windows.Forms.CheckBox()
		Me.cb2 = New System.Windows.Forms.CheckBox()
		Me.cb1 = New System.Windows.Forms.CheckBox()
		Me.allother = New System.Windows.Forms.Panel()
		Me.properties_ = New System.Windows.Forms.Panel()
		Me.texture_ = New System.Windows.Forms.Panel()
		Me.tags_ = New System.Windows.Forms.Panel()
		Me.nums_ = New System.Windows.Forms.Panel()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Panel1.Controls.Add(Me.cb5)
		Me.Panel1.Controls.Add(Me.cb4)
		Me.Panel1.Controls.Add(Me.cb3)
		Me.Panel1.Controls.Add(Me.cb2)
		Me.Panel1.Controls.Add(Me.cb1)
		Me.Panel1.Controls.Add(Me.allother)
		Me.Panel1.Controls.Add(Me.properties_)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.texture_)
		Me.Panel1.Controls.Add(Me.tags_)
		Me.Panel1.Controls.Add(Me.nums_)
		Me.Panel1.Controls.Add(Me.Label5)
		Me.Panel1.Controls.Add(Me.Label4)
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(131, 323)
		Me.Panel1.TabIndex = 0
		'
		'cb5
		'
		Me.cb5.AutoSize = True
		Me.cb5.Checked = Global.xml_editor.My.MySettings.Default.all_c
		Me.cb5.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.xml_editor.My.MySettings.Default, "all_c", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.cb5.ForeColor = System.Drawing.Color.White
		Me.cb5.Location = New System.Drawing.Point(78, 265)
		Me.cb5.Name = "cb5"
		Me.cb5.Size = New System.Drawing.Size(47, 17)
		Me.cb5.TabIndex = 1
		Me.cb5.Text = "Bold"
		Me.cb5.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(5, 8)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(46, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Numeric"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.ForeColor = System.Drawing.Color.White
		Me.Label5.Location = New System.Drawing.Point(5, 265)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(69, 13)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "All other Text"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Location = New System.Drawing.Point(3, 138)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(71, 13)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "Texture Lines"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.ForeColor = System.Drawing.Color.White
		Me.Label3.Location = New System.Drawing.Point(5, 74)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(56, 13)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "XML Tags"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(3, 201)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(72, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Property Keys"
		'
		'Panel2
		'
		Me.Panel2.AutoScroll = True
		Me.Panel2.BackColor = System.Drawing.Color.Gray
		Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
		Me.Panel2.Location = New System.Drawing.Point(146, 0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(107, 323)
		Me.Panel2.TabIndex = 1
		'
		'cb4
		'
		Me.cb4.AutoSize = True
		Me.cb4.Checked = Global.xml_editor.My.MySettings.Default.prop_c
		Me.cb4.CheckState = System.Windows.Forms.CheckState.Checked
		Me.cb4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.xml_editor.My.MySettings.Default, "prop_c", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.cb4.ForeColor = System.Drawing.Color.White
		Me.cb4.Location = New System.Drawing.Point(78, 200)
		Me.cb4.Name = "cb4"
		Me.cb4.Size = New System.Drawing.Size(47, 17)
		Me.cb4.TabIndex = 1
		Me.cb4.Text = "Bold"
		Me.cb4.UseVisualStyleBackColor = True
		'
		'cb3
		'
		Me.cb3.AutoSize = True
		Me.cb3.Checked = Global.xml_editor.My.MySettings.Default.tex_c
		Me.cb3.CheckState = System.Windows.Forms.CheckState.Checked
		Me.cb3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.xml_editor.My.MySettings.Default, "tex_c", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.cb3.ForeColor = System.Drawing.Color.White
		Me.cb3.Location = New System.Drawing.Point(78, 137)
		Me.cb3.Name = "cb3"
		Me.cb3.Size = New System.Drawing.Size(47, 17)
		Me.cb3.TabIndex = 1
		Me.cb3.Text = "Bold"
		Me.cb3.UseVisualStyleBackColor = True
		'
		'cb2
		'
		Me.cb2.AutoSize = True
		Me.cb2.Checked = Global.xml_editor.My.MySettings.Default.t_checked
		Me.cb2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.xml_editor.My.MySettings.Default, "t_checked", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.cb2.Location = New System.Drawing.Point(78, 74)
		Me.cb2.Name = "cb2"
		Me.cb2.Size = New System.Drawing.Size(47, 17)
		Me.cb2.TabIndex = 1
		Me.cb2.Text = "Bold"
		Me.cb2.UseVisualStyleBackColor = True
		'
		'cb1
		'
		Me.cb1.AutoSize = True
		Me.cb1.Checked = Global.xml_editor.My.MySettings.Default.n_checked
		Me.cb1.CheckState = System.Windows.Forms.CheckState.Checked
		Me.cb1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.xml_editor.My.MySettings.Default, "n_checked", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.cb1.ForeColor = System.Drawing.Color.White
		Me.cb1.Location = New System.Drawing.Point(80, 8)
		Me.cb1.Name = "cb1"
		Me.cb1.Size = New System.Drawing.Size(47, 17)
		Me.cb1.TabIndex = 0
		Me.cb1.Text = "Bold"
		Me.cb1.UseVisualStyleBackColor = True
		'
		'allother
		'
		Me.allother.BackColor = Global.xml_editor.My.MySettings.Default.allothers
		Me.allother.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.xml_editor.My.MySettings.Default, "allothers", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.allother.Location = New System.Drawing.Point(0, 285)
		Me.allother.Margin = New System.Windows.Forms.Padding(0)
		Me.allother.Name = "allother"
		Me.allother.Size = New System.Drawing.Size(131, 38)
		Me.allother.TabIndex = 5
		Me.allother.Tag = "4"
		'
		'properties_
		'
		Me.properties_.BackColor = Global.xml_editor.My.MySettings.Default.props
		Me.properties_.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.xml_editor.My.MySettings.Default, "props", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.properties_.Location = New System.Drawing.Point(0, 220)
		Me.properties_.Margin = New System.Windows.Forms.Padding(0)
		Me.properties_.Name = "properties_"
		Me.properties_.Size = New System.Drawing.Size(131, 38)
		Me.properties_.TabIndex = 4
		Me.properties_.Tag = "3"
		'
		'texture_
		'
		Me.texture_.BackColor = Global.xml_editor.My.MySettings.Default.textures
		Me.texture_.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.xml_editor.My.MySettings.Default, "textures", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.texture_.Location = New System.Drawing.Point(0, 157)
		Me.texture_.Margin = New System.Windows.Forms.Padding(0)
		Me.texture_.Name = "texture_"
		Me.texture_.Size = New System.Drawing.Size(131, 38)
		Me.texture_.TabIndex = 3
		Me.texture_.Tag = "2"
		'
		'tags_
		'
		Me.tags_.BackColor = Global.xml_editor.My.MySettings.Default.tags
		Me.tags_.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.xml_editor.My.MySettings.Default, "tags", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.tags_.Location = New System.Drawing.Point(0, 93)
		Me.tags_.Margin = New System.Windows.Forms.Padding(0)
		Me.tags_.Name = "tags_"
		Me.tags_.Size = New System.Drawing.Size(131, 38)
		Me.tags_.TabIndex = 2
		Me.tags_.Tag = "1"
		'
		'nums_
		'
		Me.nums_.BackColor = Global.xml_editor.My.MySettings.Default.numeric
		Me.nums_.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.xml_editor.My.MySettings.Default, "numeric", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.nums_.Location = New System.Drawing.Point(0, 28)
		Me.nums_.Margin = New System.Windows.Forms.Padding(0)
		Me.nums_.Name = "nums_"
		Me.nums_.Size = New System.Drawing.Size(131, 38)
		Me.nums_.TabIndex = 1
		Me.nums_.Tag = "0"
		'
		'frmSetColors
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.DimGray
		Me.ClientSize = New System.Drawing.Size(253, 323)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "frmSetColors"
		Me.Text = "Set HighLight Colors"
		Me.TopMost = True
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents tags_ As System.Windows.Forms.Panel
	Friend WithEvents nums_ As System.Windows.Forms.Panel
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents texture_ As System.Windows.Forms.Panel
	Friend WithEvents properties_ As System.Windows.Forms.Panel
	Friend WithEvents allother As System.Windows.Forms.Panel
	Friend WithEvents Panel2 As System.Windows.Forms.Panel
	Friend WithEvents cb5 As System.Windows.Forms.CheckBox
	Friend WithEvents cb4 As System.Windows.Forms.CheckBox
	Friend WithEvents cb3 As System.Windows.Forms.CheckBox
	Friend WithEvents cb2 As System.Windows.Forms.CheckBox
	Friend WithEvents cb1 As System.Windows.Forms.CheckBox
End Class

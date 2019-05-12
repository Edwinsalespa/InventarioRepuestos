<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewUsuarios = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TBTBtnInicio = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TBtnGestionUs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TBTBtnGesRes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TBTSesion = New System.Windows.Forms.ToolStripSplitButton()
        Me.TBTStkRes = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridViewUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewUsuarios
        '
        Me.DataGridViewUsuarios.AllowUserToAddRows = False
        Me.DataGridViewUsuarios.AllowUserToDeleteRows = False
        Me.DataGridViewUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewUsuarios.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.DataGridViewUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewUsuarios.ColumnHeadersHeight = 30
        Me.DataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewUsuarios.EnableHeadersVisualStyles = False
        Me.DataGridViewUsuarios.GridColor = System.Drawing.Color.DimGray
        Me.DataGridViewUsuarios.Location = New System.Drawing.Point(12, 136)
        Me.DataGridViewUsuarios.Name = "DataGridViewUsuarios"
        Me.DataGridViewUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewUsuarios.RowHeadersVisible = False
        Me.DataGridViewUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewUsuarios.Size = New System.Drawing.Size(656, 251)
        Me.DataGridViewUsuarios.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Listado de usuarios"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator4, Me.TBTBtnInicio, Me.ToolStripSeparator1, Me.TBtnGestionUs, Me.ToolStripSeparator2, Me.TBTBtnGesRes, Me.ToolStripSeparator3, Me.LogoutBtn, Me.ToolStripSeparator5, Me.TBTSesion, Me.TBTStkRes})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(3, 4, 1, 4)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(869, 45)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolBar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(71, 34)
        Me.ToolStripLabel1.Text = "Inventario"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 37)
        '
        'TBTBtnInicio
        '
        Me.TBTBtnInicio.BackColor = System.Drawing.Color.MidnightBlue
        Me.TBTBtnInicio.ForeColor = System.Drawing.Color.White
        Me.TBTBtnInicio.Image = Global.CapaPresentacion.My.Resources.Resources.home_icon_silhouette
        Me.TBTBtnInicio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBTBtnInicio.Margin = New System.Windows.Forms.Padding(3, 1, 2, 2)
        Me.TBTBtnInicio.Name = "TBTBtnInicio"
        Me.TBTBtnInicio.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.TBTBtnInicio.Size = New System.Drawing.Size(62, 34)
        Me.TBTBtnInicio.Text = "Inicio"
        Me.TBTBtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'TBtnGestionUs
        '
        Me.TBtnGestionUs.BackColor = System.Drawing.Color.MidnightBlue
        Me.TBtnGestionUs.ForeColor = System.Drawing.Color.White
        Me.TBtnGestionUs.Image = Global.CapaPresentacion.My.Resources.Resources.multiple_users_silhouette
        Me.TBtnGestionUs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBtnGestionUs.Margin = New System.Windows.Forms.Padding(3, 1, 2, 2)
        Me.TBtnGestionUs.Name = "TBtnGestionUs"
        Me.TBtnGestionUs.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.TBtnGestionUs.Size = New System.Drawing.Size(136, 34)
        Me.TBtnGestionUs.Text = "Gestión de usuarios"
        Me.TBtnGestionUs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 37)
        '
        'TBTBtnGesRes
        '
        Me.TBTBtnGesRes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TBTBtnGesRes.Image = Global.CapaPresentacion.My.Resources.Resources.screwdriver_and_wrench_crossed
        Me.TBTBtnGesRes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBTBtnGesRes.Margin = New System.Windows.Forms.Padding(3, 1, 2, 2)
        Me.TBTBtnGesRes.Name = "TBTBtnGesRes"
        Me.TBTBtnGesRes.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.TBTBtnGesRes.Size = New System.Drawing.Size(143, 34)
        Me.TBTBtnGesRes.Text = "Gestión de repuestos"
        Me.TBTBtnGesRes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 37)
        '
        'LogoutBtn
        '
        Me.LogoutBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LogoutBtn.AutoSize = False
        Me.LogoutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LogoutBtn.Image = Global.CapaPresentacion.My.Resources.Resources.logout
        Me.LogoutBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LogoutBtn.Margin = New System.Windows.Forms.Padding(3, 1, 6, 2)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LogoutBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LogoutBtn.Size = New System.Drawing.Size(35, 34)
        Me.LogoutBtn.Text = "Cerrar sesión"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 37)
        '
        'TBTSesion
        '
        Me.TBTSesion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TBTSesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TBTSesion.Image = Global.CapaPresentacion.My.Resources.Resources.user
        Me.TBTSesion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBTSesion.Name = "TBTSesion"
        Me.TBTSesion.Size = New System.Drawing.Size(36, 34)
        Me.TBTSesion.Text = "Usuario en sesión"
        '
        'TBTStkRes
        '
        Me.TBTStkRes.ForeColor = System.Drawing.Color.White
        Me.TBTStkRes.Image = Global.CapaPresentacion.My.Resources.Resources.worker_loading_boxes
        Me.TBTStkRes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBTStkRes.Margin = New System.Windows.Forms.Padding(3, 1, 2, 2)
        Me.TBTStkRes.Name = "TBTStkRes"
        Me.TBTStkRes.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.TBTStkRes.Size = New System.Drawing.Size(135, 34)
        Me.TBTStkRes.Text = "Stock de Repuestos"
        Me.TBTStkRes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(869, 526)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewUsuarios)
        Me.Name = "FrmUsuarios"
        Me.Text = "Form1"
        CType(Me.DataGridViewUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBTBtnInicio As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBtnGestionUs As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBTBtnGesRes As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LogoutBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBTSesion As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents TBTStkRes As System.Windows.Forms.ToolStripButton

End Class

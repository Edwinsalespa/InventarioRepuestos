<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevaMarca
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxDescripcionMarca = New System.Windows.Forms.TextBox()
        Me.BtnNuevaMarca = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agregar Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'TextBoxDescripcionMarca
        '
        Me.TextBoxDescripcionMarca.Location = New System.Drawing.Point(127, 78)
        Me.TextBoxDescripcionMarca.Name = "TextBoxDescripcionMarca"
        Me.TextBoxDescripcionMarca.Size = New System.Drawing.Size(131, 20)
        Me.TextBoxDescripcionMarca.TabIndex = 2
        '
        'BtnNuevaMarca
        '
        Me.BtnNuevaMarca.Location = New System.Drawing.Point(44, 133)
        Me.BtnNuevaMarca.Name = "BtnNuevaMarca"
        Me.BtnNuevaMarca.Size = New System.Drawing.Size(214, 40)
        Me.BtnNuevaMarca.TabIndex = 3
        Me.BtnNuevaMarca.Text = "AGREGAR"
        Me.BtnNuevaMarca.UseVisualStyleBackColor = True
        '
        'FrmNuevaMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 224)
        Me.Controls.Add(Me.BtnNuevaMarca)
        Me.Controls.Add(Me.TextBoxDescripcionMarca)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmNuevaMarca"
        Me.Text = "Agregar Nueva Marca"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescripcionMarca As System.Windows.Forms.TextBox
    Friend WithEvents BtnNuevaMarca As System.Windows.Forms.Button
End Class

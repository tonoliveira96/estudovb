<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formcadastro
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
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.txb2 = New System.Windows.Forms.TextBox()
        Me.txb1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_consulta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(36, 103)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 0
        Me.btn_ok.Text = "Ok"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'txb2
        '
        Me.txb2.Location = New System.Drawing.Point(36, 77)
        Me.txb2.Name = "txb2"
        Me.txb2.Size = New System.Drawing.Size(100, 20)
        Me.txb2.TabIndex = 1
        '
        'txb1
        '
        Me.txb1.Location = New System.Drawing.Point(36, 39)
        Me.txb1.Name = "txb1"
        Me.txb1.Size = New System.Drawing.Size(100, 20)
        Me.txb1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nome"
        '
        'btn_consulta
        '
        Me.btn_consulta.Location = New System.Drawing.Point(36, 160)
        Me.btn_consulta.Name = "btn_consulta"
        Me.btn_consulta.Size = New System.Drawing.Size(75, 23)
        Me.btn_consulta.TabIndex = 5
        Me.btn_consulta.Text = "Consulta"
        Me.btn_consulta.UseVisualStyleBackColor = True
        '
        'formcadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 257)
        Me.Controls.Add(Me.btn_consulta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txb1)
        Me.Controls.Add(Me.txb2)
        Me.Controls.Add(Me.btn_ok)
        Me.Name = "formcadastro"
        Me.Text = "Cadastro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents txb2 As System.Windows.Forms.TextBox
    Friend WithEvents txb1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_consulta As System.Windows.Forms.Button

End Class

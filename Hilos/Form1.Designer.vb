<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TXTBOX = New System.Windows.Forms.RichTextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Btn_Iniciar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Txt_valor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TXTBOX
        '
        Me.TXTBOX.Location = New System.Drawing.Point(12, 107)
        Me.TXTBOX.Name = "TXTBOX"
        Me.TXTBOX.Size = New System.Drawing.Size(562, 231)
        Me.TXTBOX.TabIndex = 0
        Me.TXTBOX.Text = ""
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 13)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(562, 23)
        Me.ProgressBar1.TabIndex = 1
        '
        'Btn_Iniciar
        '
        Me.Btn_Iniciar.Location = New System.Drawing.Point(13, 63)
        Me.Btn_Iniciar.Name = "Btn_Iniciar"
        Me.Btn_Iniciar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Iniciar.TabIndex = 2
        Me.Btn_Iniciar.Text = "Iniciar"
        Me.Btn_Iniciar.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(488, 63)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cancelar.TabIndex = 3
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Txt_valor
        '
        Me.Txt_valor.Location = New System.Drawing.Point(235, 66)
        Me.Txt_valor.Name = "Txt_valor"
        Me.Txt_valor.Size = New System.Drawing.Size(100, 20)
        Me.Txt_valor.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(264, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Valor"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 350)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_valor)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Iniciar)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TXTBOX)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTBOX As RichTextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Btn_Iniciar As Button
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Txt_valor As TextBox
    Friend WithEvents Label1 As Label
End Class

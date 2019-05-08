<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtBoxIP = New System.Windows.Forms.TextBox()
        Me.txtBoxPuerto = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBoxUltimo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblIngresar = New System.Windows.Forms.Label()
        Me.txtBoxDatos = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtBoxEnviados = New System.Windows.Forms.RichTextBox()
        Me.txtBoxRecibidos = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'txtBoxIP
        '
        Me.txtBoxIP.Location = New System.Drawing.Point(103, 28)
        Me.txtBoxIP.Name = "txtBoxIP"
        Me.txtBoxIP.Size = New System.Drawing.Size(175, 20)
        Me.txtBoxIP.TabIndex = 0
        Me.txtBoxIP.Text = "127.0.0.1"
        '
        'txtBoxPuerto
        '
        Me.txtBoxPuerto.Location = New System.Drawing.Point(103, 67)
        Me.txtBoxPuerto.Name = "txtBoxPuerto"
        Me.txtBoxPuerto.Size = New System.Drawing.Size(175, 20)
        Me.txtBoxPuerto.TabIndex = 1
        Me.txtBoxPuerto.Text = "6526"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(334, 67)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(77, 13)
        Me.lblEstado.TabIndex = 2
        Me.lblEstado.Text = "Desconectado"
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(315, 24)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(120, 27)
        Me.btnConectar.TabIndex = 3
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Datos enviados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Datos recibidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Direccion IP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Puerto"
        '
        'txtBoxUltimo
        '
        Me.txtBoxUltimo.Location = New System.Drawing.Point(12, 168)
        Me.txtBoxUltimo.Name = "txtBoxUltimo"
        Me.txtBoxUltimo.Size = New System.Drawing.Size(421, 20)
        Me.txtBoxUltimo.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Ultimo dato enviado: "
        '
        'lblIngresar
        '
        Me.lblIngresar.AutoSize = True
        Me.lblIngresar.Location = New System.Drawing.Point(11, 112)
        Me.lblIngresar.Name = "lblIngresar"
        Me.lblIngresar.Size = New System.Drawing.Size(74, 13)
        Me.lblIngresar.TabIndex = 15
        Me.lblIngresar.Text = "Ingrese datos:"
        '
        'txtBoxDatos
        '
        Me.txtBoxDatos.Location = New System.Drawing.Point(103, 108)
        Me.txtBoxDatos.Name = "txtBoxDatos"
        Me.txtBoxDatos.Size = New System.Drawing.Size(175, 20)
        Me.txtBoxDatos.TabIndex = 14
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(315, 104)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(120, 27)
        Me.btnEnviar.TabIndex = 16
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'txtBoxEnviados
        '
        Me.txtBoxEnviados.Location = New System.Drawing.Point(13, 212)
        Me.txtBoxEnviados.Name = "txtBoxEnviados"
        Me.txtBoxEnviados.Size = New System.Drawing.Size(421, 37)
        Me.txtBoxEnviados.TabIndex = 17
        Me.txtBoxEnviados.Text = ""
        '
        'txtBoxRecibidos
        '
        Me.txtBoxRecibidos.Location = New System.Drawing.Point(12, 269)
        Me.txtBoxRecibidos.Name = "txtBoxRecibidos"
        Me.txtBoxRecibidos.Size = New System.Drawing.Size(421, 38)
        Me.txtBoxRecibidos.TabIndex = 18
        Me.txtBoxRecibidos.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(461, 317)
        Me.Controls.Add(Me.txtBoxRecibidos)
        Me.Controls.Add(Me.txtBoxEnviados)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.lblIngresar)
        Me.Controls.Add(Me.txtBoxDatos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBoxUltimo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.txtBoxPuerto)
        Me.Controls.Add(Me.txtBoxIP)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBoxIP As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxPuerto As System.Windows.Forms.TextBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBoxUltimo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblIngresar As System.Windows.Forms.Label
    Friend WithEvents txtBoxDatos As System.Windows.Forms.TextBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtBoxEnviados As System.Windows.Forms.RichTextBox
    Friend WithEvents txtBoxRecibidos As System.Windows.Forms.RichTextBox

End Class

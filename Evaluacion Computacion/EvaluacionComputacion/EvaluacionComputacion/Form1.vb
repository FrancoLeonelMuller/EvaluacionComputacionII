Public Class Form1
    Dim clientePLC As Cliente = New Cliente
    Dim buffer As String
    Dim estado As Boolean = False

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1
        Timer1.Enabled = True
        txtBoxRecibidos.Enabled = False
        txtBoxUltimo.Enabled = False
        txtBoxEnviados.Enabled = False
    End Sub

    Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click
        If estado = False Then
            clientePLC.IpRemota = txtBoxIP.Text
            clientePLC.PuertoRemoto = txtBoxPuerto.Text
            Try
                clientePLC.Conectar()
                estado = True
            Catch ex As Exception
                MsgBox("Servidor no encontrado")
                estado = False
            End Try
        Else
            estado = False
            clientePLC.Desconectar()
        End If
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        clientePLC.EnviarDatos(txtBoxDatos.Text)
        txtBoxUltimo.Text = txtBoxDatos.Text
        txtBoxEnviados.Text = txtBoxEnviados.Text + txtBoxUltimo.Text
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If clientePLC.IsConected = True Then
            lblEstado.Text = "Conectado"
            btnConectar.Text = "Desconectar"
            txtBoxRecibidos.Enabled = True
            txtBoxUltimo.Enabled = True
            txtBoxEnviados.Enabled = True
            clientePLC.ProcesaDatos()
            If buffer <> clientePLC.BufferAcumulado() Then
                txtBoxRecibidos.Text = clientePLC.BufferAcumulado()
                txtBoxRecibidos.Text = buffer
            End If
        Else
            lblEstado.Text = "Desconectado"
            btnConectar.Text = "Conectar"
            txtBoxRecibidos.Enabled = False
            txtBoxUltimo.Enabled = False
            txtBoxEnviados.Enabled = False
            txtBoxEnviados.Text = ""
            txtBoxUltimo.Text = ""
            txtBoxRecibidos.Text = ""
        End If
    End Sub
End Class

Imports System.Threading
Imports System.IO.StringWriter
Imports System.IO.StreamWriter
Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim hilo1 As New Threading.Thread(AddressOf Ventana1)
    Dim n As Integer

    Private Sub Btn_Iniciar_Click(sender As Object, e As EventArgs) Handles Btn_Iniciar.Click
        n = Val(Txt_valor.Text)
        hilo1 = New Threading.Thread(AddressOf Ventana1)
        hilo1.Start()

        If hilo1.IsAlive = True Then
            Btn_Iniciar.BackColor = Color.Green
        End If
        Btn_Iniciar.Enabled = False
    End Sub

    Public Shared Sub Ventana1()
        Form1.ProgressBar1.Minimum = 0
        Form1.ProgressBar1.Maximum = Form1.n
        For q = 1 To Form1.n Step 1
            Form1.ProgressBar1.Value = q
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Lineas.TXT", "Linea N° " & q & vbCrLf, True)
        Next q
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        hilo1.Abort()
        TXTBOX.Text = ""

        If hilo1.IsAlive = False Then
            Btn_Iniciar.BackColor = Color.Red
            Btn_Iniciar.Enabled = True
        End If

    End Sub
End Class

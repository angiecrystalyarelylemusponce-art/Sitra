Public Class frmMenuPrincipal
    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        frmVenta.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        frmCategoria.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        frmEmpleado.Show()
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        frmCliente.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        frmProducto.Show()
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        frmProveedor.Show()
    End Sub

    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        frmFactura.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        frmUsuario.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnReproductor.Click
        Process.Start("wmplayer.exe")
    End Sub

    Private Sub btnCalculadoraW_Click(sender As Object, e As EventArgs) Handles btnCalculadoraW.Click
        Process.Start("Calc.exe")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCalculadoraBásica.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles BTNavegador.Click
        Process.Start("https://google.com")
    End Sub

    Private Sub btnManualDeUsuario_Click(sender As Object, e As EventArgs) Handles btnManualDeUsuario.Click

    End Sub

    Private Sub btnManualTecnico_Click(sender As Object, e As EventArgs) Handles btnManualTecnico.Click
        Dim rutaPDF As String = "D:\PROGRAMACION 1\CUARTO PARCIAL\SYSTERRE 2026.pdf"
        Process.Start(New ProcessStartInfo(rutaPDF))

    End Sub
End Class
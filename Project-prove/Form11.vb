Public Class Form11
    Private Sub BtnSalirRecuperar_Click(sender As Object, e As EventArgs) Handles BtnSalirRecuperar.Click
        BunifuTransition1.HideSync(PnlRecuperarPassword)
        BunifuTransition1.ShowSync(PnlIniciarSesion)
    End Sub

    Private Sub LnklRegistro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnklRegistro.LinkClicked
        BunifuTransition1.HideSync(PnlIniciarSesion)
        BunifuTransition1.ShowSync(PnlRegistro)
    End Sub

    Private Sub BtnReccuperarUsuario_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BtnReccuperarUsuario.LinkClicked
        BunifuTransition1.HideSync(PnlIniciarSesion)
        BunifuTransition1.ShowSync(PnlRecuperarPassword)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        BunifuTransition1.HideSync(PnlRegistro)
        BunifuTransition1.ShowSync(PnlIniciarSesion)
    End Sub

End Class
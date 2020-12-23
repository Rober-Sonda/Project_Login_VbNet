<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form11
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form11))
        Me.PnlRecuperarPassword = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnSalirRecuperar = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.BtnEnviar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtCodigoRecuperacion = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PnlIniciarSesion = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.BtnReccuperarUsuario = New Guna.UI.WinForms.GunaLinkLabel()
        Me.ChkMostrarPassword = New Guna.UI.WinForms.GunaCheckBox()
        Me.LnklRegistro = New Guna.UI.WinForms.GunaLinkLabel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtUsuario = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PnlRegistro = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtRePasswordRegistro = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BtnSalir = New Guna.UI.WinForms.GunaLabel()
        Me.ChkMostrarPasswordRegistro = New Guna.UI.WinForms.GunaCheckBox()
        Me.BtnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnPasswordRegistro = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BtnUsuarioRegistro = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.BunifuColorTransition1 = New Bunifu.Framework.UI.BunifuColorTransition(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PnlPortada = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.PnlRecuperarPassword.SuspendLayout()
        Me.PnlIniciarSesion.SuspendLayout()
        Me.PnlRegistro.SuspendLayout()
        Me.PnlPortada.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlRecuperarPassword
        '
        Me.PnlRecuperarPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlRecuperarPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PnlRecuperarPassword.Controls.Add(Me.BtnSalirRecuperar)
        Me.PnlRecuperarPassword.Controls.Add(Me.GunaLabel5)
        Me.PnlRecuperarPassword.Controls.Add(Me.GunaLabel6)
        Me.PnlRecuperarPassword.Controls.Add(Me.BtnEnviar)
        Me.PnlRecuperarPassword.Controls.Add(Me.TxtCodigoRecuperacion)
        Me.BunifuTransition1.SetDecoration(Me.PnlRecuperarPassword, BunifuAnimatorNS.DecorationType.None)
        Me.PnlRecuperarPassword.Location = New System.Drawing.Point(400, 29)
        Me.PnlRecuperarPassword.Name = "PnlRecuperarPassword"
        Me.PnlRecuperarPassword.ShadowDecoration.Parent = Me.PnlRecuperarPassword
        Me.PnlRecuperarPassword.Size = New System.Drawing.Size(323, 487)
        Me.PnlRecuperarPassword.TabIndex = 13
        Me.PnlRecuperarPassword.Visible = False
        '
        'BtnSalirRecuperar
        '
        Me.BtnSalirRecuperar.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BtnSalirRecuperar, BunifuAnimatorNS.DecorationType.None)
        Me.BtnSalirRecuperar.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnSalirRecuperar.ForeColor = System.Drawing.Color.Silver
        Me.BtnSalirRecuperar.Location = New System.Drawing.Point(300, 3)
        Me.BtnSalirRecuperar.Name = "BtnSalirRecuperar"
        Me.BtnSalirRecuperar.Size = New System.Drawing.Size(18, 20)
        Me.BtnSalirRecuperar.TabIndex = 11
        Me.BtnSalirRecuperar.Text = "X"
        '
        'GunaLabel5
        '
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel5.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel5.Location = New System.Drawing.Point(26, 379)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(267, 41)
        Me.GunaLabel5.TabIndex = 10
        Me.GunaLabel5.Text = "• Cámbiala luego de ingresar nuevamente"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel6.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel6.Location = New System.Drawing.Point(26, 341)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(245, 19)
        Me.GunaLabel6.TabIndex = 10
        Me.GunaLabel6.Text = "• Te enviaremos una nueva contraseña"
        '
        'BtnEnviar
        '
        Me.BtnEnviar.CheckedState.Parent = Me.BtnEnviar
        Me.BtnEnviar.CustomImages.Parent = Me.BtnEnviar
        Me.BunifuTransition1.SetDecoration(Me.BtnEnviar, BunifuAnimatorNS.DecorationType.None)
        Me.BtnEnviar.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnEnviar.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnEnviar.ForeColor = System.Drawing.Color.White
        Me.BtnEnviar.HoverState.Parent = Me.BtnEnviar
        Me.BtnEnviar.Location = New System.Drawing.Point(30, 194)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.ShadowDecoration.Parent = Me.BtnEnviar
        Me.BtnEnviar.Size = New System.Drawing.Size(263, 45)
        Me.BtnEnviar.TabIndex = 4
        Me.BtnEnviar.Text = "Enviar"
        '
        'TxtCodigoRecuperacion
        '
        Me.TxtCodigoRecuperacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCodigoRecuperacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.TxtCodigoRecuperacion, BunifuAnimatorNS.DecorationType.None)
        Me.TxtCodigoRecuperacion.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtCodigoRecuperacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtCodigoRecuperacion.HintForeColor = System.Drawing.Color.Silver
        Me.TxtCodigoRecuperacion.HintText = "Usuario o Email"
        Me.TxtCodigoRecuperacion.isPassword = False
        Me.TxtCodigoRecuperacion.LineFocusedColor = System.Drawing.Color.MediumSpringGreen
        Me.TxtCodigoRecuperacion.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtCodigoRecuperacion.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.TxtCodigoRecuperacion.LineThickness = 3
        Me.TxtCodigoRecuperacion.Location = New System.Drawing.Point(30, 120)
        Me.TxtCodigoRecuperacion.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodigoRecuperacion.Name = "TxtCodigoRecuperacion"
        Me.TxtCodigoRecuperacion.Size = New System.Drawing.Size(263, 33)
        Me.TxtCodigoRecuperacion.TabIndex = 1
        Me.TxtCodigoRecuperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PnlIniciarSesion
        '
        Me.PnlIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlIniciarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PnlIniciarSesion.Controls.Add(Me.GunaLabel4)
        Me.PnlIniciarSesion.Controls.Add(Me.BtnReccuperarUsuario)
        Me.PnlIniciarSesion.Controls.Add(Me.ChkMostrarPassword)
        Me.PnlIniciarSesion.Controls.Add(Me.LnklRegistro)
        Me.PnlIniciarSesion.Controls.Add(Me.Guna2Button1)
        Me.PnlIniciarSesion.Controls.Add(Me.TxtPassword)
        Me.PnlIniciarSesion.Controls.Add(Me.TxtUsuario)
        Me.BunifuTransition1.SetDecoration(Me.PnlIniciarSesion, BunifuAnimatorNS.DecorationType.None)
        Me.PnlIniciarSesion.Location = New System.Drawing.Point(400, 29)
        Me.PnlIniciarSesion.Name = "PnlIniciarSesion"
        Me.PnlIniciarSesion.ShadowDecoration.Parent = Me.PnlIniciarSesion
        Me.PnlIniciarSesion.Size = New System.Drawing.Size(323, 487)
        Me.PnlIniciarSesion.TabIndex = 11
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel4.Location = New System.Drawing.Point(136, 432)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(13, 20)
        Me.GunaLabel4.TabIndex = 8
        Me.GunaLabel4.Text = "|"
        '
        'BtnReccuperarUsuario
        '
        Me.BtnReccuperarUsuario.ActiveLinkColor = System.Drawing.Color.SpringGreen
        Me.BtnReccuperarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnReccuperarUsuario.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BtnReccuperarUsuario, BunifuAnimatorNS.DecorationType.None)
        Me.BtnReccuperarUsuario.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnReccuperarUsuario.LinkColor = System.Drawing.Color.Silver
        Me.BtnReccuperarUsuario.Location = New System.Drawing.Point(155, 432)
        Me.BtnReccuperarUsuario.Name = "BtnReccuperarUsuario"
        Me.BtnReccuperarUsuario.Size = New System.Drawing.Size(138, 19)
        Me.BtnReccuperarUsuario.TabIndex = 7
        Me.BtnReccuperarUsuario.TabStop = True
        Me.BtnReccuperarUsuario.Text = "Olvidé mi contraseña"
        '
        'ChkMostrarPassword
        '
        Me.ChkMostrarPassword.BaseColor = System.Drawing.Color.White
        Me.ChkMostrarPassword.CheckedOffColor = System.Drawing.Color.Gray
        Me.ChkMostrarPassword.CheckedOnColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuTransition1.SetDecoration(Me.ChkMostrarPassword, BunifuAnimatorNS.DecorationType.None)
        Me.ChkMostrarPassword.FillColor = System.Drawing.Color.White
        Me.ChkMostrarPassword.ForeColor = System.Drawing.Color.Silver
        Me.ChkMostrarPassword.Location = New System.Drawing.Point(30, 222)
        Me.ChkMostrarPassword.Name = "ChkMostrarPassword"
        Me.ChkMostrarPassword.Size = New System.Drawing.Size(130, 20)
        Me.ChkMostrarPassword.TabIndex = 6
        Me.ChkMostrarPassword.Text = "Mostrar Contraseña"
        '
        'LnklRegistro
        '
        Me.LnklRegistro.ActiveLinkColor = System.Drawing.Color.SpringGreen
        Me.LnklRegistro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LnklRegistro.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.LnklRegistro, BunifuAnimatorNS.DecorationType.None)
        Me.LnklRegistro.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LnklRegistro.LinkColor = System.Drawing.Color.Silver
        Me.LnklRegistro.Location = New System.Drawing.Point(55, 432)
        Me.LnklRegistro.Name = "LnklRegistro"
        Me.LnklRegistro.Size = New System.Drawing.Size(76, 19)
        Me.LnklRegistro.TabIndex = 5
        Me.LnklRegistro.TabStop = True
        Me.LnklRegistro.Text = "Registrarse"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.BunifuTransition1.SetDecoration(Me.Guna2Button1, BunifuAnimatorNS.DecorationType.None)
        Me.Guna2Button1.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(30, 341)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(263, 45)
        Me.Guna2Button1.TabIndex = 4
        Me.Guna2Button1.Text = "Iniciar Sesión"
        '
        'TxtPassword
        '
        Me.TxtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.TxtPassword, BunifuAnimatorNS.DecorationType.None)
        Me.TxtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtPassword.HintForeColor = System.Drawing.Color.Silver
        Me.TxtPassword.HintText = "Contraseña"
        Me.TxtPassword.isPassword = True
        Me.TxtPassword.LineFocusedColor = System.Drawing.Color.MediumSpringGreen
        Me.TxtPassword.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtPassword.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.TxtPassword.LineThickness = 3
        Me.TxtPassword.Location = New System.Drawing.Point(30, 179)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(263, 33)
        Me.TxtPassword.TabIndex = 3
        Me.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.TxtUsuario, BunifuAnimatorNS.DecorationType.None)
        Me.TxtUsuario.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtUsuario.HintForeColor = System.Drawing.Color.Silver
        Me.TxtUsuario.HintText = "Usuario"
        Me.TxtUsuario.isPassword = False
        Me.TxtUsuario.LineFocusedColor = System.Drawing.Color.MediumSpringGreen
        Me.TxtUsuario.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtUsuario.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.TxtUsuario.LineThickness = 3
        Me.TxtUsuario.Location = New System.Drawing.Point(30, 96)
        Me.TxtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(263, 33)
        Me.TxtUsuario.TabIndex = 1
        Me.TxtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PnlRegistro
        '
        Me.PnlRegistro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PnlRegistro.Controls.Add(Me.TxtRePasswordRegistro)
        Me.PnlRegistro.Controls.Add(Me.BtnSalir)
        Me.PnlRegistro.Controls.Add(Me.ChkMostrarPasswordRegistro)
        Me.PnlRegistro.Controls.Add(Me.BtnGuardar)
        Me.PnlRegistro.Controls.Add(Me.BtnPasswordRegistro)
        Me.PnlRegistro.Controls.Add(Me.BtnUsuarioRegistro)
        Me.BunifuTransition1.SetDecoration(Me.PnlRegistro, BunifuAnimatorNS.DecorationType.None)
        Me.PnlRegistro.Location = New System.Drawing.Point(400, 29)
        Me.PnlRegistro.Name = "PnlRegistro"
        Me.PnlRegistro.ShadowDecoration.Parent = Me.PnlRegistro
        Me.PnlRegistro.Size = New System.Drawing.Size(323, 487)
        Me.PnlRegistro.TabIndex = 12
        Me.PnlRegistro.Visible = False
        '
        'TxtRePasswordRegistro
        '
        Me.TxtRePasswordRegistro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtRePasswordRegistro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.TxtRePasswordRegistro, BunifuAnimatorNS.DecorationType.None)
        Me.TxtRePasswordRegistro.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtRePasswordRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtRePasswordRegistro.HintForeColor = System.Drawing.Color.Silver
        Me.TxtRePasswordRegistro.HintText = "Repetir Contraseña"
        Me.TxtRePasswordRegistro.isPassword = False
        Me.TxtRePasswordRegistro.LineFocusedColor = System.Drawing.Color.MediumSpringGreen
        Me.TxtRePasswordRegistro.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtRePasswordRegistro.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.TxtRePasswordRegistro.LineThickness = 3
        Me.TxtRePasswordRegistro.Location = New System.Drawing.Point(30, 222)
        Me.TxtRePasswordRegistro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRePasswordRegistro.Name = "TxtRePasswordRegistro"
        Me.TxtRePasswordRegistro.Size = New System.Drawing.Size(263, 33)
        Me.TxtRePasswordRegistro.TabIndex = 9
        Me.TxtRePasswordRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnSalir
        '
        Me.BtnSalir.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BtnSalir, BunifuAnimatorNS.DecorationType.None)
        Me.BtnSalir.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnSalir.ForeColor = System.Drawing.Color.Silver
        Me.BtnSalir.Location = New System.Drawing.Point(300, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(18, 20)
        Me.BtnSalir.TabIndex = 8
        Me.BtnSalir.Text = "X"
        '
        'ChkMostrarPasswordRegistro
        '
        Me.ChkMostrarPasswordRegistro.BaseColor = System.Drawing.Color.White
        Me.ChkMostrarPasswordRegistro.CheckedOffColor = System.Drawing.Color.Gray
        Me.ChkMostrarPasswordRegistro.CheckedOnColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuTransition1.SetDecoration(Me.ChkMostrarPasswordRegistro, BunifuAnimatorNS.DecorationType.None)
        Me.ChkMostrarPasswordRegistro.FillColor = System.Drawing.Color.White
        Me.ChkMostrarPasswordRegistro.ForeColor = System.Drawing.Color.Silver
        Me.ChkMostrarPasswordRegistro.Location = New System.Drawing.Point(30, 262)
        Me.ChkMostrarPasswordRegistro.Name = "ChkMostrarPasswordRegistro"
        Me.ChkMostrarPasswordRegistro.Size = New System.Drawing.Size(130, 20)
        Me.ChkMostrarPasswordRegistro.TabIndex = 6
        Me.ChkMostrarPasswordRegistro.Text = "Mostrar Contraseña"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.CheckedState.Parent = Me.BtnGuardar
        Me.BtnGuardar.CustomImages.Parent = Me.BtnGuardar
        Me.BunifuTransition1.SetDecoration(Me.BtnGuardar, BunifuAnimatorNS.DecorationType.None)
        Me.BtnGuardar.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnGuardar.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.HoverState.Parent = Me.BtnGuardar
        Me.BtnGuardar.Location = New System.Drawing.Point(30, 375)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.ShadowDecoration.Parent = Me.BtnGuardar
        Me.BtnGuardar.Size = New System.Drawing.Size(263, 45)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "Guardar"
        '
        'BtnPasswordRegistro
        '
        Me.BtnPasswordRegistro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnPasswordRegistro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.BtnPasswordRegistro, BunifuAnimatorNS.DecorationType.None)
        Me.BtnPasswordRegistro.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BtnPasswordRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPasswordRegistro.HintForeColor = System.Drawing.Color.Silver
        Me.BtnPasswordRegistro.HintText = "Contraseña"
        Me.BtnPasswordRegistro.isPassword = False
        Me.BtnPasswordRegistro.LineFocusedColor = System.Drawing.Color.MediumSpringGreen
        Me.BtnPasswordRegistro.LineIdleColor = System.Drawing.Color.Gray
        Me.BtnPasswordRegistro.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BtnPasswordRegistro.LineThickness = 3
        Me.BtnPasswordRegistro.Location = New System.Drawing.Point(30, 161)
        Me.BtnPasswordRegistro.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPasswordRegistro.Name = "BtnPasswordRegistro"
        Me.BtnPasswordRegistro.Size = New System.Drawing.Size(263, 33)
        Me.BtnPasswordRegistro.TabIndex = 3
        Me.BtnPasswordRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnUsuarioRegistro
        '
        Me.BtnUsuarioRegistro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnUsuarioRegistro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.BtnUsuarioRegistro, BunifuAnimatorNS.DecorationType.None)
        Me.BtnUsuarioRegistro.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BtnUsuarioRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnUsuarioRegistro.HintForeColor = System.Drawing.Color.Silver
        Me.BtnUsuarioRegistro.HintText = "Usuario"
        Me.BtnUsuarioRegistro.isPassword = False
        Me.BtnUsuarioRegistro.LineFocusedColor = System.Drawing.Color.MediumSpringGreen
        Me.BtnUsuarioRegistro.LineIdleColor = System.Drawing.Color.Gray
        Me.BtnUsuarioRegistro.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BtnUsuarioRegistro.LineThickness = 3
        Me.BtnUsuarioRegistro.Location = New System.Drawing.Point(30, 96)
        Me.BtnUsuarioRegistro.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnUsuarioRegistro.Name = "BtnUsuarioRegistro"
        Me.BtnUsuarioRegistro.Size = New System.Drawing.Size(263, 33)
        Me.BtnUsuarioRegistro.TabIndex = 1
        Me.BtnUsuarioRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'BunifuColorTransition1
        '
        Me.BunifuColorTransition1.Color1 = System.Drawing.Color.White
        Me.BunifuColorTransition1.Color2 = System.Drawing.Color.Black
        Me.BunifuColorTransition1.ProgessValue = 50
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent
        Me.BunifuTransition1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 1.0!
        Me.BunifuTransition1.DefaultAnimation = Animation2
        '
        'PnlPortada
        '
        Me.PnlPortada.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlPortada.BackgroundImage = CType(resources.GetObject("PnlPortada.BackgroundImage"), System.Drawing.Image)
        Me.PnlPortada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlPortada.Controls.Add(Me.Guna2CircleButton1)
        Me.PnlPortada.Controls.Add(Me.GunaLabel1)
        Me.PnlPortada.Controls.Add(Me.GunaLabel3)
        Me.PnlPortada.Controls.Add(Me.GunaLabel2)
        Me.BunifuTransition1.SetDecoration(Me.PnlPortada, BunifuAnimatorNS.DecorationType.None)
        Me.PnlPortada.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PnlPortada.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PnlPortada.GradientTopLeft = System.Drawing.Color.DarkGreen
        Me.PnlPortada.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PnlPortada.Location = New System.Drawing.Point(78, 29)
        Me.PnlPortada.Name = "PnlPortada"
        Me.PnlPortada.Quality = 10
        Me.PnlPortada.Size = New System.Drawing.Size(323, 487)
        Me.PnlPortada.TabIndex = 8
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(127, 275)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(100, 20)
        Me.GunaLabel3.TabIndex = 7
        Me.GunaLabel3.Text = "Autenticación"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(125, 250)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(137, 25)
        Me.GunaLabel1.TabIndex = 5
        Me.GunaLabel1.Text = "ROBER SONDA"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(51, 236)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(95, 72)
        Me.GunaLabel2.TabIndex = 6
        Me.GunaLabel2.Text = "RS"
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton1.CheckedState.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.CustomImages.Parent = Me.Guna2CircleButton1
        Me.BunifuTransition1.SetDecoration(Me.Guna2CircleButton1, BunifuAnimatorNS.DecorationType.None)
        Me.Guna2CircleButton1.FillColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2CircleButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Guna2CircleButton1.HoverState.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(293, 239)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.ShadowDecoration.Parent = Me.Guna2CircleButton1
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(87, 67)
        Me.Guna2CircleButton1.TabIndex = 1
        Me.Guna2CircleButton1.Text = ">"
        Me.Guna2CircleButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2CircleButton1.UseTransparentBackground = True
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 545)
        Me.Controls.Add(Me.PnlIniciarSesion)
        Me.Controls.Add(Me.PnlRegistro)
        Me.Controls.Add(Me.PnlRecuperarPassword)
        Me.Controls.Add(Me.PnlPortada)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form11"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlRecuperarPassword.ResumeLayout(False)
        Me.PnlRecuperarPassword.PerformLayout()
        Me.PnlIniciarSesion.ResumeLayout(False)
        Me.PnlIniciarSesion.PerformLayout()
        Me.PnlRegistro.ResumeLayout(False)
        Me.PnlRegistro.PerformLayout()
        Me.PnlPortada.ResumeLayout(False)
        Me.PnlPortada.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PnlRecuperarPassword As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PnlIniciarSesion As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BtnReccuperarUsuario As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents LnklRegistro As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtUsuario As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PnlRegistro As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtRePasswordRegistro As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BtnSalir As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ChkMostrarPasswordRegistro As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents BtnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnPasswordRegistro As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BtnUsuarioRegistro As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BtnSalirRecuperar As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BtnEnviar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtCodigoRecuperacion As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ChkMostrarPassword As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents BunifuColorTransition1 As Bunifu.Framework.UI.BunifuColorTransition
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents PnlPortada As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
End Class

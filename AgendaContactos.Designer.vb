<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgendaContactos
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
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblNomApe = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.lblProvincia = New System.Windows.Forms.Label()
        Me.lblCodPostal = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblFijo = New System.Windows.Forms.Label()
        Me.lblMovil = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblNotas = New System.Windows.Forms.Label()
        Me.txtFijo = New System.Windows.Forms.MaskedTextBox()
        Me.txtMovil = New System.Windows.Forms.MaskedTextBox()
        Me.txtCodPost = New System.Windows.Forms.MaskedTextBox()
        Me.txtFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNomApe = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtNotas = New System.Windows.Forms.TextBox()
        Me.cbCiudad = New System.Windows.Forms.ComboBox()
        Me.cbProvincia = New System.Windows.Forms.ComboBox()
        Me.btnBorrarFoto = New System.Windows.Forms.Button()
        Me.btnSubirFoto = New System.Windows.Forms.Button()
        Me.PicBoxFoto = New System.Windows.Forms.PictureBox()
        Me.ToolStripMenuIconos = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnBorrar = New System.Windows.Forms.ToolStripButton()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.OFDCargarFoto = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PicBoxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripMenuIconos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(41, 71)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(95, 23)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código: "
        '
        'lblNomApe
        '
        Me.lblNomApe.AutoSize = True
        Me.lblNomApe.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomApe.Location = New System.Drawing.Point(41, 111)
        Me.lblNomApe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNomApe.Name = "lblNomApe"
        Me.lblNomApe.Size = New System.Drawing.Size(214, 23)
        Me.lblNomApe.TabIndex = 1
        Me.lblNomApe.Text = "Nombre y apellidos: "
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(41, 151)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(110, 23)
        Me.lblDireccion.TabIndex = 2
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiudad.Location = New System.Drawing.Point(41, 191)
        Me.lblCiudad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(94, 23)
        Me.lblCiudad.TabIndex = 3
        Me.lblCiudad.Text = "Ciudad: "
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvincia.Location = New System.Drawing.Point(41, 231)
        Me.lblProvincia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(111, 23)
        Me.lblProvincia.TabIndex = 4
        Me.lblProvincia.Text = "Provincia: "
        '
        'lblCodPostal
        '
        Me.lblCodPostal.AutoSize = True
        Me.lblCodPostal.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodPostal.Location = New System.Drawing.Point(41, 271)
        Me.lblCodPostal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodPostal.Name = "lblCodPostal"
        Me.lblCodPostal.Size = New System.Drawing.Size(158, 23)
        Me.lblCodPostal.TabIndex = 5
        Me.lblCodPostal.Text = "Código Postal: "
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNac.Location = New System.Drawing.Point(41, 311)
        Me.lblFechaNac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(232, 23)
        Me.lblFechaNac.TabIndex = 6
        Me.lblFechaNac.Text = "Fecha de nacimiento: "
        '
        'lblFijo
        '
        Me.lblFijo.AutoSize = True
        Me.lblFijo.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFijo.Location = New System.Drawing.Point(41, 351)
        Me.lblFijo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFijo.Name = "lblFijo"
        Me.lblFijo.Size = New System.Drawing.Size(140, 23)
        Me.lblFijo.TabIndex = 7
        Me.lblFijo.Text = "Teléfono fijo: "
        '
        'lblMovil
        '
        Me.lblMovil.AutoSize = True
        Me.lblMovil.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovil.Location = New System.Drawing.Point(41, 391)
        Me.lblMovil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMovil.Name = "lblMovil"
        Me.lblMovil.Size = New System.Drawing.Size(164, 23)
        Me.lblMovil.TabIndex = 8
        Me.lblMovil.Text = "Teléfono móvil: "
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.Location = New System.Drawing.Point(41, 431)
        Me.lblMail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(207, 23)
        Me.lblMail.TabIndex = 9
        Me.lblMail.Text = "Correo electrónico: "
        '
        'lblNotas
        '
        Me.lblNotas.AutoSize = True
        Me.lblNotas.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotas.Location = New System.Drawing.Point(41, 471)
        Me.lblNotas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNotas.Name = "lblNotas"
        Me.lblNotas.Size = New System.Drawing.Size(78, 23)
        Me.lblNotas.TabIndex = 10
        Me.lblNotas.Text = "Notas: "
        '
        'txtFijo
        '
        Me.txtFijo.Enabled = False
        Me.txtFijo.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFijo.Location = New System.Drawing.Point(270, 351)
        Me.txtFijo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFijo.Mask = "000 000 000"
        Me.txtFijo.Name = "txtFijo"
        Me.txtFijo.Size = New System.Drawing.Size(120, 32)
        Me.txtFijo.TabIndex = 11
        Me.txtFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMovil
        '
        Me.txtMovil.Enabled = False
        Me.txtMovil.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovil.Location = New System.Drawing.Point(271, 391)
        Me.txtMovil.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMovil.Mask = "000 000 000"
        Me.txtMovil.Name = "txtMovil"
        Me.txtMovil.Size = New System.Drawing.Size(119, 32)
        Me.txtMovil.TabIndex = 12
        Me.txtMovil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodPost
        '
        Me.txtCodPost.Enabled = False
        Me.txtCodPost.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPost.Location = New System.Drawing.Point(271, 271)
        Me.txtCodPost.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCodPost.Mask = "00000"
        Me.txtCodPost.Name = "txtCodPost"
        Me.txtCodPost.Size = New System.Drawing.Size(60, 32)
        Me.txtCodPost.TabIndex = 13
        Me.txtCodPost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFechaNac
        '
        Me.txtFechaNac.CalendarFont = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaNac.CustomFormat = " dd - MMM- yyyy"
        Me.txtFechaNac.Enabled = False
        Me.txtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFechaNac.Location = New System.Drawing.Point(271, 307)
        Me.txtFechaNac.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFechaNac.Name = "txtFechaNac"
        Me.txtFechaNac.ShowCheckBox = True
        Me.txtFechaNac.Size = New System.Drawing.Size(217, 32)
        Me.txtFechaNac.TabIndex = 14
        Me.txtFechaNac.Value = New Date(2021, 2, 9, 0, 0, 0, 0)
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(270, 71)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(76, 32)
        Me.txtCodigo.TabIndex = 15
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNomApe
        '
        Me.txtNomApe.Enabled = False
        Me.txtNomApe.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomApe.Location = New System.Drawing.Point(270, 111)
        Me.txtNomApe.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNomApe.Name = "txtNomApe"
        Me.txtNomApe.Size = New System.Drawing.Size(330, 32)
        Me.txtNomApe.TabIndex = 16
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(270, 151)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(330, 32)
        Me.txtDireccion.TabIndex = 17
        '
        'txtMail
        '
        Me.txtMail.Enabled = False
        Me.txtMail.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(271, 431)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(329, 32)
        Me.txtMail.TabIndex = 18
        '
        'txtNotas
        '
        Me.txtNotas.Enabled = False
        Me.txtNotas.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotas.Location = New System.Drawing.Point(45, 497)
        Me.txtNotas.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(872, 131)
        Me.txtNotas.TabIndex = 19
        '
        'cbCiudad
        '
        Me.cbCiudad.Enabled = False
        Me.cbCiudad.FormattingEnabled = True
        Me.cbCiudad.Location = New System.Drawing.Point(270, 191)
        Me.cbCiudad.Name = "cbCiudad"
        Me.cbCiudad.Size = New System.Drawing.Size(218, 31)
        Me.cbCiudad.TabIndex = 20
        '
        'cbProvincia
        '
        Me.cbProvincia.Enabled = False
        Me.cbProvincia.FormattingEnabled = True
        Me.cbProvincia.Location = New System.Drawing.Point(271, 231)
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Size = New System.Drawing.Size(217, 31)
        Me.cbProvincia.TabIndex = 21
        '
        'btnBorrarFoto
        '
        Me.btnBorrarFoto.Enabled = False
        Me.btnBorrarFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.btnBorrarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarFoto.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarFoto.Location = New System.Drawing.Point(683, 420)
        Me.btnBorrarFoto.Name = "btnBorrarFoto"
        Me.btnBorrarFoto.Size = New System.Drawing.Size(203, 45)
        Me.btnBorrarFoto.TabIndex = 22
        Me.btnBorrarFoto.Text = "Borrar foto"
        Me.btnBorrarFoto.UseVisualStyleBackColor = True
        '
        'btnSubirFoto
        '
        Me.btnSubirFoto.Enabled = False
        Me.btnSubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubirFoto.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubirFoto.Location = New System.Drawing.Point(683, 351)
        Me.btnSubirFoto.Name = "btnSubirFoto"
        Me.btnSubirFoto.Size = New System.Drawing.Size(203, 48)
        Me.btnSubirFoto.TabIndex = 23
        Me.btnSubirFoto.Text = "Subir foto"
        Me.btnSubirFoto.UseVisualStyleBackColor = True
        '
        'PicBoxFoto
        '
        Me.PicBoxFoto.Enabled = False
        Me.PicBoxFoto.Location = New System.Drawing.Point(644, 71)
        Me.PicBoxFoto.Name = "PicBoxFoto"
        Me.PicBoxFoto.Size = New System.Drawing.Size(273, 253)
        Me.PicBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBoxFoto.TabIndex = 24
        Me.PicBoxFoto.TabStop = False
        '
        'ToolStripMenuIconos
        '
        Me.ToolStripMenuIconos.GripMargin = New System.Windows.Forms.Padding(5)
        Me.ToolStripMenuIconos.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStripMenuIconos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnEditar, Me.btnGuardar, Me.btnBorrar, Me.btnSalir})
        Me.ToolStripMenuIconos.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripMenuIconos.Name = "ToolStripMenuIconos"
        Me.ToolStripMenuIconos.Size = New System.Drawing.Size(934, 50)
        Me.ToolStripMenuIconos.TabIndex = 25
        Me.ToolStripMenuIconos.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevo.Image = Global.AgendaContactos.My.Resources.Resources.Nuevo
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(0, 3, 4, 3)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(44, 44)
        Me.btnNuevo.Text = "Nuevo contacto"
        '
        'btnEditar
        '
        Me.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditar.Image = Global.AgendaContactos.My.Resources.Resources.Editar
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(0, 3, 4, 3)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(44, 44)
        Me.btnEditar.Text = "Editar contacto"
        '
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Image = Global.AgendaContactos.My.Resources.Resources.Guardar
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(0, 3, 4, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(44, 44)
        Me.btnGuardar.Text = "Guardar contacto"
        '
        'btnBorrar
        '
        Me.btnBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBorrar.Image = Global.AgendaContactos.My.Resources.Resources.Borrar
        Me.btnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(0, 3, 4, 3)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(44, 44)
        Me.btnBorrar.Text = "Borrar contacto"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSalir.Image = Global.AgendaContactos.My.Resources.Resources.Salir
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(0, 3, 2, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(44, 44)
        Me.btnSalir.Text = "Salir"
        '
        'OFDCargarFoto
        '
        Me.OFDCargarFoto.Filter = "Archivos(*.JPG)| *.jpg"
        '
        'frmAgendaContactos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(934, 640)
        Me.Controls.Add(Me.ToolStripMenuIconos)
        Me.Controls.Add(Me.PicBoxFoto)
        Me.Controls.Add(Me.btnSubirFoto)
        Me.Controls.Add(Me.btnBorrarFoto)
        Me.Controls.Add(Me.cbProvincia)
        Me.Controls.Add(Me.cbCiudad)
        Me.Controls.Add(Me.txtNotas)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNomApe)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtFechaNac)
        Me.Controls.Add(Me.txtCodPost)
        Me.Controls.Add(Me.txtMovil)
        Me.Controls.Add(Me.txtFijo)
        Me.Controls.Add(Me.lblNotas)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblMovil)
        Me.Controls.Add(Me.lblFijo)
        Me.Controls.Add(Me.lblFechaNac)
        Me.Controls.Add(Me.lblCodPostal)
        Me.Controls.Add(Me.lblProvincia)
        Me.Controls.Add(Me.lblCiudad)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblNomApe)
        Me.Controls.Add(Me.lblCodigo)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmAgendaContactos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contactos"
        CType(Me.PicBoxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripMenuIconos.ResumeLayout(False)
        Me.ToolStripMenuIconos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblNomApe As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblCiudad As Label
    Friend WithEvents lblProvincia As Label
    Friend WithEvents lblCodPostal As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblFijo As Label
    Friend WithEvents lblMovil As Label
    Friend WithEvents lblMail As Label
    Friend WithEvents lblNotas As Label
    Friend WithEvents txtFijo As MaskedTextBox
    Friend WithEvents txtMovil As MaskedTextBox
    Friend WithEvents txtCodPost As MaskedTextBox
    Friend WithEvents txtFechaNac As DateTimePicker
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNomApe As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtNotas As TextBox
    Friend WithEvents cbCiudad As ComboBox
    Friend WithEvents cbProvincia As ComboBox
    Friend WithEvents btnBorrarFoto As Button
    Friend WithEvents btnSubirFoto As Button
    Friend WithEvents PicBoxFoto As PictureBox
    Friend WithEvents ToolStripMenuIconos As ToolStrip
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnBorrar As ToolStripButton
    Friend WithEvents btnSalir As ToolStripButton
    Friend WithEvents OFDCargarFoto As OpenFileDialog
End Class

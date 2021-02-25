Imports System.IO
Imports System.Data.SqlClient

Public Class frmAgendaContactos
    'VARIABLES
    Dim registro As Integer = 0 'para el número de registros
    Dim longtabla As Integer 'para recoger el tamaño de la tabla
    Dim nuevoReg As Boolean = False ' para saber si es un nuevo registro o editamos uno existente
    Dim cancelReg As Boolean = False 'cuando estamos creando un nuevo registro o editando el botón borrar actúa como btn cancelar
    Dim result As DialogResult
    'Declaramos una variable de tipo sqlConnection para la cadena de conexión
    Dim cnn As New SqlConnection("Data Source=.;Initial Catalog=Agenda;Integrated Security=True")
    Dim dt As New DataTable()
    'SALIR
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        result = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        Else
            Me.Show()
        End If

    End Sub

    'LOAD
    Private Sub frmAgendaContactos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargamos los combos ciudad y provincia de la bbdd
        cargarCombos("Ciudad")
        cargarCombos("Provincia")
        'cargar la tabla 
        cargarTabla()
        'comprobar si la tabla tiene registros, si no los tienen habilitar la opción de crear uno nuevo
        If longtabla = -1 Then
            Nuevo()
        Else
            'cargar los campos del formulario rellenados con los datos de bbdd
            cargarCamposForm(registro)
        End If

    End Sub

    'CAMBIAR DE REGISTRO CON LAS TECLAS (HOME, END, LEFT, RIGHT)
    Private Sub frmAgendaContactos_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        'para pasar al siguiente registro
        If e.KeyCode = Keys.Right Then
            'si es el último resgistro vuelve al primero
            If registro = longtabla Then
                registro = 0
                cargarCamposForm(registro)
            Else
                registro += 1
                cargarCamposForm(registro)
            End If
            'para pasar al registro anterior
        ElseIf e.KeyCode = Keys.Left Then
            'si es el primer registro vuelve a mostrar el último
            If registro = 0 Then
                registro = longtabla
                cargarCamposForm(registro)
            Else
                registro -= 1
                cargarCamposForm(registro)
            End If
            'para ir al primer registro
        ElseIf e.KeyCode = Keys.Home Then
            registro = 0
            cargarCamposForm(registro)
            'para ir al último registro
        ElseIf e.KeyCode = Keys.End Then
            registro = longtabla
            cargarCamposForm(registro)
        End If
    End Sub

    'NUEVO
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'habilitar sólo los botones de guardar y cancelar
        btnsGuardarCancel()
        Nuevo()
        nuevoReg = True
        cancelReg = True
    End Sub

    'EDITAR
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'habilitar sólo los botones de guardar y cancelar
        btnsGuardarCancel()
        Editar()
        nuevoReg = False
        cancelReg = True
    End Sub

    'GUARDAR NUEVO O CAMBIOS
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Guardar()
    End Sub

    'BORRAR
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        'si estamos en nuevo o editar actúa como cancelar
        'si no como borrar contacto
        borrarCancelar()
    End Sub

    'SUBIR FOTOS
    Private Sub btnSubirFoto_Click(sender As Object, e As EventArgs) Handles btnSubirFoto.Click
        CargarFotos()
    End Sub

    'BORRAR FOTO
    Private Sub btnBorrarFoto_Click(sender As Object, e As EventArgs) Handles btnBorrarFoto.Click
        'borrar la foto del formulario
        PicBoxFoto.Image = Nothing
        btnBorrarFoto.Enabled = False
    End Sub

#Region "Procedimientos"
    'procedimiento para cargar los combos ciudad y provincia
    Private Sub cargarCombos(param As String)
        Dim consulta As New SqlCommand("SELECT DISTINCT " & param & " FROM Contactos WHERE " & param & " IS NOT NULL ORDER BY " & param, cnn)
        'adaptador para cargar los datos de la tabla de sql
        Dim da As New SqlDataAdapter(consulta)
        If param = "Ciudad" Then
            Dim dt_ciudad As New DataTable()
            'cargamos los datos de la tabla de sql en nuestra tabla virtual (.fill)
            da.Fill(dt_ciudad)

            'cargamos el combobox con los datos de la columna ciudad o provincia en la tabla Contactos
            cbCiudad.DataSource = dt_ciudad
            cbCiudad.ValueMember = param
            cbCiudad.DisplayMember = param
        Else
            If param = "Provincia" Then
                Dim dt_prov As New DataTable()
                'cargamos los datos de la tabla de sql en nuestra tabla virtual (.fill)
                da.Fill(dt_prov)

                'cargamos el combobox con los datos de la columna ciudad o provincia en la tabla Contactos
                cbProvincia.DataSource = dt_prov
                cbProvincia.ValueMember = param
                cbProvincia.DisplayMember = param
            End If
        End If

    End Sub

    'procedimiento para cargar la tabla
    Private Sub cargarTabla()
        dt.Clear()
        Dim Consulta As New SqlCommand("SELECT * FROM Contactos", cnn)
        Dim da As New SqlDataAdapter(Consulta)
        'cargamos los datos de la tabla de sql en nuestra tabla virtual (.fill)
        da.Fill(dt)

        'tamaño de la tabla
        longtabla = dt.Rows.Count - 1
    End Sub

    'procedimiento para cargar los campos del formulario desde la bbdd
    Private Sub cargarCamposForm(i As Integer)
        'codigo
        txtCodigo.Text = dt.Rows(i)("Código").ToString()
        'nombre y apellido
        txtNomApe.Text = dt.Rows(i)("Nombre")
        'dirección
        If dt.Rows(i)("Dirección") Is DBNull.Value Then
            txtDireccion.Text = ""
        Else
            txtDireccion.Text = dt.Rows(i)("Dirección")
        End If
        'ciudad
        If dt.Rows(i)("Ciudad") Is DBNull.Value Then
            cbCiudad.SelectedValue = ""
        Else
            cbCiudad.SelectedValue = dt.Rows(i)("Ciudad")
        End If
        'provincia
        If dt.Rows(i)("Provincia") Is DBNull.Value Then
            cbProvincia.SelectedValue = ""
        Else
            cbProvincia.SelectedValue = dt.Rows(i)("Provincia")
        End If
        'código postal
        If dt.Rows(i)("CP") Is DBNull.Value Then
            txtCodPost.Text = ""
        Else
            txtCodPost.Text = dt.Rows(i)("CP")
        End If
        'fecha de nacimiento
        If dt.Rows(i)("Fecha_Nacimiento") Is DBNull.Value Then
            txtFechaNac.Value = Date.Now
            txtFechaNac.Checked = False
        Else
            txtFechaNac.Value = dt.Rows(i)("Fecha_Nacimiento").ToString()
        End If
        'teléfono fijo
        If dt.Rows(i)("Fijo") Is DBNull.Value Then
            txtFijo.Text = ""
        Else
            txtFijo.Text = dt.Rows(i)("Fijo")
        End If
        'teléfono móvil
        If dt.Rows(i)("Móvil") Is DBNull.Value Then
            txtMovil.Text = ""
        Else
            txtMovil.Text = dt.Rows(i)("Móvil")
        End If
        'correo electrónico
        If dt.Rows(i)("eMail") Is DBNull.Value Then
            txtMail.Text = ""
        Else
            txtMail.Text = dt.Rows(i)("eMail")
        End If
        'foto
        If dt.Rows(i)("Foto") Is DBNull.Value Then
            PicBoxFoto.Image = Nothing
        Else
            Dim ImagenByte As Byte() 'vector(array) de tipo byte
            Dim Imagen As MemoryStream
            Try
                ImagenByte = dt.Rows(i)("Foto")
                Imagen = New MemoryStream(ImagenByte) 'para meterlo en memoria
                PicBoxFoto.Image = Image.FromStream(Imagen)
                Imagen.Close() 'para cerrar el buffer
            Catch ex As Exception
            End Try
        End If
        'Notas
        If dt.Rows(i)("Notas") Is DBNull.Value Then
            txtNotas.Text = ""
        Else
            txtNotas.Text = dt.Rows(i)("Notas")
        End If
    End Sub


    'procedimiento para rellenar el formulario con un nuevo registro
    Private Sub Nuevo()
        'código no visible
        lblCodigo.Hide()
        txtCodigo.Hide()

        'focus en nombre y apellidos
        txtNomApe.Focus()

        'limpiar y habilitar campos
        'nombre
        txtNomApe.Clear()
        txtNomApe.Enabled = True
        'dirección
        txtDireccion.Clear()
        txtDireccion.Enabled = True
        'ciudad
        cargarCombos("Ciudad")
        cbCiudad.Enabled = True
        cbCiudad.SelectedValue = ""
        'provincia
        cargarCombos("Provincia")
        cbProvincia.Enabled = True
        cbProvincia.SelectedValue = ""
        'código postal
        txtCodPost.Clear()
        txtCodPost.Enabled = True
        'fecha nacimiento
        txtFechaNac.Value = Date.Now
        txtFechaNac.Enabled = True
        'fijo
        txtFijo.Clear()
        txtFijo.Enabled = True
        'movil
        txtMovil.Clear()
        txtMovil.Enabled = True
        'correo eléctronico
        txtMail.Clear()
        txtMail.Enabled = True
        'foto
        PicBoxFoto.Image = Nothing
        PicBoxFoto.Enabled = True
        'notas
        txtNotas.Clear()
        txtNotas.Enabled = True
    End Sub

    'procedimiento para editar 
    Private Sub Editar()
        'habilitar campos
        txtNomApe.Enabled = True
        txtDireccion.Enabled = True
        cbCiudad.Enabled = True
        cbProvincia.Enabled = True
        txtCodPost.Enabled = True
        txtFechaNac.Enabled = True
        txtFijo.Enabled = True
        txtMovil.Enabled = True
        txtMail.Enabled = True
        PicBoxFoto.Enabled = True
        txtNotas.Enabled = True
        btnSubirFoto.Enabled = True
        'Si no hay foto el botón borrar foto aparece deshabilitado
        If PicBoxFoto.Image Is Nothing Then
            btnBorrarFoto.Enabled = False
        Else
            btnBorrarFoto.Enabled = True
        End If

    End Sub

    'procedimiento para crear un nuevo registro
    Private Sub Guardar()
        Try
            'variables
            Dim cmdconsulta As New SqlCommand
            Dim consulta As String

            cnn.Open() 'abrir conexión 

            'comprobar si es un nuevo registro(INSERT) o estamos editando uno que ya existe (UPDATE)
            If nuevoReg Then
                consulta = "INSERT INTO Contactos (Nombre, Dirección, Ciudad, Provincia, CP, Fecha_Nacimiento, Fijo, Móvil, eMail, Foto, Notas) VALUES (@Nombre, @Direccion, @Ciudad, @Provincia, @CP, @FechaNac, @Fijo, @Movil, @Mail, @Foto, @Notas)"
            Else
                consulta = "UPDATE Contactos SET Nombre = @Nombre, Dirección = @Direccion, Ciudad = @Ciudad, Provincia = @Provincia, CP = @CP, Fecha_Nacimiento = @FechaNac, Fijo = @Fijo, Móvil =  @Movil, eMail = @Mail, Foto = @Foto, Notas = @Notas WHERE Código = @cod"
            End If
            cmdconsulta = New SqlCommand(consulta, cnn)
            'nombre
            If txtNomApe.Text = "" Then
                MessageBox.Show("El nombre no puede estar vacío")
            Else
                cmdconsulta.Parameters.AddWithValue("@Nombre", txtNomApe.Text)
            End If
            'dirección
            If txtDireccion.Text = "" Then
                cmdconsulta.Parameters.AddWithValue("@Direccion", DBNull.Value)
            Else
                cmdconsulta.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
            End If
            'ciudad
            'propiedad text para que nos guarde si escribimos una nueva ciudad que no estaba antes
            If cbCiudad.Text = "" Then
                cmdconsulta.Parameters.AddWithValue("@Ciudad", DBNull.Value)
            Else
                cmdconsulta.Parameters.AddWithValue("@Ciudad", cbCiudad.Text)
            End If
            'provincia
            If cbProvincia.Text = "" Then
                cmdconsulta.Parameters.AddWithValue("@Provincia", DBNull.Value)
            Else
                cmdconsulta.Parameters.AddWithValue("@Provincia", cbProvincia.Text)
            End If
            'código postal
            If txtCodPost.Text = "" Then
                cmdconsulta.Parameters.AddWithValue("@CP", DBNull.Value)
            Else
                cmdconsulta.Parameters.AddWithValue("@CP", txtCodPost.Text)
            End If
            'fecha de nacimiento
            If txtFechaNac.Checked = False Then
                cmdconsulta.Parameters.AddWithValue("@FechaNac", DBNull.Value)
            Else
                cmdconsulta.Parameters.AddWithValue("@FechaNac", txtFechaNac.Value)
            End If
            'fijo
            If txtFijo.MaskCompleted = False Then
                cmdconsulta.Parameters.AddWithValue("@Fijo", DBNull.Value)
            Else
                cmdconsulta.Parameters.AddWithValue("@Fijo", txtFijo.Text)
            End If
            'móvil
            If txtMovil.MaskCompleted = False Then
                cmdconsulta.Parameters.AddWithValue("@Movil", DBNull.Value)
            Else
                cmdconsulta.Parameters.AddWithValue("@Movil", txtMovil.Text)
            End If
            'correo electrónico
            If txtMail.Text = "" Then
                cmdconsulta.Parameters.AddWithValue("@Mail", DBNull.Value)
            Else
                cmdconsulta.Parameters.AddWithValue("@Mail", txtMail.Text)
            End If
            'foto
            Dim Foto As SqlParameter 'definir un objeto de tipo sqlParameter
            'instanciarlo con el parámetro (@foto) y el tipo (sqldbtype.Image)
            Foto = New SqlParameter("@Foto", SqlDbType.Image)

            If PicBoxFoto.Image Is Nothing Then
                Foto.Value = DBNull.Value
            Else
                Dim ms As New MemoryStream()
                Dim FotoByte As Byte()
                PicBoxFoto.Image.Save(ms, Imaging.ImageFormat.Jpeg)
                FotoByte = ms.GetBuffer
                Foto.Value = FotoByte
            End If
            cmdconsulta.Parameters.Add(Foto)
            'notas
            If txtNotas.Text = "" Then
                cmdconsulta.Parameters.AddWithValue("@Notas", DBNull.Value)
            Else
                cmdconsulta.Parameters.AddWithValue("@Notas", txtNotas.Text)
            End If

            'si estamos editando un registro también necesitamos el parámetro código
            If nuevoReg = False Then
                'códgio
                cmdconsulta.Parameters.AddWithValue("@cod", txtCodigo.Text)
            End If

            cmdconsulta.ExecuteNonQuery() 'ejecutar el comando de sql
            cnn.Close() 'cerrar la conexión

            'cargar los combos y la tabla
            cargarCombos("Ciudad")
            cargarCombos("Provincia")
            cargarTabla()
            'si es nuevo registro una vez guardado muestra el código
            If nuevoReg Then
                'mostrar el código
                lblCodigo.Show()
                txtCodigo.Show()
                'cargar el registro que acabamos de guardar
                registro = longtabla
                cargarCamposForm(registro)
            Else
                'cargar el registro que acabamos de guardar
                cargarCamposForm(registro)
            End If

            'diseño del formulario por defecto
            FormPorDefecto()
            cancelReg = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            MessageBox.Show("El registro no se ha podido guardar")
        End Try
    End Sub

    'procedimiento para borrar/Cancelar
    Private Sub borrarCancelar()
        If cancelReg Then
            result = MessageBox.Show("Los cambios se perderán, ¿desea borrar los cambios?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                cargarCamposForm(registro)
                FormPorDefecto()
                cancelReg = False
            Else
                Me.Show()
            End If
        Else
            result = MessageBox.Show("¿Quiere borrar el contacto de '" & txtNomApe.Text & "'?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                Borrar()
            Else
                Me.Show()
            End If

        End If
    End Sub

    'procedimiento para borrar un contacto
    Private Sub Borrar()
        Try
            'variables
            Dim cmdborrar As New SqlCommand
            Dim consultaBorrar As String
            cnn.Open()
            consultaBorrar = "DELETE FROM Contactos WHERE Código = @cod"
            cmdborrar = New SqlCommand(consultaBorrar, cnn)
            'códgio
            cmdborrar.Parameters.AddWithValue("@cod", txtCodigo.Text)

            cmdborrar.ExecuteNonQuery()
            cnn.Close()

            'cargar los combos y la tabla
            cargarCombos("Ciudad")
            cargarCombos("Provincia")
            cargarTabla()
            'mostrar registro anterior
            'si borramos el primer registro muestra el siguiente
            If registro = 0 Then
                registro += 1
                cargarCamposForm(registro)
                'si no es el primero, muestra el anterior
            Else
                registro -= 1
                cargarCamposForm(registro)
            End If
        Catch ex As Exception
            MessageBox.Show("El registro no se ha podido borrar")
        End Try
    End Sub
    'procedimiento para cargar las fotos
    Sub CargarFotos()
        Dim rutaFoto As String
        Try
            'OFDArchivo.ShowDialog() 'para abrir el cuadro de diálogo donde buscaremos el archivo
            'DialogResult.OK para comprobar que no se cancela el cuadro de dialogo
            If OFDCargarFoto.ShowDialog() = DialogResult.OK Then
                rutaFoto = OFDCargarFoto.FileName 'guardamos la ruta
                'para cargar el archivo en el PictureBox
                PicBoxFoto.Image = Image.FromFile(rutaFoto)
                btnBorrarFoto.Enabled = True
            End If
        Catch ex As Exception
        End Try

    End Sub
    'botones deshabilitados
    Private Sub btnsGuardarCancel()
        'deshabilitar los botones nuevo, editar
        btnNuevo.Enabled = False
        btnEditar.Enabled = False

        'habilitar boton guardar y cambiar tooltip de borrar por cancelar
        btnGuardar.Enabled = True
        btnBorrar.Text = "Cancelar registro"

        'habilitar subir foto
        btnSubirFoto.Enabled = True
    End Sub

    'procedimiento con el estado de los botones por defecto
    Private Sub FormPorDefecto()
        'habilitar los botones nuevo, editar
        btnNuevo.Enabled = True
        btnEditar.Enabled = True

        'deshabilitar boton guardar y cambiar tooltip de cancelar por borrar
        btnGuardar.Enabled = False
        btnBorrar.Text = "Borrar contacto"

        'deshabilitar subir y borrar foto
        btnBorrarFoto.Enabled = False
        btnSubirFoto.Enabled = False

        'todos los campos del formulario deshabilitados
        txtNomApe.Enabled = False
        txtDireccion.Enabled = False
        cbCiudad.Enabled = False
        cbProvincia.Enabled = False
        txtCodPost.Enabled = False
        txtFechaNac.Enabled = False
        txtFijo.Enabled = False
        txtMovil.Enabled = False
        txtMail.Enabled = False
        txtNotas.Enabled = False
    End Sub



#End Region

End Class

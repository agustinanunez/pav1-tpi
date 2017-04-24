﻿Public Class FormClientes

    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=(localdb)\Servidor;Integrated Security=SSPI;Initial Catalog=BD_CLOTTA"
    Dim accion As tipo_grabacion = tipo_grabacion.insertar
    Dim seleccion As String




    'ENUMERACION DE TIPOS DE GRABACION
    Enum tipo_grabacion
        insertar
        modificar
    End Enum



    'ENUMERACION DE TIPOS DE RESPUESTAS DE VALIDACION
    Enum respuesta_validacion
        _ok
        _error
    End Enum



    'LOADER DEL FORM
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargar_grilla_cliente()
        cargar_combo(cmb_tipo_documento_cliente_carga, ejecuto_sql("SELECT * FROM tipo_documento"), "id_tipo_documento", "nombre_tipo_documento")
        cargar_combo(cmb_tipo_documento_cliente_busqueda, ejecuto_sql("SELECT * FROM tipo_documento"), "id_tipo_documento", "nombre_tipo_documento")
    End Sub



    'SUBRUTINA PARA CARGAR GRILLAS
    Private Sub cargar_grilla_cliente()

        Dim tabla As New DataTable
        Dim sql_cargar_grilla As String = ""

        sql_cargar_grilla &= "SELECT * FROM clientes c "
        sql_cargar_grilla &= "JOIN tipo_documento td ON c.tipo_documento = td.id_tipo_documento"

        tabla = ejecuto_sql(sql_cargar_grilla)

        Dim c As Integer
        Me.grid_clientes.Rows.Clear()
        For c = 0 To tabla.Rows.Count - 1

            Me.grid_clientes.Rows.Add()
            Me.grid_clientes.Rows(c).Cells(0).Value = tabla.Rows(c)("apellido_cliente")
            Me.grid_clientes.Rows(c).Cells(1).Value = tabla.Rows(c)("nombre_cliente")
            Me.grid_clientes.Rows(c).Cells(2).Value = tabla.Rows(c)("nombre_tipo_documento")
            Me.grid_clientes.Rows(c).Cells(3).Value = tabla.Rows(c)("numero_documento")
            Me.grid_clientes.Rows(c).Cells(4).Value = tabla.Rows(c)("e_mail_cliente")
            Me.grid_clientes.Rows(c).Cells(5).Value = tabla.Rows(c)("telefono_cliente")

        Next

        Me.txt_apellido_cliente_carga.Focus()

    End Sub



    'FUNCION PARA EJECUTAR CONSULTAS SQL
    Private Function ejecuto_sql(ByVal sql As String)

        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()
        Return tabla
    End Function



    'SUBRUTINA PARA EJECUTAR INSERCIONES Y ELIMINACIONES EN LA BD
    Private Sub grabar_borrar(ByVal sql As String)
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub



    'SUBRUTINA PARA CARGAR COMBOS
    Private Sub cargar_combo(ByRef combo As ComboBox, tabla As DataTable, pk As String, ByVal descriptor As String)

        combo.DataSource = tabla
        combo.DisplayMember = descriptor
        combo.ValueMember = pk

    End Sub



    'SUBRUTINA PARA BLANQUEAR LOS CAMPOS
    Private Sub borrar_datos()

        For Each obj As Windows.Forms.Control In Me.Controls

            If obj.GetType().Name = "TextBox" Then

                obj.Text = ""

            End If

            If obj.GetType().Name = "MaskedTextBox" Then

                obj.Text = ""

            End If

            If obj.GetType().Name = "ComboBox" Then

                Dim local As ComboBox = obj

                local.SelectedValue = -1

            End If

        Next
    End Sub




    'BOTON PARA BLANQUEAR NUEVO CLIENTE
    Private Sub btn_nuevo_cliente_carga_Click(sender As Object, e As EventArgs) Handles btn_nuevo_cliente_carga.Click

        'If MessageBox.Show("¿Está seguro que desea eliminar los datos ingresados?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
        Me.borrar_datos()
        Me.accion = tipo_grabacion.insertar
        Me.btn_guardar_cliente_carga.Enabled = True
        Me.txt_apellido_cliente_carga.Enabled = True
        Me.txt_nombre_cliente_carga.Enabled = True
        Me.txt_numero_documento_carga.Enabled = True
        Me.cmb_tipo_documento_cliente_carga.Enabled = True
        Me.txt_email_cliente_cliente_carga.Enabled = True
        Me.txt_telefono_cliente_carga.Enabled = True
        Me.txt_apellido_cliente_carga.Focus()
        Me.cargar_grilla_cliente()
        ' End If


    End Sub



    'FUNCION PARA VALIDAR DATOS A GUARDAR
    Private Function validar_datos() As respuesta_validacion

        For Each obj As Windows.Forms.Control In Me.Controls

            If obj.GetType().Name = "TextBox" Or obj.GetType().Name = "MaskedTextBox" Then

                If obj.Text = "" Then

                    MsgBox("El campo " + obj.Name + "esta vacio.", MsgBoxStyle.OkOnly, "Error")
                    obj.Focus()
                    Return respuesta_validacion._error

                End If

            End If

            If obj.GetType().Name = "ComboBox" Then

                Dim local As ComboBox = obj

                If local.SelectedValue = -1 Then

                    MsgBox("El campo " + obj.Name + "esta vacio.", MsgBoxStyle.OkOnly, "Error")
                    obj.Focus()
                    Return respuesta_validacion._error

                End If

            End If

        Next

        Return respuesta_validacion._ok

    End Function



    'FUNCION PARA VALIDAR UNA PERSONA (PARA QUE NO EXISTA)
    Private Function validar_persona() As respuesta_validacion

        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT numero_documento FROM clientes WHERE numero_documento = " & Me.txt_numero_documento_carga.Text

        tabla = ejecuto_sql(sql)

        If tabla.Rows.Count = 1 Then
            Return respuesta_validacion._error
        End If

        Return respuesta_validacion._ok

    End Function



    'SUBRUTINA PARA GUARDAR INFORMACION A LA BD
    Private Sub btn_guardar_cliente_carga_Click(sender As Object, e As EventArgs) Handles btn_guardar_cliente_carga.Click

        If validar_datos() = respuesta_validacion._ok Then

            If accion = tipo_grabacion.insertar Then

                If validar_persona() = respuesta_validacion._ok Then

                    insertar()
                    'Me.borrar_datos()

                End If
            Else
                modificar()

            End If



        End If


    End Sub



    'SUBRUTINA PARA INSERTAR DATOS
    Private Sub insertar()

        Dim sql As String = ""

        sql &= "INSERT INTO clientes("
        sql &= "numero_documento,"
        sql &= "tipo_documento,"
        sql &= "nombre_cliente,"
        sql &= "apellido_cliente,"
        sql &= "telefono_cliente,"
        sql &= "e_mail_cliente)"
        sql &= " VALUES("
        sql &= "  " & Me.txt_numero_documento_carga.Text
        sql &= "," & Me.cmb_tipo_documento_cliente_carga.SelectedValue
        sql &= ", '" & Me.txt_nombre_cliente_carga.Text & "'"
        sql &= ", '" & Me.txt_apellido_cliente_carga.Text & "'"
        sql &= "," & Me.txt_telefono_cliente_carga.Text
        sql &= ", '" & Me.txt_email_cliente_cliente_carga.Text & "')"

        Me.grabar_borrar(sql)
        Me.cargar_grilla_cliente()
        Me.btn_guardar_cliente_carga.Enabled = False
        Me.txt_apellido_cliente_carga.Enabled = False
        Me.txt_nombre_cliente_carga.Enabled = False
        Me.txt_numero_documento_carga.Enabled = False
        Me.cmb_tipo_documento_cliente_carga.Enabled = False
        Me.txt_email_cliente_cliente_carga.Enabled = False
        Me.txt_telefono_cliente_carga.Enabled = False


        MsgBox("La carga del cliente fue exitosa", MessageBoxButtons.OK, "Carga Cliente")

    End Sub



    'SUBRUTINA PARA INTERACCION DE GRILLA
    Private Sub grid_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_clientes.CellContentClick

        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= " SELECT * FROM clientes "
        sql &= " WHERE numero_documento = " & Me.grid_clientes.CurrentRow.Cells(3).Value

        tabla = Me.ejecuto_sql(sql)

        Me.txt_apellido_cliente_carga.Text = tabla.Rows(0)("apellido_cliente")
        Me.txt_nombre_cliente_carga.Text = tabla.Rows(0)("nombre_cliente")
        Me.cmb_tipo_documento_cliente_carga.SelectedValue = tabla.Rows(0)("tipo_documento")
        Me.txt_numero_documento_carga.Text = tabla.Rows(0)("numero_documento")
        Me.txt_email_cliente_cliente_carga.Text = tabla.Rows(0)("e_mail_cliente")
        Me.txt_telefono_cliente_carga.Text = tabla.Rows(0)("telefono_cliente")

        Me.accion = tipo_grabacion.modificar
        Me.txt_apellido_cliente_carga.Enabled = True
        Me.txt_nombre_cliente_carga.Enabled = True
        Me.txt_numero_documento_carga.Enabled = False
        Me.cmb_tipo_documento_cliente_carga.Enabled = False
        Me.txt_email_cliente_cliente_carga.Enabled = True
        Me.txt_telefono_cliente_carga.Enabled = True
        Me.btn_guardar_cliente_carga.Enabled = True

    End Sub



    'SUBRUTINA PARA MODIFICAR CLIENTES
    Private Sub modificar()

        Dim sql As String = ""

        sql &= "UPDATE clientes SET "
        sql &= "apellido_cliente = '" & Me.txt_apellido_cliente_carga.Text & "'"
        sql &= ", nombre_cliente = '" & Me.txt_nombre_cliente_carga.Text & "'"
        sql &= ", e_mail_cliente = '" & Me.txt_email_cliente_cliente_carga.Text & "'"
        sql &= ", telefono_cliente = " & Me.txt_telefono_cliente_carga.Text
        sql &= " WHERE numero_documento = " & Me.txt_numero_documento_carga.Text


        grabar_borrar(sql)

        MsgBox("El cliente fue modificado", MessageBoxButtons.OK, "Exito")

        cargar_grilla_cliente()

    End Sub



    'SUBRUTINA PARA BORRAR CLIENTES
    Private Sub btn_eliminar_cliente_carga_Click(sender As Object, e As EventArgs) Handles btn_eliminar_cliente_carga.Click

        Dim sql As String = ""

        sql &= "DELETE clientes WHERE numero_documento = " & Me.grid_clientes.CurrentRow.Cells(3).Value

        If MessageBox.Show("¿Está seguro que quiere eliminar el registro?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.grabar_borrar(sql)
            MsgBox("Se borraron los datos exitosamente", MessageBoxButtons.OK, "Eliminación Cliente")
            cargar_grilla_cliente()
        End If

        If Me.grid_clientes.CurrentCell.Selected = False Then
            MessageBox.Show("Falta seleccionar dato en grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub



    'SUBRUTINA PARA PREGUNTAR CUANDO SE CIERRA EL FORMULARIO
    Private Sub formClientes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Está seguro que quiere salir del formulario", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

   

    'SUBRUTINA PARA BUSCAR Y ENCONTRAR UN CLIENTE X NUMERO Y TIPO DE DOCUMENTO
    Private Sub btn_buscar_cliente_Click(sender As Object, e As EventArgs) Handles btn_buscar_cliente.Click

        Dim sql As String = ""
        Dim tabla As New DataTable
        sql &= "SELECT * FROM clientes c JOIN tipo_documento td ON c.tipo_documento = td.id_tipo_documento "
        sql &= " WHERE td.nombre_tipo_documento = '" & Me.cmb_tipo_documento_cliente_busqueda.Text & "'"
        sql &= " AND c.numero_documento = " & Me.txt_numero_documento_cliente_busqueda.Text

        tabla = Me.ejecuto_sql(sql)

        Dim c As Integer
        Me.grid_clientes.Rows.Clear()
        For c = 0 To tabla.Rows.Count - 1

            Me.grid_clientes.Rows.Add()
            Me.grid_clientes.Rows(c).Cells(0).Value = tabla.Rows(c)("apellido_cliente")
            Me.grid_clientes.Rows(c).Cells(1).Value = tabla.Rows(c)("nombre_cliente")
            Me.grid_clientes.Rows(c).Cells(2).Value = tabla.Rows(c)("nombre_tipo_documento")
            Me.grid_clientes.Rows(c).Cells(3).Value = tabla.Rows(c)("numero_documento")
            Me.grid_clientes.Rows(c).Cells(4).Value = tabla.Rows(c)("e_mail_cliente")
            Me.grid_clientes.Rows(c).Cells(5).Value = tabla.Rows(c)("telefono_cliente")

        Next

        If tabla.Rows.Count = 0 Then
            MsgBox("No se encontró ningun resultado", MsgBoxStyle.OkOnly, "Error")
            cargar_grilla_cliente()
        End If
    End Sub




End Class
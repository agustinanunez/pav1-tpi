﻿Imports System.ComponentModel
Imports System.Data.OleDb

Public Class FormCompras
    'ENUMERADOR DE RESPUESTAS DE VALIDACION
    Enum respuesta_validacion
        _ok
        _error
    End Enum

    Enum estado_transaccion
        _iniciada
        _sin_iniciar
    End Enum

    Private estado_actual_transaccion As estado_transaccion = estado_transaccion._sin_iniciar

    'LOADER DE COMPRAS
    Private Sub form_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SoporteGUI.cargar_combo(cmb_fabrica, SoporteBD.leerBD_simple("SELECT * FROM fabricas"), "id_fabrica", "nombre")
        Me.limpiar_campos_detalle()
        Me.deshabilitar_campos()
        txt_id_compra.Text = Format(SoporteBD.autogenerar_codigo("AUTOGENERARCODIGO_compras"), "000")
    End Sub

    'BOTON NUEVO
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        If estado_actual_transaccion = estado_transaccion._iniciada Then
            If MessageBox.Show("¿Está seguro que desea cancelar la transacción actual?", "Gestión de Compras", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.Cancel Then
                Return
            End If
        End If
        estado_actual_transaccion = estado_transaccion._iniciada

        Me.limpiar_campos_compra()
        Me.deshabilitar_detalle()
        Me.cmb_fabrica.Enabled = True
        Me.chk_fabrica.Enabled = True
        Me.chk_fabrica.Checked = False
        Me.txt_id_compra.Text = SoporteBD.autogenerar_codigo("AUTOGENERARCODIGO_compras")
        Me.txt_precio.Focus()
    End Sub

    Private Sub calcular_total()
        Dim c As Integer
        Dim total As Double
        Dim parcial As Double
        For c = 0 To Me.dgv_compras.Rows.Count - 1
            parcial = Math.Round(Convert.ToDouble(Me.dgv_compras.Rows(c).Cells("col_cantidad").Value)) * Math.Round(Convert.ToDouble(Me.dgv_compras.Rows(c).Cells("col_precio").Value))
            total = total + parcial
        Next
        Me.txt_monto.Text = total
    End Sub


    'BOTON AGREGAR
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If validar_campos_detalle() Then
            'PRIMERO VERIFICA SI LAS FILAS DE LA TABLA SON NULAS
            If Me.dgv_compras.Rows.Count = 0 Then
                If Convert.ToInt32(Me.txt_cantidad.Text) > 0 Then
                    If Convert.ToDouble(Me.txt_precio.Text) > 0 Then
                        Me.dgv_compras.Rows.Add(cmb_producto.Text, Me.txt_cantidad.Text, Me.txt_precio.Text, cmb_producto.SelectedValue)
                        Me.calcular_total()
                        Me.btn_guardar.Enabled = True
                    End If

                End If

                If Convert.ToDouble(Me.txt_monto.Text) = 0 Then
                    MsgBox("El precio no puede ser igual a cero", MsgBoxStyle.OkCancel, "Error")
                End If

                If Convert.ToInt32(Me.txt_cantidad.Text) = 0 Then
                    MsgBox("La cantidad no puede ser igual a cero", MsgBoxStyle.OkCancel, "Error")
                End If



            Else
                If existe_en_grid() = False Then
                    If Convert.ToInt32(Me.txt_cantidad.Text) > 0 Then
                        If Convert.ToDouble(Me.txt_precio.Text) > 0 Then
                            Me.dgv_compras.Rows.Add(cmb_producto.Text, Me.txt_cantidad.Text, Me.txt_precio.Text, cmb_producto.SelectedValue)
                            Me.calcular_total()
                            Me.btn_guardar.Enabled = True
                        End If
                    End If

                    If Convert.ToDouble(Me.txt_monto.Text) = 0 Then
                        MsgBox("El precio no puede ser igual a cero", MsgBoxStyle.OkCancel, "Error")
                    End If

                    If Convert.ToInt32(Me.txt_cantidad.Text) = 0 Then
                        MsgBox("La cantidad no puede ser igual a cero", MsgBoxStyle.OkCancel, "Error")
                    End If

                End If
            End If
            Me.limpiar_campos_detalle()
        End If
    End Sub

    Private Function validar_campos_detalle()
        Dim mensaje As String = "Faltan campos requeridos para agregar un nuevo artículo:"
        Dim flag As Boolean = True
        If Me.cmb_producto.SelectedIndex = -1 Then
            flag = False
            mensaje &= vbCrLf & "- producto"
        End If
        If Me.txt_cantidad.Text = "" Then
            flag = False
            mensaje &= vbCrLf & "- cantidad"
        End If
        If Me.txt_precio.Text = "" Then
            flag = False
            mensaje &= vbCrLf & "- precio unitario del producto comprado"
        End If
        If flag = False Then
            MessageBox.Show(mensaje, "Gestión de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return flag
    End Function

    'BOTON ELIMINAR
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If Me.dgv_compras.Rows.Count > 0 Then
            Me.dgv_compras.Rows.Remove(Me.dgv_compras.CurrentRow)
            Me.calcular_total()
        End If
        Me.cmb_producto.Enabled = True
        Me.btn_modificar.Enabled = False
        Me.btn_modificar.Visible = False
        Me.btn_agregar.Enabled = True
        Me.btn_eliminar.Enabled = False
        Me.limpiar_campos_detalle()
    End Sub

    'FUNCION QUE DEVUELVE TRUE SI EXISTE UN ELEMENTO SELECCIONADO EN LA GRILLA
    Private Function existe_en_grid()
        Dim valor As Boolean = False
        For a = 0 To Me.dgv_compras.Rows.Count - 1
            If Me.cmb_producto.SelectedValue = Me.dgv_compras.Rows(a).Cells("col_id_producto").Value Then
                MsgBox("El producto '" & cmb_producto.Text & "' ya fue cargado, seleccione otro", MsgBoxStyle.OkOnly, "Error")
                valor = True
            End If
        Next
        Return valor
    End Function

    'BOTON GRABAR
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If dgv_compras.Rows.Count > 0 Then
            SoporteBD.iniciar_conexion_con_transaccion()

            Dim sql_insertar_compra As String = ""
            sql_insertar_compra &= "INSERT INTO compras(id_compra,fecha_compra,hora_compra,monto) VALUES(" & txt_id_compra.Text
            sql_insertar_compra &= ", '" & txt_fecha.Text & "'"
            sql_insertar_compra &= ", '" & txt_hora.Text & "'"
            sql_insertar_compra &= "," & txt_monto.Text & ")"
            SoporteBD.escribirBD_transaccion(sql_insertar_compra)

            Dim sql_insertar_detalle As String = ""
            Dim tabla As New DataTable
            Dim sql As String = ""

            For c = 0 To Me.dgv_compras.Rows.Count - 1
                sql_insertar_detalle &= " INSERT INTO detalles_compras(id_compra,id_producto,cantidad,precio_unitario) VALUES (" & txt_id_compra.Text
                sql_insertar_detalle &= "," & Me.dgv_compras.Rows(c).Cells("col_id_producto").Value
                sql_insertar_detalle &= "," & Me.dgv_compras.Rows(c).Cells("col_cantidad").Value
                sql_insertar_detalle &= "," & Me.dgv_compras.Rows(c).Cells("col_precio").Value & ")"
                SoporteBD.escribirBD_transaccion(sql_insertar_detalle)
                sql_insertar_detalle = ""
            Next

            MessageBox.Show("Datos almacenados.", "Gestión de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SoporteBD.cerrar_conexion_con_transaccion()
            estado_actual_transaccion = estado_transaccion._sin_iniciar
            Me.deshabilitar_campos()
        End If

        If dgv_compras.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para guardar", "Gestión de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    
    End Sub

    'DESHABILITAR CAMPOS
    Private Sub deshabilitar_campos()
        Me.txt_cantidad.Enabled = False
        Me.txt_fecha.Enabled = False
        Me.txt_hora.Enabled = False
        Me.txt_id_compra.Enabled = False
        Me.txt_precio.Enabled = False
        Me.txt_monto.Enabled = False
        Me.btn_guardar.Enabled = False
        Me.cmb_producto.Enabled = False
        Me.dgv_compras.Enabled = False
        Me.btn_agregar.Enabled = False
        Me.btn_eliminar.Enabled = False
        Me.cmb_fabrica.Enabled = False
        Me.chk_fabrica.Enabled = False
    End Sub

    'LIMPIAR EL CONTENIDO DE LOS CAMPOS DE LA COMPRA
    Private Sub limpiar_campos_compra()
        Me.txt_cantidad.Text = ""
        Me.txt_fecha.Text = Today
        Me.txt_hora.Text = TimeOfDay
        Me.txt_monto.Text = "0,00"
        Me.txt_precio.Text = ""
        Me.cmb_producto.Text = ""
        Me.dgv_compras.Rows.Clear()
        Me.cmb_fabrica.SelectedIndex = -1

    End Sub

    'LIMPIAR EL CONTENIDO DE LOS CAMPOS DE LOS PRODUCTOS A CARGAR DE LA COMPRA
    Private Sub limpiar_campos_detalle()
        Me.txt_cantidad.Text = ""
        Me.cmb_producto.SelectedIndex = -1
        'Me.cmb_fabrica.SelectedIndex = -1
        Me.txt_precio.Text = ""
    End Sub

    'VALIDAR CAMPOS
    Private Function validar_campos()
        If txt_cantidad.Text = "" Or txt_fecha.Text = "" Or txt_precio.Text = "" Or cmb_producto.SelectedValue = 0 Then
            MsgBox("Alguno de los campos no fue completado", MsgBoxStyle.OkOnly, "Error")
            Return respuesta_validacion._error
        End If
        Return respuesta_validacion._ok
    End Function

    'VALIDAR COMPRA
    Public Function validar_compra()
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql &= "SELECT * FROM compras WHERE id_compra = " & Me.txt_id_compra.Text
        tabla = SoporteBD.leerBD_simple(sql)

        If tabla.Rows.Count = 1 Then
            MsgBox("El numero de compra ya existe, ingrese otro", MsgBoxStyle.OkOnly, "Error")
            Return respuesta_validacion._error
        End If
        Return respuesta_validacion._ok
    End Function

    'CIERRE FORMULARIO
    Private Sub FormCompras_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("¿Está seguro que desea salir?", "Gestión de Compras", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub


    'ABRIR PRODUCTOS Y ACTUALIZAR EL COMBO DE PRODUCTOS CUANDO SE GUARDA
    Private Sub btn_nuevo_producto_Click(sender As Object, e As EventArgs) Handles btn_nuevo_producto.Click
        'Dim frmProductos = New FormProductos
        'frmProductos.Visible = True
        Using form As New FormProductos
            If form.ShowDialog() = DialogResult.OK Then
                SoporteGUI.cargar_combo(cmb_producto, SoporteBD.leerBD_simple("SELECT * FROM productos"), "id_producto", "descripcion")
            End If
        End Using

    End Sub

    Private Sub cmb_fabrica_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_fabrica.SelectionChangeCommitted
        SoporteGUI.cargar_combo(cmb_producto, SoporteBD.leerBD_simple("SELECT * FROM productos WHERE id_fabrica = " & Me.cmb_fabrica.SelectedValue), "id_producto", "descripcion")
    End Sub

    Private Sub dgv_compras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_compras.CellContentClick

        Me.cmb_producto.SelectedValue = Me.dgv_compras.CurrentRow.Cells("col_id_producto").Value
        Me.txt_precio.Text = Me.dgv_compras.CurrentRow.Cells("col_precio").Value
        Me.txt_cantidad.Text = Me.dgv_compras.CurrentRow.Cells("col_cantidad").Value

        Me.cmb_producto.Enabled = False
        Me.btn_modificar.Enabled = True
        Me.btn_modificar.Visible = True
        Me.btn_agregar.Enabled = False
        Me.btn_eliminar.Enabled = True

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click

        If Math.Round(Convert.ToDouble(txt_precio.Text)) = 0 Then
            MsgBox("Precio no admitido", MsgBoxStyle.OkOnly, "Error")
            Return
        Else
            Me.dgv_compras.CurrentRow.Cells(2).Value = Me.txt_precio.Text
        End If

        If txt_cantidad.Text = 0 Then
            MsgBox("Cantidad no admitida", MsgBoxStyle.OkOnly, "Error")
            Return
        Else
            Me.dgv_compras.CurrentRow.Cells(1).Value = Me.txt_cantidad.Text
        End If



        Me.calcular_total()
        Me.cmb_producto.Enabled = True
        Me.btn_modificar.Enabled = False
        Me.btn_modificar.Visible = False
        Me.btn_agregar.Enabled = True
        Me.btn_eliminar.Enabled = False
        Me.limpiar_campos_detalle()


    End Sub

    Private Sub deshabilitar_detalle()
        Me.cmb_producto.Enabled = False
        Me.txt_precio.Enabled = False
        Me.txt_cantidad.Enabled = False
        Me.dgv_compras.Enabled = False
        Me.btn_agregar.Enabled = False
    End Sub

    Private Sub habilitar_detalle()
        Me.cmb_producto.Enabled = True
        Me.txt_precio.Enabled = True
        Me.txt_cantidad.Enabled = True
        Me.dgv_compras.Enabled = True
        Me.btn_agregar.Enabled = True
    End Sub

    Private Sub chk_fabrica_CheckedChanged(sender As Object, e As EventArgs) Handles chk_fabrica.CheckedChanged
        If chk_fabrica.Checked = True Then
            If cmb_fabrica.SelectedIndex = -1 Then
                MsgBox("Fabrica no seleccionada", MsgBoxStyle.OkOnly, "Error")
                Me.chk_fabrica.Checked = False
            Else
                If MessageBox.Show("¿La fábrica seleccionada es correcta?", "Compras", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Me.habilitar_detalle()
                    Me.chk_fabrica.Enabled = False
                    Me.cmb_fabrica.Enabled = False
                Else
                    Me.chk_fabrica.Checked = False
                End If
            End If
        End If
    End Sub

    Private Sub txt_monto_TextChanged(sender As Object, e As EventArgs) Handles txt_monto.TextChanged
        If Convert.ToDouble(Me.txt_monto.Text) > 0 Then
            Me.btn_guardar.Enabled = True
        End If

        If Convert.ToDouble(Me.txt_monto.Text) = 0 Then
            Me.btn_guardar.Enabled = False
        End If
    End Sub

End Class
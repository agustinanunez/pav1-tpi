﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVentas))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_formasPago = New System.Windows.Forms.Button()
        Me.chk_descuento = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_usuarioLogueado = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_borrarCLIENTE = New System.Windows.Forms.Button()
        Me.btn_buscarCLIENTE = New System.Windows.Forms.Button()
        Me.txt_nombreCLIENTE = New System.Windows.Forms.TextBox()
        Me.cmb_tipoDocCLIENTE = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_nroDocCLIENTE = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_dtoVENTA = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_aceptarDETALLE = New System.Windows.Forms.Button()
        Me.btn_eliminarDETALLE = New System.Windows.Forms.Button()
        Me.btn_agregarDETALLE = New System.Windows.Forms.Button()
        Me.txt_subtotalVENTA = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_producto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv_detalle = New System.Windows.Forms.DataGridView()
        Me.col_id_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_final = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_idVENTA = New System.Windows.Forms.TextBox()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.txt_totalVENTA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_cancelarVENTA = New System.Windows.Forms.Button()
        Me.btn_nuevaVENTA = New System.Windows.Forms.Button()
        Me.btn_guardarVENTA = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(757, 47)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "  Registro de Venta"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_formasPago)
        Me.GroupBox1.Controls.Add(Me.chk_descuento)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txt_usuarioLogueado)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.txt_dtoVENTA)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txt_idVENTA)
        Me.GroupBox1.Controls.Add(Me.txt_hora)
        Me.GroupBox1.Controls.Add(Me.txt_fecha)
        Me.GroupBox1.Controls.Add(Me.txt_totalVENTA)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(729, 526)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Venta"
        '
        'btn_formasPago
        '
        Me.btn_formasPago.BackColor = System.Drawing.Color.White
        Me.btn_formasPago.Enabled = False
        Me.btn_formasPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_formasPago.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_formasPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_formasPago.Image = Global.PAV1_TPI.My.Resources.Resources.new_document
        Me.btn_formasPago.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_formasPago.Location = New System.Drawing.Point(21, 397)
        Me.btn_formasPago.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_formasPago.Name = "btn_formasPago"
        Me.btn_formasPago.Size = New System.Drawing.Size(152, 45)
        Me.btn_formasPago.TabIndex = 16
        Me.btn_formasPago.Text = "Formas de Pago"
        Me.btn_formasPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_formasPago.UseVisualStyleBackColor = False
        '
        'chk_descuento
        '
        Me.chk_descuento.AutoSize = True
        Me.chk_descuento.Enabled = False
        Me.chk_descuento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_descuento.ForeColor = System.Drawing.Color.Black
        Me.chk_descuento.Location = New System.Drawing.Point(409, 535)
        Me.chk_descuento.Name = "chk_descuento"
        Me.chk_descuento.Size = New System.Drawing.Size(139, 21)
        Me.chk_descuento.TabIndex = 18
        Me.chk_descuento.Text = "Guardar descuento"
        Me.chk_descuento.UseVisualStyleBackColor = True
        Me.chk_descuento.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(461, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 17)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Vendedor"
        '
        'txt_usuarioLogueado
        '
        Me.txt_usuarioLogueado.Enabled = False
        Me.txt_usuarioLogueado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuarioLogueado.ForeColor = System.Drawing.Color.Black
        Me.txt_usuarioLogueado.Location = New System.Drawing.Point(532, 34)
        Me.txt_usuarioLogueado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_usuarioLogueado.Name = "txt_usuarioLogueado"
        Me.txt_usuarioLogueado.Size = New System.Drawing.Size(174, 25)
        Me.txt_usuarioLogueado.TabIndex = 7
        Me.txt_usuarioLogueado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_borrarCLIENTE)
        Me.GroupBox4.Controls.Add(Me.btn_buscarCLIENTE)
        Me.GroupBox4.Controls.Add(Me.txt_nombreCLIENTE)
        Me.GroupBox4.Controls.Add(Me.cmb_tipoDocCLIENTE)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txt_nroDocCLIENTE)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(21, 67)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(685, 65)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del Cliente"
        '
        'btn_borrarCLIENTE
        '
        Me.btn_borrarCLIENTE.BackColor = System.Drawing.Color.White
        Me.btn_borrarCLIENTE.Enabled = False
        Me.btn_borrarCLIENTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_borrarCLIENTE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_borrarCLIENTE.ForeColor = System.Drawing.Color.White
        Me.btn_borrarCLIENTE.Image = Global.PAV1_TPI.My.Resources.Resources.cancel_button
        Me.btn_borrarCLIENTE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_borrarCLIENTE.Location = New System.Drawing.Point(638, 28)
        Me.btn_borrarCLIENTE.Name = "btn_borrarCLIENTE"
        Me.btn_borrarCLIENTE.Size = New System.Drawing.Size(25, 25)
        Me.btn_borrarCLIENTE.TabIndex = 6
        Me.btn_borrarCLIENTE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_borrarCLIENTE.UseVisualStyleBackColor = False
        '
        'btn_buscarCLIENTE
        '
        Me.btn_buscarCLIENTE.BackColor = System.Drawing.Color.White
        Me.btn_buscarCLIENTE.Enabled = False
        Me.btn_buscarCLIENTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscarCLIENTE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscarCLIENTE.ForeColor = System.Drawing.Color.White
        Me.btn_buscarCLIENTE.Image = Global.PAV1_TPI.My.Resources.Resources.magnifier16
        Me.btn_buscarCLIENTE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscarCLIENTE.Location = New System.Drawing.Point(371, 28)
        Me.btn_buscarCLIENTE.Name = "btn_buscarCLIENTE"
        Me.btn_buscarCLIENTE.Size = New System.Drawing.Size(25, 25)
        Me.btn_buscarCLIENTE.TabIndex = 4
        Me.btn_buscarCLIENTE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscarCLIENTE.UseVisualStyleBackColor = False
        '
        'txt_nombreCLIENTE
        '
        Me.txt_nombreCLIENTE.Enabled = False
        Me.txt_nombreCLIENTE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombreCLIENTE.ForeColor = System.Drawing.Color.Black
        Me.txt_nombreCLIENTE.Location = New System.Drawing.Point(402, 28)
        Me.txt_nombreCLIENTE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_nombreCLIENTE.Name = "txt_nombreCLIENTE"
        Me.txt_nombreCLIENTE.Size = New System.Drawing.Size(230, 25)
        Me.txt_nombreCLIENTE.TabIndex = 5
        '
        'cmb_tipoDocCLIENTE
        '
        Me.cmb_tipoDocCLIENTE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipoDocCLIENTE.Enabled = False
        Me.cmb_tipoDocCLIENTE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipoDocCLIENTE.ForeColor = System.Drawing.Color.Black
        Me.cmb_tipoDocCLIENTE.FormattingEnabled = True
        Me.cmb_tipoDocCLIENTE.Location = New System.Drawing.Point(120, 28)
        Me.cmb_tipoDocCLIENTE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmb_tipoDocCLIENTE.Name = "cmb_tipoDocCLIENTE"
        Me.cmb_tipoDocCLIENTE.Size = New System.Drawing.Size(103, 25)
        Me.cmb_tipoDocCLIENTE.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(229, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 17)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Nro."
        '
        'txt_nroDocCLIENTE
        '
        Me.txt_nroDocCLIENTE.Enabled = False
        Me.txt_nroDocCLIENTE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nroDocCLIENTE.ForeColor = System.Drawing.Color.Black
        Me.txt_nroDocCLIENTE.Location = New System.Drawing.Point(269, 28)
        Me.txt_nroDocCLIENTE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_nroDocCLIENTE.Name = "txt_nroDocCLIENTE"
        Me.txt_nroDocCLIENTE.Size = New System.Drawing.Size(96, 25)
        Me.txt_nroDocCLIENTE.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(15, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 17)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Tipo documento"
        '
        'txt_dtoVENTA
        '
        Me.txt_dtoVENTA.Enabled = False
        Me.txt_dtoVENTA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dtoVENTA.ForeColor = System.Drawing.Color.Black
        Me.txt_dtoVENTA.Location = New System.Drawing.Point(579, 397)
        Me.txt_dtoVENTA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_dtoVENTA.MaxLength = 2
        Me.txt_dtoVENTA.Name = "txt_dtoVENTA"
        Me.txt_dtoVENTA.Size = New System.Drawing.Size(105, 25)
        Me.txt_dtoVENTA.TabIndex = 11
        Me.txt_dtoVENTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(505, 400)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Descuento"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Image = Global.PAV1_TPI.My.Resources.Resources.clotta_nombre
        Me.Label9.Location = New System.Drawing.Point(597, 476)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 33)
        Me.Label9.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro. Venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(331, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hora"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_aceptarDETALLE)
        Me.GroupBox2.Controls.Add(Me.btn_eliminarDETALLE)
        Me.GroupBox2.Controls.Add(Me.btn_agregarDETALLE)
        Me.GroupBox2.Controls.Add(Me.txt_subtotalVENTA)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cmb_producto)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_cantidad)
        Me.GroupBox2.Controls.Add(Me.txt_precio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dgv_detalle)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(685, 252)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles de la Venta"
        '
        'btn_aceptarDETALLE
        '
        Me.btn_aceptarDETALLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_aceptarDETALLE.Enabled = False
        Me.btn_aceptarDETALLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptarDETALLE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptarDETALLE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_aceptarDETALLE.Image = Global.PAV1_TPI.My.Resources.Resources.check_mark
        Me.btn_aceptarDETALLE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptarDETALLE.Location = New System.Drawing.Point(240, 192)
        Me.btn_aceptarDETALLE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_aceptarDETALLE.Name = "btn_aceptarDETALLE"
        Me.btn_aceptarDETALLE.Size = New System.Drawing.Size(105, 45)
        Me.btn_aceptarDETALLE.TabIndex = 9
        Me.btn_aceptarDETALLE.Text = "Aceptar"
        Me.btn_aceptarDETALLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptarDETALLE.UseVisualStyleBackColor = True
        Me.btn_aceptarDETALLE.Visible = False
        '
        'btn_eliminarDETALLE
        '
        Me.btn_eliminarDETALLE.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_eliminarDETALLE.Enabled = False
        Me.btn_eliminarDETALLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminarDETALLE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminarDETALLE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_eliminarDETALLE.Image = Global.PAV1_TPI.My.Resources.Resources.trash_bin32
        Me.btn_eliminarDETALLE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminarDETALLE.Location = New System.Drawing.Point(129, 192)
        Me.btn_eliminarDETALLE.Name = "btn_eliminarDETALLE"
        Me.btn_eliminarDETALLE.Size = New System.Drawing.Size(105, 45)
        Me.btn_eliminarDETALLE.TabIndex = 8
        Me.btn_eliminarDETALLE.Text = "Eliminar"
        Me.btn_eliminarDETALLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminarDETALLE.UseVisualStyleBackColor = True
        Me.btn_eliminarDETALLE.Visible = False
        '
        'btn_agregarDETALLE
        '
        Me.btn_agregarDETALLE.Enabled = False
        Me.btn_agregarDETALLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregarDETALLE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregarDETALLE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_agregarDETALLE.Image = Global.PAV1_TPI.My.Resources.Resources.plus_circular_button32
        Me.btn_agregarDETALLE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_agregarDETALLE.Location = New System.Drawing.Point(18, 192)
        Me.btn_agregarDETALLE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_agregarDETALLE.Name = "btn_agregarDETALLE"
        Me.btn_agregarDETALLE.Size = New System.Drawing.Size(105, 45)
        Me.btn_agregarDETALLE.TabIndex = 7
        Me.btn_agregarDETALLE.Text = "Agregar"
        Me.btn_agregarDETALLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_agregarDETALLE.UseVisualStyleBackColor = True
        '
        'txt_subtotalVENTA
        '
        Me.txt_subtotalVENTA.Enabled = False
        Me.txt_subtotalVENTA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotalVENTA.ForeColor = System.Drawing.Color.Black
        Me.txt_subtotalVENTA.Location = New System.Drawing.Point(558, 212)
        Me.txt_subtotalVENTA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_subtotalVENTA.Name = "txt_subtotalVENTA"
        Me.txt_subtotalVENTA.Size = New System.Drawing.Size(105, 25)
        Me.txt_subtotalVENTA.TabIndex = 11
        Me.txt_subtotalVENTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(496, 215)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 17)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Subtotal"
        '
        'cmb_producto
        '
        Me.cmb_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_producto.Enabled = False
        Me.cmb_producto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_producto.ForeColor = System.Drawing.Color.Black
        Me.cmb_producto.FormattingEnabled = True
        Me.cmb_producto.Location = New System.Drawing.Point(99, 28)
        Me.cmb_producto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmb_producto.Name = "cmb_producto"
        Me.cmb_producto.Size = New System.Drawing.Size(254, 25)
        Me.cmb_producto.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(533, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Cantidad (*)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(359, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Precio unitario"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Enabled = False
        Me.txt_cantidad.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad.ForeColor = System.Drawing.Color.Black
        Me.txt_cantidad.Location = New System.Drawing.Point(616, 29)
        Me.txt_cantidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(47, 25)
        Me.txt_cantidad.TabIndex = 5
        Me.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_precio
        '
        Me.txt_precio.Enabled = False
        Me.txt_precio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio.ForeColor = System.Drawing.Color.Black
        Me.txt_precio.Location = New System.Drawing.Point(457, 28)
        Me.txt_precio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(70, 25)
        Me.txt_precio.TabIndex = 3
        Me.txt_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Producto (*)"
        '
        'dgv_detalle
        '
        Me.dgv_detalle.AllowUserToAddRows = False
        Me.dgv_detalle.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_detalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_detalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id_producto, Me.col_producto, Me.col_cantidad, Me.col_precio, Me.col_total, Me.stock_final})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_detalle.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_detalle.Location = New System.Drawing.Point(18, 61)
        Me.dgv_detalle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgv_detalle.Name = "dgv_detalle"
        Me.dgv_detalle.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_detalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_detalle.Size = New System.Drawing.Size(645, 123)
        Me.dgv_detalle.TabIndex = 6
        '
        'col_id_producto
        '
        Me.col_id_producto.HeaderText = "id_producto"
        Me.col_id_producto.Name = "col_id_producto"
        Me.col_id_producto.ReadOnly = True
        Me.col_id_producto.Visible = False
        '
        'col_producto
        '
        Me.col_producto.HeaderText = "Producto"
        Me.col_producto.Name = "col_producto"
        Me.col_producto.ReadOnly = True
        Me.col_producto.Width = 290
        '
        'col_cantidad
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_cantidad.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_cantidad.HeaderText = "Cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.ReadOnly = True
        Me.col_cantidad.Width = 85
        '
        'col_precio
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.NullValue = Nothing
        Me.col_precio.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_precio.HeaderText = "Precio Unit."
        Me.col_precio.Name = "col_precio"
        Me.col_precio.ReadOnly = True
        Me.col_precio.Width = 105
        '
        'col_total
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col_total.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_total.HeaderText = "Precio"
        Me.col_total.Name = "col_total"
        Me.col_total.ReadOnly = True
        Me.col_total.Width = 90
        '
        'stock_final
        '
        Me.stock_final.HeaderText = "stock_final"
        Me.stock_final.Name = "stock_final"
        Me.stock_final.ReadOnly = True
        Me.stock_final.Visible = False
        '
        'txt_idVENTA
        '
        Me.txt_idVENTA.Enabled = False
        Me.txt_idVENTA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idVENTA.ForeColor = System.Drawing.Color.Black
        Me.txt_idVENTA.Location = New System.Drawing.Point(94, 35)
        Me.txt_idVENTA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_idVENTA.Name = "txt_idVENTA"
        Me.txt_idVENTA.Size = New System.Drawing.Size(91, 25)
        Me.txt_idVENTA.TabIndex = 1
        Me.txt_idVENTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_hora
        '
        Me.txt_hora.Enabled = False
        Me.txt_hora.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hora.ForeColor = System.Drawing.Color.Black
        Me.txt_hora.Location = New System.Drawing.Point(373, 34)
        Me.txt_hora.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(82, 25)
        Me.txt_hora.TabIndex = 5
        Me.txt_hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_fecha
        '
        Me.txt_fecha.Enabled = False
        Me.txt_fecha.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha.ForeColor = System.Drawing.Color.Black
        Me.txt_fecha.Location = New System.Drawing.Point(238, 35)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(87, 25)
        Me.txt_fecha.TabIndex = 3
        Me.txt_fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_totalVENTA
        '
        Me.txt_totalVENTA.Enabled = False
        Me.txt_totalVENTA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalVENTA.ForeColor = System.Drawing.Color.Black
        Me.txt_totalVENTA.Location = New System.Drawing.Point(579, 430)
        Me.txt_totalVENTA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_totalVENTA.Name = "txt_totalVENTA"
        Me.txt_totalVENTA.Size = New System.Drawing.Size(105, 25)
        Me.txt_totalVENTA.TabIndex = 14
        Me.txt_totalVENTA.Text = "0"
        Me.txt_totalVENTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(191, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(487, 433)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Total a pagar"
        '
        'btn_cancelarVENTA
        '
        Me.btn_cancelarVENTA.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_cancelarVENTA.Enabled = False
        Me.btn_cancelarVENTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelarVENTA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelarVENTA.ForeColor = System.Drawing.Color.White
        Me.btn_cancelarVENTA.Image = Global.PAV1_TPI.My.Resources.Resources.cancel_button321
        Me.btn_cancelarVENTA.Location = New System.Drawing.Point(705, 7)
        Me.btn_cancelarVENTA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_cancelarVENTA.Name = "btn_cancelarVENTA"
        Me.btn_cancelarVENTA.Size = New System.Drawing.Size(40, 40)
        Me.btn_cancelarVENTA.TabIndex = 3
        Me.btn_cancelarVENTA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelarVENTA.UseVisualStyleBackColor = True
        '
        'btn_nuevaVENTA
        '
        Me.btn_nuevaVENTA.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_nuevaVENTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevaVENTA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevaVENTA.ForeColor = System.Drawing.Color.White
        Me.btn_nuevaVENTA.Image = Global.PAV1_TPI.My.Resources.Resources.plus_circular_button
        Me.btn_nuevaVENTA.Location = New System.Drawing.Point(618, 7)
        Me.btn_nuevaVENTA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_nuevaVENTA.Name = "btn_nuevaVENTA"
        Me.btn_nuevaVENTA.Size = New System.Drawing.Size(40, 40)
        Me.btn_nuevaVENTA.TabIndex = 1
        Me.btn_nuevaVENTA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevaVENTA.UseVisualStyleBackColor = True
        '
        'btn_guardarVENTA
        '
        Me.btn_guardarVENTA.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_guardarVENTA.Enabled = False
        Me.btn_guardarVENTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardarVENTA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardarVENTA.ForeColor = System.Drawing.Color.White
        Me.btn_guardarVENTA.Image = Global.PAV1_TPI.My.Resources.Resources.check_mark1
        Me.btn_guardarVENTA.Location = New System.Drawing.Point(662, 7)
        Me.btn_guardarVENTA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_guardarVENTA.Name = "btn_guardarVENTA"
        Me.btn_guardarVENTA.Size = New System.Drawing.Size(40, 40)
        Me.btn_guardarVENTA.TabIndex = 2
        Me.btn_guardarVENTA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardarVENTA.UseVisualStyleBackColor = True
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(757, 588)
        Me.Controls.Add(Me.btn_cancelarVENTA)
        Me.Controls.Add(Me.btn_nuevaVENTA)
        Me.Controls.Add(Me.btn_guardarVENTA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmb_producto As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dgv_detalle As DataGridView
    Friend WithEvents txt_idVENTA As TextBox
    Friend WithEvents txt_hora As TextBox
    Friend WithEvents txt_fecha As TextBox
    Friend WithEvents txt_totalVENTA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_subtotalVENTA As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmb_tipoDocCLIENTE As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_nroDocCLIENTE As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_nombreCLIENTE As TextBox
    Friend WithEvents btn_buscarCLIENTE As Button
    Friend WithEvents btn_eliminarDETALLE As Button
    Friend WithEvents btn_agregarDETALLE As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_usuarioLogueado As TextBox
    Friend WithEvents btn_aceptarDETALLE As Button
    Friend WithEvents chk_descuento As System.Windows.Forms.CheckBox
    Friend WithEvents txt_dtoVENTA As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelarVENTA As Button
    Friend WithEvents btn_nuevaVENTA As Button
    Friend WithEvents btn_guardarVENTA As Button
    Friend WithEvents btn_borrarCLIENTE As Button
    Friend WithEvents btn_formasPago As Button
    Friend WithEvents col_id_producto As DataGridViewTextBoxColumn
    Friend WithEvents col_producto As DataGridViewTextBoxColumn
    Friend WithEvents col_cantidad As DataGridViewTextBoxColumn
    Friend WithEvents col_precio As DataGridViewTextBoxColumn
    Friend WithEvents col_total As DataGridViewTextBoxColumn
    Friend WithEvents stock_final As DataGridViewTextBoxColumn
End Class

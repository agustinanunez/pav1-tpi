﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstadisticaFabrica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstadisticaFabrica))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_temporadas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_año = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.Location = New System.Drawing.Point(14, 66)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(742, 475)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Temporada"
        '
        'cmb_temporadas
        '
        Me.cmb_temporadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_temporadas.FormattingEnabled = True
        Me.cmb_temporadas.Items.AddRange(New Object() {"Otoño-Invierno", "Primavera-Verano"})
        Me.cmb_temporadas.Location = New System.Drawing.Point(93, 24)
        Me.cmb_temporadas.Name = "cmb_temporadas"
        Me.cmb_temporadas.Size = New System.Drawing.Size(121, 25)
        Me.cmb_temporadas.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Año"
        '
        'cmb_año
        '
        Me.cmb_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_año.FormattingEnabled = True
        Me.cmb_año.Items.AddRange(New Object() {"2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024"})
        Me.cmb_año.Location = New System.Drawing.Point(257, 24)
        Me.cmb_año.Name = "cmb_año"
        Me.cmb_año.Size = New System.Drawing.Size(121, 25)
        Me.cmb_año.TabIndex = 5
        '
        'EstadisticaFabrica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(782, 557)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_año)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_temporadas)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "EstadisticaFabrica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estadística de fábrica más vendida por temporada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_temporadas As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_año As ComboBox
End Class

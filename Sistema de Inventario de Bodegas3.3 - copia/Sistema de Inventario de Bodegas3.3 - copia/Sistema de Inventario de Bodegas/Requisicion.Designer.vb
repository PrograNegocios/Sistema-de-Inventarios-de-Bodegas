﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Requisicion
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
        Me.components = New System.ComponentModel.Container()
        Dim BuscarLabel As System.Windows.Forms.Label
        Dim IdRequisiciónLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim IdDepartamentoLabel As System.Windows.Forms.Label
        Dim ObservaciónLabel As System.Windows.Forms.Label
        Dim NombreProductoLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Requisicion))
        Me.Label_Inventario = New System.Windows.Forms.Label()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.BuscarTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBoxOpciones_p = New System.Windows.Forms.GroupBox()
        Me.Eliminar_Requisicion_Button = New System.Windows.Forms.Button()
        Me.Agregar_Button_Requisicion = New System.Windows.Forms.Button()
        Me.Salir_Button = New System.Windows.Forms.Button()
        Me.Guardar_Button_Requisicion = New System.Windows.Forms.Button()
        Me.RequisicionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Inv_Bodegas_DataSet = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSet()
        Me.InventarioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Cancelar_Operacion = New System.Windows.Forms.ToolStripButton()
        Me.RequisiciónTableAdapter = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.RequisiciónTableAdapter()
        Me.TableAdapterManager = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager()
        Me.InvBodegasDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventario_de_Bodega_UNICAHDataSet = New Sistema_de_Inventario_de_Bodegas.Inventario_de_Bodega_UNICAHDataSet()
        Me.SubdepartamentosselBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventario_de_Bodega_UNICAHDataSet3 = New Sistema_de_Inventario_de_Bodegas.Inventario_de_Bodega_UNICAHDataSet3()
        Me.SubNombreProductoselBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventario_de_Bodega_UNICAHDataSet1 = New Sistema_de_Inventario_de_Bodegas.Inventario_de_Bodega_UNICAHDataSet1()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.ProductoTableAdapter()
        Me.Sub_NombreProducto_selTableAdapter = New Sistema_de_Inventario_de_Bodegas.Inventario_de_Bodega_UNICAHDataSet1TableAdapters.sub_NombreProducto_selTableAdapter()
        Me.Inventario_de_Bodega_UNICAHDataSet2 = New Sistema_de_Inventario_de_Bodegas.Inventario_de_Bodega_UNICAHDataSet2()
        Me.Sub_departamentos_selTableAdapter = New Sistema_de_Inventario_de_Bodegas.Inventario_de_Bodega_UNICAHDataSet3TableAdapters.sub_departamentos_selTableAdapter()
        Me.IdRequisiciónTextBox = New System.Windows.Forms.TextBox()
        Me.RequisiciónDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdDepartamentoComboBox = New System.Windows.Forms.ComboBox()
        Me.ObservaciónTextBox = New System.Windows.Forms.TextBox()
        Me.NombreProductoComboBox = New System.Windows.Forms.ComboBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        BuscarLabel = New System.Windows.Forms.Label()
        IdRequisiciónLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        IdDepartamentoLabel = New System.Windows.Forms.Label()
        ObservaciónLabel = New System.Windows.Forms.Label()
        NombreProductoLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        Me.GroupBoxOpciones_p.SuspendLayout()
        CType(Me.RequisicionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventarioBindingNavigator.SuspendLayout()
        CType(Me.InvBodegasDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventario_de_Bodega_UNICAHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubdepartamentosselBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventario_de_Bodega_UNICAHDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubNombreProductoselBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventario_de_Bodega_UNICAHDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventario_de_Bodega_UNICAHDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisiciónDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuscarLabel
        '
        BuscarLabel.AutoSize = True
        BuscarLabel.Location = New System.Drawing.Point(12, 79)
        BuscarLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        BuscarLabel.Name = "BuscarLabel"
        BuscarLabel.Size = New System.Drawing.Size(43, 13)
        BuscarLabel.TabIndex = 80
        BuscarLabel.Text = "Buscar:"
        '
        'IdRequisiciónLabel
        '
        IdRequisiciónLabel.AutoSize = True
        IdRequisiciónLabel.Location = New System.Drawing.Point(15, 120)
        IdRequisiciónLabel.Name = "IdRequisiciónLabel"
        IdRequisiciónLabel.Size = New System.Drawing.Size(77, 13)
        IdRequisiciónLabel.TabIndex = 94
        IdRequisiciónLabel.Text = "Id Requisición:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(358, 124)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 95
        FechaLabel.Text = "Fecha:"
        '
        'IdDepartamentoLabel
        '
        IdDepartamentoLabel.AutoSize = True
        IdDepartamentoLabel.Location = New System.Drawing.Point(15, 151)
        IdDepartamentoLabel.Name = "IdDepartamentoLabel"
        IdDepartamentoLabel.Size = New System.Drawing.Size(89, 13)
        IdDepartamentoLabel.TabIndex = 96
        IdDepartamentoLabel.Text = "Id Departamento:"
        '
        'ObservaciónLabel
        '
        ObservaciónLabel.AutoSize = True
        ObservaciónLabel.Location = New System.Drawing.Point(359, 154)
        ObservaciónLabel.Name = "ObservaciónLabel"
        ObservaciónLabel.Size = New System.Drawing.Size(70, 13)
        ObservaciónLabel.TabIndex = 97
        ObservaciónLabel.Text = "Observación:"
        '
        'NombreProductoLabel
        '
        NombreProductoLabel.AutoSize = True
        NombreProductoLabel.Location = New System.Drawing.Point(13, 187)
        NombreProductoLabel.Name = "NombreProductoLabel"
        NombreProductoLabel.Size = New System.Drawing.Size(93, 13)
        NombreProductoLabel.TabIndex = 98
        NombreProductoLabel.Text = "Nombre Producto:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(362, 190)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 99
        CantidadLabel.Text = "Cantidad:"
        '
        'Label_Inventario
        '
        Me.Label_Inventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Inventario.Location = New System.Drawing.Point(0, 0)
        Me.Label_Inventario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Inventario.Name = "Label_Inventario"
        Me.Label_Inventario.Size = New System.Drawing.Size(669, 43)
        Me.Label_Inventario.TabIndex = 39
        Me.Label_Inventario.Text = "Requisición de Inventario"
        Me.Label_Inventario.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BuscarButton
        '
        Me.BuscarButton.BackgroundImage = Global.Sistema_de_Inventario_de_Bodegas.My.Resources.Resources._16__Search_
        Me.BuscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BuscarButton.Location = New System.Drawing.Point(225, 78)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(28, 23)
        Me.BuscarButton.TabIndex = 82
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'BuscarTextBox
        '
        Me.BuscarTextBox.Location = New System.Drawing.Point(111, 79)
        Me.BuscarTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.BuscarTextBox.Multiline = True
        Me.BuscarTextBox.Name = "BuscarTextBox"
        Me.BuscarTextBox.Size = New System.Drawing.Size(142, 21)
        Me.BuscarTextBox.TabIndex = 81
        '
        'GroupBoxOpciones_p
        '
        Me.GroupBoxOpciones_p.Controls.Add(Me.Eliminar_Requisicion_Button)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Agregar_Button_Requisicion)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Salir_Button)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Guardar_Button_Requisicion)
        Me.GroupBoxOpciones_p.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxOpciones_p.Location = New System.Drawing.Point(15, 428)
        Me.GroupBoxOpciones_p.Name = "GroupBoxOpciones_p"
        Me.GroupBoxOpciones_p.Size = New System.Drawing.Size(561, 83)
        Me.GroupBoxOpciones_p.TabIndex = 84
        Me.GroupBoxOpciones_p.TabStop = False
        Me.GroupBoxOpciones_p.Text = "Opciones"
        '
        'Eliminar_Requisicion_Button
        '
        Me.Eliminar_Requisicion_Button.BackColor = System.Drawing.Color.PowderBlue
        Me.Eliminar_Requisicion_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar_Requisicion_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Eliminar_Requisicion_Button.ImageKey = "(ninguno)"
        Me.Eliminar_Requisicion_Button.Location = New System.Drawing.Point(297, 25)
        Me.Eliminar_Requisicion_Button.Name = "Eliminar_Requisicion_Button"
        Me.Eliminar_Requisicion_Button.Size = New System.Drawing.Size(136, 47)
        Me.Eliminar_Requisicion_Button.TabIndex = 36
        Me.Eliminar_Requisicion_Button.Text = "Eliminar"
        Me.Eliminar_Requisicion_Button.UseVisualStyleBackColor = False
        '
        'Agregar_Button_Requisicion
        '
        Me.Agregar_Button_Requisicion.BackColor = System.Drawing.Color.PowderBlue
        Me.Agregar_Button_Requisicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar_Button_Requisicion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Agregar_Button_Requisicion.ImageKey = "(ninguno)"
        Me.Agregar_Button_Requisicion.Location = New System.Drawing.Point(155, 25)
        Me.Agregar_Button_Requisicion.Name = "Agregar_Button_Requisicion"
        Me.Agregar_Button_Requisicion.Size = New System.Drawing.Size(136, 47)
        Me.Agregar_Button_Requisicion.TabIndex = 35
        Me.Agregar_Button_Requisicion.Text = "Agregar"
        Me.Agregar_Button_Requisicion.UseVisualStyleBackColor = False
        '
        'Salir_Button
        '
        Me.Salir_Button.BackColor = System.Drawing.Color.PowderBlue
        Me.Salir_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salir_Button.ImageKey = "16 (Exit).ico"
        Me.Salir_Button.Location = New System.Drawing.Point(436, 25)
        Me.Salir_Button.Name = "Salir_Button"
        Me.Salir_Button.Size = New System.Drawing.Size(119, 47)
        Me.Salir_Button.TabIndex = 24
        Me.Salir_Button.Text = "Salir"
        Me.Salir_Button.UseVisualStyleBackColor = False
        '
        'Guardar_Button_Requisicion
        '
        Me.Guardar_Button_Requisicion.BackColor = System.Drawing.Color.PowderBlue
        Me.Guardar_Button_Requisicion.Enabled = False
        Me.Guardar_Button_Requisicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar_Button_Requisicion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Guardar_Button_Requisicion.ImageKey = "(ninguno)"
        Me.Guardar_Button_Requisicion.Location = New System.Drawing.Point(13, 25)
        Me.Guardar_Button_Requisicion.Name = "Guardar_Button_Requisicion"
        Me.Guardar_Button_Requisicion.Size = New System.Drawing.Size(136, 47)
        Me.Guardar_Button_Requisicion.TabIndex = 34
        Me.Guardar_Button_Requisicion.Text = "Guardar"
        Me.Guardar_Button_Requisicion.UseVisualStyleBackColor = False
        '
        'RequisicionBindingSource
        '
        Me.RequisicionBindingSource.DataMember = "Requisición"
        Me.RequisicionBindingSource.DataSource = Me._Inv_Bodegas_DataSet
        '
        '_Inv_Bodegas_DataSet
        '
        Me._Inv_Bodegas_DataSet.DataSetName = "Inv-Bodegas_DataSet"
        Me._Inv_Bodegas_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventarioBindingNavigator
        '
        Me.InventarioBindingNavigator.AddNewItem = Nothing
        Me.InventarioBindingNavigator.BackColor = System.Drawing.Color.PowderBlue
        Me.InventarioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InventarioBindingNavigator.DeleteItem = Nothing
        Me.InventarioBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.InventarioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.Cancelar_Operacion})
        Me.InventarioBindingNavigator.Location = New System.Drawing.Point(0, 43)
        Me.InventarioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InventarioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InventarioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InventarioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InventarioBindingNavigator.Name = "InventarioBindingNavigator"
        Me.InventarioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InventarioBindingNavigator.Size = New System.Drawing.Size(669, 27)
        Me.InventarioBindingNavigator.TabIndex = 86
        Me.InventarioBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Cancelar_Operacion
        '
        Me.Cancelar_Operacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cancelar_Operacion.Image = CType(resources.GetObject("Cancelar_Operacion.Image"), System.Drawing.Image)
        Me.Cancelar_Operacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cancelar_Operacion.Name = "Cancelar_Operacion"
        Me.Cancelar_Operacion.Size = New System.Drawing.Size(24, 24)
        Me.Cancelar_Operacion.Text = "Cancelar"
        Me.Cancelar_Operacion.Visible = False
        '
        'RequisiciónTableAdapter
        '
        Me.RequisiciónTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BodegaTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_SalidasTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.RequisiciónTableAdapter = Me.RequisiciónTableAdapter
        Me.TableAdapterManager.SalidasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InvBodegasDataSetBindingSource
        '
        Me.InvBodegasDataSetBindingSource.DataSource = Me._Inv_Bodegas_DataSet
        Me.InvBodegasDataSetBindingSource.Position = 0
        '
        'Inventario_de_Bodega_UNICAHDataSet
        '
        Me.Inventario_de_Bodega_UNICAHDataSet.DataSetName = "Inventario_de_Bodega_UNICAHDataSet"
        Me.Inventario_de_Bodega_UNICAHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubdepartamentosselBindingSource
        '
        Me.SubdepartamentosselBindingSource.DataMember = "sub_departamentos_sel"
        Me.SubdepartamentosselBindingSource.DataSource = Me.Inventario_de_Bodega_UNICAHDataSet3
        '
        'Inventario_de_Bodega_UNICAHDataSet3
        '
        Me.Inventario_de_Bodega_UNICAHDataSet3.DataSetName = "Inventario_de_Bodega_UNICAHDataSet3"
        Me.Inventario_de_Bodega_UNICAHDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubNombreProductoselBindingSource
        '
        Me.SubNombreProductoselBindingSource.DataMember = "sub_NombreProducto_sel"
        Me.SubNombreProductoselBindingSource.DataSource = Me.Inventario_de_Bodega_UNICAHDataSet1
        '
        'Inventario_de_Bodega_UNICAHDataSet1
        '
        Me.Inventario_de_Bodega_UNICAHDataSet1.DataSetName = "Inventario_de_Bodega_UNICAHDataSet1"
        Me.Inventario_de_Bodega_UNICAHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.InvBodegasDataSetBindingSource
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'Sub_NombreProducto_selTableAdapter
        '
        Me.Sub_NombreProducto_selTableAdapter.ClearBeforeFill = True
        '
        'Inventario_de_Bodega_UNICAHDataSet2
        '
        Me.Inventario_de_Bodega_UNICAHDataSet2.DataSetName = "Inventario_de_Bodega_UNICAHDataSet2"
        Me.Inventario_de_Bodega_UNICAHDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sub_departamentos_selTableAdapter
        '
        Me.Sub_departamentos_selTableAdapter.ClearBeforeFill = True
        '
        'IdRequisiciónTextBox
        '
        Me.IdRequisiciónTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequisicionBindingSource, "IdRequisición", True))
        Me.IdRequisiciónTextBox.Enabled = False
        Me.IdRequisiciónTextBox.Location = New System.Drawing.Point(112, 117)
        Me.IdRequisiciónTextBox.Name = "IdRequisiciónTextBox"
        Me.IdRequisiciónTextBox.ReadOnly = True
        Me.IdRequisiciónTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdRequisiciónTextBox.TabIndex = 95
        '
        'RequisiciónDataGridView
        '
        Me.RequisiciónDataGridView.AutoGenerateColumns = False
        Me.RequisiciónDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RequisiciónDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.RequisiciónDataGridView.DataSource = Me.RequisicionBindingSource
        Me.RequisiciónDataGridView.Location = New System.Drawing.Point(15, 227)
        Me.RequisiciónDataGridView.Name = "RequisiciónDataGridView"
        Me.RequisiciónDataGridView.Size = New System.Drawing.Size(608, 195)
        Me.RequisiciónDataGridView.TabIndex = 95
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdRequisición"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdRequisición"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdDepartamento"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdDepartamento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Observación"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Observación"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NombreProducto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NombreProducto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.Checked = False
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RequisicionBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Enabled = False
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(404, 120)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(208, 20)
        Me.FechaDateTimePicker.TabIndex = 96
        '
        'IdDepartamentoComboBox
        '
        Me.IdDepartamentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequisicionBindingSource, "IdDepartamento", True))
        Me.IdDepartamentoComboBox.DataSource = Me.SubdepartamentosselBindingSource
        Me.IdDepartamentoComboBox.DisplayMember = "IdDepartamento"
        Me.IdDepartamentoComboBox.Enabled = False
        Me.IdDepartamentoComboBox.FormattingEnabled = True
        Me.IdDepartamentoComboBox.Location = New System.Drawing.Point(112, 148)
        Me.IdDepartamentoComboBox.Name = "IdDepartamentoComboBox"
        Me.IdDepartamentoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.IdDepartamentoComboBox.TabIndex = 97
        '
        'ObservaciónTextBox
        '
        Me.ObservaciónTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequisicionBindingSource, "Observación", True))
        Me.ObservaciónTextBox.Enabled = False
        Me.ObservaciónTextBox.Location = New System.Drawing.Point(435, 151)
        Me.ObservaciónTextBox.Name = "ObservaciónTextBox"
        Me.ObservaciónTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ObservaciónTextBox.TabIndex = 98
        '
        'NombreProductoComboBox
        '
        Me.NombreProductoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequisicionBindingSource, "NombreProducto", True))
        Me.NombreProductoComboBox.DataSource = Me.SubNombreProductoselBindingSource
        Me.NombreProductoComboBox.DisplayMember = "Nombre"
        Me.NombreProductoComboBox.Enabled = False
        Me.NombreProductoComboBox.FormattingEnabled = True
        Me.NombreProductoComboBox.Location = New System.Drawing.Point(112, 184)
        Me.NombreProductoComboBox.Name = "NombreProductoComboBox"
        Me.NombreProductoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NombreProductoComboBox.TabIndex = 99
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequisicionBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Enabled = False
        Me.CantidadTextBox.Location = New System.Drawing.Point(435, 187)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CantidadTextBox.TabIndex = 100
        '
        'Requisicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(669, 560)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(NombreProductoLabel)
        Me.Controls.Add(Me.NombreProductoComboBox)
        Me.Controls.Add(ObservaciónLabel)
        Me.Controls.Add(Me.ObservaciónTextBox)
        Me.Controls.Add(IdDepartamentoLabel)
        Me.Controls.Add(Me.IdDepartamentoComboBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.RequisiciónDataGridView)
        Me.Controls.Add(IdRequisiciónLabel)
        Me.Controls.Add(Me.IdRequisiciónTextBox)
        Me.Controls.Add(Me.InventarioBindingNavigator)
        Me.Controls.Add(Me.GroupBoxOpciones_p)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(BuscarLabel)
        Me.Controls.Add(Me.BuscarTextBox)
        Me.Controls.Add(Me.Label_Inventario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Requisicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requisicion"
        Me.GroupBoxOpciones_p.ResumeLayout(False)
        CType(Me.RequisicionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventarioBindingNavigator.ResumeLayout(False)
        Me.InventarioBindingNavigator.PerformLayout()
        CType(Me.InvBodegasDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventario_de_Bodega_UNICAHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubdepartamentosselBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventario_de_Bodega_UNICAHDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubNombreProductoselBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventario_de_Bodega_UNICAHDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventario_de_Bodega_UNICAHDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisiciónDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Inventario As Label
    Friend WithEvents BuscarButton As Button
    Friend WithEvents BuscarTextBox As TextBox
    Friend WithEvents GroupBoxOpciones_p As GroupBox
    Friend WithEvents Eliminar_Requisicion_Button As Button
    Friend WithEvents Agregar_Button_Requisicion As Button
    Friend WithEvents Salir_Button As Button
    Friend WithEvents Guardar_Button_Requisicion As Button
    Friend WithEvents _Inv_Bodegas_DataSet As _Inv_Bodegas_DataSet
    Friend WithEvents RequisicionBindingSource As BindingSource
    Friend WithEvents RequisiciónTableAdapter As _Inv_Bodegas_DataSetTableAdapters.RequisiciónTableAdapter
    Friend WithEvents TableAdapterManager As _Inv_Bodegas_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents InventarioBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Cancelar_Operacion As ToolStripButton
    Friend WithEvents InvBodegasDataSetBindingSource As BindingSource
    Friend WithEvents Inventario_de_Bodega_UNICAHDataSet As Inventario_de_Bodega_UNICAHDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As _Inv_Bodegas_DataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents Inventario_de_Bodega_UNICAHDataSet1 As Inventario_de_Bodega_UNICAHDataSet1
    Friend WithEvents SubNombreProductoselBindingSource As BindingSource
    Friend WithEvents Sub_NombreProducto_selTableAdapter As Inventario_de_Bodega_UNICAHDataSet1TableAdapters.sub_NombreProducto_selTableAdapter
    Friend WithEvents Inventario_de_Bodega_UNICAHDataSet2 As Inventario_de_Bodega_UNICAHDataSet2
    Friend WithEvents Inventario_de_Bodega_UNICAHDataSet3 As Inventario_de_Bodega_UNICAHDataSet3
    Friend WithEvents SubdepartamentosselBindingSource As BindingSource
    Friend WithEvents Sub_departamentos_selTableAdapter As Inventario_de_Bodega_UNICAHDataSet3TableAdapters.sub_departamentos_selTableAdapter
    Friend WithEvents IdRequisiciónTextBox As TextBox
    Friend WithEvents RequisiciónDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents IdDepartamentoComboBox As ComboBox
    Friend WithEvents ObservaciónTextBox As TextBox
    Friend WithEvents NombreProductoComboBox As ComboBox
    Friend WithEvents CantidadTextBox As TextBox
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetalleSalida_Form
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
        Dim BuscarLabel As System.Windows.Forms.Label
        Dim IdInventarioLabel As System.Windows.Forms.Label
        Dim IdSalidasLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetalleSalida_Form))
        Me.Label_Inventario = New System.Windows.Forms.Label()
        Me.InventarioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Detalle_SalidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Inv_Bodegas_DataSet = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSet()
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
        Me.GroupBoxOpciones_p = New System.Windows.Forms.GroupBox()
        Me.Eliminar_Button_DetalleSalida = New System.Windows.Forms.Button()
        Me.Agregar_Button_DetalleSalida = New System.Windows.Forms.Button()
        Me.Salir_Button = New System.Windows.Forms.Button()
        Me.Guardar_Button_DetalleSalida = New System.Windows.Forms.Button()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.BuscarTextBox = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager()
        Me.Detalle_SalidasTableAdapter = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.Detalle_SalidasTableAdapter()
        Me.IdInventarioComboBox = New System.Windows.Forms.ComboBox()
        Me.SubinventarioselBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventario_de_Bodega_UNICAHDataSet4 = New Sistema_de_Inventario_de_Bodegas.Inventario_de_Bodega_UNICAHDataSet4()
        Me.IdSalidasComboBox = New System.Windows.Forms.ComboBox()
        Me.SubSalidasselBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventario_de_Bodega_UNICAHDataSet5 = New Sistema_de_Inventario_de_Bodegas.Inventario_de_Bodega_UNICAHDataSet5()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.Detalle_SalidasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sub_inventario_selTableAdapter = New Sistema_de_Inventario_de_Bodegas.Inventario_de_Bodega_UNICAHDataSet4TableAdapters.sub_inventario_selTableAdapter()
        Me.Sub_Salidas_selTableAdapter = New Sistema_de_Inventario_de_Bodegas.Inventario_de_Bodega_UNICAHDataSet5TableAdapters.sub_Salidas_selTableAdapter()
        Me.InvBodegasDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventario_de_Bodega_UNICAHDataSet = New Sistema_de_Inventario_de_Bodegas.Inventario_de_Bodega_UNICAHDataSet()
        BuscarLabel = New System.Windows.Forms.Label()
        IdInventarioLabel = New System.Windows.Forms.Label()
        IdSalidasLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventarioBindingNavigator.SuspendLayout()
        CType(Me.Detalle_SalidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxOpciones_p.SuspendLayout()
        CType(Me.SubinventarioselBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventario_de_Bodega_UNICAHDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubSalidasselBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventario_de_Bodega_UNICAHDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalle_SalidasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvBodegasDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventario_de_Bodega_UNICAHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuscarLabel
        '
        BuscarLabel.AutoSize = True
        BuscarLabel.Location = New System.Drawing.Point(72, 98)
        BuscarLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        BuscarLabel.Name = "BuscarLabel"
        BuscarLabel.Size = New System.Drawing.Size(43, 13)
        BuscarLabel.TabIndex = 98
        BuscarLabel.Text = "Buscar:"
        '
        'IdInventarioLabel
        '
        IdInventarioLabel.AutoSize = True
        IdInventarioLabel.Location = New System.Drawing.Point(72, 133)
        IdInventarioLabel.Name = "IdInventarioLabel"
        IdInventarioLabel.Size = New System.Drawing.Size(69, 13)
        IdInventarioLabel.TabIndex = 100
        IdInventarioLabel.Text = "Id Inventario:"
        '
        'IdSalidasLabel
        '
        IdSalidasLabel.AutoSize = True
        IdSalidasLabel.Location = New System.Drawing.Point(72, 170)
        IdSalidasLabel.Name = "IdSalidasLabel"
        IdSalidasLabel.Size = New System.Drawing.Size(56, 13)
        IdSalidasLabel.TabIndex = 101
        IdSalidasLabel.Text = "Id Salidas:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(76, 207)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 102
        CantidadLabel.Text = "Cantidad:"
        '
        'Label_Inventario
        '
        Me.Label_Inventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Inventario.Location = New System.Drawing.Point(0, 0)
        Me.Label_Inventario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Inventario.Name = "Label_Inventario"
        Me.Label_Inventario.Size = New System.Drawing.Size(478, 43)
        Me.Label_Inventario.TabIndex = 40
        Me.Label_Inventario.Text = "Detalle Salidas"
        Me.Label_Inventario.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'InventarioBindingNavigator
        '
        Me.InventarioBindingNavigator.AddNewItem = Nothing
        Me.InventarioBindingNavigator.BackColor = System.Drawing.Color.PowderBlue
        Me.InventarioBindingNavigator.BindingSource = Me.Detalle_SalidasBindingSource
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
        Me.InventarioBindingNavigator.Size = New System.Drawing.Size(478, 27)
        Me.InventarioBindingNavigator.TabIndex = 87
        Me.InventarioBindingNavigator.Text = "BindingNavigator1"
        '
        'Detalle_SalidasBindingSource
        '
        Me.Detalle_SalidasBindingSource.DataMember = "Detalle Salidas"
        Me.Detalle_SalidasBindingSource.DataSource = Me._Inv_Bodegas_DataSet
        '
        '_Inv_Bodegas_DataSet
        '
        Me._Inv_Bodegas_DataSet.DataSetName = "Inv-Bodegas_DataSet"
        Me._Inv_Bodegas_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Cancelar_Operacion.ToolTipText = "Cancelar"
        Me.Cancelar_Operacion.Visible = False
        '
        'GroupBoxOpciones_p
        '
        Me.GroupBoxOpciones_p.Controls.Add(Me.Eliminar_Button_DetalleSalida)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Agregar_Button_DetalleSalida)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Salir_Button)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Guardar_Button_DetalleSalida)
        Me.GroupBoxOpciones_p.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxOpciones_p.Location = New System.Drawing.Point(29, 437)
        Me.GroupBoxOpciones_p.Name = "GroupBoxOpciones_p"
        Me.GroupBoxOpciones_p.Size = New System.Drawing.Size(427, 83)
        Me.GroupBoxOpciones_p.TabIndex = 97
        Me.GroupBoxOpciones_p.TabStop = False
        Me.GroupBoxOpciones_p.Text = "Opciones"
        '
        'Eliminar_Button_DetalleSalida
        '
        Me.Eliminar_Button_DetalleSalida.BackColor = System.Drawing.Color.PowderBlue
        Me.Eliminar_Button_DetalleSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar_Button_DetalleSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Eliminar_Button_DetalleSalida.ImageKey = "(ninguno)"
        Me.Eliminar_Button_DetalleSalida.Location = New System.Drawing.Point(226, 25)
        Me.Eliminar_Button_DetalleSalida.Name = "Eliminar_Button_DetalleSalida"
        Me.Eliminar_Button_DetalleSalida.Size = New System.Drawing.Size(98, 47)
        Me.Eliminar_Button_DetalleSalida.TabIndex = 36
        Me.Eliminar_Button_DetalleSalida.Text = "Eliminar"
        Me.Eliminar_Button_DetalleSalida.UseVisualStyleBackColor = False
        '
        'Agregar_Button_DetalleSalida
        '
        Me.Agregar_Button_DetalleSalida.BackColor = System.Drawing.Color.PowderBlue
        Me.Agregar_Button_DetalleSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar_Button_DetalleSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Agregar_Button_DetalleSalida.ImageKey = "(ninguno)"
        Me.Agregar_Button_DetalleSalida.Location = New System.Drawing.Point(118, 25)
        Me.Agregar_Button_DetalleSalida.Name = "Agregar_Button_DetalleSalida"
        Me.Agregar_Button_DetalleSalida.Size = New System.Drawing.Size(102, 47)
        Me.Agregar_Button_DetalleSalida.TabIndex = 35
        Me.Agregar_Button_DetalleSalida.Text = "Agregar"
        Me.Agregar_Button_DetalleSalida.UseVisualStyleBackColor = False
        '
        'Salir_Button
        '
        Me.Salir_Button.BackColor = System.Drawing.Color.PowderBlue
        Me.Salir_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salir_Button.ImageKey = "16 (Exit).ico"
        Me.Salir_Button.Location = New System.Drawing.Point(330, 25)
        Me.Salir_Button.Name = "Salir_Button"
        Me.Salir_Button.Size = New System.Drawing.Size(78, 47)
        Me.Salir_Button.TabIndex = 24
        Me.Salir_Button.Text = "Salir"
        Me.Salir_Button.UseVisualStyleBackColor = False
        '
        'Guardar_Button_DetalleSalida
        '
        Me.Guardar_Button_DetalleSalida.BackColor = System.Drawing.Color.PowderBlue
        Me.Guardar_Button_DetalleSalida.Enabled = False
        Me.Guardar_Button_DetalleSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar_Button_DetalleSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Guardar_Button_DetalleSalida.ImageKey = "(ninguno)"
        Me.Guardar_Button_DetalleSalida.Location = New System.Drawing.Point(13, 25)
        Me.Guardar_Button_DetalleSalida.Name = "Guardar_Button_DetalleSalida"
        Me.Guardar_Button_DetalleSalida.Size = New System.Drawing.Size(99, 47)
        Me.Guardar_Button_DetalleSalida.TabIndex = 34
        Me.Guardar_Button_DetalleSalida.Text = "Guardar"
        Me.Guardar_Button_DetalleSalida.UseVisualStyleBackColor = False
        '
        'BuscarButton
        '
        Me.BuscarButton.BackgroundImage = Global.Sistema_de_Inventario_de_Bodegas.My.Resources.Resources._16__Search_
        Me.BuscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BuscarButton.Location = New System.Drawing.Point(261, 97)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(28, 23)
        Me.BuscarButton.TabIndex = 100
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'BuscarTextBox
        '
        Me.BuscarTextBox.Location = New System.Drawing.Point(147, 98)
        Me.BuscarTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.BuscarTextBox.Multiline = True
        Me.BuscarTextBox.Name = "BuscarTextBox"
        Me.BuscarTextBox.Size = New System.Drawing.Size(142, 21)
        Me.BuscarTextBox.TabIndex = 99
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BodegaTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_EntradasTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_SalidasTableAdapter = Me.Detalle_SalidasTableAdapter
        Me.TableAdapterManager.EntradasTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.RequisiciónTableAdapter = Nothing
        Me.TableAdapterManager.SalidasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Detalle_SalidasTableAdapter
        '
        Me.Detalle_SalidasTableAdapter.ClearBeforeFill = True
        '
        'IdInventarioComboBox
        '
        Me.IdInventarioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_SalidasBindingSource, "IdInventario", True))
        Me.IdInventarioComboBox.DataSource = Me.SubinventarioselBindingSource
        Me.IdInventarioComboBox.DisplayMember = "IdInventario"
        Me.IdInventarioComboBox.Enabled = False
        Me.IdInventarioComboBox.FormattingEnabled = True
        Me.IdInventarioComboBox.Location = New System.Drawing.Point(147, 130)
        Me.IdInventarioComboBox.Name = "IdInventarioComboBox"
        Me.IdInventarioComboBox.Size = New System.Drawing.Size(121, 21)
        Me.IdInventarioComboBox.TabIndex = 101
        '
        'SubinventarioselBindingSource
        '
        Me.SubinventarioselBindingSource.DataMember = "sub_inventario_sel"
        Me.SubinventarioselBindingSource.DataSource = Me.Inventario_de_Bodega_UNICAHDataSet4
        '
        'Inventario_de_Bodega_UNICAHDataSet4
        '
        Me.Inventario_de_Bodega_UNICAHDataSet4.DataSetName = "Inventario_de_Bodega_UNICAHDataSet4"
        Me.Inventario_de_Bodega_UNICAHDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdSalidasComboBox
        '
        Me.IdSalidasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_SalidasBindingSource, "IdSalidas", True))
        Me.IdSalidasComboBox.DataSource = Me.SubSalidasselBindingSource
        Me.IdSalidasComboBox.DisplayMember = "IdSalidas"
        Me.IdSalidasComboBox.Enabled = False
        Me.IdSalidasComboBox.FormattingEnabled = True
        Me.IdSalidasComboBox.Location = New System.Drawing.Point(148, 167)
        Me.IdSalidasComboBox.Name = "IdSalidasComboBox"
        Me.IdSalidasComboBox.Size = New System.Drawing.Size(121, 21)
        Me.IdSalidasComboBox.TabIndex = 102
        '
        'SubSalidasselBindingSource
        '
        Me.SubSalidasselBindingSource.DataMember = "sub_Salidas_sel"
        Me.SubSalidasselBindingSource.DataSource = Me.Inventario_de_Bodega_UNICAHDataSet5
        '
        'Inventario_de_Bodega_UNICAHDataSet5
        '
        Me.Inventario_de_Bodega_UNICAHDataSet5.DataSetName = "Inventario_de_Bodega_UNICAHDataSet5"
        Me.Inventario_de_Bodega_UNICAHDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_SalidasBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Enabled = False
        Me.CantidadTextBox.Location = New System.Drawing.Point(148, 204)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CantidadTextBox.TabIndex = 103
        '
        'Detalle_SalidasDataGridView
        '
        Me.Detalle_SalidasDataGridView.AutoGenerateColumns = False
        Me.Detalle_SalidasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Detalle_SalidasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Detalle_SalidasDataGridView.DataSource = Me.Detalle_SalidasBindingSource
        Me.Detalle_SalidasDataGridView.Location = New System.Drawing.Point(47, 230)
        Me.Detalle_SalidasDataGridView.Name = "Detalle_SalidasDataGridView"
        Me.Detalle_SalidasDataGridView.Size = New System.Drawing.Size(342, 191)
        Me.Detalle_SalidasDataGridView.TabIndex = 103
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdInventario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdInventario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdSalidas"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdSalidas"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Sub_inventario_selTableAdapter
        '
        Me.Sub_inventario_selTableAdapter.ClearBeforeFill = True
        '
        'Sub_Salidas_selTableAdapter
        '
        Me.Sub_Salidas_selTableAdapter.ClearBeforeFill = True
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
        'DetalleSalida_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(478, 528)
        Me.Controls.Add(Me.Detalle_SalidasDataGridView)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(IdSalidasLabel)
        Me.Controls.Add(Me.IdSalidasComboBox)
        Me.Controls.Add(IdInventarioLabel)
        Me.Controls.Add(Me.IdInventarioComboBox)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(BuscarLabel)
        Me.Controls.Add(Me.BuscarTextBox)
        Me.Controls.Add(Me.GroupBoxOpciones_p)
        Me.Controls.Add(Me.InventarioBindingNavigator)
        Me.Controls.Add(Me.Label_Inventario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DetalleSalida_Form"
        Me.Text = "DetalleSalida_Form"
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventarioBindingNavigator.ResumeLayout(False)
        Me.InventarioBindingNavigator.PerformLayout()
        CType(Me.Detalle_SalidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxOpciones_p.ResumeLayout(False)
        CType(Me.SubinventarioselBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventario_de_Bodega_UNICAHDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubSalidasselBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventario_de_Bodega_UNICAHDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalle_SalidasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvBodegasDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventario_de_Bodega_UNICAHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Inventario As Label
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
    Friend WithEvents GroupBoxOpciones_p As GroupBox
    Friend WithEvents Eliminar_Button_DetalleSalida As Button
    Friend WithEvents Agregar_Button_DetalleSalida As Button
    Friend WithEvents Salir_Button As Button
    Friend WithEvents Guardar_Button_DetalleSalida As Button
    Friend WithEvents BuscarButton As Button
    Friend WithEvents BuscarTextBox As TextBox
    Friend WithEvents _Inv_Bodegas_DataSet As _Inv_Bodegas_DataSet
    Friend WithEvents Detalle_SalidasBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As _Inv_Bodegas_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdInventarioComboBox As ComboBox
    Friend WithEvents IdSalidasComboBox As ComboBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents Detalle_SalidasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Inventario_de_Bodega_UNICAHDataSet4 As Inventario_de_Bodega_UNICAHDataSet4
    Friend WithEvents SubinventarioselBindingSource As BindingSource
    Friend WithEvents Sub_inventario_selTableAdapter As Inventario_de_Bodega_UNICAHDataSet4TableAdapters.sub_inventario_selTableAdapter
    Friend WithEvents Inventario_de_Bodega_UNICAHDataSet5 As Inventario_de_Bodega_UNICAHDataSet5
    Friend WithEvents SubSalidasselBindingSource As BindingSource
    Friend WithEvents Sub_Salidas_selTableAdapter As Inventario_de_Bodega_UNICAHDataSet5TableAdapters.sub_Salidas_selTableAdapter
    Friend WithEvents InvBodegasDataSetBindingSource As BindingSource
    Friend WithEvents Inventario_de_Bodega_UNICAHDataSet As Inventario_de_Bodega_UNICAHDataSet
    Friend WithEvents Detalle_SalidasTableAdapter As _Inv_Bodegas_DataSetTableAdapters.Detalle_SalidasTableAdapter
End Class

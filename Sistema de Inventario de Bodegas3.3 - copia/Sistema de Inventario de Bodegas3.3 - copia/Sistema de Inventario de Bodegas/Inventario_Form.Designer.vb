<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventario_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdInventarioLabel As System.Windows.Forms.Label
        Dim IdBodegaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario_Form))
        Me._Inv_Bodegas_DataSet = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSet()
        Me.InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioTableAdapter = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.InventarioTableAdapter()
        Me.TableAdapterManager = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager()
        Me.Opciones_Label = New System.Windows.Forms.Label()
        Me.Salir_Button_inventario = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_Inventario = New System.Windows.Forms.Label()
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
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.ProductoTableAdapter()
        Me.BodegaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BodegaTableAdapter = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.BodegaTableAdapter()
        Me.InventarioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.IdInventarioComboBox = New System.Windows.Forms.ComboBox()
        Me.SubinventarioselBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventario_de_Bodega_UNICAHDataSet6 = New Sistema_de_Inventario_de_Bodegas.Inventario_de_Bodega_UNICAHDataSet6()
        Me.Sub_inventario_selTableAdapter1 = New Sistema_de_Inventario_de_Bodegas.Inventario_de_Bodega_UNICAHDataSet4TableAdapters.sub_inventario_selTableAdapter()
        Me.Sub_inventario_selTableAdapter = New Sistema_de_Inventario_de_Bodegas.Inventario_de_Bodega_UNICAHDataSet6TableAdapters.sub_inventario_selTableAdapter()
        Me.IdBodegaComboBox = New System.Windows.Forms.ComboBox()
        Me.SubfiltrobodegaselBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventario_de_Bodega_UNICAHDataSet8 = New Sistema_de_Inventario_de_Bodegas.Inventario_de_Bodega_UNICAHDataSet8()
        Me.FiltroBodega = New System.Windows.Forms.Button()
        Me.Sub_filtrobodega_selTableAdapter = New Sistema_de_Inventario_de_Bodegas.Inventario_de_Bodega_UNICAHDataSet8TableAdapters.sub_filtrobodega_selTableAdapter()
        IdInventarioLabel = New System.Windows.Forms.Label()
        IdBodegaLabel = New System.Windows.Forms.Label()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventarioBindingNavigator.SuspendLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BodegaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubinventarioselBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventario_de_Bodega_UNICAHDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubfiltrobodegaselBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventario_de_Bodega_UNICAHDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdInventarioLabel
        '
        IdInventarioLabel.AutoSize = True
        IdInventarioLabel.Location = New System.Drawing.Point(17, 96)
        IdInventarioLabel.Name = "IdInventarioLabel"
        IdInventarioLabel.Size = New System.Drawing.Size(69, 13)
        IdInventarioLabel.TabIndex = 85
        IdInventarioLabel.Text = "Id Inventario:"
        '
        'IdBodegaLabel
        '
        IdBodegaLabel.AutoSize = True
        IdBodegaLabel.Location = New System.Drawing.Point(312, 99)
        IdBodegaLabel.Name = "IdBodegaLabel"
        IdBodegaLabel.Size = New System.Drawing.Size(59, 13)
        IdBodegaLabel.TabIndex = 86
        IdBodegaLabel.Text = "Id Bodega:"
        '
        '_Inv_Bodegas_DataSet
        '
        Me._Inv_Bodegas_DataSet.DataSetName = "Inv-Bodegas_DataSet"
        Me._Inv_Bodegas_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventarioBindingSource
        '
        Me.InventarioBindingSource.DataMember = "Inventario"
        Me.InventarioBindingSource.DataSource = Me._Inv_Bodegas_DataSet
        '
        'InventarioTableAdapter
        '
        Me.InventarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BodegaTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_EntradasTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_SalidasTableAdapter = Nothing
        Me.TableAdapterManager.EntradasTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Me.InventarioTableAdapter
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.RequisiciónTableAdapter = Nothing
        Me.TableAdapterManager.SalidasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Opciones_Label
        '
        Me.Opciones_Label.AutoSize = True
        Me.Opciones_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opciones_Label.Location = New System.Drawing.Point(10, 395)
        Me.Opciones_Label.Name = "Opciones_Label"
        Me.Opciones_Label.Size = New System.Drawing.Size(89, 20)
        Me.Opciones_Label.TabIndex = 29
        Me.Opciones_Label.Text = "Opciones:"
        '
        'Salir_Button_inventario
        '
        Me.Salir_Button_inventario.BackColor = System.Drawing.Color.PowderBlue
        Me.Salir_Button_inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir_Button_inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salir_Button_inventario.ImageKey = "16 (Exit).ico"
        Me.Salir_Button_inventario.Location = New System.Drawing.Point(377, 417)
        Me.Salir_Button_inventario.Name = "Salir_Button_inventario"
        Me.Salir_Button_inventario.Size = New System.Drawing.Size(119, 47)
        Me.Salir_Button_inventario.TabIndex = 28
        Me.Salir_Button_inventario.Text = "Salir"
        Me.Salir_Button_inventario.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(12, 403)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(577, 71)
        Me.Label2.TabIndex = 26
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Inventario
        '
        Me.Label_Inventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Inventario.Location = New System.Drawing.Point(0, 0)
        Me.Label_Inventario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Inventario.Name = "Label_Inventario"
        Me.Label_Inventario.Size = New System.Drawing.Size(651, 43)
        Me.Label_Inventario.TabIndex = 37
        Me.Label_Inventario.Text = "Inventario"
        Me.Label_Inventario.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'InventarioBindingNavigator
        '
        Me.InventarioBindingNavigator.AddNewItem = Nothing
        Me.InventarioBindingNavigator.BackColor = System.Drawing.Color.PowderBlue
        Me.InventarioBindingNavigator.BindingSource = Me.InventarioBindingSource
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
        Me.InventarioBindingNavigator.Size = New System.Drawing.Size(651, 27)
        Me.InventarioBindingNavigator.TabIndex = 38
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
        Me.Cancelar_Operacion.Text = "ToolStripButton1"
        Me.Cancelar_Operacion.Visible = False
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me._Inv_Bodegas_DataSet
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'BodegaBindingSource
        '
        Me.BodegaBindingSource.DataMember = "Bodega"
        Me.BodegaBindingSource.DataSource = Me._Inv_Bodegas_DataSet
        '
        'BodegaTableAdapter
        '
        Me.BodegaTableAdapter.ClearBeforeFill = True
        '
        'InventarioBindingSource1
        '
        Me.InventarioBindingSource1.DataMember = "FK_Inventario_Bodega"
        Me.InventarioBindingSource1.DataSource = Me.BodegaBindingSource
        '
        'InventarioDataGridView
        '
        Me.InventarioDataGridView.AllowUserToAddRows = False
        Me.InventarioDataGridView.AllowUserToDeleteRows = False
        Me.InventarioDataGridView.AutoGenerateColumns = False
        Me.InventarioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.InventarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InventarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.InventarioDataGridView.DataSource = Me.InventarioBindingSource
        Me.InventarioDataGridView.Location = New System.Drawing.Point(0, 137)
        Me.InventarioDataGridView.Name = "InventarioDataGridView"
        Me.InventarioDataGridView.ReadOnly = True
        Me.InventarioDataGridView.Size = New System.Drawing.Size(631, 242)
        Me.InventarioDataGridView.TabIndex = 39
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdInventario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdInventario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdProducto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdProducto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Medida"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Medida"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Existencia_Inicial"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Existencia_Inicial"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Existencia_Final"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Existencia_Final"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdBodega"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IdBodega"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PowderBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageKey = "16 (Exit).ico"
        Me.Button1.Location = New System.Drawing.Point(155, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 47)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Reportes"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BuscarButton
        '
        Me.BuscarButton.BackgroundImage = Global.Sistema_de_Inventario_de_Bodegas.My.Resources.Resources._16__Search_
        Me.BuscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BuscarButton.Location = New System.Drawing.Point(162, 92)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(28, 23)
        Me.BuscarButton.TabIndex = 85
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'IdInventarioComboBox
        '
        Me.IdInventarioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource1, "IdInventario", True))
        Me.IdInventarioComboBox.DataSource = Me.SubinventarioselBindingSource
        Me.IdInventarioComboBox.DisplayMember = "IdInventario"
        Me.IdInventarioComboBox.FormattingEnabled = True
        Me.IdInventarioComboBox.Location = New System.Drawing.Point(92, 93)
        Me.IdInventarioComboBox.Name = "IdInventarioComboBox"
        Me.IdInventarioComboBox.Size = New System.Drawing.Size(71, 21)
        Me.IdInventarioComboBox.TabIndex = 86
        '
        'SubinventarioselBindingSource
        '
        Me.SubinventarioselBindingSource.DataMember = "sub_inventario_sel"
        Me.SubinventarioselBindingSource.DataSource = Me.Inventario_de_Bodega_UNICAHDataSet6
        '
        'Inventario_de_Bodega_UNICAHDataSet6
        '
        Me.Inventario_de_Bodega_UNICAHDataSet6.DataSetName = "Inventario_de_Bodega_UNICAHDataSet6"
        Me.Inventario_de_Bodega_UNICAHDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sub_inventario_selTableAdapter1
        '
        Me.Sub_inventario_selTableAdapter1.ClearBeforeFill = True
        '
        'Sub_inventario_selTableAdapter
        '
        Me.Sub_inventario_selTableAdapter.ClearBeforeFill = True
        '
        'IdBodegaComboBox
        '
        Me.IdBodegaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "IdBodega", True))
        Me.IdBodegaComboBox.DataSource = Me.SubfiltrobodegaselBindingSource
        Me.IdBodegaComboBox.DisplayMember = "IdBodega"
        Me.IdBodegaComboBox.FormattingEnabled = True
        Me.IdBodegaComboBox.Location = New System.Drawing.Point(377, 96)
        Me.IdBodegaComboBox.Name = "IdBodegaComboBox"
        Me.IdBodegaComboBox.Size = New System.Drawing.Size(64, 21)
        Me.IdBodegaComboBox.TabIndex = 87
        '
        'SubfiltrobodegaselBindingSource
        '
        Me.SubfiltrobodegaselBindingSource.DataMember = "sub_filtrobodega_sel"
        Me.SubfiltrobodegaselBindingSource.DataSource = Me.Inventario_de_Bodega_UNICAHDataSet8
        '
        'Inventario_de_Bodega_UNICAHDataSet8
        '
        Me.Inventario_de_Bodega_UNICAHDataSet8.DataSetName = "Inventario_de_Bodega_UNICAHDataSet8"
        Me.Inventario_de_Bodega_UNICAHDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FiltroBodega
        '
        Me.FiltroBodega.BackgroundImage = Global.Sistema_de_Inventario_de_Bodegas.My.Resources.Resources._16__Search_
        Me.FiltroBodega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.FiltroBodega.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FiltroBodega.Location = New System.Drawing.Point(439, 95)
        Me.FiltroBodega.Name = "FiltroBodega"
        Me.FiltroBodega.Size = New System.Drawing.Size(28, 23)
        Me.FiltroBodega.TabIndex = 88
        Me.FiltroBodega.UseVisualStyleBackColor = True
        '
        'Sub_filtrobodega_selTableAdapter
        '
        Me.Sub_filtrobodega_selTableAdapter.ClearBeforeFill = True
        '
        'Inventario_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(651, 494)
        Me.Controls.Add(Me.FiltroBodega)
        Me.Controls.Add(IdBodegaLabel)
        Me.Controls.Add(Me.IdBodegaComboBox)
        Me.Controls.Add(IdInventarioLabel)
        Me.Controls.Add(Me.IdInventarioComboBox)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.InventarioDataGridView)
        Me.Controls.Add(Me.InventarioBindingNavigator)
        Me.Controls.Add(Me.Label_Inventario)
        Me.Controls.Add(Me.Opciones_Label)
        Me.Controls.Add(Me.Salir_Button_inventario)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Inventario_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario_Form"
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventarioBindingNavigator.ResumeLayout(False)
        Me.InventarioBindingNavigator.PerformLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BodegaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubinventarioselBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventario_de_Bodega_UNICAHDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubfiltrobodegaselBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventario_de_Bodega_UNICAHDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Inv_Bodegas_DataSet As _Inv_Bodegas_DataSet
    Friend WithEvents InventarioBindingSource As BindingSource
    Friend WithEvents InventarioTableAdapter As _Inv_Bodegas_DataSetTableAdapters.InventarioTableAdapter
    Friend WithEvents TableAdapterManager As _Inv_Bodegas_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Opciones_Label As Label
    Friend WithEvents Salir_Button_inventario As Button
    Friend WithEvents Label2 As Label
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
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As _Inv_Bodegas_DataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents BodegaBindingSource As BindingSource
    Friend WithEvents BodegaTableAdapter As _Inv_Bodegas_DataSetTableAdapters.BodegaTableAdapter
    Friend WithEvents InventarioBindingSource1 As BindingSource
    Friend WithEvents InventarioDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents BuscarButton As Button
    Friend WithEvents IdInventarioComboBox As ComboBox
    Friend WithEvents Sub_inventario_selTableAdapter1 As Inventario_de_Bodega_UNICAHDataSet4TableAdapters.sub_inventario_selTableAdapter
    Friend WithEvents Inventario_de_Bodega_UNICAHDataSet6 As Inventario_de_Bodega_UNICAHDataSet6
    Friend WithEvents SubinventarioselBindingSource As BindingSource
    Friend WithEvents Sub_inventario_selTableAdapter As Inventario_de_Bodega_UNICAHDataSet6TableAdapters.sub_inventario_selTableAdapter
    Friend WithEvents IdBodegaComboBox As ComboBox
    Friend WithEvents FiltroBodega As Button
    Friend WithEvents Inventario_de_Bodega_UNICAHDataSet8 As Inventario_de_Bodega_UNICAHDataSet8
    Friend WithEvents SubfiltrobodegaselBindingSource As BindingSource
    Friend WithEvents Sub_filtrobodega_selTableAdapter As Inventario_de_Bodega_UNICAHDataSet8TableAdapters.sub_filtrobodega_selTableAdapter
End Class

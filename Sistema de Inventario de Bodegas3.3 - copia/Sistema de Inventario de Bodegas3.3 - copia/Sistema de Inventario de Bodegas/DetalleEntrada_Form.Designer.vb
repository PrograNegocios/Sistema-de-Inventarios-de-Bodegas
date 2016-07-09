<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleEntrada_Form
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
        Dim IdEntradasLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim IdInventarioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetalleEntrada_Form))
        Me.Productotitle_Label = New System.Windows.Forms.Label()
        Me.GroupBoxOpciones_p = New System.Windows.Forms.GroupBox()
        Me.Eliminar_Button_DetalleEntrada = New System.Windows.Forms.Button()
        Me.Agregar_Button_DetalleEntrada = New System.Windows.Forms.Button()
        Me.Salir_Button = New System.Windows.Forms.Button()
        Me.Guardar_Button_DetalleEntrada = New System.Windows.Forms.Button()
        Me._Inv_Bodegas_DataSet = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSet()
        Me.Detalle_EntradasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Detalle_EntradasTableAdapter = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.Detalle_EntradasTableAdapter()
        Me.TableAdapterManager = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager()
        Me.Detalle_EntradasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.IdEntradasTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.IdInventarioComboBox = New System.Windows.Forms.ComboBox()
        IdEntradasLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        IdInventarioLabel = New System.Windows.Forms.Label()
        Me.GroupBoxOpciones_p.SuspendLayout()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalle_EntradasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalle_EntradasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventarioBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdEntradasLabel
        '
        IdEntradasLabel.AutoSize = True
        IdEntradasLabel.Location = New System.Drawing.Point(49, 135)
        IdEntradasLabel.Name = "IdEntradasLabel"
        IdEntradasLabel.Size = New System.Drawing.Size(64, 13)
        IdEntradasLabel.TabIndex = 102
        IdEntradasLabel.Text = "Id Entradas:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(49, 161)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 104
        CantidadLabel.Text = "Cantidad:"
        '
        'IdInventarioLabel
        '
        IdInventarioLabel.AutoSize = True
        IdInventarioLabel.Location = New System.Drawing.Point(49, 106)
        IdInventarioLabel.Name = "IdInventarioLabel"
        IdInventarioLabel.Size = New System.Drawing.Size(69, 13)
        IdInventarioLabel.TabIndex = 105
        IdInventarioLabel.Text = "Id Inventario:"
        '
        'Productotitle_Label
        '
        Me.Productotitle_Label.BackColor = System.Drawing.Color.DarkCyan
        Me.Productotitle_Label.Dock = System.Windows.Forms.DockStyle.Top
        Me.Productotitle_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Productotitle_Label.ForeColor = System.Drawing.Color.Black
        Me.Productotitle_Label.Location = New System.Drawing.Point(0, 0)
        Me.Productotitle_Label.Name = "Productotitle_Label"
        Me.Productotitle_Label.Size = New System.Drawing.Size(688, 51)
        Me.Productotitle_Label.TabIndex = 20
        Me.Productotitle_Label.Text = "Detalle Entrada"
        Me.Productotitle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBoxOpciones_p
        '
        Me.GroupBoxOpciones_p.Controls.Add(Me.Eliminar_Button_DetalleEntrada)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Agregar_Button_DetalleEntrada)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Salir_Button)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Guardar_Button_DetalleEntrada)
        Me.GroupBoxOpciones_p.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxOpciones_p.Location = New System.Drawing.Point(63, 427)
        Me.GroupBoxOpciones_p.Name = "GroupBoxOpciones_p"
        Me.GroupBoxOpciones_p.Size = New System.Drawing.Size(427, 83)
        Me.GroupBoxOpciones_p.TabIndex = 98
        Me.GroupBoxOpciones_p.TabStop = False
        Me.GroupBoxOpciones_p.Text = "Opciones"
        '
        'Eliminar_Button_DetalleEntrada
        '
        Me.Eliminar_Button_DetalleEntrada.BackColor = System.Drawing.Color.PowderBlue
        Me.Eliminar_Button_DetalleEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar_Button_DetalleEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Eliminar_Button_DetalleEntrada.ImageKey = "(ninguno)"
        Me.Eliminar_Button_DetalleEntrada.Location = New System.Drawing.Point(226, 25)
        Me.Eliminar_Button_DetalleEntrada.Name = "Eliminar_Button_DetalleEntrada"
        Me.Eliminar_Button_DetalleEntrada.Size = New System.Drawing.Size(98, 47)
        Me.Eliminar_Button_DetalleEntrada.TabIndex = 36
        Me.Eliminar_Button_DetalleEntrada.Text = "Eliminar"
        Me.Eliminar_Button_DetalleEntrada.UseVisualStyleBackColor = False
        '
        'Agregar_Button_DetalleEntrada
        '
        Me.Agregar_Button_DetalleEntrada.BackColor = System.Drawing.Color.PowderBlue
        Me.Agregar_Button_DetalleEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar_Button_DetalleEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Agregar_Button_DetalleEntrada.ImageKey = "(ninguno)"
        Me.Agregar_Button_DetalleEntrada.Location = New System.Drawing.Point(118, 25)
        Me.Agregar_Button_DetalleEntrada.Name = "Agregar_Button_DetalleEntrada"
        Me.Agregar_Button_DetalleEntrada.Size = New System.Drawing.Size(102, 47)
        Me.Agregar_Button_DetalleEntrada.TabIndex = 35
        Me.Agregar_Button_DetalleEntrada.Text = "Agregar"
        Me.Agregar_Button_DetalleEntrada.UseVisualStyleBackColor = False
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
        'Guardar_Button_DetalleEntrada
        '
        Me.Guardar_Button_DetalleEntrada.BackColor = System.Drawing.Color.PowderBlue
        Me.Guardar_Button_DetalleEntrada.Enabled = False
        Me.Guardar_Button_DetalleEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar_Button_DetalleEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Guardar_Button_DetalleEntrada.ImageKey = "(ninguno)"
        Me.Guardar_Button_DetalleEntrada.Location = New System.Drawing.Point(13, 25)
        Me.Guardar_Button_DetalleEntrada.Name = "Guardar_Button_DetalleEntrada"
        Me.Guardar_Button_DetalleEntrada.Size = New System.Drawing.Size(99, 47)
        Me.Guardar_Button_DetalleEntrada.TabIndex = 34
        Me.Guardar_Button_DetalleEntrada.Text = "Guardar"
        Me.Guardar_Button_DetalleEntrada.UseVisualStyleBackColor = False
        '
        '_Inv_Bodegas_DataSet
        '
        Me._Inv_Bodegas_DataSet.DataSetName = "Inv-Bodegas_DataSet"
        Me._Inv_Bodegas_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Detalle_EntradasBindingSource
        '
        Me.Detalle_EntradasBindingSource.DataMember = "Detalle Entradas"
        Me.Detalle_EntradasBindingSource.DataSource = Me._Inv_Bodegas_DataSet
        '
        'Detalle_EntradasTableAdapter
        '
        Me.Detalle_EntradasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BodegaTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_EntradasTableAdapter = Me.Detalle_EntradasTableAdapter
        Me.TableAdapterManager.Detalle_SalidasTableAdapter = Nothing
        Me.TableAdapterManager.EntradasTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.RequisiciónTableAdapter = Nothing
        Me.TableAdapterManager.SalidasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Detalle_EntradasDataGridView
        '
        Me.Detalle_EntradasDataGridView.AutoGenerateColumns = False
        Me.Detalle_EntradasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Detalle_EntradasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Detalle_EntradasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Detalle_EntradasDataGridView.DataSource = Me.Detalle_EntradasBindingSource
        Me.Detalle_EntradasDataGridView.Location = New System.Drawing.Point(32, 215)
        Me.Detalle_EntradasDataGridView.Name = "Detalle_EntradasDataGridView"
        Me.Detalle_EntradasDataGridView.Size = New System.Drawing.Size(439, 206)
        Me.Detalle_EntradasDataGridView.TabIndex = 99
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdInventario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdInventario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdEntradas"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdEntradas"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'InventarioBindingNavigator
        '
        Me.InventarioBindingNavigator.AddNewItem = Nothing
        Me.InventarioBindingNavigator.BackColor = System.Drawing.Color.PowderBlue
        Me.InventarioBindingNavigator.BindingSource = Me.Detalle_EntradasBindingSource
        Me.InventarioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InventarioBindingNavigator.DeleteItem = Nothing
        Me.InventarioBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.InventarioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.Cancelar_Operacion})
        Me.InventarioBindingNavigator.Location = New System.Drawing.Point(0, 51)
        Me.InventarioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InventarioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InventarioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InventarioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InventarioBindingNavigator.Name = "InventarioBindingNavigator"
        Me.InventarioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InventarioBindingNavigator.Size = New System.Drawing.Size(688, 27)
        Me.InventarioBindingNavigator.TabIndex = 100
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
        Me.Cancelar_Operacion.ToolTipText = "Cancelar"
        Me.Cancelar_Operacion.Visible = False
        '
        'IdEntradasTextBox
        '
        Me.IdEntradasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_EntradasBindingSource, "IdEntradas", True))
        Me.IdEntradasTextBox.Location = New System.Drawing.Point(124, 132)
        Me.IdEntradasTextBox.Name = "IdEntradasTextBox"
        Me.IdEntradasTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IdEntradasTextBox.TabIndex = 103
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_EntradasBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(124, 158)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CantidadTextBox.TabIndex = 105
        '
        'IdInventarioComboBox
        '
        Me.IdInventarioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_EntradasBindingSource, "IdInventario", True))
        Me.IdInventarioComboBox.FormattingEnabled = True
        Me.IdInventarioComboBox.Location = New System.Drawing.Point(124, 103)
        Me.IdInventarioComboBox.Name = "IdInventarioComboBox"
        Me.IdInventarioComboBox.Size = New System.Drawing.Size(121, 21)
        Me.IdInventarioComboBox.TabIndex = 106
        '
        'DetalleEntrada_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(688, 554)
        Me.Controls.Add(IdInventarioLabel)
        Me.Controls.Add(Me.IdInventarioComboBox)
        Me.Controls.Add(IdEntradasLabel)
        Me.Controls.Add(Me.IdEntradasTextBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(Me.InventarioBindingNavigator)
        Me.Controls.Add(Me.Detalle_EntradasDataGridView)
        Me.Controls.Add(Me.GroupBoxOpciones_p)
        Me.Controls.Add(Me.Productotitle_Label)
        Me.Name = "DetalleEntrada_Form"
        Me.Text = "DetalleEntrada_Form"
        Me.GroupBoxOpciones_p.ResumeLayout(False)
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalle_EntradasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalle_EntradasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventarioBindingNavigator.ResumeLayout(False)
        Me.InventarioBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Productotitle_Label As Label
    Friend WithEvents GroupBoxOpciones_p As GroupBox
    Friend WithEvents Eliminar_Button_DetalleEntrada As Button
    Friend WithEvents Agregar_Button_DetalleEntrada As Button
    Friend WithEvents Salir_Button As Button
    Friend WithEvents Guardar_Button_DetalleEntrada As Button
    Friend WithEvents _Inv_Bodegas_DataSet As _Inv_Bodegas_DataSet
    Friend WithEvents Detalle_EntradasBindingSource As BindingSource
    Friend WithEvents Detalle_EntradasTableAdapter As _Inv_Bodegas_DataSetTableAdapters.Detalle_EntradasTableAdapter
    Friend WithEvents TableAdapterManager As _Inv_Bodegas_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Detalle_EntradasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
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
    Friend WithEvents IdEntradasTextBox As TextBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents IdInventarioComboBox As ComboBox
End Class

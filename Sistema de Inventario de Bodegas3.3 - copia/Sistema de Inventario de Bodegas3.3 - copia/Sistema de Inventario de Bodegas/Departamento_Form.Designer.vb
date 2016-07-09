<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Departamento_Form
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
        Dim IdDepartamentoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim EncargadoLabel As System.Windows.Forms.Label
        Dim BuscarLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Departamento_Form))
        Me.Label_Depto = New System.Windows.Forms.Label()
        Me.InventarioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.IdDepartamentoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.EncargadoTextBox = New System.Windows.Forms.TextBox()
        Me.DeptoDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EncargadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.BuscarTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBoxOpciones_p = New System.Windows.Forms.GroupBox()
        Me.Eliminar_Depto_Button = New System.Windows.Forms.Button()
        Me.Agregar_Button_Depto = New System.Windows.Forms.Button()
        Me.Salir_Button = New System.Windows.Forms.Button()
        Me.Guardar_Button_Depto = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager()
        Me.DepartamentoTableAdapter = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.DepartamentoTableAdapter()
        IdDepartamentoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        EncargadoLabel = New System.Windows.Forms.Label()
        BuscarLabel = New System.Windows.Forms.Label()
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventarioBindingNavigator.SuspendLayout()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeptoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxOpciones_p.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdDepartamentoLabel
        '
        IdDepartamentoLabel.AutoSize = True
        IdDepartamentoLabel.Location = New System.Drawing.Point(4, 16)
        IdDepartamentoLabel.Name = "IdDepartamentoLabel"
        IdDepartamentoLabel.Size = New System.Drawing.Size(89, 13)
        IdDepartamentoLabel.TabIndex = 87
        IdDepartamentoLabel.Text = "Id Departamento:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(5, 51)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 88
        NombreLabel.Text = "Nombre:"
        '
        'EncargadoLabel
        '
        EncargadoLabel.AutoSize = True
        EncargadoLabel.Location = New System.Drawing.Point(6, 88)
        EncargadoLabel.Name = "EncargadoLabel"
        EncargadoLabel.Size = New System.Drawing.Size(62, 13)
        EncargadoLabel.TabIndex = 89
        EncargadoLabel.Text = "Encargado:"
        '
        'BuscarLabel
        '
        BuscarLabel.AutoSize = True
        BuscarLabel.Location = New System.Drawing.Point(33, 93)
        BuscarLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        BuscarLabel.Name = "BuscarLabel"
        BuscarLabel.Size = New System.Drawing.Size(43, 13)
        BuscarLabel.TabIndex = 93
        BuscarLabel.Text = "Buscar:"
        '
        'Label_Depto
        '
        Me.Label_Depto.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Depto.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Depto.Location = New System.Drawing.Point(0, 0)
        Me.Label_Depto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Depto.Name = "Label_Depto"
        Me.Label_Depto.Size = New System.Drawing.Size(494, 43)
        Me.Label_Depto.TabIndex = 40
        Me.Label_Depto.Text = "Departamento de Inventario"
        Me.Label_Depto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'InventarioBindingNavigator
        '
        Me.InventarioBindingNavigator.AddNewItem = Nothing
        Me.InventarioBindingNavigator.BackColor = System.Drawing.Color.PowderBlue
        Me.InventarioBindingNavigator.BindingSource = Me.DepartamentoBindingSource
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
        Me.InventarioBindingNavigator.Size = New System.Drawing.Size(494, 27)
        Me.InventarioBindingNavigator.TabIndex = 87
        Me.InventarioBindingNavigator.Text = "BindingNavigator1"
        '
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "Departamento"
        Me.DepartamentoBindingSource.DataSource = Me._Inv_Bodegas_DataSet
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
        Me.Cancelar_Operacion.Visible = False
        '
        'IdDepartamentoTextBox
        '
        Me.IdDepartamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartamentoBindingSource, "IdDepartamento", True))
        Me.IdDepartamentoTextBox.Enabled = False
        Me.IdDepartamentoTextBox.Location = New System.Drawing.Point(99, 13)
        Me.IdDepartamentoTextBox.Name = "IdDepartamentoTextBox"
        Me.IdDepartamentoTextBox.ReadOnly = True
        Me.IdDepartamentoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdDepartamentoTextBox.TabIndex = 88
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartamentoBindingSource, "Nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(99, 51)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 89
        '
        'EncargadoTextBox
        '
        Me.EncargadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartamentoBindingSource, "Encargado", True))
        Me.EncargadoTextBox.Enabled = False
        Me.EncargadoTextBox.Location = New System.Drawing.Point(99, 88)
        Me.EncargadoTextBox.Name = "EncargadoTextBox"
        Me.EncargadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EncargadoTextBox.TabIndex = 90
        '
        'DeptoDataGridView
        '
        Me.DeptoDataGridView.AutoGenerateColumns = False
        Me.DeptoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DeptoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDepartamentoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.EncargadoDataGridViewTextBoxColumn})
        Me.DeptoDataGridView.DataSource = Me.DepartamentoBindingSource
        Me.DeptoDataGridView.Location = New System.Drawing.Point(30, 130)
        Me.DeptoDataGridView.Name = "DeptoDataGridView"
        Me.DeptoDataGridView.Size = New System.Drawing.Size(346, 90)
        Me.DeptoDataGridView.TabIndex = 91
        '
        'IdDepartamentoDataGridViewTextBoxColumn
        '
        Me.IdDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "IdDepartamento"
        Me.IdDepartamentoDataGridViewTextBoxColumn.HeaderText = "IdDepartamento"
        Me.IdDepartamentoDataGridViewTextBoxColumn.Name = "IdDepartamentoDataGridViewTextBoxColumn"
        Me.IdDepartamentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'EncargadoDataGridViewTextBoxColumn
        '
        Me.EncargadoDataGridViewTextBoxColumn.DataPropertyName = "Encargado"
        Me.EncargadoDataGridViewTextBoxColumn.HeaderText = "Encargado"
        Me.EncargadoDataGridViewTextBoxColumn.Name = "EncargadoDataGridViewTextBoxColumn"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(EncargadoLabel)
        Me.GroupBox1.Controls.Add(Me.EncargadoTextBox)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(IdDepartamentoLabel)
        Me.GroupBox1.Controls.Add(Me.IdDepartamentoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 236)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 126)
        Me.GroupBox1.TabIndex = 92
        Me.GroupBox1.TabStop = False
        '
        'BuscarButton
        '
        Me.BuscarButton.BackgroundImage = Global.Sistema_de_Inventario_de_Bodegas.My.Resources.Resources._16__Search_
        Me.BuscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BuscarButton.Location = New System.Drawing.Point(244, 92)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(28, 23)
        Me.BuscarButton.TabIndex = 95
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'BuscarTextBox
        '
        Me.BuscarTextBox.Location = New System.Drawing.Point(130, 93)
        Me.BuscarTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.BuscarTextBox.Multiline = True
        Me.BuscarTextBox.Name = "BuscarTextBox"
        Me.BuscarTextBox.Size = New System.Drawing.Size(142, 21)
        Me.BuscarTextBox.TabIndex = 94
        '
        'GroupBoxOpciones_p
        '
        Me.GroupBoxOpciones_p.Controls.Add(Me.Eliminar_Depto_Button)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Agregar_Button_Depto)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Salir_Button)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Guardar_Button_Depto)
        Me.GroupBoxOpciones_p.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxOpciones_p.Location = New System.Drawing.Point(31, 368)
        Me.GroupBoxOpciones_p.Name = "GroupBoxOpciones_p"
        Me.GroupBoxOpciones_p.Size = New System.Drawing.Size(427, 83)
        Me.GroupBoxOpciones_p.TabIndex = 96
        Me.GroupBoxOpciones_p.TabStop = False
        Me.GroupBoxOpciones_p.Text = "Opciones"
        '
        'Eliminar_Depto_Button
        '
        Me.Eliminar_Depto_Button.BackColor = System.Drawing.Color.PowderBlue
        Me.Eliminar_Depto_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar_Depto_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Eliminar_Depto_Button.ImageKey = "(ninguno)"
        Me.Eliminar_Depto_Button.Location = New System.Drawing.Point(226, 25)
        Me.Eliminar_Depto_Button.Name = "Eliminar_Depto_Button"
        Me.Eliminar_Depto_Button.Size = New System.Drawing.Size(98, 47)
        Me.Eliminar_Depto_Button.TabIndex = 36
        Me.Eliminar_Depto_Button.Text = "Eliminar"
        Me.Eliminar_Depto_Button.UseVisualStyleBackColor = False
        '
        'Agregar_Button_Depto
        '
        Me.Agregar_Button_Depto.BackColor = System.Drawing.Color.PowderBlue
        Me.Agregar_Button_Depto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar_Button_Depto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Agregar_Button_Depto.ImageKey = "(ninguno)"
        Me.Agregar_Button_Depto.Location = New System.Drawing.Point(118, 25)
        Me.Agregar_Button_Depto.Name = "Agregar_Button_Depto"
        Me.Agregar_Button_Depto.Size = New System.Drawing.Size(102, 47)
        Me.Agregar_Button_Depto.TabIndex = 35
        Me.Agregar_Button_Depto.Text = "Agregar"
        Me.Agregar_Button_Depto.UseVisualStyleBackColor = False
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
        'Guardar_Button_Depto
        '
        Me.Guardar_Button_Depto.BackColor = System.Drawing.Color.PowderBlue
        Me.Guardar_Button_Depto.Enabled = False
        Me.Guardar_Button_Depto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar_Button_Depto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Guardar_Button_Depto.ImageKey = "(ninguno)"
        Me.Guardar_Button_Depto.Location = New System.Drawing.Point(13, 25)
        Me.Guardar_Button_Depto.Name = "Guardar_Button_Depto"
        Me.Guardar_Button_Depto.Size = New System.Drawing.Size(99, 47)
        Me.Guardar_Button_Depto.TabIndex = 34
        Me.Guardar_Button_Depto.Text = "Guardar"
        Me.Guardar_Button_Depto.UseVisualStyleBackColor = False
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BodegaTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentoTableAdapter = Me.DepartamentoTableAdapter
        Me.TableAdapterManager.Detalle_EntradasTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_SalidasTableAdapter = Nothing
        Me.TableAdapterManager.EntradasTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.RequisiciónTableAdapter = Nothing
        Me.TableAdapterManager.SalidasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'Departamento_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(494, 466)
        Me.Controls.Add(Me.GroupBoxOpciones_p)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(BuscarLabel)
        Me.Controls.Add(Me.BuscarTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DeptoDataGridView)
        Me.Controls.Add(Me.InventarioBindingNavigator)
        Me.Controls.Add(Me.Label_Depto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Departamento_Form"
        Me.Text = "Departamento_Form"
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventarioBindingNavigator.ResumeLayout(False)
        Me.InventarioBindingNavigator.PerformLayout()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeptoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxOpciones_p.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Depto As Label
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
    Friend WithEvents _Inv_Bodegas_DataSet As _Inv_Bodegas_DataSet
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As _Inv_Bodegas_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdDepartamentoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents EncargadoTextBox As TextBox
    Friend WithEvents DeptoDataGridView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BuscarButton As Button
    Friend WithEvents BuscarTextBox As TextBox
    Friend WithEvents GroupBoxOpciones_p As GroupBox
    Friend WithEvents Eliminar_Depto_Button As Button
    Friend WithEvents Agregar_Button_Depto As Button
    Friend WithEvents Salir_Button As Button
    Friend WithEvents Guardar_Button_Depto As Button
    Friend WithEvents IdDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EncargadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartamentoTableAdapter As _Inv_Bodegas_DataSetTableAdapters.DepartamentoTableAdapter
End Class

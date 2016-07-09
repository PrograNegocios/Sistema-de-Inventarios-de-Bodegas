<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bodega_Form
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
        Dim IdBodegaLabel As System.Windows.Forms.Label
        Dim LocalizaciónLabel As System.Windows.Forms.Label
        Dim EspecialidadesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bodega_Form))
        Dim BuscarLabel As System.Windows.Forms.Label
        Me._Inv_Bodegas_DataSet = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSet()
        Me.BodegaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BodegaTableAdapter = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.BodegaTableAdapter()
        Me.TableAdapterManager = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager()
        Me.BodegaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.IdBodegaTextBox = New System.Windows.Forms.TextBox()
        Me.LocalizaciónTextBox = New System.Windows.Forms.TextBox()
        Me.EspecialidadesTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBoxOpciones_p = New System.Windows.Forms.GroupBox()
        Me.Eliminar_Button_Bodega = New System.Windows.Forms.Button()
        Me.Agregar_Button_Bodega = New System.Windows.Forms.Button()
        Me.Salir_Button = New System.Windows.Forms.Button()
        Me.Guardar_Button_Bodega = New System.Windows.Forms.Button()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.BuscarTextBox = New System.Windows.Forms.TextBox()
        IdBodegaLabel = New System.Windows.Forms.Label()
        LocalizaciónLabel = New System.Windows.Forms.Label()
        EspecialidadesLabel = New System.Windows.Forms.Label()
        BuscarLabel = New System.Windows.Forms.Label()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BodegaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BodegaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventarioBindingNavigator.SuspendLayout()
        Me.GroupBoxOpciones_p.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdBodegaLabel
        '
        IdBodegaLabel.AutoSize = True
        IdBodegaLabel.Location = New System.Drawing.Point(68, 121)
        IdBodegaLabel.Name = "IdBodegaLabel"
        IdBodegaLabel.Size = New System.Drawing.Size(59, 13)
        IdBodegaLabel.TabIndex = 103
        IdBodegaLabel.Text = "Id Bodega:"
        '
        'LocalizaciónLabel
        '
        LocalizaciónLabel.AutoSize = True
        LocalizaciónLabel.Location = New System.Drawing.Point(68, 149)
        LocalizaciónLabel.Name = "LocalizaciónLabel"
        LocalizaciónLabel.Size = New System.Drawing.Size(69, 13)
        LocalizaciónLabel.TabIndex = 105
        LocalizaciónLabel.Text = "Localización:"
        '
        'EspecialidadesLabel
        '
        EspecialidadesLabel.AutoSize = True
        EspecialidadesLabel.Location = New System.Drawing.Point(274, 151)
        EspecialidadesLabel.Name = "EspecialidadesLabel"
        EspecialidadesLabel.Size = New System.Drawing.Size(81, 13)
        EspecialidadesLabel.TabIndex = 107
        EspecialidadesLabel.Text = "Especialidades:"
        '
        '_Inv_Bodegas_DataSet
        '
        Me._Inv_Bodegas_DataSet.DataSetName = "Inv-Bodegas_DataSet"
        Me._Inv_Bodegas_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BodegaTableAdapter = Me.BodegaTableAdapter
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
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
        'BodegaDataGridView
        '
        Me.BodegaDataGridView.AllowUserToAddRows = False
        Me.BodegaDataGridView.AllowUserToDeleteRows = False
        Me.BodegaDataGridView.AutoGenerateColumns = False
        Me.BodegaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BodegaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BodegaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.BodegaDataGridView.DataSource = Me.BodegaBindingSource
        Me.BodegaDataGridView.Location = New System.Drawing.Point(72, 184)
        Me.BodegaDataGridView.Name = "BodegaDataGridView"
        Me.BodegaDataGridView.ReadOnly = True
        Me.BodegaDataGridView.Size = New System.Drawing.Size(399, 200)
        Me.BodegaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdBodega"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdBodega"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Localización"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Localización"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Especialidades"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Especialidades"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Label_Inventario
        '
        Me.Label_Inventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Inventario.Location = New System.Drawing.Point(0, 0)
        Me.Label_Inventario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Inventario.Name = "Label_Inventario"
        Me.Label_Inventario.Size = New System.Drawing.Size(611, 43)
        Me.Label_Inventario.TabIndex = 40
        Me.Label_Inventario.Text = "Bodega"
        Me.Label_Inventario.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'InventarioBindingNavigator
        '
        Me.InventarioBindingNavigator.AddNewItem = Nothing
        Me.InventarioBindingNavigator.BackColor = System.Drawing.Color.PowderBlue
        Me.InventarioBindingNavigator.BindingSource = Me.BodegaBindingSource
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
        Me.InventarioBindingNavigator.Size = New System.Drawing.Size(611, 27)
        Me.InventarioBindingNavigator.TabIndex = 103
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
        'IdBodegaTextBox
        '
        Me.IdBodegaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BodegaBindingSource, "IdBodega", True))
        Me.IdBodegaTextBox.Location = New System.Drawing.Point(155, 118)
        Me.IdBodegaTextBox.Name = "IdBodegaTextBox"
        Me.IdBodegaTextBox.ReadOnly = True
        Me.IdBodegaTextBox.Size = New System.Drawing.Size(47, 20)
        Me.IdBodegaTextBox.TabIndex = 104
        '
        'LocalizaciónTextBox
        '
        Me.LocalizaciónTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BodegaBindingSource, "Localización", True))
        Me.LocalizaciónTextBox.Enabled = False
        Me.LocalizaciónTextBox.Location = New System.Drawing.Point(155, 146)
        Me.LocalizaciónTextBox.Name = "LocalizaciónTextBox"
        Me.LocalizaciónTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LocalizaciónTextBox.TabIndex = 106
        '
        'EspecialidadesTextBox
        '
        Me.EspecialidadesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BodegaBindingSource, "Especialidades", True))
        Me.EspecialidadesTextBox.Enabled = False
        Me.EspecialidadesTextBox.Location = New System.Drawing.Point(361, 148)
        Me.EspecialidadesTextBox.Name = "EspecialidadesTextBox"
        Me.EspecialidadesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EspecialidadesTextBox.TabIndex = 108
        '
        'GroupBoxOpciones_p
        '
        Me.GroupBoxOpciones_p.Controls.Add(Me.Eliminar_Button_Bodega)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Agregar_Button_Bodega)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Salir_Button)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Guardar_Button_Bodega)
        Me.GroupBoxOpciones_p.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBoxOpciones_p.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxOpciones_p.Location = New System.Drawing.Point(0, 393)
        Me.GroupBoxOpciones_p.Name = "GroupBoxOpciones_p"
        Me.GroupBoxOpciones_p.Size = New System.Drawing.Size(611, 83)
        Me.GroupBoxOpciones_p.TabIndex = 109
        Me.GroupBoxOpciones_p.TabStop = False
        Me.GroupBoxOpciones_p.Text = "Opciones"
        '
        'Eliminar_Button_Bodega
        '
        Me.Eliminar_Button_Bodega.BackColor = System.Drawing.Color.PowderBlue
        Me.Eliminar_Button_Bodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar_Button_Bodega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Eliminar_Button_Bodega.ImageKey = "(ninguno)"
        Me.Eliminar_Button_Bodega.Location = New System.Drawing.Point(311, 24)
        Me.Eliminar_Button_Bodega.Name = "Eliminar_Button_Bodega"
        Me.Eliminar_Button_Bodega.Size = New System.Drawing.Size(136, 47)
        Me.Eliminar_Button_Bodega.TabIndex = 36
        Me.Eliminar_Button_Bodega.Text = "Eliminar"
        Me.Eliminar_Button_Bodega.UseVisualStyleBackColor = False
        '
        'Agregar_Button_Bodega
        '
        Me.Agregar_Button_Bodega.BackColor = System.Drawing.Color.PowderBlue
        Me.Agregar_Button_Bodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar_Button_Bodega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Agregar_Button_Bodega.ImageKey = "(ninguno)"
        Me.Agregar_Button_Bodega.Location = New System.Drawing.Point(155, 24)
        Me.Agregar_Button_Bodega.Name = "Agregar_Button_Bodega"
        Me.Agregar_Button_Bodega.Size = New System.Drawing.Size(136, 47)
        Me.Agregar_Button_Bodega.TabIndex = 35
        Me.Agregar_Button_Bodega.Text = "Agregar"
        Me.Agregar_Button_Bodega.UseVisualStyleBackColor = False
        '
        'Salir_Button
        '
        Me.Salir_Button.BackColor = System.Drawing.Color.PowderBlue
        Me.Salir_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salir_Button.ImageKey = "16 (Exit).ico"
        Me.Salir_Button.Location = New System.Drawing.Point(453, 24)
        Me.Salir_Button.Name = "Salir_Button"
        Me.Salir_Button.Size = New System.Drawing.Size(119, 47)
        Me.Salir_Button.TabIndex = 24
        Me.Salir_Button.Text = "Salir"
        Me.Salir_Button.UseVisualStyleBackColor = False
        '
        'Guardar_Button_Bodega
        '
        Me.Guardar_Button_Bodega.BackColor = System.Drawing.Color.PowderBlue
        Me.Guardar_Button_Bodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar_Button_Bodega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Guardar_Button_Bodega.ImageKey = "(ninguno)"
        Me.Guardar_Button_Bodega.Location = New System.Drawing.Point(13, 25)
        Me.Guardar_Button_Bodega.Name = "Guardar_Button_Bodega"
        Me.Guardar_Button_Bodega.Size = New System.Drawing.Size(136, 47)
        Me.Guardar_Button_Bodega.TabIndex = 34
        Me.Guardar_Button_Bodega.Text = "Guardar"
        Me.Guardar_Button_Bodega.UseVisualStyleBackColor = False
        '
        'BuscarButton
        '
        Me.BuscarButton.BackgroundImage = Global.Sistema_de_Inventario_de_Bodegas.My.Resources.Resources._16__Search_
        Me.BuscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BuscarButton.Location = New System.Drawing.Point(226, 87)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(28, 23)
        Me.BuscarButton.TabIndex = 112
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'BuscarLabel
        '
        BuscarLabel.AutoSize = True
        BuscarLabel.Location = New System.Drawing.Point(69, 91)
        BuscarLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        BuscarLabel.Name = "BuscarLabel"
        BuscarLabel.Size = New System.Drawing.Size(43, 13)
        BuscarLabel.TabIndex = 110
        BuscarLabel.Text = "Buscar:"
        '
        'BuscarTextBox
        '
        Me.BuscarTextBox.Location = New System.Drawing.Point(155, 88)
        Me.BuscarTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.BuscarTextBox.Multiline = True
        Me.BuscarTextBox.Name = "BuscarTextBox"
        Me.BuscarTextBox.Size = New System.Drawing.Size(75, 21)
        Me.BuscarTextBox.TabIndex = 111
        '
        'Bodega_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(611, 476)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(BuscarLabel)
        Me.Controls.Add(Me.BuscarTextBox)
        Me.Controls.Add(Me.GroupBoxOpciones_p)
        Me.Controls.Add(IdBodegaLabel)
        Me.Controls.Add(Me.IdBodegaTextBox)
        Me.Controls.Add(LocalizaciónLabel)
        Me.Controls.Add(Me.LocalizaciónTextBox)
        Me.Controls.Add(EspecialidadesLabel)
        Me.Controls.Add(Me.EspecialidadesTextBox)
        Me.Controls.Add(Me.InventarioBindingNavigator)
        Me.Controls.Add(Me.Label_Inventario)
        Me.Controls.Add(Me.BodegaDataGridView)
        Me.Name = "Bodega_Form"
        Me.Text = "Bodega_Form"
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BodegaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BodegaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventarioBindingNavigator.ResumeLayout(False)
        Me.InventarioBindingNavigator.PerformLayout()
        Me.GroupBoxOpciones_p.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Inv_Bodegas_DataSet As _Inv_Bodegas_DataSet
    Friend WithEvents BodegaBindingSource As BindingSource
    Friend WithEvents BodegaTableAdapter As _Inv_Bodegas_DataSetTableAdapters.BodegaTableAdapter
    Friend WithEvents TableAdapterManager As _Inv_Bodegas_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BodegaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
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
    Friend WithEvents IdBodegaTextBox As TextBox
    Friend WithEvents LocalizaciónTextBox As TextBox
    Friend WithEvents EspecialidadesTextBox As TextBox
    Friend WithEvents GroupBoxOpciones_p As GroupBox
    Friend WithEvents Eliminar_Button_Bodega As Button
    Friend WithEvents Agregar_Button_Bodega As Button
    Friend WithEvents Salir_Button As Button
    Friend WithEvents Guardar_Button_Bodega As Button
    Friend WithEvents BuscarButton As Button
    Friend WithEvents BuscarTextBox As TextBox
End Class

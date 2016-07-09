<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetalleSolucitud_Form
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
        Dim Estado_EntregaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetalleSolucitud_Form))
        Me.Label_Inventario = New System.Windows.Forms.Label()
        Me._Inv_Bodegas_DataSet = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSet()
        Me.Detalle_SolicitudBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Detalle_SolicitudTableAdapter = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.Detalle_SolicitudTableAdapter()
        Me.TableAdapterManager = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager()
        Me.Detalle_SolicitudBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Detalle_SolicitudBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Detalle_SolicitudDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxOpciones_p = New System.Windows.Forms.GroupBox()
        Me.Salir_Button = New System.Windows.Forms.Button()
        Me.Estado_EntregaComboBox = New System.Windows.Forms.ComboBox()
        Estado_EntregaLabel = New System.Windows.Forms.Label()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalle_SolicitudBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalle_SolicitudBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Detalle_SolicitudBindingNavigator.SuspendLayout()
        CType(Me.Detalle_SolicitudDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxOpciones_p.SuspendLayout()
        Me.SuspendLayout()
        '
        'Estado_EntregaLabel
        '
        Estado_EntregaLabel.AutoSize = True
        Estado_EntregaLabel.Location = New System.Drawing.Point(248, 121)
        Estado_EntregaLabel.Name = "Estado_EntregaLabel"
        Estado_EntregaLabel.Size = New System.Drawing.Size(83, 13)
        Estado_EntregaLabel.TabIndex = 87
        Estado_EntregaLabel.Text = "Estado Entrega:"
        '
        'Label_Inventario
        '
        Me.Label_Inventario.BackColor = System.Drawing.Color.DarkCyan
        Me.Label_Inventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Inventario.Location = New System.Drawing.Point(0, 0)
        Me.Label_Inventario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Inventario.Name = "Label_Inventario"
        Me.Label_Inventario.Size = New System.Drawing.Size(669, 43)
        Me.Label_Inventario.TabIndex = 40
        Me.Label_Inventario.Text = "Detalle de Solicitud"
        Me.Label_Inventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_Inv_Bodegas_DataSet
        '
        Me._Inv_Bodegas_DataSet.DataSetName = "Inv-Bodegas_DataSet"
        Me._Inv_Bodegas_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Detalle_SolicitudBindingSource
        '
        Me.Detalle_SolicitudBindingSource.DataMember = "Detalle Solicitud"
        Me.Detalle_SolicitudBindingSource.DataSource = Me._Inv_Bodegas_DataSet
        '
        'Detalle_SolicitudTableAdapter
        '
        Me.Detalle_SolicitudTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BodegaTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_SalidasTableAdapter = Nothing
        Me.TableAdapterManager.EntradasTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.RequisiciónTableAdapter = Nothing
        Me.TableAdapterManager.SalidasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Detalle_SolicitudBindingNavigator
        '
        Me.Detalle_SolicitudBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Detalle_SolicitudBindingNavigator.BindingSource = Me.Detalle_SolicitudBindingSource
        Me.Detalle_SolicitudBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Detalle_SolicitudBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Detalle_SolicitudBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Detalle_SolicitudBindingNavigatorSaveItem})
        Me.Detalle_SolicitudBindingNavigator.Location = New System.Drawing.Point(0, 43)
        Me.Detalle_SolicitudBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Detalle_SolicitudBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Detalle_SolicitudBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Detalle_SolicitudBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Detalle_SolicitudBindingNavigator.Name = "Detalle_SolicitudBindingNavigator"
        Me.Detalle_SolicitudBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Detalle_SolicitudBindingNavigator.Size = New System.Drawing.Size(669, 25)
        Me.Detalle_SolicitudBindingNavigator.TabIndex = 41
        Me.Detalle_SolicitudBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Detalle_SolicitudBindingNavigatorSaveItem
        '
        Me.Detalle_SolicitudBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Detalle_SolicitudBindingNavigatorSaveItem.Enabled = False
        Me.Detalle_SolicitudBindingNavigatorSaveItem.Image = CType(resources.GetObject("Detalle_SolicitudBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Detalle_SolicitudBindingNavigatorSaveItem.Name = "Detalle_SolicitudBindingNavigatorSaveItem"
        Me.Detalle_SolicitudBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Detalle_SolicitudBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Detalle_SolicitudDataGridView
        '
        Me.Detalle_SolicitudDataGridView.AllowUserToAddRows = False
        Me.Detalle_SolicitudDataGridView.AllowUserToDeleteRows = False
        Me.Detalle_SolicitudDataGridView.AutoGenerateColumns = False
        Me.Detalle_SolicitudDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Detalle_SolicitudDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Detalle_SolicitudDataGridView.DataSource = Me.Detalle_SolicitudBindingSource
        Me.Detalle_SolicitudDataGridView.Location = New System.Drawing.Point(63, 176)
        Me.Detalle_SolicitudDataGridView.Name = "Detalle_SolicitudDataGridView"
        Me.Detalle_SolicitudDataGridView.ReadOnly = True
        Me.Detalle_SolicitudDataGridView.Size = New System.Drawing.Size(540, 220)
        Me.Detalle_SolicitudDataGridView.TabIndex = 41
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Medida"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Medida"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Estado_Entrega"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estado_Entrega"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'GroupBoxOpciones_p
        '
        Me.GroupBoxOpciones_p.Controls.Add(Me.Salir_Button)
        Me.GroupBoxOpciones_p.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxOpciones_p.Location = New System.Drawing.Point(251, 439)
        Me.GroupBoxOpciones_p.Name = "GroupBoxOpciones_p"
        Me.GroupBoxOpciones_p.Size = New System.Drawing.Size(199, 83)
        Me.GroupBoxOpciones_p.TabIndex = 87
        Me.GroupBoxOpciones_p.TabStop = False
        Me.GroupBoxOpciones_p.Text = "Opciones"
        '
        'Salir_Button
        '
        Me.Salir_Button.BackColor = System.Drawing.Color.PowderBlue
        Me.Salir_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salir_Button.ImageKey = "16 (Exit).ico"
        Me.Salir_Button.Location = New System.Drawing.Point(48, 25)
        Me.Salir_Button.Name = "Salir_Button"
        Me.Salir_Button.Size = New System.Drawing.Size(119, 47)
        Me.Salir_Button.TabIndex = 24
        Me.Salir_Button.Text = "Salir"
        Me.Salir_Button.UseVisualStyleBackColor = False
        '
        'Estado_EntregaComboBox
        '
        Me.Estado_EntregaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_SolicitudBindingSource, "Estado_Entrega", True))
        Me.Estado_EntregaComboBox.FormattingEnabled = True
        Me.Estado_EntregaComboBox.Location = New System.Drawing.Point(337, 118)
        Me.Estado_EntregaComboBox.Name = "Estado_EntregaComboBox"
        Me.Estado_EntregaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Estado_EntregaComboBox.TabIndex = 88
        '
        'DetalleSolucitud_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(669, 560)
        Me.Controls.Add(Estado_EntregaLabel)
        Me.Controls.Add(Me.Estado_EntregaComboBox)
        Me.Controls.Add(Me.GroupBoxOpciones_p)
        Me.Controls.Add(Me.Detalle_SolicitudDataGridView)
        Me.Controls.Add(Me.Detalle_SolicitudBindingNavigator)
        Me.Controls.Add(Me.Label_Inventario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "DetalleSolucitud_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalle_SolicitudBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalle_SolicitudBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Detalle_SolicitudBindingNavigator.ResumeLayout(False)
        Me.Detalle_SolicitudBindingNavigator.PerformLayout()
        CType(Me.Detalle_SolicitudDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxOpciones_p.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Inventario As Label
    Friend WithEvents _Inv_Bodegas_DataSet As _Inv_Bodegas_DataSet
    Friend WithEvents Detalle_SolicitudBindingSource As BindingSource
    Friend WithEvents Detalle_SolicitudTableAdapter As _Inv_Bodegas_DataSetTableAdapters.Detalle_SolicitudTableAdapter
    Friend WithEvents TableAdapterManager As _Inv_Bodegas_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Detalle_SolicitudBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Detalle_SolicitudBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Detalle_SolicitudDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBoxOpciones_p As GroupBox
    Friend WithEvents Salir_Button As Button
    Friend WithEvents Estado_EntregaComboBox As ComboBox
End Class

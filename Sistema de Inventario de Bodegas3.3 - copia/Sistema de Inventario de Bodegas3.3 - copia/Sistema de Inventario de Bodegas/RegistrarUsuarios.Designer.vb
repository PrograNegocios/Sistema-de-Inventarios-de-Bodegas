<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarUsuarios_Form
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim ConfirmarLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarUsuarios_Form))
        Me.Agregar_Button_Usuarios = New System.Windows.Forms.Button()
        Me.Exit_Botton = New System.Windows.Forms.Button()
        Me.TitleLogin_Panel = New System.Windows.Forms.Panel()
        Me.Logo_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Login_Panel = New System.Windows.Forms.Panel()
        Me._Inv_Bodegas_DataSet = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmarTextBox = New System.Windows.Forms.TextBox()
        Me.Guardar_Button_Requisicion = New System.Windows.Forms.Button()
        NombreLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        ConfirmarLabel = New System.Windows.Forms.Label()
        Me.TitleLogin_Panel.SuspendLayout()
        CType(Me.Logo_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(67, 124)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 46
        NombreLabel.Text = "Nombre:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Location = New System.Drawing.Point(66, 167)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(64, 13)
        ContraseñaLabel.TabIndex = 47
        ContraseñaLabel.Text = "Contraseña:"
        '
        'ConfirmarLabel
        '
        ConfirmarLabel.AutoSize = True
        ConfirmarLabel.Location = New System.Drawing.Point(67, 210)
        ConfirmarLabel.Name = "ConfirmarLabel"
        ConfirmarLabel.Size = New System.Drawing.Size(54, 13)
        ConfirmarLabel.TabIndex = 48
        ConfirmarLabel.Text = "Confirmar:"
        '
        'Agregar_Button_Usuarios
        '
        Me.Agregar_Button_Usuarios.BackColor = System.Drawing.Color.PowderBlue
        Me.Agregar_Button_Usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Agregar_Button_Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Agregar_Button_Usuarios.ImageKey = "(ninguno)"
        Me.Agregar_Button_Usuarios.Location = New System.Drawing.Point(46, 243)
        Me.Agregar_Button_Usuarios.Name = "Agregar_Button_Usuarios"
        Me.Agregar_Button_Usuarios.Size = New System.Drawing.Size(87, 33)
        Me.Agregar_Button_Usuarios.TabIndex = 45
        Me.Agregar_Button_Usuarios.Text = "Ingresar"
        Me.Agregar_Button_Usuarios.UseVisualStyleBackColor = False
        '
        'Exit_Botton
        '
        Me.Exit_Botton.BackColor = System.Drawing.Color.PowderBlue
        Me.Exit_Botton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Botton.Location = New System.Drawing.Point(213, 243)
        Me.Exit_Botton.Name = "Exit_Botton"
        Me.Exit_Botton.Size = New System.Drawing.Size(70, 33)
        Me.Exit_Botton.TabIndex = 38
        Me.Exit_Botton.Text = "Salir"
        Me.Exit_Botton.UseVisualStyleBackColor = False
        '
        'TitleLogin_Panel
        '
        Me.TitleLogin_Panel.BackColor = System.Drawing.SystemColors.Desktop
        Me.TitleLogin_Panel.Controls.Add(Me.Logo_PictureBox)
        Me.TitleLogin_Panel.Controls.Add(Me.Label3)
        Me.TitleLogin_Panel.Location = New System.Drawing.Point(0, 52)
        Me.TitleLogin_Panel.Name = "TitleLogin_Panel"
        Me.TitleLogin_Panel.Size = New System.Drawing.Size(315, 46)
        Me.TitleLogin_Panel.TabIndex = 37
        '
        'Logo_PictureBox
        '
        Me.Logo_PictureBox.ErrorImage = Nothing
        Me.Logo_PictureBox.Image = CType(resources.GetObject("Logo_PictureBox.Image"), System.Drawing.Image)
        Me.Logo_PictureBox.Location = New System.Drawing.Point(252, -1)
        Me.Logo_PictureBox.Name = "Logo_PictureBox"
        Me.Logo_PictureBox.Size = New System.Drawing.Size(63, 55)
        Me.Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo_PictureBox.TabIndex = 12
        Me.Logo_PictureBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(10, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "REGISTRARSE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Login_Panel
        '
        Me.Login_Panel.BackColor = System.Drawing.Color.DarkCyan
        Me.Login_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Login_Panel.Name = "Login_Panel"
        Me.Login_Panel.Size = New System.Drawing.Size(371, 46)
        Me.Login_Panel.TabIndex = 36
        '
        '_Inv_Bodegas_DataSet
        '
        Me._Inv_Bodegas_DataSet.DataSetName = "Inv-Bodegas_DataSet"
        Me._Inv_Bodegas_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me._Inv_Bodegas_DataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BodegaTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_SalidasTableAdapter = Nothing
        Me.TableAdapterManager.EntradasTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.RequisiciónTableAdapter = Nothing
        Me.TableAdapterManager.SalidasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(136, 124)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 47
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Contraseña", True))
        Me.ContraseñaTextBox.Enabled = False
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(136, 164)
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContraseñaTextBox.TabIndex = 48
        '
        'ConfirmarTextBox
        '
        Me.ConfirmarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Confirmar", True))
        Me.ConfirmarTextBox.Enabled = False
        Me.ConfirmarTextBox.Location = New System.Drawing.Point(136, 207)
        Me.ConfirmarTextBox.Name = "ConfirmarTextBox"
        Me.ConfirmarTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmarTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ConfirmarTextBox.TabIndex = 49
        '
        'Guardar_Button_Requisicion
        '
        Me.Guardar_Button_Requisicion.BackColor = System.Drawing.Color.PowderBlue
        Me.Guardar_Button_Requisicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guardar_Button_Requisicion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Guardar_Button_Requisicion.ImageKey = "(ninguno)"
        Me.Guardar_Button_Requisicion.Location = New System.Drawing.Point(133, 243)
        Me.Guardar_Button_Requisicion.Name = "Guardar_Button_Requisicion"
        Me.Guardar_Button_Requisicion.Size = New System.Drawing.Size(80, 33)
        Me.Guardar_Button_Requisicion.TabIndex = 50
        Me.Guardar_Button_Requisicion.Text = "Enviar"
        Me.Guardar_Button_Requisicion.UseVisualStyleBackColor = False
        '
        'RegistrarUsuarios_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(369, 310)
        Me.Controls.Add(Me.Guardar_Button_Requisicion)
        Me.Controls.Add(ConfirmarLabel)
        Me.Controls.Add(Me.ConfirmarTextBox)
        Me.Controls.Add(ContraseñaLabel)
        Me.Controls.Add(Me.ContraseñaTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.Agregar_Button_Usuarios)
        Me.Controls.Add(Me.Exit_Botton)
        Me.Controls.Add(Me.TitleLogin_Panel)
        Me.Controls.Add(Me.Login_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "RegistrarUsuarios_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrarUsuarios"
        Me.TitleLogin_Panel.ResumeLayout(False)
        Me.TitleLogin_Panel.PerformLayout()
        CType(Me.Logo_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Agregar_Button_Usuarios As Button
    Friend WithEvents Exit_Botton As Button
    Friend WithEvents TitleLogin_Panel As Panel
    Friend WithEvents Logo_PictureBox As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Login_Panel As Panel
    Friend WithEvents _Inv_Bodegas_DataSet As _Inv_Bodegas_DataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As _Inv_Bodegas_DataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As _Inv_Bodegas_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ContraseñaTextBox As TextBox
    Friend WithEvents ConfirmarTextBox As TextBox
    Friend WithEvents Guardar_Button_Requisicion As Button
End Class

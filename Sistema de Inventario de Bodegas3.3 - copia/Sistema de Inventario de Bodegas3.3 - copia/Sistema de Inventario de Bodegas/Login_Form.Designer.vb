<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form))
        Me.TitleLogin_Panel = New System.Windows.Forms.Panel()
        Me.Logo_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Login_Panel = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EntrarLogin = New System.Windows.Forms.Button()
        Me.RegistrarseButton = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Inv_Bodegas_DataSet = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSet()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Exit_Botton = New System.Windows.Forms.Button()
        Me.Password_PictureBox = New System.Windows.Forms.PictureBox()
        Me.User_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Login_ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Login_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.UsuariosTableAdapter = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager()
        NombreLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        Me.TitleLogin_Panel.SuspendLayout()
        CType(Me.Logo_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Password_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(119, 42)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 18
        NombreLabel.Text = "Nombre:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Location = New System.Drawing.Point(118, 83)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(64, 13)
        ContraseñaLabel.TabIndex = 19
        ContraseñaLabel.Text = "Contraseña:"
        '
        'TitleLogin_Panel
        '
        Me.TitleLogin_Panel.BackColor = System.Drawing.SystemColors.Desktop
        Me.TitleLogin_Panel.Controls.Add(Me.Logo_PictureBox)
        Me.TitleLogin_Panel.Controls.Add(Me.Label3)
        Me.TitleLogin_Panel.Location = New System.Drawing.Point(0, 56)
        Me.TitleLogin_Panel.Name = "TitleLogin_Panel"
        Me.TitleLogin_Panel.Size = New System.Drawing.Size(421, 46)
        Me.TitleLogin_Panel.TabIndex = 19
        '
        'Logo_PictureBox
        '
        Me.Logo_PictureBox.ErrorImage = Nothing
        Me.Logo_PictureBox.Image = CType(resources.GetObject("Logo_PictureBox.Image"), System.Drawing.Image)
        Me.Logo_PictureBox.Location = New System.Drawing.Point(366, -1)
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
        Me.Label3.Size = New System.Drawing.Size(60, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "LOGIN"
        '
        'Login_Panel
        '
        Me.Login_Panel.BackColor = System.Drawing.Color.DarkCyan
        Me.Login_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Login_Panel.Name = "Login_Panel"
        Me.Login_Panel.Size = New System.Drawing.Size(484, 46)
        Me.Login_Panel.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EntrarLogin)
        Me.GroupBox1.Controls.Add(Me.RegistrarseButton)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(ContraseñaLabel)
        Me.GroupBox1.Controls.Add(Me.ContraseñaTextBox)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(Me.Exit_Botton)
        Me.GroupBox1.Controls.Add(Me.Password_PictureBox)
        Me.GroupBox1.Controls.Add(Me.User_PictureBox)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 183)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'EntrarLogin
        '
        Me.EntrarLogin.BackColor = System.Drawing.Color.PowderBlue
        Me.EntrarLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntrarLogin.Location = New System.Drawing.Point(41, 129)
        Me.EntrarLogin.Name = "EntrarLogin"
        Me.EntrarLogin.Size = New System.Drawing.Size(70, 33)
        Me.EntrarLogin.TabIndex = 22
        Me.EntrarLogin.Text = "Entrar"
        Me.EntrarLogin.UseVisualStyleBackColor = False
        '
        'RegistrarseButton
        '
        Me.RegistrarseButton.BackColor = System.Drawing.Color.PowderBlue
        Me.RegistrarseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrarseButton.Location = New System.Drawing.Point(117, 129)
        Me.RegistrarseButton.Name = "RegistrarseButton"
        Me.RegistrarseButton.Size = New System.Drawing.Size(114, 33)
        Me.RegistrarseButton.TabIndex = 21
        Me.RegistrarseButton.Text = "Registrarse"
        Me.RegistrarseButton.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(119, 103)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(146, 13)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "¿Ha olvidado su contraseña?"
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Contraseña", True))
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(188, 80)
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContraseñaTextBox.TabIndex = 20
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me._Inv_Bodegas_DataSet
        '
        '_Inv_Bodegas_DataSet
        '
        Me._Inv_Bodegas_DataSet.DataSetName = "Inv-Bodegas_DataSet"
        Me._Inv_Bodegas_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(188, 39)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 19
        '
        'Exit_Botton
        '
        Me.Exit_Botton.BackColor = System.Drawing.Color.PowderBlue
        Me.Exit_Botton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Botton.Location = New System.Drawing.Point(237, 129)
        Me.Exit_Botton.Name = "Exit_Botton"
        Me.Exit_Botton.Size = New System.Drawing.Size(70, 33)
        Me.Exit_Botton.TabIndex = 16
        Me.Exit_Botton.Text = "Salir"
        Me.Exit_Botton.UseVisualStyleBackColor = False
        '
        'Password_PictureBox
        '
        Me.Password_PictureBox.Image = CType(resources.GetObject("Password_PictureBox.Image"), System.Drawing.Image)
        Me.Password_PictureBox.Location = New System.Drawing.Point(64, 63)
        Me.Password_PictureBox.Name = "Password_PictureBox"
        Me.Password_PictureBox.Size = New System.Drawing.Size(48, 41)
        Me.Password_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Password_PictureBox.TabIndex = 11
        Me.Password_PictureBox.TabStop = False
        '
        'User_PictureBox
        '
        Me.User_PictureBox.Image = CType(resources.GetObject("User_PictureBox.Image"), System.Drawing.Image)
        Me.User_PictureBox.Location = New System.Drawing.Point(64, 19)
        Me.User_PictureBox.Name = "User_PictureBox"
        Me.User_PictureBox.Size = New System.Drawing.Size(49, 46)
        Me.User_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.User_PictureBox.TabIndex = 10
        Me.User_PictureBox.TabStop = False
        '
        'Login_ProgressBar
        '
        Me.Login_ProgressBar.Location = New System.Drawing.Point(82, 297)
        Me.Login_ProgressBar.Name = "Login_ProgressBar"
        Me.Login_ProgressBar.Size = New System.Drawing.Size(224, 27)
        Me.Login_ProgressBar.TabIndex = 16
        Me.Login_ProgressBar.Visible = False
        '
        'Login_Timer
        '
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
        'Login_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(445, 336)
        Me.Controls.Add(Me.TitleLogin_Panel)
        Me.Controls.Add(Me.Login_Panel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Login_ProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Login_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TitleLogin_Panel.ResumeLayout(False)
        Me.TitleLogin_Panel.PerformLayout()
        CType(Me.Logo_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Password_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleLogin_Panel As Panel
    Friend WithEvents Logo_PictureBox As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Login_Panel As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Password_PictureBox As PictureBox
    Friend WithEvents User_PictureBox As PictureBox
    Friend WithEvents Login_ProgressBar As ProgressBar
    Friend WithEvents Login_Timer As Timer
    Friend WithEvents Exit_Botton As Button
    Friend WithEvents _Inv_Bodegas_DataSet As _Inv_Bodegas_DataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As _Inv_Bodegas_DataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As _Inv_Bodegas_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ContraseñaTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents RegistrarseButton As Button
    Friend WithEvents EntrarLogin As Button
End Class

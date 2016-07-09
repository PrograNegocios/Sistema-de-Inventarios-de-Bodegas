Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Imports System.Linq
Public Class Login_Form
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Dim fu
    Dim eu

    Private Sub Login_Timer_Tick(sender As Object, e As EventArgs) Handles Login_Timer.Tick
        Login_ProgressBar.Increment(5)
        If Login_ProgressBar.Value = 100 Then
            Login_Timer.Enabled = False
            MsgBox("Bienvenido al sistema " & NombreTextBox.Text)
            Me.Hide()
            Menu_Form.Show()
        End If
    End Sub
    Private Sub validacion()
        Try
            cmd = New SqlCommand("SELECT * FROM Usuarios WHERE Nombre='" + NombreTextBox.Text + "'AND Contraseña='" + ContraseñaTextBox.Text + "'", con)
            ' cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Login_ProgressBar.Visible = True
                Login_Timer.Start()

            Else
                MsgBox("Los datos son incorrectos, Registrese o Actualice la Contraseña")
                NombreTextBox.Text = ""
                ContraseñaTextBox.Text = ""
                NombreTextBox.Focus()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub
    Private Sub Exit_Botton_Click(sender As Object, e As EventArgs) Handles Exit_Botton.Click
        Me.Close()
    End Sub
    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Inv_Bodegas_DataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        ' Me.UsuariosTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Usuarios)
        Me.UsuariosBindingSource.ResetBindings(True)
        GroupBox1.Focus()
        NombreTextBox.Focus()
        ' Me.UsuariosBindingNavigatorSaveItem_Click.Refresh()
        con.ConnectionString = My.Settings.Inventario_de_Bodegas_UNICAHConnectionString
        con.Open()


    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)

    End Sub

    Private Sub EntrarLogin_Click(sender As Object, e As EventArgs) Handles EntrarLogin.Click
        validacion()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        IngresarPersonas.Show()
        Me.Close()
    End Sub

    Private Sub RegistrarseButton_Click(sender As Object, e As EventArgs) Handles RegistrarseButton.Click
        RegistrarUsuarios_Form.Show()
        Me.Close()
    End Sub

    Private Sub NombreTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NombreTextBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            ContraseñaTextBox.Focus()

        End If
    End Sub

    Private Sub ContraseñaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContraseñaTextBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            EntrarLogin.PerformClick()
        End If
    End Sub

End Class
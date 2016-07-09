Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Imports System.Linq
Public Class RegistrarUsuarios_Form
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Guardar_Button_Requisicion.Click

        If NombreTextBox.Text = "" And ContraseñaTextBox.Text = "" And ConfirmarTextBox.Text = "" Then
            MsgBox("Los campos se encuentran vacios")
        ElseIf NombreTextBox.Text = Nothing Then
            MsgBox("El Campo Nombre de Usuario no Puede quedar Vacio", vbInformation)
        ElseIf ContraseñaTextBox.Text = Nothing Then
            MsgBox("El Campo Contraseña no Puede quedar Vacio", vbInformation)
        ElseIf ConfirmarTextBox.Text = Nothing Then
            MsgBox("El Campo Confirmar no Puede quedar Vacio", vbInformation)
        Else
            If (ContraseñaTextBox.Text = ConfirmarTextBox.Text) Then
                MsgBox("Los datos se guardaron exitosamente", vbInformation)
                Me.Validate()
                Me.UsuariosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)
                Login_Form.Show()
                Me.Close()
            Else
                MsgBox("Login Incorrecto")
                NombreTextBox.Text = ""
                ContraseñaTextBox.Text = ""
                ConfirmarTextBox.Text = ""
                NombreTextBox.Focus()
            End If
        End If

    End Sub

    Private Sub RegistrarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Inv_Bodegas_DataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        'Me.UsuariosTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Usuarios)
        Me.UsuariosBindingSource.ResetBindings(True)
        ' Me.UsuariosBindingNavigatorSaveItem_Click.Refresh()
        con.ConnectionString = My.Settings.Inventario_de_Bodegas_UNICAHConnectionString
        con.Open()
    End Sub

    Private Sub Agregar_Button_Usuarios_Click(sender As Object, e As EventArgs) Handles Agregar_Button_Usuarios.Click
        UsuariosBindingSource.AddNew()
        NombreTextBox.Enabled = True
        ContraseñaTextBox.Enabled = True
        ConfirmarTextBox.Enabled = True
        NombreTextBox.Focus()
    End Sub

    Private Sub Exit_Botton_Click(sender As Object, e As EventArgs) Handles Exit_Botton.Click
        Me.Close()
    End Sub
End Class
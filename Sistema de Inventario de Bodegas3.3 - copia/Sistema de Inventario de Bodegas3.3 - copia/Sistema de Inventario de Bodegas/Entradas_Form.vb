Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Imports System.Linq

Public Class Entradas_Form
    Public con As New SqlConnection
    Public cmd As New SqlCommand

    Private Sub Entradas_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the '_Inv_Bodegas_DataSet.Entradas' table. You can move, or remove it, as needed.
        Me.EntradasTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Entradas)
        con.ConnectionString = My.Settings.Inventario_de_Bodegas_UNICAHConnectionString
        con.Open()

    End Sub

    Private Sub autogenerate_id()
        Try

            cmd = New SqlCommand("SELECT MAX(IdEntradas)FROM Entradas", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read = True Then
                Me.IdEntradasTextBox.Text = dr.Item(0) + 1
                EntradasDataGridView.Item(0, EntradasDataGridView.CurrentRow.Index).Value = IdEntradasTextBox.Text
            Else
                Exit Sub

            End If
            'dr.Close()
            'con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Guardar_Button_Entradas_Click(sender As Object, e As EventArgs) Handles Guardar_Button_Entradas.Click

        Dim date1 As Date = Date.Now
        If IdEntradasTextBox.Text = Nothing Then
            MsgBox("El Campo IdEntradas no Puede quedar Vacio", vbInformation)
        ElseIf NombreProductoTextBox.Text = Nothing Then
            MsgBox("El Campo NombreProducto no Puede quedar Vacio", vbInformation)
        ElseIf CantidadTextBox.Text = Nothing Then
            MsgBox("El Campo Cantidad no Puede quedar Vacio", vbInformation)
        ElseIf DescripciónTextBox.Text = Nothing Then
            MsgBox("El Campo Descripción no Puede quedar Vacio", vbInformation)

        ElseIf (EntradasDataGridView.Rows.Count > 0) Then
            If (FechaDateTimePicker.Checked = True) Then
                If (FechaDateTimePicker.Value <= date1) Then
                    MsgBox("Los datos se guardaron exitosamente", vbInformation)
                    Cancelar_Operacion.Visible = True
                    Agregar_Button_Entradas.Enabled = True
                    Me.Validate()
                    Me.EntradasBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)
                    EntradasDataGridView.Refresh()

                Else
                    MsgBox("Debe seleccionar una fecha menor", vbInformation)
                End If
            Else
                MsgBox("El Campo Fecha no Puede quedar Vacio", vbInformation)
            End If
        Else
            MsgBox("No existen Valores", vbInformation)

        End If
    End Sub

    Private Sub Agregar_Button_Entradas_Click(sender As Object, e As EventArgs) Handles Agregar_Button_Entradas.Click

        EntradasBindingSource.AddNew()
        Agregar_Button_Entradas.Enabled = False
        Eliminar_Button_Entradas.Enabled = False
        IdEntradasTextBox.Focus()

        Guardar_Button_Entradas.Enabled = True
        Cancelar_Operacion.Visible = True
        Eliminar_Button_Entradas.Enabled = True

        'BuscarTextBox.Enabled = True
        'BuscarButton.Enabled = True
        IdEntradasTextBox.Enabled = False
        NombreProductoTextBox.Enabled = True
        FechaDateTimePicker.Enabled = True
        CantidadTextBox.Enabled = True
        DescripciónTextBox.Enabled = True
        UsuarioTextBox.Enabled = True
        NombreProductoTextBox.Focus()
        ' RequisiciónDataGridView.Enabled = True
        FechaDateTimePicker.Text = Date.Today 'Importante para q quede la fecha actual

        autogenerate_id()
    End Sub

    Private Sub Eliminar_Button_Entradas_Click(sender As Object, e As EventArgs) Handles Eliminar_Button_Entradas.Click

        Me.Validate()
        EntradasBindingSource.RemoveCurrent()
        MsgBox("Los datos se eliminaron correctamente", vbExclamation)
        EntradasDataGridView.Refresh()
        Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)

    End Sub

    Private Sub Cancelar_Operacion_Click(sender As Object, e As EventArgs) 

        IdEntradasTextBox.Enabled = False
        NombreProductoTextBox.Enabled = False
        FechaDateTimePicker.Enabled = False
        CantidadTextBox.Enabled = False
        DescripciónTextBox.Enabled = False

        Guardar_Button_Entradas.Visible = True
        Agregar_Button_Entradas.Visible = True
        Eliminar_Button_Entradas.Visible = True
        Cancelar_Operacion.Visible = True

        IdEntradasTextBox.Enabled = ""
        NombreProductoTextBox.Enabled = ""
        FechaDateTimePicker.Enabled = ""
        CantidadTextBox.Enabled = ""
        DescripciónTextBox.Enabled = ""
        Agregar_Button_Entradas.Enabled = ""

        Me.Validate()
        EntradasBindingSource.RemoveCurrent()
        EntradasDataGridView.Refresh()
        Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)

    End Sub

    Private Sub Salir_Button_Click(sender As Object, e As EventArgs) Handles Salir_Button.Click
        Me.Close()
        Menu_Form.Show()
    End Sub

    Private Sub Cancelar_Operacion_Click_1(sender As Object, e As EventArgs) Handles Cancelar_Operacion.Click
        IdEntradasTextBox.Enabled = False
        NombreProductoTextBox.Enabled = False
        FechaDateTimePicker.Enabled = False
        CantidadTextBox.Enabled = False
        DescripciónTextBox.Enabled = False
        UsuarioTextBox.Enabled = False

        Guardar_Button_Entradas.Enabled = False

        Agregar_Button_Entradas.Enabled = True
        Eliminar_Button_Entradas.Enabled = True

        IdEntradasTextBox.Text = ""
        NombreProductoTextBox.Text = ""
        FechaDateTimePicker.Text = ""
        CantidadTextBox.Text = ""
        DescripciónTextBox.Text = ""
        UsuarioTextBox.Text = ""

        Me.Validate()
        EntradasBindingSource.RemoveCurrent()
        EntradasDataGridView.Refresh()
        Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)
    End Sub
End Class
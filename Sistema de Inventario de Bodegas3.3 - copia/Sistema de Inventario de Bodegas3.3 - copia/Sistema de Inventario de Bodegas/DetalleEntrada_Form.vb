Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Imports System.Linq
Public Class DetalleEntrada_Form
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Private Sub Detalle_EntradasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Detalle_EntradasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)

    End Sub

    Private Sub DetalleEntrada_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Inv_Bodegas_DataSet.Detalle_Entradas' Puede moverla o quitarla según sea necesario.
        Me.Detalle_EntradasTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Detalle_Entradas)
        con.ConnectionString = My.Settings.Inventario_de_Bodegas_UNICAHConnectionString
        con.Open()

    End Sub

    Private Sub Agregar_Button_DetalleEntrada_Click(sender As Object, e As EventArgs) Handles Agregar_Button_DetalleEntrada.Click
        Detalle_EntradasBindingSource.AddNew()
        Agregar_Button_DetalleEntrada.Enabled = False
        Eliminar_Button_DetalleEntrada.Enabled = False
        IdInventarioComboBox.Focus()

        Guardar_Button_DetalleEntrada.Enabled = True
        Cancelar_Operacion.Visible = True
        'BuscarTextBox.Enabled = True
        'BuscarButton.Enabled = True
        IdInventarioComboBox.Enabled = True
        IdEntradasTextBox.Enabled = True
        CantidadTextBox.Enabled = True
    End Sub

    Private Sub Salir_Button_Click(sender As Object, e As EventArgs) Handles Salir_Button.Click
        Me.Close()
        Menu_Form.Show()
    End Sub

    Private Sub Eliminar_Button_DetalleEntrada_Click(sender As Object, e As EventArgs) Handles Eliminar_Button_DetalleEntrada.Click
        If MsgBox("Desea Eliminar el registro Seleccionado", vbYesNo) = MsgBoxResult.Yes Then

            Me.Validate()
            Detalle_EntradasBindingSource.RemoveCurrent()
            MsgBox("Los datos se eliminaron correctamente", vbExclamation)
            Detalle_EntradasDataGridView.Refresh()
            Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)
        End If
    End Sub
    Private Sub DetalleEntradasBindingNavigatorSaveItem(sender As Object, e As EventArgs) Handles Guardar_Button_DetalleEntrada.Click
        If IdInventarioComboBox.Text = Nothing Then
            MsgBox("El Campo IdInventario no Puede quedar Vacio", vbInformation)
        ElseIf IdEntradasTextBox.Text = Nothing Then
            MsgBox("El Campo IdEntradas no Puede quedar Vacio", vbInformation)

        ElseIf (Detalle_EntradasDataGridView.Rows.Count > 0) Then

            MsgBox("Los datos se guardaron exitosamente", vbInformation)
            Agregar_Button_DetalleEntrada.Enabled = True
            Me.Validate()
            Me.Detalle_EntradasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet) 'error
            Detalle_EntradasDataGridView.Refresh()
            'IdRequisiciónTextBox.Text = "" Me borra la linea anterior
            '' FechaDateTimePicker.Enabled = False
            'ObservaciónTextBox.Text = ""
            'CantidadTextBox.Text = ""


        Else
            MsgBox("No existen Valores", vbInformation)

        End If
    End Sub

    Private Sub Cancelar_Operacion_Click(sender As Object, e As EventArgs) Handles Cancelar_Operacion.Click
        IdEntradasTextBox.Enabled = False
        IdInventarioComboBox.Enabled = False
        CantidadTextBox.Enabled = False

        Guardar_Button_DetalleEntrada.Enabled = False
        Detalle_EntradasDataGridView.Enabled = True
        Agregar_Button_DetalleEntrada.Enabled = True
        Eliminar_Button_DetalleEntrada.Enabled = True

        IdEntradasTextBox.Text = ""
        IdInventarioComboBox.Text = ""
        CantidadTextBox.Text = ""
        'Detalle_SalidasDataGridView.DataSource = Nothing
        'Detalle_SalidasDataGridView.Rows.Clear()

        Me.Validate()
        Detalle_EntradasBindingSource.RemoveCurrent()
        Detalle_EntradasDataGridView.Refresh()
        Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet) 'daba error
    End Sub

End Class
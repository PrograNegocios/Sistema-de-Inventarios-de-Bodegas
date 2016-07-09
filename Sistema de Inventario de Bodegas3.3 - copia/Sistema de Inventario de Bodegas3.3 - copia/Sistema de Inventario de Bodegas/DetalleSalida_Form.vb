Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Imports System.Linq
Public Class DetalleSalida_Form
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Private Sub DetalleSalida_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Inventario_de_Bodega_UNICAHDataSet5.sub_Salidas_sel' Puede moverla o quitarla según sea necesario.
        Me.Sub_Salidas_selTableAdapter.Fill(Me.Inventario_de_Bodega_UNICAHDataSet5.sub_Salidas_sel)
        'TODO: esta línea de código carga datos en la tabla 'Inventario_de_Bodega_UNICAHDataSet4.sub_inventario_sel' Puede moverla o quitarla según sea necesario.
        Me.Sub_inventario_selTableAdapter.Fill(Me.Inventario_de_Bodega_UNICAHDataSet4.sub_inventario_sel)
        'TODO: esta línea de código carga datos en la tabla '_Inv_Bodegas_DataSet.Detalle_Salidas' Puede moverla o quitarla según sea necesario.

        Me.Detalle_SalidasTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Detalle_Salidas)
        Me.Detalle_SalidasBindingSource.ResetBindings(True)
        Me.InventarioBindingNavigator.Refresh()
        con.ConnectionString = My.Settings.Inventario_de_Bodegas_UNICAHConnectionString
        con.Open()

    End Sub

    Private Sub Agregar_Button_DetalleSalidas_Click(sender As Object, e As EventArgs) Handles Agregar_Button_DetalleSalida.Click
        Detalle_SalidasBindingSource.AddNew()
        Agregar_Button_DetalleSalida.Enabled = False
        Eliminar_Button_DetalleSalida.Enabled = False
        IdInventarioComboBox.Focus()

        Guardar_Button_DetalleSalida.Enabled = True
        Cancelar_Operacion.Visible = True
        'BuscarTextBox.Enabled = True
        'BuscarButton.Enabled = True
        IdInventarioComboBox.Enabled = True
        IdSalidasComboBox.Enabled = True
        CantidadTextBox.Enabled = True
        'Detalle_SalidasDataGridView.Enabled = True
    End Sub

    Private Sub Salir_Button_Click(sender As Object, e As EventArgs) Handles Salir_Button.Click
        Me.Close()
        Menu_Form.Show()
    End Sub

    Private Sub Eliminar_DetalleSalidas_Button_Click(sender As Object, e As EventArgs) Handles Eliminar_Button_DetalleSalida.Click
        If MsgBox("Desea Eliminar el registro Seleccionado", vbYesNo) = MsgBoxResult.Yes Then

            Me.Validate()
            Detalle_SalidasBindingSource.RemoveCurrent()
            MsgBox("Los datos se eliminaron correctamente", vbExclamation)
            Detalle_SalidasDataGridView.Refresh()
            Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)

        End If
    End Sub

    Private Sub DetalleSalidasBindingNavigatorSaveItem(sender As Object, e As EventArgs) Handles Guardar_Button_DetalleSalida.Click
        If IdInventarioComboBox.Text = Nothing Then
            MsgBox("El Campo IdInventario no Puede quedar Vacio", vbInformation)
        ElseIf IdSalidasComboBox.Text = Nothing Then
            MsgBox("El Campo IdSalidas no Puede quedar Vacio", vbInformation)

        ElseIf (Detalle_SalidasDataGridView.Rows.Count > 0) Then

            MsgBox("Los datos se guardaron exitosamente", vbInformation)
            Agregar_Button_DetalleSalida.Enabled = True
            Me.Validate()
            Me.Detalle_SalidasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet) 'error
            Detalle_SalidasDataGridView.Refresh()
            'IdRequisiciónTextBox.Text = "" Me borra la linea anterior
            '' FechaDateTimePicker.Enabled = False
            'ObservaciónTextBox.Text = ""
            'CantidadTextBox.Text = ""


        Else
            MsgBox("No existen Valores", vbInformation)

        End If
    End Sub

    Private Sub Cancelar_Operacion_Click(sender As Object, e As EventArgs) Handles Cancelar_Operacion.Click

        IdSalidasComboBox.Enabled = False
        IdInventarioComboBox.Enabled = False
        CantidadTextBox.Enabled = False

        Guardar_Button_DetalleSalida.Enabled = False
        Detalle_SalidasDataGridView.Enabled = True
        Agregar_Button_DetalleSalida.Enabled = True
        Eliminar_Button_DetalleSalida.Enabled = True

        IdSalidasComboBox.Text = ""
        IdInventarioComboBox.Text = ""
        CantidadTextBox.Text = ""
        'Detalle_SalidasDataGridView.DataSource = Nothing
        'Detalle_SalidasDataGridView.Rows.Clear()

        Me.Validate()
        Detalle_SalidasBindingSource.RemoveCurrent()
        Detalle_SalidasDataGridView.Refresh()
        Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet) 'daba error

    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        Me.Detalle_SalidasTableAdapter.FillBy(Me._Inv_Bodegas_DataSet.Detalle_Salidas, BuscarTextBox.Text)
        BuscarTextBox.Text = ""
        BuscarTextBox.Focus()
    End Sub
End Class
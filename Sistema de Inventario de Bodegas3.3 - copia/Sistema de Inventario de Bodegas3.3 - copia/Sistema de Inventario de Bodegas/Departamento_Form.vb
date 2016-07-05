Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Imports System.Linq
Public Class Departamento_Form
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Private Sub Departamento_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Inv_Bodegas_DataSet.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Departamento)
        Me.DepartamentoBindingSource.ResetBindings(True)
        Me.InventarioBindingNavigator.Refresh()
        con.ConnectionString = My.Settings.Inventario_de_Bodegas_UNICAHConnectionString
        con.Open()
    End Sub

    Private Sub Agregar_Button_Depto_Click(sender As Object, e As EventArgs) Handles Agregar_Button_Depto.Click
        DepartamentoBindingSource.AddNew()
        Agregar_Button_Depto.Enabled = False
        Eliminar_Depto_Button.Enabled = False
        IdDepartamentoTextBox.Focus()

        Guardar_Button_Depto.Enabled = True
        Cancelar_Operacion.Visible = True
        'BuscarTextBox.Enabled = True
        'BuscarButton.Enabled = True
        IdDepartamentoTextBox.Enabled = True
        NombreTextBox.Enabled = True
        EncargadoTextBox.Enabled = True

        'DeptoDataGridView.Enabled = True
    End Sub

    Private Sub Salir_Button_Click(sender As Object, e As EventArgs) Handles Salir_Button.Click
        Me.Close()
        Menu_Form.Show()
    End Sub

    Private Sub Eliminar_Depto_Button_Click(sender As Object, e As EventArgs) Handles Eliminar_Depto_Button.Click
        If MsgBox("Desea Eliminar el registro Seleccionado", vbYesNo) = MsgBoxResult.Yes Then

            Me.Validate()
            DepartamentoBindingSource.RemoveCurrent()
            MsgBox("Los datos se eliminaron correctamente", vbExclamation)
            DeptoDataGridView.Refresh()
            Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)

        End If
    End Sub

    Private Sub DeptoBindingNavigatorSaveItem(sender As Object, e As EventArgs) Handles Guardar_Button_Depto.Click

        If IdDepartamentoTextBox.Text = Nothing Then
            MsgBox("El Campo IdDepartamento no Puede quedar Vacio", vbInformation)
        ElseIf NombreTextBox.Text = Nothing Then
            MsgBox("El Campo Nombre no Puede quedar Vacio", vbInformation)
        ElseIf EncargadoTextBox.Text = Nothing Then
            MsgBox("El Campo Encargado Puede quedar Vacio", vbInformation)

        ElseIf (DeptoDataGridView.Rows.Count > 0) Then

            MsgBox("Los datos se guardaron exitosamente", vbInformation)
            Agregar_Button_Depto.Enabled = True
            Me.Validate()
            Me.DepartamentoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)
            DeptoDataGridView.Refresh()
            'IdRequisiciónTextBox.Text = "" Me borra la linea anterior
            '' FechaDateTimePicker.Enabled = False
            'ObservaciónTextBox.Text = ""
            'CantidadTextBox.Text = ""


        Else
            MsgBox("No existen Valores", vbInformation)

        End If
    End Sub

    Private Sub Cancelar_Operacion_Click(sender As Object, e As EventArgs) Handles Cancelar_Operacion.Click

        IdDepartamentoTextBox.Enabled = False
        NombreTextBox.Enabled = False
        EncargadoTextBox.Enabled = False

        DeptoDataGridView.Enabled = True
        Guardar_Button_Depto.Enabled = False
        Agregar_Button_Depto.Enabled = True
        Eliminar_Depto_Button.Enabled = True

        IdDepartamentoTextBox.Text = ""
        NombreTextBox.Text = ""
        EncargadoTextBox.Text = ""

        Me.Validate()
        DepartamentoBindingSource.RemoveCurrent()
        DeptoDataGridView.Refresh()
        Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        Me.DepartamentoTableAdapter.FillBy(Me._Inv_Bodegas_DataSet.Departamento, BuscarTextBox.Text)
        BuscarTextBox.Text = ""
        BuscarTextBox.Focus()
    End Sub
End Class
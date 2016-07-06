Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Imports System.Linq

Public Class Requisicion
    Public con As New SqlConnection
    Public cmd As New SqlCommand



    Private Sub Requisicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'Inventario_de_Bodega_UNICAHDataSet3.sub_departamentos_sel' Puede moverla o quitarla según sea necesario.
        Me.Sub_departamentos_selTableAdapter.Fill(Me.Inventario_de_Bodega_UNICAHDataSet3.sub_departamentos_sel)
        'TODO: esta línea de código carga datos en la tabla 'Inventario_de_Bodega_UNICAHDataSet2.sub_departamentos_sel' Puede moverla o quitarla según sea necesario.
        'Me.Sub_departamentos_selTableAdapter.Fill(Me.Inventario_de_Bodega_UNICAHDataSet2.sub_departamentos_sel)
        'TODO: esta línea de código carga datos en la tabla 'Inventario_de_Bodega_UNICAHDataSet1.sub_NombreProducto_sel' Puede moverla o quitarla según sea necesario.
        Me.Sub_NombreProducto_selTableAdapter.Fill(Me.Inventario_de_Bodega_UNICAHDataSet1.sub_NombreProducto_sel)
        'TODO: esta línea de código carga datos en la tabla '_Inv_Bodegas_DataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Producto)
        Me.RequisiciónTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Requisición)
        Me.RequisicionBindingSource.ResetBindings(True)
        Me.InventarioBindingNavigator.Refresh()
        con.ConnectionString = My.Settings.Inventario_de_Bodegas_UNICAHConnectionString
        con.Open()

    End Sub
    Private Sub autogenerate_id()
        Try

            cmd = New SqlCommand("SELECT MAX(IdRequisición)FROM Requisición", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read = True Then
                Me.IdRequisiciónTextBox.Text = dr.Item(0) + 1
                RequisiciónDataGridView.Item(0, RequisiciónDataGridView.CurrentRow.Index).Value = IdRequisiciónTextBox.Text
            Else
                Exit Sub

            End If
            'dr.Close()
            'con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cancelar_Operacion_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Agregar_Button_Requisicion_Click(sender As Object, e As EventArgs) Handles Agregar_Button_Requisicion.Click


        RequisicionBindingSource.AddNew()
        Agregar_Button_Requisicion.Enabled = False
        Eliminar_Requisicion_Button.Enabled = False
        IdRequisiciónTextBox.Focus()

        Guardar_Button_Requisicion.Enabled = True
        Cancelar_Operacion.Visible = True
        'BuscarTextBox.Enabled = True
        'BuscarButton.Enabled = True
        IdRequisiciónTextBox.Enabled = True
        IdDepartamentoComboBox.Enabled = True
        FechaDateTimePicker.Enabled = True
        ObservaciónTextBox.Enabled = True
        NombreProductoComboBox.Enabled = True
        CantidadTextBox.Enabled = True
        ' RequisiciónDataGridView.Enabled = True
        FechaDateTimePicker.Text = Date.Today 'Importante para q quede la fecha actual

        autogenerate_id()

    End Sub

    Private Sub Salir_Button_Click(sender As Object, e As EventArgs) Handles Salir_Button.Click
        Me.Close()
        Menu_Form.Show()
    End Sub

    Private Sub Eliminar_Requisicion_Button_Click(sender As Object, e As EventArgs) Handles Eliminar_Requisicion_Button.Click
        If MsgBox("Desea Eliminar el registro Seleccionado", vbYesNo) = MsgBoxResult.Yes Then

            Me.Validate()
            RequisicionBindingSource.RemoveCurrent()
            MsgBox("Los datos se eliminaron correctamente", vbExclamation)
            RequisiciónDataGridView.Refresh()
            Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)

        End If
    End Sub

    Private Sub RequisicionBindingNavigatorSaveItem(sender As Object, e As EventArgs) Handles Guardar_Button_Requisicion.Click

        Dim date1 As Date = Date.Now
        If IdRequisiciónTextBox.Text = Nothing Then
            MsgBox("El Campo IdRequisicion no Puede quedar Vacio", vbInformation)
        ElseIf IdDepartamentoComboBox.Text = Nothing Then
            MsgBox("El Campo IdDepartamento no Puede quedar Vacio", vbInformation)
        ElseIf NombreProductoComboBox.Text = Nothing Then
            MsgBox("El Campo NombreProducto no Puede quedar Vacio", vbInformation)
        ElseIf ObservaciónTextBox.Text = Nothing Then
            MsgBox("El Campo Observacion no Puede quedar Vacio", vbInformation)
        ElseIf CantidadTextBox.Text = Nothing Then
            MsgBox("El Campo Cantidad no Puede quedar Vacio", vbInformation)

        ElseIf (RequisiciónDataGridView.Rows.Count > 0) Then
            If (FechaDateTimePicker.Checked = True) Then
                If (FechaDateTimePicker.Value <= date1) Then
                    MsgBox("Los datos se guardaron exitosamente", vbInformation)
                    Agregar_Button_Requisicion.Enabled = True
                    Me.Validate()
                    Me.RequisicionBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)
                    RequisiciónDataGridView.Refresh()
                    'IdRequisiciónTextBox.Text = "" Me borra la linea anterior
                    '' FechaDateTimePicker.Enabled = False
                    'ObservaciónTextBox.Text = ""
                    'CantidadTextBox.Text = ""

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

    Private Sub FechaDateTimePicker_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cancelar_Operacion_Click_1(sender As Object, e As EventArgs) Handles Cancelar_Operacion.Click
        'BuscarButton.Enabled = False
        IdRequisiciónTextBox.Enabled = False
        IdDepartamentoComboBox.Enabled = False
        FechaDateTimePicker.Enabled = False
        ObservaciónTextBox.Enabled = False
        NombreProductoComboBox.Enabled = False
        CantidadTextBox.Enabled = False

        Guardar_Button_Requisicion.Enabled = False
        RequisiciónDataGridView.Enabled = True
        Agregar_Button_Requisicion.Enabled = True
        Eliminar_Requisicion_Button.Enabled = True

        IdRequisiciónTextBox.Text = ""
        IdDepartamentoComboBox.Text = ""
        FechaDateTimePicker.Text = ""
        ObservaciónTextBox.Text = ""
        NombreProductoComboBox.Text = ""
        CantidadTextBox.Text = ""

        Me.Validate()
        RequisicionBindingSource.RemoveCurrent()
        RequisiciónDataGridView.Refresh()
        Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)
        ' autogenerate_id()
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        Me.RequisiciónTableAdapter.FillBy(Me._Inv_Bodegas_DataSet.Requisición, BuscarTextBox.Text)
        BuscarTextBox.Text = ""
        BuscarTextBox.Focus()
    End Sub
End Class
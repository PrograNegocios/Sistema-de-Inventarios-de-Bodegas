Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Imports System.Linq

Public Class Bodega_Form

    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Private Sub BodegaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BodegaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)

    End Sub

    Private Sub Bodega_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Inv_Bodegas_DataSet.Bodega' Puede moverla o quitarla según sea necesario.
        Me.BodegaTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Bodega)
        con.ConnectionString = My.Settings.Inventario_de_Bodegas_UNICAHConnectionString
        con.Open()


    End Sub
    Private Sub autogenerate_id()
        Try

            cmd = New SqlCommand("SELECT MAX(IdBodega)FROM Bodega", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read = True Then
                Me.IdBodegaTextBox.Text = dr.Item(0) + 1
                BodegaDataGridView.Item(0, BodegaDataGridView.CurrentRow.Index).Value = IdBodegaTextBox.Text
            Else
                Exit Sub

            End If
            'dr.Close()
            'con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Salir_Button_Click(sender As Object, e As EventArgs) Handles Salir_Button.Click
        Me.Close()
        Menu_Form.Show()

    End Sub

    Private Sub Agregar_Button_Bodega_Click(sender As Object, e As EventArgs) Handles Agregar_Button_Bodega.Click
        BodegaBindingSource.AddNew()
        Agregar_Button_Bodega.Enabled = False
        Eliminar_Button_Bodega.Enabled = False
        LocalizaciónTextBox.Focus()

        Guardar_Button_Bodega.Enabled = True
        Cancelar_Operacion.Visible = True
        LocalizaciónTextBox.Enabled = True
        EspecialidadesTextBox.Enabled = True
        BodegaDataGridView.Enabled = False
        'BuscarTextBox.Enabled = True
        'BuscarButton.Enabled = True
        EspecialidadesTextBox.Enabled = True
        LocalizaciónTextBox.Enabled = True


        ' RequisiciónDataGridView.Enabled = True

        autogenerate_id()
    End Sub

    Private Sub Eliminar_Button_Bodega_Click(sender As Object, e As EventArgs) Handles Eliminar_Button_Bodega.Click
        If MsgBox("Desea Eliminar el registro Seleccionado", vbYesNo) = MsgBoxResult.Yes Then

            Me.Validate()
            BodegaBindingSource.RemoveCurrent()
            MsgBox("Los datos se eliminaron correctamente", vbExclamation)
            BodegaDataGridView.Refresh()
            Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)

        End If
    End Sub
    Private Sub RequisicionBindingNavigatorSaveItem(sender As Object, e As EventArgs) Handles Guardar_Button_Bodega.Click

        Dim date1 As Date = Date.Now
        If IdBodegaTextBox.Text = Nothing Then
            MsgBox("El Campo IdBodega no Puede quedar Vacio", vbInformation)
        ElseIf LocalizaciónTextBox.Text = Nothing Then
            MsgBox("El Campo Localización no Puede quedar Vacio", vbInformation)
        ElseIf EspecialidadesTextBox.Text = Nothing Then
            MsgBox("El Campo Especialidades no Puede quedar Vacio", vbInformation)


        ElseIf (BodegaDataGridView.Rows.Count > 0) Then

            MsgBox("Los datos se guardaron exitosamente", vbInformation)
            Agregar_Button_Bodega.Enabled = True
            Cancelar_Operacion.Visible = False
            LocalizaciónTextBox.Enabled = False
            EspecialidadesTextBox.Enabled = False
            Me.Validate()
            Me.BodegaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)
            BodegaDataGridView.Refresh()
            'IdRequisiciónTextBox.Text = "" Me borra la linea anterior
            '' FechaDateTimePicker.Enabled = False
            'ObservaciónTextBox.Text = ""
            'CantidadTextBox.Text = ""
        Else

            MsgBox("No existen Valores", vbInformation)

        End If
    End Sub
    Private Sub Cancelar_Operacion_Click_1(sender As Object, e As EventArgs) Handles Cancelar_Operacion.Click
        'BuscarButton.Enabled = False
        IdBodegaTextBox.Enabled = False
        LocalizaciónTextBox.Enabled = False
        EspecialidadesTextBox.Enabled = False



        BodegaDataGridView.Enabled = True
        Agregar_Button_Bodega.Enabled = True
        Eliminar_Button_Bodega.Enabled = True


        LocalizaciónTextBox.Text = ""
        EspecialidadesTextBox.Text = ""


        Me.Validate()
        BodegaBindingSource.RemoveCurrent()
        BodegaDataGridView.Refresh()
        Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        Me.BodegaTableAdapter.FillBy(Me._Inv_Bodegas_DataSet.Bodega, BuscarTextBox.Text)
        BuscarTextBox.Text = ""
        BuscarTextBox.Focus()
    End Sub
End Class
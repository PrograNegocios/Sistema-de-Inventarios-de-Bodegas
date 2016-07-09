Public Class Salidas_Form
    Private Sub SalidasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SalidasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)

    End Sub

    Private Sub Salidas_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Inv_Bodegas_DataSet.Salidas' Puede moverla o quitarla según sea necesario.
        Me.SalidasTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Salidas)

    End Sub
End Class
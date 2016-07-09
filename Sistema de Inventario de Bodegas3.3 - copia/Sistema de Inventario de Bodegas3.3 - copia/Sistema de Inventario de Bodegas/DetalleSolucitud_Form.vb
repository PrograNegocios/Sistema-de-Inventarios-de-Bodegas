Public Class DetalleSolucitud_Form
    Private Sub DetalleSolucitud_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Inv_Bodegas_DataSet.Detalle_Solicitud' Puede moverla o quitarla según sea necesario.
        Me.Detalle_SolicitudTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Detalle_Solicitud)

    End Sub

    Private Sub Salir_Button_Click(sender As Object, e As EventArgs) Handles Salir_Button.Click
        Me.Close()
        Menu_Form.Show()
    End Sub
End Class
Public Class Rooms

    Private Sub RoomsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
       

    End Sub

    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NyandaSQL.Rooms' table. You can move, or remove it, as needed.
        Me.RoomsTableAdapter.Fill(Me.NyandaSQL.Rooms)
        'TODO: This line of code loads data into the 'NyandaDataSet.Rooms' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub RoomsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles RoomsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RoomsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NyandaSQL)
        MsgBox("Successfully Saved")
    End Sub
End Class
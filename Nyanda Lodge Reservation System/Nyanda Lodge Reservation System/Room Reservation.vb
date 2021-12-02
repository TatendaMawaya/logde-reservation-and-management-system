Public Class Room_Reservation

    Private Sub Room_ReservationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
     

    End Sub

    Private Sub Room_Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NyandaSQL.Room_Reservations' table. You can move, or remove it, as needed.
        Me.Room_ReservationsTableAdapter.Fill(Me.NyandaSQL.Room_Reservations)
        'TODO: This line of code loads data into the 'NyandaDataSet.Room_Reservation' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub Room_ReservationsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Room_ReservationsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Room_ReservationsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NyandaSQL)
        MsgBox("Successfully Saved")
    End Sub
End Class
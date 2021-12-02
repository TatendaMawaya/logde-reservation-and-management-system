Public Class Event_Reservation

    Private Sub Event_ReservationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
      

    End Sub

    Private Sub Event_Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NyandaSQL.Event_Resrvation' table. You can move, or remove it, as needed.
        Me.Event_ResrvationTableAdapter.Fill(Me.NyandaSQL.Event_Resrvation)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub Event_ResrvationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Event_ResrvationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Event_ResrvationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NyandaSQL)
        MsgBox("Successfully Saved")
    End Sub
End Class
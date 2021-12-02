Public Class Inventory_Registration

    Private Sub InventoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
      

    End Sub

    Private Sub Inventory_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NyandaSQL.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.NyandaSQL.Inventory)
        'TODO: This line of code loads data into the 'NyandaDataSet.Inventory' table. You can move, or remove it, as needed.


    End Sub

    Private Sub InventoryBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles InventoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InventoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NyandaSQL)
        MsgBox("Successfully Saved")
    End Sub
End Class
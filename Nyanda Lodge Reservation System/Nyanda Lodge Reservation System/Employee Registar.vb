Public Class Employee_Registar

    Private Sub EmployeesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()


    End Sub

    Private Sub Employee_Registar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NyandaSQL.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.NyandaSQL.Employees)
        'TODO: This line of code loads data into the 'NyandaDataSet.Employees' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub EmployeesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles EmployeesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NyandaSQL)
        MsgBox("Successfully Saved")
    End Sub
End Class
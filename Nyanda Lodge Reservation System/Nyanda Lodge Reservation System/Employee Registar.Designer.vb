<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Registar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee_Registar))
        Dim Employee_IDLabel As System.Windows.Forms.Label
        Dim Full_NameLabel As System.Windows.Forms.Label
        Dim National_IDLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim RoleLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Me.NyandaSQL = New Nyanda_Lodge_Reservation_System.NyandaSQL()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesTableAdapter = New Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.EmployeesTableAdapter()
        Me.TableAdapterManager = New Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.TableAdapterManager()
        Me.EmployeesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.EmployeesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EmployeesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Employee_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.National_IDTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.RoleTextBox = New System.Windows.Forms.TextBox()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Employee_IDLabel = New System.Windows.Forms.Label()
        Full_NameLabel = New System.Windows.Forms.Label()
        National_IDLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        RoleLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        CType(Me.NyandaSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeesBindingNavigator.SuspendLayout()
        CType(Me.EmployeesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NyandaSQL
        '
        Me.NyandaSQL.DataSetName = "NyandaSQL"
        Me.NyandaSQL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.NyandaSQL
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeesTableAdapter = Me.EmployeesTableAdapter
        Me.TableAdapterManager.Event_ResrvationTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.Room_ReservationsTableAdapter = Nothing
        Me.TableAdapterManager.RoomsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeesBindingNavigator
        '
        Me.EmployeesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmployeesBindingNavigator.BindingSource = Me.EmployeesBindingSource
        Me.EmployeesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmployeesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmployeesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.EmployeesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmployeesBindingNavigatorSaveItem})
        Me.EmployeesBindingNavigator.Location = New System.Drawing.Point(9, 237)
        Me.EmployeesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmployeesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmployeesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmployeesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmployeesBindingNavigator.Name = "EmployeesBindingNavigator"
        Me.EmployeesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmployeesBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.EmployeesBindingNavigator.TabIndex = 0
        Me.EmployeesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'EmployeesBindingNavigatorSaveItem
        '
        Me.EmployeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmployeesBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmployeesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmployeesBindingNavigatorSaveItem.Name = "EmployeesBindingNavigatorSaveItem"
        Me.EmployeesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.EmployeesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EmployeesDataGridView
        '
        Me.EmployeesDataGridView.AutoGenerateColumns = False
        Me.EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.EmployeesDataGridView.DataSource = Me.EmployeesBindingSource
        Me.EmployeesDataGridView.Location = New System.Drawing.Point(2, 0)
        Me.EmployeesDataGridView.Name = "EmployeesDataGridView"
        Me.EmployeesDataGridView.Size = New System.Drawing.Size(746, 220)
        Me.EmployeesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Employee ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Employee ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Full Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Full Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "National ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "National ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Phone Number"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Phone Number"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Role"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Role"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Salary"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Salary"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Employee_IDLabel
        '
        Employee_IDLabel.AutoSize = True
        Employee_IDLabel.Location = New System.Drawing.Point(12, 299)
        Employee_IDLabel.Name = "Employee_IDLabel"
        Employee_IDLabel.Size = New System.Drawing.Size(70, 13)
        Employee_IDLabel.TabIndex = 2
        Employee_IDLabel.Text = "Employee ID:"
        '
        'Employee_IDTextBox
        '
        Me.Employee_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Employee ID", True))
        Me.Employee_IDTextBox.Location = New System.Drawing.Point(99, 296)
        Me.Employee_IDTextBox.Name = "Employee_IDTextBox"
        Me.Employee_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Employee_IDTextBox.TabIndex = 3
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.Location = New System.Drawing.Point(12, 325)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(57, 13)
        Full_NameLabel.TabIndex = 4
        Full_NameLabel.Text = "Full Name:"
        '
        'Full_NameTextBox
        '
        Me.Full_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Full Name", True))
        Me.Full_NameTextBox.Location = New System.Drawing.Point(99, 322)
        Me.Full_NameTextBox.Name = "Full_NameTextBox"
        Me.Full_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Full_NameTextBox.TabIndex = 5
        '
        'National_IDLabel
        '
        National_IDLabel.AutoSize = True
        National_IDLabel.Location = New System.Drawing.Point(12, 351)
        National_IDLabel.Name = "National_IDLabel"
        National_IDLabel.Size = New System.Drawing.Size(63, 13)
        National_IDLabel.TabIndex = 6
        National_IDLabel.Text = "National ID:"
        '
        'National_IDTextBox
        '
        Me.National_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "National ID", True))
        Me.National_IDTextBox.Location = New System.Drawing.Point(99, 348)
        Me.National_IDTextBox.Name = "National_IDTextBox"
        Me.National_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.National_IDTextBox.TabIndex = 7
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(12, 377)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 8
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(99, 374)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddressTextBox.TabIndex = 9
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Location = New System.Drawing.Point(292, 299)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(81, 13)
        Phone_NumberLabel.TabIndex = 10
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Phone Number", True))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(379, 296)
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Phone_NumberTextBox.TabIndex = 11
        '
        'RoleLabel
        '
        RoleLabel.AutoSize = True
        RoleLabel.Location = New System.Drawing.Point(292, 325)
        RoleLabel.Name = "RoleLabel"
        RoleLabel.Size = New System.Drawing.Size(32, 13)
        RoleLabel.TabIndex = 12
        RoleLabel.Text = "Role:"
        '
        'RoleTextBox
        '
        Me.RoleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Role", True))
        Me.RoleTextBox.Location = New System.Drawing.Point(379, 322)
        Me.RoleTextBox.Name = "RoleTextBox"
        Me.RoleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RoleTextBox.TabIndex = 13
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Location = New System.Drawing.Point(292, 351)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(39, 13)
        SalaryLabel.TabIndex = 14
        SalaryLabel.Text = "Salary:"
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Salary", True))
        Me.SalaryTextBox.Location = New System.Drawing.Point(379, 348)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SalaryTextBox.TabIndex = 15
        '
        'Employee_Registar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 463)
        Me.ControlBox = False
        Me.Controls.Add(Employee_IDLabel)
        Me.Controls.Add(Me.Employee_IDTextBox)
        Me.Controls.Add(Full_NameLabel)
        Me.Controls.Add(Me.Full_NameTextBox)
        Me.Controls.Add(National_IDLabel)
        Me.Controls.Add(Me.National_IDTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Me.Phone_NumberTextBox)
        Me.Controls.Add(RoleLabel)
        Me.Controls.Add(Me.RoleTextBox)
        Me.Controls.Add(SalaryLabel)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Controls.Add(Me.EmployeesDataGridView)
        Me.Controls.Add(Me.EmployeesBindingNavigator)
        Me.Name = "Employee_Registar"
        CType(Me.NyandaSQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeesBindingNavigator.ResumeLayout(False)
        Me.EmployeesBindingNavigator.PerformLayout()
        CType(Me.EmployeesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NyandaSQL As Nyanda_Lodge_Reservation_System.NyandaSQL
    Friend WithEvents EmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeesTableAdapter As Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.EmployeesTableAdapter
    Friend WithEvents TableAdapterManager As Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.TableAdapterManager
    Friend WithEvents EmployeesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EmployeesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EmployeesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Employee_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Full_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents National_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RoleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalaryTextBox As System.Windows.Forms.TextBox
End Class

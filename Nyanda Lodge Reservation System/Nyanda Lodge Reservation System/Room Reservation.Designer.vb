<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Room_Reservation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Room_Reservation))
        Dim Room_IDLabel As System.Windows.Forms.Label
        Dim Customer_NameLabel As System.Windows.Forms.Label
        Dim National_IDLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim Duration_of_StayLabel As System.Windows.Forms.Label
        Dim Amout_PaidLabel As System.Windows.Forms.Label
        Me.NyandaSQL = New Nyanda_Lodge_Reservation_System.NyandaSQL()
        Me.Room_ReservationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Room_ReservationsTableAdapter = New Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.Room_ReservationsTableAdapter()
        Me.TableAdapterManager = New Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.TableAdapterManager()
        Me.Room_ReservationsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Room_ReservationsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Room_ReservationsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Room_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_NameTextBox = New System.Windows.Forms.TextBox()
        Me.National_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Duration_of_StayTextBox = New System.Windows.Forms.TextBox()
        Me.Amout_PaidTextBox = New System.Windows.Forms.TextBox()
        Room_IDLabel = New System.Windows.Forms.Label()
        Customer_NameLabel = New System.Windows.Forms.Label()
        National_IDLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Duration_of_StayLabel = New System.Windows.Forms.Label()
        Amout_PaidLabel = New System.Windows.Forms.Label()
        CType(Me.NyandaSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Room_ReservationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Room_ReservationsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Room_ReservationsBindingNavigator.SuspendLayout()
        CType(Me.Room_ReservationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NyandaSQL
        '
        Me.NyandaSQL.DataSetName = "NyandaSQL"
        Me.NyandaSQL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Room_ReservationsBindingSource
        '
        Me.Room_ReservationsBindingSource.DataMember = "Room Reservations"
        Me.Room_ReservationsBindingSource.DataSource = Me.NyandaSQL
        '
        'Room_ReservationsTableAdapter
        '
        Me.Room_ReservationsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Event_ResrvationTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.Room_ReservationsTableAdapter = Me.Room_ReservationsTableAdapter
        Me.TableAdapterManager.RoomsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Room_ReservationsBindingNavigator
        '
        Me.Room_ReservationsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Room_ReservationsBindingNavigator.BindingSource = Me.Room_ReservationsBindingSource
        Me.Room_ReservationsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Room_ReservationsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Room_ReservationsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.Room_ReservationsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Room_ReservationsBindingNavigatorSaveItem})
        Me.Room_ReservationsBindingNavigator.Location = New System.Drawing.Point(60, 237)
        Me.Room_ReservationsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Room_ReservationsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Room_ReservationsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Room_ReservationsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Room_ReservationsBindingNavigator.Name = "Room_ReservationsBindingNavigator"
        Me.Room_ReservationsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Room_ReservationsBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.Room_ReservationsBindingNavigator.TabIndex = 0
        Me.Room_ReservationsBindingNavigator.Text = "BindingNavigator1"
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
        'Room_ReservationsBindingNavigatorSaveItem
        '
        Me.Room_ReservationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Room_ReservationsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Room_ReservationsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Room_ReservationsBindingNavigatorSaveItem.Name = "Room_ReservationsBindingNavigatorSaveItem"
        Me.Room_ReservationsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Room_ReservationsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Room_ReservationsDataGridView
        '
        Me.Room_ReservationsDataGridView.AutoGenerateColumns = False
        Me.Room_ReservationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Room_ReservationsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Room_ReservationsDataGridView.DataSource = Me.Room_ReservationsBindingSource
        Me.Room_ReservationsDataGridView.Location = New System.Drawing.Point(0, 2)
        Me.Room_ReservationsDataGridView.Name = "Room_ReservationsDataGridView"
        Me.Room_ReservationsDataGridView.Size = New System.Drawing.Size(649, 220)
        Me.Room_ReservationsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Room ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Room ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Customer Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer Name"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Phone Number"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Phone Number"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Duration of Stay"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Duration of Stay"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Amout Paid"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Amout Paid"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Room_IDLabel
        '
        Room_IDLabel.AutoSize = True
        Room_IDLabel.Location = New System.Drawing.Point(24, 281)
        Room_IDLabel.Name = "Room_IDLabel"
        Room_IDLabel.Size = New System.Drawing.Size(52, 13)
        Room_IDLabel.TabIndex = 2
        Room_IDLabel.Text = "Room ID:"
        '
        'Room_IDTextBox
        '
        Me.Room_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Room_ReservationsBindingSource, "Room ID", True))
        Me.Room_IDTextBox.Location = New System.Drawing.Point(116, 278)
        Me.Room_IDTextBox.Name = "Room_IDTextBox"
        Me.Room_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Room_IDTextBox.TabIndex = 3
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Location = New System.Drawing.Point(24, 307)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.Size = New System.Drawing.Size(85, 13)
        Customer_NameLabel.TabIndex = 4
        Customer_NameLabel.Text = "Customer Name:"
        '
        'Customer_NameTextBox
        '
        Me.Customer_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Room_ReservationsBindingSource, "Customer Name", True))
        Me.Customer_NameTextBox.Location = New System.Drawing.Point(116, 304)
        Me.Customer_NameTextBox.Name = "Customer_NameTextBox"
        Me.Customer_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Customer_NameTextBox.TabIndex = 5
        '
        'National_IDLabel
        '
        National_IDLabel.AutoSize = True
        National_IDLabel.Location = New System.Drawing.Point(24, 333)
        National_IDLabel.Name = "National_IDLabel"
        National_IDLabel.Size = New System.Drawing.Size(63, 13)
        National_IDLabel.TabIndex = 6
        National_IDLabel.Text = "National ID:"
        '
        'National_IDTextBox
        '
        Me.National_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Room_ReservationsBindingSource, "National ID", True))
        Me.National_IDTextBox.Location = New System.Drawing.Point(116, 330)
        Me.National_IDTextBox.Name = "National_IDTextBox"
        Me.National_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.National_IDTextBox.TabIndex = 7
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Location = New System.Drawing.Point(24, 359)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(81, 13)
        Phone_NumberLabel.TabIndex = 8
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Room_ReservationsBindingSource, "Phone Number", True))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(116, 356)
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Phone_NumberTextBox.TabIndex = 9
        '
        'Duration_of_StayLabel
        '
        Duration_of_StayLabel.AutoSize = True
        Duration_of_StayLabel.Location = New System.Drawing.Point(24, 385)
        Duration_of_StayLabel.Name = "Duration_of_StayLabel"
        Duration_of_StayLabel.Size = New System.Drawing.Size(86, 13)
        Duration_of_StayLabel.TabIndex = 10
        Duration_of_StayLabel.Text = "Duration of Stay:"
        '
        'Duration_of_StayTextBox
        '
        Me.Duration_of_StayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Room_ReservationsBindingSource, "Duration of Stay", True))
        Me.Duration_of_StayTextBox.Location = New System.Drawing.Point(116, 382)
        Me.Duration_of_StayTextBox.Name = "Duration_of_StayTextBox"
        Me.Duration_of_StayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Duration_of_StayTextBox.TabIndex = 11
        '
        'Amout_PaidLabel
        '
        Amout_PaidLabel.AutoSize = True
        Amout_PaidLabel.Location = New System.Drawing.Point(24, 411)
        Amout_PaidLabel.Name = "Amout_PaidLabel"
        Amout_PaidLabel.Size = New System.Drawing.Size(64, 13)
        Amout_PaidLabel.TabIndex = 12
        Amout_PaidLabel.Text = "Amout Paid:"
        '
        'Amout_PaidTextBox
        '
        Me.Amout_PaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Room_ReservationsBindingSource, "Amout Paid", True))
        Me.Amout_PaidTextBox.Location = New System.Drawing.Point(116, 408)
        Me.Amout_PaidTextBox.Name = "Amout_PaidTextBox"
        Me.Amout_PaidTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Amout_PaidTextBox.TabIndex = 13
        '
        'Room_Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 467)
        Me.ControlBox = False
        Me.Controls.Add(Room_IDLabel)
        Me.Controls.Add(Me.Room_IDTextBox)
        Me.Controls.Add(Customer_NameLabel)
        Me.Controls.Add(Me.Customer_NameTextBox)
        Me.Controls.Add(National_IDLabel)
        Me.Controls.Add(Me.National_IDTextBox)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Me.Phone_NumberTextBox)
        Me.Controls.Add(Duration_of_StayLabel)
        Me.Controls.Add(Me.Duration_of_StayTextBox)
        Me.Controls.Add(Amout_PaidLabel)
        Me.Controls.Add(Me.Amout_PaidTextBox)
        Me.Controls.Add(Me.Room_ReservationsDataGridView)
        Me.Controls.Add(Me.Room_ReservationsBindingNavigator)
        Me.Name = "Room_Reservation"
        CType(Me.NyandaSQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Room_ReservationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Room_ReservationsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Room_ReservationsBindingNavigator.ResumeLayout(False)
        Me.Room_ReservationsBindingNavigator.PerformLayout()
        CType(Me.Room_ReservationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NyandaSQL As Nyanda_Lodge_Reservation_System.NyandaSQL
    Friend WithEvents Room_ReservationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Room_ReservationsTableAdapter As Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.Room_ReservationsTableAdapter
    Friend WithEvents TableAdapterManager As Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.TableAdapterManager
    Friend WithEvents Room_ReservationsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Room_ReservationsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Room_ReservationsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Room_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Customer_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents National_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Duration_of_StayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Amout_PaidTextBox As System.Windows.Forms.TextBox
End Class

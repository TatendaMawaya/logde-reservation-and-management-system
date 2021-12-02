<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Event_Reservation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Event_Reservation))
        Dim Event_IDLabel As System.Windows.Forms.Label
        Dim Event_NameLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Customer_NameLabel As System.Windows.Forms.Label
        Dim National_IDLabel As System.Windows.Forms.Label
        Dim Amount_PaidLabel As System.Windows.Forms.Label
        Me.NyandaSQL = New Nyanda_Lodge_Reservation_System.NyandaSQL()
        Me.Event_ResrvationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Event_ResrvationTableAdapter = New Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.Event_ResrvationTableAdapter()
        Me.TableAdapterManager = New Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.TableAdapterManager()
        Me.Event_ResrvationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Event_ResrvationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Event_ResrvationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Event_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Event_NameTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Customer_NameTextBox = New System.Windows.Forms.TextBox()
        Me.National_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_PaidTextBox = New System.Windows.Forms.TextBox()
        Event_IDLabel = New System.Windows.Forms.Label()
        Event_NameLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Customer_NameLabel = New System.Windows.Forms.Label()
        National_IDLabel = New System.Windows.Forms.Label()
        Amount_PaidLabel = New System.Windows.Forms.Label()
        CType(Me.NyandaSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_ResrvationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_ResrvationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Event_ResrvationBindingNavigator.SuspendLayout()
        CType(Me.Event_ResrvationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NyandaSQL
        '
        Me.NyandaSQL.DataSetName = "NyandaSQL"
        Me.NyandaSQL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Event_ResrvationBindingSource
        '
        Me.Event_ResrvationBindingSource.DataMember = "Event Resrvation"
        Me.Event_ResrvationBindingSource.DataSource = Me.NyandaSQL
        '
        'Event_ResrvationTableAdapter
        '
        Me.Event_ResrvationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Event_ResrvationTableAdapter = Me.Event_ResrvationTableAdapter
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.Room_ReservationsTableAdapter = Nothing
        Me.TableAdapterManager.RoomsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Event_ResrvationBindingNavigator
        '
        Me.Event_ResrvationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Event_ResrvationBindingNavigator.BindingSource = Me.Event_ResrvationBindingSource
        Me.Event_ResrvationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Event_ResrvationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Event_ResrvationBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.Event_ResrvationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Event_ResrvationBindingNavigatorSaveItem})
        Me.Event_ResrvationBindingNavigator.Location = New System.Drawing.Point(9, 232)
        Me.Event_ResrvationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Event_ResrvationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Event_ResrvationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Event_ResrvationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Event_ResrvationBindingNavigator.Name = "Event_ResrvationBindingNavigator"
        Me.Event_ResrvationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Event_ResrvationBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.Event_ResrvationBindingNavigator.TabIndex = 0
        Me.Event_ResrvationBindingNavigator.Text = "BindingNavigator1"
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
        'Event_ResrvationBindingNavigatorSaveItem
        '
        Me.Event_ResrvationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Event_ResrvationBindingNavigatorSaveItem.Image = CType(resources.GetObject("Event_ResrvationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Event_ResrvationBindingNavigatorSaveItem.Name = "Event_ResrvationBindingNavigatorSaveItem"
        Me.Event_ResrvationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Event_ResrvationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Event_ResrvationDataGridView
        '
        Me.Event_ResrvationDataGridView.AutoGenerateColumns = False
        Me.Event_ResrvationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Event_ResrvationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Event_ResrvationDataGridView.DataSource = Me.Event_ResrvationBindingSource
        Me.Event_ResrvationDataGridView.Location = New System.Drawing.Point(0, -2)
        Me.Event_ResrvationDataGridView.Name = "Event_ResrvationDataGridView"
        Me.Event_ResrvationDataGridView.Size = New System.Drawing.Size(642, 220)
        Me.Event_ResrvationDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Event ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Event ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Event Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Event Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Customer Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Customer Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "National ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "National ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Amount Paid"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Amount Paid"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Event_IDLabel
        '
        Event_IDLabel.AutoSize = True
        Event_IDLabel.Location = New System.Drawing.Point(8, 276)
        Event_IDLabel.Name = "Event_IDLabel"
        Event_IDLabel.Size = New System.Drawing.Size(52, 13)
        Event_IDLabel.TabIndex = 2
        Event_IDLabel.Text = "Event ID:"
        '
        'Event_IDTextBox
        '
        Me.Event_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_ResrvationBindingSource, "Event ID", True))
        Me.Event_IDTextBox.Location = New System.Drawing.Point(99, 273)
        Me.Event_IDTextBox.Name = "Event_IDTextBox"
        Me.Event_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Event_IDTextBox.TabIndex = 3
        '
        'Event_NameLabel
        '
        Event_NameLabel.AutoSize = True
        Event_NameLabel.Location = New System.Drawing.Point(8, 302)
        Event_NameLabel.Name = "Event_NameLabel"
        Event_NameLabel.Size = New System.Drawing.Size(69, 13)
        Event_NameLabel.TabIndex = 4
        Event_NameLabel.Text = "Event Name:"
        '
        'Event_NameTextBox
        '
        Me.Event_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_ResrvationBindingSource, "Event Name", True))
        Me.Event_NameTextBox.Location = New System.Drawing.Point(99, 299)
        Me.Event_NameTextBox.Name = "Event_NameTextBox"
        Me.Event_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Event_NameTextBox.TabIndex = 5
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(8, 329)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 6
        DateLabel.Text = "Date:"
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Event_ResrvationBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(99, 325)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 7
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Location = New System.Drawing.Point(8, 354)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.Size = New System.Drawing.Size(85, 13)
        Customer_NameLabel.TabIndex = 8
        Customer_NameLabel.Text = "Customer Name:"
        '
        'Customer_NameTextBox
        '
        Me.Customer_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_ResrvationBindingSource, "Customer Name", True))
        Me.Customer_NameTextBox.Location = New System.Drawing.Point(99, 351)
        Me.Customer_NameTextBox.Name = "Customer_NameTextBox"
        Me.Customer_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Customer_NameTextBox.TabIndex = 9
        '
        'National_IDLabel
        '
        National_IDLabel.AutoSize = True
        National_IDLabel.Location = New System.Drawing.Point(8, 380)
        National_IDLabel.Name = "National_IDLabel"
        National_IDLabel.Size = New System.Drawing.Size(63, 13)
        National_IDLabel.TabIndex = 10
        National_IDLabel.Text = "National ID:"
        '
        'National_IDTextBox
        '
        Me.National_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_ResrvationBindingSource, "National ID", True))
        Me.National_IDTextBox.Location = New System.Drawing.Point(99, 377)
        Me.National_IDTextBox.Name = "National_IDTextBox"
        Me.National_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.National_IDTextBox.TabIndex = 11
        '
        'Amount_PaidLabel
        '
        Amount_PaidLabel.AutoSize = True
        Amount_PaidLabel.Location = New System.Drawing.Point(8, 406)
        Amount_PaidLabel.Name = "Amount_PaidLabel"
        Amount_PaidLabel.Size = New System.Drawing.Size(70, 13)
        Amount_PaidLabel.TabIndex = 12
        Amount_PaidLabel.Text = "Amount Paid:"
        '
        'Amount_PaidTextBox
        '
        Me.Amount_PaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_ResrvationBindingSource, "Amount Paid", True))
        Me.Amount_PaidTextBox.Location = New System.Drawing.Point(99, 403)
        Me.Amount_PaidTextBox.Name = "Amount_PaidTextBox"
        Me.Amount_PaidTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Amount_PaidTextBox.TabIndex = 13
        '
        'Event_Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 476)
        Me.ControlBox = False
        Me.Controls.Add(Event_IDLabel)
        Me.Controls.Add(Me.Event_IDTextBox)
        Me.Controls.Add(Event_NameLabel)
        Me.Controls.Add(Me.Event_NameTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Customer_NameLabel)
        Me.Controls.Add(Me.Customer_NameTextBox)
        Me.Controls.Add(National_IDLabel)
        Me.Controls.Add(Me.National_IDTextBox)
        Me.Controls.Add(Amount_PaidLabel)
        Me.Controls.Add(Me.Amount_PaidTextBox)
        Me.Controls.Add(Me.Event_ResrvationDataGridView)
        Me.Controls.Add(Me.Event_ResrvationBindingNavigator)
        Me.Name = "Event_Reservation"
        CType(Me.NyandaSQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_ResrvationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_ResrvationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Event_ResrvationBindingNavigator.ResumeLayout(False)
        Me.Event_ResrvationBindingNavigator.PerformLayout()
        CType(Me.Event_ResrvationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NyandaSQL As Nyanda_Lodge_Reservation_System.NyandaSQL
    Friend WithEvents Event_ResrvationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_ResrvationTableAdapter As Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.Event_ResrvationTableAdapter
    Friend WithEvents TableAdapterManager As Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.TableAdapterManager
    Friend WithEvents Event_ResrvationBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Event_ResrvationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Event_ResrvationDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Event_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Event_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Customer_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents National_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Amount_PaidTextBox As System.Windows.Forms.TextBox
End Class

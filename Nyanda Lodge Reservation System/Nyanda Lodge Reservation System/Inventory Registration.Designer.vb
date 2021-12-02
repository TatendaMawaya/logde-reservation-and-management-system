<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory_Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory_Registration))
        Dim Equipment_IDLabel As System.Windows.Forms.Label
        Dim Equipment_NameLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim Price_Per_UnitLabel As System.Windows.Forms.Label
        Me.NyandaSQL = New Nyanda_Lodge_Reservation_System.NyandaSQL()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.InventoryTableAdapter()
        Me.TableAdapterManager = New Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.TableAdapterManager()
        Me.InventoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.InventoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.InventoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Equipment_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Equipment_NameTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Price_Per_UnitTextBox = New System.Windows.Forms.TextBox()
        Equipment_IDLabel = New System.Windows.Forms.Label()
        Equipment_NameLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Price_Per_UnitLabel = New System.Windows.Forms.Label()
        CType(Me.NyandaSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventoryBindingNavigator.SuspendLayout()
        CType(Me.InventoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NyandaSQL
        '
        Me.NyandaSQL.DataSetName = "NyandaSQL"
        Me.NyandaSQL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.NyandaSQL
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Event_ResrvationTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Me.InventoryTableAdapter
        Me.TableAdapterManager.Room_ReservationsTableAdapter = Nothing
        Me.TableAdapterManager.RoomsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InventoryBindingNavigator
        '
        Me.InventoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InventoryBindingNavigator.BindingSource = Me.InventoryBindingSource
        Me.InventoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InventoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InventoryBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.InventoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InventoryBindingNavigatorSaveItem})
        Me.InventoryBindingNavigator.Location = New System.Drawing.Point(9, 223)
        Me.InventoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InventoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InventoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InventoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InventoryBindingNavigator.Name = "InventoryBindingNavigator"
        Me.InventoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InventoryBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.InventoryBindingNavigator.TabIndex = 0
        Me.InventoryBindingNavigator.Text = "BindingNavigator1"
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
        'InventoryBindingNavigatorSaveItem
        '
        Me.InventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InventoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("InventoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InventoryBindingNavigatorSaveItem.Name = "InventoryBindingNavigatorSaveItem"
        Me.InventoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.InventoryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'InventoryDataGridView
        '
        Me.InventoryDataGridView.AutoGenerateColumns = False
        Me.InventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InventoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.InventoryDataGridView.DataSource = Me.InventoryBindingSource
        Me.InventoryDataGridView.Location = New System.Drawing.Point(3, 0)
        Me.InventoryDataGridView.Name = "InventoryDataGridView"
        Me.InventoryDataGridView.Size = New System.Drawing.Size(644, 220)
        Me.InventoryDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Equipment ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Equipment ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Equipment Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Equipment Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Price Per Unit"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Price Per Unit"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Equipment_IDLabel
        '
        Equipment_IDLabel.AutoSize = True
        Equipment_IDLabel.Location = New System.Drawing.Point(12, 278)
        Equipment_IDLabel.Name = "Equipment_IDLabel"
        Equipment_IDLabel.Size = New System.Drawing.Size(74, 13)
        Equipment_IDLabel.TabIndex = 2
        Equipment_IDLabel.Text = "Equipment ID:"
        '
        'Equipment_IDTextBox
        '
        Me.Equipment_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "Equipment ID", True))
        Me.Equipment_IDTextBox.Location = New System.Drawing.Point(109, 275)
        Me.Equipment_IDTextBox.Name = "Equipment_IDTextBox"
        Me.Equipment_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Equipment_IDTextBox.TabIndex = 3
        '
        'Equipment_NameLabel
        '
        Equipment_NameLabel.AutoSize = True
        Equipment_NameLabel.Location = New System.Drawing.Point(12, 304)
        Equipment_NameLabel.Name = "Equipment_NameLabel"
        Equipment_NameLabel.Size = New System.Drawing.Size(91, 13)
        Equipment_NameLabel.TabIndex = 4
        Equipment_NameLabel.Text = "Equipment Name:"
        '
        'Equipment_NameTextBox
        '
        Me.Equipment_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "Equipment Name", True))
        Me.Equipment_NameTextBox.Location = New System.Drawing.Point(109, 301)
        Me.Equipment_NameTextBox.Name = "Equipment_NameTextBox"
        Me.Equipment_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Equipment_NameTextBox.TabIndex = 5
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(12, 330)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(49, 13)
        QuantityLabel.TabIndex = 6
        QuantityLabel.Text = "Quantity:"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(109, 327)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.QuantityTextBox.TabIndex = 7
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(12, 357)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 8
        DateLabel.Text = "Date:"
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InventoryBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(109, 353)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 9
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(12, 382)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 10
        StatusLabel.Text = "Status:"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(109, 379)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StatusTextBox.TabIndex = 11
        '
        'Price_Per_UnitLabel
        '
        Price_Per_UnitLabel.AutoSize = True
        Price_Per_UnitLabel.Location = New System.Drawing.Point(12, 408)
        Price_Per_UnitLabel.Name = "Price_Per_UnitLabel"
        Price_Per_UnitLabel.Size = New System.Drawing.Size(75, 13)
        Price_Per_UnitLabel.TabIndex = 12
        Price_Per_UnitLabel.Text = "Price Per Unit:"
        '
        'Price_Per_UnitTextBox
        '
        Me.Price_Per_UnitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "Price Per Unit", True))
        Me.Price_Per_UnitTextBox.Location = New System.Drawing.Point(109, 405)
        Me.Price_Per_UnitTextBox.Name = "Price_Per_UnitTextBox"
        Me.Price_Per_UnitTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Price_Per_UnitTextBox.TabIndex = 13
        '
        'Inventory_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 472)
        Me.Controls.Add(Equipment_IDLabel)
        Me.Controls.Add(Me.Equipment_IDTextBox)
        Me.Controls.Add(Equipment_NameLabel)
        Me.Controls.Add(Me.Equipment_NameTextBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(Price_Per_UnitLabel)
        Me.Controls.Add(Me.Price_Per_UnitTextBox)
        Me.Controls.Add(Me.InventoryDataGridView)
        Me.Controls.Add(Me.InventoryBindingNavigator)
        Me.Name = "Inventory_Registration"
        Me.Text = "Inventory_Registration"
        CType(Me.NyandaSQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventoryBindingNavigator.ResumeLayout(False)
        Me.InventoryBindingNavigator.PerformLayout()
        CType(Me.InventoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NyandaSQL As Nyanda_Lodge_Reservation_System.NyandaSQL
    Friend WithEvents InventoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventoryTableAdapter As Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.InventoryTableAdapter
    Friend WithEvents TableAdapterManager As Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.TableAdapterManager
    Friend WithEvents InventoryBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents InventoryBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents InventoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Equipment_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Equipment_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Price_Per_UnitTextBox As System.Windows.Forms.TextBox
End Class

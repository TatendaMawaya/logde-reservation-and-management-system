<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rooms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rooms))
        Dim Room_IDLabel As System.Windows.Forms.Label
        Dim Room_TypeLabel As System.Windows.Forms.Label
        Me.NyandaSQL = New Nyanda_Lodge_Reservation_System.NyandaSQL()
        Me.RoomsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomsTableAdapter = New Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.RoomsTableAdapter()
        Me.TableAdapterManager = New Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.TableAdapterManager()
        Me.RoomsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RoomsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RoomsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Room_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Room_TypeTextBox = New System.Windows.Forms.TextBox()
        Room_IDLabel = New System.Windows.Forms.Label()
        Room_TypeLabel = New System.Windows.Forms.Label()
        CType(Me.NyandaSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoomsBindingNavigator.SuspendLayout()
        CType(Me.RoomsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NyandaSQL
        '
        Me.NyandaSQL.DataSetName = "NyandaSQL"
        Me.NyandaSQL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RoomsBindingSource
        '
        Me.RoomsBindingSource.DataMember = "Rooms"
        Me.RoomsBindingSource.DataSource = Me.NyandaSQL
        '
        'RoomsTableAdapter
        '
        Me.RoomsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Event_ResrvationTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.Room_ReservationsTableAdapter = Nothing
        Me.TableAdapterManager.RoomsTableAdapter = Me.RoomsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RoomsBindingNavigator
        '
        Me.RoomsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RoomsBindingNavigator.BindingSource = Me.RoomsBindingSource
        Me.RoomsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RoomsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RoomsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.RoomsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RoomsBindingNavigatorSaveItem})
        Me.RoomsBindingNavigator.Location = New System.Drawing.Point(0, 223)
        Me.RoomsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RoomsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RoomsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RoomsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RoomsBindingNavigator.Name = "RoomsBindingNavigator"
        Me.RoomsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RoomsBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.RoomsBindingNavigator.TabIndex = 0
        Me.RoomsBindingNavigator.Text = "BindingNavigator1"
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
        'RoomsBindingNavigatorSaveItem
        '
        Me.RoomsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RoomsBindingNavigatorSaveItem.Image = CType(resources.GetObject("RoomsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RoomsBindingNavigatorSaveItem.Name = "RoomsBindingNavigatorSaveItem"
        Me.RoomsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.RoomsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RoomsDataGridView
        '
        Me.RoomsDataGridView.AutoGenerateColumns = False
        Me.RoomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RoomsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.RoomsDataGridView.DataSource = Me.RoomsBindingSource
        Me.RoomsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.RoomsDataGridView.Name = "RoomsDataGridView"
        Me.RoomsDataGridView.Size = New System.Drawing.Size(244, 220)
        Me.RoomsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Room ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Room ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Room Type"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Room Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Room_IDLabel
        '
        Room_IDLabel.AutoSize = True
        Room_IDLabel.Location = New System.Drawing.Point(12, 279)
        Room_IDLabel.Name = "Room_IDLabel"
        Room_IDLabel.Size = New System.Drawing.Size(52, 13)
        Room_IDLabel.TabIndex = 2
        Room_IDLabel.Text = "Room ID:"
        '
        'Room_IDTextBox
        '
        Me.Room_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomsBindingSource, "Room ID", True))
        Me.Room_IDTextBox.Location = New System.Drawing.Point(83, 276)
        Me.Room_IDTextBox.Name = "Room_IDTextBox"
        Me.Room_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Room_IDTextBox.TabIndex = 3
        '
        'Room_TypeLabel
        '
        Room_TypeLabel.AutoSize = True
        Room_TypeLabel.Location = New System.Drawing.Point(12, 305)
        Room_TypeLabel.Name = "Room_TypeLabel"
        Room_TypeLabel.Size = New System.Drawing.Size(65, 13)
        Room_TypeLabel.TabIndex = 4
        Room_TypeLabel.Text = "Room Type:"
        '
        'Room_TypeTextBox
        '
        Me.Room_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomsBindingSource, "Room Type", True))
        Me.Room_TypeTextBox.Location = New System.Drawing.Point(83, 302)
        Me.Room_TypeTextBox.Name = "Room_TypeTextBox"
        Me.Room_TypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Room_TypeTextBox.TabIndex = 5
        '
        'Rooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 404)
        Me.ControlBox = False
        Me.Controls.Add(Room_IDLabel)
        Me.Controls.Add(Me.Room_IDTextBox)
        Me.Controls.Add(Room_TypeLabel)
        Me.Controls.Add(Me.Room_TypeTextBox)
        Me.Controls.Add(Me.RoomsDataGridView)
        Me.Controls.Add(Me.RoomsBindingNavigator)
        Me.Name = "Rooms"
        CType(Me.NyandaSQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoomsBindingNavigator.ResumeLayout(False)
        Me.RoomsBindingNavigator.PerformLayout()
        CType(Me.RoomsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NyandaSQL As Nyanda_Lodge_Reservation_System.NyandaSQL
    Friend WithEvents RoomsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RoomsTableAdapter As Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.RoomsTableAdapter
    Friend WithEvents TableAdapterManager As Nyanda_Lodge_Reservation_System.NyandaSQLTableAdapters.TableAdapterManager
    Friend WithEvents RoomsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents RoomsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RoomsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Room_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Room_TypeTextBox As System.Windows.Forms.TextBox
End Class

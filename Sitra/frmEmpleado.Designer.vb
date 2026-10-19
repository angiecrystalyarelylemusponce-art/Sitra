<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleado))
        Dim Id_empleadoLabel As System.Windows.Forms.Label
        Dim NombreEmpleadoLabel As System.Windows.Forms.Label
        Dim DireccionEmpleadoLabel As System.Windows.Forms.Label
        Dim TelefonoEmpleadoLabel As System.Windows.Forms.Label
        Dim EdadEmpleadoLabel As System.Windows.Forms.Label
        Dim DNIempleadoLabel As System.Windows.Forms.Label
        Dim IdusuarioLabel As System.Windows.Forms.Label
        Me._Systerre2002_2003DataSet = New Sitra._Systerre2002_2003DataSet()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New Sitra._Systerre2002_2003DataSetTableAdapters.empleadoTableAdapter()
        Me.TableAdapterManager = New Sitra._Systerre2002_2003DataSetTableAdapters.TableAdapterManager()
        Me.EmpleadoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EmpleadoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EmpleadoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_empleadoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.EdadEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.DNIempleadoTextBox = New System.Windows.Forms.TextBox()
        Me.IdusuarioTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Id_empleadoLabel = New System.Windows.Forms.Label()
        NombreEmpleadoLabel = New System.Windows.Forms.Label()
        DireccionEmpleadoLabel = New System.Windows.Forms.Label()
        TelefonoEmpleadoLabel = New System.Windows.Forms.Label()
        EdadEmpleadoLabel = New System.Windows.Forms.Label()
        DNIempleadoLabel = New System.Windows.Forms.Label()
        IdusuarioLabel = New System.Windows.Forms.Label()
        CType(Me._Systerre2002_2003DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpleadoBindingNavigator.SuspendLayout()
        CType(Me.EmpleadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_Systerre2002_2003DataSet
        '
        Me._Systerre2002_2003DataSet.DataSetName = "_Systerre2002_2003DataSet"
        Me._Systerre2002_2003DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "empleado"
        Me.EmpleadoBindingSource.DataSource = Me._Systerre2002_2003DataSet
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.Copia_de_empleadoTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Me.EmpleadoTableAdapter
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sitra._Systerre2002_2003DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'EmpleadoBindingNavigator
        '
        Me.EmpleadoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpleadoBindingNavigator.BindingSource = Me.EmpleadoBindingSource
        Me.EmpleadoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpleadoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpleadoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpleadoBindingNavigatorSaveItem})
        Me.EmpleadoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpleadoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpleadoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpleadoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpleadoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpleadoBindingNavigator.Name = "EmpleadoBindingNavigator"
        Me.EmpleadoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpleadoBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.EmpleadoBindingNavigator.TabIndex = 0
        Me.EmpleadoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'EmpleadoBindingNavigatorSaveItem
        '
        Me.EmpleadoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpleadoBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpleadoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpleadoBindingNavigatorSaveItem.Name = "EmpleadoBindingNavigatorSaveItem"
        Me.EmpleadoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmpleadoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'EmpleadoDataGridView
        '
        Me.EmpleadoDataGridView.AutoGenerateColumns = False
        Me.EmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.EmpleadoDataGridView.DataSource = Me.EmpleadoBindingSource
        Me.EmpleadoDataGridView.Location = New System.Drawing.Point(22, 243)
        Me.EmpleadoDataGridView.Name = "EmpleadoDataGridView"
        Me.EmpleadoDataGridView.Size = New System.Drawing.Size(749, 220)
        Me.EmpleadoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_empleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_empleado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombreEmpleado"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombreEmpleado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "direccionEmpleado"
        Me.DataGridViewTextBoxColumn3.HeaderText = "direccionEmpleado"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "telefonoEmpleado"
        Me.DataGridViewTextBoxColumn4.HeaderText = "telefonoEmpleado"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "edadEmpleado"
        Me.DataGridViewTextBoxColumn5.HeaderText = "edadEmpleado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DNIempleado"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DNIempleado"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Idusuario"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Idusuario"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Id_empleadoLabel
        '
        Id_empleadoLabel.AutoSize = True
        Id_empleadoLabel.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_empleadoLabel.Location = New System.Drawing.Point(74, 117)
        Id_empleadoLabel.Name = "Id_empleadoLabel"
        Id_empleadoLabel.Size = New System.Drawing.Size(84, 15)
        Id_empleadoLabel.TabIndex = 2
        Id_empleadoLabel.Text = "Id empleado:"
        '
        'Id_empleadoTextBox
        '
        Me.Id_empleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "Id_empleado", True))
        Me.Id_empleadoTextBox.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_empleadoTextBox.Location = New System.Drawing.Point(199, 114)
        Me.Id_empleadoTextBox.Name = "Id_empleadoTextBox"
        Me.Id_empleadoTextBox.Size = New System.Drawing.Size(124, 22)
        Me.Id_empleadoTextBox.TabIndex = 3
        '
        'NombreEmpleadoLabel
        '
        NombreEmpleadoLabel.AutoSize = True
        NombreEmpleadoLabel.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreEmpleadoLabel.Location = New System.Drawing.Point(74, 143)
        NombreEmpleadoLabel.Name = "NombreEmpleadoLabel"
        NombreEmpleadoLabel.Size = New System.Drawing.Size(119, 15)
        NombreEmpleadoLabel.TabIndex = 4
        NombreEmpleadoLabel.Text = "nombre Empleado:"
        '
        'NombreEmpleadoTextBox
        '
        Me.NombreEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "nombreEmpleado", True))
        Me.NombreEmpleadoTextBox.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreEmpleadoTextBox.Location = New System.Drawing.Point(199, 140)
        Me.NombreEmpleadoTextBox.Name = "NombreEmpleadoTextBox"
        Me.NombreEmpleadoTextBox.Size = New System.Drawing.Size(438, 22)
        Me.NombreEmpleadoTextBox.TabIndex = 5
        '
        'DireccionEmpleadoLabel
        '
        DireccionEmpleadoLabel.AutoSize = True
        DireccionEmpleadoLabel.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionEmpleadoLabel.Location = New System.Drawing.Point(69, 170)
        DireccionEmpleadoLabel.Name = "DireccionEmpleadoLabel"
        DireccionEmpleadoLabel.Size = New System.Drawing.Size(128, 15)
        DireccionEmpleadoLabel.TabIndex = 6
        DireccionEmpleadoLabel.Text = "direccion Empleado:"
        '
        'DireccionEmpleadoTextBox
        '
        Me.DireccionEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "direccionEmpleado", True))
        Me.DireccionEmpleadoTextBox.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionEmpleadoTextBox.Location = New System.Drawing.Point(199, 166)
        Me.DireccionEmpleadoTextBox.Name = "DireccionEmpleadoTextBox"
        Me.DireccionEmpleadoTextBox.Size = New System.Drawing.Size(124, 22)
        Me.DireccionEmpleadoTextBox.TabIndex = 7
        '
        'TelefonoEmpleadoLabel
        '
        TelefonoEmpleadoLabel.AutoSize = True
        TelefonoEmpleadoLabel.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoEmpleadoLabel.Location = New System.Drawing.Point(74, 195)
        TelefonoEmpleadoLabel.Name = "TelefonoEmpleadoLabel"
        TelefonoEmpleadoLabel.Size = New System.Drawing.Size(123, 15)
        TelefonoEmpleadoLabel.TabIndex = 8
        TelefonoEmpleadoLabel.Text = "telefono Empleado:"
        '
        'TelefonoEmpleadoTextBox
        '
        Me.TelefonoEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "telefonoEmpleado", True))
        Me.TelefonoEmpleadoTextBox.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoEmpleadoTextBox.Location = New System.Drawing.Point(199, 192)
        Me.TelefonoEmpleadoTextBox.Name = "TelefonoEmpleadoTextBox"
        Me.TelefonoEmpleadoTextBox.Size = New System.Drawing.Size(124, 22)
        Me.TelefonoEmpleadoTextBox.TabIndex = 9
        '
        'EdadEmpleadoLabel
        '
        EdadEmpleadoLabel.AutoSize = True
        EdadEmpleadoLabel.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EdadEmpleadoLabel.Location = New System.Drawing.Point(376, 114)
        EdadEmpleadoLabel.Name = "EdadEmpleadoLabel"
        EdadEmpleadoLabel.Size = New System.Drawing.Size(103, 15)
        EdadEmpleadoLabel.TabIndex = 10
        EdadEmpleadoLabel.Text = "edad Empleado:"
        '
        'EdadEmpleadoTextBox
        '
        Me.EdadEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "edadEmpleado", True))
        Me.EdadEmpleadoTextBox.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EdadEmpleadoTextBox.Location = New System.Drawing.Point(485, 111)
        Me.EdadEmpleadoTextBox.Name = "EdadEmpleadoTextBox"
        Me.EdadEmpleadoTextBox.Size = New System.Drawing.Size(152, 22)
        Me.EdadEmpleadoTextBox.TabIndex = 11
        '
        'DNIempleadoLabel
        '
        DNIempleadoLabel.AutoSize = True
        DNIempleadoLabel.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DNIempleadoLabel.Location = New System.Drawing.Point(376, 173)
        DNIempleadoLabel.Name = "DNIempleadoLabel"
        DNIempleadoLabel.Size = New System.Drawing.Size(89, 15)
        DNIempleadoLabel.TabIndex = 12
        DNIempleadoLabel.Text = "DNIempleado:"
        '
        'DNIempleadoTextBox
        '
        Me.DNIempleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "DNIempleado", True))
        Me.DNIempleadoTextBox.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DNIempleadoTextBox.Location = New System.Drawing.Point(485, 170)
        Me.DNIempleadoTextBox.Name = "DNIempleadoTextBox"
        Me.DNIempleadoTextBox.Size = New System.Drawing.Size(152, 22)
        Me.DNIempleadoTextBox.TabIndex = 13
        '
        'IdusuarioLabel
        '
        IdusuarioLabel.AutoSize = True
        IdusuarioLabel.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdusuarioLabel.Location = New System.Drawing.Point(376, 199)
        IdusuarioLabel.Name = "IdusuarioLabel"
        IdusuarioLabel.Size = New System.Drawing.Size(65, 15)
        IdusuarioLabel.TabIndex = 14
        IdusuarioLabel.Text = "Idusuario:"
        '
        'IdusuarioTextBox
        '
        Me.IdusuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "Idusuario", True))
        Me.IdusuarioTextBox.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdusuarioTextBox.Location = New System.Drawing.Point(485, 196)
        Me.IdusuarioTextBox.Name = "IdusuarioTextBox"
        Me.IdusuarioTextBox.Size = New System.Drawing.Size(152, 22)
        Me.IdusuarioTextBox.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Tabla: Empleado"
        '
        'frmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 475)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Id_empleadoLabel)
        Me.Controls.Add(Me.Id_empleadoTextBox)
        Me.Controls.Add(NombreEmpleadoLabel)
        Me.Controls.Add(Me.NombreEmpleadoTextBox)
        Me.Controls.Add(DireccionEmpleadoLabel)
        Me.Controls.Add(Me.DireccionEmpleadoTextBox)
        Me.Controls.Add(TelefonoEmpleadoLabel)
        Me.Controls.Add(Me.TelefonoEmpleadoTextBox)
        Me.Controls.Add(EdadEmpleadoLabel)
        Me.Controls.Add(Me.EdadEmpleadoTextBox)
        Me.Controls.Add(DNIempleadoLabel)
        Me.Controls.Add(Me.DNIempleadoTextBox)
        Me.Controls.Add(IdusuarioLabel)
        Me.Controls.Add(Me.IdusuarioTextBox)
        Me.Controls.Add(Me.EmpleadoDataGridView)
        Me.Controls.Add(Me.EmpleadoBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmpleado"
        Me.Text = "Form12"
        CType(Me._Systerre2002_2003DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpleadoBindingNavigator.ResumeLayout(False)
        Me.EmpleadoBindingNavigator.PerformLayout()
        CType(Me.EmpleadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Systerre2002_2003DataSet As _Systerre2002_2003DataSet
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As _Systerre2002_2003DataSetTableAdapters.empleadoTableAdapter
    Friend WithEvents TableAdapterManager As _Systerre2002_2003DataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadoBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EmpleadoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EmpleadoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Id_empleadoTextBox As TextBox
    Friend WithEvents NombreEmpleadoTextBox As TextBox
    Friend WithEvents DireccionEmpleadoTextBox As TextBox
    Friend WithEvents TelefonoEmpleadoTextBox As TextBox
    Friend WithEvents EdadEmpleadoTextBox As TextBox
    Friend WithEvents DNIempleadoTextBox As TextBox
    Friend WithEvents IdusuarioTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class

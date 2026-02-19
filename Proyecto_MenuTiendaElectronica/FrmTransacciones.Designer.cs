namespace MenuTiendaElectronica
{
    partial class FrmTransacciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_TransaccionLabel;
            System.Windows.Forms.Label iD_ProductoLabel;
            System.Windows.Forms.Label fecha_HoraLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label iD_Tipo_TransaccionLabel;
            System.Windows.Forms.Label direccionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransacciones));
            this.transaccionesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.transaccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIENDA_ELECTRONICADataSet = new MenuTiendaElectronica.TIENDA_ELECTRONICADataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.transaccionesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.transaccionesDataGridView = new System.Windows.Forms.DataGridView();
            this.iD_TransaccionTextBox = new System.Windows.Forms.TextBox();
            this.iD_ProductoTextBox = new System.Windows.Forms.TextBox();
            this.fecha_HoraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.iD_Tipo_TransaccionTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.transaccionesTableAdapter = new MenuTiendaElectronica.TIENDA_ELECTRONICADataSetTableAdapters.TransaccionesTableAdapter();
            this.tableAdapterManager = new MenuTiendaElectronica.TIENDA_ELECTRONICADataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_TransaccionLabel = new System.Windows.Forms.Label();
            iD_ProductoLabel = new System.Windows.Forms.Label();
            fecha_HoraLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            iD_Tipo_TransaccionLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesBindingNavigator)).BeginInit();
            this.transaccionesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIENDA_ELECTRONICADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_TransaccionLabel
            // 
            iD_TransaccionLabel.AutoSize = true;
            iD_TransaccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_TransaccionLabel.Location = new System.Drawing.Point(31, 89);
            iD_TransaccionLabel.Name = "iD_TransaccionLabel";
            iD_TransaccionLabel.Size = new System.Drawing.Size(92, 15);
            iD_TransaccionLabel.TabIndex = 3;
            iD_TransaccionLabel.Text = "ID Transaccion:";
            // 
            // iD_ProductoLabel
            // 
            iD_ProductoLabel.AutoSize = true;
            iD_ProductoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_ProductoLabel.Location = new System.Drawing.Point(31, 115);
            iD_ProductoLabel.Name = "iD_ProductoLabel";
            iD_ProductoLabel.Size = new System.Drawing.Size(74, 15);
            iD_ProductoLabel.TabIndex = 5;
            iD_ProductoLabel.Text = "ID Producto:";
            // 
            // fecha_HoraLabel
            // 
            fecha_HoraLabel.AutoSize = true;
            fecha_HoraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fecha_HoraLabel.Location = new System.Drawing.Point(31, 142);
            fecha_HoraLabel.Name = "fecha_HoraLabel";
            fecha_HoraLabel.Size = new System.Drawing.Size(74, 15);
            fecha_HoraLabel.TabIndex = 7;
            fecha_HoraLabel.Text = "Fecha Hora:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadLabel.Location = new System.Drawing.Point(31, 167);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(59, 15);
            cantidadLabel.TabIndex = 9;
            cantidadLabel.Text = "Cantidad:";
            // 
            // iD_Tipo_TransaccionLabel
            // 
            iD_Tipo_TransaccionLabel.AutoSize = true;
            iD_Tipo_TransaccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_Tipo_TransaccionLabel.Location = new System.Drawing.Point(31, 193);
            iD_Tipo_TransaccionLabel.Name = "iD_Tipo_TransaccionLabel";
            iD_Tipo_TransaccionLabel.Size = new System.Drawing.Size(119, 15);
            iD_Tipo_TransaccionLabel.TabIndex = 11;
            iD_Tipo_TransaccionLabel.Text = "ID Tipo Transaccion:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(31, 219);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(62, 15);
            direccionLabel.TabIndex = 13;
            direccionLabel.Text = "Direccion:";
            // 
            // transaccionesBindingNavigator
            // 
            this.transaccionesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.transaccionesBindingNavigator.BindingSource = this.transaccionesBindingSource;
            this.transaccionesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.transaccionesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.transaccionesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.transaccionesBindingNavigatorSaveItem});
            this.transaccionesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.transaccionesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.transaccionesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.transaccionesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.transaccionesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.transaccionesBindingNavigator.Name = "transaccionesBindingNavigator";
            this.transaccionesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.transaccionesBindingNavigator.Size = new System.Drawing.Size(743, 25);
            this.transaccionesBindingNavigator.TabIndex = 0;
            this.transaccionesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // transaccionesBindingSource
            // 
            this.transaccionesBindingSource.DataMember = "Transacciones";
            this.transaccionesBindingSource.DataSource = this.tIENDA_ELECTRONICADataSet;
            // 
            // tIENDA_ELECTRONICADataSet
            // 
            this.tIENDA_ELECTRONICADataSet.DataSetName = "TIENDA_ELECTRONICADataSet";
            this.tIENDA_ELECTRONICADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // transaccionesBindingNavigatorSaveItem
            // 
            this.transaccionesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.transaccionesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("transaccionesBindingNavigatorSaveItem.Image")));
            this.transaccionesBindingNavigatorSaveItem.Name = "transaccionesBindingNavigatorSaveItem";
            this.transaccionesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.transaccionesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.transaccionesBindingNavigatorSaveItem.Click += new System.EventHandler(this.transaccionesBindingNavigatorSaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transacciones";
            // 
            // transaccionesDataGridView
            // 
            this.transaccionesDataGridView.AutoGenerateColumns = false;
            this.transaccionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transaccionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.transaccionesDataGridView.DataSource = this.transaccionesBindingSource;
            this.transaccionesDataGridView.Location = new System.Drawing.Point(12, 263);
            this.transaccionesDataGridView.Name = "transaccionesDataGridView";
            this.transaccionesDataGridView.ReadOnly = true;
            this.transaccionesDataGridView.Size = new System.Drawing.Size(644, 220);
            this.transaccionesDataGridView.TabIndex = 2;
            // 
            // iD_TransaccionTextBox
            // 
            this.iD_TransaccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaccionesBindingSource, "ID_Transaccion", true));
            this.iD_TransaccionTextBox.Enabled = false;
            this.iD_TransaccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_TransaccionTextBox.Location = new System.Drawing.Point(157, 86);
            this.iD_TransaccionTextBox.Name = "iD_TransaccionTextBox";
            this.iD_TransaccionTextBox.ReadOnly = true;
            this.iD_TransaccionTextBox.Size = new System.Drawing.Size(200, 21);
            this.iD_TransaccionTextBox.TabIndex = 4;
            // 
            // iD_ProductoTextBox
            // 
            this.iD_ProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaccionesBindingSource, "ID_Producto", true));
            this.iD_ProductoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_ProductoTextBox.Location = new System.Drawing.Point(157, 112);
            this.iD_ProductoTextBox.Name = "iD_ProductoTextBox";
            this.iD_ProductoTextBox.Size = new System.Drawing.Size(200, 21);
            this.iD_ProductoTextBox.TabIndex = 6;
            this.iD_ProductoTextBox.TextChanged += new System.EventHandler(this.iD_ProductoTextBox_TextChanged);
            // 
            // fecha_HoraDateTimePicker
            // 
            this.fecha_HoraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transaccionesBindingSource, "Fecha_Hora", true));
            this.fecha_HoraDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_HoraDateTimePicker.Location = new System.Drawing.Point(157, 138);
            this.fecha_HoraDateTimePicker.Name = "fecha_HoraDateTimePicker";
            this.fecha_HoraDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.fecha_HoraDateTimePicker.TabIndex = 8;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaccionesBindingSource, "Cantidad", true));
            this.cantidadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadTextBox.Location = new System.Drawing.Point(157, 164);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(200, 21);
            this.cantidadTextBox.TabIndex = 10;
            // 
            // iD_Tipo_TransaccionTextBox
            // 
            this.iD_Tipo_TransaccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaccionesBindingSource, "ID_Tipo_Transaccion", true));
            this.iD_Tipo_TransaccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_Tipo_TransaccionTextBox.Location = new System.Drawing.Point(157, 190);
            this.iD_Tipo_TransaccionTextBox.Name = "iD_Tipo_TransaccionTextBox";
            this.iD_Tipo_TransaccionTextBox.Size = new System.Drawing.Size(200, 21);
            this.iD_Tipo_TransaccionTextBox.TabIndex = 12;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaccionesBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(157, 216);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(355, 21);
            this.direccionTextBox.TabIndex = 14;
            // 
            // transaccionesTableAdapter
            // 
            this.transaccionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.Producto_ProveedorTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.Tipo_TransaccionTableAdapter = null;
            this.tableAdapterManager.TransaccionesTableAdapter = this.transaccionesTableAdapter;
            this.tableAdapterManager.UpdateOrder = MenuTiendaElectronica.TIENDA_ELECTRONICADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Transaccion";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Transaccion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Producto";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fecha_Hora";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha_Hora";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_Tipo_Transaccion";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID_Tipo_Transaccion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // FrmTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 495);
            this.Controls.Add(iD_TransaccionLabel);
            this.Controls.Add(this.iD_TransaccionTextBox);
            this.Controls.Add(iD_ProductoLabel);
            this.Controls.Add(this.iD_ProductoTextBox);
            this.Controls.Add(fecha_HoraLabel);
            this.Controls.Add(this.fecha_HoraDateTimePicker);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(iD_Tipo_TransaccionLabel);
            this.Controls.Add(this.iD_Tipo_TransaccionTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.transaccionesDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transaccionesBindingNavigator);
            this.Name = "FrmTransacciones";
            this.Text = "FrmTransacciones";
            this.Load += new System.EventHandler(this.FrmTransacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesBindingNavigator)).EndInit();
            this.transaccionesBindingNavigator.ResumeLayout(false);
            this.transaccionesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIENDA_ELECTRONICADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TIENDA_ELECTRONICADataSet tIENDA_ELECTRONICADataSet;
        private System.Windows.Forms.BindingSource transaccionesBindingSource;
        private TIENDA_ELECTRONICADataSetTableAdapters.TransaccionesTableAdapter transaccionesTableAdapter;
        private TIENDA_ELECTRONICADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator transaccionesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton transaccionesBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView transaccionesDataGridView;
        private System.Windows.Forms.TextBox iD_TransaccionTextBox;
        private System.Windows.Forms.TextBox iD_ProductoTextBox;
        private System.Windows.Forms.DateTimePicker fecha_HoraDateTimePicker;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox iD_Tipo_TransaccionTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
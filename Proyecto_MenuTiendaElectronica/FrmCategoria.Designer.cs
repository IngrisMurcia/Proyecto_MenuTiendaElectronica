namespace MenuTiendaElectronica
{
    partial class FrmCategoria
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_CategoriaLabel;
            System.Windows.Forms.Label nombre_CategoriaLabel;
            System.Windows.Forms.Label descripcion_CategoriaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoria));
            this.tIENDA_ELECTRONICADataSet = new MenuTiendaElectronica.TIENDA_ELECTRONICADataSet();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new MenuTiendaElectronica.TIENDA_ELECTRONICADataSetTableAdapters.CategoriaTableAdapter();
            this.tableAdapterManager = new MenuTiendaElectronica.TIENDA_ELECTRONICADataSetTableAdapters.TableAdapterManager();
            this.categoriaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.categoriaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_CategoriaTextBox = new System.Windows.Forms.TextBox();
            this.nombre_CategoriaTextBox = new System.Windows.Forms.TextBox();
            this.descripcion_CategoriaTextBox = new System.Windows.Forms.TextBox();
            this.productoDeCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoDeCategoriaTableAdapter = new MenuTiendaElectronica.TIENDA_ELECTRONICADataSetTableAdapters.ProductoDeCategoriaTableAdapter();
            this.productoDeCategoriaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.producto_ProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producto_ProveedorTableAdapter = new MenuTiendaElectronica.TIENDA_ELECTRONICADataSetTableAdapters.Producto_ProveedorTableAdapter();
            this.tipo_TransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_TransaccionTableAdapter = new MenuTiendaElectronica.TIENDA_ELECTRONICADataSetTableAdapters.Tipo_TransaccionTableAdapter();
            iD_CategoriaLabel = new System.Windows.Forms.Label();
            nombre_CategoriaLabel = new System.Windows.Forms.Label();
            descripcion_CategoriaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tIENDA_ELECTRONICADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingNavigator)).BeginInit();
            this.categoriaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoDeCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDeCategoriaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto_ProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_TransaccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_CategoriaLabel
            // 
            iD_CategoriaLabel.AutoSize = true;
            iD_CategoriaLabel.Location = new System.Drawing.Point(28, 103);
            iD_CategoriaLabel.Name = "iD_CategoriaLabel";
            iD_CategoriaLabel.Size = new System.Drawing.Size(69, 13);
            iD_CategoriaLabel.TabIndex = 2;
            iD_CategoriaLabel.Text = "ID Categoria:";
            // 
            // nombre_CategoriaLabel
            // 
            nombre_CategoriaLabel.AutoSize = true;
            nombre_CategoriaLabel.Location = new System.Drawing.Point(28, 129);
            nombre_CategoriaLabel.Name = "nombre_CategoriaLabel";
            nombre_CategoriaLabel.Size = new System.Drawing.Size(95, 13);
            nombre_CategoriaLabel.TabIndex = 4;
            nombre_CategoriaLabel.Text = "Nombre Categoria:";
            // 
            // descripcion_CategoriaLabel
            // 
            descripcion_CategoriaLabel.AutoSize = true;
            descripcion_CategoriaLabel.Location = new System.Drawing.Point(28, 155);
            descripcion_CategoriaLabel.Name = "descripcion_CategoriaLabel";
            descripcion_CategoriaLabel.Size = new System.Drawing.Size(114, 13);
            descripcion_CategoriaLabel.TabIndex = 6;
            descripcion_CategoriaLabel.Text = "Descripcion Categoria:";
            // 
            // tIENDA_ELECTRONICADataSet
            // 
            this.tIENDA_ELECTRONICADataSet.DataSetName = "TIENDA_ELECTRONICADataSet";
            this.tIENDA_ELECTRONICADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.tIENDA_ELECTRONICADataSet;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = this.categoriaTableAdapter;
            this.tableAdapterManager.Producto_ProveedorTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.Tipo_TransaccionTableAdapter = null;
            this.tableAdapterManager.TransaccionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MenuTiendaElectronica.TIENDA_ELECTRONICADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriaBindingNavigator
            // 
            this.categoriaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categoriaBindingNavigator.BindingSource = this.categoriaBindingSource;
            this.categoriaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.categoriaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.categoriaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.categoriaBindingNavigatorSaveItem});
            this.categoriaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categoriaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.categoriaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.categoriaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categoriaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categoriaBindingNavigator.Name = "categoriaBindingNavigator";
            this.categoriaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categoriaBindingNavigator.Size = new System.Drawing.Size(864, 25);
            this.categoriaBindingNavigator.TabIndex = 0;
            this.categoriaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
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
            // categoriaBindingNavigatorSaveItem
            // 
            this.categoriaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoriaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriaBindingNavigatorSaveItem.Image")));
            this.categoriaBindingNavigatorSaveItem.Name = "categoriaBindingNavigatorSaveItem";
            this.categoriaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.categoriaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.categoriaBindingNavigatorSaveItem.Click += new System.EventHandler(this.categoriaBindingNavigatorSaveItem_Click);
            // 
            // iD_CategoriaTextBox
            // 
            this.iD_CategoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "ID_Categoria", true));
            this.iD_CategoriaTextBox.Location = new System.Drawing.Point(148, 100);
            this.iD_CategoriaTextBox.Name = "iD_CategoriaTextBox";
            this.iD_CategoriaTextBox.Size = new System.Drawing.Size(144, 20);
            this.iD_CategoriaTextBox.TabIndex = 3;
            // 
            // nombre_CategoriaTextBox
            // 
            this.nombre_CategoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Nombre_Categoria", true));
            this.nombre_CategoriaTextBox.Location = new System.Drawing.Point(148, 126);
            this.nombre_CategoriaTextBox.Name = "nombre_CategoriaTextBox";
            this.nombre_CategoriaTextBox.Size = new System.Drawing.Size(173, 20);
            this.nombre_CategoriaTextBox.TabIndex = 5;
            // 
            // descripcion_CategoriaTextBox
            // 
            this.descripcion_CategoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Descripcion_Categoria", true));
            this.descripcion_CategoriaTextBox.Location = new System.Drawing.Point(148, 152);
            this.descripcion_CategoriaTextBox.Name = "descripcion_CategoriaTextBox";
            this.descripcion_CategoriaTextBox.Size = new System.Drawing.Size(173, 20);
            this.descripcion_CategoriaTextBox.TabIndex = 7;
            // 
            // productoDeCategoriaBindingSource
            // 
            this.productoDeCategoriaBindingSource.DataMember = "Categoria_ProductoDeCategoria";
            this.productoDeCategoriaBindingSource.DataSource = this.categoriaBindingSource;
            // 
            // productoDeCategoriaTableAdapter
            // 
            this.productoDeCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // productoDeCategoriaDataGridView
            // 
            this.productoDeCategoriaDataGridView.AllowUserToAddRows = false;
            this.productoDeCategoriaDataGridView.AllowUserToDeleteRows = false;
            this.productoDeCategoriaDataGridView.AutoGenerateColumns = false;
            this.productoDeCategoriaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.productoDeCategoriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDeCategoriaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.productoDeCategoriaDataGridView.DataSource = this.productoDeCategoriaBindingSource;
            this.productoDeCategoriaDataGridView.Location = new System.Drawing.Point(31, 261);
            this.productoDeCategoriaDataGridView.Name = "productoDeCategoriaDataGridView";
            this.productoDeCategoriaDataGridView.ReadOnly = true;
            this.productoDeCategoriaDataGridView.Size = new System.Drawing.Size(790, 165);
            this.productoDeCategoriaDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_Producto";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_Producto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 92;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 69;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 88;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Precio_unitario";
            this.dataGridViewTextBoxColumn7.HeaderText = "Precio_unitario";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 102;
            // 
            // categoriaDataGridView
            // 
            this.categoriaDataGridView.AllowUserToAddRows = false;
            this.categoriaDataGridView.AllowUserToDeleteRows = false;
            this.categoriaDataGridView.AutoGenerateColumns = false;
            this.categoriaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.categoriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.categoriaDataGridView.DataSource = this.categoriaBindingSource;
            this.categoriaDataGridView.Location = new System.Drawing.Point(354, 46);
            this.categoriaDataGridView.Name = "categoriaDataGridView";
            this.categoriaDataGridView.ReadOnly = true;
            this.categoriaDataGridView.Size = new System.Drawing.Size(467, 170);
            this.categoriaDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Categoria";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Categoria";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 94;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre_Categoria";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre_Categoria";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion_Categoria";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion_Categoria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 139;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Categorias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(28, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Producto por Categorias (hijo)";
            // 
            // producto_ProveedorBindingSource
            // 
            this.producto_ProveedorBindingSource.DataMember = "Producto_Proveedor";
            this.producto_ProveedorBindingSource.DataSource = this.tIENDA_ELECTRONICADataSet;
            // 
            // producto_ProveedorTableAdapter
            // 
            this.producto_ProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // tipo_TransaccionBindingSource
            // 
            this.tipo_TransaccionBindingSource.DataMember = "Tipo_Transaccion";
            this.tipo_TransaccionBindingSource.DataSource = this.tIENDA_ELECTRONICADataSet;
            // 
            // tipo_TransaccionTableAdapter
            // 
            this.tipo_TransaccionTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoriaDataGridView);
            this.Controls.Add(this.productoDeCategoriaDataGridView);
            this.Controls.Add(iD_CategoriaLabel);
            this.Controls.Add(this.iD_CategoriaTextBox);
            this.Controls.Add(nombre_CategoriaLabel);
            this.Controls.Add(this.nombre_CategoriaTextBox);
            this.Controls.Add(descripcion_CategoriaLabel);
            this.Controls.Add(this.descripcion_CategoriaTextBox);
            this.Controls.Add(this.categoriaBindingNavigator);
            this.Name = "FrmCategoria";
            this.Text = "FrmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tIENDA_ELECTRONICADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingNavigator)).EndInit();
            this.categoriaBindingNavigator.ResumeLayout(false);
            this.categoriaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoDeCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDeCategoriaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto_ProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_TransaccionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TIENDA_ELECTRONICADataSet tIENDA_ELECTRONICADataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private TIENDA_ELECTRONICADataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private TIENDA_ELECTRONICADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator categoriaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton categoriaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_CategoriaTextBox;
        private System.Windows.Forms.TextBox nombre_CategoriaTextBox;
        private System.Windows.Forms.TextBox descripcion_CategoriaTextBox;
        private System.Windows.Forms.BindingSource productoDeCategoriaBindingSource;
        private TIENDA_ELECTRONICADataSetTableAdapters.ProductoDeCategoriaTableAdapter productoDeCategoriaTableAdapter;
        private System.Windows.Forms.DataGridView productoDeCategoriaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView categoriaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource producto_ProveedorBindingSource;
        private TIENDA_ELECTRONICADataSetTableAdapters.Producto_ProveedorTableAdapter producto_ProveedorTableAdapter;
        private System.Windows.Forms.BindingSource tipo_TransaccionBindingSource;
        private TIENDA_ELECTRONICADataSetTableAdapters.Tipo_TransaccionTableAdapter tipo_TransaccionTableAdapter;
    }
}


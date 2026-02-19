namespace MenuTiendaElectronica
{
    partial class FrmTipoTransaccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoTransaccion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tIENDA_ELECTRONICADataSet = new MenuTiendaElectronica.TIENDA_ELECTRONICADataSet();
            this.tipo_TransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_TransaccionTableAdapter = new MenuTiendaElectronica.TIENDA_ELECTRONICADataSetTableAdapters.Tipo_TransaccionTableAdapter();
            this.tableAdapterManager = new MenuTiendaElectronica.TIENDA_ELECTRONICADataSetTableAdapters.TableAdapterManager();
            this.tipo_TransaccionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tipo_TransaccionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tipo_TransaccionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiposOperacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipos_OperacionesTableAdapter = new MenuTiendaElectronica.TIENDA_ELECTRONICADataSetTableAdapters.Tipos_OperacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tIENDA_ELECTRONICADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_TransaccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_TransaccionBindingNavigator)).BeginInit();
            this.tipo_TransaccionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_TransaccionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposOperacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el tipo de Operación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tipo de Transacciones";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tiposOperacionesBindingSource;
            this.comboBox1.DisplayMember = "Operacion";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(234, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "Operacion";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(391, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tIENDA_ELECTRONICADataSet
            // 
            this.tIENDA_ELECTRONICADataSet.DataSetName = "TIENDA_ELECTRONICADataSet";
            this.tIENDA_ELECTRONICADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.Producto_ProveedorTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.Tipo_TransaccionTableAdapter = this.tipo_TransaccionTableAdapter;
            this.tableAdapterManager.TransaccionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MenuTiendaElectronica.TIENDA_ELECTRONICADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tipo_TransaccionBindingNavigator
            // 
            this.tipo_TransaccionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tipo_TransaccionBindingNavigator.BindingSource = this.tipo_TransaccionBindingSource;
            this.tipo_TransaccionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tipo_TransaccionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tipo_TransaccionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tipo_TransaccionBindingNavigatorSaveItem});
            this.tipo_TransaccionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tipo_TransaccionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tipo_TransaccionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tipo_TransaccionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tipo_TransaccionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tipo_TransaccionBindingNavigator.Name = "tipo_TransaccionBindingNavigator";
            this.tipo_TransaccionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tipo_TransaccionBindingNavigator.Size = new System.Drawing.Size(515, 25);
            this.tipo_TransaccionBindingNavigator.TabIndex = 15;
            this.tipo_TransaccionBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // tipo_TransaccionBindingNavigatorSaveItem
            // 
            this.tipo_TransaccionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tipo_TransaccionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tipo_TransaccionBindingNavigatorSaveItem.Image")));
            this.tipo_TransaccionBindingNavigatorSaveItem.Name = "tipo_TransaccionBindingNavigatorSaveItem";
            this.tipo_TransaccionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tipo_TransaccionBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tipo_TransaccionBindingNavigatorSaveItem.Click += new System.EventHandler(this.tipo_TransaccionBindingNavigatorSaveItem_Click);
            // 
            // tipo_TransaccionDataGridView
            // 
            this.tipo_TransaccionDataGridView.AllowUserToAddRows = false;
            this.tipo_TransaccionDataGridView.AllowUserToDeleteRows = false;
            this.tipo_TransaccionDataGridView.AutoGenerateColumns = false;
            this.tipo_TransaccionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tipo_TransaccionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipo_TransaccionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tipo_TransaccionDataGridView.DataSource = this.tipo_TransaccionBindingSource;
            this.tipo_TransaccionDataGridView.Location = new System.Drawing.Point(28, 134);
            this.tipo_TransaccionDataGridView.Name = "tipo_TransaccionDataGridView";
            this.tipo_TransaccionDataGridView.ReadOnly = true;
            this.tipo_TransaccionDataGridView.Size = new System.Drawing.Size(450, 197);
            this.tipo_TransaccionDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Tipo_Transaccion";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Tipo_Transaccion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 135;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 88;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Operacion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Operacion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 81;
            // 
            // tiposOperacionesBindingSource
            // 
            this.tiposOperacionesBindingSource.DataMember = "Tipos_Operaciones";
            this.tiposOperacionesBindingSource.DataSource = this.tIENDA_ELECTRONICADataSet;
            // 
            // tipos_OperacionesTableAdapter
            // 
            this.tipos_OperacionesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTipoTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 362);
            this.Controls.Add(this.tipo_TransaccionDataGridView);
            this.Controls.Add(this.tipo_TransaccionBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTipoTransaccion";
            this.Text = "FrmTipoTransaccion";
            this.Load += new System.EventHandler(this.FrmTipoTransaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tIENDA_ELECTRONICADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_TransaccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_TransaccionBindingNavigator)).EndInit();
            this.tipo_TransaccionBindingNavigator.ResumeLayout(false);
            this.tipo_TransaccionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_TransaccionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposOperacionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private TIENDA_ELECTRONICADataSet tIENDA_ELECTRONICADataSet;
        private System.Windows.Forms.BindingSource tipo_TransaccionBindingSource;
        private TIENDA_ELECTRONICADataSetTableAdapters.Tipo_TransaccionTableAdapter tipo_TransaccionTableAdapter;
        private TIENDA_ELECTRONICADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tipo_TransaccionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tipo_TransaccionBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tipo_TransaccionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource tiposOperacionesBindingSource;
        private TIENDA_ELECTRONICADataSetTableAdapters.Tipos_OperacionesTableAdapter tipos_OperacionesTableAdapter;
    }
}
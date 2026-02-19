using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuTiendaElectronica
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tIENDA_ELECTRONICADataSet);

        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tIENDA_ELECTRONICADataSet.ProveedoresProductos' Puede moverla o quitarla según sea necesario.
            this.proveedoresProductosTableAdapter.Fill(this.tIENDA_ELECTRONICADataSet.ProveedoresProductos);
            // TODO: esta línea de código carga datos en la tabla 'tIENDA_ELECTRONICADataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.tIENDA_ELECTRONICADataSet.Producto);

        }
    }
}

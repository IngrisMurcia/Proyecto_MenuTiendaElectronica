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
    public partial class FrmProveedor : Form
    {
        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void proveedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tIENDA_ELECTRONICADataSet);

        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tIENDA_ELECTRONICADataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.tIENDA_ELECTRONICADataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'tIENDA_ELECTRONICADataSet.Producto_Proveedor' Puede moverla o quitarla según sea necesario.
            this.producto_ProveedorTableAdapter.Fill(this.tIENDA_ELECTRONICADataSet.Producto_Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'tIENDA_ELECTRONICADataSet.Productos_Provee' Puede moverla o quitarla según sea necesario.
            this.productos_ProveeTableAdapter.Fill(this.tIENDA_ELECTRONICADataSet.Productos_Provee);
            // TODO: esta línea de código carga datos en la tabla 'tIENDA_ELECTRONICADataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.tIENDA_ELECTRONICADataSet.Proveedor);

        }
    }
}

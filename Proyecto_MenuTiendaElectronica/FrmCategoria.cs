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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void categoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tIENDA_ELECTRONICADataSet);

        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tIENDA_ELECTRONICADataSet.Tipo_Transaccion' Puede moverla o quitarla según sea necesario.
            this.tipo_TransaccionTableAdapter.Fill(this.tIENDA_ELECTRONICADataSet.Tipo_Transaccion);
            // TODO: esta línea de código carga datos en la tabla 'tIENDA_ELECTRONICADataSet.Producto_Proveedor' Puede moverla o quitarla según sea necesario.
            this.producto_ProveedorTableAdapter.Fill(this.tIENDA_ELECTRONICADataSet.Producto_Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'tIENDA_ELECTRONICADataSet.ProductoDeCategoria' Puede moverla o quitarla según sea necesario.
            this.productoDeCategoriaTableAdapter.Fill(this.tIENDA_ELECTRONICADataSet.ProductoDeCategoria);
            // TODO: esta línea de código carga datos en la tabla 'tIENDA_ELECTRONICADataSet.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.tIENDA_ELECTRONICADataSet.Categoria);

        }
    }
}

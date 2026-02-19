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
    public partial class FrmTransacciones : Form
    {
        public FrmTransacciones()
        {
            InitializeComponent();
        }

        private void FrmTransacciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tIENDA_ELECTRONICADataSet.Transacciones' Puede moverla o quitarla según sea necesario.
            this.transaccionesTableAdapter.Fill(this.tIENDA_ELECTRONICADataSet.Transacciones);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
       
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de eliminar esta transacción?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                transaccionesBindingSource.RemoveCurrent();
                tableAdapterManager.UpdateAll(tIENDA_ELECTRONICADataSet);
            }
        }

        private void transaccionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.transaccionesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.tIENDA_ELECTRONICADataSet);
                MessageBox.Show("Guardado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iD_ProductoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

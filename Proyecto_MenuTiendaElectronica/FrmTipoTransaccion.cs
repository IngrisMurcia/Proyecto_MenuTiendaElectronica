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
    public partial class FrmTipoTransaccion : Form
    {
        public FrmTipoTransaccion()
        {
            InitializeComponent();
        }

        private void tipo_TransaccionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipo_TransaccionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tIENDA_ELECTRONICADataSet);

        }

        private void FrmTipoTransaccion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tIENDA_ELECTRONICADataSet.Tipos_Operaciones' Puede moverla o quitarla según sea necesario.
            this.tipos_OperacionesTableAdapter.Fill(this.tIENDA_ELECTRONICADataSet.Tipos_Operaciones);
            // TODO: esta línea de código carga datos en la tabla 'tIENDA_ELECTRONICADataSet.Tipo_Transaccion' Puede moverla o quitarla según sea necesario.
            this.tipo_TransaccionTableAdapter.Fill(this.tIENDA_ELECTRONICADataSet.Tipo_Transaccion);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tipo_TransaccionTableAdapter.FillByMovimiento(this.tIENDA_ELECTRONICADataSet.Tipo_Transaccion, comboBox1.Text);
        }
    }
}

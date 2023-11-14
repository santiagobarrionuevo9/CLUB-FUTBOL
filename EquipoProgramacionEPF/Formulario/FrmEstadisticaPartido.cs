using EquipoProgramacionEPF.Dominio;
using EquipoProgramacionEPF.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipoProgramacionEPF.Formulario
{
    public partial class FrmEstadisticaPartido : Form
    {
        EstadisticaPartido estadistica= null;
        IServicio servicio= null;
        Partidos partido = null;
        public FrmEstadisticaPartido()
        {
            InitializeComponent();
        }

        private void EstadisticaPartido_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            GrabarPartido();
        }

        private void GrabarPartido()
        {
            estadistica.Amarillas = Convert.ToInt32(txtAmarillas.Text);
            estadistica.Rojas= Convert.ToInt32(txtRojas.Text);
            estadistica.Goles= Convert.ToInt32(txtGoles.Text);
            estadistica.Asistencias = Convert.ToInt32(txtAsistencias.Text);
            estadistica.Jugador = cboJugador.SelectedIndex;
            estadistica.TiempoJugado = Convert.ToInt16(txttiempoJugado.Text);
            int nroPartido = servicio.Crear(partido);
            if(nroPartido>0)
            {
                MessageBox.Show("Se registro con exito el partido", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                partido=new Partidos();
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttiempoJugado.Text))
            {
                MessageBox.Show("Ingrese un Tiempo Jugado...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboJugador.SelectedIndex==-1)
            {
                MessageBox.Show("Ingrese un Jugador...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DataGridViewRow dr in dgvEstadisticas.Rows)
            {
                if (dr.Cells["ColJugador"].Value.ToString().Equals(cboJugador.SelectedItem.ToString()))
                {
                    MessageBox.Show("Este Jugador ya se Agregó...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }
    }
}

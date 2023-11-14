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
    public partial class PartidosReport : Form
    {
        public PartidosReport()
        {
            InitializeComponent();
        }

        private void PartidosReport_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reporte.DataTable1' Puede moverla o quitarla según sea necesario.
            this.dataTable1TableAdapter.Fill(this.reporte.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}

using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAgregarPaciente : Form
    {
        public FrmAgregarPaciente()
        {
            InitializeComponent();
        }

        private void cbBuscarDoctorPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbBuscarDoctorPor.SelectedIndex == 0)
            {
                lblTipoDoctor.Text = "Nombre del doctor";
                tbNombreDoctor.Visible = true;
                cbEspecialidades.Visible = false;
            }
            else
            {
                lblTipoDoctor.Text = "Especialidad del doctor";
                tbNombreDoctor.Visible = false;
                cbEspecialidades.Visible = true;
                cbEspecialidades.DataSource = Enum.GetValues(typeof(Doctor.EEspecialidades));
            }
        }

    }
}

using MyAPP1.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAPP1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            Persona personita = new Persona();
            personita.Nombre = tbNombre.Text;
            personita.FechaNac = dtpFechaNac.Value;
            MessageBox.Show(personita.EvaluarEdad());
        }
    }
}

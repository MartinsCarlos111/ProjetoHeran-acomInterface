using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividadedeherençacomirterface
{
    public partial class Cadastrar_Professor : Form
    {
        Professor professor;
        public Cadastrar_Professor()
        {
            InitializeComponent();
        }


        private void btncadprof_Click(object sender, EventArgs e)
        {
            professor = new Professor(txtnomeprof.Text, (Convert.ToInt32(txtidadeprof.Text)), txttitulacao.Text);
            txtnomeprof.Clear();
            txtidadeprof.Clear();
            txttitulacao.Clear();
        }

        private void btnexibirprof_Click(object sender, EventArgs e)
        {

            MessageBox.Show(professor.ImprimeDados());
        }

        private void btnvoltarprof_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Show();
        }
    }
}

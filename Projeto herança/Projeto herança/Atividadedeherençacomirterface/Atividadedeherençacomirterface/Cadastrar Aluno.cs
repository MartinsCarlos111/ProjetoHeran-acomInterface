using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividadedeherençacomirterface
{
    public partial class Cadastrar_Aluno : Form
    {
        Aluno aluno;
        public Cadastrar_Aluno()
        {
            InitializeComponent();
        }

        private void btncadaluno_Click(object sender, EventArgs e)
        {
            aluno = new Aluno(txtnomealuno.Text, (Convert.ToInt32(txtidadealuno.Text)), txtcurso.Text);
            txtnomealuno.Clear();
            txtidadealuno.Clear();
            txtcurso.Clear();
        }

        private void btnexibiraluno_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aluno.ImprimeDados());
        }

        private void btnvoltaraluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Show();
        }
    }
}

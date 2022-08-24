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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncadprof_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Professor professor = new Cadastrar_Professor();
            professor.Show();
        }

        private void btncadaluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Aluno aluno = new Cadastrar_Aluno();
            aluno.Show();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}

using eAgenda2._0.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda2._0.Apresentacao
{
    public partial class CadastroContato : Form
    {
        public Contato contato;

        public CadastroContato()
        {
            InitializeComponent();
            contato = new Contato();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contato.Nome = txtNome.Text;
            contato.Email = txtEmail.Text;
            contato.Empresa = txtEmpresa.Text;
            contato.Cargo = txtCargo.Text;  
            
        }
    }
}

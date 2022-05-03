using eAgenda2._0.Dominio;
using eAgenda2._0.Infra;
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
    public partial class ListagemContato : UserControl
    {
        RepositorioContato repositorioContato;

        public ListagemContato()
        {
            InitializeComponent();

            repositorioContato = new RepositorioContato();

            CarregarContatos();
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            List<Contato> contatosOrdenadosPorCargo = repositorioContato.SelecionarTodos();
            repositorioContato.OrdenarPorCargo(contatosOrdenadosPorCargo);

            listContatosId.Items.Clear();

            foreach (Contato c in contatos)
            {
                listContatosId.Items.Add(c);
            }


            foreach  (Contato c in contatosOrdenadosPorCargo)
            {
                listContatosCargo.Items.Add(c);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroContato tela = new CadastroContato();
           

            DialogResult resultado = tela.ShowDialog();

            string validacao = ValidarContato(tela.contato);

            if (validacao != "")
            {
                MessageBox.Show(validacao,
              "Cadastro de Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Inserir(tela.contato);
                CarregarContatos();
            }
        }

        private string ValidarContato(Contato contato)
        {
            string validacao = "";

           if (contato.Nome == "")
            validacao = " Contato precisa de nome";
            

           if(contato.Email == "")
             validacao += "\n Contato precisa de e-mail";

            if (contato.Telefone == "")
                validacao += "\n Contato precisa de Telefone";

            bool existeNome = repositorioContato.SelecionarTodos().Exists(x => x.Nome == contato.Nome);
            bool existeEmail = repositorioContato.SelecionarTodos().Exists(x => x.Email == contato.Email);
            bool existeTelefone = repositorioContato.SelecionarTodos().Exists(x => x.Telefone == contato.Telefone);

            if (existeNome == true)
                validacao += "\n Nome precisa ser único";
            
            if (existeEmail == true)
                validacao += "\n E-mail precisa ser único";
            
            if (existeTelefone == true)
                validacao += "\n Telefone precisa ser único";

            bool emailEstaValido = System.Net.Mail.MailAddress.TryCreate(contato.Email, out _);
            if (emailEstaValido == false)
                validacao += "\n Insira um endereço de email válido! (Ex: contato@gmail.com)";

           /* bool telefoneEstaValido = false;
    
             string telefoneProcessado = contato.Telefone.Replace("-", string.Empty)
                                                .Replace(" ", string.Empty);

            
            telefoneEstaValido = System.Text.RegularExpressions.Regex.IsMatch(telefoneProcessado, @"^[0-9]*$");

            if (telefoneEstaValido == false || telefoneProcessado.Length < 9)
                validacao += "\n O número precisa seguir um dos seguintes formatos: 99999-0000 ou 99999 0000 ou 999990000";*/


            return validacao;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatosId.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroContato tela = new CadastroContato();

            tela.contato = contatoSelecionado;

            DialogResult resultado = tela.ShowDialog();

            string validacao = ValidarContato(tela.contato);

            if (validacao != "")
            {
                MessageBox.Show(validacao,
              "Cadastro de Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Editar(tela.contato);
                CarregarContatos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato contatoIdSelecionado = (Contato)listContatosId.SelectedItem;
            Contato contatoNomeSelecionado = (Contato)listContatosCargo.SelectedItem;


            if (contatoIdSelecionado == null && contatoNomeSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Exclusão de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (contatoIdSelecionado != null)
                repositorioContato.Excluir(contatoIdSelecionado);

            if (contatoNomeSelecionado != null)
                repositorioContato.Excluir(contatoNomeSelecionado);
        }
    }
}

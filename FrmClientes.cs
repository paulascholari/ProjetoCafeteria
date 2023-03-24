using ProjetoCafeteria.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCafeteria
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // limpando o codigo e evitando o sql injection
            var codigo = IdCliente.Text.Trim().Replace("'", "");
            //esta listando todos os campos
            var listaDeCampos = new List<TextBox> {
                Nome,
                Logradouro,
                Bairro,
                Numero,
                UF,
                CEP,
                Municipio,
                Telefone,
                TelefoneContato,
                Email,
                EmailContato,
            };
            // limpando todos os campos com espaços extras e evitando o sql injection
            // subistituindo as aspas simples por nada 
            foreach (var item in listaDeCampos)
                item.Text = item.Text.Trim().Replace("'", "");
            //pegando todos o valores do campos digitados 
            var Valores = listaDeCampos.Select(x => $"'{x.Text}'").Aggregate((a, b) => $"{a} , {b}");
            //pegando todos os nomes dos campos 
            var Nomes = listaDeCampos.Select(x => $"[{x.Name}]").Aggregate((a, b) => $"{a} , {b}");

            // tratando o erro relacionado aos campos enviados para o banco de dados
            try
            {
                //comando sql pegando todos os nomes e todos os valores
                var sql = $@"INSERT INTO Clientes ({Nomes})
                VALUES ({Valores})";
                // se o tamanho for maior que 0 
                if (codigo.Length > 0)
                {
                    //esta selecionando cada campo e transforma o campo em atualização
                    //depois separa cada campo por virgula
                    var atualizar = listaDeCampos.Select(x => $"[{x.Name}]='{x.Text}'")
                        .Aggregate((a, b) => $"{a},{b}");
                    //criando comando de sql de atualização
                    sql = $@"UPDATE Clientes
                        SET {atualizar}
                        WHERE IdCliente={codigo}";
                }

                //rodando o comando no banco de dados
                BD.RetornaDatatable(sql);
                Close();
            }
            catch
            {
                // caso cair no erro ele ira mostrar que os campos estão invalidos.
                MessageBox.Show(" Há campos incorretos! Verifique e tente novamente ", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            //esta listando todos os campos
            var listaDeCampos = new List<Control> {
                IdCliente,
                Nome,
                Logradouro,
                Bairro,
                Numero,
                UF,
                CEP,
                Municipio,
                Telefone,
                TelefoneContato,
                Email,
                EmailContato,
            };
            var Nomes = listaDeCampos.Select(x => $"[{x.Name}]").ToList();
            // abrindo a tela de localização de Clientes
            var form = new FrmLocalizar(Nomes, "Clientes");

            // atribuindo comando de  pesquisa e o @Pesquisa dentro do comando  vai ser substituido pela pesquisa 
            form.sqlpesquisa($@"select IdCliente,
                        Nome,
                        Logradouro,
                        Bairro,
                        Numero,
                        UF,
                        CEP,
                        Municipio,
                        Telefone,
                        TelefoneContato,
                        Email,
                        EmailContato from Clientes 
                        where Nome like '%@pesquisa%' 
                            or Logradouro like '%@pesquisa%'
                            or Bairro like '%@pesquisa%'
                            or Municipio like '%@pesquisa%'
                            or Telefone like '%@pesquisa%'
                            or Email like '%@pesquisa%'");
            form.ShowDialog();
            // tratando os erros 
            try
            {
                // pegando o item selecionado 
                var Cliente = form.PegarItemSelecionado();
                // percorre a listaDeCampos pegando a posição atual para então pegar o valor do
                // item na tabela e passando para o campo respectivo
                for (int i = 0; i < listaDeCampos.Count; i++)
                {
                    listaDeCampos[i].Text = Cliente[i].ToString();
                }

                BtnCancelar.Enabled = true;
                BtnExcluir.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

            // limpando o codigo e evitando o sql injection
            var codigo = IdCliente.Text.Trim().Replace("'", "");
            //verificando se o codigo não esta vazio
            if (codigo.Length > 0)
            {
                // tratando os erros quando tenta apagar no banco de dados
                try
                {
                    // comando sql para exclusão
                    var sql = $@"delete from Clientes where IdCliente = {codigo}";


                    //rodando o comando
                    BD.RetornaDatatable(sql);
                    //fechando assim que deletar 
                    Close();


                }
                catch
                {
                    // caso ocorrer algum erro vai exibir a messagem
                    MessageBox.Show(" Não foi possivel apagar", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //esta listando todos os campos
            var listaDeCampos = new List<TextBox> {
                IdCliente,
                Nome,
                Logradouro,
                Bairro,
                Numero,
                UF,
                CEP,
                Municipio,
                Telefone,
                TelefoneContato,
                Email,
                EmailContato,
            };
            
            // limpando todos os campos 
            foreach (var item in listaDeCampos)
                item.Text = "";

            // resetar todos os botões

            BtnCancelar.Enabled = false;
            BtnExcluir.Enabled = false;
        }
    }
}

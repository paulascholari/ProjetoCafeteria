using ProjetoCafeteria.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoCafeteria
{
    public partial class frmProdutos : Form
    {
        public DataRowCollection categorias { get; set; }
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmCriarPedidos_Load(object sender, EventArgs e)
        {
            var sql = $@"select IdCategoria,NomeDaCategoria from Categorias";
            categorias = BD.RetornaDatatable(sql).Rows;
            foreach (DataRow categoria in categorias)
                CategoriaId.Items.Add(categoria[1].ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            // limpando o codigo e evitando o sql injection
            var codigo = IdProduto.Text.Trim().Replace("'", "");
            //verificando se o codigo não esta vazio
            if (codigo.Length > 0)
            {
                // tratando os erros quando tenta apagar no banco de dados
                try
                {
                    // comando sql para exclusão
                    var sql = $@"delete from Produtos where IdProduto = {codigo}";


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

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            //esta listando todos os campos
            var listaDeCampos = new List<Control> {
                IdProduto,
                NomeDoProduto ,
                Preco ,
                Unidade,
                Observação,
                CategoriaId,
            };
            var Nomes = listaDeCampos.Select(x => $"[{x.Name}]").ToList();
            // abrindo a tela de localização de Produtos
            var form = new FrmLocalizar(Nomes, "Produtos");
            form.ShowDialog();
            // tratando os erros 
            try
            {
                // pegando o item selecionado 
                var Categoria = form.PegarItemSelecionado();
                // percorre a listaDeCampos pegando a posição atual para então pegar o valor do
                // item na tabela e passando para o campo respectivo
                for (int i = 0; i < listaDeCampos.Count; i++)
                {
                    // checa se o nome é o mesmo do campo de categoria porque ele é um campo de seleção
                    if (listaDeCampos[i].Name == CategoriaId.Name)
                        // Percorre a propriedade itemselecionado e verifica se o Categoria
                        // é o mesmo do produto localizado e quebra o loop passando
                        // o index selecionado para o campo de categoria
                        for (int j = 0; j < categorias.Count; j++)
                        {
                            if (categorias[j][0].ToString() == Categoria[i].ToString())
                            {
                                CategoriaId.SelectedIndex = j;
                                break;
                            }
                        }
                    // Caso o item não seja o campo categoria, o texto dos outros itens é alterado
                    // pelo valor do item do banco de dados
                    else
                        listaDeCampos[i].Text = Categoria[i].ToString();
                }

                BtnCancelar.Enabled = true;
                BtnExcluir.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //esta listando todos os campos
            var listaDeCampos = new List<Control> {
               IdProduto,
                NomeDoProduto ,
                Preco ,
                Unidade,
                Observação,
                CategoriaId,
            };
            //resetando o campo categoria 
            CategoriaId.SelectedIndex = -1;
            // limpando todos os campos 
            foreach (var item in listaDeCampos)
                item.Text = "";

            // resetar todos os botões

            BtnCancelar.Enabled = false;
            BtnExcluir.Enabled = false;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // limpando o codigo e evitando o sql injection
            var codigo = IdProduto.Text.Trim().Replace("'", "");
            //esta listando todos os campos
            var listaDeCampos = new List<TextBox> {
                NomeDoProduto ,
                Preco ,
                Unidade,
                Observação,
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
                var sql = $@"INSERT INTO Produtos ({Nomes}, CategoriaId)
                VALUES ({Valores},{categorias[CategoriaId.SelectedIndex][0]})";
                // se o tamanho for maior que 0 
                if (codigo.Length > 0)
                {
                    //esta selecionando cada campo e transforma o campo em atualização
                    //depois separa cada campo por virgula
                    var atualizar = listaDeCampos.Select(x => $"[{x.Name}]='{x.Text}'")
                        .Aggregate((a, b) => $"{a},{b}");
                    //criando comando de sql de atualização
                    sql = $@"UPDATE Produtos
                        SET {atualizar},CategoriaId={categorias[CategoriaId.SelectedIndex][0]}
                        WHERE IdProduto={codigo}";
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

        private void CategoriaId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

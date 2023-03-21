using ProjetoCafeteria.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoCafeteria
{
    public partial class FrmPedidos : Form
    {
        public ICollection<DataRow> ProdutosSelecionados = new List<DataRow>();
        public DataRowCollection Clientes { get; set; }
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void BtnExcluirProduto_Click(object sender, EventArgs e)
        {
            // verificando se tem algum item selecionado na lista de produtos
            if (ListaProdutos.SelectedIndex != -1)
            {
                //removendo o produto da propriedade produtos selecionados 
                ProdutosSelecionados.Remove(ProdutosSelecionados.ElementAt(ListaProdutos.SelectedIndex));
                //removendo produto da lista
                ListaProdutos.Items.RemoveAt(ListaProdutos.SelectedIndex);
            }
        }

        private void BtnAdicionarProduto_Click(object sender, EventArgs e)
        {

            // abrindo a tela de localização de Produtos
            var form = new FrmLocalizar("IdProduto", "NomeDoProduto", "Produtos");
            form.ShowDialog();
            // tratando os erros 
            try
            {
                // pegando o item selecionado 
                var produto = form.PegarItemSelecionado();
                //adicionando na propriedade produtos selecionados o  item que foi selecionado da tela de localizar
                ProdutosSelecionados.Add(produto);
                //adicionando na lista o item que foi selecionado da tela de localizar 
                ListaProdutos.Items.Add(produto[1].ToString());
            }
            catch
            {
                return;
            }
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {

            // esta criando o comando sql  
            var sql = $@"Select IdCliente , Nome  From Clientes";
            // Esta executando o comando sql e salvando as linhas dentro da propriedade item selecionado
            Clientes = BD.RetornaDatatable(sql).Rows;
            foreach (DataRow row in Clientes)
            {
                // adicionando na lista de seleção 

                ClienteId.Items.Add(row[1].ToString());

            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // limpando o codigo e evitando o sql injection
            var codigo = IdPedido.Text.Trim().Replace("'", "");
            //selecionando o cliente 
            var cliente = Clientes[ClienteId.SelectedIndex][0];

            // tratando o erro relacionado aos campos enviados para o banco de dados
            try
            {
                //comando sql inserindo o pedido
                var sql = $@"INSERT INTO Pedidos (ClienteId,FuncionarioId)
                VALUES ({cliente},1);";
                // se o tamanho for maior que 0 
                //if (codigo.Length > 0)
                //{
                //    //esta selecionando cada campo e transforma o campo em atualização
                //    //depois separa cada campo por virgula
                //    var atualizar = listaDeCampos.Select(x => $"[{x.Name}]='{x.Text}'")
                //        .Aggregate((a, b) => $"{a},{b}");
                //    //criando comando de sql de atualização
                //    sql = $@"UPDATE Funcionarios
                //        SET {atualizar},CargoId={ItemSelecionado[CargoId.SelectedIndex][0]}
                //        WHERE IdFuncionario={codigo}";
                //}

                //rodando o comando no banco de dados e pegando id do pedido
                var IdPedido=BD.ExecutaComando(sql,true);
                // transformando todos os produto selecionados para ser inserido no sql
                var produtos = ProdutosSelecionados.Select(x => $"({IdPedido},'{x[0]}')")
                    .Aggregate((a, b) => $"{a},{b}");
                //inserindo os produtos no pedido
                var sqlprodutos = $@"INSERT INTO PedidosProdutos (PedidoId,ProdutoId)
                        VALUES {produtos}";
                // rodando comando inserir os produtos na tabela pedido
                BD.RetornaDatatable(sqlprodutos);
                Close();
            }
            catch
            {
                // caso cair no erro ele ira mostrar que os campos estão invalidos.
                MessageBox.Show(" Há campos incorretos! Verifique e tente novamente ", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            // abrindo a tela de localização de categorias
            var form = new FrmLocalizar($@"select p.IdPedido,c.Nome,c.IdCliente,pr.IdProduto from pedidos P
                inner join clientes c
                on p.ClienteId = c.IdCliente

                inner join PedidosProdutos pp
                on pp.PedidoId=p.IdPedido
                inner join Produtos pr
                on pr.IdProduto = pp.ProdutoId;");
            form.ShowDialog();
            // tratando os erros 
            try
            {
                // pegando o item selecionado 
                var Pedido = form.PegarItemSelecionado();
                // atribuindo o primeiro item do categoria ao campo de codigo
                IdPedido.Text = Pedido[0].ToString();
                // atribuindo o segundo item do categoria ao campo de categoria
                for (var i = 0; i < Clientes.Count; i++)
                    if (Clientes[i][0].ToString() == Pedido[2].ToString())
                    {
                        ClienteId.SelectedIndex = i; break;
                    }

                BtnCancelar.Enabled = true;
                BtnExcluir.Enabled = true;
            }
            catch
            {
                return;
            }
        }
    }
}

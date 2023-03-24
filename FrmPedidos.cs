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
            // criando comando sql para selecionar o nome do funcionario
            sql = $"select NomeDoFuncionario from funcionarios where IdFuncionario = {Login.PegarFuncinarioId()}";
            var funcionario = BD.RetornaDatatable(sql).Rows ;
            Funcionario.Text= funcionario[0][0].ToString() ;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // tratando o erro relacionado aos campos enviados para o banco de dados
            try
            {
                // limpando o codigo e evitando o sql injection
                var codigo = IdPedido.Text.Trim().Replace("'", "");
                //selecionando o cliente 
                var cliente = Clientes[ClienteId.SelectedIndex][0];

                //comando sql inserindo o pedido
                var sql = $@"INSERT INTO Pedidos (ClienteId,FuncionarioId)
                VALUES ({cliente},{Login.PegarFuncinarioId()});";
                // se o tamanho for maior que 0 vai atualizar o pedido
                if (codigo.Length > 0)
                {
                    // apaga o comando sql de inserir para evitar criar um novo item
                    sql = "";
                    //comando sql para deletar todos os produtos no pedido atual
                    var sqlatualizar = $@"delete from PedidosProdutos where PedidoId = {codigo}";
                    //executar comando sql atualizar
                    BD.RetornaDatatable(sqlatualizar);
                }

                //pegando o codigo por padrão 
                var pedidoid = int.Parse(codigo);
                //caso for um pedido novo é criado o pedido e retornado o id 
                if (sql.Length > 0)
                    pedidoid=BD.ExecutaComando(sql,true);
                // transformando todos os produto selecionados para ser inserido no sql
                var produtos = ProdutosSelecionados.Select(x => $"({pedidoid},'{x[0]}')")
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
            // abrindo a tela de localização de Pedidos
            var form = new FrmLocalizar($@"select p.IdPedido,c.Nome,c.IdCliente from pedidos P
                inner join clientes c
                on p.ClienteId = c.IdCliente");
            form.ShowDialog();
            // tratando os erros 
            try
            {
                // pegando o item selecionado 
                var Pedido = form.PegarItemSelecionado();
                // atribuindo o primeiro item do pedido ao campo de codigo
                IdPedido.Text = Pedido[0].ToString();
                // atribuindo o cliente  ao campo de cliente 
                for (var i = 0; i < Clientes.Count; i++)
                    if (Clientes[i][0].ToString() == Pedido[2].ToString())
                    {
                        ClienteId.SelectedIndex = i; break;
                    }
                // comando sql para selecionar todos os produtos do pedido
                var sqlprodutos = $@"select pr.IdProduto,pr.NomeDoProduto from pedidos p
                    inner join PedidosProdutos pp
                    on pp.PedidoId= p.IdPedido
                    inner join Produtos pr
                    on pr.IdProduto  = pp.ProdutoId
                    where p.IdPedido ={Pedido[0]}";
                // rodando o comando sql
                var produtos = BD.RetornaDatatable(sqlprodutos).Rows;
                //limpando a lista 
                ProdutosSelecionados.Clear();
                ListaProdutos.Items.Clear();
                //adicionando todos os produtos do pedido na lista
                foreach ( DataRow produto in produtos)
                {
                    ProdutosSelecionados.Add(produto);
                    ListaProdutos.Items.Add(produto[1].ToString());
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
            // tratando erros ao excluir 
            try
            {
                //limpando o campo do codigo e evitando o sql injection
                var codigo = IdPedido.Text.Trim().Replace("'", "");
                // verificando caso o não estiver vazio
                if (codigo.Length > 0)
                {
                    //comando exclusão do pedido 
                    var sql = $@"delete from PedidosProdutos  where PedidoId = {codigo};
                        delete from Pedidos where IdPedido = {codigo} ;";
                    //rodando comando sql
                    BD.RetornaDatatable(sql);
                    Close();
                }
            }
            catch
            {
                // caso cair no erro ele ira mostrar a seguinte menssagem 
                MessageBox.Show(" Não foi possivel excluir,tente novamente  ", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            // resetando os botao cancelar e excluir
            BtnCancelar.Enabled = false;    
            BtnExcluir.Enabled = false;
        }

        private void Funcionario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

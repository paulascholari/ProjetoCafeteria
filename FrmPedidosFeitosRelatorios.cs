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
    public partial class FrmPedidosFeitosRelatorios : Form
    {
        public FrmPedidosFeitosRelatorios()
        {
            InitializeComponent();
        }

        private void FrmPedidosFeitosRelatorios_Load(object sender, EventArgs e)
        {

            //comando selecionando todos os itens
            var itens = BD.RetornaDatatable($@"select p.IdPedido,c.Nome,pr.NomeDoProduto,pr.Preco,f.NomeDoFuncionario from pedidos p
                                inner join PedidosProdutos pp
                                on pp.PedidoId =p.IdPedido
                                inner join Produtos pr
                                on pr.IdProduto = pp.ProdutoId      
                                inner join Clientes c
                                on c.IdCliente = p.ClienteId
                                inner join Funcionarios F
                                ON F.IdFuncionario = P.FuncionarioId").Rows;
            //limpando a lista
            Lista.Items.Clear();
            var Listaagregada=new List<List<string>>();
            //percorrendo cada item e fazendo o looping
            foreach (DataRow c in itens)
            {
                if (Listaagregada.Select(x => x[0]).Contains(c[0].ToString()))
                {
                    var item = Listaagregada.First(x => x[0] == c[0].ToString());
                    item[2] += ", "+c[2].ToString();
                    item[3] =(double.Parse(item[3]) + double.Parse(c[3].ToString())).ToString();
                    continue;
                }
                // adicionando o item na lista
                Listaagregada.Add(new List<string> {  
                    c[0].ToString(), 
                    c[1].ToString(), 
                    c[2].ToString(),
                    c[3].ToString(),
                    c[4].ToString()
                });
            }
            foreach(var item in Listaagregada)
            {
                var itemlista=Lista.Items.Add(item[1]);
                itemlista.SubItems.Add(item[2]);
                itemlista.SubItems.Add("R$"+double.Parse(item[3]).ToString("N2"));
                itemlista.SubItems.Add(item[4]);

            }
        }
    }
}

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
    public partial class FrmLocalizar : Form
    {
        private DataTable ItemSelecionado;
        /// <summary>
        /// assim que a tela e instanciada e pedido a coluna do id ,coluna nome e o nome da tabela
        /// </summary>
        /// <param name="idColuna"></param>
        /// <param name="nomeColuna"></param>
        /// <param name="tabela"></param>
        public FrmLocalizar(string idColuna, string nomeColuna, string tabela)
        {
            // esta criando o comando sql  
            var sql = $@"Select {idColuna} ,{nomeColuna}  From {tabela}";
            // Esta executando o comando sql e salvando as linhas dentro da propriedade item selecionado
            ItemSelecionado = BD.RetornaDatatable(sql);
            InitializeComponent();
        }
        /// <summary>
        /// assim que a tela e instanciada e pedido a coluna do id ,coluna nome e o nome da tabela
        /// </summary>
        /// <param name="colunas">
        /// obs: a primeira coluna tem que ser o id da tabela e a segunda coluna deve ser o texto mostrado
        /// </param>
        /// <param name="tabela"></param>
        public FrmLocalizar(ICollection<string> colunas, string tabela)
        {
            var nomes = colunas.Aggregate((a, b) => $"{a},{b}");
            // esta criando o comando sql  
            var sql = $@"Select {nomes} From {tabela}";
            // Esta executando o comando sql e salvando as linhas dentro da propriedade item selecionado
            ItemSelecionado = BD.RetornaDatatable(sql);
            InitializeComponent();
        }
        public FrmLocalizar(string sql)
        {
            ItemSelecionado = BD.RetornaDatatable(sql);
            InitializeComponent();
        }
        /// <summary>
        /// pegar o item selecionado
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataRow PegarItemSelecionado()
        {
            // tratando erro 
            try
            {
                return ItemSelecionado.Rows[ListaDeLocalizar.SelectedRows[0].Index];
            }
            catch
            {
                // esta criando erro caso não existir o item selecionado 
                throw new Exception();
            }
        }
        private string sql = "";
        public void sqlpesquisa(string sql)
        {
            this.sql = sql;
        }

        private void FrmLocalizar_Load(object sender, EventArgs e)
        {
            ListaDeLocalizar.DataSource = ItemSelecionado;
        }
        private void ListaDeLocalizar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pesquisa = Pesquisa.Text.Trim().Replace("'", "");
            ItemSelecionado = BD.RetornaDatatable(sql.Replace("@pesquisa",pesquisa));
            ListaDeLocalizar.DataSource = ItemSelecionado;
        }
    }
}

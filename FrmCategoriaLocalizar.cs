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
    public partial class FrmCategoriaLocalizar : Form
    {
        private DataRowCollection Categorias;
        public FrmCategoriaLocalizar()
        {
            InitializeComponent();
        }
        // pegar o item selecionado
        public DataRow PegarItemSelecionado()
        {
            try
            {
                return Categorias[ListaCategorias.SelectedIndex];
            }catch { throw new Exception(); }
        }

        private void FrmCategoriaLocalizar_Load(object sender, EventArgs e)
        {
            // esta criando o comando sql  
            var sql = $@"Select IdCategoria ,NomeDaCategoria  From Categorias";
             // Esta executando o comando sql e salvando as linhas dentro da propriedade categorias
             Categorias = BD.RetornaDatatable(sql).Rows;
            // percorrendo as categorias 
            foreach (DataRow row in Categorias)
            {
                // adicionando na lista de seleção 
                ListaCategorias.Items.Add(row[1].ToString());
            }
        }


        private void ListaCategorias_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

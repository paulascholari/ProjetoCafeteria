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
    public partial class FrmCategoriaRealatorios : Form
    {
        public FrmCategoriaRealatorios()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmCategoriaRealatorios_Load(object sender, EventArgs e)
        {
            //comando selecionando todos os itens
            var itens = BD.RetornaDatatable("select NomeDaCategoria from Categorias").Rows;
            //limpando a lista
            Lista.Items.Clear();
            //percorrendo cada item e fazendo o looping
            foreach (DataRow c in itens)
            {
                // adicionando o item na lista
                Lista.Items.Add(c[0].ToString());

            }

        }
    }
}

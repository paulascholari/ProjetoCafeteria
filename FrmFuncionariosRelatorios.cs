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
    public partial class FrmFuncionariosRelatorios : Form
    {
        public FrmFuncionariosRelatorios()
        {
            InitializeComponent();
        }

        private void FrmFuncionariosRelatorios_Load(object sender, EventArgs e)
        {
            //comando selecionando todos os itens
            var itens = BD.RetornaDatatable("select NomeDoFuncionario,Telefone,Email from Funcionarios").Rows;
            //limpando a lista
            Lista.Items.Clear();
            //percorrendo cada item e fazendo o looping
            foreach (DataRow c in itens)
            {
                // adicionando o item na lista
                var itemdalista =Lista.Items.Add(c[0].ToString());
                //adicionando sub itens do item da lista  
                itemdalista.SubItems.Add(c[1].ToString());
                itemdalista.SubItems.Add(c[2].ToString());
            }
        }
    }
}

using ProjetoCafeteria.Classes;
using System;
using System.Collections;
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
    public partial class FrmCargosRelatorios : Form
    {
        public FrmCargosRelatorios()
        {
            InitializeComponent();
        }

        private void FrmCargosRelatorios_Load(object sender, EventArgs e)
        {
            //comando selecionando todos os itens
            var itens = BD.RetornaDatatable("select NomeDoCargo from Cargos").Rows;
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

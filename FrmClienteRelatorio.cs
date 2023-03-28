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
    public partial class FrmClienteRelatorio : Form
    {
        public FrmClienteRelatorio()
        {
            InitializeComponent();
        }

        private void FrmClienteRelatorio_Load(object sender, EventArgs e)
        {
            //comando selecionando todos os itens
            var itens = BD.RetornaDatatable($@"select c.nome,count(p.ClienteId),c.Logradouro from Clientes c
                        inner join Pedidos p    
                        on p.ClienteId = c.IdCliente
                        group by p.ClienteId,c.Nome,c.Logradouro").Rows;
            //limpando a lista
            Lista.Items.Clear();
            //percorrendo cada item e fazendo o looping
            foreach (DataRow c in itens)
            {
                // adicionando o item na lista
                var itemdalista = Lista.Items.Add(c[0].ToString());
                //adicionando sub itens do item da lista  
                itemdalista.SubItems.Add(c[1].ToString());
                itemdalista.SubItems.Add(c[2].ToString());
            }
        }
    }
}

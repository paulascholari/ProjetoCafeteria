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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //Replace evita o sql injection trim remove os espaços 
            var Categoria = TextCategoria.Text.Replace("'", "").Trim();
             // verifica se o texto da categoria não esta vazio
            if (Categoria.Length > 0)
            {
                //comando sql para inserir o item 
                var sql = $@"INSERT INTO Categorias (NomeDaCategoria)
                    VALUES ('{Categoria}')";
                  //executa o comando 
                BD.RetornaDatatable(sql);
            }
            else
            {
                // ele mostra a messagem caso o campo esteja vazio 
                MessageBox.Show("Há Campos vazios", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

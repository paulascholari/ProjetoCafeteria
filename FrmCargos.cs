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
    public partial class FrmCargos : Form
    {
        public FrmCargos()
        {
            InitializeComponent();
        }

        private void TextCargo_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            var form = new FrmCategoriaLocalizar();
            form.ShowDialog();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            //Replace evita o sql injection trim remove os espaços 
            var Cargo = TextCargo.Text.Replace("'", "").Trim();
            // verifica se o texto da cargo não esta vazio
            if (Cargo.Length > 0)
            {
                //comando sql para inserir o item 
                var sql = $@"INSERT INTO Cargos (NomeDoCargo)
                    VALUES ('{Cargo}')";
                //executa o comando 
                BD.RetornaDatatable(sql);
                Close();
            }
            else
            {
                // ele mostra a messagem caso o campo esteja vazio 
                MessageBox.Show("Há Campos vazios", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

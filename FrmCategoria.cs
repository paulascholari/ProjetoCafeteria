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
            // pegando o codigo da categoria selecionando e apagando os campos em branco
            var codigo = TextCodigo.Text.Trim();
            //Replace evita o sql injection trim remove os espaços 
            var Categoria = TextCategoria.Text.Replace("'", "").Trim();
             // verifica se o texto da categoria não esta vazio
            if (Categoria.Length > 0)
            {
                //comando sql para inserir o item 
                var sql = $@"INSERT INTO Categorias (NomeDaCategoria)
                    VALUES ('{Categoria}')";
                 // verificando se o codigo não esta vazio
                if (codigo != "")
                {
                    // comando sql para atualizar o item 
                    sql = $@"UPDATE Categorias
                        SET NomeDaCategoria='{Categoria}'
                        WHERE IdCategoria ={codigo}";
                }
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

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            // abrindo a tela de localização de categorias
            var form = new FrmCategoriaLocalizar();
            form.ShowDialog();
            // pegando o item selecionado 
            var categoria =form.PegarItemSelecionado();
            // atribuindo o primeiro item do categoria ao campo de codigo
            TextCodigo.Text = categoria[0].ToString();
            // atribuindo o segundo item do categoria ao campo de categoria
            TextCategoria.Text = categoria[1].ToString();
        }

        private void TextCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            // pegando o codigo da categoria selecionando e apagando os campos em branco
            var codigo = TextCodigo.Text.Trim();
            // comando sql de exclusão 
            var sql = $@"delete from Categorias where IdCategoria = {codigo}";
            //rodando o comando
            BD.RetornaDatatable(sql);
            //fechando assim que deletar 
            Close();
        }
    }
}

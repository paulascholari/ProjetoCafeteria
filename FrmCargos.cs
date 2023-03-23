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

            // abrindo a tela de localização de cargos
            var form = new FrmLocalizar("IdCargo", "NomeDoCargo", "Cargos");
            form.ShowDialog();
            // tratando os erros 
            try
            {
                // pegando o item selecionado 
                var Cargo = form.PegarItemSelecionado();
                // atribuindo o primeiro item do cargo ao campo de codigo
                TextCodigo.Text = Cargo[0].ToString();
                // atribuindo o segundo item do cargo ao campo de Cargo
                TextCargo.Text = Cargo[1].ToString();

                BtnCancelar.Enabled = true;
                BtnExcluir.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // limpando o codigo e evitando o sql injection
            var codigo = TextCodigo.Text.Trim().Replace("'", "");
            //Replace evita o sql injection trim remove os espaços 
            var Cargo = TextCargo.Text.Replace("'", "").Trim();
            // verifica se o texto da cargo não esta vazio
            if (Cargo.Length > 0)
            {
                //comando sql para inserir o item 
                var sql = $@"INSERT INTO Cargos (NomeDoCargo)
                    VALUES ('{Cargo}')";
                if(codigo.Length> 0)
                {
                    // comando sql para atualizar o item 
                    sql = $@"UPDATE Cargos
                        SET NomeDoCargo='{Cargo}'
                        WHERE IdCargo={codigo}";
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

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            // pegando o codigo do Cargo selecionando e apagando os campos em branco
            var codigo = TextCodigo.Text.Trim();
            // comando sql de exclusão 
            var sql = $@"delete from Cargos where IdCargo = {codigo}";

            // tratando o erro caso tenha itens que estão relacionados 
            try
            {
                //rodando o comando
                BD.RetornaDatatable(sql);
                //fechando assim que deletar 
                Close();
            }
            catch
            {
                MessageBox.Show(" Não foi possivel apagar", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            // resetar todos os campos
            TextCodigo.Text = string.Empty;
            TextCargo.Text = string.Empty;
            BtnCancelar.Enabled = false;
            BtnExcluir.Enabled = false;
        }

        private void FrmCargos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using ProjetoCafeteria.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCafeteria
{
    public partial class FrmFuncionarios : Form
    {
        private DataRowCollection ItemSelecionado;
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //esta listando todos os campos
            var listaDeCampos = new List<TextBox> {
                NomeDoFuncionario,
                Logradouro,
                Bairro,
                NumeroDaCasa,
                UF,
                CEP,
                Municipio,
                Telefone,
                TelefoneContato,
                Email,
                EmailContato,
                Observação,
                Password,
            };
            // limpando todos os campos com espaços extras e evitando o sql injection
            // subistituindo as aspas simples por nada 
            foreach (var item in listaDeCampos)
                item.Text = item.Text.Trim().Replace("'", "");
            //pegando todos o valores do campos digitados 
            var Valores = listaDeCampos.Select(x => $"'{x.Text}'").Aggregate((a,b)=>$"{a} , {b}");
            //pegando todos os nomes dos campos 
            var Nomes = listaDeCampos.Select(x => $"[{x.Name}]").Aggregate((a,b)=>$"{a} , {b}");

            // tratando o erro relacionado aos campos enviados para o banco de dados
            try
            {
                //comando sql pegando todos os nomes e todos os valores
                var sql = $@"INSERT INTO Funcionarios ({Nomes}, CargoId)
                VALUES ({Valores},{ItemSelecionado[IdCargo.SelectedIndex][0]})";
                //rodando o comando no banco de dados
                BD.RetornaDatatable(sql);

            }
            catch  
            {
                // caso cair no erro ele ira mostrar que os campos estão invalidos.
                MessageBox.Show(" Há campos incorretos! Verifique e tente novamente ", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {

            // esta criando o comando sql  
            var sql = $@"Select IdCargo ,NomeDoCargo  From Cargos";
            // Esta executando o comando sql e salvando as linhas dentro da propriedade item selecionado
            ItemSelecionado = BD.RetornaDatatable(sql).Rows;
            foreach (DataRow row in ItemSelecionado)
            {
                // adicionando na lista de seleção 
                
                IdCargo.Items.Add(row[1].ToString());

            }
        }
    }
}

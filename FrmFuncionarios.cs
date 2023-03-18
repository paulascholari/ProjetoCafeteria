using ProjetoCafeteria.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
                VALUES ({Valores},{ItemSelecionado[CargoId.SelectedIndex][0]})";
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
                
                CargoId.Items.Add(row[1].ToString());

            }
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            //esta listando todos os campos
            var listaDeCampos = new List<Control> {
                IdFuncionario,
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
                CargoId,
            };
            var Nomes = listaDeCampos.Select(x => $"[{x.Name}]").ToList();
            // abrindo a tela de localização de funcionarios
            var form = new FrmLocalizar( Nomes, "Funcionarios");
            form.ShowDialog();
            // tratando os erros 
            try
            {
                // pegando o item selecionado 
                var Funcionario = form.PegarItemSelecionado();
                // percorre a listaDeCampos pegando a posição atual para então pegar o valor do
                // item na tabela e passando para o campo respectivo
                for (int i = 0; i < listaDeCampos.Count; i++)
                {
                    // checa se o nome é o mesmo do campo de cargo porque ele é um campo de seleção
                    if (listaDeCampos[i].Name == CargoId.Name)
                        // Percorre a propriedade itemselecionado e verifica se o Cargo
                        // é o mesmo do funcionario localizado e quebra o loop passando
                        // o index selecionado para o campo de cargo
                        for (int j = 0; j < ItemSelecionado.Count; j++)
                        {
                            if (ItemSelecionado[j][0].ToString() == Funcionario[i].ToString())
                            {
                                CargoId.SelectedIndex = j;
                                break;
                            }
                        }
                    // Caso o item não seja o campo cargo, o texto dos outros itens é alterado
                    // pelo valor do item do banco de dados
                    else
                        listaDeCampos[i].Text = Funcionario[i].ToString();
                }

                BtnCancelar.Enabled = true;
                BtnExcluir.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
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
                IdFuncionario,
            };
            //resetando o campo cargo 
            CargoId.SelectedIndex = -1;
            // limpando todos os campos 
            foreach (var item in listaDeCampos)
                item.Text = "";
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            // limpando o codigo e evitando o sql injection
            var codigo=IdFuncionario.Text.Trim().Replace("'","");
            //verificando se o codigo não esta vazio
            if (codigo.Length > 0)
            {
                // tratando os erros quando tenta apagar no banco de dados
                try
                {
                    // comando sql para exclusão
                    var sql = $@"delete from Funcionarios where IdFuncionario = {codigo}";

                    
                    //rodando o comando
                    BD.RetornaDatatable(sql);
                    //fechando assim que deletar 
                    Close();
                    
                    
                }
                catch 
                {
                    // caso ocorrer algum erro vai exibir a messagem
                    MessageBox.Show(" Não foi possivel apagar", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
    }
}

﻿using ProjetoCafeteria.Classes;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private bool Validacao(string usuario, string senha)
        { 
            //limpando os espaços em branco da senha e do usuario e verificando se o campo não esta vazio
            if (usuario.Trim() == "" && senha.Trim() == "") return false; 
            string sql = $@"
                SELECT * FROM Funcionarios
                WHERE Email='{usuario}' AND Password='{senha}'
            "; 
            
            var dt = BD.RetornaDatatable(sql); 
            // verificando se existe o usuario 
            if(dt.Rows.Count != 0)
            {
                //salvando id do funcionario
                Login.SalvarFuncionarioId(int.Parse(dt.Rows[0][0].ToString()));
            }
            return dt.Rows.Count != 0;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            // apagando os espaços em branco  da senha e usuarío e removendo aspas simples para evitar sql injection
            var cSenha = txtSenha.Text.Replace("'", "").Trim();
            var cUsuario = txtUsuario.Text.Replace("'", "").Trim();
            if (cUsuario != "" && cSenha != "")
            {
                if (!Validacao(cUsuario, cSenha))
                {
                    //  serve para mostrar um aviso que o login ou a senha esta errada .
                    MessageBox.Show("Login/Senha invalidos", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            { 
                // para mostrar um aviso que existe campo vazio
                MessageBox.Show("Há Campos vazios", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Close();
        }

        private void Formclose(object sender, FormClosedEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

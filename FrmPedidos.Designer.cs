namespace ProjetoCafeteria
{
    partial class FrmPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IdPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnLocalizar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.ListaProdutos = new System.Windows.Forms.ListBox();
            this.BtnAdicionarProduto = new System.Windows.Forms.Button();
            this.BtnExcluirProduto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ClienteId = new System.Windows.Forms.ComboBox();
            this.Funcionario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Preco = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdPedido
            // 
            this.IdPedido.Enabled = false;
            this.IdPedido.Location = new System.Drawing.Point(12, 25);
            this.IdPedido.Name = "IdPedido";
            this.IdPedido.Size = new System.Drawing.Size(50, 20);
            this.IdPedido.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "CODIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "CLIENTE";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnExcluir);
            this.panel1.Controls.Add(this.BtnFechar);
            this.panel1.Controls.Add(this.BtnLocalizar);
            this.panel1.Controls.Add(this.BtnSalvar);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 34);
            this.panel1.TabIndex = 26;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(172, 3);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 30;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(360, 3);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 29;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnLocalizar
            // 
            this.BtnLocalizar.Location = new System.Drawing.Point(253, 3);
            this.BtnLocalizar.Name = "BtnLocalizar";
            this.BtnLocalizar.Size = new System.Drawing.Size(75, 23);
            this.BtnLocalizar.TabIndex = 28;
            this.BtnLocalizar.Text = "Localizar";
            this.BtnLocalizar.UseVisualStyleBackColor = true;
            this.BtnLocalizar.Click += new System.EventHandler(this.BtnLocalizar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(10, 3);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 27;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Enabled = false;
            this.BtnCancelar.Location = new System.Drawing.Point(91, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 26;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ListaProdutos
            // 
            this.ListaProdutos.FormattingEnabled = true;
            this.ListaProdutos.Location = new System.Drawing.Point(12, 104);
            this.ListaProdutos.Name = "ListaProdutos";
            this.ListaProdutos.Size = new System.Drawing.Size(205, 95);
            this.ListaProdutos.TabIndex = 27;
            // 
            // BtnAdicionarProduto
            // 
            this.BtnAdicionarProduto.Location = new System.Drawing.Point(12, 205);
            this.BtnAdicionarProduto.Name = "BtnAdicionarProduto";
            this.BtnAdicionarProduto.Size = new System.Drawing.Size(75, 23);
            this.BtnAdicionarProduto.TabIndex = 28;
            this.BtnAdicionarProduto.Text = "Adicionar";
            this.BtnAdicionarProduto.UseVisualStyleBackColor = true;
            this.BtnAdicionarProduto.Click += new System.EventHandler(this.BtnAdicionarProduto_Click);
            // 
            // BtnExcluirProduto
            // 
            this.BtnExcluirProduto.Location = new System.Drawing.Point(99, 205);
            this.BtnExcluirProduto.Name = "BtnExcluirProduto";
            this.BtnExcluirProduto.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluirProduto.TabIndex = 29;
            this.BtnExcluirProduto.Text = "Excluir";
            this.BtnExcluirProduto.UseVisualStyleBackColor = true;
            this.BtnExcluirProduto.Click += new System.EventHandler(this.BtnExcluirProduto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "PRODUTOS";
            // 
            // ClienteId
            // 
            this.ClienteId.FormattingEnabled = true;
            this.ClienteId.Location = new System.Drawing.Point(12, 64);
            this.ClienteId.Name = "ClienteId";
            this.ClienteId.Size = new System.Drawing.Size(205, 21);
            this.ClienteId.TabIndex = 31;
            // 
            // Funcionario
            // 
            this.Funcionario.Enabled = false;
            this.Funcionario.Location = new System.Drawing.Point(68, 25);
            this.Funcionario.Name = "Funcionario";
            this.Funcionario.Size = new System.Drawing.Size(100, 20);
            this.Funcionario.TabIndex = 32;
            this.Funcionario.TextChanged += new System.EventHandler(this.Funcionario_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "FUNCIONARIO";
            // 
            // Preco
            // 
            this.Preco.Enabled = false;
            this.Preco.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preco.Location = new System.Drawing.Point(223, 64);
            this.Preco.Name = "Preco";
            this.Preco.Size = new System.Drawing.Size(63, 20);
            this.Preco.TabIndex = 34;
            this.Preco.TextChanged += new System.EventHandler(this.Preco_TextChanged);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(223, 45);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 35;
            this.Total.Text = "Total";
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 266);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Preco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Funcionario);
            this.Controls.Add(this.ClienteId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnExcluirProduto);
            this.Controls.Add(this.BtnAdicionarProduto);
            this.Controls.Add(this.ListaProdutos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdPedido);
            this.Name = "FrmPedidos";
            this.Text = "Cadastro De Pedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnLocalizar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ListBox ListaProdutos;
        private System.Windows.Forms.Button BtnAdicionarProduto;
        private System.Windows.Forms.Button BtnExcluirProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ClienteId;
        private System.Windows.Forms.TextBox Funcionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Preco;
        private System.Windows.Forms.Label Total;
    }
}
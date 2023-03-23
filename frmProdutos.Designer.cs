namespace ProjetoCafeteria
{
    partial class frmProdutos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.IdProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnLocalizar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.Observação = new System.Windows.Forms.TextBox();
            this.Preco = new System.Windows.Forms.TextBox();
            this.NomeDoProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Unidade = new System.Windows.Forms.TextBox();
            this.CategoriaId = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "CODIGO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IdProduto
            // 
            this.IdProduto.Enabled = false;
            this.IdProduto.Location = new System.Drawing.Point(12, 25);
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.Size = new System.Drawing.Size(56, 20);
            this.IdProduto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "CATEGORIA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.panel1.Location = new System.Drawing.Point(0, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 33);
            this.panel1.TabIndex = 35;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.BtnFechar.Location = new System.Drawing.Point(351, 3);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 29;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.button5_Click);
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 127);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 64;
            this.label18.Text = "OBSERVAÇÃO";
            // 
            // Observação
            // 
            this.Observação.Location = new System.Drawing.Point(12, 143);
            this.Observação.Multiline = true;
            this.Observação.Name = "Observação";
            this.Observação.Size = new System.Drawing.Size(383, 41);
            this.Observação.TabIndex = 63;
            // 
            // Preco
            // 
            this.Preco.Location = new System.Drawing.Point(231, 64);
            this.Preco.Name = "Preco";
            this.Preco.Size = new System.Drawing.Size(79, 20);
            this.Preco.TabIndex = 65;
            // 
            // NomeDoProduto
            // 
            this.NomeDoProduto.Location = new System.Drawing.Point(12, 64);
            this.NomeDoProduto.Name = "NomeDoProduto";
            this.NomeDoProduto.Size = new System.Drawing.Size(213, 20);
            this.NomeDoProduto.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "NOME DO PRODUTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "PREÇO ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "UNIDADE";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Unidade
            // 
            this.Unidade.Location = new System.Drawing.Point(316, 64);
            this.Unidade.Name = "Unidade";
            this.Unidade.Size = new System.Drawing.Size(79, 20);
            this.Unidade.TabIndex = 72;
            // 
            // CategoriaId
            // 
            this.CategoriaId.FormattingEnabled = true;
            this.CategoriaId.Location = new System.Drawing.Point(12, 103);
            this.CategoriaId.Name = "CategoriaId";
            this.CategoriaId.Size = new System.Drawing.Size(156, 21);
            this.CategoriaId.TabIndex = 73;
            this.CategoriaId.SelectedIndexChanged += new System.EventHandler(this.CategoriaId_SelectedIndexChanged);
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 226);
            this.Controls.Add(this.CategoriaId);
            this.Controls.Add(this.Unidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomeDoProduto);
            this.Controls.Add(this.Preco);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Observação);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdProduto);
            this.Name = "frmProdutos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FrmCriarPedidos_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnLocalizar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Observação;
        private System.Windows.Forms.TextBox Preco;
        private System.Windows.Forms.TextBox NomeDoProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Unidade;
        private System.Windows.Forms.ComboBox CategoriaId;
    }
}
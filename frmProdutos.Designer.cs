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
            this.TextCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnLocalizar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.TextObservacao = new System.Windows.Forms.TextBox();
            this.TextPreco = new System.Windows.Forms.TextBox();
            this.TextCategoria = new System.Windows.Forms.TextBox();
            this.TextProdutos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TextUnidade = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "CODIGO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextCodigo
            // 
            this.TextCodigo.Location = new System.Drawing.Point(12, 25);
            this.TextCodigo.Name = "TextCodigo";
            this.TextCodigo.Size = new System.Drawing.Size(56, 20);
            this.TextCodigo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
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
            this.panel1.Controls.Add(this.BtnNovo);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 35;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(253, 16);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 30;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(432, 16);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 29;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnLocalizar
            // 
            this.BtnLocalizar.Location = new System.Drawing.Point(334, 16);
            this.BtnLocalizar.Name = "BtnLocalizar";
            this.BtnLocalizar.Size = new System.Drawing.Size(75, 23);
            this.BtnLocalizar.TabIndex = 28;
            this.BtnLocalizar.Text = "Localizar";
            this.BtnLocalizar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(91, 16);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 27;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(10, 16);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 25;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Enabled = false;
            this.BtnCancelar.Location = new System.Drawing.Point(172, 16);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 26;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 64;
            this.label18.Text = "OBSERVAÇÃO";
            // 
            // TextObservacao
            // 
            this.TextObservacao.Location = new System.Drawing.Point(12, 142);
            this.TextObservacao.Multiline = true;
            this.TextObservacao.Name = "TextObservacao";
            this.TextObservacao.Size = new System.Drawing.Size(454, 41);
            this.TextObservacao.TabIndex = 63;
            // 
            // TextPreco
            // 
            this.TextPreco.Location = new System.Drawing.Point(231, 64);
            this.TextPreco.Name = "TextPreco";
            this.TextPreco.Size = new System.Drawing.Size(79, 20);
            this.TextPreco.TabIndex = 65;
            // 
            // TextCategoria
            // 
            this.TextCategoria.Location = new System.Drawing.Point(12, 103);
            this.TextCategoria.Name = "TextCategoria";
            this.TextCategoria.Size = new System.Drawing.Size(213, 20);
            this.TextCategoria.TabIndex = 66;
            // 
            // TextProdutos
            // 
            this.TextProdutos.Location = new System.Drawing.Point(12, 64);
            this.TextProdutos.Name = "TextProdutos";
            this.TextProdutos.Size = new System.Drawing.Size(213, 20);
            this.TextProdutos.TabIndex = 67;
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
            // TextUnidade
            // 
            this.TextUnidade.Location = new System.Drawing.Point(316, 64);
            this.TextUnidade.Name = "TextUnidade";
            this.TextUnidade.Size = new System.Drawing.Size(79, 20);
            this.TextUnidade.TabIndex = 72;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 257);
            this.Controls.Add(this.TextUnidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextProdutos);
            this.Controls.Add(this.TextCategoria);
            this.Controls.Add(this.TextPreco);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TextObservacao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextCodigo);
            this.Name = "frmProdutos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FrmCriarPedidos_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnLocalizar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TextObservacao;
        private System.Windows.Forms.TextBox TextPreco;
        private System.Windows.Forms.TextBox TextCategoria;
        private System.Windows.Forms.TextBox TextProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TextUnidade;
    }
}
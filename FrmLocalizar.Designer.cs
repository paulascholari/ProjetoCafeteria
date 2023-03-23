namespace ProjetoCafeteria
{
    partial class FrmLocalizar
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
            this.ListaDeLocalizar = new System.Windows.Forms.DataGridView();
            this.Pesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDeLocalizar)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaDeLocalizar
            // 
            this.ListaDeLocalizar.AllowUserToAddRows = false;
            this.ListaDeLocalizar.AllowUserToDeleteRows = false;
            this.ListaDeLocalizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaDeLocalizar.Location = new System.Drawing.Point(0, 92);
            this.ListaDeLocalizar.MultiSelect = false;
            this.ListaDeLocalizar.Name = "ListaDeLocalizar";
            this.ListaDeLocalizar.ReadOnly = true;
            this.ListaDeLocalizar.RowHeadersVisible = false;
            this.ListaDeLocalizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaDeLocalizar.Size = new System.Drawing.Size(702, 320);
            this.ListaDeLocalizar.TabIndex = 3;
            this.ListaDeLocalizar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaDeLocalizar_CellContentClick);
            // 
            // Pesquisa
            // 
            this.Pesquisa.Location = new System.Drawing.Point(15, 40);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(608, 20);
            this.Pesquisa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Localizar";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProjetoCafeteria.Properties.Resources.Icontexto_Search_Search_black_256;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(629, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLocalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 414);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pesquisa);
            this.Controls.Add(this.ListaDeLocalizar);
            this.Name = "FrmLocalizar";
            this.Text = "FrmLocalizar";
            this.Load += new System.EventHandler(this.FrmLocalizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaDeLocalizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaDeLocalizar;
        private System.Windows.Forms.TextBox Pesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
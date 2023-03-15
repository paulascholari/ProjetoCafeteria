namespace ProjetoCafeteria
{
    partial class FrmCategoriaLocalizar
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
            this.ListaCategorias = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListaCategorias
            // 
            this.ListaCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaCategorias.FormattingEnabled = true;
            this.ListaCategorias.Location = new System.Drawing.Point(0, 0);
            this.ListaCategorias.Name = "ListaCategorias";
            this.ListaCategorias.Size = new System.Drawing.Size(800, 450);
            this.ListaCategorias.TabIndex = 1;
            this.ListaCategorias.SelectedIndexChanged += new System.EventHandler(this.ListaCategorias_SelectedIndexChanged_1);
            // 
            // FrmCategoriaLocalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaCategorias);
            this.Name = "FrmCategoriaLocalizar";
            this.Text = "FrmCategoriaLocalizar";
            this.Load += new System.EventHandler(this.FrmCategoriaLocalizar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListaCategorias;
    }
}
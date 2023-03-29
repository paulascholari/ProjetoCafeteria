namespace ProjetoCafeteria
{
    partial class FrmCategoriaRealatorios
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bebidas",
            "5",
            "Carlos Kruse 61"}, -1);
            this.Lista = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.Lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lista.HideSelection = false;
            this.Lista.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.Lista.Location = new System.Drawing.Point(0, 0);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(800, 450);
            this.Lista.TabIndex = 1;
            this.Lista.UseCompatibleStateImageBehavior = false;
            this.Lista.View = System.Windows.Forms.View.Details;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome Da Categoria";
            this.columnHeader1.Width = 674;
            // 
            // FrmCategoriaRealatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lista);
            this.Name = "FrmCategoriaRealatorios";
            this.Text = "Relatório Categorias";
            this.Load += new System.EventHandler(this.FrmCategoriaRealatorios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Lista;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
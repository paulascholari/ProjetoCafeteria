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
    public partial class FrmCategoriaLocalizar : Form
    {
        public FrmCategoriaLocalizar()
        {
            InitializeComponent();
        }

        private void FrmCategoriaLocalizar_Load(object sender, EventArgs e)
        {
            var sql = $@"Select IdCategoria ,NomeDaCategoria  From Categorias";
            var Categorias = BD.RetornaDatatable(sql);
            if (Categorias.Rows.Count != 0)
            {
                foreach (DataRow row in Categorias.Rows)
                {
                    ListaCategorias.Items.Add(row[1].ToString());
                }
            }
        }
    }
}

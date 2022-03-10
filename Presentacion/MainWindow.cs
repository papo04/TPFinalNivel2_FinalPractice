using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Presentacion
{
    public partial class MainWindow : Form

    {
        private List<Items> itemList; 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            ItemNegocio negocio = new ItemNegocio();
            itemList = negocio.listar();
            dgvItems.DataSource = itemList;

        }
    }
}

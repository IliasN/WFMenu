using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Menu menu;

        private void btnBeef_Click(object sender, EventArgs e)
        {
            menu.AddBeef();
            if (menu.NbBeef > 0)
            {
                btnBeef.Text = menu.NbBeef.ToString() + " : Roti de boeuf";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menu = new Menu();
        }

        private void btnSpag_Click(object sender, EventArgs e)
        {
            menu.AddSpag();
            if (menu.NbSpag > 0)
            {
                btnSpag.Text = menu.NbSpag.ToString() + " : Plat de spaghettis";
            }
        }

        private void btnTruite_Click(object sender, EventArgs e)
        {
            menu.AddTruite();
            if (menu.NbTruite > 0)
            {
                btnTruite.Text = menu.NbTruite.ToString() + " : Truite aux amandes";
            }
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            menu.AddDessert();
            if (menu.NbDessert > 0)
            {
                btnDessert.Text = menu.NbDessert.ToString() + " : Dessert";
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            tbxResult.Text += menu.ToString();
            menu = new Menu();
            btnDessert.Text ="Dessert";
            btnTruite.Text = "Truite aux amandes";
            btnSpag.Text = "Plat de spaghettis";
            btnBeef.Text = "Roti de boeuf";
        }
    }
}

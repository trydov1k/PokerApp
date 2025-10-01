using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerApp
{
    
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>Закрывает текущее окно и открывает окно MainForm</summary>
        private void OpenMainWindow()
        { 
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            OpenMainWindow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenMainWindow();
        }
    }
}

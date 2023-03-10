using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Data.SqlClient;

namespace menu
{
    public partial class Form1 : Form
    {
        UCunos_hemije u2;
        UCskladiste_hemije u3;
        Lista_ulaza_hemikalija_UC u4;
        UserControl2 u5;
        public Form1()
        {
            InitializeComponent();
            u2 = new UCunos_hemije();
            u3 = new UCskladiste_hemije();
            u4=new Lista_ulaza_hemikalija_UC();
            u5=new UserControl2();
        }

        private void hemija_btn_Click(object sender, EventArgs e)
        {

            u5.Hide();
            u3.Hide();
            u4.Hide();
            u2.Show();
            u2.Dock=DockStyle.Fill;
            dock_uc_pan.Controls.Add(u2);
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Skladiste_btn_Click(object sender, EventArgs e)
        {
            u5.Hide();
            u2.Hide();
            u4.Hide();
            u3.Show();
            u3.Dock = DockStyle.Fill;
         
            dock_uc_pan.Controls.Add(u3);

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ulaz_hem_btn_Click(object sender, EventArgs e)
        {
            u5.Hide();
            u2.Hide();
            u3.Hide();
            u4.Show();
            u4.Dock=DockStyle.Fill;
            dock_uc_pan.Controls.Add(u4);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            u5.Show();
            u2.Hide();
            u3.Hide();
            u4.Hide();
            u5.Dock = DockStyle.Fill;
            dock_uc_pan.Controls.Add(u5);
        }
    }
}

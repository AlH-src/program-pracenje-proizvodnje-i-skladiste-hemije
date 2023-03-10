using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;

namespace menu
{
    public partial class UserControl2 : UserControl
    {
        
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
          
        }

        private void tableLayoutPanel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "none";

            string CONNSTRING = "server=localhost;uid=root;pwd=korisnik;database=hemija";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = CONNSTRING;
            con.Open();
            float odm = float.Parse(Odmašživanje_analiza.Text);
            float dezo1 = float.Parse(Dez_1_konc.Text);
            float dezo2 = float.Parse(Dez_2_konc.Text);
            float eo1 = float.Parse(EO_1.Text);
            float eo2 = float.Parse(EO_2.Text);
            float neut = float.Parse(neu.Text);
            float dekap = float.Parse(Dekap.Text);
            float cink = float.Parse(Cink.Text);
            float NAOH = float.Parse(NaOH.Text);
            float R_hem = float.Parse(R.Text);
            float zuti_pas = float.Parse(Zuti_pas.Text);
            float plavi_pas=float.Parse(Plavi_pas.Text);
            float plavi_pas2=float.Parse(plavi_pas_kk_10.Text);
            try
            {
                if (comboBox1.ValueMember == "LINIJA ALKALNOG CINKA 19-1-22 (VELIKA)")
                {
                    sql = "USE INSERT INTO dik_analiza_vl (odmascivanje_analiza,dezoksidacija_1_konc,dezoksidacija_2_konc,elektroodmascivac_1_konc,elektroodmascivac_2_konc,neutralizacija,dekapiranje,cinkanje_konc_zn,NaOH ,R,zuti_pasivat_konc,plavi_pasivat_1 ,plavi_pasivat_konc_2 ,datum) values('" + odm + "','" + dezo1 + "','" + dezo2 + "','" + eo1 + "','" + eo2 + "','" + neut + "','" + dekap + "','" + cink + "','" + cink + "','" + NAOH + "','" + R_hem + "','" + zuti_pas + "','" + plavi_pas + "','" + plavi_pas2 + "')";
                }
            }catch(Exception ex) 
            {
             MessageBox.Show(ex.Message);
            }


        }
    }
    
}

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
    public partial class UCunos_hemije : UserControl
    {
        public UCunos_hemije()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "none";

                string CONNSTRING = "server=localhost;uid=tehnolog;pwd=tehnolog;database=skladiste_hemije";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = CONNSTRING;
                con.Open();
                DateTime datum = dateTimePicker1.Value;
                int kolicina = int.Parse(Kolicina_txtb.Text);
                string sifra = sifra_txtb.Text;
                string naziv = naziv_txtb.Text;
                string interni_naziv = Interninaziv_txtb.Text;
                string jm = jm_cmbx.Text;
                
                int kol_pak = int.Parse(Kolpak_txtb.Text);
                int pak = kol_pak / kolicina;

                if (int.Parse(Kolicina_txtb.Text) != 0)
                {

                    sql = "INSERT INTO (sifra,naziv,interni_naziv,kolicina,J_MJ,pak,kol_pak,datum) VALUES('" + sifra + "','" + naziv + "','" + interni_naziv + "','" + kolicina + "','" + jm + "','" + pak + "','" + kol_pak + "','" + datum;

                }
                else
                {
                    MessageBox.Show("Količina nije unešena");
                }

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT LAST_INSERT_ID()";
                int lastInsertedId = Convert.ToInt32(cmd.ExecuteScalar());
                if (int.Parse(br_lbl.Text) <= 0 || int.Parse(br_lbl.Text) < lastInsertedId)
                {
                    br_lbl.Text = lastInsertedId.ToString();

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Greška pri unosu " + exc.Message);
            }
        }

        private void br_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}

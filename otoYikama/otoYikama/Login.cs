using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otoYikama
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;

        public static string ad;

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string personel, password;
           
            con = new SqlConnection("server=DESKTOP-MILUGA6; Initial Catalog=otoYikama;Integrated Security=SSPI");

            personel = txt_ad.Text;
            password = txt_sifre.Text;

            try
            {
                string query = "SELECT * FROM personel WHERE personel_ad = '" + txt_ad.Text + "' AND password = '" + txt_sifre.Text + "'";
                da = new SqlDataAdapter(query, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    otoYikama otoYikama = new otoYikama();
                    otoYikama.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya Şifreyi kontrol ediniz!");
                    txt_ad.Clear();
                    txt_sifre.Clear();

                    txt_ad.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                con.Close();
            }
            
           
        }
    }
}

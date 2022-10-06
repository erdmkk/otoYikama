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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace otoYikama
{
    public partial class otoYikama : Form
    {
        public otoYikama()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        void veriCek()
        {
            con = new SqlConnection("server=DESKTOP-MILUGA6;Initial Catalog=otoYikama; Integrated Security=True");
            da = new SqlDataAdapter("Select *from musteri", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "musteri");
            dtg_arac.DataSource = ds.Tables["musteri"];
            con.Close();
        }
        void fiyatList()
        {
            con = new SqlConnection("server=DESKTOP-MILUGA6;Initial Catalog=otoYikama; Integrated Security=True");
            da = new SqlDataAdapter("Select *from arac", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "arac");
            dtg_fiyatList.DataSource = ds.Tables["arac"];
            con.Close();
        }

        void txtClear()
        {
            txt_ad.Text = "";
            txt_soyad.Text = "";
            txt_plaka.Text = "";
            txt_tel.Text = "";
            cbox_aracTuru.Items.Clear();    
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {        
            con.Open();
            string kayit = "insert into musteri(musteri_ad,musteri_soyad,telefon,plaka) values (@ad,@soyad,@telefon,@plaka)";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@ad", txt_ad.Text);
            cmd.Parameters.AddWithValue("@soyad", txt_soyad.Text);
            cmd.Parameters.AddWithValue("@telefon", txt_tel.Text);
            cmd.Parameters.AddWithValue("@plaka", txt_plaka.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            veriCek();
            txtClear();
        }
         private void btn_cikar_Click(object sender, EventArgs e)
         {
            con.Open();
            cmd = new SqlCommand("DELETE FROM musteri WHERE plaka=@plaka", con);
            cmd.Parameters.AddWithValue("@plaka", txt_plaka.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            veriCek();
            txtClear();
         }
        private void otoYikama_Load(object sender, EventArgs e)
        {
            veriCek();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fiyatList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}

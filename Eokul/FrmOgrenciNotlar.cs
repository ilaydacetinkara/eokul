using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Eokul
{
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LQ8HBDS;Initial Catalog=OkulSistemi;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string numara;
        
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select DersAd,Sınav1,Sınav2,Sınav3,Proje,Ortalama,Durum From Tbl_Notlar INNER JOIN Tbl_Ders on Tbl_Notlar.Dersid = Tbl_Ders.Dersid where Ogrenciid= @P1", baglanti);
            komut.Parameters.AddWithValue("@P1", numara);
            label1.Text = "Ögrenci No: " +  numara.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }
    }
}

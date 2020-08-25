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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LQ8HBDS;Initial Catalog=OkulSistemi;Integrated Security=True");

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kulup", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "KulupAd";
            comboBox1.ValueMember = "Kulupid";

            comboBox1.DataSource = dt;
            baglanti.Close();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }
        string c = "";
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            
            
            ds.OgrenciEkle(TxtAd.Text, TxtSoyad.Text, byte.Parse(comboBox1.SelectedValue.ToString()), c);
            MessageBox.Show("Öğrenci Eklendi");
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(TxtID.Text));
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            TxtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            c = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (c == "Kız")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            if (c == "Erkek")

            {

                radioButton1.Checked = false;

                radioButton2.Checked = true;

            }
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(TxtAd.Text, TxtSoyad.Text, byte.Parse(comboBox1.SelectedValue.ToString()), c,int.Parse(TxtID.Text));
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                c = "Kız";
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                c = "Erkek";
            }
           
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciArama(TxtAra.Text);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FrmOgretmen fr = new FrmOgretmen();
            fr.Show();
            this.Hide();
        }
    }
}

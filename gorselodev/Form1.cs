using System;
using System.Windows.Forms;
using System.Data;        
using System.Data.OleDb;  

namespace gorselodev
{
    public partial class Form1 : Form
    {

        private string connectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\EXCAL�BUR\Desktop\gorsel.accdb;Persist Security Info=False;";

        public Form1()
        {
            InitializeComponent();
            LoadTumOyunlar();
            LoadKategoriler();
        }
        private void tabPageTumOyunlar_Enter(object sender, EventArgs e)
        {
            LoadTumOyunlar();
        }

        private void tabPageKategoriler_Enter(object sender, EventArgs e)
        {
            LoadKategoriler();
        }

        private void LoadTumOyunlar()
        {

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT oyun_adi, oyun_fiyati, oyun_cikis_yili FROM Tablo1";

                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewTumOyunlar.DataSource = dt;
            }
        }
        private void LoadKategoriler()
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT oyun_adi, kategori FROM Tablo1";

                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewKategoriler.DataSource = dt;
            }
        }

        private void yARDIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "bu site kullan�c�lar�n h�zl� ve pratik bir �ekilde pop�ler oyunlar� bulmalar� i�in tasarland�.\n" +
                "� T�m Oyunlar sekmesinde: Oyun ad�, fiyat ve ��k�� y�l�.\n" +
                "� Kategoriler sekmesinde: Oyun ad� ve kategori bilgisi.\n\n" +
                "Ek bilgiler i�in l�tfen 0366 866 10 04 numaras�n� aray�n.",
                "Yard�m",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ��k��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ��k��ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String path = @"Data Source=INDRIANNA\IDR;Initial Catalog=Tasklists;User Id=sa;password=sa;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        SqlDataAdapter adpt2;
        DataSet ds;
        DataTable dt;
        DataTable dt2;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            load_data();
            load_status();
        }

        public void load_status()
        {
            con.Open();
            string query = "select StatusID,Status from status";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader DR = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("StatusID", typeof(int));
            dt.Load(DR);
            cmbStatus.ValueMember = "StatusID";
            cmbStatus.DisplayMember = "Status";
            cmbStatus.DataSource = dt;

            cmbStatus.Enabled = false;
            con.Close();
            
        }

        public void load_data()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("select t.ID,tittle,description,s.Status from tasklists t inner join status s on s.statusid = t.status", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            txt_tittle.Text = "";
            Txt_desc.Text = "";
            lblupdate.Text = "0";

            txt_tittle.Enabled = false;
            Txt_desc.Enabled = false;

            btn_hapus.Enabled = false;
            btn_simpan.Enabled = false;
            cmbStatus.Enabled = false;
        }
        private void btn_tambah_Click(object sender, EventArgs e)
        {
            txt_tittle.Enabled = true;
            Txt_desc.Enabled = true;
            btn_simpan.Enabled = true;
            cmbStatus.Enabled = true;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (txt_tittle.Text == "")
            {
                MessageBox.Show("tittle  tidak boleh kosong");
            }
            else if (Txt_desc.Text == "")
            {
                MessageBox.Show("description  tidak boleh kosong");
            }
            else
            {
               
                if (lblupdate.Text == "0")
                {
                   
                        con.Open();
                        cmd = new SqlCommand(" insert into tasklists(tittle,description,createdDate,updateDate,status) values('" + txt_tittle.Text + "','" + Txt_desc.Text + "',GETDATE(),GETDATE(),'"+cmbStatus.SelectedValue.ToString()+"')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Berhasil menambahkan data");
                    
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("update  tasklists set tittle='" + txt_tittle.Text + "', description='" + Txt_desc.Text + "', status ='"+cmbStatus.SelectedValue.ToString()+"' where ID='" + labelID.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Berhasil update data");

                }
                load_data();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
            {
                labelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_tittle.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Txt_desc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                lblupdate.Text = "1";

                txt_tittle.Enabled = true;
                Txt_desc.Enabled = true;

                btn_simpan.Enabled = true;
                btn_hapus.Enabled = true;
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand("delete  tasklists  where ID='" + labelID.Text.ToString() + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil menghapus data");

                load_data();
            }
            else if (dialogResult == DialogResult.No)
            {
                load_data();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
            {
                labelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_tittle.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Txt_desc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cmbStatus.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                lblupdate.Text = "1";

                txt_tittle.Enabled = true;
                Txt_desc.Enabled = true;

                btn_simpan.Enabled = true;
                btn_hapus.Enabled = true;
                cmbStatus.Enabled = true;
            }
        }

       
    }
}

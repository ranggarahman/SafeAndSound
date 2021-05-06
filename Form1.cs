using SafeAndSound.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeAndSound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        detailClass c = new();
        private void btnAdd_Click(object sender, EventArgs e)
        {

            c.FirstName = txtboxFirstName.Text;
            c.LastName = txtboxLastName.Text;
            c.ContactNumber = txtboxContactNumber.Text;
            c.Address = txtboxAddress.Text;
            c.Gender = cmbGender.Text;
            insertClass ins = new();
            bool success = ins.Insert(c);
            if (success == true)
            {
                MessageBox.Show("Data berhasil dimasukkan");
                Clear();
            }
            else
            {
                MessageBox.Show("Input gagal");
            }

            selectClass slc = new();
            DataTable dt = slc.Select();
            dgvContactList.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectClass slc = new();
            DataTable dt = slc.Select();
            dgvContactList.DataSource = dt;
        }

        public void Clear()
        {
            txtboxFirstName.Text = txtboxLastName.Text = txtboxContactNumber.Text = txtboxAddress.Text = txtboxContactID.Text = cmbGender.Text="";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Cara update adlah : Pilih baris pada tabel, lalu edit pada textbox dengan informasi baru
            c.ContactID = int.Parse(txtboxContactID.Text);
            c.FirstName = txtboxFirstName.Text;
            c.LastName = txtboxLastName.Text;
            c.ContactNumber = txtboxContactNumber.Text;
            c.Address = txtboxAddress.Text;
            c.Gender = cmbGender.Text;

            updateClass updt = new();
            bool success = updt.Update(c);
            if (success == true)
            {
                MessageBox.Show("Data berhasil terupdate");
                selectClass slc = new();
                DataTable dt = slc.Select();
                dgvContactList.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Gagal");
            }
        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Mengambil data dari data grid, lalu memuatnya ke textbox
            //Mencari tahu di baris mana mouse di klik
            int rowIndex = e.RowIndex;
            txtboxContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtboxContactNumber.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtboxAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.ContactID = Convert.ToInt32(txtboxContactID.Text);
            deleteClass dlt = new();
            bool success = dlt.Delete(c);
            if(success == true)
            {
                MessageBox.Show("Data berhasil dihapus");
                selectClass slc = new();
                DataTable dt = slc.Select();
                dgvContactList.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Data gagal dihapus");
            }
        }
    }
}

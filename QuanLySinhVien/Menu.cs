using QuanLySinhVien.Data;
using QuanLySinhVien.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Menu : Form
    {
        /*-------------------------------------------------------*/
        SinhVienRepository repository = new SinhVienRepository();
        List<SinhVien> list = new List<SinhVien>();
        /*-------------------------------------------------------*/
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            grbTIMSV.Hide();
            FormatTable();
            LoadTableFromDatabase();
        }
        #region PhuongThucBoTro

        void FormatTable()
        {
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dgvResult.DefaultCellStyle.ForeColor = Color.Blue;
            dgvResult.DefaultCellStyle.BackColor = Color.Beige;   //Beige
            dgvResult.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            dgvResult.DefaultCellStyle.SelectionBackColor = Color.Black;
            dgvResult.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvResult.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
        }

        void ClearTextBox()
        {
            txtHO.Text = "";
            txtTEN.Text = "";
            txtNGAYSINH.Text = "";
            txtDIACHI.Text = "";
            txtNGANH.Text = "";
        }

        void LoadTableFromDatabase()
        {
            ClearTable();
            list = repository.Read();
            dgvResult.DataSource = list;
            dgvResult.Columns["Id"].Visible = false;
        }

        void LoadTableFromList()
        {
            ClearTable();
            dgvResult.DataSource = list;
            dgvResult.Columns["Id"].Visible = false;
        }

        void ClearTable()
        {
            dgvResult.DataSource = null;
            dgvResult.Rows.Clear();
        }
        #endregion

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Closed += (s, agrs) => this.Close();
            login.Show();
        }

        private void dgvResult_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvResult.SelectedRows)
            {
                txtHO.Text = row.Cells[1].Value.ToString();
                txtTEN.Text = row.Cells[2].Value.ToString();
                txtNGAYSINH.Text = row.Cells[3].Value.ToString();
                if (Convert.ToBoolean(row.Cells[4].Value) == true)
                    rdbNAM.Checked = true;
                else rdbNU.Checked = true;
                txtDIACHI.Text = row.Cells[5].Value.ToString();
                txtNGANH.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien
            {
                Ho = txtHO.Text,
                Ten = txtTEN.Text,
                NgaySinh = Convert.ToDateTime(txtNGAYSINH.Text),
                GioiTinh = (rdbNAM.Checked) ? 1 : 0,
                DiaChi = txtDIACHI.Text,
                NganhHoc = txtNGANH.Text,
                MaSinhVien = "",
                Email = ""
            };
            repository.Insert(sv);
            LoadTableFromDatabase();
            ClearTextBox();
        }

        private void btnSXDS_Click(object sender, EventArgs e)
        {
            ClearTable();
            dgvResult.DataSource = repository.Sort();
            dgvResult.Columns["Id"].Visible = false;
            list = repository.Sort();
        }

        private void btnTimSV_Click(object sender, EventArgs e)
        {
            grbTIMSV.Show();
        }

        private void txtTKMSV_TextChanged(object sender, EventArgs e)
        {
            ClearTable();
            dgvResult.DataSource = repository.Search(txtSearch.Text);
            dgvResult.Columns["Id"].Visible = false;
        }

        private void btnCLOSESEARCH_Click(object sender, EventArgs e)
        {
            grbTIMSV.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm Delete ?", "Warning !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int deleteID = 0;
                foreach (DataGridViewRow row in dgvResult.SelectedRows)
                {
                    deleteID = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
                repository.Delete(deleteID);
                LoadTableFromDatabase();
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updateId = 0;
            foreach (DataGridViewRow row in dgvResult.SelectedRows)
            {
                updateId = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
            SinhVien sv = new SinhVien
            {
                Id = updateId,
                Ho = txtHO.Text,
                Ten = txtTEN.Text,
                NgaySinh = Convert.ToDateTime(txtNGAYSINH.Text),
                GioiTinh = (rdbNAM.Checked) ? 1 : 0,
                DiaChi = txtDIACHI.Text,
                NganhHoc = txtNGANH.Text,
                MaSinhVien = "",
                Email = ""
            };
            repository.Update(sv);
            LoadTableFromDatabase();
            ClearTextBox();
        }
        #region MSV Email XuatDS
        private void btnXuatDS_Click(object sender, EventArgs e)
        {
            if (dgvResult.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dgvResult.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dgvResult.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dgvResult.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dgvResult.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dgvResult.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void btnCMSV_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int stt = 102190200 + i;
                list[i].MaSinhVien = stt.ToString();
            }
            ClearTable();
            LoadTableFromList();
        }

        private void btnCESV_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Email = String.Concat(list[i].MaSinhVien, "@sv.dut.edu.vn");
            }
            ClearTable();
            LoadTableFromList();
        }
        #endregion

    }
}

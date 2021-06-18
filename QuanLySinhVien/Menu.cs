using MaterialSkin;
using MaterialSkin.Controls;
using QuanLySinhVien.Data;
using QuanLySinhVien.Model;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using QuanLySinhVien;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public partial class Menu : MaterialForm
    {
        /*-------------------------------------------------------*/
        private readonly SinhVienRepository repository;
        SortableBindingList<SinhVien> list = new SortableBindingList<SinhVien>();
        /*-------------------------------------------------------*/
        public Menu()
        {
            InitializeComponent();
            repository = new SinhVienRepository();
            SetupMaterialSkin();
            dgvResult.FormatDataGridView();
        }

        private async void Menu_Load(object sender, EventArgs e)
        {
            await LoadTableFromDatabase();
        }

        #region PhuongThucBoTro
        private void SetupMaterialSkin()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ROBOTO_REGULAR_11 = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular);
            materialSkinManager.ROBOTO_MEDIUM_12 = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular);
            materialSkinManager.ROBOTO_MEDIUM_11 = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular);
            //materialSkinManager.ROBOTO_MEDIUM_10 = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular);
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700,
                                                Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }
        private void ClearTextBox()
        {
            txtHO.Text = "";
            txtTEN.Text = "";
            txtNGAYSINH.Text = "";
            txtDIACHI.Text = "";
            txtNGANH.Text = "";
        }

        private async Task LoadTableFromDatabase()
        {
            ClearTable();
            list = (await repository.Read()).ToSortableBindingList();
            dgvResult.DataSource = list;
            dgvResult.Columns["Id"].Visible = false;
        }

        private void LoadTableFromList()
        {
            ClearTable();
            dgvResult.DataSource = list;
            dgvResult.Columns["Id"].Visible = false;
        }

        private void ClearTable()
        {
            dgvResult.DataSource = null;
            dgvResult.Rows.Clear();
        }
        #endregion

        #region CRUD
        private void dgvResult_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvResult.SelectedRows)
            {
                txtHO.Text = row.Cells["Ho"].Value.ToString();
                txtTEN.Text = row.Cells["Ten"].Value.ToString();
                txtNGAYSINH.Text = row.Cells["NgaySinh"].Value.ToString();
                if (Convert.ToBoolean(row.Cells["GioiTinh"].Value) == true)
                    rdbNAM.Checked = true;
                else rdbNU.Checked = true;
                txtDIACHI.Text = row.Cells["DiaChi"].Value.ToString();
                txtNGANH.Text = row.Cells["NganhHoc"].Value.ToString();
            }
        }

        private async void btnThemSV_Click(object sender, EventArgs e)
        {
            try
            {
                await repository.Insert(new SinhVien()
                {
                    Ho = txtHO.Text,
                    Ten = txtTEN.Text,
                    NgaySinh = Convert.ToDateTime(txtNGAYSINH.Text),
                    GioiTinh = (rdbNAM.Checked) ? 1 : 0,
                    DiaChi = txtDIACHI.Text,
                    NganhHoc = txtNGANH.Text,
                    MaSinhVien = "",
                    Email = ""
                });
                await LoadTableFromDatabase();
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvResult.SelectedRows;
            if (r.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xoá ?", "Bình tĩnh !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in r)
                    {
                        await repository.Delete(Convert.ToInt32(row.Cells["Id"].Value));
                    }
                }
                await LoadTableFromDatabase();
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection r = dgvResult.SelectedRows;
                await repository.Update(new SinhVien()
                {
                    Id = Convert.ToInt32(r[0].Cells["Id"].Value),
                    Ho = txtHO.Text,
                    Ten = txtTEN.Text,
                    NgaySinh = Convert.ToDateTime(txtNGAYSINH.Text),
                    GioiTinh = (rdbNAM.Checked) ? 1 : 0,
                    DiaChi = txtDIACHI.Text,
                    NganhHoc = txtNGANH.Text,
                    MaSinhVien = "",
                    Email = ""
                });
                await LoadTableFromDatabase();
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ClearTable();
            dgvResult.DataSource = (await repository.Search(txtSearch.Text)).ToSortableBindingList();
            dgvResult.Columns["Id"].Visible = false;
        }
        #endregion

        #region MSV-Email
        private async void btnCMSV_Click(object sender, EventArgs e)
        {
            Task task = new Task(() =>
            {
                for (int i = 0; i < list.Count; i++)
                {
                    int stt = 102190200 + i;
                    list[i].MaSinhVien = stt.ToString();
                }
            });
            task.Start();
            await task;
            ClearTable();
            LoadTableFromList();
        }

        private async void btnCESV_Click(object sender, EventArgs e)
        {
            Task task = new Task(() =>
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].Email = String.Concat(list[i].MaSinhVien, "@sv.dut.edu.vn");
                }
            });
            task.Start();
            await task;
            ClearTable();
            LoadTableFromList();
        }
        #endregion

        #region MSV Email XuatDS
        private void ExportCSV()
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
                                    object value = dgvResult.Rows[i - 1].Cells[j].Value;
                                    string output = (value != null) ? (value.ToString()) : "";
                                    outputCsv[i] += output + ",";
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

        private void btnXuatDS_Click(object sender, EventArgs e)
        {
            ExportCSV();
        }
        #endregion
    }
}

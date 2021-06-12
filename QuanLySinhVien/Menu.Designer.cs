namespace QuanLySinhVien
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.grbTIMSV = new System.Windows.Forms.GroupBox();
            this.btnCLOSESEARCH = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtHO = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDIACHI = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTEN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNGAYSINH = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNGANH = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rdbNAM = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbNU = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnThemSV = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnXuatDS = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnTimSV = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCESV = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCMSV = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSXDS = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.grbTIMSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ SV :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên SV : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(547, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(797, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giới tính : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Địa chỉ : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(543, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngành học :";
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToResizeRows = false;
            this.dgvResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(25, 194);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(1038, 371);
            this.dgvResult.TabIndex = 5;
            this.dgvResult.SelectionChanged += new System.EventHandler(this.dgvResult_SelectionChanged);
            // 
            // grbTIMSV
            // 
            this.grbTIMSV.Controls.Add(this.btnCLOSESEARCH);
            this.grbTIMSV.Controls.Add(this.txtSearch);
            this.grbTIMSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTIMSV.Location = new System.Drawing.Point(506, 442);
            this.grbTIMSV.Name = "grbTIMSV";
            this.grbTIMSV.Size = new System.Drawing.Size(228, 125);
            this.grbTIMSV.TabIndex = 7;
            this.grbTIMSV.TabStop = false;
            this.grbTIMSV.Text = "Tìm sinh viên theo Tên :";
            // 
            // btnCLOSESEARCH
            // 
            this.btnCLOSESEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLOSESEARCH.Location = new System.Drawing.Point(86, 75);
            this.btnCLOSESEARCH.Name = "btnCLOSESEARCH";
            this.btnCLOSESEARCH.Size = new System.Drawing.Size(61, 32);
            this.btnCLOSESEARCH.TabIndex = 2;
            this.btnCLOSESEARCH.Text = "Đóng";
            this.btnCLOSESEARCH.UseVisualStyleBackColor = true;
            this.btnCLOSESEARCH.Click += new System.EventHandler(this.btnCLOSESEARCH_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(19, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 27);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtTKMSV_TextChanged);
            // 
            // txtHO
            // 
            this.txtHO.BackColor = System.Drawing.Color.White;
            this.txtHO.Depth = 0;
            this.txtHO.Hint = "";
            this.txtHO.Location = new System.Drawing.Point(139, 88);
            this.txtHO.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtHO.Name = "txtHO";
            this.txtHO.PasswordChar = '\0';
            this.txtHO.SelectedText = "";
            this.txtHO.SelectionLength = 0;
            this.txtHO.SelectionStart = 0;
            this.txtHO.Size = new System.Drawing.Size(141, 23);
            this.txtHO.TabIndex = 8;
            this.txtHO.UseSystemPasswordChar = false;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.BackColor = System.Drawing.Color.White;
            this.txtDIACHI.Depth = 0;
            this.txtDIACHI.Hint = "";
            this.txtDIACHI.Location = new System.Drawing.Point(139, 143);
            this.txtDIACHI.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.PasswordChar = '\0';
            this.txtDIACHI.SelectedText = "";
            this.txtDIACHI.SelectionLength = 0;
            this.txtDIACHI.SelectionStart = 0;
            this.txtDIACHI.Size = new System.Drawing.Size(381, 23);
            this.txtDIACHI.TabIndex = 8;
            this.txtDIACHI.UseSystemPasswordChar = false;
            // 
            // txtTEN
            // 
            this.txtTEN.BackColor = System.Drawing.Color.White;
            this.txtTEN.Depth = 0;
            this.txtTEN.Hint = "";
            this.txtTEN.Location = new System.Drawing.Point(381, 88);
            this.txtTEN.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.PasswordChar = '\0';
            this.txtTEN.SelectedText = "";
            this.txtTEN.SelectionLength = 0;
            this.txtTEN.SelectionStart = 0;
            this.txtTEN.Size = new System.Drawing.Size(139, 23);
            this.txtTEN.TabIndex = 8;
            this.txtTEN.UseSystemPasswordChar = false;
            // 
            // txtNGAYSINH
            // 
            this.txtNGAYSINH.BackColor = System.Drawing.Color.White;
            this.txtNGAYSINH.Depth = 0;
            this.txtNGAYSINH.Hint = "";
            this.txtNGAYSINH.Location = new System.Drawing.Point(639, 88);
            this.txtNGAYSINH.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNGAYSINH.Name = "txtNGAYSINH";
            this.txtNGAYSINH.PasswordChar = '\0';
            this.txtNGAYSINH.SelectedText = "";
            this.txtNGAYSINH.SelectionLength = 0;
            this.txtNGAYSINH.SelectionStart = 0;
            this.txtNGAYSINH.Size = new System.Drawing.Size(136, 23);
            this.txtNGAYSINH.TabIndex = 8;
            this.txtNGAYSINH.UseSystemPasswordChar = false;
            // 
            // txtNGANH
            // 
            this.txtNGANH.BackColor = System.Drawing.Color.White;
            this.txtNGANH.Depth = 0;
            this.txtNGANH.Hint = "";
            this.txtNGANH.Location = new System.Drawing.Point(639, 143);
            this.txtNGANH.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNGANH.Name = "txtNGANH";
            this.txtNGANH.PasswordChar = '\0';
            this.txtNGANH.SelectedText = "";
            this.txtNGANH.SelectionLength = 0;
            this.txtNGANH.SelectionStart = 0;
            this.txtNGANH.Size = new System.Drawing.Size(136, 23);
            this.txtNGANH.TabIndex = 8;
            this.txtNGANH.UseSystemPasswordChar = false;
            // 
            // rdbNAM
            // 
            this.rdbNAM.AutoSize = true;
            this.rdbNAM.BackColor = System.Drawing.Color.White;
            this.rdbNAM.Checked = true;
            this.rdbNAM.Depth = 0;
            this.rdbNAM.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbNAM.Location = new System.Drawing.Point(877, 83);
            this.rdbNAM.Margin = new System.Windows.Forms.Padding(0);
            this.rdbNAM.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbNAM.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbNAM.Name = "rdbNAM";
            this.rdbNAM.Ripple = true;
            this.rdbNAM.Size = new System.Drawing.Size(58, 30);
            this.rdbNAM.TabIndex = 9;
            this.rdbNAM.Text = "Nam";
            this.rdbNAM.UseVisualStyleBackColor = false;
            // 
            // rdbNU
            // 
            this.rdbNU.AutoSize = true;
            this.rdbNU.BackColor = System.Drawing.Color.White;
            this.rdbNU.Depth = 0;
            this.rdbNU.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbNU.Location = new System.Drawing.Point(957, 83);
            this.rdbNU.Margin = new System.Windows.Forms.Padding(0);
            this.rdbNU.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbNU.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbNU.Name = "rdbNU";
            this.rdbNU.Ripple = true;
            this.rdbNU.Size = new System.Drawing.Size(47, 30);
            this.rdbNU.TabIndex = 9;
            this.rdbNU.Text = "Nữ";
            this.rdbNU.UseVisualStyleBackColor = false;
            // 
            // btnThemSV
            // 
            this.btnThemSV.Depth = 0;
            this.btnThemSV.Location = new System.Drawing.Point(804, 135);
            this.btnThemSV.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Primary = true;
            this.btnThemSV.Size = new System.Drawing.Size(73, 38);
            this.btnThemSV.TabIndex = 10;
            this.btnThemSV.Text = "Thêm";
            this.btnThemSV.UseVisualStyleBackColor = true;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // btnXuatDS
            // 
            this.btnXuatDS.Depth = 0;
            this.btnXuatDS.Location = new System.Drawing.Point(897, 575);
            this.btnXuatDS.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXuatDS.Name = "btnXuatDS";
            this.btnXuatDS.Primary = true;
            this.btnXuatDS.Size = new System.Drawing.Size(73, 39);
            this.btnXuatDS.TabIndex = 10;
            this.btnXuatDS.Text = "Lưu";
            this.btnXuatDS.UseVisualStyleBackColor = true;
            this.btnXuatDS.Click += new System.EventHandler(this.btnXuatDS_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Depth = 0;
            this.btnDelete.Location = new System.Drawing.Point(775, 575);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = true;
            this.btnDelete.Size = new System.Drawing.Size(73, 39);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xoá SV";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTimSV
            // 
            this.btnTimSV.Depth = 0;
            this.btnTimSV.Location = new System.Drawing.Point(649, 575);
            this.btnTimSV.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimSV.Name = "btnTimSV";
            this.btnTimSV.Primary = true;
            this.btnTimSV.Size = new System.Drawing.Size(73, 39);
            this.btnTimSV.TabIndex = 10;
            this.btnTimSV.Text = "Tìm kiếm";
            this.btnTimSV.UseVisualStyleBackColor = true;
            this.btnTimSV.Click += new System.EventHandler(this.btnTimSV_Click);
            // 
            // btnCESV
            // 
            this.btnCESV.Depth = 0;
            this.btnCESV.Location = new System.Drawing.Point(515, 575);
            this.btnCESV.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCESV.Name = "btnCESV";
            this.btnCESV.Primary = true;
            this.btnCESV.Size = new System.Drawing.Size(86, 39);
            this.btnCESV.TabIndex = 10;
            this.btnCESV.Text = "Cấp Email";
            this.btnCESV.UseVisualStyleBackColor = true;
            this.btnCESV.Click += new System.EventHandler(this.btnCESV_Click);
            // 
            // btnCMSV
            // 
            this.btnCMSV.Depth = 0;
            this.btnCMSV.Location = new System.Drawing.Point(381, 575);
            this.btnCMSV.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCMSV.Name = "btnCMSV";
            this.btnCMSV.Primary = true;
            this.btnCMSV.Size = new System.Drawing.Size(86, 39);
            this.btnCMSV.TabIndex = 10;
            this.btnCMSV.Text = "Cấp MSV";
            this.btnCMSV.UseVisualStyleBackColor = true;
            this.btnCMSV.Click += new System.EventHandler(this.btnCMSV_Click);
            // 
            // btnSXDS
            // 
            this.btnSXDS.Depth = 0;
            this.btnSXDS.Location = new System.Drawing.Point(244, 575);
            this.btnSXDS.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSXDS.Name = "btnSXDS";
            this.btnSXDS.Primary = true;
            this.btnSXDS.Size = new System.Drawing.Size(86, 39);
            this.btnSXDS.TabIndex = 10;
            this.btnSXDS.Text = "Sắp xếp";
            this.btnSXDS.UseVisualStyleBackColor = true;
            this.btnSXDS.Click += new System.EventHandler(this.btnSXDS_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(115, 575);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(86, 39);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 625);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSXDS);
            this.Controls.Add(this.btnCMSV);
            this.Controls.Add(this.btnCESV);
            this.Controls.Add(this.btnTimSV);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnXuatDS);
            this.Controls.Add(this.btnThemSV);
            this.Controls.Add(this.rdbNU);
            this.Controls.Add(this.rdbNAM);
            this.Controls.Add(this.txtDIACHI);
            this.Controls.Add(this.txtNGANH);
            this.Controls.Add(this.txtNGAYSINH);
            this.Controls.Add(this.txtTEN);
            this.Controls.Add(this.txtHO);
            this.Controls.Add(this.grbTIMSV);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.grbTIMSV.ResumeLayout(false);
            this.grbTIMSV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.GroupBox grbTIMSV;
        private System.Windows.Forms.Button btnCLOSESEARCH;
        private System.Windows.Forms.TextBox txtSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtHO;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDIACHI;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTEN;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNGAYSINH;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNGANH;
        private MaterialSkin.Controls.MaterialRadioButton rdbNAM;
        private MaterialSkin.Controls.MaterialRadioButton rdbNU;
        private MaterialSkin.Controls.MaterialRaisedButton btnThemSV;
        private MaterialSkin.Controls.MaterialRaisedButton btnXuatDS;
        private MaterialSkin.Controls.MaterialRaisedButton btnDelete;
        private MaterialSkin.Controls.MaterialRaisedButton btnTimSV;
        private MaterialSkin.Controls.MaterialRaisedButton btnCESV;
        private MaterialSkin.Controls.MaterialRaisedButton btnCMSV;
        private MaterialSkin.Controls.MaterialRaisedButton btnSXDS;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
    }
}
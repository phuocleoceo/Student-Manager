namespace QuanLySinhVien
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSHOWPASS = new System.Windows.Forms.Button();
            this.btnHIDEPASS = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDangNhap = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtNick = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu : ";
            // 
            // btnSHOWPASS
            // 
            this.btnSHOWPASS.BackColor = System.Drawing.Color.White;
            this.btnSHOWPASS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSHOWPASS.BackgroundImage")));
            this.btnSHOWPASS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSHOWPASS.FlatAppearance.BorderSize = 0;
            this.btnSHOWPASS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHOWPASS.Location = new System.Drawing.Point(337, 128);
            this.btnSHOWPASS.Name = "btnSHOWPASS";
            this.btnSHOWPASS.Size = new System.Drawing.Size(26, 26);
            this.btnSHOWPASS.TabIndex = 3;
            this.btnSHOWPASS.UseVisualStyleBackColor = false;
            this.btnSHOWPASS.Click += new System.EventHandler(this.btnPASS_Click);
            // 
            // btnHIDEPASS
            // 
            this.btnHIDEPASS.BackColor = System.Drawing.Color.White;
            this.btnHIDEPASS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHIDEPASS.BackgroundImage")));
            this.btnHIDEPASS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHIDEPASS.FlatAppearance.BorderSize = 0;
            this.btnHIDEPASS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHIDEPASS.Location = new System.Drawing.Point(337, 128);
            this.btnHIDEPASS.Name = "btnHIDEPASS";
            this.btnHIDEPASS.Size = new System.Drawing.Size(26, 26);
            this.btnHIDEPASS.TabIndex = 3;
            this.btnHIDEPASS.UseVisualStyleBackColor = false;
            this.btnHIDEPASS.Click += new System.EventHandler(this.btnHIDEPASS_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phuoc DUT";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Depth = 0;
            this.btnDangNhap.Location = new System.Drawing.Point(161, 184);
            this.btnDangNhap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Primary = true;
            this.btnDangNhap.Size = new System.Drawing.Size(91, 47);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtNick
            // 
            this.txtNick.BackColor = System.Drawing.Color.White;
            this.txtNick.Depth = 0;
            this.txtNick.Hint = "";
            this.txtNick.Location = new System.Drawing.Point(162, 90);
            this.txtNick.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNick.Name = "txtNick";
            this.txtNick.PasswordChar = '\0';
            this.txtNick.SelectedText = "";
            this.txtNick.SelectionLength = 0;
            this.txtNick.SelectionStart = 0;
            this.txtNick.Size = new System.Drawing.Size(200, 23);
            this.txtNick.TabIndex = 6;
            this.txtNick.UseSystemPasswordChar = false;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Depth = 0;
            this.txtPass.Hint = "";
            this.txtPass.Location = new System.Drawing.Point(162, 132);
            this.txtPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.Size = new System.Drawing.Size(200, 23);
            this.txtPass.TabIndex = 6;
            this.txtPass.UseSystemPasswordChar = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(408, 243);
            this.Controls.Add(this.btnSHOWPASS);
            this.Controls.Add(this.btnHIDEPASS);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSHOWPASS;
        private System.Windows.Forms.Button btnHIDEPASS;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialRaisedButton btnDangNhap;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNick;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPass;
    }
}


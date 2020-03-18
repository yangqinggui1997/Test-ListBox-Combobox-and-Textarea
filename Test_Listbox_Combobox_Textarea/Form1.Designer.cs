namespace Test_Listbox_Combobox_Textarea
{
    partial class Form1
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
            this.lbxThongTinMH = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTenhang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMahang = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtNhaSX = new System.Windows.Forms.TextBox();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblKetquaTK = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbTimtheoTH = new System.Windows.Forms.RadioButton();
            this.rdbTimtheoNSX = new System.Windows.Forms.RadioButton();
            this.rdbTimtheoMH = new System.Windows.Forms.RadioButton();
            this.txtThongtinTK = new System.Windows.Forms.TextBox();
            this.cbTuyChon = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblTuyChon = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxThongTinMH
            // 
            this.lbxThongTinMH.AccessibleDescription = "";
            this.lbxThongTinMH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbxThongTinMH.FormattingEnabled = true;
            this.lbxThongTinMH.ItemHeight = 20;
            this.lbxThongTinMH.Location = new System.Drawing.Point(3, 39);
            this.lbxThongTinMH.Name = "lbxThongTinMH";
            this.lbxThongTinMH.Size = new System.Drawing.Size(870, 104);
            this.lbxThongTinMH.TabIndex = 0;
            this.lbxThongTinMH.Click += new System.EventHandler(this.lbxThongTinMH_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 100);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(179, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Testing ListBox, ComboBox And TextArea";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxThongTinMH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 146);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Mặt Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.lblTenhang);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblMahang);
            this.groupBox2.Controls.Add(this.txtTenHang);
            this.groupBox2.Controls.Add(this.txtNhaSX);
            this.groupBox2.Controls.Add(this.txtMahang);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 250);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xử Lý Thông Tin Mặt Hàng";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHuy.Location = new System.Drawing.Point(333, 189);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(67, 29);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.Location = new System.Drawing.Point(253, 189);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(67, 29);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(173, 189);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(67, 29);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Gold;
            this.btnSua.Location = new System.Drawing.Point(93, 189);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 29);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Green;
            this.btnThem.Location = new System.Drawing.Point(13, 189);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(67, 29);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTenhang
            // 
            this.lblTenhang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenhang.AutoSize = true;
            this.lblTenhang.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenhang.Location = new System.Drawing.Point(66, 90);
            this.lblTenhang.Name = "lblTenhang";
            this.lblTenhang.Size = new System.Drawing.Size(64, 17);
            this.lblTenhang.TabIndex = 8;
            this.lblTenhang.Text = "Tên hàng";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nhà sản xuất";
            // 
            // lblMahang
            // 
            this.lblMahang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMahang.AutoSize = true;
            this.lblMahang.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMahang.Location = new System.Drawing.Point(66, 41);
            this.lblMahang.Name = "lblMahang";
            this.lblMahang.Size = new System.Drawing.Size(60, 17);
            this.lblMahang.TabIndex = 7;
            this.lblMahang.Text = "Mã hàng";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenHang.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHang.Location = new System.Drawing.Point(173, 87);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(173, 23);
            this.txtTenHang.TabIndex = 1;
            // 
            // txtNhaSX
            // 
            this.txtNhaSX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNhaSX.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaSX.Location = new System.Drawing.Point(173, 133);
            this.txtNhaSX.Name = "txtNhaSX";
            this.txtNhaSX.Size = new System.Drawing.Size(173, 23);
            this.txtNhaSX.TabIndex = 2;
            // 
            // txtMahang
            // 
            this.txtMahang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMahang.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahang.Location = new System.Drawing.Point(173, 41);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(173, 23);
            this.txtMahang.TabIndex = 0;
            this.txtMahang.Leave += new System.EventHandler(this.txtMahang_Leave);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(413, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 250);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblKetquaTK);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtThongtinTK);
            this.groupBox3.Controls.Add(this.cbTuyChon);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.lblTuyChon);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(416, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 250);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm Mặt Hàng";
            // 
            // lblKetquaTK
            // 
            this.lblKetquaTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKetquaTK.AutoSize = true;
            this.lblKetquaTK.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetquaTK.Location = new System.Drawing.Point(12, 139);
            this.lblKetquaTK.Name = "lblKetquaTK";
            this.lblKetquaTK.Size = new System.Drawing.Size(0, 17);
            this.lblKetquaTK.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbTimtheoTH);
            this.groupBox4.Controls.Add(this.rdbTimtheoNSX);
            this.groupBox4.Controls.Add(this.rdbTimtheoMH);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(288, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(169, 144);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tùy Chọn";
            // 
            // rdbTimtheoTH
            // 
            this.rdbTimtheoTH.AutoSize = true;
            this.rdbTimtheoTH.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTimtheoTH.Location = new System.Drawing.Point(4, 68);
            this.rdbTimtheoTH.Name = "rdbTimtheoTH";
            this.rdbTimtheoTH.Size = new System.Drawing.Size(137, 21);
            this.rdbTimtheoTH.TabIndex = 1;
            this.rdbTimtheoTH.TabStop = true;
            this.rdbTimtheoTH.Text = "Tìm theo tên hàng";
            this.rdbTimtheoTH.UseVisualStyleBackColor = true;
            this.rdbTimtheoTH.CheckedChanged += new System.EventHandler(this.rdbTimtheoTH_CheckedChanged);
            this.rdbTimtheoTH.Leave += new System.EventHandler(this.rdbTimtheoTH_Leave);
            // 
            // rdbTimtheoNSX
            // 
            this.rdbTimtheoNSX.AutoSize = true;
            this.rdbTimtheoNSX.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTimtheoNSX.Location = new System.Drawing.Point(4, 98);
            this.rdbTimtheoNSX.Name = "rdbTimtheoNSX";
            this.rdbTimtheoNSX.Size = new System.Drawing.Size(161, 21);
            this.rdbTimtheoNSX.TabIndex = 2;
            this.rdbTimtheoNSX.TabStop = true;
            this.rdbTimtheoNSX.Text = "Tìm theo nhà sản xuất";
            this.rdbTimtheoNSX.UseVisualStyleBackColor = true;
            this.rdbTimtheoNSX.CheckedChanged += new System.EventHandler(this.rdbTimtheoNSX_CheckedChanged);
            this.rdbTimtheoNSX.Leave += new System.EventHandler(this.rdbTimtheoNSX_Leave);
            // 
            // rdbTimtheoMH
            // 
            this.rdbTimtheoMH.AutoSize = true;
            this.rdbTimtheoMH.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTimtheoMH.Location = new System.Drawing.Point(4, 38);
            this.rdbTimtheoMH.Name = "rdbTimtheoMH";
            this.rdbTimtheoMH.Size = new System.Drawing.Size(136, 21);
            this.rdbTimtheoMH.TabIndex = 0;
            this.rdbTimtheoMH.TabStop = true;
            this.rdbTimtheoMH.Text = "Tìm theo mã hàng";
            this.rdbTimtheoMH.UseVisualStyleBackColor = true;
            this.rdbTimtheoMH.CheckedChanged += new System.EventHandler(this.rdbTimtheoMH_CheckedChanged);
            this.rdbTimtheoMH.Leave += new System.EventHandler(this.rdbTimtheoMH_Leave);
            // 
            // txtThongtinTK
            // 
            this.txtThongtinTK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtThongtinTK.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongtinTK.Location = new System.Drawing.Point(3, 167);
            this.txtThongtinTK.Multiline = true;
            this.txtThongtinTK.Name = "txtThongtinTK";
            this.txtThongtinTK.ReadOnly = true;
            this.txtThongtinTK.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtThongtinTK.Size = new System.Drawing.Size(454, 80);
            this.txtThongtinTK.TabIndex = 5;
            this.txtThongtinTK.WordWrap = false;
            // 
            // cbTuyChon
            // 
            this.cbTuyChon.AllowDrop = true;
            this.cbTuyChon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTuyChon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTuyChon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTuyChon.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTuyChon.FormattingEnabled = true;
            this.cbTuyChon.Location = new System.Drawing.Point(109, 50);
            this.cbTuyChon.Name = "cbTuyChon";
            this.cbTuyChon.Size = new System.Drawing.Size(173, 23);
            this.cbTuyChon.TabIndex = 0;
            this.cbTuyChon.TextChanged += new System.EventHandler(this.cbTuyChon_TextChanged);
            this.cbTuyChon.Click += new System.EventHandler(this.cbTuyChon_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnTimKiem.Location = new System.Drawing.Point(142, 87);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(111, 29);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm &Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblTuyChon
            // 
            this.lblTuyChon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTuyChon.AutoSize = true;
            this.lblTuyChon.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuyChon.Location = new System.Drawing.Point(12, 53);
            this.lblTuyChon.Name = "lblTuyChon";
            this.lblTuyChon.Size = new System.Drawing.Size(81, 17);
            this.lblTuyChon.TabIndex = 4;
            this.lblTuyChon.Text = "Tìm theo ...?";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Báo Cáo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxThongTinMH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTenhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMahang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtNhaSX;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbTuyChon;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblTuyChon;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbTimtheoTH;
        private System.Windows.Forms.RadioButton rdbTimtheoNSX;
        private System.Windows.Forms.RadioButton rdbTimtheoMH;
        private System.Windows.Forms.TextBox txtThongtinTK;
        private System.Windows.Forms.Label lblKetquaTK;
    }
}


﻿namespace AppQuanLyBanHang
{
    partial class frmQLSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSV));
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnDanhsach = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.dgvQLSV = new System.Windows.Forms.DataGridView();
            this.mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dantoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hokhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTKTP = new System.Windows.Forms.Button();
            this.dtpSV = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdonu = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.rdonam = new System.Windows.Forms.RadioButton();
            this.txtphong = new System.Windows.Forms.TextBox();
            this.txtTongiao = new System.Windows.Forms.TextBox();
            this.txtDantoc = new System.Windows.Forms.TextBox();
            this.txtHokhau = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(1095, 27);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(132, 38);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(476, 27);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(132, 38);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(327, 27);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(132, 38);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(173, 27);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(132, 38);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(20, 27);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 38);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLammoi);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnDanhsach);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnTimkiem);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 536);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 82);
            this.panel1.TabIndex = 12;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.Image")));
            this.btnLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoi.Location = new System.Drawing.Point(947, 27);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(132, 38);
            this.btnLammoi.TabIndex = 14;
            this.btnLammoi.Text = "&Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnDanhsach
            // 
            this.btnDanhsach.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhsach.Image")));
            this.btnDanhsach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhsach.Location = new System.Drawing.Point(791, 27);
            this.btnDanhsach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDanhsach.Name = "btnDanhsach";
            this.btnDanhsach.Size = new System.Drawing.Size(132, 38);
            this.btnDanhsach.TabIndex = 13;
            this.btnDanhsach.Text = "&Danh sách";
            this.btnDanhsach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDanhsach.UseVisualStyleBackColor = true;
            this.btnDanhsach.Click += new System.EventHandler(this.btnDanhsach_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(633, 27);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(132, 38);
            this.btnTimkiem.TabIndex = 12;
            this.btnTimkiem.Text = "&  Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // dgvQLSV
            // 
            this.dgvQLSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mssv,
            this.hoten,
            this.gioitinh,
            this.ngaysinh,
            this.dantoc,
            this.tongiao,
            this.hokhau,
            this.lop,
            this.maphong});
            this.dgvQLSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQLSV.Location = new System.Drawing.Point(0, 266);
            this.dgvQLSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvQLSV.Name = "dgvQLSV";
            this.dgvQLSV.RowHeadersWidth = 51;
            this.dgvQLSV.Size = new System.Drawing.Size(1243, 270);
            this.dgvQLSV.TabIndex = 16;
            this.dgvQLSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLSV_CellClick);
            this.dgvQLSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLSV_CellContentClick);
            // 
            // mssv
            // 
            this.mssv.DataPropertyName = "mssv";
            this.mssv.HeaderText = "Mã sinh viên";
            this.mssv.MinimumWidth = 6;
            this.mssv.Name = "mssv";
            this.mssv.Width = 120;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Tên sinh viên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.Width = 110;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 60;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // dantoc
            // 
            this.dantoc.DataPropertyName = "dantoc";
            this.dantoc.HeaderText = "Dân tộc";
            this.dantoc.MinimumWidth = 6;
            this.dantoc.Name = "dantoc";
            this.dantoc.Width = 60;
            // 
            // tongiao
            // 
            this.tongiao.DataPropertyName = "tongiao";
            this.tongiao.HeaderText = "Tôn giáo";
            this.tongiao.MinimumWidth = 6;
            this.tongiao.Name = "tongiao";
            this.tongiao.Width = 60;
            // 
            // hokhau
            // 
            this.hokhau.DataPropertyName = "hokhau";
            this.hokhau.HeaderText = "Hộ khẩu thường trú";
            this.hokhau.MinimumWidth = 6;
            this.hokhau.Name = "hokhau";
            this.hokhau.Width = 250;
            // 
            // lop
            // 
            this.lop.DataPropertyName = "lop";
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.Width = 68;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Phòng";
            this.maphong.MinimumWidth = 6;
            this.maphong.Name = "maphong";
            this.maphong.Width = 60;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(435, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Sinh Viên";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sinh viên:";
            // 
            // labelth
            // 
            this.labelth.AutoSize = true;
            this.labelth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelth.Location = new System.Drawing.Point(57, 129);
            this.labelth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelth.Name = "labelth";
            this.labelth.Size = new System.Drawing.Size(131, 20);
            this.labelth.TabIndex = 2;
            this.labelth.Text = "Mã số sinh viên:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh:";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSV.Location = new System.Drawing.Point(192, 76);
            this.txtTenSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(351, 26);
            this.txtTenSV.TabIndex = 5;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(192, 126);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(351, 26);
            this.txtMaSV.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(623, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Dân tộc:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(621, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tôn giáo:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hộ khẩu:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(947, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã phòng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnIn);
            this.panel2.Controls.Add(this.btnTKTP);
            this.panel2.Controls.Add(this.dtpSV);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtLop);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rdonu);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.rdonam);
            this.panel2.Controls.Add(this.txtphong);
            this.panel2.Controls.Add(this.txtTongiao);
            this.panel2.Controls.Add(this.txtDantoc);
            this.panel2.Controls.Add(this.txtHokhau);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtMaSV);
            this.panel2.Controls.Add(this.txtTenSV);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.labelth);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 266);
            this.panel2.TabIndex = 15;
            // 
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(917, 203);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(143, 38);
            this.btnIn.TabIndex = 37;
            this.btnIn.Text = "&In danh sách";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTKTP
            // 
            this.btnTKTP.Image = ((System.Drawing.Image)(resources.GetObject("btnTKTP.Image")));
            this.btnTKTP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKTP.Location = new System.Drawing.Point(1084, 203);
            this.btnTKTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTKTP.Name = "btnTKTP";
            this.btnTKTP.Size = new System.Drawing.Size(143, 38);
            this.btnTKTP.TabIndex = 29;
            this.btnTKTP.Text = "DS Theo phòng";
            this.btnTKTP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTKTP.UseVisualStyleBackColor = true;
            this.btnTKTP.Click += new System.EventHandler(this.btnTKTP_Click);
            // 
            // dtpSV
            // 
            this.dtpSV.CustomFormat = "";
            this.dtpSV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSV.Location = new System.Drawing.Point(192, 217);
            this.dtpSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpSV.Name = "dtpSV";
            this.dtpSV.Size = new System.Drawing.Size(133, 22);
            this.dtpSV.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(625, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nhấp vào bảng để thao tác";
            // 
            // txtLop
            // 
            this.txtLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLop.Location = new System.Drawing.Point(1049, 73);
            this.txtLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(132, 26);
            this.txtLop.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(947, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Lớp:";
            // 
            // rdonu
            // 
            this.rdonu.AutoSize = true;
            this.rdonu.Location = new System.Drawing.Point(787, 180);
            this.rdonu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdonu.Name = "rdonu";
            this.rdonu.Size = new System.Drawing.Size(47, 21);
            this.rdonu.TabIndex = 24;
            this.rdonu.Text = "Nữ";
            this.rdonu.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(625, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Giới tính:";
            // 
            // rdonam
            // 
            this.rdonam.AutoSize = true;
            this.rdonam.Location = new System.Drawing.Point(716, 180);
            this.rdonam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdonam.Name = "rdonam";
            this.rdonam.Size = new System.Drawing.Size(58, 21);
            this.rdonam.TabIndex = 22;
            this.rdonam.Text = "Nam";
            this.rdonam.UseVisualStyleBackColor = true;
            // 
            // txtphong
            // 
            this.txtphong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphong.Location = new System.Drawing.Point(1049, 129);
            this.txtphong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtphong.Name = "txtphong";
            this.txtphong.Size = new System.Drawing.Size(132, 26);
            this.txtphong.TabIndex = 20;
            // 
            // txtTongiao
            // 
            this.txtTongiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongiao.Location = new System.Drawing.Point(715, 126);
            this.txtTongiao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongiao.Name = "txtTongiao";
            this.txtTongiao.Size = new System.Drawing.Size(185, 26);
            this.txtTongiao.TabIndex = 18;
            // 
            // txtDantoc
            // 
            this.txtDantoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDantoc.Location = new System.Drawing.Point(715, 73);
            this.txtDantoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDantoc.Name = "txtDantoc";
            this.txtDantoc.Size = new System.Drawing.Size(185, 26);
            this.txtDantoc.TabIndex = 17;
            // 
            // txtHokhau
            // 
            this.txtHokhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHokhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHokhau.Location = new System.Drawing.Point(192, 175);
            this.txtHokhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHokhau.Name = "txtHokhau";
            this.txtHokhau.Size = new System.Drawing.Size(351, 26);
            this.txtHokhau.TabIndex = 16;
            // 
            // frmQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 618);
            this.Controls.Add(this.dgvQLSV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmQLSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.frmQLSV_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDanhsach;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DataGridView dgvQLSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtphong;
        private System.Windows.Forms.TextBox txtTongiao;
        private System.Windows.Forms.TextBox txtDantoc;
        private System.Windows.Forms.TextBox txtHokhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdonu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdonam;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.DateTimePicker dtpSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dantoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn hokhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.Button btnTKTP;
        private System.Windows.Forms.Button btnIn;
    }
}
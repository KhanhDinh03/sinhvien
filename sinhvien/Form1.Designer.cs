namespace sinhvien
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
            this.dataGridView_dssv = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_msv = new System.Windows.Forms.TextBox();
            this.tb_ht = new System.Windows.Forms.TextBox();
            this.dt_ns = new System.Windows.Forms.DateTimePicker();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cb_qq = new System.Windows.Forms.ComboBox();
            this.cb_k = new System.Windows.Forms.ComboBox();
            this.cb_l = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dssv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_dssv
            // 
            this.dataGridView_dssv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_dssv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dssv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView_dssv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_dssv.Location = new System.Drawing.Point(0, 235);
            this.dataGridView_dssv.Name = "dataGridView_dssv";
            this.dataGridView_dssv.Size = new System.Drawing.Size(1001, 362);
            this.dataGridView_dssv.TabIndex = 1;
            this.dataGridView_dssv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_dssv_CellClick);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lớp";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quê quán";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Khoa";
            // 
            // bt_them
            // 
            this.bt_them.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_them.Location = new System.Drawing.Point(45, 180);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(185, 37);
            this.bt_them.TabIndex = 7;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // tb_msv
            // 
            this.tb_msv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_msv.Location = new System.Drawing.Point(132, 17);
            this.tb_msv.Name = "tb_msv";
            this.tb_msv.Size = new System.Drawing.Size(260, 26);
            this.tb_msv.TabIndex = 4;
            // 
            // tb_ht
            // 
            this.tb_ht.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ht.Location = new System.Drawing.Point(132, 68);
            this.tb_ht.Name = "tb_ht";
            this.tb_ht.Size = new System.Drawing.Size(260, 26);
            this.tb_ht.TabIndex = 5;
            // 
            // dt_ns
            // 
            this.dt_ns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_ns.CustomFormat = "dd/MM/yyyy";
            this.dt_ns.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ns.Location = new System.Drawing.Point(132, 125);
            this.dt_ns.Name = "dt_ns";
            this.dt_ns.Size = new System.Drawing.Size(260, 26);
            this.dt_ns.TabIndex = 6;
            this.dt_ns.Value = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            // 
            // rb_nam
            // 
            this.rb_nam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_nam.AutoSize = true;
            this.rb_nam.Checked = true;
            this.rb_nam.Location = new System.Drawing.Point(132, 184);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(60, 24);
            this.rb_nam.TabIndex = 7;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // rb_nu
            // 
            this.rb_nu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(285, 184);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(47, 24);
            this.rb_nu.TabIndex = 8;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rb_nu);
            this.splitContainer1.Panel1.Controls.Add(this.rb_nam);
            this.splitContainer1.Panel1.Controls.Add(this.dt_ns);
            this.splitContainer1.Panel1.Controls.Add(this.tb_ht);
            this.splitContainer1.Panel1.Controls.Add(this.tb_msv);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bt_sua);
            this.splitContainer1.Panel2.Controls.Add(this.cb_l);
            this.splitContainer1.Panel2.Controls.Add(this.cb_k);
            this.splitContainer1.Panel2.Controls.Add(this.cb_qq);
            this.splitContainer1.Panel2.Controls.Add(this.bt_them);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(1001, 235);
            this.splitContainer1.SplitterDistance = 492;
            this.splitContainer1.TabIndex = 0;
            // 
            // cb_qq
            // 
            this.cb_qq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_qq.FormattingEnabled = true;
            this.cb_qq.Items.AddRange(new object[] {
            "Hà Nội",
            "Nam Định",
            "Hải Phòng",
            "Thanh Hoá"});
            this.cb_qq.Location = new System.Drawing.Point(126, 15);
            this.cb_qq.Name = "cb_qq";
            this.cb_qq.Size = new System.Drawing.Size(288, 28);
            this.cb_qq.TabIndex = 8;
            // 
            // cb_k
            // 
            this.cb_k.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_k.FormattingEnabled = true;
            this.cb_k.Items.AddRange(new object[] {
            "Công Nghệ Thông Tin",
            "Kinh Tế",
            "Công Nghiệp",
            "An Ninh"});
            this.cb_k.Location = new System.Drawing.Point(126, 66);
            this.cb_k.Name = "cb_k";
            this.cb_k.Size = new System.Drawing.Size(288, 28);
            this.cb_k.TabIndex = 9;
            // 
            // cb_l
            // 
            this.cb_l.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_l.FormattingEnabled = true;
            this.cb_l.Items.AddRange(new object[] {
            "K63CNTT",
            "K63KT",
            "K63CN",
            "K63AN"});
            this.cb_l.Location = new System.Drawing.Point(126, 123);
            this.cb_l.Name = "cb_l";
            this.cb_l.Size = new System.Drawing.Size(288, 28);
            this.cb_l.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã SV";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giới tính";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quê quán";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Khoa";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Lớp";
            this.Column7.Name = "Column7";
            // 
            // bt_sua
            // 
            this.bt_sua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_sua.Location = new System.Drawing.Point(292, 180);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(185, 37);
            this.bt_sua.TabIndex = 11;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 597);
            this.Controls.Add(this.dataGridView_dssv);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Nhập thông tin sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dssv)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_dssv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_msv;
        private System.Windows.Forms.TextBox tb_ht;
        private System.Windows.Forms.DateTimePicker dt_ns;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cb_l;
        private System.Windows.Forms.ComboBox cb_k;
        private System.Windows.Forms.ComboBox cb_qq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button bt_sua;
    }
}


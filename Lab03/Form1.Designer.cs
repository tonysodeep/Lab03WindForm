namespace Lab03
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ms = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_diem = new System.Windows.Forms.TextBox();
            this.cb_nganh = new System.Windows.Forms.ComboBox();
            this.dgMain = new System.Windows.Forms.DataGridView();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_fix = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            this.cl_ms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_nganh);
            this.groupBox1.Controls.Add(this.tb_diem);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.tb_ms);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin sinh vien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma so";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ho ten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nganh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diem";
            // 
            // tb_ms
            // 
            this.tb_ms.Location = new System.Drawing.Point(124, 44);
            this.tb_ms.Name = "tb_ms";
            this.tb_ms.Size = new System.Drawing.Size(100, 20);
            this.tb_ms.TabIndex = 4;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(124, 82);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 20);
            this.tb_name.TabIndex = 5;
            // 
            // tb_diem
            // 
            this.tb_diem.Location = new System.Drawing.Point(124, 155);
            this.tb_diem.Name = "tb_diem";
            this.tb_diem.Size = new System.Drawing.Size(100, 20);
            this.tb_diem.TabIndex = 6;
            // 
            // cb_nganh
            // 
            this.cb_nganh.FormattingEnabled = true;
            this.cb_nganh.Location = new System.Drawing.Point(124, 119);
            this.cb_nganh.Name = "cb_nganh";
            this.cb_nganh.Size = new System.Drawing.Size(121, 21);
            this.cb_nganh.TabIndex = 7;
            // 
            // dgMain
            // 
            this.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_ms,
            this.cl_name,
            this.cl_khoa,
            this.cl_diem});
            this.dgMain.Location = new System.Drawing.Point(369, 51);
            this.dgMain.Name = "dgMain";
            this.dgMain.Size = new System.Drawing.Size(541, 201);
            this.dgMain.TabIndex = 1;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(75, 246);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 2;
            this.bt_add.Text = "them";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_fix
            // 
            this.bt_fix.Location = new System.Drawing.Point(169, 246);
            this.bt_fix.Name = "bt_fix";
            this.bt_fix.Size = new System.Drawing.Size(75, 23);
            this.bt_fix.TabIndex = 3;
            this.bt_fix.Text = "Sua";
            this.bt_fix.UseVisualStyleBackColor = true;
            this.bt_fix.Click += new System.EventHandler(this.bt_fix_Click);
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(266, 246);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(75, 23);
            this.bt_del.TabIndex = 4;
            this.bt_del.Text = "Xoa";
            this.bt_del.UseVisualStyleBackColor = true;
            // 
            // cl_ms
            // 
            this.cl_ms.HeaderText = "Ma so Sinh Vien";
            this.cl_ms.Name = "cl_ms";
            // 
            // cl_name
            // 
            this.cl_name.HeaderText = "Ho Ten";
            this.cl_name.Name = "cl_name";
            this.cl_name.Width = 150;
            // 
            // cl_khoa
            // 
            this.cl_khoa.HeaderText = "Ten Khoa";
            this.cl_khoa.Name = "cl_khoa";
            this.cl_khoa.Width = 150;
            // 
            // cl_diem
            // 
            this.cl_diem.HeaderText = "Diem Tb";
            this.cl_diem.Name = "cl_diem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 511);
            this.Controls.Add(this.bt_del);
            this.Controls.Add(this.bt_fix);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.dgMain);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_nganh;
        private System.Windows.Forms.TextBox tb_diem;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_ms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_ms;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_diem;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_fix;
        private System.Windows.Forms.Button bt_del;
    }
}


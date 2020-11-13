namespace Lab03_03
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dg_giao = new System.Windows.Forms.DataGridView();
            this.cl_stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_hd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_dat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_giao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_giao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(100, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong Tin Don Hag";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(30, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Xem tat ca trong thang";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thoi gian giao hang";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(418, 56);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dg_giao
            // 
            this.dg_giao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_giao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_stt,
            this.cl_hd,
            this.cl_dat,
            this.cl_giao,
            this.cl_tien});
            this.dg_giao.Location = new System.Drawing.Point(74, 138);
            this.dg_giao.Name = "dg_giao";
            this.dg_giao.Size = new System.Drawing.Size(652, 291);
            this.dg_giao.TabIndex = 1;
            // 
            // cl_stt
            // 
            this.cl_stt.HeaderText = "stt";
            this.cl_stt.Name = "cl_stt";
            // 
            // cl_hd
            // 
            this.cl_hd.HeaderText = "So HD";
            this.cl_hd.Name = "cl_hd";
            this.cl_hd.Width = 200;
            // 
            // cl_dat
            // 
            this.cl_dat.HeaderText = "Ngay Dat Hang";
            this.cl_dat.Name = "cl_dat";
            // 
            // cl_giao
            // 
            this.cl_giao.HeaderText = "Ngay Giao Hang";
            this.cl_giao.Name = "cl_giao";
            // 
            // cl_tien
            // 
            this.cl_tien.HeaderText = "Thanh Tien";
            this.cl_tien.Name = "cl_tien";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_giao);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_giao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dg_giao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_hd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_dat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_giao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_tien;
    }
}


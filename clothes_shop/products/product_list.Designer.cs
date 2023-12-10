namespace clothes_shop.products
{
    partial class product_list
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serch_but = new System.Windows.Forms.Button();
            this.refreh_but = new System.Windows.Forms.Button();
            this.par_ctex = new System.Windows.Forms.TextBox();
            this.nameform_tex = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nam_tex = new System.Windows.Forms.TextBox();
            this.pri_tex = new System.Windows.Forms.TextBox();
            this.qua_tex = new System.Windows.Forms.TextBox();
            this.par_tex = new System.Windows.Forms.TextBox();
            this.saved_but = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 120);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(573, 357);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // serch_but
            // 
            this.serch_but.Location = new System.Drawing.Point(306, 91);
            this.serch_but.Name = "serch_but";
            this.serch_but.Size = new System.Drawing.Size(75, 23);
            this.serch_but.TabIndex = 1;
            this.serch_but.Text = "search";
            this.serch_but.UseVisualStyleBackColor = true;
            this.serch_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // refreh_but
            // 
            this.refreh_but.Location = new System.Drawing.Point(191, 91);
            this.refreh_but.Name = "refreh_but";
            this.refreh_but.Size = new System.Drawing.Size(75, 23);
            this.refreh_but.TabIndex = 1;
            this.refreh_but.Text = "refresh";
            this.refreh_but.UseVisualStyleBackColor = true;
            this.refreh_but.Click += new System.EventHandler(this.button2_Click);
            // 
            // par_ctex
            // 
            this.par_ctex.Location = new System.Drawing.Point(400, 90);
            this.par_ctex.Name = "par_ctex";
            this.par_ctex.Size = new System.Drawing.Size(148, 22);
            this.par_ctex.TabIndex = 2;
            this.par_ctex.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nameform_tex
            // 
            this.nameform_tex.Location = new System.Drawing.Point(12, 91);
            this.nameform_tex.Name = "nameform_tex";
            this.nameform_tex.Size = new System.Drawing.Size(148, 22);
            this.nameform_tex.TabIndex = 2;
            this.nameform_tex.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold);
            this.Password.Location = new System.Drawing.Point(4, 6);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(148, 44);
            this.Password.TabIndex = 3;
            this.Password.Text = "p_name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(298, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 44);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(392, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "p_cde";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(861, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "parcode";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(632, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "product name";
            // 
            // nam_tex
            // 
            this.nam_tex.Location = new System.Drawing.Point(750, 97);
            this.nam_tex.Name = "nam_tex";
            this.nam_tex.Size = new System.Drawing.Size(105, 22);
            this.nam_tex.TabIndex = 4;
            // 
            // pri_tex
            // 
            this.pri_tex.Location = new System.Drawing.Point(750, 264);
            this.pri_tex.Name = "pri_tex";
            this.pri_tex.Size = new System.Drawing.Size(105, 22);
            this.pri_tex.TabIndex = 5;
            // 
            // qua_tex
            // 
            this.qua_tex.Location = new System.Drawing.Point(750, 160);
            this.qua_tex.Name = "qua_tex";
            this.qua_tex.Size = new System.Drawing.Size(105, 22);
            this.qua_tex.TabIndex = 6;
            // 
            // par_tex
            // 
            this.par_tex.Location = new System.Drawing.Point(750, 336);
            this.par_tex.Name = "par_tex";
            this.par_tex.Size = new System.Drawing.Size(105, 22);
            this.par_tex.TabIndex = 7;
            // 
            // saved_but
            // 
            this.saved_but.Location = new System.Drawing.Point(648, 400);
            this.saved_but.Name = "saved_but";
            this.saved_but.Size = new System.Drawing.Size(101, 67);
            this.saved_but.TabIndex = 13;
            this.saved_but.Text = "saved";
            this.saved_but.UseVisualStyleBackColor = true;
            this.saved_but.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(911, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(941, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // product_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saved_but);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nam_tex);
            this.Controls.Add(this.pri_tex);
            this.Controls.Add(this.qua_tex);
            this.Controls.Add(this.par_tex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.nameform_tex);
            this.Controls.Add(this.par_ctex);
            this.Controls.Add(this.refreh_but);
            this.Controls.Add(this.serch_but);
            this.Controls.Add(this.dataGridView1);
            this.Name = "product_list";
            this.Text = "product_list";
            this.Load += new System.EventHandler(this.product_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button serch_but;
        private System.Windows.Forms.Button refreh_but;
        private System.Windows.Forms.TextBox par_ctex;
        private System.Windows.Forms.TextBox nameform_tex;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nam_tex;
        private System.Windows.Forms.TextBox pri_tex;
        private System.Windows.Forms.TextBox qua_tex;
        private System.Windows.Forms.TextBox par_tex;
        private System.Windows.Forms.Button saved_but;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
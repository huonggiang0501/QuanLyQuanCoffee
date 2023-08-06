namespace QuanLyQuanCoffe.View.Admin_Side
{
    partial class fIncreOfFood
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Id = new System.Windows.Forms.Label();
            this.kl = new System.Windows.Forms.Label();
            this.IdNL = new System.Windows.Forms.Label();
            this.IdFood = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddAcount = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(197, 121);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(684, 317);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(204, 81);
            this.Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(23, 19);
            this.Id.TabIndex = 19;
            this.Id.Text = "Id";
            // 
            // kl
            // 
            this.kl.AutoSize = true;
            this.kl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.kl.Location = new System.Drawing.Point(567, 81);
            this.kl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kl.Name = "kl";
            this.kl.Size = new System.Drawing.Size(100, 19);
            this.kl.TabIndex = 18;
            this.kl.Text = "Khối lượng ";
            // 
            // IdNL
            // 
            this.IdNL.AutoSize = true;
            this.IdNL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.IdNL.Location = new System.Drawing.Point(404, 81);
            this.IdNL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdNL.Name = "IdNL";
            this.IdNL.Size = new System.Drawing.Size(124, 19);
            this.IdNL.TabIndex = 17;
            this.IdNL.Text = "Id Nguyên Liệu";
            // 
            // IdFood
            // 
            this.IdFood.AutoSize = true;
            this.IdFood.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdFood.Location = new System.Drawing.Point(276, 81);
            this.IdFood.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdFood.Name = "IdFood";
            this.IdFood.Size = new System.Drawing.Size(67, 19);
            this.IdFood.TabIndex = 16;
            this.IdFood.Text = "Id Food";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nguyên Liệu Của Sản Phẩm";
            // 
            // AddAcount
            // 
            this.AddAcount.AutoRoundedCorners = true;
            this.AddAcount.BorderRadius = 26;
            this.AddAcount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddAcount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddAcount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddAcount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddAcount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.AddAcount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAcount.ForeColor = System.Drawing.Color.White;
            this.AddAcount.Location = new System.Drawing.Point(591, 458);
            this.AddAcount.Margin = new System.Windows.Forms.Padding(2);
            this.AddAcount.Name = "AddAcount";
            this.AddAcount.Size = new System.Drawing.Size(232, 54);
            this.AddAcount.TabIndex = 21;
            this.AddAcount.Text = "Thêm Nguyên Liệu Cho Sản Phẩm";
            this.AddAcount.Click += new System.EventHandler(this.AddAcount_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::QuanLyQuanCoffe.Properties.Resources.cafe;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(13, 176);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(178, 175);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 22;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 26;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(34, 451);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(139, 54);
            this.guna2Button1.TabIndex = 23;
            this.guna2Button1.Text = "Back";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // fIncreOfFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 516);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.AddAcount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.kl);
            this.Controls.Add(this.IdNL);
            this.Controls.Add(this.IdFood);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "fIncreOfFood";
            this.Text = "fIncreOfFood";
            this.Load += new System.EventHandler(this.fIncreOfFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label kl;
        private System.Windows.Forms.Label IdNL;
        private System.Windows.Forms.Label IdFood;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button AddAcount;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
namespace QuanLyQuanCoffe.UserControls
{
    partial class UserItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemUserName = new System.Windows.Forms.Label();
            this.itemType = new System.Windows.Forms.Label();
            this.ButtonUpdate = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ButtonRemove = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtMaNV = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // itemUserName
            // 
            this.itemUserName.AutoSize = true;
            this.itemUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemUserName.Location = new System.Drawing.Point(101, 19);
            this.itemUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemUserName.Name = "itemUserName";
            this.itemUserName.Size = new System.Drawing.Size(128, 19);
            this.itemUserName.TabIndex = 1;
            this.itemUserName.Text = "Tên Đăng Nhập";
            this.itemUserName.Click += new System.EventHandler(this.itemUserName_Click);
            // 
            // itemType
            // 
            this.itemType.AutoSize = true;
            this.itemType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.itemType.Location = new System.Drawing.Point(344, 19);
            this.itemType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemType.Name = "itemType";
            this.itemType.Size = new System.Drawing.Size(77, 19);
            this.itemType.TabIndex = 2;
            this.itemType.Text = "Chức Vụ";
            this.itemType.Click += new System.EventHandler(this.itemType_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.ButtonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.Location = new System.Drawing.Point(706, 9);
            this.ButtonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonUpdate.Size = new System.Drawing.Size(54, 37);
            this.ButtonUpdate.TabIndex = 3;
            this.ButtonUpdate.Text = "Sửa";
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click_1);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonRemove.FillColor = System.Drawing.Color.Red;
            this.ButtonRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRemove.ForeColor = System.Drawing.Color.Black;
            this.ButtonRemove.Location = new System.Drawing.Point(775, 9);
            this.ButtonRemove.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonRemove.Size = new System.Drawing.Size(54, 37);
            this.ButtonRemove.TabIndex = 4;
            this.ButtonRemove.Text = "Xóa";
            this.ButtonRemove.Tile = false;
            this.ButtonRemove.UseTransparentBackground = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click_1);
            // 
            // txtMaNV
            // 
            this.txtMaNV.AutoSize = true;
            this.txtMaNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtMaNV.Location = new System.Drawing.Point(542, 19);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(114, 19);
            this.txtMaNV.TabIndex = 5;
            this.txtMaNV.Text = "Mã Nhân Viên";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::QuanLyQuanCoffe.Properties.Resources.user_icon_1506701;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 2);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(48, 52);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // UserItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.itemType);
            this.Controls.Add(this.itemUserName);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserItem";
            this.Size = new System.Drawing.Size(852, 58);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label itemUserName;
        private System.Windows.Forms.Label itemType;
        private System.Windows.Forms.Label txtMaNV;
        public Guna.UI2.WinForms.Guna2CircleButton ButtonUpdate;
        protected internal Guna.UI2.WinForms.Guna2CircleButton ButtonRemove;
    }
}

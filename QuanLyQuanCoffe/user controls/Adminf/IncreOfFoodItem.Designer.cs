namespace QuanLyQuanCoffe.user_controls.Adminf
{
    partial class IncreOfFoodItem
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
            this.Id = new System.Windows.Forms.Label();
            this.kl = new System.Windows.Forms.Label();
            this.ButtonRemove = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ButtonUpdate = new Guna.UI2.WinForms.Guna2CircleButton();
            this.IdNL = new System.Windows.Forms.Label();
            this.IdFood = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(8, 29);
            this.Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(23, 19);
            this.Id.TabIndex = 15;
            this.Id.Text = "Id";
            this.Id.Click += new System.EventHandler(this.MaNL_Click);
            // 
            // kl
            // 
            this.kl.AutoSize = true;
            this.kl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.kl.Location = new System.Drawing.Point(371, 29);
            this.kl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kl.Name = "kl";
            this.kl.Size = new System.Drawing.Size(100, 19);
            this.kl.TabIndex = 14;
            this.kl.Text = "Khối lượng ";
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonRemove.FillColor = System.Drawing.Color.Red;
            this.ButtonRemove.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemove.ForeColor = System.Drawing.Color.Black;
            this.ButtonRemove.Location = new System.Drawing.Point(574, 14);
            this.ButtonRemove.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonRemove.Size = new System.Drawing.Size(62, 51);
            this.ButtonRemove.TabIndex = 13;
            this.ButtonRemove.Text = "Xóa";
            this.ButtonRemove.Tile = false;
            this.ButtonRemove.UseTransparentBackground = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.ButtonUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.Location = new System.Drawing.Point(498, 14);
            this.ButtonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonUpdate.Size = new System.Drawing.Size(61, 51);
            this.ButtonUpdate.TabIndex = 12;
            this.ButtonUpdate.Text = "Sửa";
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // IdNL
            // 
            this.IdNL.AutoSize = true;
            this.IdNL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.IdNL.Location = new System.Drawing.Point(208, 29);
            this.IdNL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdNL.Name = "IdNL";
            this.IdNL.Size = new System.Drawing.Size(124, 19);
            this.IdNL.TabIndex = 11;
            this.IdNL.Text = "Id Nguyên Liệu";
            this.IdNL.Click += new System.EventHandler(this.itemTL_Click);
            // 
            // IdFood
            // 
            this.IdFood.AutoSize = true;
            this.IdFood.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdFood.Location = new System.Drawing.Point(80, 29);
            this.IdFood.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdFood.Name = "IdFood";
            this.IdFood.Size = new System.Drawing.Size(67, 19);
            this.IdFood.TabIndex = 10;
            this.IdFood.Text = "Id Food";
            // 
            // IncreOfFoodItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.Id);
            this.Controls.Add(this.kl);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.IdNL);
            this.Controls.Add(this.IdFood);
            this.Name = "IncreOfFoodItem";
            this.Size = new System.Drawing.Size(650, 84);
            this.Load += new System.EventHandler(this.IncreOfFoodItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label kl;
        protected internal Guna.UI2.WinForms.Guna2CircleButton ButtonRemove;
        public Guna.UI2.WinForms.Guna2CircleButton ButtonUpdate;
        private System.Windows.Forms.Label IdNL;
        private System.Windows.Forms.Label IdFood;
    }
}

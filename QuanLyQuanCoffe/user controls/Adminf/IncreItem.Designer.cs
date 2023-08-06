namespace QuanLyQuanCoffe.user_controls.Adminf
{
    partial class IncreItem
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
            this.ButtonRemove = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ButtonUpdate = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtgia = new System.Windows.Forms.Label();
            this.itemTL = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.Label();
            this.MaNL = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.ButtonRemove.Location = new System.Drawing.Point(731, 2);
            this.ButtonRemove.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonRemove.Size = new System.Drawing.Size(62, 51);
            this.ButtonRemove.TabIndex = 7;
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
            this.ButtonUpdate.Location = new System.Drawing.Point(655, 2);
            this.ButtonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonUpdate.Size = new System.Drawing.Size(61, 51);
            this.ButtonUpdate.TabIndex = 6;
            this.ButtonUpdate.Text = "Sửa";
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // txtgia
            // 
            this.txtgia.AutoSize = true;
            this.txtgia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtgia.Location = new System.Drawing.Point(536, 18);
            this.txtgia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(34, 19);
            this.txtgia.TabIndex = 8;
            this.txtgia.Text = "Gía";
            this.txtgia.Click += new System.EventHandler(this.txtgia_Click);
            // 
            // itemTL
            // 
            this.itemTL.AutoSize = true;
            this.itemTL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.itemTL.Location = new System.Drawing.Point(330, 18);
            this.itemTL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemTL.Name = "itemTL";
            this.itemTL.Size = new System.Drawing.Size(105, 19);
            this.itemTL.TabIndex = 3;
            this.itemTL.Text = "Trọng lượng";
            this.itemTL.Click += new System.EventHandler(this.itemType_Click);
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(88, 18);
            this.itemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(139, 19);
            this.itemName.TabIndex = 2;
            this.itemName.Text = "Tên Nguyên Liệu";
            this.itemName.Click += new System.EventHandler(this.itemName_Click);
            // 
            // MaNL
            // 
            this.MaNL.AutoSize = true;
            this.MaNL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNL.Location = new System.Drawing.Point(16, 18);
            this.MaNL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaNL.Name = "MaNL";
            this.MaNL.Size = new System.Drawing.Size(57, 19);
            this.MaNL.TabIndex = 9;
            this.MaNL.Text = "Mã NL";
            this.MaNL.Click += new System.EventHandler(this.label1_Click);
            // 
            // IncreItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.MaNL);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.itemTL);
            this.Controls.Add(this.itemName);
            this.Name = "IncreItem";
            this.Size = new System.Drawing.Size(816, 58);
            this.Load += new System.EventHandler(this.IncreItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal Guna.UI2.WinForms.Guna2CircleButton ButtonRemove;
        public Guna.UI2.WinForms.Guna2CircleButton ButtonUpdate;
        private System.Windows.Forms.Label txtgia;
        private System.Windows.Forms.Label itemTL;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label MaNL;
    }
}

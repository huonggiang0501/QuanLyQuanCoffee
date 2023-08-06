
namespace QuanLyQuanCoffe.user_controls.Adminf
{
    partial class fManagerProduct
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
            this.btnShowAll = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanelFoodList = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.TextSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonsMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnHt = new Guna.UI2.WinForms.Guna2Button();
            this.btnCake = new Guna.UI2.WinForms.Guna2Button();
            this.btnTs = new Guna.UI2.WinForms.Guna2Button();
            this.btnCfVn = new Guna.UI2.WinForms.Guna2Button();
            this.btnCfM = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butTim = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowAll
            // 
            this.btnShowAll.AutoRoundedCorners = true;
            this.btnShowAll.BorderRadius = 19;
            this.btnShowAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnShowAll.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnShowAll.Location = new System.Drawing.Point(153, 152);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(117, 40);
            this.btnShowAll.TabIndex = 22;
            this.btnShowAll.Text = "Tất cả món";
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // flowLayoutPanelFoodList
            // 
            this.flowLayoutPanelFoodList.AutoScroll = true;
            this.flowLayoutPanelFoodList.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelFoodList.Location = new System.Drawing.Point(25, 211);
            this.flowLayoutPanelFoodList.Name = "flowLayoutPanelFoodList";
            this.flowLayoutPanelFoodList.Size = new System.Drawing.Size(784, 295);
            this.flowLayoutPanelFoodList.TabIndex = 21;
            this.flowLayoutPanelFoodList.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelFoodList_Paint);
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.AutoRoundedCorners = true;
            this.ButtonAddProduct.BorderRadius = 19;
            this.ButtonAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.ButtonAddProduct.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddProduct.ForeColor = System.Drawing.Color.White;
            this.ButtonAddProduct.ImageOffset = new System.Drawing.Point(-2, 0);
            this.ButtonAddProduct.Location = new System.Drawing.Point(25, 152);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(122, 40);
            this.ButtonAddProduct.TabIndex = 20;
            this.ButtonAddProduct.Text = "Thêm món";
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click_1);
            // 
            // TextSearch
            // 
            this.TextSearch.Animated = true;
            this.TextSearch.AutoRoundedCorners = true;
            this.TextSearch.BorderRadius = 19;
            this.TextSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextSearch.DefaultText = "";
            this.TextSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextSearch.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextSearch.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.TextSearch.IconLeftSize = new System.Drawing.Size(15, 15);
            this.TextSearch.Location = new System.Drawing.Point(364, 152);
            this.TextSearch.Margin = new System.Windows.Forms.Padding(0);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.PasswordChar = '\0';
            this.TextSearch.PlaceholderText = "Tìm kiếm trong menu";
            this.TextSearch.SelectedText = "";
            this.TextSearch.Size = new System.Drawing.Size(212, 40);
            this.TextSearch.TabIndex = 19;
            this.TextSearch.TextOffset = new System.Drawing.Point(10, 0);
            this.TextSearch.TextChanged += new System.EventHandler(this.TextSearch_TextChanged);
            // 
            // ButtonsMenu
            // 
            this.ButtonsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsMenu.ColumnCount = 5;
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.Controls.Add(this.btnHt, 0, 0);
            this.ButtonsMenu.Controls.Add(this.btnCake, 0, 0);
            this.ButtonsMenu.Controls.Add(this.btnTs, 0, 0);
            this.ButtonsMenu.Controls.Add(this.btnCfVn, 0, 0);
            this.ButtonsMenu.Controls.Add(this.btnCfM, 0, 0);
            this.ButtonsMenu.Location = new System.Drawing.Point(26, 77);
            this.ButtonsMenu.Name = "ButtonsMenu";
            this.ButtonsMenu.RowCount = 1;
            this.ButtonsMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsMenu.Size = new System.Drawing.Size(517, 60);
            this.ButtonsMenu.TabIndex = 18;
            // 
            // btnHt
            // 
            this.btnHt.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHt.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnHt.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHt.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnHt.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnHt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnHt.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHt.ForeColor = System.Drawing.Color.Black;
            this.btnHt.Location = new System.Drawing.Point(309, 0);
            this.btnHt.Margin = new System.Windows.Forms.Padding(0);
            this.btnHt.Name = "btnHt";
            this.btnHt.Size = new System.Drawing.Size(103, 60);
            this.btnHt.TabIndex = 5;
            this.btnHt.Tag = "Dessert";
            this.btnHt.Text = "Hồng trà";
            this.btnHt.Click += new System.EventHandler(this.btnHt_Click_1);
            // 
            // btnCake
            // 
            this.btnCake.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCake.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnCake.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCake.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCake.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnCake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCake.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCake.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCake.ForeColor = System.Drawing.Color.Black;
            this.btnCake.Location = new System.Drawing.Point(412, 0);
            this.btnCake.Margin = new System.Windows.Forms.Padding(0);
            this.btnCake.Name = "btnCake";
            this.btnCake.Size = new System.Drawing.Size(105, 60);
            this.btnCake.TabIndex = 4;
            this.btnCake.Tag = "Smoothies";
            this.btnCake.Text = "Bánh ngọt";
            this.btnCake.Click += new System.EventHandler(this.btnCake_Click_1);
            // 
            // btnTs
            // 
            this.btnTs.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTs.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnTs.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTs.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnTs.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnTs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnTs.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTs.ForeColor = System.Drawing.Color.Black;
            this.btnTs.Location = new System.Drawing.Point(206, 0);
            this.btnTs.Margin = new System.Windows.Forms.Padding(0);
            this.btnTs.Name = "btnTs";
            this.btnTs.Size = new System.Drawing.Size(103, 60);
            this.btnTs.TabIndex = 3;
            this.btnTs.Tag = "Drinks";
            this.btnTs.Text = "Trà sữa";
            this.btnTs.Click += new System.EventHandler(this.btnTs_Click_1);
            // 
            // btnCfVn
            // 
            this.btnCfVn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCfVn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnCfVn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCfVn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCfVn.CustomBorderColor = System.Drawing.Color.White;
            this.btnCfVn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnCfVn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCfVn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCfVn.FocusedColor = System.Drawing.Color.White;
            this.btnCfVn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCfVn.ForeColor = System.Drawing.Color.Black;
            this.btnCfVn.Location = new System.Drawing.Point(0, 0);
            this.btnCfVn.Margin = new System.Windows.Forms.Padding(0);
            this.btnCfVn.Name = "btnCfVn";
            this.btnCfVn.Size = new System.Drawing.Size(103, 60);
            this.btnCfVn.TabIndex = 2;
            this.btnCfVn.Tag = "Coffee";
            this.btnCfVn.Text = "Cafe Việt Nam";
            this.btnCfVn.Click += new System.EventHandler(this.btnCfVn_Click_1);
            // 
            // btnCfM
            // 
            this.btnCfM.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCfM.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnCfM.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCfM.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCfM.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnCfM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCfM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCfM.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCfM.ForeColor = System.Drawing.Color.Black;
            this.btnCfM.Location = new System.Drawing.Point(103, 0);
            this.btnCfM.Margin = new System.Windows.Forms.Padding(0);
            this.btnCfM.Name = "btnCfM";
            this.btnCfM.Size = new System.Drawing.Size(103, 60);
            this.btnCfM.TabIndex = 1;
            this.btnCfM.Tag = "MilkTea";
            this.btnCfM.Text = "Cafe Máy";
            this.btnCfM.Click += new System.EventHandler(this.btnCfM_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quản lý món";
            // 
            // butTim
            // 
            this.butTim.BorderRadius = 23;
            this.butTim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.butTim.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTim.ForeColor = System.Drawing.Color.White;
            this.butTim.Location = new System.Drawing.Point(594, 155);
            this.butTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butTim.Name = "butTim";
            this.butTim.Size = new System.Drawing.Size(89, 37);
            this.butTim.TabIndex = 23;
            this.butTim.Text = "Tìm";
            this.butTim.Click += new System.EventHandler(this.butTim_Click);
            // 
            // fManagerProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butTim);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.flowLayoutPanelFoodList);
            this.Controls.Add(this.ButtonAddProduct);
            this.Controls.Add(this.TextSearch);
            this.Controls.Add(this.ButtonsMenu);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fManagerProduct";
            this.Size = new System.Drawing.Size(820, 566);
            this.Load += new System.EventHandler(this.fManagerProduct_Load);
            this.ButtonsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnShowAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFoodList;
        private Guna.UI2.WinForms.Guna2Button ButtonAddProduct;
        private Guna.UI2.WinForms.Guna2TextBox TextSearch;
        private System.Windows.Forms.TableLayoutPanel ButtonsMenu;
        private Guna.UI2.WinForms.Guna2Button btnHt;
        private Guna.UI2.WinForms.Guna2Button btnCake;
        private Guna.UI2.WinForms.Guna2Button btnTs;
        private Guna.UI2.WinForms.Guna2Button btnCfVn;
        private Guna.UI2.WinForms.Guna2Button btnCfM;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button butTim;
    }
}

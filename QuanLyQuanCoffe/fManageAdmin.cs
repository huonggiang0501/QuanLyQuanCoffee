using QuanLyQuanCoffe.Controls;
using QuanLyQuanCoffe.Models;
using QuanLyQuanCoffe.UserControls;
using System;
using QuanLyQuanCoffe.user_controls.Adminf;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffe
{
    public partial class fManageAdmin : Form
    {
        private Account CurrentSession;
        public fManageAdmin(Account session)
        {
            InitializeComponent();
            HideAllSubContent();

            string currentSessionUserDisplay = AccountDAO.Instance.GetNameFromID(session.IdEmployee);
            txtSessionUser.Text = currentSessionUserDisplay;
            CurrentSession = session;

        }

        private void fManageAdmin_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            formSaleReport1.BringToFront();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            fManagerProduct1.BringToFront();
        
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        // Sale
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
            fPromotion1.BringToFront();
        }

        private void HideAllSubContent()
        {
            
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            fUser1.BringToFront();
        }

        private void fDetail3_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //fManageIncredient1.BringtoFront();
        }

        private void fManageIncredient2_Load(object sender, EventArgs e)
        {

        }

        private void fManageIncredient1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click_2(object sender, EventArgs e)
        {
            fManageIncredient2.BringToFront();
        }
    }
}

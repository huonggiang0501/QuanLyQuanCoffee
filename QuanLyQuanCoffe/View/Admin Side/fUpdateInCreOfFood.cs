using QuanLyQuanCoffe.Controls;
using QuanLyQuanCoffe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyQuanCoffe.View.Admin_Side
{
    public partial class fUpdateInCreOfFood : Form
    {
        private IncreOfFood current;
        public fUpdateInCreOfFood(IncreOfFood item)
        {
            InitializeComponent();
            current = item;
            txtidFood.Value = (decimal)current.IdFood;
            txtIdCre.Text = current.IdCre;
            txtKL.Value = (decimal)current.QuantityIncre;


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtidFood.Value = (decimal)current.IdFood;
            txtIdCre.Text = current.IdCre;
            txtKL.Value = (decimal)current.QuantityIncre;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                IncreOfFoodDAO.Instance.UpdateQuantityIncreofFood((int)txtidFood.Value,txtIdCre.Text,(float)txtKL.Value);
                MessageBox.Show("Sửa thành công");
                this.Close();

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) //conflict primary key exception
                {
                    MessageBox.Show("Mã  bị trùng");
                    return;

                }
            }
        }

        private void txtidFood_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

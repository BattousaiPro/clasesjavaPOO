using GestionDeStockController.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCategory();
            
        }


        private void PopulateCategory() 
        {
            
            List<CategoryModel> categoryModels = new List<CategoryModel>();
            categoryModels.Add(new CategoryModel {
                IdCategory = 0,
                CategoryName = "Seleccione opcion"
            });
            categoryModels.Add(new CategoryModel
            {
                IdCategory = 1,
                CategoryName = "Electronica"
            });
            categoryModels.Add(new CategoryModel
            {
                IdCategory = 2,
                CategoryName = "Muebles"
            });
            categoryModels.Add(new CategoryModel
            {
                IdCategory = 3,
                CategoryName = "Linea blanca"
            });
            cbxCategories.DataSource = categoryModels;
            cbxCategories.DisplayMember = "CategoryName";
            cbxCategories.ValueMember = "IdCategory";
        }

       /*rivate void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string msg = "INVENTORYo agregado con exito a la BBDD";
            try
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];

                tbxElectronica.Text = row.Cells[1].Value.ToString();
                tbxAdddress.Text = row.Cells[2].Value.ToString();
                tbxPhone.Text = row.Cells[3].Value.ToString();
                tbxMail.Text = row.Cells[4].Value.ToString();
            }
            catch
            {
                msg = "INVENTORYo No agregado con exito a la BBDD";
                MessageBox.Show(msg);
            }
        }*/


        private void btnExportation_Click(object sender, EventArgs e)
        {
            try
            { 
                
            }
            catch
            {

            }
        }
    }   
    
}

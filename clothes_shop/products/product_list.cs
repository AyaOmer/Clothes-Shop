using clothes_shop.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clothes_shop.products
{
    public partial class product_list : Form
    {
        salesEntities1 db = new salesEntities1();

        string path="";
        int id;
        public product_list()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Products.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(nam_tex.Text =="")
                dataGridView1.DataSource = db.Products.Where(x => x.Code == par_ctex.Text).ToList();
            else  dataGridView1.DataSource = db.Products.Where(x => x.Code == par_ctex.Text || x.Name==  nameform_tex.Text).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void product_list_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.ToList();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var result = db.Products.SingleOrDefault(x => x.Id == id);
            result.Name = nam_tex.Text;
            result.Quantity = int.Parse(qua_tex.Text);
            result.Price = decimal.Parse(pri_tex.Text);
            result.Code = par_tex.Text;
            result.Image = path;
            db.SaveChanges();
            MessageBox.Show("SAVED");
            dataGridView1.DataSource = db.Products.ToList();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                 id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var result = db.Products.SingleOrDefault(x => x.Id == id);
                nam_tex.Text = result.Name;
                qua_tex.Text = result.Quantity.ToString();
                pri_tex.Text = result.Price.ToString();
                par_tex.Text = result.Code;

                pictureBox1.ImageLocation = result.Image;
            }
            catch { }

      }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog()==DialogResult.OK )
            {
                path = dialog.FileName;
                pictureBox1.ImageLocation = dialog.FileName;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var r = MessageBox.Show("do you want to delete", "are you sure about delete", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                var result = db.Products.Find(id);
                db.Products.Remove(result);
                db.SaveChanges();
                MessageBox.Show("delete");
                dataGridView1.DataSource = db.Products.ToList();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            products p = new products();
            p.Show();
        }

        
    }
}

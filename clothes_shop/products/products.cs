using clothes_shop.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clothes_shop.products
{
    public partial class products : Form
    {
        string path="";
        string newpath = "";
        salesEntities1 db = new salesEntities1();
        public products()
        {
            InitializeComponent();
        }

        private void products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.salesDataSet.Category);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product()
          
             {
                 Name = textBox4.Text,
                 Quantity = int.Parse(textBox3.Text),
                 Price = decimal.Parse(textBox2.Text),
                 Code = textBox1.Text

             };
            db.Products.Add(p);
            db.SaveChanges();
           newpath ="C:\\Users\\Microsoft\\Documents\\visual studio 2013\\Projects\\clothes_shop\\clothes_shop\\bin\\photos\\product\\" + p.Id + ".jpg";
          File.Copy(path, newpath);
          p.Image = newpath;
          db.SaveChanges();


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                path = dialog.FileName;
                pictureBox1.ImageLocation = dialog.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            product_list p = new product_list();
            p.Show();
        }
    }
}

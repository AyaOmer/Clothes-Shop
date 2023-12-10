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

namespace clothes_shop.Users
{
    public partial class New_Users : Form
    {
        salesEntities1 db =new salesEntities1() ;
        string img;
        public New_Users()
        {
            InitializeComponent();
            MessageBox.Show(Environment.CurrentDirectory);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        { User u= new User()
        {
            userName = textBox1.Text,
            password = textBox2.Text,
          image=img
        };
            db.Users.Add(u);
            db.SaveChanges();
        //string newpath = Environment.CurrentDirectory + "\\photos\\users\\" +  u.id  + ".jpg";
        //    File.Copy(img, newpath);
        //    u.image = newpath;
        //    db.SaveChanges();
        //    MessageBox.Show(newpath);
            MessageBox.Show("DONE");
            //MessageBox.Show(Environment.CurrentDirectory);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
               img = dialog.FileName;
                pictureBox1.ImageLocation =dialog.FileName;

        }
    }
}

using clothes_shop.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clothes_shop
{
    public partial class log_in : Form
    {
        salesEntities1 db = new salesEntities1();
        public log_in()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result=db.Users.Where(x=>x.userName==textBox1.Text && x.password==textBox2.Text ).ToList();
            //New_Users obj=new New_Users();
            //obj.show();
            if (result.Count() > 0)
            {
                this.Close();
                Thread th = new Thread(fn);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

            }
            else MessageBox.Show("INVALID PASSWORD OR USER NAME");
        }
      void fn()
        {
            Application.Run(new Home());
        }

      private void label2_Click(object sender, EventArgs e)
      {

      }

      private void button1_Click_1(object sender, EventArgs e)
      {

      }
    }
}

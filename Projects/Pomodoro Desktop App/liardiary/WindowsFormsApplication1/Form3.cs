using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            edit_min.Text = "25";
            edit_sec.Text = "00";
        }

        private void edit_plus_Click(object sender, EventArgs e)
        {
            int plus;
            int.TryParse(edit_min.Text, out plus);
            plus++;
            if (plus < 10)
                edit_min.Text = "0" + plus.ToString();
            else
                edit_min.Text = plus.ToString();
            
        }




        private void edit_minus_Click(object sender, EventArgs e)
        {
            int minus;
            int.TryParse(edit_min.Text, out minus);
            minus--;
            if (minus < 10)
                edit_min.Text = "0" + minus.ToString();
            else
                edit_min.Text = minus.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 clock = new Form1();
            Form2 pause = new Form2();
            clock.minText = edit_min.Text;
            clock.secText = edit_sec.Text;
            clock.Show();
        }

    }
}

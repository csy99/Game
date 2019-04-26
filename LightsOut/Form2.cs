using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightsOut
{
    public partial class Form2 : Form
    {
        public int ReturnVal { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            int size;
            try { size = Convert.ToInt32(str); }
            catch
            {
                MessageBox.Show("Please enter an integer with in the range.");
                size = 5;
                return;
            }
            if(size < 3 || size > 7)  // sanity check
            {
                MessageBox.Show("Please enter an integer with in the range.");
                return;
            }
            this.ReturnVal = size;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

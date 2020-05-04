using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numberRange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(startBox.Text);
            int end = Convert.ToInt32(endBox.Text);
          
            for (int y = start; y <= end; y++)
            {
                outputLabel.Text += y + " ";
                outputLabel.Update();
                System.Threading.Thread.Sleep(100);
            }
  
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            Pen grayPen = new Pen(Color.Gray, 20);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            Rectangle table = new Rectangle(25, 25, 615, 315);

            Graphics t = CreateGraphics();
            Graphics r = CreateGraphics();
            t.FillRectangle(greenBrush, table);
            r.DrawRectangle(grayPen, 25, 25, 625, 325);
            
        }
    }
}
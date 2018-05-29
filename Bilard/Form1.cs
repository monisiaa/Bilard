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
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Rectangle table = new Rectangle(25, 25, 615, 315);

            Graphics t = CreateGraphics();
            Graphics r = CreateGraphics();
            t.FillRectangle(greenBrush, table);
            r.DrawRectangle(grayPen, 25, 25, 625, 325);

            Graphics l1 = CreateGraphics();
            l1.FillEllipse(blackBrush, 26, 26, 25, 25);
            Graphics l2 = CreateGraphics();
            l2.FillEllipse(blackBrush, 322, 26, 25, 25);
            Graphics l3 = CreateGraphics();
            l3.FillEllipse(blackBrush, 618, 26, 25, 25);
            Graphics l4 = CreateGraphics();
            l4.FillEllipse(blackBrush, 618, 325, 25, 25);
            Graphics l5 = CreateGraphics();
            l5.FillEllipse(blackBrush, 322, 325, 25, 25);
            Graphics l6 = CreateGraphics();
            l6.FillEllipse(blackBrush, 26, 325, 25, 25);
        }
    }
}
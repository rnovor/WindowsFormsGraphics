using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics dc = e.Graphics;

            Pen bluePen = new Pen(Color.Blue, 3);
            dc.DrawRectangle(bluePen, 0, 0, 50, 50);

            Pen redPen = new Pen(Color.Red, 2);
            dc.DrawEllipse(redPen, 0, 50, 80, 60);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
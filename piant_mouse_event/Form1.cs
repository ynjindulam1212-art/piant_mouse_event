using System.Windows.Forms;

namespace piant_mouse_event
{
    public partial class Form1 : Form
    {
        Graphics g;     // зурах цаас
        Pen p;          // үзэг
        bool draw;      // хулганы товч дарагдсан эсэх
        int x, y;       // өмнөх цэгийн координат
        public Form1()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            p = new Pen(Color.Black, 2);
            draw = false;
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void colorToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void colorToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                g.DrawLine(p, x, y, e.X, e.Y);
                x = e.X;
                y = e.Y;
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }













        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            p.Width = (float)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p.Color = colorDialog1.Color;

            }
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            p.Width = (float)numericUpDown1.Value;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

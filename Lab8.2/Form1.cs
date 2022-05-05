using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Object getObject(int id)
        {
            Object[] obj = new Object[] { label1, label2, textBox1, textBox2, button1, button2 };
            return obj[id];
        }
        public void changeXY(int x, int y)
        {
            if(редактированиеПоложенияToolStripMenuItem.Checked)
            {
                int id = toolStripComboBox1.SelectedIndex;
                Control var = (Control)getObject(id);
                Point newPoint = var.Location;
                newPoint.X += 5 * x;
                newPoint.Y += 5 * y;
                var.Location = newPoint;
            }
        }

        private void левееToolStripMenuItem_Click(object sender, EventArgs e) => changeXY(-1, 0);

        private void правееToolStripMenuItem_Click(object sender, EventArgs e) => changeXY(1, 0);

        private void вышеToolStripMenuItem_Click(object sender, EventArgs e) => changeXY(0, -1);            
        
        private void нижеToolStripMenuItem_Click(object sender, EventArgs e) => changeXY(0, 1);

        private void очиститьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void редактированиеПоложенияToolStripMenuItem_Click(object sender, EventArgs e) => редактированиеПоложенияToolStripMenuItem.Checked = !редактированиеПоложенияToolStripMenuItem.Checked;

        private void button1_Click(object sender, EventArgs e) => textBox1.Text = "Действие 1";

        private void button2_Click(object sender, EventArgs e) => textBox2.Text = "Действие 2";
    }
}

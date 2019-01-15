using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            font.Items.AddRange(FontFamily.Families);
            //font.DisplayMember 

            for (int i = 8; i < 75; i += 5)
            {
                size.Items.Add(i);
            }

        }

        private void color_Click(object sender, EventArgs e)
        {
            ColorDialog colordialog = new ColorDialog();

            if (colordialog.ShowDialog() == DialogResult.OK)
            {
                colordialog.Color = basetxtbox.BackColor;
            }
        }

        private void font_SelectedIndexChanged(object sender, EventArgs e)
        {
            //basetxtbox.Font = new Font(font.SelectedIndex + 1);
        }

        private void size_SelectedIndexChanged(object sender, EventArgs e)
        {
            basetxtbox.Font = new Font(font.Text, int.Parse(size.Text));
        }
    }
}

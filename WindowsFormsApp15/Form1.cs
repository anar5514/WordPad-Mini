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
            font.DisplayMember = "Name";
            
            for (int i = 8; i < 75; i += 5)
            {
                size.Items.Add(i);
            }

            font.SelectedIndex = 156;
            size.SelectedIndex = 1;
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
            
        }

        private void size_SelectedIndexChanged(object sender, EventArgs e)
        {
            basetxtbox.SelectionFont = new Font(font.Text, int.Parse(size.Text));
        }

        private void bold_CheckedChanged(object sender, EventArgs e)
        {
            oldstyle = basetxtbox.Font.Style;
            if (bold.Checked)
            basetxtbox.SelectionFont = new Font(font.Text, Convert.ToInt32(size.Text), oldstyle | FontStyle.Bold);
            else if(bold.Checked == false)
                basetxtbox.SelectionFont = new Font(font.Text, Convert.ToInt32(size.Text), oldstyle & ~FontStyle.Regular);
        }
        FontStyle oldstyle = FontStyle.Regular;
        private void lined_CheckedChanged(object sender, EventArgs e)
        {
            oldstyle = basetxtbox.Font.Style;
            if (lined.Checked)
                basetxtbox.SelectionFont = new Font(font.Text, Convert.ToInt32(size.Text), oldstyle | FontStyle.Underline);
            else if (lined.Checked == false)
                basetxtbox.SelectionFont = new Font(font.Text, Convert.ToInt32(size.Text), oldstyle & ~FontStyle.Regular);
        }

        private void italic_CheckedChanged(object sender, EventArgs e)
        {
            oldstyle = basetxtbox.Font.Style;
            if (italic.Checked)
                basetxtbox.SelectionFont = new Font(font.Text, Convert.ToInt32(size.Text), oldstyle|FontStyle.Italic);
            else if (italic.Checked == false)
                basetxtbox.SelectionFont = new Font(font.Text, Convert.ToInt32(size.Text), oldstyle &~FontStyle.Regular);
        }

        private void left_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void center_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void right_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

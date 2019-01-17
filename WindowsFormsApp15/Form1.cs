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
    public partial class WordPadMini : Form
    {
        FontStyle oldstyle = FontStyle.Regular;
        public string Filename { get; set; }

        public WordPadMini()
        {
            InitializeComponent();
        }

        private void WordPadMini_Load(object sender, EventArgs e)
        {
            font.Items.AddRange(FontFamily.Families);
            font.DisplayMember = "Name";
 
            for (int i = 8; i < 75; i += 5)
            {
                size.Items.Add(i);
            }

            size.Text = "13";
            font.Text = "Times New Roman";

            basetxtbox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void color_Click(object sender, EventArgs e)
        {
            ColorDialog colordialog = new ColorDialog();

            if (colordialog.ShowDialog() == DialogResult.OK)
            {
                basetxtbox.ForeColor = colordialog.Color;
            }
        }

        private void font_SelectedIndexChanged(object sender, EventArgs e)
        {
            basetxtbox.SelectionFont = new Font(font.Text, int.Parse(size.Text));
        }

        private void size_SelectedIndexChanged(object sender, EventArgs e)
        {
            basetxtbox.SelectionFont = new Font(font.Text, int.Parse(size.Text));
        }

        private void bold_CheckedChanged(object sender, EventArgs e)
        {

            if (bold.Checked)
            {
                oldstyle = basetxtbox.SelectionFont.Style;
                basetxtbox.SelectionFont = new Font(font.Text, Convert.ToInt32(size.Text), oldstyle | FontStyle.Bold);
            }

            else if (bold.Checked == false)
                basetxtbox.SelectionFont = new Font(font.Text, Convert.ToInt32(size.Text), oldstyle & ~FontStyle.Regular);
        }

        private void lined_CheckedChanged(object sender, EventArgs e)
        {

            if (lined.Checked)
            {
                oldstyle = basetxtbox.SelectionFont.Style;
                basetxtbox.SelectionFont = new Font(font.Text, Convert.ToInt32(size.Text), oldstyle | FontStyle.Underline);
            }

            else if (lined.Checked == false)
                basetxtbox.SelectionFont = new Font(font.Text, Convert.ToInt32(size.Text), oldstyle & ~FontStyle.Regular);
        }

        private void italic_CheckedChanged(object sender, EventArgs e)
        {

            if (italic.Checked)
            {
                oldstyle = basetxtbox.SelectionFont.Style;
                basetxtbox.SelectionFont = new Font(font.Text, Convert.ToInt32(size.Text), oldstyle | FontStyle.Italic);
            }

            else if (italic.Checked == false)
                basetxtbox.SelectionFont = new Font(font.Text, Convert.ToInt32(size.Text), oldstyle & ~FontStyle.Regular);
        }
        
        private void btnleft_CheckedChanged(object sender, EventArgs e)
        {
            if (btnleft.Checked)
                basetxtbox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btncenter_CheckedChanged(object sender, EventArgs e)
        {
            if (btncenter.Checked)
                basetxtbox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnright_CheckedChanged(object sender, EventArgs e)
        {
            if (btnright.Checked)
                basetxtbox.SelectionAlignment = HorizontalAlignment.Right;
        }
    }
}

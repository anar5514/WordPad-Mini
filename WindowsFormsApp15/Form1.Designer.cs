namespace WindowsFormsApp15
{
    partial class WordPadMini
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.basetxtbox = new System.Windows.Forms.RichTextBox();
            this.font = new System.Windows.Forms.ComboBox();
            this.size = new System.Windows.Forms.ComboBox();
            this.bold = new System.Windows.Forms.CheckBox();
            this.lined = new System.Windows.Forms.CheckBox();
            this.italic = new System.Windows.Forms.CheckBox();
            this.btnload = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtboxload = new System.Windows.Forms.TextBox();
            this.txtboxsave = new System.Windows.Forms.TextBox();
            this.labelfont = new System.Windows.Forms.Label();
            this.labelsize = new System.Windows.Forms.Label();
            this.labelfontstyle = new System.Windows.Forms.Label();
            this.labelalign = new System.Windows.Forms.Label();
            this.labelcolor = new System.Windows.Forms.Label();
            this.btncolor = new System.Windows.Forms.Button();
            this.btnleft = new System.Windows.Forms.RadioButton();
            this.btnright = new System.Windows.Forms.RadioButton();
            this.btncenter = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // basetxtbox
            // 
            this.basetxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.basetxtbox.Location = new System.Drawing.Point(3, 93);
            this.basetxtbox.Name = "basetxtbox";
            this.basetxtbox.Size = new System.Drawing.Size(794, 358);
            this.basetxtbox.TabIndex = 1;
            this.basetxtbox.Text = "";
            // 
            // font
            // 
            this.font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.font.FormattingEnabled = true;
            this.font.Location = new System.Drawing.Point(12, 34);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(99, 21);
            this.font.TabIndex = 2;
            this.font.SelectedIndexChanged += new System.EventHandler(this.font_SelectedIndexChanged);
            // 
            // size
            // 
            this.size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.size.FormattingEnabled = true;
            this.size.Location = new System.Drawing.Point(129, 34);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(68, 21);
            this.size.TabIndex = 3;
            this.size.SelectedIndexChanged += new System.EventHandler(this.size_SelectedIndexChanged);
            // 
            // bold
            // 
            this.bold.Appearance = System.Windows.Forms.Appearance.Button;
            this.bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bold.Location = new System.Drawing.Point(213, 32);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(25, 25);
            this.bold.TabIndex = 4;
            this.bold.Text = "B";
            this.bold.UseVisualStyleBackColor = true;
            this.bold.CheckedChanged += new System.EventHandler(this.bold_CheckedChanged);
            // 
            // lined
            // 
            this.lined.Appearance = System.Windows.Forms.Appearance.Button;
            this.lined.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lined.Location = new System.Drawing.Point(244, 32);
            this.lined.Name = "lined";
            this.lined.Size = new System.Drawing.Size(25, 25);
            this.lined.TabIndex = 7;
            this.lined.Text = "U";
            this.lined.UseVisualStyleBackColor = true;
            this.lined.CheckedChanged += new System.EventHandler(this.lined_CheckedChanged);
            // 
            // italic
            // 
            this.italic.Appearance = System.Windows.Forms.Appearance.Button;
            this.italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.italic.Location = new System.Drawing.Point(275, 32);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(25, 25);
            this.italic.TabIndex = 8;
            this.italic.Text = "I";
            this.italic.UseVisualStyleBackColor = true;
            this.italic.CheckedChanged += new System.EventHandler(this.italic_CheckedChanged);
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(704, 21);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(75, 20);
            this.btnload.TabIndex = 13;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(704, 47);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 20);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtboxload
            // 
            this.txtboxload.ForeColor = System.Drawing.Color.Silver;
            this.txtboxload.Location = new System.Drawing.Point(528, 21);
            this.txtboxload.Name = "txtboxload";
            this.txtboxload.Size = new System.Drawing.Size(160, 20);
            this.txtboxload.TabIndex = 15;
            this.txtboxload.Text = "Enter a file name to load";
            this.txtboxload.Enter += new System.EventHandler(this.txtboxload_Enter);
            this.txtboxload.Leave += new System.EventHandler(this.txtboxload_Leave);
            // 
            // txtboxsave
            // 
            this.txtboxsave.ForeColor = System.Drawing.Color.Silver;
            this.txtboxsave.Location = new System.Drawing.Point(528, 47);
            this.txtboxsave.Name = "txtboxsave";
            this.txtboxsave.Size = new System.Drawing.Size(160, 20);
            this.txtboxsave.TabIndex = 16;
            this.txtboxsave.Text = "Enter a file name  to save";
            this.txtboxsave.Enter += new System.EventHandler(this.txtboxsave_Enter);
            this.txtboxsave.Leave += new System.EventHandler(this.txtboxsave_Leave);
            // 
            // labelfont
            // 
            this.labelfont.AutoSize = true;
            this.labelfont.Location = new System.Drawing.Point(46, 9);
            this.labelfont.Name = "labelfont";
            this.labelfont.Size = new System.Drawing.Size(28, 13);
            this.labelfont.TabIndex = 17;
            this.labelfont.Text = "Font";
            // 
            // labelsize
            // 
            this.labelsize.AutoSize = true;
            this.labelsize.Location = new System.Drawing.Point(145, 9);
            this.labelsize.Name = "labelsize";
            this.labelsize.Size = new System.Drawing.Size(27, 13);
            this.labelsize.TabIndex = 18;
            this.labelsize.Text = "Size";
            // 
            // labelfontstyle
            // 
            this.labelfontstyle.AutoSize = true;
            this.labelfontstyle.Location = new System.Drawing.Point(227, 9);
            this.labelfontstyle.Name = "labelfontstyle";
            this.labelfontstyle.Size = new System.Drawing.Size(51, 13);
            this.labelfontstyle.TabIndex = 19;
            this.labelfontstyle.Text = "FontStyle";
            // 
            // labelalign
            // 
            this.labelalign.AutoSize = true;
            this.labelalign.Location = new System.Drawing.Point(333, 9);
            this.labelalign.Name = "labelalign";
            this.labelalign.Size = new System.Drawing.Size(53, 13);
            this.labelalign.TabIndex = 20;
            this.labelalign.Text = "Alignment";
            // 
            // labelcolor
            // 
            this.labelcolor.AutoSize = true;
            this.labelcolor.Location = new System.Drawing.Point(440, 9);
            this.labelcolor.Name = "labelcolor";
            this.labelcolor.Size = new System.Drawing.Size(31, 13);
            this.labelcolor.TabIndex = 21;
            this.labelcolor.Text = "Color";
            // 
            // btncolor
            // 
            this.btncolor.Location = new System.Drawing.Point(412, 32);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(97, 25);
            this.btncolor.TabIndex = 22;
            this.btncolor.Text = "Choose color";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.color_Click);
            // 
            // btnleft
            // 
            this.btnleft.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnleft.Location = new System.Drawing.Point(319, 32);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(25, 25);
            this.btnleft.TabIndex = 23;
            this.btnleft.TabStop = true;
            this.btnleft.Text = "L";
            this.btnleft.UseVisualStyleBackColor = true;
            this.btnleft.CheckedChanged += new System.EventHandler(this.btnleft_CheckedChanged);
            // 
            // btnright
            // 
            this.btnright.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnright.Location = new System.Drawing.Point(381, 32);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(25, 25);
            this.btnright.TabIndex = 24;
            this.btnright.TabStop = true;
            this.btnright.Text = "R";
            this.btnright.UseVisualStyleBackColor = true;
            this.btnright.CheckedChanged += new System.EventHandler(this.btnright_CheckedChanged);
            // 
            // btncenter
            // 
            this.btncenter.Appearance = System.Windows.Forms.Appearance.Button;
            this.btncenter.Location = new System.Drawing.Point(350, 32);
            this.btncenter.Name = "btncenter";
            this.btncenter.Size = new System.Drawing.Size(25, 25);
            this.btncenter.TabIndex = 25;
            this.btncenter.TabStop = true;
            this.btncenter.Text = "C";
            this.btncenter.UseVisualStyleBackColor = true;
            this.btncenter.CheckedChanged += new System.EventHandler(this.btncenter_CheckedChanged);
            // 
            // WordPadMini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 457);
            this.Controls.Add(this.btncenter);
            this.Controls.Add(this.btnright);
            this.Controls.Add(this.btnleft);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.labelcolor);
            this.Controls.Add(this.labelalign);
            this.Controls.Add(this.labelfontstyle);
            this.Controls.Add(this.labelsize);
            this.Controls.Add(this.labelfont);
            this.Controls.Add(this.txtboxsave);
            this.Controls.Add(this.txtboxload);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.italic);
            this.Controls.Add(this.lined);
            this.Controls.Add(this.bold);
            this.Controls.Add(this.size);
            this.Controls.Add(this.font);
            this.Controls.Add(this.basetxtbox);
            this.Name = "WordPadMini";
            this.Text = "WordPad";
            this.Load += new System.EventHandler(this.WordPadMini_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox basetxtbox;
        private System.Windows.Forms.ComboBox font;
        private System.Windows.Forms.ComboBox size;
        private System.Windows.Forms.CheckBox bold;
        private System.Windows.Forms.CheckBox lined;
        private System.Windows.Forms.CheckBox italic;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtboxload;
        private System.Windows.Forms.TextBox txtboxsave;
        private System.Windows.Forms.Label labelfont;
        private System.Windows.Forms.Label labelsize;
        private System.Windows.Forms.Label labelfontstyle;
        private System.Windows.Forms.Label labelalign;
        private System.Windows.Forms.Label labelcolor;
        private System.Windows.Forms.Button btncolor;
        private System.Windows.Forms.RadioButton btnleft;
        private System.Windows.Forms.RadioButton btnright;
        private System.Windows.Forms.RadioButton btncenter;
    }
}


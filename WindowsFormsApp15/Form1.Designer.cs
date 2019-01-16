namespace WindowsFormsApp15
{
    partial class Form1
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
            this.right = new System.Windows.Forms.CheckBox();
            this.center = new System.Windows.Forms.CheckBox();
            this.left = new System.Windows.Forms.CheckBox();
            this.btnload = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.txtboxload = new System.Windows.Forms.TextBox();
            this.txtboxsave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btncolor = new System.Windows.Forms.Button();
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
            // right
            // 
            this.right.Appearance = System.Windows.Forms.Appearance.Button;
            this.right.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.right.Location = new System.Drawing.Point(381, 31);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(25, 25);
            this.right.TabIndex = 11;
            this.right.Text = "R";
            this.right.UseVisualStyleBackColor = true;
            this.right.CheckedChanged += new System.EventHandler(this.right_CheckedChanged);
            // 
            // center
            // 
            this.center.Appearance = System.Windows.Forms.Appearance.Button;
            this.center.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.center.Location = new System.Drawing.Point(350, 31);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(25, 25);
            this.center.TabIndex = 10;
            this.center.Text = "C";
            this.center.UseVisualStyleBackColor = true;
            this.center.CheckedChanged += new System.EventHandler(this.center_CheckedChanged);
            // 
            // left
            // 
            this.left.Appearance = System.Windows.Forms.Appearance.Button;
            this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.left.Location = new System.Drawing.Point(319, 31);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(25, 25);
            this.left.TabIndex = 9;
            this.left.Text = "L";
            this.left.UseVisualStyleBackColor = true;
            this.left.CheckedChanged += new System.EventHandler(this.left_CheckedChanged);
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(704, 21);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(75, 20);
            this.btnload.TabIndex = 13;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(704, 47);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 20);
            this.save.TabIndex = 14;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // txtboxload
            // 
            this.txtboxload.Location = new System.Drawing.Point(528, 21);
            this.txtboxload.Name = "txtboxload";
            this.txtboxload.Size = new System.Drawing.Size(160, 20);
            this.txtboxload.TabIndex = 15;
            // 
            // txtboxsave
            // 
            this.txtboxsave.Location = new System.Drawing.Point(528, 47);
            this.txtboxsave.Name = "txtboxsave";
            this.txtboxsave.Size = new System.Drawing.Size(160, 20);
            this.txtboxsave.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Font";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "FontStyle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Alignment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Color";
            // 
            // btncolor
            // 
            this.btncolor.Location = new System.Drawing.Point(412, 32);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(97, 23);
            this.btncolor.TabIndex = 22;
            this.btncolor.Text = "Choose color";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 457);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxsave);
            this.Controls.Add(this.txtboxload);
            this.Controls.Add(this.save);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.right);
            this.Controls.Add(this.center);
            this.Controls.Add(this.left);
            this.Controls.Add(this.italic);
            this.Controls.Add(this.lined);
            this.Controls.Add(this.bold);
            this.Controls.Add(this.size);
            this.Controls.Add(this.font);
            this.Controls.Add(this.basetxtbox);
            this.Name = "Form1";
            this.Text = "WordPad";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.CheckBox right;
        private System.Windows.Forms.CheckBox center;
        private System.Windows.Forms.CheckBox left;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox txtboxload;
        private System.Windows.Forms.TextBox txtboxsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncolor;
    }
}


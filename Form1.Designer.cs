using System;

namespace GoogleSheets
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.Update_sheet = new System.Windows.Forms.Button();
            this.Create_sheet = new System.Windows.Forms.Button();
            this.print_sheet = new System.Windows.Forms.Button();
            this.richTextbox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.start = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.sheet_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startNum = new System.Windows.Forms.NumericUpDown();
            this.endNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.startNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNum)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 26);
            this.textBox1.TabIndex = 1;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(407, 22);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(121, 28);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Browse\r\n";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(55, 95);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(180, 31);
            this.Upload.TabIndex = 3;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            // 
            // Update_sheet
            // 
            this.Update_sheet.Location = new System.Drawing.Point(369, 95);
            this.Update_sheet.Name = "Update_sheet";
            this.Update_sheet.Size = new System.Drawing.Size(159, 31);
            this.Update_sheet.TabIndex = 4;
            this.Update_sheet.Text = "Update SpreadSheet";
            this.Update_sheet.UseVisualStyleBackColor = true;
            this.Update_sheet.Click += new System.EventHandler(this.Update_sheet_Click);
            // 
            // Create_sheet
            // 
            this.Create_sheet.Location = new System.Drawing.Point(369, 143);
            this.Create_sheet.Name = "Create_sheet";
            this.Create_sheet.Size = new System.Drawing.Size(159, 31);
            this.Create_sheet.TabIndex = 5;
            this.Create_sheet.Text = "Create SpreadSheet";
            this.Create_sheet.UseVisualStyleBackColor = true;
            this.Create_sheet.Click += new System.EventHandler(this.Create_sheet_Click);
            // 
            // print_sheet
            // 
            this.print_sheet.Location = new System.Drawing.Point(369, 192);
            this.print_sheet.Name = "print_sheet";
            this.print_sheet.Size = new System.Drawing.Size(159, 31);
            this.print_sheet.TabIndex = 6;
            this.print_sheet.Text = "Print Sheet";
            this.print_sheet.UseVisualStyleBackColor = true;
            this.print_sheet.Click += new System.EventHandler(this.Print_sheet_Click);
            // 
            // richTextbox1
            // 
            this.richTextbox1.Location = new System.Drawing.Point(55, 262);
            this.richTextbox1.Multiline = true;
            this.richTextbox1.Name = "richTextbox1";
            this.richTextbox1.Size = new System.Drawing.Size(558, 181);
            this.richTextbox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownWidth = 40;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "AA",
            "BB"});
            this.comboBox1.Location = new System.Drawing.Point(718, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(65, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "AA",
            "BB"});
            this.comboBox2.Location = new System.Drawing.Point(718, 125);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(65, 28);
            this.comboBox2.TabIndex = 9;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(608, 95);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(96, 20);
            this.start.TabIndex = 10;
            this.start.Text = "Start Range";
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Location = new System.Drawing.Point(608, 128);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(90, 20);
            this.end.TabIndex = 11;
            this.end.Text = "End Range";
            // 
            // sheet_name
            // 
            this.sheet_name.Location = new System.Drawing.Point(718, 22);
            this.sheet_name.Name = "sheet_name";
            this.sheet_name.Size = new System.Drawing.Size(165, 26);
            this.sheet_name.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sheet Name";
            // 
            // startNum
            // 
            this.startNum.Location = new System.Drawing.Point(806, 91);
            this.startNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startNum.Name = "startNum";
            this.startNum.Size = new System.Drawing.Size(77, 26);
            this.startNum.TabIndex = 15;
            this.startNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endNum
            // 
            this.endNum.Location = new System.Drawing.Point(806, 126);
            this.endNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endNum.Name = "endNum";
            this.endNum.Size = new System.Drawing.Size(77, 26);
            this.endNum.TabIndex = 16;
            this.endNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1109, 498);
            this.Controls.Add(this.endNum);
            this.Controls.Add(this.startNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sheet_name);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextbox1);
            this.Controls.Add(this.print_sheet);
            this.Controls.Add(this.Create_sheet);
            this.Controls.Add(this.Update_sheet);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.startNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private String text;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Button Update_sheet;
        private System.Windows.Forms.Button Create_sheet;
        private System.Windows.Forms.Button print_sheet;
        private System.Windows.Forms.TextBox richTextbox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.TextBox sheet_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown startNum;
        private System.Windows.Forms.NumericUpDown endNum;
    }

 
}


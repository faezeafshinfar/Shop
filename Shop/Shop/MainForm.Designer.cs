namespace Shop
{
    partial class MainForm
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
            this.Calculator = new System.Windows.Forms.Button();
            this.InputWidth = new System.Windows.Forms.TextBox();
            this.InputHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Inputmohit = new System.Windows.Forms.Button();
            this.CalDisplay = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calculator
            // 
            this.Calculator.Location = new System.Drawing.Point(65, 265);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(56, 23);
            this.Calculator.TabIndex = 16;
            this.Calculator.Text = "Area";
            this.Calculator.UseVisualStyleBackColor = true;
            this.Calculator.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // InputWidth
            // 
            this.InputWidth.Location = new System.Drawing.Point(65, 123);
            this.InputWidth.Name = "InputWidth";
            this.InputWidth.Size = new System.Drawing.Size(146, 20);
            this.InputWidth.TabIndex = 18;
            this.InputWidth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // InputHeight
            // 
            this.InputHeight.Location = new System.Drawing.Point(65, 84);
            this.InputHeight.Name = "InputHeight";
            this.InputHeight.Size = new System.Drawing.Size(146, 20);
            this.InputHeight.TabIndex = 19;
            this.InputHeight.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Width";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Squere",
            "Rectangle"});
            this.comboBox1.DisplayMember = "1";
            this.comboBox1.Items.AddRange(new object[] {
            "Squere",
            "Rectangle"});
            this.comboBox1.Location = new System.Drawing.Point(74, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Tag = "Test";
            this.comboBox1.ValueMember = "1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Inputmohit
            // 
            this.Inputmohit.Location = new System.Drawing.Point(127, 265);
            this.Inputmohit.Name = "Inputmohit";
            this.Inputmohit.Size = new System.Drawing.Size(53, 23);
            this.Inputmohit.TabIndex = 23;
            this.Inputmohit.Text = "Mohit";
            this.Inputmohit.UseVisualStyleBackColor = true;
            this.Inputmohit.Click += new System.EventHandler(this.Inputmohit_Click);
            // 
            // CalDisplay
            // 
            this.CalDisplay.Location = new System.Drawing.Point(65, 167);
            this.CalDisplay.Name = "CalDisplay";
            this.CalDisplay.Size = new System.Drawing.Size(146, 55);
            this.CalDisplay.TabIndex = 24;
            this.CalDisplay.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Ghotr";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(660, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CalDisplay);
            this.Controls.Add(this.Inputmohit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputHeight);
            this.Controls.Add(this.InputWidth);
            this.Controls.Add(this.Calculator);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Calculator;
        private System.Windows.Forms.TextBox InputWidth;
        private System.Windows.Forms.TextBox InputHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Inputmohit;
        private System.Windows.Forms.ListView CalDisplay;
        private System.Windows.Forms.Button button1;
    }
}
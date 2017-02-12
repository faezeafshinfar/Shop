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
            this.InputSend = new System.Windows.Forms.Button();
            this.txtEngilishTitle = new System.Windows.Forms.TextBox();
            this.txtPersianTitle = new System.Windows.Forms.TextBox();
            this.txtBuyer = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtShortExplain = new System.Windows.Forms.TextBox();
            this.TxtFullExpalin = new System.Windows.Forms.TextBox();
            this.TxtProducter = new System.Windows.Forms.TextBox();
            this.PersianTitle = new System.Windows.Forms.Label();
            this.EngilishTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputSend
            // 
            this.InputSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputSend.Location = new System.Drawing.Point(137, 282);
            this.InputSend.Name = "InputSend";
            this.InputSend.Size = new System.Drawing.Size(75, 23);
            this.InputSend.TabIndex = 0;
            this.InputSend.Text = "Send";
            this.InputSend.UseVisualStyleBackColor = true;
            // 
            // txtEngilishTitle
            // 
            this.txtEngilishTitle.Location = new System.Drawing.Point(112, 36);
            this.txtEngilishTitle.Name = "txtEngilishTitle";
            this.txtEngilishTitle.Size = new System.Drawing.Size(100, 20);
            this.txtEngilishTitle.TabIndex = 1;
            this.txtEngilishTitle.TextChanged += new System.EventHandler(this.txtEngilishTitle_TextChanged);
            // 
            // txtPersianTitle
            // 
            this.txtPersianTitle.Location = new System.Drawing.Point(112, 65);
            this.txtPersianTitle.Name = "txtPersianTitle";
            this.txtPersianTitle.Size = new System.Drawing.Size(100, 20);
            this.txtPersianTitle.TabIndex = 2;
            // 
            // txtBuyer
            // 
            this.txtBuyer.Location = new System.Drawing.Point(112, 237);
            this.txtBuyer.Name = "txtBuyer";
            this.txtBuyer.Size = new System.Drawing.Size(100, 20);
            this.txtBuyer.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(112, 204);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // txtShortExplain
            // 
            this.txtShortExplain.Location = new System.Drawing.Point(112, 169);
            this.txtShortExplain.Name = "txtShortExplain";
            this.txtShortExplain.Size = new System.Drawing.Size(100, 20);
            this.txtShortExplain.TabIndex = 5;
            // 
            // TxtFullExpalin
            // 
            this.TxtFullExpalin.Location = new System.Drawing.Point(112, 136);
            this.TxtFullExpalin.Name = "TxtFullExpalin";
            this.TxtFullExpalin.Size = new System.Drawing.Size(100, 20);
            this.TxtFullExpalin.TabIndex = 6;
            // 
            // TxtProducter
            // 
            this.TxtProducter.Location = new System.Drawing.Point(112, 100);
            this.TxtProducter.Name = "TxtProducter";
            this.TxtProducter.Size = new System.Drawing.Size(100, 20);
            this.TxtProducter.TabIndex = 7;
            // 
            // PersianTitle
            // 
            this.PersianTitle.AutoSize = true;
            this.PersianTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersianTitle.Location = new System.Drawing.Point(14, 65);
            this.PersianTitle.Name = "PersianTitle";
            this.PersianTitle.Size = new System.Drawing.Size(74, 13);
            this.PersianTitle.TabIndex = 9;
            this.PersianTitle.Text = "PersianTitle";
            // 
            // EngilishTitle
            // 
            this.EngilishTitle.AutoSize = true;
            this.EngilishTitle.BackColor = System.Drawing.Color.Honeydew;
            this.EngilishTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EngilishTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.EngilishTitle.ForeColor = System.Drawing.Color.Black;
            this.EngilishTitle.Location = new System.Drawing.Point(12, 36);
            this.EngilishTitle.Name = "EngilishTitle";
            this.EngilishTitle.Size = new System.Drawing.Size(76, 13);
            this.EngilishTitle.TabIndex = 10;
            this.EngilishTitle.Text = "EngilishTitle";
            this.EngilishTitle.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Buyer ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Price ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ShortExplain ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "FullExplain ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Producter ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(660, 424);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EngilishTitle);
            this.Controls.Add(this.PersianTitle);
            this.Controls.Add(this.TxtProducter);
            this.Controls.Add(this.TxtFullExpalin);
            this.Controls.Add(this.txtShortExplain);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtBuyer);
            this.Controls.Add(this.txtPersianTitle);
            this.Controls.Add(this.txtEngilishTitle);
            this.Controls.Add(this.InputSend);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InputSend;
        private System.Windows.Forms.TextBox txtEngilishTitle;
        private System.Windows.Forms.TextBox txtPersianTitle;
        private System.Windows.Forms.TextBox txtBuyer;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtShortExplain;
        private System.Windows.Forms.TextBox TxtFullExpalin;
        private System.Windows.Forms.TextBox TxtProducter;
        private System.Windows.Forms.Label PersianTitle;
        private System.Windows.Forms.Label EngilishTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
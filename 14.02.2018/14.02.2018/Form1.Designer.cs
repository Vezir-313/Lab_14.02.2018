namespace _14._02._2018
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
            this.tesdiqbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.secilmiwLbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tesdiqbtn
            // 
            this.tesdiqbtn.Location = new System.Drawing.Point(46, 308);
            this.tesdiqbtn.Name = "tesdiqbtn";
            this.tesdiqbtn.Size = new System.Drawing.Size(75, 23);
            this.tesdiqbtn.TabIndex = 0;
            this.tesdiqbtn.Text = "Tesdiqle";
            this.tesdiqbtn.UseVisualStyleBackColor = true;
            this.tesdiqbtn.Click += new System.EventHandler(this.tesdiqbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Onceden Baxiw";
            // 
            // secilmiwLbl
            // 
            this.secilmiwLbl.AutoSize = true;
            this.secilmiwLbl.Location = new System.Drawing.Point(49, 225);
            this.secilmiwLbl.Name = "secilmiwLbl";
            this.secilmiwLbl.Size = new System.Drawing.Size(0, 13);
            this.secilmiwLbl.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(563, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 186);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 370);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.secilmiwLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tesdiqbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tesdiqbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label secilmiwLbl;
        private System.Windows.Forms.ListBox listBox1;
    }
}


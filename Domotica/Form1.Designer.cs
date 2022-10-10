namespace Domotica
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlTv = new System.Windows.Forms.Panel();
            this.textBoxCanale = new System.Windows.Forms.TextBox();
            this.pnlTv.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "get canale";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(371, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 26);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "set canale";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(409, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlTv
            // 
            this.pnlTv.Controls.Add(this.textBoxCanale);
            this.pnlTv.Location = new System.Drawing.Point(25, 44);
            this.pnlTv.Name = "pnlTv";
            this.pnlTv.Size = new System.Drawing.Size(200, 100);
            this.pnlTv.TabIndex = 4;
            // 
            // textBoxCanale
            // 
            this.textBoxCanale.Location = new System.Drawing.Point(57, 42);
            this.textBoxCanale.Name = "textBoxCanale";
            this.textBoxCanale.Size = new System.Drawing.Size(100, 26);
            this.textBoxCanale.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlTv);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlTv.ResumeLayout(false);
            this.pnlTv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlTv;
        private System.Windows.Forms.TextBox textBoxCanale;
    }
}


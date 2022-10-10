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
            this.components = new System.ComponentModel.Container();
            this.btnGetCanale = new System.Windows.Forms.Button();
            this.textBoxCanale = new System.Windows.Forms.TextBox();
            this.btnSetCanale = new System.Windows.Forms.Button();
            this.btnClearCanale = new System.Windows.Forms.Button();
            this.pnlTv = new System.Windows.Forms.Panel();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblCanale = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClearVolume = new System.Windows.Forms.Button();
            this.btnSetVolume = new System.Windows.Forms.Button();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.btnGetVolume = new System.Windows.Forms.Button();
            this.pnlTv.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetCanale
            // 
            this.btnGetCanale.Location = new System.Drawing.Point(940, 219);
            this.btnGetCanale.Name = "btnGetCanale";
            this.btnGetCanale.Size = new System.Drawing.Size(85, 54);
            this.btnGetCanale.TabIndex = 0;
            this.btnGetCanale.Text = "get canale";
            this.btnGetCanale.UseVisualStyleBackColor = true;
            this.btnGetCanale.Click += new System.EventHandler(this.btnGetCanale_Click);
            // 
            // textBoxCanale
            // 
            this.textBoxCanale.Location = new System.Drawing.Point(1031, 233);
            this.textBoxCanale.Name = "textBoxCanale";
            this.textBoxCanale.Size = new System.Drawing.Size(141, 26);
            this.textBoxCanale.TabIndex = 1;
            // 
            // btnSetCanale
            // 
            this.btnSetCanale.Location = new System.Drawing.Point(1178, 219);
            this.btnSetCanale.Name = "btnSetCanale";
            this.btnSetCanale.Size = new System.Drawing.Size(81, 54);
            this.btnSetCanale.TabIndex = 2;
            this.btnSetCanale.Text = "set canale";
            this.btnSetCanale.UseVisualStyleBackColor = true;
            this.btnSetCanale.Click += new System.EventHandler(this.btnSetCanale_Click);
            // 
            // btnClearCanale
            // 
            this.btnClearCanale.Location = new System.Drawing.Point(1061, 173);
            this.btnClearCanale.Name = "btnClearCanale";
            this.btnClearCanale.Size = new System.Drawing.Size(75, 45);
            this.btnClearCanale.TabIndex = 3;
            this.btnClearCanale.Text = "clear";
            this.btnClearCanale.UseVisualStyleBackColor = true;
            this.btnClearCanale.Click += new System.EventHandler(this.btnClearCanale_Click);
            // 
            // pnlTv
            // 
            this.pnlTv.BackgroundImage = global::Domotica.Properties.Resources.TV_icon;
            this.pnlTv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTv.Controls.Add(this.lblVolume);
            this.pnlTv.Controls.Add(this.lblCanale);
            this.pnlTv.Location = new System.Drawing.Point(12, 12);
            this.pnlTv.Name = "pnlTv";
            this.pnlTv.Size = new System.Drawing.Size(868, 610);
            this.pnlTv.TabIndex = 4;
            // 
            // lblVolume
            // 
            this.lblVolume.BackColor = System.Drawing.Color.Transparent;
            this.lblVolume.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVolume.Location = new System.Drawing.Point(56, 247);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(100, 48);
            this.lblVolume.TabIndex = 1;
            this.lblVolume.Text = "0";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCanale
            // 
            this.lblCanale.BackColor = System.Drawing.Color.Transparent;
            this.lblCanale.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCanale.Location = new System.Drawing.Point(714, 247);
            this.lblCanale.Name = "lblCanale";
            this.lblCanale.Size = new System.Drawing.Size(100, 48);
            this.lblCanale.TabIndex = 0;
            this.lblCanale.Text = "0";
            this.lblCanale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClearVolume
            // 
            this.btnClearVolume.Location = new System.Drawing.Point(1061, 306);
            this.btnClearVolume.Name = "btnClearVolume";
            this.btnClearVolume.Size = new System.Drawing.Size(75, 45);
            this.btnClearVolume.TabIndex = 8;
            this.btnClearVolume.Text = "clear";
            this.btnClearVolume.UseVisualStyleBackColor = true;
            this.btnClearVolume.Click += new System.EventHandler(this.btnClearVolume_Click);
            // 
            // btnSetVolume
            // 
            this.btnSetVolume.Location = new System.Drawing.Point(1178, 352);
            this.btnSetVolume.Name = "btnSetVolume";
            this.btnSetVolume.Size = new System.Drawing.Size(81, 54);
            this.btnSetVolume.TabIndex = 7;
            this.btnSetVolume.Text = "set volume";
            this.btnSetVolume.UseVisualStyleBackColor = true;
            this.btnSetVolume.Click += new System.EventHandler(this.btnSetVolume_Click);
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(1031, 366);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(141, 26);
            this.textBoxVolume.TabIndex = 6;
            // 
            // btnGetVolume
            // 
            this.btnGetVolume.Location = new System.Drawing.Point(940, 352);
            this.btnGetVolume.Name = "btnGetVolume";
            this.btnGetVolume.Size = new System.Drawing.Size(85, 54);
            this.btnGetVolume.TabIndex = 5;
            this.btnGetVolume.Text = "get volume";
            this.btnGetVolume.UseVisualStyleBackColor = true;
            this.btnGetVolume.Click += new System.EventHandler(this.btnGetVolume_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 644);
            this.Controls.Add(this.btnClearVolume);
            this.Controls.Add(this.btnSetVolume);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.btnGetVolume);
            this.Controls.Add(this.pnlTv);
            this.Controls.Add(this.btnClearCanale);
            this.Controls.Add(this.btnSetCanale);
            this.Controls.Add(this.textBoxCanale);
            this.Controls.Add(this.btnGetCanale);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlTv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetCanale;
        private System.Windows.Forms.TextBox textBoxCanale;
        private System.Windows.Forms.Button btnSetCanale;
        private System.Windows.Forms.Button btnClearCanale;
        private System.Windows.Forms.Panel pnlTv;
        private System.Windows.Forms.Label lblCanale;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnClearVolume;
        private System.Windows.Forms.Button btnSetVolume;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.Button btnGetVolume;
    }
}


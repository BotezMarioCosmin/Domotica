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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClearVolume = new System.Windows.Forms.Button();
            this.btnSetVolume = new System.Windows.Forms.Button();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.btnGetVolume = new System.Windows.Forms.Button();
            this.pnlTelecomando = new System.Windows.Forms.Panel();
            this.btnMuto = new System.Windows.Forms.Button();
            this.pictureBoxSource = new System.Windows.Forms.PictureBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblCh = new System.Windows.Forms.Label();
            this.btnCanaleGiu = new System.Windows.Forms.Button();
            this.btnCanaleSu = new System.Windows.Forms.Button();
            this.lblVol = new System.Windows.Forms.Label();
            this.btnVolumeGiu = new System.Windows.Forms.Button();
            this.btnVolumeSu = new System.Windows.Forms.Button();
            this.pictureBoxOnOff = new System.Windows.Forms.PictureBox();
            this.pnlTv = new System.Windows.Forms.Panel();
            this.textBoxProduttoreModello = new System.Windows.Forms.TextBox();
            this.pictureBoxVol = new System.Windows.Forms.PictureBox();
            this.pnlTvOff = new System.Windows.Forms.Panel();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblCanale = new System.Windows.Forms.Label();
            this.textBoxCaldaiaFunz = new System.Windows.Forms.TextBox();
            this.pnlTelecomando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOnOff)).BeginInit();
            this.pnlTv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVol)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetCanale
            // 
            this.btnGetCanale.Location = new System.Drawing.Point(886, 42);
            this.btnGetCanale.Name = "btnGetCanale";
            this.btnGetCanale.Size = new System.Drawing.Size(85, 56);
            this.btnGetCanale.TabIndex = 0;
            this.btnGetCanale.Text = "get canale";
            this.btnGetCanale.UseVisualStyleBackColor = true;
            this.btnGetCanale.Click += new System.EventHandler(this.btnGetCanale_Click);
            // 
            // textBoxCanale
            // 
            this.textBoxCanale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCanale.Location = new System.Drawing.Point(977, 47);
            this.textBoxCanale.Name = "textBoxCanale";
            this.textBoxCanale.Size = new System.Drawing.Size(60, 44);
            this.textBoxCanale.TabIndex = 1;
            // 
            // btnSetCanale
            // 
            this.btnSetCanale.Location = new System.Drawing.Point(1043, 42);
            this.btnSetCanale.Name = "btnSetCanale";
            this.btnSetCanale.Size = new System.Drawing.Size(81, 56);
            this.btnSetCanale.TabIndex = 2;
            this.btnSetCanale.Text = "set canale";
            this.btnSetCanale.UseVisualStyleBackColor = true;
            this.btnSetCanale.Click += new System.EventHandler(this.btnSetCanale_Click);
            // 
            // btnClearCanale
            // 
            this.btnClearCanale.Location = new System.Drawing.Point(977, 4);
            this.btnClearCanale.Name = "btnClearCanale";
            this.btnClearCanale.Size = new System.Drawing.Size(60, 37);
            this.btnClearCanale.TabIndex = 3;
            this.btnClearCanale.Text = "clear";
            this.btnClearCanale.UseVisualStyleBackColor = true;
            this.btnClearCanale.Click += new System.EventHandler(this.btnClearCanale_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClearVolume
            // 
            this.btnClearVolume.Location = new System.Drawing.Point(1221, 4);
            this.btnClearVolume.Name = "btnClearVolume";
            this.btnClearVolume.Size = new System.Drawing.Size(60, 37);
            this.btnClearVolume.TabIndex = 8;
            this.btnClearVolume.Text = "clear";
            this.btnClearVolume.UseVisualStyleBackColor = true;
            this.btnClearVolume.Click += new System.EventHandler(this.btnClearVolume_Click);
            // 
            // btnSetVolume
            // 
            this.btnSetVolume.Location = new System.Drawing.Point(1287, 42);
            this.btnSetVolume.Name = "btnSetVolume";
            this.btnSetVolume.Size = new System.Drawing.Size(81, 56);
            this.btnSetVolume.TabIndex = 7;
            this.btnSetVolume.Text = "set volume";
            this.btnSetVolume.UseVisualStyleBackColor = true;
            this.btnSetVolume.Click += new System.EventHandler(this.btnSetVolume_Click);
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVolume.Location = new System.Drawing.Point(1221, 47);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(60, 44);
            this.textBoxVolume.TabIndex = 6;
            // 
            // btnGetVolume
            // 
            this.btnGetVolume.Location = new System.Drawing.Point(1130, 42);
            this.btnGetVolume.Name = "btnGetVolume";
            this.btnGetVolume.Size = new System.Drawing.Size(85, 56);
            this.btnGetVolume.TabIndex = 5;
            this.btnGetVolume.Text = "get volume";
            this.btnGetVolume.UseVisualStyleBackColor = true;
            this.btnGetVolume.Click += new System.EventHandler(this.btnGetVolume_Click);
            // 
            // pnlTelecomando
            // 
            this.pnlTelecomando.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlTelecomando.Controls.Add(this.btnMuto);
            this.pnlTelecomando.Controls.Add(this.pictureBoxSource);
            this.pnlTelecomando.Controls.Add(this.btn0);
            this.pnlTelecomando.Controls.Add(this.btn9);
            this.pnlTelecomando.Controls.Add(this.btn8);
            this.pnlTelecomando.Controls.Add(this.btn7);
            this.pnlTelecomando.Controls.Add(this.btn6);
            this.pnlTelecomando.Controls.Add(this.btn5);
            this.pnlTelecomando.Controls.Add(this.btn4);
            this.pnlTelecomando.Controls.Add(this.btn3);
            this.pnlTelecomando.Controls.Add(this.btn2);
            this.pnlTelecomando.Controls.Add(this.btn1);
            this.pnlTelecomando.Controls.Add(this.lblCh);
            this.pnlTelecomando.Controls.Add(this.btnCanaleGiu);
            this.pnlTelecomando.Controls.Add(this.btnCanaleSu);
            this.pnlTelecomando.Controls.Add(this.lblVol);
            this.pnlTelecomando.Controls.Add(this.btnVolumeGiu);
            this.pnlTelecomando.Controls.Add(this.btnVolumeSu);
            this.pnlTelecomando.Controls.Add(this.pictureBoxOnOff);
            this.pnlTelecomando.Location = new System.Drawing.Point(977, 122);
            this.pnlTelecomando.Name = "pnlTelecomando";
            this.pnlTelecomando.Size = new System.Drawing.Size(303, 500);
            this.pnlTelecomando.TabIndex = 9;
            // 
            // btnMuto
            // 
            this.btnMuto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMuto.BackgroundImage = global::Domotica.Properties.Resources.mute;
            this.btnMuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuto.FlatAppearance.BorderSize = 0;
            this.btnMuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMuto.Location = new System.Drawing.Point(121, 387);
            this.btnMuto.Name = "btnMuto";
            this.btnMuto.Size = new System.Drawing.Size(55, 55);
            this.btnMuto.TabIndex = 19;
            this.btnMuto.UseVisualStyleBackColor = false;
            this.btnMuto.Click += new System.EventHandler(this.btnMuto_Click);
            // 
            // pictureBoxSource
            // 
            this.pictureBoxSource.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxSource.BackgroundImage = global::Domotica.Properties.Resources.source;
            this.pictureBoxSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSource.Location = new System.Drawing.Point(224, 18);
            this.pictureBoxSource.Name = "pictureBoxSource";
            this.pictureBoxSource.Size = new System.Drawing.Size(56, 56);
            this.pictureBoxSource.TabIndex = 18;
            this.pictureBoxSource.TabStop = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.Location = new System.Drawing.Point(121, 313);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(55, 55);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.Location = new System.Drawing.Point(225, 240);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 55);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.Location = new System.Drawing.Point(121, 240);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 55);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.Location = new System.Drawing.Point(23, 240);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 55);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.Location = new System.Drawing.Point(225, 166);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 55);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.Location = new System.Drawing.Point(121, 166);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 55);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.Location = new System.Drawing.Point(23, 166);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 55);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Location = new System.Drawing.Point(225, 96);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 55);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Location = new System.Drawing.Point(121, 96);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 55);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Location = new System.Drawing.Point(23, 96);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 55);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblCh
            // 
            this.lblCh.AutoSize = true;
            this.lblCh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCh.Location = new System.Drawing.Point(232, 330);
            this.lblCh.Name = "lblCh";
            this.lblCh.Size = new System.Drawing.Size(41, 25);
            this.lblCh.TabIndex = 6;
            this.lblCh.Text = "CH";
            // 
            // btnCanaleGiu
            // 
            this.btnCanaleGiu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCanaleGiu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanaleGiu.FlatAppearance.BorderSize = 0;
            this.btnCanaleGiu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanaleGiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanaleGiu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCanaleGiu.Location = new System.Drawing.Point(225, 414);
            this.btnCanaleGiu.Name = "btnCanaleGiu";
            this.btnCanaleGiu.Size = new System.Drawing.Size(55, 55);
            this.btnCanaleGiu.TabIndex = 5;
            this.btnCanaleGiu.Text = "-";
            this.btnCanaleGiu.UseVisualStyleBackColor = false;
            this.btnCanaleGiu.Click += new System.EventHandler(this.btnCanaleGiu_Click);
            // 
            // btnCanaleSu
            // 
            this.btnCanaleSu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCanaleSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanaleSu.FlatAppearance.BorderSize = 0;
            this.btnCanaleSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanaleSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanaleSu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCanaleSu.Location = new System.Drawing.Point(225, 358);
            this.btnCanaleSu.Name = "btnCanaleSu";
            this.btnCanaleSu.Size = new System.Drawing.Size(55, 55);
            this.btnCanaleSu.TabIndex = 4;
            this.btnCanaleSu.Text = "+";
            this.btnCanaleSu.UseVisualStyleBackColor = false;
            this.btnCanaleSu.Click += new System.EventHandler(this.btnCanaleSu_Click);
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVol.Location = new System.Drawing.Point(25, 330);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(53, 25);
            this.lblVol.TabIndex = 3;
            this.lblVol.Text = "VOL";
            // 
            // btnVolumeGiu
            // 
            this.btnVolumeGiu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVolumeGiu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolumeGiu.FlatAppearance.BorderSize = 0;
            this.btnVolumeGiu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolumeGiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolumeGiu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolumeGiu.Location = new System.Drawing.Point(22, 414);
            this.btnVolumeGiu.Name = "btnVolumeGiu";
            this.btnVolumeGiu.Size = new System.Drawing.Size(55, 55);
            this.btnVolumeGiu.TabIndex = 2;
            this.btnVolumeGiu.Text = "-";
            this.btnVolumeGiu.UseVisualStyleBackColor = false;
            this.btnVolumeGiu.Click += new System.EventHandler(this.btnVolumeGiu_Click);
            // 
            // btnVolumeSu
            // 
            this.btnVolumeSu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVolumeSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolumeSu.FlatAppearance.BorderSize = 0;
            this.btnVolumeSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolumeSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolumeSu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolumeSu.Location = new System.Drawing.Point(22, 358);
            this.btnVolumeSu.Name = "btnVolumeSu";
            this.btnVolumeSu.Size = new System.Drawing.Size(55, 55);
            this.btnVolumeSu.TabIndex = 1;
            this.btnVolumeSu.Text = "+";
            this.btnVolumeSu.UseVisualStyleBackColor = false;
            this.btnVolumeSu.Click += new System.EventHandler(this.btnVolumeSu_Click);
            // 
            // pictureBoxOnOff
            // 
            this.pictureBoxOnOff.BackgroundImage = global::Domotica.Properties.Resources.onoff;
            this.pictureBoxOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOnOff.Location = new System.Drawing.Point(23, 18);
            this.pictureBoxOnOff.Name = "pictureBoxOnOff";
            this.pictureBoxOnOff.Size = new System.Drawing.Size(56, 56);
            this.pictureBoxOnOff.TabIndex = 0;
            this.pictureBoxOnOff.TabStop = false;
            this.pictureBoxOnOff.Click += new System.EventHandler(this.pictureBoxOnOff_Click);
            // 
            // pnlTv
            // 
            this.pnlTv.BackgroundImage = global::Domotica.Properties.Resources.TV_icon;
            this.pnlTv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTv.Controls.Add(this.textBoxProduttoreModello);
            this.pnlTv.Controls.Add(this.pictureBoxVol);
            this.pnlTv.Controls.Add(this.pnlTvOff);
            this.pnlTv.Controls.Add(this.lblVolume);
            this.pnlTv.Controls.Add(this.lblCanale);
            this.pnlTv.Location = new System.Drawing.Point(12, 12);
            this.pnlTv.Name = "pnlTv";
            this.pnlTv.Size = new System.Drawing.Size(868, 610);
            this.pnlTv.TabIndex = 4;
            // 
            // textBoxProduttoreModello
            // 
            this.textBoxProduttoreModello.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxProduttoreModello.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProduttoreModello.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProduttoreModello.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxProduttoreModello.Location = new System.Drawing.Point(203, 490);
            this.textBoxProduttoreModello.Name = "textBoxProduttoreModello";
            this.textBoxProduttoreModello.Size = new System.Drawing.Size(459, 30);
            this.textBoxProduttoreModello.TabIndex = 4;
            this.textBoxProduttoreModello.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxVol
            // 
            this.pictureBoxVol.BackColor = System.Drawing.Color.Gray;
            this.pictureBoxVol.BackgroundImage = global::Domotica.Properties.Resources.muteico;
            this.pictureBoxVol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxVol.Location = new System.Drawing.Point(55, 234);
            this.pictureBoxVol.Name = "pictureBoxVol";
            this.pictureBoxVol.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxVol.TabIndex = 3;
            this.pictureBoxVol.TabStop = false;
            // 
            // pnlTvOff
            // 
            this.pnlTvOff.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTvOff.Location = new System.Drawing.Point(35, 35);
            this.pnlTvOff.Name = "pnlTvOff";
            this.pnlTvOff.Size = new System.Drawing.Size(796, 455);
            this.pnlTvOff.TabIndex = 2;
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
            // textBoxCaldaiaFunz
            // 
            this.textBoxCaldaiaFunz.Location = new System.Drawing.Point(887, 480);
            this.textBoxCaldaiaFunz.Name = "textBoxCaldaiaFunz";
            this.textBoxCaldaiaFunz.Size = new System.Drawing.Size(100, 26);
            this.textBoxCaldaiaFunz.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1378, 644);
            this.Controls.Add(this.textBoxCaldaiaFunz);
            this.Controls.Add(this.pnlTelecomando);
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
            this.pnlTelecomando.ResumeLayout(false);
            this.pnlTelecomando.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOnOff)).EndInit();
            this.pnlTv.ResumeLayout(false);
            this.pnlTv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVol)).EndInit();
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
        private System.Windows.Forms.Panel pnlTelecomando;
        private System.Windows.Forms.PictureBox pictureBoxOnOff;
        private System.Windows.Forms.Panel pnlTvOff;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.Button btnVolumeGiu;
        private System.Windows.Forms.Button btnVolumeSu;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblCh;
        private System.Windows.Forms.Button btnCanaleGiu;
        private System.Windows.Forms.Button btnCanaleSu;
        private System.Windows.Forms.PictureBox pictureBoxSource;
        private System.Windows.Forms.Button btnMuto;
        private System.Windows.Forms.PictureBox pictureBoxVol;
        private System.Windows.Forms.TextBox textBoxProduttoreModello;
        private System.Windows.Forms.TextBox textBoxCaldaiaFunz;
    }
}


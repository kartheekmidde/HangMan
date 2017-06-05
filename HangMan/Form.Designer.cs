namespace HangMan
{
    partial class frmHangman
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
            this.hangImage = new System.Windows.Forms.PictureBox();
            this.cmdA = new System.Windows.Forms.Button();
            this.cmdB = new System.Windows.Forms.Button();
            this.cmdC = new System.Windows.Forms.Button();
            this.cmdD = new System.Windows.Forms.Button();
            this.cmdK = new System.Windows.Forms.Button();
            this.cmdE = new System.Windows.Forms.Button();
            this.cmdJ = new System.Windows.Forms.Button();
            this.cmdI = new System.Windows.Forms.Button();
            this.cmdH = new System.Windows.Forms.Button();
            this.cmdF = new System.Windows.Forms.Button();
            this.cmdL = new System.Windows.Forms.Button();
            this.cmdO = new System.Windows.Forms.Button();
            this.cmdG = new System.Windows.Forms.Button();
            this.cmdS = new System.Windows.Forms.Button();
            this.cmdN = new System.Windows.Forms.Button();
            this.cmdM = new System.Windows.Forms.Button();
            this.cmdR = new System.Windows.Forms.Button();
            this.cmdU = new System.Windows.Forms.Button();
            this.cmdQ = new System.Windows.Forms.Button();
            this.cmdP = new System.Windows.Forms.Button();
            this.cmdT = new System.Windows.Forms.Button();
            this.cmdW = new System.Windows.Forms.Button();
            this.cmdX = new System.Windows.Forms.Button();
            this.cmdY = new System.Windows.Forms.Button();
            this.cmdZ = new System.Windows.Forms.Button();
            this.cmdV = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.lblShowWord = new System.Windows.Forms.Label();
            this.bt_G_Restart = new System.Windows.Forms.Button();
            this.bt_G_Home = new System.Windows.Forms.Button();
            this.bt_E = new System.Windows.Forms.Button();
            this.bt_NE = new System.Windows.Forms.Button();
            this.bt_E_Med = new System.Windows.Forms.Button();
            this.bt_E_Easy = new System.Windows.Forms.Button();
            this.bt_E_Diff = new System.Windows.Forms.Button();
            this.bt_NE_Diff = new System.Windows.Forms.Button();
            this.bt_NE_Med = new System.Windows.Forms.Button();
            this.bt_NE_Easy = new System.Windows.Forms.Button();
            this.hint = new System.Windows.Forms.Label();
            this.btMusic = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).BeginInit();
            this.SuspendLayout();
            // 
            // hangImage
            // 
            this.hangImage.BackColor = System.Drawing.Color.Transparent;
            this.hangImage.Location = new System.Drawing.Point(157, 244);
            this.hangImage.Name = "hangImage";
            this.hangImage.Size = new System.Drawing.Size(135, 116);
            this.hangImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hangImage.TabIndex = 0;
            this.hangImage.TabStop = false;
            // 
            // cmdA
            // 
            this.cmdA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdA.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdA.Location = new System.Drawing.Point(171, 388);
            this.cmdA.Name = "cmdA";
            this.cmdA.Size = new System.Drawing.Size(25, 25);
            this.cmdA.TabIndex = 1;
            this.cmdA.Text = "A";
            this.cmdA.UseVisualStyleBackColor = false;
            this.cmdA.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdB
            // 
            this.cmdB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdB.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdB.Location = new System.Drawing.Point(195, 388);
            this.cmdB.Name = "cmdB";
            this.cmdB.Size = new System.Drawing.Size(25, 25);
            this.cmdB.TabIndex = 2;
            this.cmdB.Text = "B";
            this.cmdB.UseVisualStyleBackColor = false;
            this.cmdB.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdC
            // 
            this.cmdC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdC.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdC.Location = new System.Drawing.Point(219, 388);
            this.cmdC.Name = "cmdC";
            this.cmdC.Size = new System.Drawing.Size(25, 25);
            this.cmdC.TabIndex = 3;
            this.cmdC.Text = "C";
            this.cmdC.UseVisualStyleBackColor = false;
            this.cmdC.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdD
            // 
            this.cmdD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdD.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdD.Location = new System.Drawing.Point(243, 388);
            this.cmdD.Name = "cmdD";
            this.cmdD.Size = new System.Drawing.Size(25, 25);
            this.cmdD.TabIndex = 4;
            this.cmdD.Text = "D";
            this.cmdD.UseVisualStyleBackColor = false;
            this.cmdD.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdK
            // 
            this.cmdK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdK.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdK.Location = new System.Drawing.Point(195, 419);
            this.cmdK.Name = "cmdK";
            this.cmdK.Size = new System.Drawing.Size(25, 25);
            this.cmdK.TabIndex = 5;
            this.cmdK.Text = "K";
            this.cmdK.UseVisualStyleBackColor = false;
            this.cmdK.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdE
            // 
            this.cmdE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdE.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdE.Location = new System.Drawing.Point(267, 388);
            this.cmdE.Name = "cmdE";
            this.cmdE.Size = new System.Drawing.Size(25, 25);
            this.cmdE.TabIndex = 6;
            this.cmdE.Text = "E";
            this.cmdE.UseVisualStyleBackColor = false;
            this.cmdE.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdJ
            // 
            this.cmdJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdJ.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdJ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdJ.Location = new System.Drawing.Point(171, 419);
            this.cmdJ.Name = "cmdJ";
            this.cmdJ.Size = new System.Drawing.Size(25, 25);
            this.cmdJ.TabIndex = 7;
            this.cmdJ.Text = "J";
            this.cmdJ.UseVisualStyleBackColor = false;
            this.cmdJ.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdI
            // 
            this.cmdI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdI.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdI.Location = new System.Drawing.Point(361, 388);
            this.cmdI.Name = "cmdI";
            this.cmdI.Size = new System.Drawing.Size(25, 25);
            this.cmdI.TabIndex = 8;
            this.cmdI.Text = "I";
            this.cmdI.UseVisualStyleBackColor = false;
            this.cmdI.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdH
            // 
            this.cmdH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdH.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdH.Location = new System.Drawing.Point(338, 388);
            this.cmdH.Name = "cmdH";
            this.cmdH.Size = new System.Drawing.Size(25, 25);
            this.cmdH.TabIndex = 9;
            this.cmdH.Text = "H";
            this.cmdH.UseVisualStyleBackColor = false;
            this.cmdH.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdF
            // 
            this.cmdF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdF.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdF.Location = new System.Drawing.Point(291, 388);
            this.cmdF.Name = "cmdF";
            this.cmdF.Size = new System.Drawing.Size(25, 25);
            this.cmdF.TabIndex = 10;
            this.cmdF.Text = "F";
            this.cmdF.UseVisualStyleBackColor = false;
            this.cmdF.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdL
            // 
            this.cmdL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdL.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdL.Location = new System.Drawing.Point(219, 419);
            this.cmdL.Name = "cmdL";
            this.cmdL.Size = new System.Drawing.Size(25, 25);
            this.cmdL.TabIndex = 11;
            this.cmdL.Text = "L";
            this.cmdL.UseVisualStyleBackColor = false;
            this.cmdL.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdO
            // 
            this.cmdO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdO.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdO.Location = new System.Drawing.Point(291, 419);
            this.cmdO.Name = "cmdO";
            this.cmdO.Size = new System.Drawing.Size(25, 25);
            this.cmdO.TabIndex = 12;
            this.cmdO.Text = "O";
            this.cmdO.UseVisualStyleBackColor = false;
            this.cmdO.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdG
            // 
            this.cmdG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdG.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdG.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdG.Location = new System.Drawing.Point(315, 388);
            this.cmdG.Name = "cmdG";
            this.cmdG.Size = new System.Drawing.Size(25, 25);
            this.cmdG.TabIndex = 13;
            this.cmdG.Text = "G";
            this.cmdG.UseVisualStyleBackColor = false;
            this.cmdG.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdS
            // 
            this.cmdS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdS.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdS.Location = new System.Drawing.Point(173, 450);
            this.cmdS.Name = "cmdS";
            this.cmdS.Size = new System.Drawing.Size(25, 25);
            this.cmdS.TabIndex = 14;
            this.cmdS.Text = "S";
            this.cmdS.UseVisualStyleBackColor = false;
            this.cmdS.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdN
            // 
            this.cmdN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdN.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdN.Location = new System.Drawing.Point(267, 419);
            this.cmdN.Name = "cmdN";
            this.cmdN.Size = new System.Drawing.Size(25, 25);
            this.cmdN.TabIndex = 15;
            this.cmdN.Text = "N";
            this.cmdN.UseVisualStyleBackColor = false;
            this.cmdN.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdM
            // 
            this.cmdM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdM.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdM.Location = new System.Drawing.Point(243, 419);
            this.cmdM.Name = "cmdM";
            this.cmdM.Size = new System.Drawing.Size(25, 25);
            this.cmdM.TabIndex = 16;
            this.cmdM.Text = "M";
            this.cmdM.UseVisualStyleBackColor = false;
            this.cmdM.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdR
            // 
            this.cmdR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdR.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdR.Location = new System.Drawing.Point(363, 419);
            this.cmdR.Name = "cmdR";
            this.cmdR.Size = new System.Drawing.Size(25, 25);
            this.cmdR.TabIndex = 17;
            this.cmdR.Text = "R";
            this.cmdR.UseVisualStyleBackColor = false;
            this.cmdR.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdU
            // 
            this.cmdU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdU.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdU.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdU.Location = new System.Drawing.Point(221, 450);
            this.cmdU.Name = "cmdU";
            this.cmdU.Size = new System.Drawing.Size(25, 25);
            this.cmdU.TabIndex = 18;
            this.cmdU.Text = "U";
            this.cmdU.UseVisualStyleBackColor = false;
            this.cmdU.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdQ
            // 
            this.cmdQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdQ.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdQ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdQ.Location = new System.Drawing.Point(339, 419);
            this.cmdQ.Name = "cmdQ";
            this.cmdQ.Size = new System.Drawing.Size(25, 25);
            this.cmdQ.TabIndex = 19;
            this.cmdQ.Text = "Q";
            this.cmdQ.UseVisualStyleBackColor = false;
            this.cmdQ.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdP
            // 
            this.cmdP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdP.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdP.Location = new System.Drawing.Point(315, 419);
            this.cmdP.Name = "cmdP";
            this.cmdP.Size = new System.Drawing.Size(25, 25);
            this.cmdP.TabIndex = 20;
            this.cmdP.Text = "P";
            this.cmdP.UseVisualStyleBackColor = false;
            this.cmdP.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdT
            // 
            this.cmdT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdT.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdT.Location = new System.Drawing.Point(197, 450);
            this.cmdT.Name = "cmdT";
            this.cmdT.Size = new System.Drawing.Size(25, 25);
            this.cmdT.TabIndex = 21;
            this.cmdT.Text = "T";
            this.cmdT.UseVisualStyleBackColor = false;
            this.cmdT.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdW
            // 
            this.cmdW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdW.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdW.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdW.Location = new System.Drawing.Point(268, 450);
            this.cmdW.Name = "cmdW";
            this.cmdW.Size = new System.Drawing.Size(25, 25);
            this.cmdW.TabIndex = 26;
            this.cmdW.Text = "W";
            this.cmdW.UseVisualStyleBackColor = false;
            this.cmdW.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdX
            // 
            this.cmdX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdX.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdX.Location = new System.Drawing.Point(292, 450);
            this.cmdX.Name = "cmdX";
            this.cmdX.Size = new System.Drawing.Size(25, 25);
            this.cmdX.TabIndex = 25;
            this.cmdX.Text = "X";
            this.cmdX.UseVisualStyleBackColor = false;
            this.cmdX.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdY
            // 
            this.cmdY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdY.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdY.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdY.Location = new System.Drawing.Point(316, 450);
            this.cmdY.Name = "cmdY";
            this.cmdY.Size = new System.Drawing.Size(25, 25);
            this.cmdY.TabIndex = 24;
            this.cmdY.Text = "Y";
            this.cmdY.UseVisualStyleBackColor = false;
            this.cmdY.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdZ
            // 
            this.cmdZ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdZ.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdZ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdZ.Location = new System.Drawing.Point(340, 450);
            this.cmdZ.Name = "cmdZ";
            this.cmdZ.Size = new System.Drawing.Size(25, 25);
            this.cmdZ.TabIndex = 23;
            this.cmdZ.Text = "Z";
            this.cmdZ.UseVisualStyleBackColor = false;
            this.cmdZ.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdV
            // 
            this.cmdV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.cmdV.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdV.Location = new System.Drawing.Point(245, 450);
            this.cmdV.Name = "cmdV";
            this.cmdV.Size = new System.Drawing.Size(25, 25);
            this.cmdV.TabIndex = 22;
            this.cmdV.Text = "V";
            this.cmdV.UseVisualStyleBackColor = false;
            this.cmdV.Click += new System.EventHandler(this.guessClick);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.Color.Transparent;
            this.labelResult.Font = new System.Drawing.Font("Chiller", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.Color.Red;
            this.labelResult.Location = new System.Drawing.Point(402, 75);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 56);
            this.labelResult.TabIndex = 27;
            // 
            // lblShowWord
            // 
            this.lblShowWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.lblShowWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShowWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblShowWord.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowWord.Location = new System.Drawing.Point(363, 205);
            this.lblShowWord.Name = "lblShowWord";
            this.lblShowWord.Size = new System.Drawing.Size(205, 32);
            this.lblShowWord.TabIndex = 28;
            this.lblShowWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_G_Restart
            // 
            this.bt_G_Restart.CausesValidation = false;
            this.bt_G_Restart.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bt_G_Restart.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_G_Restart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_G_Restart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_G_Restart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_G_Restart.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_G_Restart.Location = new System.Drawing.Point(437, 9);
            this.bt_G_Restart.Name = "bt_G_Restart";
            this.bt_G_Restart.Size = new System.Drawing.Size(100, 30);
            this.bt_G_Restart.TabIndex = 29;
            this.bt_G_Restart.Text = "Restart";
            this.bt_G_Restart.UseVisualStyleBackColor = true;
            this.bt_G_Restart.Click += new System.EventHandler(this.restart_click);
            // 
            // bt_G_Home
            // 
            this.bt_G_Home.CausesValidation = false;
            this.bt_G_Home.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bt_G_Home.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_G_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_G_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_G_Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_G_Home.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_G_Home.Location = new System.Drawing.Point(12, 12);
            this.bt_G_Home.Name = "bt_G_Home";
            this.bt_G_Home.Size = new System.Drawing.Size(100, 30);
            this.bt_G_Home.TabIndex = 30;
            this.bt_G_Home.Text = "Home";
            this.bt_G_Home.UseVisualStyleBackColor = true;
            this.bt_G_Home.Click += new System.EventHandler(this.bt_G_Home_Click);
            // 
            // bt_E
            // 
            this.bt_E.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_E.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_E.Location = new System.Drawing.Point(243, 48);
            this.bt_E.Name = "bt_E";
            this.bt_E.Size = new System.Drawing.Size(114, 32);
            this.bt_E.TabIndex = 31;
            this.bt_E.Text = "English";
            this.bt_E.UseVisualStyleBackColor = true;
            this.bt_E.Click += new System.EventHandler(this.bt_E_Click);
            // 
            // bt_NE
            // 
            this.bt_NE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_NE.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NE.Location = new System.Drawing.Point(243, 85);
            this.bt_NE.Name = "bt_NE";
            this.bt_NE.Size = new System.Drawing.Size(114, 32);
            this.bt_NE.TabIndex = 32;
            this.bt_NE.Text = "Non English";
            this.bt_NE.UseVisualStyleBackColor = true;
            this.bt_NE.Click += new System.EventHandler(this.bt_NE_Click);
            // 
            // bt_E_Med
            // 
            this.bt_E_Med.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_E_Med.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_E_Med.Location = new System.Drawing.Point(242, 166);
            this.bt_E_Med.Name = "bt_E_Med";
            this.bt_E_Med.Size = new System.Drawing.Size(114, 32);
            this.bt_E_Med.TabIndex = 35;
            this.bt_E_Med.Text = "Medium";
            this.bt_E_Med.UseVisualStyleBackColor = true;
            this.bt_E_Med.Click += new System.EventHandler(this.bt_E_Med_Click);
            // 
            // bt_E_Easy
            // 
            this.bt_E_Easy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_E_Easy.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_E_Easy.Location = new System.Drawing.Point(242, 128);
            this.bt_E_Easy.Name = "bt_E_Easy";
            this.bt_E_Easy.Size = new System.Drawing.Size(114, 32);
            this.bt_E_Easy.TabIndex = 34;
            this.bt_E_Easy.Text = "Easy";
            this.bt_E_Easy.UseVisualStyleBackColor = true;
            this.bt_E_Easy.Click += new System.EventHandler(this.bt_E_Easy_Click);
            // 
            // bt_E_Diff
            // 
            this.bt_E_Diff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_E_Diff.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_E_Diff.Location = new System.Drawing.Point(242, 205);
            this.bt_E_Diff.Name = "bt_E_Diff";
            this.bt_E_Diff.Size = new System.Drawing.Size(114, 32);
            this.bt_E_Diff.TabIndex = 36;
            this.bt_E_Diff.Text = "Difficult";
            this.bt_E_Diff.UseVisualStyleBackColor = true;
            this.bt_E_Diff.Click += new System.EventHandler(this.bt_E_Diff_Click);
            // 
            // bt_NE_Diff
            // 
            this.bt_NE_Diff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_NE_Diff.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NE_Diff.Location = new System.Drawing.Point(242, 205);
            this.bt_NE_Diff.Name = "bt_NE_Diff";
            this.bt_NE_Diff.Size = new System.Drawing.Size(114, 32);
            this.bt_NE_Diff.TabIndex = 40;
            this.bt_NE_Diff.Text = "Difficult";
            this.bt_NE_Diff.UseVisualStyleBackColor = true;
            this.bt_NE_Diff.Click += new System.EventHandler(this.bt_NE_Diff_Click);
            // 
            // bt_NE_Med
            // 
            this.bt_NE_Med.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_NE_Med.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NE_Med.Location = new System.Drawing.Point(242, 166);
            this.bt_NE_Med.Name = "bt_NE_Med";
            this.bt_NE_Med.Size = new System.Drawing.Size(114, 32);
            this.bt_NE_Med.TabIndex = 39;
            this.bt_NE_Med.Text = "Medium";
            this.bt_NE_Med.UseVisualStyleBackColor = true;
            this.bt_NE_Med.Click += new System.EventHandler(this.bt_NE_Med_Click);
            // 
            // bt_NE_Easy
            // 
            this.bt_NE_Easy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_NE_Easy.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NE_Easy.Location = new System.Drawing.Point(242, 128);
            this.bt_NE_Easy.Name = "bt_NE_Easy";
            this.bt_NE_Easy.Size = new System.Drawing.Size(114, 32);
            this.bt_NE_Easy.TabIndex = 38;
            this.bt_NE_Easy.Text = "Easy";
            this.bt_NE_Easy.UseVisualStyleBackColor = true;
            this.bt_NE_Easy.Click += new System.EventHandler(this.bt_NE_Easy_Click);
            // 
            // hint
            // 
            this.hint.AutoSize = true;
            this.hint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint.Location = new System.Drawing.Point(357, 179);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(0, 19);
            this.hint.TabIndex = 41;
            // 
            // btMusic
            // 
            this.btMusic.BackColor = System.Drawing.Color.Transparent;
            this.btMusic.FlatAppearance.BorderSize = 0;
            this.btMusic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMusic.Location = new System.Drawing.Point(543, -8);
            this.btMusic.Name = "btMusic";
            this.btMusic.Size = new System.Drawing.Size(40, 47);
            this.btMusic.TabIndex = 42;
            this.btMusic.Text = "🔊";
            this.btMusic.UseVisualStyleBackColor = false;
            this.btMusic.Click += new System.EventHandler(this.btMusic_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(367, 244);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer.TabIndex = 43;
            // 
            // frmHangman
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(41)))));
            this.BackgroundImage = global::HangMan.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 489);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btMusic);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.bt_NE_Diff);
            this.Controls.Add(this.bt_NE_Med);
            this.Controls.Add(this.bt_NE_Easy);
            this.Controls.Add(this.bt_E_Diff);
            this.Controls.Add(this.bt_E_Med);
            this.Controls.Add(this.bt_E_Easy);
            this.Controls.Add(this.bt_NE);
            this.Controls.Add(this.bt_E);
            this.Controls.Add(this.bt_G_Home);
            this.Controls.Add(this.bt_G_Restart);
            this.Controls.Add(this.lblShowWord);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.cmdW);
            this.Controls.Add(this.cmdX);
            this.Controls.Add(this.cmdY);
            this.Controls.Add(this.cmdZ);
            this.Controls.Add(this.cmdV);
            this.Controls.Add(this.cmdT);
            this.Controls.Add(this.cmdP);
            this.Controls.Add(this.cmdQ);
            this.Controls.Add(this.cmdU);
            this.Controls.Add(this.cmdR);
            this.Controls.Add(this.cmdM);
            this.Controls.Add(this.cmdN);
            this.Controls.Add(this.cmdS);
            this.Controls.Add(this.cmdG);
            this.Controls.Add(this.cmdO);
            this.Controls.Add(this.cmdL);
            this.Controls.Add(this.cmdF);
            this.Controls.Add(this.cmdH);
            this.Controls.Add(this.cmdI);
            this.Controls.Add(this.cmdJ);
            this.Controls.Add(this.cmdE);
            this.Controls.Add(this.cmdK);
            this.Controls.Add(this.cmdD);
            this.Controls.Add(this.cmdC);
            this.Controls.Add(this.cmdB);
            this.Controls.Add(this.cmdA);
            this.Controls.Add(this.hangImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHangman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.frmHangman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hangImage;
        private System.Windows.Forms.Button cmdA;
        private System.Windows.Forms.Button cmdB;
        private System.Windows.Forms.Button cmdC;
        private System.Windows.Forms.Button cmdD;
        private System.Windows.Forms.Button cmdK;
        private System.Windows.Forms.Button cmdE;
        private System.Windows.Forms.Button cmdJ;
        private System.Windows.Forms.Button cmdI;
        private System.Windows.Forms.Button cmdH;
        private System.Windows.Forms.Button cmdF;
        private System.Windows.Forms.Button cmdL;
        private System.Windows.Forms.Button cmdO;
        private System.Windows.Forms.Button cmdG;
        private System.Windows.Forms.Button cmdS;
        private System.Windows.Forms.Button cmdN;
        private System.Windows.Forms.Button cmdM;
        private System.Windows.Forms.Button cmdR;
        private System.Windows.Forms.Button cmdU;
        private System.Windows.Forms.Button cmdQ;
        private System.Windows.Forms.Button cmdP;
        private System.Windows.Forms.Button cmdT;
        private System.Windows.Forms.Button cmdW;
        private System.Windows.Forms.Button cmdX;
        private System.Windows.Forms.Button cmdY;
        private System.Windows.Forms.Button cmdZ;
        private System.Windows.Forms.Button cmdV;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label lblShowWord;
        private System.Windows.Forms.Button bt_G_Restart;
        private System.Windows.Forms.Button bt_G_Home;
        private System.Windows.Forms.Button bt_E;
        private System.Windows.Forms.Button bt_NE;
        private System.Windows.Forms.Button bt_E_Med;
        private System.Windows.Forms.Button bt_E_Easy;
        private System.Windows.Forms.Button bt_E_Diff;
        private System.Windows.Forms.Button bt_NE_Diff;
        private System.Windows.Forms.Button bt_NE_Med;
        private System.Windows.Forms.Button bt_NE_Easy;
        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.Button btMusic;
        private System.Windows.Forms.Label lblAnswer;
    }
}


namespace CarpetAss1
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
            this.cbxInstall = new System.Windows.Forms.CheckBox();
            this.cbxUnderlay = new System.Windows.Forms.CheckBox();
            this.cbxCarpet = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheap = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLux = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numRoomWidth = new System.Windows.Forms.NumericUpDown();
            this.numRoomLength = new System.Windows.Forms.NumericUpDown();
            this.numUnderlayCost = new System.Windows.Forms.NumericUpDown();
            this.numInstallCost = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCarpetCost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbxCarpetImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblRoomCost = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnderlayCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInstallCost)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarpetImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxInstall
            // 
            this.cbxInstall.AutoSize = true;
            this.cbxInstall.Location = new System.Drawing.Point(25, 21);
            this.cbxInstall.Margin = new System.Windows.Forms.Padding(2);
            this.cbxInstall.Name = "cbxInstall";
            this.cbxInstall.Size = new System.Drawing.Size(198, 17);
            this.cbxInstall.TabIndex = 0;
            this.cbxInstall.Text = "Do you want us to install the carpet?";
            this.cbxInstall.UseVisualStyleBackColor = true;
            this.cbxInstall.CheckedChanged += new System.EventHandler(this.cbxAllBoxes_CheckedChanged);
            // 
            // cbxUnderlay
            // 
            this.cbxUnderlay.AutoSize = true;
            this.cbxUnderlay.Location = new System.Drawing.Point(25, 42);
            this.cbxUnderlay.Margin = new System.Windows.Forms.Padding(2);
            this.cbxUnderlay.Name = "cbxUnderlay";
            this.cbxUnderlay.Size = new System.Drawing.Size(208, 17);
            this.cbxUnderlay.TabIndex = 1;
            this.cbxUnderlay.Text = "Do you want Underlay for your carpet?";
            this.cbxUnderlay.UseVisualStyleBackColor = true;
            this.cbxUnderlay.CheckedChanged += new System.EventHandler(this.cbxAllBoxes_CheckedChanged);
            // 
            // cbxCarpet
            // 
            this.cbxCarpet.AutoSize = true;
            this.cbxCarpet.Location = new System.Drawing.Point(25, 60);
            this.cbxCarpet.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCarpet.Name = "cbxCarpet";
            this.cbxCarpet.Size = new System.Drawing.Size(125, 17);
            this.cbxCarpet.TabIndex = 2;
            this.cbxCarpet.Text = "Do you want carpet?";
            this.cbxCarpet.UseVisualStyleBackColor = true;
            this.cbxCarpet.CheckedChanged += new System.EventHandler(this.cbxAllBoxes_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxUnderlay);
            this.groupBox1.Controls.Add(this.cbxCarpet);
            this.groupBox1.Controls.Add(this.cbxInstall);
            this.groupBox1.Location = new System.Drawing.Point(174, 195);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(245, 108);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carpet Options";
            // 
            // btnCheap
            // 
            this.btnCheap.Location = new System.Drawing.Point(3, 3);
            this.btnCheap.Name = "btnCheap";
            this.btnCheap.Size = new System.Drawing.Size(114, 38);
            this.btnCheap.TabIndex = 4;
            this.btnCheap.Tag = "15";
            this.btnCheap.Text = "Cheap ";
            this.btnCheap.UseVisualStyleBackColor = true;
            this.btnCheap.Click += new System.EventHandler(this.btnCheap_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(3, 47);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(114, 38);
            this.btnHome.TabIndex = 5;
            this.btnHome.Tag = "20";
            this.btnHome.Text = "Home ";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLux
            // 
            this.btnLux.Location = new System.Drawing.Point(3, 91);
            this.btnLux.Name = "btnLux";
            this.btnLux.Size = new System.Drawing.Size(114, 38);
            this.btnLux.TabIndex = 6;
            this.btnLux.Tag = "40";
            this.btnLux.Text = "Luxurious ";
            this.btnLux.UseVisualStyleBackColor = true;
            this.btnLux.Click += new System.EventHandler(this.btnLux_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCheap);
            this.flowLayoutPanel1.Controls.Add(this.btnHome);
            this.flowLayoutPanel1.Controls.Add(this.btnLux);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 195);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(123, 140);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Room Width Meters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Room Length Meters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Installation Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Underlay Cost";
            // 
            // numRoomWidth
            // 
            this.numRoomWidth.Location = new System.Drawing.Point(136, 28);
            this.numRoomWidth.Name = "numRoomWidth";
            this.numRoomWidth.Size = new System.Drawing.Size(70, 20);
            this.numRoomWidth.TabIndex = 9;
            this.numRoomWidth.ValueChanged += new System.EventHandler(this.AllUpDown_ValueChanged);
            // 
            // numRoomLength
            // 
            this.numRoomLength.Location = new System.Drawing.Point(354, 28);
            this.numRoomLength.Name = "numRoomLength";
            this.numRoomLength.Size = new System.Drawing.Size(70, 20);
            this.numRoomLength.TabIndex = 14;
            this.numRoomLength.ValueChanged += new System.EventHandler(this.AllUpDown_ValueChanged);
            // 
            // numUnderlayCost
            // 
            this.numUnderlayCost.Location = new System.Drawing.Point(114, 28);
            this.numUnderlayCost.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUnderlayCost.Name = "numUnderlayCost";
            this.numUnderlayCost.Size = new System.Drawing.Size(70, 20);
            this.numUnderlayCost.TabIndex = 15;
            this.numUnderlayCost.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // numInstallCost
            // 
            this.numInstallCost.Location = new System.Drawing.Point(114, 51);
            this.numInstallCost.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numInstallCost.Name = "numInstallCost";
            this.numInstallCost.Size = new System.Drawing.Size(70, 20);
            this.numInstallCost.TabIndex = 16;
            this.numInstallCost.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCarpetCost);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numUnderlayCost);
            this.panel1.Controls.Add(this.numInstallCost);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(460, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 82);
            this.panel1.TabIndex = 17;
            // 
            // lblCarpetCost
            // 
            this.lblCarpetCost.AutoSize = true;
            this.lblCarpetCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarpetCost.ForeColor = System.Drawing.Color.Red;
            this.lblCarpetCost.Location = new System.Drawing.Point(111, 4);
            this.lblCarpetCost.Name = "lblCarpetCost";
            this.lblCarpetCost.Size = new System.Drawing.Size(14, 13);
            this.lblCarpetCost.TabIndex = 18;
            this.lblCarpetCost.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Carpet Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(49, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Wholesale Carpets";
            // 
            // pbxCarpetImage
            // 
            this.pbxCarpetImage.Location = new System.Drawing.Point(32, 342);
            this.pbxCarpetImage.Name = "pbxCarpetImage";
            this.pbxCarpetImage.Size = new System.Drawing.Size(340, 75);
            this.pbxCarpetImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCarpetImage.TabIndex = 19;
            this.pbxCarpetImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Room Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total Cost";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalCost);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblRoomCost);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(507, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 62);
            this.panel2.TabIndex = 22;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.Red;
            this.lblTotalCost.Location = new System.Drawing.Point(83, 37);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(14, 13);
            this.lblTotalCost.TabIndex = 24;
            this.lblTotalCost.Text = "0";
            // 
            // lblRoomCost
            // 
            this.lblRoomCost.AutoSize = true;
            this.lblRoomCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomCost.ForeColor = System.Drawing.Color.Red;
            this.lblRoomCost.Location = new System.Drawing.Point(83, 11);
            this.lblRoomCost.Name = "lblRoomCost";
            this.lblRoomCost.Size = new System.Drawing.Size(14, 13);
            this.lblRoomCost.TabIndex = 23;
            this.lblRoomCost.Text = "0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.numRoomWidth);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.numRoomLength);
            this.panel3.Location = new System.Drawing.Point(29, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 66);
            this.panel3.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(533, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Enter your room dimensions first, then choose from the 3 carpet types and the Car" +
    "pet options";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "1 Choose your carpet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(171, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "2 Choose your options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 440);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbxCarpetImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRoomWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnderlayCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInstallCost)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarpetImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxInstall;
        private System.Windows.Forms.CheckBox cbxUnderlay;
        private System.Windows.Forms.CheckBox cbxCarpet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheap;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLux;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numRoomWidth;
        private System.Windows.Forms.NumericUpDown numRoomLength;
        private System.Windows.Forms.NumericUpDown numUnderlayCost;
        private System.Windows.Forms.NumericUpDown numInstallCost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbxCarpetImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCarpetCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRoomCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}


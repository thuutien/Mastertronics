namespace Master2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnQuickTest = new System.Windows.Forms.Button();
            this.btnSysprep = new System.Windows.Forms.Button();
            this.btnReactivate = new System.Windows.Forms.Button();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblActivation = new System.Windows.Forms.Label();
            this.picDetails = new System.Windows.Forms.PictureBox();
            this.picSerial = new System.Windows.Forms.PictureBox();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPC = new System.Windows.Forms.Button();
            this.btnLaptop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.picDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSerial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuickTest
            // 
            this.btnQuickTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuickTest.Location = new System.Drawing.Point(30, 27);
            this.btnQuickTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuickTest.Name = "btnQuickTest";
            this.btnQuickTest.Size = new System.Drawing.Size(148, 55);
            this.btnQuickTest.TabIndex = 2;
            this.btnQuickTest.Text = "Quick Test!";
            this.btnQuickTest.UseVisualStyleBackColor = true;
            this.btnQuickTest.Click += new System.EventHandler(this.btnQuickTest_Click);
            // 
            // btnSysprep
            // 
            this.btnSysprep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSysprep.Location = new System.Drawing.Point(396, 27);
            this.btnSysprep.Margin = new System.Windows.Forms.Padding(4);
            this.btnSysprep.Name = "btnSysprep";
            this.btnSysprep.Size = new System.Drawing.Size(148, 55);
            this.btnSysprep.TabIndex = 3;
            this.btnSysprep.Text = "Sysprep";
            this.btnSysprep.UseVisualStyleBackColor = true;
            this.btnSysprep.Click += new System.EventHandler(this.btnSysprep_Click);
            // 
            // btnReactivate
            // 
            this.btnReactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReactivate.ForeColor = System.Drawing.Color.Firebrick;
            this.btnReactivate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReactivate.Location = new System.Drawing.Point(563, 27);
            this.btnReactivate.Margin = new System.Windows.Forms.Padding(4);
            this.btnReactivate.Name = "btnReactivate";
            this.btnReactivate.Size = new System.Drawing.Size(148, 55);
            this.btnReactivate.TabIndex = 4;
            this.btnReactivate.Text = "Re-Activate";
            this.btnReactivate.UseVisualStyleBackColor = true;
            this.btnReactivate.Click += new System.EventHandler(this.btnReactivate_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(30, 98);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(997, 315);
            this.txtDetails.TabIndex = 17;
            // 
            // lblActivation
            // 
            this.lblActivation.AutoSize = true;
            this.lblActivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivation.Location = new System.Drawing.Point(729, 44);
            this.lblActivation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivation.Name = "lblActivation";
            this.lblActivation.Size = new System.Drawing.Size(100, 20);
            this.lblActivation.TabIndex = 19;
            this.lblActivation.Text = "activation?";
            this.lblActivation.Click += new System.EventHandler(this.lblActivation_Click);
            // 
            // picDetails
            // 
            this.picDetails.Location = new System.Drawing.Point(512, 473);
            this.picDetails.Name = "picDetails";
            this.picDetails.Size = new System.Drawing.Size(515, 455);
            this.picDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDetails.TabIndex = 24;
            this.picDetails.TabStop = false;
            this.picDetails.Click += new System.EventHandler(this.picDetails_Click);
            // 
            // picSerial
            // 
            this.picSerial.Location = new System.Drawing.Point(30, 488);
            this.picSerial.Name = "picSerial";
            this.picSerial.Size = new System.Drawing.Size(395, 407);
            this.picSerial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSerial.TabIndex = 25;
            this.picSerial.TabStop = false;
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSerialNumber.Location = new System.Drawing.Point(153, 433);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(208, 32);
            this.lblSerialNumber.TabIndex = 26;
            this.lblSerialNumber.Text = "Serial Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(751, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Details";
            // 
            // btnPC
            // 
            this.btnPC.ForeColor = System.Drawing.Color.Black;
            this.btnPC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPC.Location = new System.Drawing.Point(296, 27);
            this.btnPC.Margin = new System.Windows.Forms.Padding(4);
            this.btnPC.Name = "btnPC";
            this.btnPC.Size = new System.Drawing.Size(83, 55);
            this.btnPC.TabIndex = 1;
            this.btnPC.Text = "PC";
            this.btnPC.UseVisualStyleBackColor = true;
            this.btnPC.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // btnLaptop
            // 
            this.btnLaptop.ForeColor = System.Drawing.Color.Black;
            this.btnLaptop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaptop.Location = new System.Drawing.Point(195, 27);
            this.btnLaptop.Margin = new System.Windows.Forms.Padding(4);
            this.btnLaptop.Name = "btnLaptop";
            this.btnLaptop.Size = new System.Drawing.Size(83, 55);
            this.btnLaptop.TabIndex = 0;
            this.btnLaptop.Text = "Laptop";
            this.btnLaptop.UseVisualStyleBackColor = true;
            this.btnLaptop.Click += new System.EventHandler(this.btnLaptop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Serial Number:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 932);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(119, 20);
            this.lblVersion.TabIndex = 29;
            this.lblVersion.Text = "Version 1.0.0.0";
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1055, 961);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLaptop);
            this.Controls.Add(this.btnPC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.picSerial);
            this.Controls.Add(this.picDetails);
            this.Controls.Add(this.lblActivation);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.btnReactivate);
            this.Controls.Add(this.btnSysprep);
            this.Controls.Add(this.btnQuickTest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mastertronics";
            ((System.ComponentModel.ISupportInitialize)(this.picDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSerial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuickTest;
        private System.Windows.Forms.Button btnSysprep;
        private System.Windows.Forms.Button btnReactivate;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblActivation;
        private System.Windows.Forms.PictureBox picDetails;
        private System.Windows.Forms.PictureBox picSerial;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPC;
        private System.Windows.Forms.Button btnLaptop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVersion;
        private System.Diagnostics.EventLog eventLog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


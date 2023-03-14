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
            this.btn_taskmngr = new System.Windows.Forms.Button();
            this.btn_devicemgnr = new System.Windows.Forms.Button();
            this.btn_dxdiag = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.disk_mgmt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cmd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSerial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuickTest
            // 
            this.btnQuickTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuickTest.Location = new System.Drawing.Point(24, 22);
            this.btnQuickTest.Name = "btnQuickTest";
            this.btnQuickTest.Size = new System.Drawing.Size(118, 44);
            this.btnQuickTest.TabIndex = 2;
            this.btnQuickTest.Text = "Quick Test!";
            this.btnQuickTest.UseVisualStyleBackColor = true;
            this.btnQuickTest.Click += new System.EventHandler(this.btnQuickTest_Click);
            // 
            // btnSysprep
            // 
            this.btnSysprep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSysprep.Location = new System.Drawing.Point(317, 22);
            this.btnSysprep.Name = "btnSysprep";
            this.btnSysprep.Size = new System.Drawing.Size(118, 44);
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
            this.btnReactivate.Location = new System.Drawing.Point(450, 22);
            this.btnReactivate.Name = "btnReactivate";
            this.btnReactivate.Size = new System.Drawing.Size(118, 44);
            this.btnReactivate.TabIndex = 4;
            this.btnReactivate.Text = "Re-Activate";
            this.btnReactivate.UseVisualStyleBackColor = true;
            this.btnReactivate.Click += new System.EventHandler(this.btnReactivate_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(24, 78);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(798, 283);
            this.txtDetails.TabIndex = 17;
            // 
            // lblActivation
            // 
            this.lblActivation.AutoSize = true;
            this.lblActivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivation.Location = new System.Drawing.Point(583, 35);
            this.lblActivation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivation.Name = "lblActivation";
            this.lblActivation.Size = new System.Drawing.Size(87, 17);
            this.lblActivation.TabIndex = 19;
            this.lblActivation.Text = "activation?";
            this.lblActivation.Click += new System.EventHandler(this.lblActivation_Click);
            // 
            // picDetails
            // 
            this.picDetails.Location = new System.Drawing.Point(410, 390);
            this.picDetails.Margin = new System.Windows.Forms.Padding(2);
            this.picDetails.Name = "picDetails";
            this.picDetails.Size = new System.Drawing.Size(412, 352);
            this.picDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDetails.TabIndex = 24;
            this.picDetails.TabStop = false;
            this.picDetails.Click += new System.EventHandler(this.picDetails_Click);
            // 
            // picSerial
            // 
            this.picSerial.Location = new System.Drawing.Point(24, 390);
            this.picSerial.Margin = new System.Windows.Forms.Padding(2);
            this.picSerial.Name = "picSerial";
            this.picSerial.Size = new System.Drawing.Size(316, 326);
            this.picSerial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSerial.TabIndex = 25;
            this.picSerial.TabStop = false;
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSerialNumber.Location = new System.Drawing.Point(122, 362);
            this.lblSerialNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(165, 26);
            this.lblSerialNumber.TabIndex = 26;
            this.lblSerialNumber.Text = "Serial Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 368);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Details";
            // 
            // btnPC
            // 
            this.btnPC.ForeColor = System.Drawing.Color.Black;
            this.btnPC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPC.Location = new System.Drawing.Point(237, 22);
            this.btnPC.Name = "btnPC";
            this.btnPC.Size = new System.Drawing.Size(66, 44);
            this.btnPC.TabIndex = 1;
            this.btnPC.Text = "PC";
            this.btnPC.UseVisualStyleBackColor = true;
            this.btnPC.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // btnLaptop
            // 
            this.btnLaptop.ForeColor = System.Drawing.Color.Black;
            this.btnLaptop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaptop.Location = new System.Drawing.Point(156, 22);
            this.btnLaptop.Name = "btnLaptop";
            this.btnLaptop.Size = new System.Drawing.Size(66, 44);
            this.btnLaptop.TabIndex = 0;
            this.btnLaptop.Text = "Laptop";
            this.btnLaptop.UseVisualStyleBackColor = true;
            this.btnLaptop.Click += new System.EventHandler(this.btnLaptop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 370);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Serial Number:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(911, 743);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(92, 17);
            this.lblVersion.TabIndex = 29;
            this.lblVersion.Text = "Version 2.4.1";
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btn_taskmngr
            // 
            this.btn_taskmngr.Location = new System.Drawing.Point(842, 99);
            this.btn_taskmngr.Name = "btn_taskmngr";
            this.btn_taskmngr.Size = new System.Drawing.Size(160, 33);
            this.btn_taskmngr.TabIndex = 30;
            this.btn_taskmngr.Text = "Tasks Mngr";
            this.btn_taskmngr.UseVisualStyleBackColor = true;
            this.btn_taskmngr.Click += new System.EventHandler(this.btn_taskmngr_Click);
            // 
            // btn_devicemgnr
            // 
            this.btn_devicemgnr.Location = new System.Drawing.Point(842, 138);
            this.btn_devicemgnr.Name = "btn_devicemgnr";
            this.btn_devicemgnr.Size = new System.Drawing.Size(160, 33);
            this.btn_devicemgnr.TabIndex = 31;
            this.btn_devicemgnr.Text = "Device Mngr";
            this.btn_devicemgnr.UseVisualStyleBackColor = true;
            this.btn_devicemgnr.Click += new System.EventHandler(this.btn_devicemgnr_Click);
            // 
            // btn_dxdiag
            // 
            this.btn_dxdiag.Location = new System.Drawing.Point(843, 216);
            this.btn_dxdiag.Name = "btn_dxdiag";
            this.btn_dxdiag.Size = new System.Drawing.Size(160, 33);
            this.btn_dxdiag.TabIndex = 32;
            this.btn_dxdiag.Text = "dxdiag";
            this.btn_dxdiag.UseVisualStyleBackColor = true;
            this.btn_dxdiag.Click += new System.EventHandler(this.btn_dxdiag_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.Location = new System.Drawing.Point(842, 390);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(160, 33);
            this.btn_upload.TabIndex = 33;
            this.btn_upload.Text = "Upload Drivers";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // disk_mgmt
            // 
            this.disk_mgmt.Location = new System.Drawing.Point(843, 177);
            this.disk_mgmt.Name = "disk_mgmt";
            this.disk_mgmt.Size = new System.Drawing.Size(160, 33);
            this.disk_mgmt.TabIndex = 34;
            this.disk_mgmt.Text = "Disk Mgmt";
            this.disk_mgmt.UseVisualStyleBackColor = true;
            this.disk_mgmt.Click += new System.EventHandler(this.disk_mgmt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(839, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "Diagnostic Tools";
            // 
            // btn_cmd
            // 
            this.btn_cmd.Location = new System.Drawing.Point(843, 255);
            this.btn_cmd.Name = "btn_cmd";
            this.btn_cmd.Size = new System.Drawing.Size(160, 33);
            this.btn_cmd.TabIndex = 41;
            this.btn_cmd.Text = "CMD";
            this.btn_cmd.UseVisualStyleBackColor = true;
            this.btn_cmd.Click += new System.EventHandler(this.btn_cmd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1014, 769);
            this.Controls.Add(this.btn_cmd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.disk_mgmt);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.btn_dxdiag);
            this.Controls.Add(this.btn_devicemgnr);
            this.Controls.Add(this.btn_taskmngr);
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
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mastertronics";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.Button btn_dxdiag;
        private System.Windows.Forms.Button btn_devicemgnr;
        private System.Windows.Forms.Button btn_taskmngr;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button disk_mgmt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cmd;
    }
}


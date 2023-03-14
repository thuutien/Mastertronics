using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Management.Automation;

namespace Master2
{
    public partial class MainForm : Form
    {
        //string serverIP = "";
        public MainForm()
        {

            InitializeComponent();
            checkActivation();
            genrateCodeImages();
            txtDetails.Text = laptopDetails();
            lblSerialNumber.Text = WMICTool.getSerialNumber();
            genrateCodeImages();
            WMICTool.preventSleep();
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            
        }


        // Buttons
        private void btnQuickTest_Click(object sender, EventArgs e)
        {
            PowerShell ps = PowerShell.Create();
            string script = @"start microsoft-edge:https://www.youtube.com/watch?v=KpsJWFuVTdI
start microsoft-edge:https://key-test.com/
start microsoft-edge:https://lcdtech.info/en/tests/dead.pixel.htm
start microsoft.windows.camera:
start devmgmt.msc";

            ps.AddScript(script);
            ps.Invoke();
            ps.Dispose();


        }

        private void btnSysprep_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Windows\sysnative\Sysprep\sysprep.exe");
            } catch
            {
                MessageBox.Show("Please run application as Administrator");
            }

        }


        private void btnReactivate_Click(object sender, EventArgs e)
        {
            WMICTool.reactivate();
        }


        private void btnLaptop_Click(object sender, EventArgs e)
        {

            txtDetails.Text = laptopDetails();
            genrateCodeImages();
        }

        private void btnPC_Click(object sender, EventArgs e)
        {

            txtDetails.Text = pcDetails();
            genrateCodeImages();
        }





        //Private methods.
        private string laptopDetails()
        {
            String output = "ORDER ID: \r\nTRACKING NUMBER: \r\nREASON: N/A \r\n\r\nCHARGER: N/A \r\nISSUES: NO \r\nUNPLUG TEST: N/A \r\nWARRANTY: " +
                 "\r\n\r\nCOLOR: \r\nBOX: \r\n\r\n" +
                WMICTool.getManufacturer() + ", " + WMICTool.getModelName() + ", [SCREEN SIZE?], " + WMICTool.getResolutionDetails() +
                ", [TOUCH?], " + WMICTool.getCPUDetails() + ", " + WMICTool.getRAMDetails() + ", " + WMICTool.getDiskDetails() +
                 WMICTool.getGraphicCardDetails() + " " + WMICTool.getOSDetails() + "\r\n\r\nSKU: " + "\r\nLOCATION: \r\n\r\nN/A \r\n\r\n1. SN: " + WMICTool.getSerialNumber() + "\r\n\r\nNOTE: SMILEY-FACE";

            return output;
        }

        private string pcDetails()
        {
            String output = "ORDER ID: \r\nTRACKING NUMBER: \r\nREASON: N/A \r\n\r\nCHARGER: N/A \r\nISSUES: NO \r\nUNPLUG TEST: N/A \r\nWARRANTY: " +
                 "\r\n\r\nCOLOR: \r\nBOX: \r\n\r\n" +
                WMICTool.getManufacturer() + ", " + WMICTool.getModelName() +
                ", " + WMICTool.getCPUDetails() + ", " + WMICTool.getRAMDetails() + ", " + WMICTool.getDiskDetails() +
                 WMICTool.getGraphicCardDetails() + " " + WMICTool.getOSDetails() + "\r\n\r\nSKU: " + "\r\nLOCATION: \r\n\r\nN/A \r\n\r\n1. SN: " + WMICTool.getSerialNumber() + "\r\n\r\nNOTE: SMILEY-FACE";

            return output;
        }



        private void checkActivation()
        {
            if (WMICTool.getActivationDetails() == LicenseStatus.Licensed)
            {
                lblActivation.ForeColor = System.Drawing.Color.Green;
                lblActivation.Text = "WINDOWS IS ACTIVATED";
            }
            else
            {
                lblActivation.ForeColor = System.Drawing.Color.Red;
                lblActivation.Text = "WINDOWS IS NOT ACTIVATED";
                //run activate
            }

            Console.WriteLine("Checked: " + lblActivation.Text);

        }

        private void genrateCodeImages()
        {
            string serialNumber = WMICTool.getSerialNumber();
            if (serialNumber != "")
            {
                QRCoder.QRCodeGenerator qrCodeGenerator = new QRCoder.QRCodeGenerator();

                var dataDetails = qrCodeGenerator.CreateQrCode(txtDetails.Text, QRCoder.QRCodeGenerator.ECCLevel.M);
                var codeDetails = new QRCoder.QRCode(dataDetails);
                picDetails.Image = codeDetails.GetGraphic(100);

                var dataSerial = qrCodeGenerator.CreateQrCode(serialNumber, QRCoder.QRCodeGenerator.ECCLevel.M);
                var codeSerial = new QRCoder.QRCode(dataSerial);
                picSerial.Image = codeSerial.GetGraphic(100);

            }

        }


        private void lblActivation_Click(object sender, EventArgs e)
        {
            checkActivation();
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/thuutien");
        }

        private void picDetails_Click(object sender, EventArgs e)
        {
            genrateCodeImages();
        }

        private void btn_taskmngr_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\WINDOWS\system32\taskmgr.exe");
            }
            catch
            {
                MessageBox.Show("Please run application as Administrator");
            }
        }

        private void btn_devicemgnr_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\WINDOWS\system32\devmgmt.msc");
            }
            catch
            {
                MessageBox.Show("Please run application as Administrator");
            }
        }

        private void disk_mgmt_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\WINDOWS\system32\diskmgmt.msc");
            }
            catch
            {
                MessageBox.Show("Please run application as Administrator");
            }

        }

        private void btn_dxdiag_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\WINDOWS\system32\dxdiag.exe");
            }
            catch
            {
                MessageBox.Show("Please run application as Administrator");
            }

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            String manufacturer = WMICTool.getManufacturer();
            String model = WMICTool.getModelName();
            string directory = "'Z:\\" + manufacturer + "\\" + model + "'";
            Console.WriteLine(directory);

            string script = @"$secPassword = ConvertTo-SecureString ""G00dm@stertronic"" -AsPlainText -Force
$cred = new-object -typename System.Management.Automation.PSCredential -argumentlist Administrator, $secPassword
New-PSDrive -Name Z -PSProvider FileSystem -Root \\192.168.128.2\drivers$ -Credential $cred -Persist";


            PowerShell ps = PowerShell.Create();
            
            ps.AddScript(script);
            ps.Invoke();
            ps.AddScript(@"New-Item -Path " + directory + " -ItemType Directory");
            ps.Invoke();
            ps.AddScript("dism /online /export-driver /destination:" + directory);
            ps.Invoke();
            ps.AddScript("net use Z: /delete");
            ps.Invoke();
            Cursor.Current = Cursors.Default;
            MessageBox.Show("Export completed!");
            ps.Dispose();
        }

        private void btn_cmd_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\WINDOWS\system32\cmd.exe");
            }
            catch
            {
                MessageBox.Show("Please run application as Administrator");
            }

        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_enabeSleep_Click(object sender, EventArgs e)
        {
        }
    }
}

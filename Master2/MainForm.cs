using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace Master2
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            
            InitializeComponent();
            checkActivation();
            genrateCodeImages();
            txtDetails.Text = laptopDetails();
            lblSerialNumber.Text = WMICTool.getSerialNumber();
            genrateCodeImages();
        }


        // Buttons
        private void btnQuickTest_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/C start msedge /new http://en.key-test.ru/");
            Process.Start("cmd.exe", "/C start msedge /new https://lcdtech.info/en/tests/dead.pixel.htm");
            Process.Start("cmd.exe", "/C start msedge /new https://www.youtube.com/watch?v=QEjgPh4SEmU");
            Process.Start("cmd.exe", "/C start microsoft.windows.camera:");
            Process.Start("cmd.exe", "/C devmgmt.msc");

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
            String output = "SOURCE: \r\nORDER#: \r\nTRACKING#: \r\n\r\nCHARGER: \r\nISSUES: \r\n\r\nCONDITION: \r\nSN: " +
                WMICTool.getSerialNumber() + "\r\nCOLOR: \r\n\r\n" +
                WMICTool.getManufacturer() + ", " + WMICTool.getModelName() + ", [SCREEN SIZE], " + WMICTool.getResolutionDetails() + 
                ", " + WMICTool.getCPUDetails() + ", " + WMICTool.getRAMDetails() +", " + WMICTool.getDiskDetails() +
                 WMICTool.getGraphicCardDetails() + " " + WMICTool.getOSDetails() + "\r\n\r\nREF MODEL: " + WMICTool.getModelName() + "\r\n\r\nBOX: \r\nUNPLUG TEST: \r\nACTION: ";

            return output;
        }

        private string pcDetails()
        {
            String output = "SOURCE: \r\nORDER#: \r\nTRACKING#: \r\n\r\nCHARGER: \r\nISSUES: \r\n\r\nCONDITION: \r\nSN: " +
                WMICTool.getSerialNumber() + "\r\nCOLOR: \r\n\r\n" +
                WMICTool.getManufacturer() + ", " + WMICTool.getModelName() +
                ", [SCREEN SIZE], " + WMICTool.getCPUDetails() + ", " + WMICTool.getRAMDetails() + ", " + WMICTool.getDiskDetails() +
                 WMICTool.getGraphicCardDetails() + " " + WMICTool.getOSDetails() + "\r\n\r\nREF MODEL: " + WMICTool.getModelName() + "\r\n\r\nBOX: \r\nUNPLUG TEST: \r\nACTION: ";

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

        }

        private void lblVersion_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/thuutien");
        }

        private void picDetails_Click(object sender, EventArgs e)
        {
            genrateCodeImages();
        }
    }
}

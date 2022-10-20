using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows;

namespace Master2
{
    internal class WMICTool
    {
        public static string getSerialNumber() 
        {
            string serialNumber = "";
            ManagementObjectSearcher s = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
            foreach (ManagementObject wmi in s.Get())
            {
                try
                {
                    serialNumber = wmi.GetPropertyValue("SerialNumber").ToString();
                }
                catch { }
            }

            return serialNumber;
        }

        public static string getManufacturer() 
        {
            string manufacturer = "";
            ManagementObjectSearcher s = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject wmi in s.Get())
            {
                try
                {
                    manufacturer = wmi.GetPropertyValue("Manufacturer").ToString();
                }
                catch { }
            }

            return manufacturer;
        }

        public static string getModelName()
        {
            string modelName = "";
            ManagementObjectSearcher s = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");

            foreach (ManagementObject wmi in s.Get())
            {
                try
                {
                    modelName = wmi.GetPropertyValue("Model").ToString();
                }
                catch { }
            
            }

            return modelName;
        }

        public static string getGraphicCardDetails()
        {
            string graphicCardDetail = "";
            ManagementObjectSearcher s = new ManagementObjectSearcher("SELECT * FROM win32_VideoController");
            foreach (ManagementObject wmi in s.Get())
            {
                try
                {
                    graphicCardDetail += wmi.GetPropertyValue("Name").ToString() +", ";
                }
                catch { }
            }

            return graphicCardDetail;
        }

        public static string getResolutionDetails()
        {
            string vertical = "";
            string horizontal = "";
            ManagementObjectSearcher s = new ManagementObjectSearcher("SELECT * FROM win32_VideoController");

            foreach (ManagementObject wmi in s.Get())
            {
                try
                {
                    vertical = wmi.GetPropertyValue("CurrentVerticalResolution").ToString();
                    horizontal = wmi.GetPropertyValue("CurrentHorizontalResolution").ToString();
                }
                catch { }
                if(vertical != "" && horizontal != "")
                {
                    break;
                }

                
            }

            return horizontal + "x" + vertical;
        }


        public static string getOSDetails()
        {
            string osName = "";
            string osArchitecture = "";
            ManagementObjectSearcher s = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject wmi in s.Get())
            {
                try
                {
                    osName = wmi.GetPropertyValue("Caption").ToString();
                    osArchitecture = wmi.GetPropertyValue("OSArchitecture").ToString();
                }
                catch { }

            }

            return osName + " " + osArchitecture;
        }

        public static string getCPUDetails()
        {
            string cpuName = "";
            ManagementObjectSearcher s = new ManagementObjectSearcher("SELECT * FROM CIM_Processor");

            foreach (ManagementObject wmi in s.Get())
            {
                try
                {
                    cpuName += wmi.GetPropertyValue("Name").ToString() + "";

                }
                catch { }

            }

            return cpuName;
        }

        public static string getRAMDetails()
        {
            long capacity = 0;
            ManagementObjectSearcher s = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");

            foreach (ManagementObject wmi in s.Get())
            {
                try
                {              
                    capacity += long.Parse(wmi.GetPropertyValue("Capacity").ToString()) / 1073741824;
                }
                catch { }
                
            }

            return capacity.ToString() + "GB RAM"  ;
        }


        public static string getDiskDetails()
        {
            long capacity = 0;
            string capacityString = "";
            string type = "";
            string disks = "";
            var scope = new ManagementScope(@"\\localhost\ROOT\Microsoft\Windows\Storage");
            var query = new ObjectQuery("SELECT * FROM MSFT_PhysicalDisk");
            var s = new ManagementObjectSearcher(scope, query);
    
            foreach (ManagementObject wmi in s.Get())
            {
                try
                {
                    int typeCode = int.Parse(wmi.GetPropertyValue("MediaType").ToString());
                    switch (typeCode) {
                        case 3:
                            type = "HDD";
                            capacity = long.Parse(wmi.GetPropertyValue("Size").ToString()) / 1000000000;
                            if (capacity >= 1000)
                            {
                                capacityString = (capacity / 1000).ToString() + "TB";
                            }
                            else
                            {
                                capacityString = capacity.ToString() + "GB";
                            }

                            disks += capacityString + " " + type + ", ";
                            break;

                        case 4:
                            type = "SSD";
                            capacity = long.Parse(wmi.GetPropertyValue("Size").ToString()) / 1000000000;
                            if (capacity >= 1000)
                            {
                                capacityString = (capacity / 1000).ToString() + "TB";
                            }
                            else
                            {
                                capacityString = capacity.ToString() + "GB";
                            }

                            disks += capacityString + " " + type + ", ";
                            break;
                            
                        default:
                            break;
                    }
                }
                catch { }
            }
            return disks;
        }

      
        public static LicenseStatus getActivationDetails()
        {
            string status = "";
            LicenseStatus result = LicenseStatus.Unlicensed;
            ManagementObjectSearcher s = new ManagementObjectSearcher("SELECT * FROM SoftwareLicensingProduct");

            foreach (ManagementObject wmi in s.Get())
            {
                try
                {
                    status = wmi.GetPropertyValue("LicenseStatus").ToString(); 
                }
                catch { }
                if (status == "1") { result = LicenseStatus.Licensed; break; }  
            }
            return result;
        }

        public static void reactivate()
        {
            string oemKey = ""; 
            ManagementObjectSearcher s = new ManagementObjectSearcher("SELECT * FROM SoftwareLicensingService");
            foreach (ManagementObject wmi in s.Get())
            {
                try
                {
                    oemKey = wmi.GetPropertyValue("OA3xOriginalProductKey").ToString();
                }
                catch { }
                break;
            }

            if (oemKey == "") { MessageBox.Show("Cannot Activate"); return; }
            try
            {
                string command = "/c slmgr /ipk " + oemKey;
                Process.Start("cmd.exe", command);
                //var cls = new ManagementClass("SELECT * FROM SoftwareLicensingServissce");
                //cls.InvokeMethod("RefreshLicenseStatus", new object[0]);


            }
            catch (ManagementException e)
            {
                MessageBox.Show(e.Message + "\r\nPlease run application as Administrator");
            }
            
        }


    }

    
}

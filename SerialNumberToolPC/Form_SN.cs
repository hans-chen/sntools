using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using OpenNETCF.Desktop.Communication;

namespace SerialNumberInput
{
    public partial class F_SN : Form
    {
        Hashtable hs_product = new Hashtable();
        Hashtable hs_month = new Hashtable();

        string[] s_serialnumber = null;

        string[] snfiles = Directory.GetFiles(".\\NLSN\\", "*.txt");

        int n_snfileindex = 0;

        int iProductCodeLength = 2;
        int iYearLength = 1;
        int iMonthLength = 1;
        int iSerialLenth = 5;

        public F_SN()
        {
            InitializeComponent();

            hs_product.Add("P3", "PT850");
            hs_product.Add("P5", "PT810");
            hs_product.Add("P6", "PT950");
            hs_product.Add("P7", "PT952");
            hs_product.Add("PB", "PT980");
            hs_product.Add("PC", "PT982");
            hs_product.Add("PD", "PT981");
            hs_product.Add("PE", "PT853");
            hs_product.Add("PF", "PT983");
            hs_product.Add("E0", "EM1027");
            hs_product.Add("E1", "EM1300");
            hs_product.Add("E2", "EM2027");
            hs_product.Add("E3", "EM3000");
            hs_product.Add("E4", "EM3042");
            hs_product.Add("H3", "HR200");
            hs_product.Add("H5", "HR100");
            hs_product.Add("H6", "HR085");
            hs_product.Add("F2", "FM200");
            hs_product.Add("F3", "FM208");
            hs_product.Add("F6", "FM300");
            hs_product.Add("F7", "FM210");
            hs_product.Add("I0", "NQuire202");
            hs_product.Add("I1", "NQuire201");
            hs_product.Add("I3", "NQuire231");
            hs_product.Add("I4", "NQuire232");
            hs_product.Add("I2", "IT220");
            hs_product.Add("F9", "FM100");
            hs_product.Add("F8", "FM420");

            hs_month.Add("A", "Jan");
            hs_month.Add("B", "Feb");
            hs_month.Add("C", "Mar");
            hs_month.Add("D", "Apr");
            hs_month.Add("E", "May");
            hs_month.Add("F", "Jun");
            hs_month.Add("G", "Jul");
            hs_month.Add("H", "Aug");
            hs_month.Add("I", "Sep");
            hs_month.Add("J", "Oct");
            hs_month.Add("K", "Nov");
            hs_month.Add("L", "Dec");

            if (snfiles.Length > 0)
            {
                T_Info.Clear();
                T_Info.AppendText(@"There are " + snfiles.Length.ToString() + @" SN Files");
            }
            else
            {
                T_Info.AppendText("There is no SN files!\n");
            }
        }

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("USER32.DLL")]
        public static extern int GetCursorPos(out Point point);

        [DllImport("msvcrt.dll")]
        static extern bool system(string str);

        [ DllImport ( "gdi32.dll" ) ] 
        private static extern bool BitBlt ( 
            IntPtr hdcDest, // 目标设备的句柄 
            int nXDest, // 目标对象的左上角的X坐标 
            int nYDest, // 目标对象的左上角的X坐标 
            int nWidth, // 目标对象的矩形的宽度 
            int nHeight, // 目标对象的矩形的长度 
            IntPtr hdcSrc, // 源设备的句柄 
            int nXSrc, // 源对象的左上角的X坐标 
            int nYSrc, // 源对象的左上角的X坐标 
            int dwRop // 光栅的操作值 
            );

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateDC(
            string lpszDriver, // 驱动名称 
            string lpszDevice, // 设备名称 
            string lpszOutput, // 无用，可以设定位"NULL" 
            IntPtr lpInitData // 任意的打印机数据 
            );

        private void B_Open_Click(object sender, EventArgs e)
        {
            ReadSN();
        }

        private void B_SimInput_Click(object sender, EventArgs e)
        {
            IntPtr ERPHandle = FindWindow("ThunderRT6FormDC", "050 Fulfillment - Exact");

            // Verify that Calculator is a running process.
            if (ERPHandle == IntPtr.Zero)
            {
                ERPHandle = FindWindow("ThunderRT6FormDC", "050 Receipts - Exact");

                if (ERPHandle == IntPtr.Zero)
                {
                    MessageBox.Show("Can not open Exact Fulfillment or Receipt window!");

                    return;
                }
            }
//            IntPtr ERPHandle = FindWindow("ThunderRT6FormDC", "050 Create: Serial number - Exact");
            
            foreach (DataGridViewRow s in DG_SNList.Rows)
            {
                try
                {
                    SetForegroundWindow(ERPHandle);
                }
                catch (Exception)
                {
                    return;
                }
                

                //GetColor();

                SendKeys.SendWait(s.Cells[0].Value.ToString());

                Thread.Sleep(500);

                SendKeys.SendWait("{ENTER}");

                Thread.Sleep(2000);

//                SendKeys.SendWait("{ENTER}");

//                Thread.Sleep(500);
            }
        }

        private void B_PrevFile_Click(object sender, EventArgs e)
        {
            SwitchSNFile("Prev");
        }

        private void B_NextFile_Click(object sender, EventArgs e)
        {
            SwitchSNFile("Next");
        }

        private int SwitchSNFile(string d)
        {
            int n = n_snfileindex;

            if (d == "Prev" && n_snfileindex > 0 && n_snfileindex < snfiles.Length-1)
            {
                n_snfileindex -= 1;
            }
            else if (d == "Next" && n_snfileindex >= 0 && n_snfileindex < snfiles.Length-1)
            {
                n_snfileindex += 1;
            }

            E_SNFile.Text = snfiles[n_snfileindex].Split(new Char[] { '\\' })[2].Split(new Char[] { '.' })[0];

            ReadSN();

            return n_snfileindex;
        }

        private void ReadSN()
        {
            string s_filename = @".\NLSN\" + E_SNFile.Text + @".txt";

            DG_SNList.Rows.Clear();

            if (File.Exists(s_filename))
            {

                s_serialnumber = File.ReadAllLines(s_filename);

            }
            else
            {
                MessageBox.Show("Can not open serial number file!");
                return;
            }

            foreach (string s in s_serialnumber)
            {
                if (hs_product.ContainsKey(s.Substring(0, iProductCodeLength)))
                {

                    try
                    {
                        DG_SNList.Rows.Add(s,
                            hs_product[s.Substring(0, iProductCodeLength)],
                            int.Parse(s.Substring(iProductCodeLength, iYearLength)) + 2010,
                            hs_month[s.Substring(iProductCodeLength + iYearLength, iMonthLength)],
                            s.Substring(iProductCodeLength + iYearLength + iMonthLength + iSerialLenth));

                    }
                    catch (Exception)
                    {
                        DG_SNList.Rows.Add(s, "Unknown");
                    }
                }
                else
                {
                    DG_SNList.Rows.Add(s, "Unknown");
                }

                DG_SNList.Update();
            }

            UpdateInfo();
        }

        private void GetColor()
        {
            IntPtr hdlDisplay = CreateDC("DISPLAY", null, null, IntPtr.Zero);

            // 从指定设备的句柄创建新的 Graphics 对象 

            Graphics gfxDisplay = Graphics.FromHdc(hdlDisplay);

            // 创建只有一个象素大小的 Bitmap 对象 

            Bitmap bmp = new Bitmap(1, 1, gfxDisplay);

            // 从指定 Image 对象创建新的 Graphics 对象 

            Graphics gfxBmp = Graphics.FromImage(bmp);

            // 获得屏幕的句柄 

            IntPtr hdlScreen = gfxDisplay.GetHdc();

            // 获得位图的句柄 

            IntPtr hdlBmp = gfxBmp.GetHdc();

            // 把当前屏幕中鼠标指针所在位置的一个象素拷贝到位图中 

            Point showPoint = new Point();
            GetCursorPos(out showPoint);

            MessageBox.Show(showPoint.X.ToString());

            BitBlt(hdlBmp, 0, 0, 1, 1, hdlScreen, showPoint.X, showPoint.Y, 13369376);

            // 释放屏幕句柄 

            gfxDisplay.ReleaseHdc(hdlScreen);

            // 释放位图句柄 

            gfxBmp.ReleaseHdc(hdlBmp);

            string s_color = bmp.GetPixel(0, 0).ToArgb().ToString("x").ToUpper();

            MessageBox.Show(s_color);

            gfxDisplay.Dispose();
            gfxBmp.Dispose();

            bmp.Dispose(); // 释放 bmp 所使用的资源 

        }

        private void DG_SNList_UDRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateInfo();
        }

        private void E_SNFileKP(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                ReadSN();
            }
        }

        private void UpdateInfo()
        {
            T_Info.Clear();
            T_Info.AppendText("SN file opened: " + E_SNFile.Text + "\n");
            T_Info.AppendText("Serial numbers: " + DG_SNList.Rows.GetRowCount(DataGridViewElementStates.None).ToString());
        }

        private void B_GetFromPT_Click(object sender, EventArgs e)
        {
            T_Info.Clear();

            RAPI ptapi = new RAPI();

            ptapi.Connect();

            FileList ptfiles = ptapi.EnumFiles(@"\NLSN\*.txt");

            foreach (FileInformation f in ptfiles)
            {
                ptapi.CopyFileFromDevice(@".\NLSN\" + f.FileName, @"\NLSN\" + f.FileName, true);

                T_Info.AppendText(f.FileName + "\n");
            }

            T_Info.AppendText("Copied " + ptfiles.Count.ToString() + " SN files.\n");

            ptapi.Disconnect();

            ptapi.Dispose();

            snfiles = Directory.GetFiles(@".\NLSN\", "*.txt");
        }

        //http://msdn.microsoft.com/zh-cn/library/ms171548.aspx
    }
}

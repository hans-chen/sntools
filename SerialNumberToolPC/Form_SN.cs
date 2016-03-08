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

        string[] snfiles = Directory.GetFiles(".\\NLSN\\", "*.txt");

        int n_snfileindex = 0;

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
                tboxInfo.Clear();
                tboxInfo.AppendText(@"There are " + snfiles.Length.ToString() + @" SN Files");
            }
            else
            {
                tboxInfo.AppendText("There is no SN files!\n");
            }
        }

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        // Activate an application window.
        [DllImport("user32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.DLL")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.DLL")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.DLL")]
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

        private void B_SimInput_Click(object sender, EventArgs e)
        {
            string[] strSN = (!String.IsNullOrEmpty(T_SNinput.Text.Trim())) ? T_SNinput.Lines : null;

            IntPtr handleExact = IntPtr.Zero;
            IntPtr handleCurrent = IntPtr.Zero;
            StringBuilder strWinTitle = new StringBuilder(256);

            //testing window
            //handleExact = FindWindow("Notepad++", "*new  2 - Notepad++");

            if (radioFullfill.Checked)
            {
                handleExact = FindWindow("ThunderRT6FormDC", "050 Leveringen - Exact");
            }
            else if (radioReceipt.Checked)
            {
                handleExact = FindWindow("ThunderRT6FormDC", "050 Ontvangsten - Exact");
            }
            else if (radioCounts.Checked)
            {
                handleExact = FindWindow("ThunderRT6FormDC", "050 Aanmaken: Serienummer - Exact");
            }
            else
            {
                MessageBox.Show("Please choose input target from To...");
                return; //comment this line for testing to notepad
            }

            if (handleExact == IntPtr.Zero)
            {
                tboxInfo.AppendText("Can't find Exact window!\n");
                return;
            }
            else
            {
                try
                {
                    SetForegroundWindow(handleExact);
                }
                catch (Exception)
                {
                    tboxInfo.AppendText("Can't find Exact window!\n");
                    return;
                }
            }
            
            foreach (string s in strSN)
            {
                handleCurrent = GetForegroundWindow();

                if (GetWindowText(handleCurrent, strWinTitle, 256) == 0)
                {
                    tboxInfo.AppendText("Unknown window!\n");
                    return;
                }
                else if (!(radioCounts.Checked && strWinTitle.ToString() == "050 Aanmaken: Serienummer - Exact") && (handleExact != handleCurrent))
                {
                    tboxInfo.AppendText("Stopped by switch window!\n");
                    tboxInfo.AppendText(strWinTitle.ToString());
                    return;
                }

                if (s.Length == 0)
                {
                    continue;
                }

                //GetColor();
                if (radioTypein.Checked)
                {
                    SendKeys.SendWait(s);
                }
                else if (radioPaste.Checked)
                {
                    Clipboard.SetDataObject(s);
                    SendKeys.SendWait("^(v)");
                }
                
                Thread.Sleep(500);
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(2000);

                // inputting for inventory counts, need an extra enter to active inputting window
                if (radioCounts.Checked)
                {
                    SendKeys.SendWait("{ENTER}");
                    Thread.Sleep(500);
                }
            }

            tboxInfo.AppendText("Completely!");
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

            if (File.Exists(s_filename))
            {
                T_SNinput.Text = File.ReadAllText(s_filename);
            }
            else
            {
                MessageBox.Show("Can not open serial number file!");
                return;
            }

            updateInfo();
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
            updateInfo();
        }

        private void E_SNFileKP(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                ReadSN();
            }
        }

        private void updateInfo(string s)
        {
            tboxInfo.Clear();
            tboxInfo.AppendText("SN: " + T_SNinput.Lines.Length.ToString() + "\n");
            tboxInfo.AppendText(s);
        }

        private void updateInfo()
        {
            updateInfo("");
        }

        private void B_GetFromPT_Click(object sender, EventArgs e)
        {
            tboxInfo.Clear();

            RAPI ptapi = new RAPI();

            ptapi.Connect();

            FileList ptfiles = ptapi.EnumFiles(@"\NLSN\*.txt");

            foreach (FileInformation f in ptfiles)
            {
                ptapi.CopyFileFromDevice(@".\NLSN\" + f.FileName, @"\NLSN\" + f.FileName, true);

                tboxInfo.AppendText(f.FileName + "\n");
            }

            tboxInfo.AppendText("Copied " + ptfiles.Count.ToString() + " SN files.\n");

            ptapi.Disconnect();

            ptapi.Dispose();

            snfiles = Directory.GetFiles(@".\NLSN\", "*.txt");
        }

        private void T_SNinput_TextChanged(object sender, EventArgs e)
        {
            updateInfo();
        }

        //http://msdn.microsoft.com/zh-cn/library/ms171548.aspx
    }
}

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
using System.Media;
using System.Reflection;
using System.Configuration;
using System.Collections.Specialized;

namespace SerialNumberInput
{
    public partial class F_SN : Form
    {
        public F_SN()
        {
            InitializeComponent();

            L_Version.Text = Assembly.GetEntryAssembly().GetName().Version + "; Hans @ Newland Europe 2016";

            radioFullfill.Text = ConfigurationManager.AppSettings.Get("windowFullfill");
            radioReceipt.Text = ConfigurationManager.AppSettings.Get("windowReceipt");
            radioCounts.Text = ConfigurationManager.AppSettings.Get("windowCounts");
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
        /*- Retrieves information about active window or any specific GUI thread -*/
        [DllImport("user32.dll", EntryPoint = "GetGUIThreadInfo")]
        public static extern bool GetGUIThreadInfo(uint tId, out GUITHREADINFO threadInfo);

        [StructLayout(LayoutKind.Sequential)]    // Required by user32.dll
        public struct RECT
        {
            public uint Left;
            public uint Top;
            public uint Right;
            public uint Bottom;
        };

        [StructLayout(LayoutKind.Sequential)]    // Required by user32.dll
        public struct GUITHREADINFO
        {
            public uint cbSize;
            public uint flags;
            public IntPtr hwndActive;
            public IntPtr hwndFocus;
            public IntPtr hwndCapture;
            public IntPtr hwndMenuOwner;
            public IntPtr hwndMoveSize;
            public IntPtr hwndCaret;
            public RECT rcCaret;
        };

        GUITHREADINFO guiInfo;                     // To store GUI Thread Information
        Point caretPosition;                     // To store Caret Position  

        public void GetCaretPosition(ref int cx, ref int cy)
        {
            guiInfo = new GUITHREADINFO();
            guiInfo.cbSize = (uint)Marshal.SizeOf(guiInfo);

            // Get GuiThreadInfo into guiInfo
            GetGUIThreadInfo(0, out guiInfo);

            caretPosition.X = (int)guiInfo.rcCaret.Left;
            caretPosition.Y = (int)guiInfo.rcCaret.Bottom;

            cx = caretPosition.X;
            cy = caretPosition.Y;
        }

        private void B_SimInput_Click(object sender, EventArgs e)
        {
            string[] strSN = (!String.IsNullOrEmpty(T_SNinput.Text.Trim())) ? T_SNinput.Lines : null;

            IntPtr handleExact = IntPtr.Zero;
            IntPtr handleCurrent = IntPtr.Zero;
            StringBuilder strWinTitle = new StringBuilder(256);

            //caret positions
            int caretX1 = 0;
            int caretY1 = 0;
            int caretX2 = 0;
            int caretY2 = 0;

            //load configurations


            if (radioFullfill.Checked)
            {
                handleExact = FindWindow(ConfigurationManager.AppSettings.Get("windowClass"), ConfigurationManager.AppSettings.Get("windowFullfill"));
            }
            else if (radioReceipt.Checked)
            {
                handleExact = FindWindow(ConfigurationManager.AppSettings.Get("windowClass"), ConfigurationManager.AppSettings.Get("windowReceipt"));
            }
            else if (radioCounts.Checked)
            {
                handleExact = FindWindow(ConfigurationManager.AppSettings.Get("windowClass"), ConfigurationManager.AppSettings.Get("windowCounts"));
            }
            else
            {
                MessageBox.Show("Please choose input target from To...");
                return; //comment this line for testing to notepad
            }

            //testing window
            //handleExact = FindWindow("Notepad", "Untitled - Notepad");

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

            //log the caret postion from beginning
            Thread.Sleep(500);
            GetCaretPosition(ref caretX1, ref caretY1);

            tboxInfo.AppendText("X1=" + caretX1.ToString() + ", Y1=" + caretY1.ToString() + "\n");

            foreach (string s in strSN)
            {
                handleCurrent = GetForegroundWindow();

                if (GetWindowText(handleCurrent, strWinTitle, 256) == 0)
                {
                    tboxInfo.AppendText("Unknown window!\n");
                    return;
                }
                else if (strWinTitle.ToString() != ConfigurationManager.AppSettings.Get("windowCounts")
                         && (handleExact != handleCurrent))
                {
                    //since in counts window the handle of window will be changed every serial number so have to ignore its checking.
                    tboxInfo.AppendText("Switching window!\n");
                    tboxInfo.AppendText("handleExact=" + handleExact.ToString() + "\n");
                    tboxInfo.AppendText("handleCurrent=" + handleCurrent.ToString() + "\n");
                    tboxInfo.AppendText(strWinTitle.ToString());
                    return;
                }

                GetCaretPosition(ref caretX2, ref caretY2);
                tboxInfo.AppendText("X2=" + caretX2.ToString() + ", Y2=" + caretY2.ToString() + "\n");

                if (caretX2 != caretX1)
                {
                    tboxInfo.AppendText("X1=" + caretX1.ToString() + ", Y1=" + caretY1.ToString() + "\n");
                    tboxInfo.AppendText("X2=" + caretX2.ToString() + ", Y2=" + caretY2.ToString() + "\n");
                    tboxInfo.AppendText("Wrong caret!\n");

                    SystemSounds.Beep.Play();

                    SetForegroundWindow(this.Handle);

                    return;
                }

                if (s.Length == 0)
                {
                    continue;
                }

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

                T_SNdone.AppendText(s + "\n");
                if (T_SNinput.Text.Length > T_SNinput.Lines.GetValue(0).ToString().Length)
                    T_SNinput.Text = T_SNinput.Text.Remove(0, T_SNinput.Lines.GetValue(0).ToString().Length + 2);
                else
                    T_SNinput.Text = "";
            }

            tboxInfo.AppendText("Done!\n");
        }

        private void DG_SNList_UDRow(object sender, DataGridViewRowEventArgs e)
        {
            updateInfo();
        }

/*
        private void E_SNFileKP(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                ReadSN();
            }
        }
*/
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

        private void T_SNinput_TextChanged(object sender, EventArgs e)
        {
            updateInfo();
        }

        //http://msdn.microsoft.com/zh-cn/library/ms171548.aspx
    }
}

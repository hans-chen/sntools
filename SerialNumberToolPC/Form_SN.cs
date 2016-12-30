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

        public void getCaretPosition(ref int cx, ref int cy)
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
                return;
            }

            //testing window
            //handleExact = FindWindow("Notepad", "Untitled - Notepad");

            if (handleExact == IntPtr.Zero)
            {
                updateLog("Can't find Exact!");

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
                    updateLog("Can't find Exact!");
                    return;
                }
            }

            //log the caret postion from beginning
            Thread.Sleep(500);
            getCaretPosition(ref caretX1, ref caretY1);

            updateLog("X1=" + caretX1.ToString() + ", Y1=" + caretY1.ToString());

            foreach (string s in strSN)
            {
                handleCurrent = GetForegroundWindow();

                if (GetWindowText(handleCurrent, strWinTitle, 256) == 0)
                {
                    updateLog("Unknown window!");
                    return;
                }
                else if (strWinTitle.ToString() != ConfigurationManager.AppSettings.Get("windowCounts")
                         && (handleExact != handleCurrent))
                {
                    //since the counts window handle will be changed every serial number so have to ignore its checking.
                    updateLog("Switching window!", false);
                    updateLog("handleExact=" + handleExact.ToString(), false);
                    updateLog("handleCurrent=" + handleCurrent.ToString(), false);
                    updateLog(strWinTitle.ToString(), false);
                    return;
                }

                // get new caret position which should be same X as oringinal one
                getCaretPosition(ref caretX2, ref caretY2);
                updateLog("X2=" + caretX2.ToString() + ", Y2=" + caretY2.ToString());

                if (caretX2 != caretX1)
                {
                    updateLog("Wrong caret!");
                    updateLog("X1=" + caretX1.ToString() + ", Y1=" + caretY1.ToString(), false);
                    updateLog("X2=" + caretX2.ToString() + ", Y2=" + caretY2.ToString(), false);

                    SystemSounds.Beep.Play();

                    SetForegroundWindow(this.Handle);

                    return;
                }

                if (s.Length == 0)
                {
                    continue;
                }

                // emulate by keystrokes
                if (radioTypein.Checked)
                {
                    SendKeys.SendWait(s);
                }
                // emulate by clipboard and paste
                else if (radioPaste.Checked)
                {
                    Clipboard.SetDataObject(s); // send serial number to clipboard
                    SendKeys.SendWait("^(v)");  // send control V to paste
                }
                
                // go to next serial number
                Thread.Sleep(500);
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(2000);

                // inputting for inventory counts only, need an extra enter to active inputting window
                if (radioCounts.Checked)
                {
                    SendKeys.SendWait("{ENTER}");
                    Thread.Sleep(500);
                }

                // moving inputted serial number from oringial box to inputted box
                T_SNdone.AppendText(s + "\r\n");

                if (T_SNinput.Text.Length > T_SNinput.Lines.GetValue(0).ToString().Length) // the last one could be no carriage return
                    T_SNinput.Text = T_SNinput.Text.Remove(0, T_SNinput.Lines.GetValue(0).ToString().Length + 2);
                else
                    T_SNinput.Text = "";
            }

            updateLog("Done!");
        }

        private void updateLog(string s, bool clear=true)
        {
            if (clear)
            {
                tboxLog.Clear();
                tboxLog.AppendText("SN: " + T_SNinput.Lines.Length.ToString() + "\r\n");
                tboxLog.AppendText("---------------------\r\n");
            }

            tboxLog.AppendText(s + "\r\n");
        }

        private void updateLog()
        {
            updateLog("");
        }

        private void T_SNinput_TextChanged(object sender, EventArgs e)
        {
            updateLog();
        }

        //http://msdn.microsoft.com/zh-cn/library/ms171548.aspx
    }
}

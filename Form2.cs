using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduinoilkdeneme
{
    public partial class Form2 : Form
    {
        private delegate int KeyboardHookProc(int code, int wParam, ref KeyboardHookStruct lParam);

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, KeyboardHookProc callback, IntPtr hInstance, uint threadId);

        [DllImport("kernel32.dll")]
        private static extern IntPtr LoadLibrary(string lpFileName);

        [DllImport("user32.dll")]
        private static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref KeyboardHookStruct lParam);

        private readonly IntPtr _hook;

        private struct KeyboardHookStruct
        {
            public int VkCode;
            public int ScanCode;
            public int Flags;
            public int Time;
            public int DwExtraInfo;
        }
        public Form2()
        {
            InitializeComponent();
            var hInstance = LoadLibrary("User32");
            _hook = SetWindowsHookEx(13, HookProc, hInstance, 0);
        }
           
            private int HookProc(int code, int wParam, ref KeyboardHookStruct lParam)
            {
                if (code >= 0 && lParam.Flags == 0)
                {
                    var key = (Keys)lParam.VkCode;
                   label1.Text=key.ToString();
                if(label1.Text=="W") {
                    form1.goder("10","a");
                }
                if (label1.Text == "D")
                {
                    form1.goder("10", "d");
                }
                if (label1.Text == "S")
                {
                    form1.goder("10", "b");
                }
                if (label1.Text == "A")
                {
                    form1.goder("10", "c");
                }

            }
                return CallNextHookEx(_hook, code, wParam, ref lParam);
            }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        Form1 form1 = new Form1();
        private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }

        private void w(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("ömerhann");
        }

        private void g(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("ömerhann");
        }
    }
}

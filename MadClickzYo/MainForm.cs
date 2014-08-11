using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;

namespace MadClickzYo
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private readonly MouseHookListener mouseHook;
        private readonly KeyboardHookListener keyboardHook;
        private System.Timers.Timer timer;

        public MainForm()
        {
            InitializeComponent();
            mouseHook = new MouseHookListener(new GlobalHooker());
            mouseHook.Enabled = true;
            mouseHook.MouseMove += MouseEvent_MouseMove;

            keyboardHook = new KeyboardHookListener(new GlobalHooker());
            keyboardHook.Enabled = true;
            keyboardHook.KeyPress += KeyboardEvent_KeyPress;

        }

        private void KeyboardEvent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 's' && timer.Enabled)
            {
                timer.Stop();
                MessageBox.Show("Clickzy stopped.");
            }
        }

        private void MouseEvent_MouseMove(object sender, MouseEventArgs e)
        {
            txtMouseX.Text = e.X.ToString();
            txtMouseY.Text = e.Y.ToString();
        }

        private void btnClickeroo_Click(object sender, EventArgs e)
        {
            if (timer == null)
            {
                timer = new System.Timers.Timer(Int32.Parse(txtClicksPerSec.Text));
                timer.Elapsed += AutoClickEvent;
            }

            timer.Start();
        }

        private void AutoClickEvent(Object source, ElapsedEventArgs e)
        {
            Cursor.Position = new Point(Int32.Parse(txtClickX.Text), Int32.Parse(txtClickY.Text));
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, UIntPtr.Zero);
        }
    }
}

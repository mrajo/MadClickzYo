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
using WindowsInput;

namespace MadClickzYo
{
    public partial class MainForm : Form
    {
        private InputSimulator input;
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

            input = new InputSimulator();
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
            // getting the InputSimulator to move the mouse to an absolute position on
            // multiple monitors in staggered positions is a pain, so just use Cursor for now
            Cursor.Position = new Point(Int32.Parse(txtClickX.Text), Int32.Parse(txtClickY.Text));
            input.Mouse.LeftButtonClick();
        }
    }
}

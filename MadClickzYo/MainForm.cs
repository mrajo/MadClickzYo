using System;
using System.Drawing;
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
            if (e.KeyChar == 's')
            {
                toggleTimer();
            }

            if (e.KeyChar == 'c')
            {
                captureCoords();
            }
        }

        private void captureCoords()
        {
            txtClickX.Text = Cursor.Position.X.ToString();
            txtClickY.Text = Cursor.Position.Y.ToString();
        }

        private void MouseEvent_MouseMove(object sender, MouseEventArgs e)
        {
            txtMouseX.Text = e.X.ToString();
            txtMouseY.Text = e.Y.ToString();
        }

        private void btnClickeroo_Click(object sender, EventArgs e)
        {
            toggleTimer();
        }

        private void startTimer()
        {
            int x;
            int y;
            int interval;
            bool checkX = Int32.TryParse(txtClickX.Text, out x);
            bool checkY = Int32.TryParse(txtClickY.Text, out y);
            bool checkInterval = Int32.TryParse(txtClickInterval.Text, out interval);

            if (!checkX || !checkY || !checkInterval)
            {
                MessageBox.Show("Parameters must be integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (timer == null)
                {
                    timer = new System.Timers.Timer(Int32.Parse(txtClickInterval.Text));
                    timer.Elapsed += AutoClickEvent;
                }

                timer.Start();
                statusText.Text = "Clicking";
                btnClickeroo.Text = "Stop";
            }
        }

        private void stopTimer()
        {
            if (timer != null && timer.Enabled)
            {
                timer.Stop();
                statusText.Text = "Stopped";
                btnClickeroo.Text = "Start";
            }
        }

        private void toggleTimer()
        {
            if (timer != null && timer.Enabled)
            {
                stopTimer();
            }
            else
            {
                startTimer();
            }
        }

        private void AutoClickEvent(Object source, ElapsedEventArgs e)
        {
            // getting the InputSimulator to move the mouse to an absolute position on
            // multiple monitors in staggered positions is a pain, so just use Cursor for now.
            Cursor.Position = new Point(Int32.Parse(txtClickX.Text), Int32.Parse(txtClickY.Text));
            input.Mouse.LeftButtonClick();
        }
    }
}

using System;
using System.Drawing;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using WindowsInput;

namespace MadClickzYo
{
    public partial class MainForm : Form
    {
        private InputSimulator input;
        private Timer timer;
        private IKeyboardMouseEvents globalHook;
        private bool hooked;

        private const string STATUS_READY = "Ready";
        private const string STATUS_DISABLED = "Disabled";
        private const string STATUS_RUNNING = "Clicking";

        public MainForm()
        {
            InitializeComponent();

            input = new InputSimulator();
            globalHook = Hook.GlobalEvents();
            enableHooks();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            removeHooks();
            globalHook.Dispose();
            base.OnFormClosed(e);
        }

        private void enableHooks()
        {
            globalHook.MouseMove += MouseEvent_MouseMove;
            globalHook.KeyUp += KeyboardEvent_KeyUp;
            statusText.Text = STATUS_READY;
            hooked = true;
        }

        private void removeHooks()
        {
            globalHook.MouseMoveExt -= MouseEvent_MouseMove;
            globalHook.KeyUp -= KeyboardEvent_KeyUp;
        }

        private void toggleHooks()
        {
            hooked = !hooked;
            statusText.Text = STATUS_DISABLED;
        }

        private void captureCoords()
        {
            txtClickX.Text = Cursor.Position.X.ToString();
            txtClickY.Text = Cursor.Position.Y.ToString();
        }

        private void KeyboardEvent_KeyUp(object sender, KeyEventArgs e)
        {
            if (hooked && e.KeyCode == Keys.X)
            {
                toggleTimer();
            }

            if (e.KeyCode == Keys.C)
            {
                captureCoords();
            }

            if (e.KeyCode == Keys.Scroll)
            {
                toggleHooks();
            }
        }

        private void MouseEvent_MouseMove(object sender, MouseEventArgs e)
        {
            if (checkAutoPause.Checked)
            {
                stopTimer();
            }

            txtMouseX.Text = e.X.ToString();
            txtMouseY.Text = e.Y.ToString();
        }


        private void btnClickeroo_Click(object sender, EventArgs e)
        {
            toggleTimer();
        }

        private void startTimer()
        {
            if (checkAutoCapture.Checked)
            {
                captureCoords();
            }

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
                statusText.Text = STATUS_RUNNING;
                btnClickeroo.Text = "Stop";
            }
        }

        private void stopTimer()
        {
            if (timer != null && timer.Enabled)
            {
                timer.Stop();
                statusText.Text = STATUS_READY;
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

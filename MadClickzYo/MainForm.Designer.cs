namespace MadClickzYo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkAutoPause = new System.Windows.Forms.CheckBox();
            this.checkAutoCapture = new System.Windows.Forms.CheckBox();
            this.lblClickCoords = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.txtClickInterval = new System.Windows.Forms.TextBox();
            this.lblMouseCoords = new System.Windows.Forms.Label();
            this.lblClickY = new System.Windows.Forms.Label();
            this.lblMouseY = new System.Windows.Forms.Label();
            this.lblClickX = new System.Windows.Forms.Label();
            this.lblMouseX = new System.Windows.Forms.Label();
            this.txtClickY = new System.Windows.Forms.TextBox();
            this.txtClickX = new System.Windows.Forms.TextBox();
            this.txtMouseY = new System.Windows.Forms.TextBox();
            this.txtMouseX = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpHotKeys = new System.Windows.Forms.GroupBox();
            this.lblHotKeys = new System.Windows.Forms.Label();
            this.statusBar.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpHotKeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText});
            this.statusBar.Location = new System.Drawing.Point(0, 251);
            this.statusBar.Name = "statusBar";
            this.statusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusBar.Size = new System.Drawing.Size(343, 22);
            this.statusBar.TabIndex = 7;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(39, 17);
            this.statusText.Text = "Ready";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(326, 228);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkAutoPause);
            this.tabPage1.Controls.Add(this.checkAutoCapture);
            this.tabPage1.Controls.Add(this.lblClickCoords);
            this.tabPage1.Controls.Add(this.lblInterval);
            this.tabPage1.Controls.Add(this.txtClickInterval);
            this.tabPage1.Controls.Add(this.lblMouseCoords);
            this.tabPage1.Controls.Add(this.lblClickY);
            this.tabPage1.Controls.Add(this.lblMouseY);
            this.tabPage1.Controls.Add(this.lblClickX);
            this.tabPage1.Controls.Add(this.lblMouseX);
            this.tabPage1.Controls.Add(this.txtClickY);
            this.tabPage1.Controls.Add(this.txtClickX);
            this.tabPage1.Controls.Add(this.txtMouseY);
            this.tabPage1.Controls.Add(this.txtMouseX);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(318, 202);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Options";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkAutoPause
            // 
            this.checkAutoPause.AutoSize = true;
            this.checkAutoPause.Checked = true;
            this.checkAutoPause.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAutoPause.Location = new System.Drawing.Point(115, 126);
            this.checkAutoPause.Name = "checkAutoPause";
            this.checkAutoPause.Size = new System.Drawing.Size(178, 17);
            this.checkAutoPause.TabIndex = 27;
            this.checkAutoPause.Text = "Pause Clicking On Mouse Move";
            this.checkAutoPause.UseVisualStyleBackColor = true;
            // 
            // checkAutoCapture
            // 
            this.checkAutoCapture.AutoSize = true;
            this.checkAutoCapture.Checked = true;
            this.checkAutoCapture.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAutoCapture.Location = new System.Drawing.Point(115, 103);
            this.checkAutoCapture.Name = "checkAutoCapture";
            this.checkAutoCapture.Size = new System.Drawing.Size(130, 17);
            this.checkAutoCapture.TabIndex = 26;
            this.checkAutoCapture.Text = "Auto Capture On Start";
            this.checkAutoCapture.UseVisualStyleBackColor = true;
            // 
            // lblClickCoords
            // 
            this.lblClickCoords.AutoSize = true;
            this.lblClickCoords.Location = new System.Drawing.Point(20, 46);
            this.lblClickCoords.Name = "lblClickCoords";
            this.lblClickCoords.Size = new System.Drawing.Size(66, 13);
            this.lblClickCoords.TabIndex = 22;
            this.lblClickCoords.Text = "Click Coords";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(45, 72);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(64, 13);
            this.lblInterval.TabIndex = 23;
            this.lblInterval.Text = "Interval (ms)";
            // 
            // txtClickInterval
            // 
            this.txtClickInterval.Location = new System.Drawing.Point(115, 69);
            this.txtClickInterval.MaxLength = 8;
            this.txtClickInterval.Name = "txtClickInterval";
            this.txtClickInterval.Size = new System.Drawing.Size(46, 20);
            this.txtClickInterval.TabIndex = 24;
            this.txtClickInterval.Text = "100";
            // 
            // lblMouseCoords
            // 
            this.lblMouseCoords.AutoSize = true;
            this.lblMouseCoords.Location = new System.Drawing.Point(11, 20);
            this.lblMouseCoords.Name = "lblMouseCoords";
            this.lblMouseCoords.Size = new System.Drawing.Size(75, 13);
            this.lblMouseCoords.TabIndex = 17;
            this.lblMouseCoords.Text = "Mouse Coords";
            // 
            // lblClickY
            // 
            this.lblClickY.AutoSize = true;
            this.lblClickY.Location = new System.Drawing.Point(173, 46);
            this.lblClickY.Name = "lblClickY";
            this.lblClickY.Size = new System.Drawing.Size(17, 13);
            this.lblClickY.TabIndex = 21;
            this.lblClickY.Text = "Y:";
            // 
            // lblMouseY
            // 
            this.lblMouseY.AutoSize = true;
            this.lblMouseY.Location = new System.Drawing.Point(173, 20);
            this.lblMouseY.Name = "lblMouseY";
            this.lblMouseY.Size = new System.Drawing.Size(17, 13);
            this.lblMouseY.TabIndex = 16;
            this.lblMouseY.Text = "Y:";
            // 
            // lblClickX
            // 
            this.lblClickX.AutoSize = true;
            this.lblClickX.Location = new System.Drawing.Point(92, 46);
            this.lblClickX.Name = "lblClickX";
            this.lblClickX.Size = new System.Drawing.Size(17, 13);
            this.lblClickX.TabIndex = 20;
            this.lblClickX.Text = "X:";
            // 
            // lblMouseX
            // 
            this.lblMouseX.AutoSize = true;
            this.lblMouseX.Location = new System.Drawing.Point(92, 20);
            this.lblMouseX.Name = "lblMouseX";
            this.lblMouseX.Size = new System.Drawing.Size(17, 13);
            this.lblMouseX.TabIndex = 15;
            this.lblMouseX.Text = "X:";
            // 
            // txtClickY
            // 
            this.txtClickY.Location = new System.Drawing.Point(196, 43);
            this.txtClickY.MaxLength = 5;
            this.txtClickY.Name = "txtClickY";
            this.txtClickY.Size = new System.Drawing.Size(46, 20);
            this.txtClickY.TabIndex = 19;
            // 
            // txtClickX
            // 
            this.txtClickX.Location = new System.Drawing.Point(115, 43);
            this.txtClickX.MaxLength = 5;
            this.txtClickX.Name = "txtClickX";
            this.txtClickX.Size = new System.Drawing.Size(46, 20);
            this.txtClickX.TabIndex = 18;
            // 
            // txtMouseY
            // 
            this.txtMouseY.Location = new System.Drawing.Point(196, 17);
            this.txtMouseY.Name = "txtMouseY";
            this.txtMouseY.ReadOnly = true;
            this.txtMouseY.Size = new System.Drawing.Size(46, 20);
            this.txtMouseY.TabIndex = 14;
            // 
            // txtMouseX
            // 
            this.txtMouseX.Location = new System.Drawing.Point(115, 17);
            this.txtMouseX.Name = "txtMouseX";
            this.txtMouseX.ReadOnly = true;
            this.txtMouseX.Size = new System.Drawing.Size(46, 20);
            this.txtMouseX.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpHotKeys);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(318, 202);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Instructions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpHotKeys
            // 
            this.grpHotKeys.Controls.Add(this.lblHotKeys);
            this.grpHotKeys.Location = new System.Drawing.Point(6, 6);
            this.grpHotKeys.Name = "grpHotKeys";
            this.grpHotKeys.Size = new System.Drawing.Size(306, 68);
            this.grpHotKeys.TabIndex = 7;
            this.grpHotKeys.TabStop = false;
            this.grpHotKeys.Text = "HotKeys.";
            // 
            // lblHotKeys
            // 
            this.lblHotKeys.Location = new System.Drawing.Point(6, 16);
            this.lblHotKeys.Name = "lblHotKeys";
            this.lblHotKeys.Size = new System.Drawing.Size(221, 45);
            this.lblHotKeys.TabIndex = 0;
            this.lblHotKeys.Text = "X - start/stop clicking\r\nC - capture current mouse position\r\nScroll Lock - toggle" +
    "s X and C keyboard hook";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 273);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.statusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MadClickzYo";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grpHotKeys.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkAutoCapture;
        private System.Windows.Forms.Label lblClickCoords;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.TextBox txtClickInterval;
        private System.Windows.Forms.Label lblMouseCoords;
        private System.Windows.Forms.Label lblClickY;
        private System.Windows.Forms.Label lblMouseY;
        private System.Windows.Forms.Label lblClickX;
        private System.Windows.Forms.Label lblMouseX;
        private System.Windows.Forms.TextBox txtClickY;
        private System.Windows.Forms.TextBox txtClickX;
        private System.Windows.Forms.TextBox txtMouseY;
        private System.Windows.Forms.TextBox txtMouseX;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpHotKeys;
        private System.Windows.Forms.Label lblHotKeys;
        private System.Windows.Forms.CheckBox checkAutoPause;
    }
}


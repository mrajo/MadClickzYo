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
            this.txtMouseX = new System.Windows.Forms.TextBox();
            this.txtMouseY = new System.Windows.Forms.TextBox();
            this.lblMouseX = new System.Windows.Forms.Label();
            this.lblMouseY = new System.Windows.Forms.Label();
            this.lblMouseCoords = new System.Windows.Forms.Label();
            this.grpClick = new System.Windows.Forms.GroupBox();
            this.btnClickeroo = new System.Windows.Forms.Button();
            this.txtClickInterval = new System.Windows.Forms.TextBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblClickY = new System.Windows.Forms.Label();
            this.lblClickX = new System.Windows.Forms.Label();
            this.txtClickY = new System.Windows.Forms.TextBox();
            this.txtClickX = new System.Windows.Forms.TextBox();
            this.grpClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMouseX
            // 
            this.txtMouseX.Location = new System.Drawing.Point(138, 12);
            this.txtMouseX.Name = "txtMouseX";
            this.txtMouseX.ReadOnly = true;
            this.txtMouseX.Size = new System.Drawing.Size(46, 20);
            this.txtMouseX.TabIndex = 1;
            // 
            // txtMouseY
            // 
            this.txtMouseY.Location = new System.Drawing.Point(219, 12);
            this.txtMouseY.Name = "txtMouseY";
            this.txtMouseY.ReadOnly = true;
            this.txtMouseY.Size = new System.Drawing.Size(46, 20);
            this.txtMouseY.TabIndex = 2;
            // 
            // lblMouseX
            // 
            this.lblMouseX.AutoSize = true;
            this.lblMouseX.Location = new System.Drawing.Point(115, 15);
            this.lblMouseX.Name = "lblMouseX";
            this.lblMouseX.Size = new System.Drawing.Size(17, 13);
            this.lblMouseX.TabIndex = 3;
            this.lblMouseX.Text = "X:";
            // 
            // lblMouseY
            // 
            this.lblMouseY.AutoSize = true;
            this.lblMouseY.Location = new System.Drawing.Point(196, 15);
            this.lblMouseY.Name = "lblMouseY";
            this.lblMouseY.Size = new System.Drawing.Size(17, 13);
            this.lblMouseY.TabIndex = 4;
            this.lblMouseY.Text = "Y:";
            // 
            // lblMouseCoords
            // 
            this.lblMouseCoords.AutoSize = true;
            this.lblMouseCoords.Location = new System.Drawing.Point(34, 15);
            this.lblMouseCoords.Name = "lblMouseCoords";
            this.lblMouseCoords.Size = new System.Drawing.Size(75, 13);
            this.lblMouseCoords.TabIndex = 5;
            this.lblMouseCoords.Text = "Mouse Coords";
            // 
            // grpClick
            // 
            this.grpClick.Controls.Add(this.btnClickeroo);
            this.grpClick.Controls.Add(this.txtClickInterval);
            this.grpClick.Controls.Add(this.lblInterval);
            this.grpClick.Controls.Add(this.lblClickY);
            this.grpClick.Controls.Add(this.lblClickX);
            this.grpClick.Controls.Add(this.txtClickY);
            this.grpClick.Controls.Add(this.txtClickX);
            this.grpClick.Location = new System.Drawing.Point(20, 59);
            this.grpClick.Name = "grpClick";
            this.grpClick.Size = new System.Drawing.Size(244, 156);
            this.grpClick.TabIndex = 6;
            this.grpClick.TabStop = false;
            this.grpClick.Text = "Click Parameters";
            // 
            // btnClickeroo
            // 
            this.btnClickeroo.Location = new System.Drawing.Point(94, 114);
            this.btnClickeroo.Name = "btnClickeroo";
            this.btnClickeroo.Size = new System.Drawing.Size(99, 27);
            this.btnClickeroo.TabIndex = 11;
            this.btnClickeroo.Text = "Start Clicking";
            this.btnClickeroo.UseVisualStyleBackColor = true;
            this.btnClickeroo.Click += new System.EventHandler(this.btnClickeroo_Click);
            // 
            // txtClickInterval
            // 
            this.txtClickInterval.Location = new System.Drawing.Point(147, 71);
            this.txtClickInterval.Name = "txtClickInterval";
            this.txtClickInterval.Size = new System.Drawing.Size(46, 20);
            this.txtClickInterval.TabIndex = 10;
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(99, 74);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(42, 13);
            this.lblInterval.TabIndex = 9;
            this.lblInterval.Text = "Interval";
            // 
            // lblClickY
            // 
            this.lblClickY.AutoSize = true;
            this.lblClickY.Location = new System.Drawing.Point(124, 31);
            this.lblClickY.Name = "lblClickY";
            this.lblClickY.Size = new System.Drawing.Size(17, 13);
            this.lblClickY.TabIndex = 8;
            this.lblClickY.Text = "Y:";
            // 
            // lblClickX
            // 
            this.lblClickX.AutoSize = true;
            this.lblClickX.Location = new System.Drawing.Point(43, 31);
            this.lblClickX.Name = "lblClickX";
            this.lblClickX.Size = new System.Drawing.Size(17, 13);
            this.lblClickX.TabIndex = 7;
            this.lblClickX.Text = "X:";
            // 
            // txtClickY
            // 
            this.txtClickY.Location = new System.Drawing.Point(147, 28);
            this.txtClickY.Name = "txtClickY";
            this.txtClickY.Size = new System.Drawing.Size(46, 20);
            this.txtClickY.TabIndex = 6;
            // 
            // txtClickX
            // 
            this.txtClickX.Location = new System.Drawing.Point(66, 28);
            this.txtClickX.Name = "txtClickX";
            this.txtClickX.Size = new System.Drawing.Size(46, 20);
            this.txtClickX.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 232);
            this.Controls.Add(this.grpClick);
            this.Controls.Add(this.lblMouseCoords);
            this.Controls.Add(this.lblMouseY);
            this.Controls.Add(this.lblMouseX);
            this.Controls.Add(this.txtMouseY);
            this.Controls.Add(this.txtMouseX);
            this.Name = "MainForm";
            this.Text = "Clickzy";
            this.grpClick.ResumeLayout(false);
            this.grpClick.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMouseX;
        private System.Windows.Forms.TextBox txtMouseY;
        private System.Windows.Forms.Label lblMouseX;
        private System.Windows.Forms.Label lblMouseY;
        private System.Windows.Forms.Label lblMouseCoords;
        private System.Windows.Forms.GroupBox grpClick;
        private System.Windows.Forms.Button btnClickeroo;
        private System.Windows.Forms.TextBox txtClickInterval;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblClickY;
        private System.Windows.Forms.Label lblClickX;
        private System.Windows.Forms.TextBox txtClickY;
        private System.Windows.Forms.TextBox txtClickX;
    }
}


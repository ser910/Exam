using System.Windows.Forms;
namespace Menu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTimer = new System.Windows.Forms.ToolStripDropDownButton();
            this.startStopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSpeed = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripAngle = new System.Windows.Forms.ToolStripDropDownButton();
            this.paintButton1 = new Menu.PaintButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitFile,
            this.toolStripTimer,
            this.toolStripSpeed,
            this.toolStripAngle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(292, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitFile
            // 
            this.toolStripSplitFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.toolStripSplitFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitFile.Image")));
            this.toolStripSplitFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitFile.Name = "toolStripSplitFile";
            this.toolStripSplitFile.Size = new System.Drawing.Size(38, 22);
            this.toolStripSplitFile.Text = "&File";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            // 
            // toolStripTimer
            // 
            this.toolStripTimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripTimer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startStopToolStripMenuItem1});
            this.toolStripTimer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripTimer.Image")));
            this.toolStripTimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripTimer.Name = "toolStripTimer";
            this.toolStripTimer.Size = new System.Drawing.Size(48, 22);
            this.toolStripTimer.Text = "timer";
            // 
            // startStopToolStripMenuItem1
            // 
            this.startStopToolStripMenuItem1.Name = "startStopToolStripMenuItem1";
            this.startStopToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.startStopToolStripMenuItem1.Text = "Start/Stop";
            this.startStopToolStripMenuItem1.Click += new System.EventHandler(this.startStopToolStripMenuItem1_Click);
            // 
            // toolStripSpeed
            // 
            this.toolStripSpeed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSpeed.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSpeed.Image")));
            this.toolStripSpeed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSpeed.Name = "toolStripSpeed";
            this.toolStripSpeed.Size = new System.Drawing.Size(52, 22);
            this.toolStripSpeed.Text = "Speed";
            this.toolStripSpeed.ToolTipText = "Speed";
            // 
            // toolStripAngle
            // 
            this.toolStripAngle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripAngle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAngle.Image")));
            this.toolStripAngle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAngle.Name = "toolStripAngle";
            this.toolStripAngle.Size = new System.Drawing.Size(51, 22);
            this.toolStripAngle.Text = "Angle";
            // 
            // paintButton1
            // 
            this.paintButton1.Location = new System.Drawing.Point(125, 120);
            this.paintButton1.Name = "paintButton1";
            this.paintButton1.Size = new System.Drawing.Size(23, 23);
            this.paintButton1.TabIndex = 3;
            this.paintButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 269);
            this.Controls.Add(this.paintButton1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripSplitFile;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripDropDownButton toolStripTimer;
        private ToolStripMenuItem startStopToolStripMenuItem1;
        private ToolStripDropDownButton toolStripSpeed;
        private ToolStripDropDownButton toolStripAngle;
        private PaintButton paintButton1;
    }
}


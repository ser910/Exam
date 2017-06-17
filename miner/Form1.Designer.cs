namespace miner
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
            this.label1 = new System.Windows.Forms.Label();
            this.Avtosave = new System.Windows.Forms.CheckBox();
            this.buttonLevel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00:0000";
            // 
            // Avtosave
            // 
            this.Avtosave.AutoSize = true;
            this.Avtosave.Checked = true;
            this.Avtosave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Avtosave.Location = new System.Drawing.Point(12, 12);
            this.Avtosave.Name = "Avtosave";
            this.Avtosave.Size = new System.Drawing.Size(70, 18);
            this.Avtosave.TabIndex = 1;
            this.Avtosave.Text = "Autosave";
            this.Avtosave.UseCompatibleTextRendering = true;
            this.Avtosave.UseVisualStyleBackColor = true;
            // 
            // buttonLevel
            // 
            this.buttonLevel.Location = new System.Drawing.Point(88, 9);
            this.buttonLevel.Name = "buttonLevel";
            this.buttonLevel.Size = new System.Drawing.Size(75, 23);
            this.buttonLevel.TabIndex = 2;
            this.buttonLevel.Text = "Set Level";
            this.buttonLevel.UseVisualStyleBackColor = true;
            this.buttonLevel.Click += new System.EventHandler(this.buttonLevel_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 293);
            this.Controls.Add(this.buttonLevel);
            this.Controls.Add(this.Avtosave);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "miner 2.3.2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Avtosave;
        private System.Windows.Forms.Button buttonLevel;
        private System.Windows.Forms.Timer timer1;



    }
}


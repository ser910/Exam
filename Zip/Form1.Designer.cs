namespace Zip
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonNewZip = new System.Windows.Forms.Button();
            this.buttonLoadZip = new System.Windows.Forms.Button();
            this.listBoxDir = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxSel = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelZip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonNewZip
            // 
            this.buttonNewZip.Location = new System.Drawing.Point(139, 12);
            this.buttonNewZip.Name = "buttonNewZip";
            this.buttonNewZip.Size = new System.Drawing.Size(75, 23);
            this.buttonNewZip.TabIndex = 1;
            this.buttonNewZip.Text = "New";
            this.buttonNewZip.UseVisualStyleBackColor = true;
            this.buttonNewZip.Click += new System.EventHandler(this.buttonNewZip_Click);
            // 
            // buttonLoadZip
            // 
            this.buttonLoadZip.Location = new System.Drawing.Point(220, 12);
            this.buttonLoadZip.Name = "buttonLoadZip";
            this.buttonLoadZip.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadZip.TabIndex = 2;
            this.buttonLoadZip.Text = "Load";
            this.buttonLoadZip.UseVisualStyleBackColor = true;
            this.buttonLoadZip.Click += new System.EventHandler(this.buttonLoadZip_Click);
            // 
            // listBoxDir
            // 
            this.listBoxDir.FormattingEnabled = true;
            this.listBoxDir.Location = new System.Drawing.Point(12, 52);
            this.listBoxDir.Name = "listBoxDir";
            this.listBoxDir.Size = new System.Drawing.Size(100, 160);
            this.listBoxDir.TabIndex = 3;
            this.listBoxDir.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxDir_MouseDoubleClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(118, 103);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(39, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = ">>";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(118, 160);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(39, 23);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "<<";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(186, 234);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // listBoxSel
            // 
            this.listBoxSel.FormattingEnabled = true;
            this.listBoxSel.Location = new System.Drawing.Point(186, 52);
            this.listBoxSel.Name = "listBoxSel";
            this.listBoxSel.Size = new System.Drawing.Size(100, 160);
            this.listBoxSel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Location = new System.Drawing.Point(150, 36);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(0, 13);
            this.labelZip.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 269);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxDir);
            this.Controls.Add(this.buttonLoadZip);
            this.Controls.Add(this.buttonNewZip);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonNewZip;
        private System.Windows.Forms.Button buttonLoadZip;
        private System.Windows.Forms.ListBox listBoxDir;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxSel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelZip;
    }
}


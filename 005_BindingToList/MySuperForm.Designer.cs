namespace BindSourse
{
    partial class MySuperForm
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
            this.bindingsComboBox = new System.Windows.Forms.ComboBox();
            this.bindingsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bindingsComboBox
            // 
            this.bindingsComboBox.FormattingEnabled = true;
            this.bindingsComboBox.Location = new System.Drawing.Point(13, 13);
            this.bindingsComboBox.Name = "bindingsComboBox";
            this.bindingsComboBox.Size = new System.Drawing.Size(121, 21);
            this.bindingsComboBox.TabIndex = 0;
            // 
            // bindingsListBox
            // 
            this.bindingsListBox.FormattingEnabled = true;
            this.bindingsListBox.Location = new System.Drawing.Point(13, 41);
            this.bindingsListBox.Name = "bindingsListBox";
            this.bindingsListBox.Size = new System.Drawing.Size(277, 173);
            this.bindingsListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(340, 13);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(65, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(340, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(65, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(340, 76);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(65, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(340, 115);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(65, 23);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(340, 153);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(65, 23);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // MySuperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 340);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingsListBox);
            this.Controls.Add(this.bindingsComboBox);
            this.Name = "MySuperForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bindingsComboBox;
        private System.Windows.Forms.ListBox bindingsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonUpdate;
    }
}


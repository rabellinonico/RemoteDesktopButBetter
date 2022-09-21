namespace RemoteDesktopButBetter
{
    partial class ReorderListComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReorderListComponent));
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListBoxOrderable = new System.Windows.Forms.ListBox();
            this.ButtonRowUp = new System.Windows.Forms.Button();
            this.ButtonRowDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(216, 181);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(106, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Items";
            // 
            // ListBoxOrderable
            // 
            this.ListBoxOrderable.FormattingEnabled = true;
            this.ListBoxOrderable.ItemHeight = 15;
            this.ListBoxOrderable.Location = new System.Drawing.Point(12, 27);
            this.ListBoxOrderable.Name = "ListBoxOrderable";
            this.ListBoxOrderable.Size = new System.Drawing.Size(310, 139);
            this.ListBoxOrderable.TabIndex = 2;
            // 
            // ButtonRowUp
            // 
            this.ButtonRowUp.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRowUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonRowUp.BackgroundImage")));
            this.ButtonRowUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonRowUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRowUp.Location = new System.Drawing.Point(328, 27);
            this.ButtonRowUp.Name = "ButtonRowUp";
            this.ButtonRowUp.Size = new System.Drawing.Size(25, 25);
            this.ButtonRowUp.TabIndex = 13;
            this.ButtonRowUp.UseVisualStyleBackColor = false;
            this.ButtonRowUp.Click += new System.EventHandler(this.ButtonRowUp_Click);
            // 
            // ButtonRowDown
            // 
            this.ButtonRowDown.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRowDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonRowDown.BackgroundImage")));
            this.ButtonRowDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonRowDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRowDown.Location = new System.Drawing.Point(328, 58);
            this.ButtonRowDown.Name = "ButtonRowDown";
            this.ButtonRowDown.Size = new System.Drawing.Size(25, 25);
            this.ButtonRowDown.TabIndex = 14;
            this.ButtonRowDown.UseVisualStyleBackColor = false;
            this.ButtonRowDown.Click += new System.EventHandler(this.ButtonRowDown_Click);
            // 
            // ReorderListComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 218);
            this.Controls.Add(this.ButtonRowDown);
            this.Controls.Add(this.ButtonRowUp);
            this.Controls.Add(this.ListBoxOrderable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Name = "ReorderListComponent";
            this.Text = "Reorder list";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SaveButton;
        private Label label1;
        private ListBox ListBoxOrderable;
        private Button ButtonRowUp;
        private Button ButtonRowDown;
    }
}
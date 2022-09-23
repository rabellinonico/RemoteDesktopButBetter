
namespace RemoteDesktopButBetter
{
    partial class InitialForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialForm));
            this.ComboBoxGroups = new System.Windows.Forms.ComboBox();
            this.ComboBoxServers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonAvvioRemoteDesktop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonAddServer = new System.Windows.Forms.Button();
            this.ButtonRemoveServer = new System.Windows.Forms.Button();
            this.ButtonRemoveGroup = new System.Windows.Forms.Button();
            this.ButtonAddGroup = new System.Windows.Forms.Button();
            this.ButtonReorderGroups = new System.Windows.Forms.Button();
            this.ButtonReorderServers = new System.Windows.Forms.Button();
            this.ButtonEditGroup = new System.Windows.Forms.Button();
            this.ButtonEditServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxGroups
            // 
            this.ComboBoxGroups.DisplayMember = "Name";
            this.ComboBoxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGroups.Enabled = false;
            this.ComboBoxGroups.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxGroups.FormattingEnabled = true;
            this.ComboBoxGroups.Location = new System.Drawing.Point(12, 51);
            this.ComboBoxGroups.Name = "ComboBoxGroups";
            this.ComboBoxGroups.Size = new System.Drawing.Size(250, 25);
            this.ComboBoxGroups.TabIndex = 0;
            this.ComboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGroup_SelectedIndexChanged);
            // 
            // ComboBoxServers
            // 
            this.ComboBoxServers.DisplayMember = "Fullname";
            this.ComboBoxServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxServers.Enabled = false;
            this.ComboBoxServers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxServers.FormattingEnabled = true;
            this.ComboBoxServers.Location = new System.Drawing.Point(12, 101);
            this.ComboBoxServers.Name = "ComboBoxServers";
            this.ComboBoxServers.Size = new System.Drawing.Size(250, 25);
            this.ComboBoxServers.TabIndex = 1;
            this.ComboBoxServers.SelectedIndexChanged += new System.EventHandler(this.ComboBoxServers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(103, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Remote Desktop But Better";
            // 
            // ButtonAvvioRemoteDesktop
            // 
            this.ButtonAvvioRemoteDesktop.Enabled = false;
            this.ButtonAvvioRemoteDesktop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonAvvioRemoteDesktop.Location = new System.Drawing.Point(86, 136);
            this.ButtonAvvioRemoteDesktop.Name = "ButtonAvvioRemoteDesktop";
            this.ButtonAvvioRemoteDesktop.Size = new System.Drawing.Size(230, 72);
            this.ButtonAvvioRemoteDesktop.TabIndex = 5;
            this.ButtonAvvioRemoteDesktop.Text = "Connect";
            this.ButtonAvvioRemoteDesktop.UseVisualStyleBackColor = true;
            this.ButtonAvvioRemoteDesktop.Click += new System.EventHandler(this.ButtonAvvioRemoteDesktop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(135, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Copyright © 2022 - Nicolò Rabellino. All Rights Reserved";
            // 
            // ButtonAddServer
            // 
            this.ButtonAddServer.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAddServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonAddServer.BackgroundImage")));
            this.ButtonAddServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAddServer.Enabled = false;
            this.ButtonAddServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddServer.Location = new System.Drawing.Point(268, 101);
            this.ButtonAddServer.Name = "ButtonAddServer";
            this.ButtonAddServer.Size = new System.Drawing.Size(25, 25);
            this.ButtonAddServer.TabIndex = 9;
            this.ButtonAddServer.UseVisualStyleBackColor = false;
            this.ButtonAddServer.Click += new System.EventHandler(this.ButtonAddServer_Click);
            // 
            // ButtonRemoveServer
            // 
            this.ButtonRemoveServer.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRemoveServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonRemoveServer.BackgroundImage")));
            this.ButtonRemoveServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonRemoveServer.Enabled = false;
            this.ButtonRemoveServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveServer.Location = new System.Drawing.Point(361, 101);
            this.ButtonRemoveServer.Name = "ButtonRemoveServer";
            this.ButtonRemoveServer.Size = new System.Drawing.Size(25, 25);
            this.ButtonRemoveServer.TabIndex = 11;
            this.ButtonRemoveServer.UseVisualStyleBackColor = false;
            this.ButtonRemoveServer.Click += new System.EventHandler(this.ButtonRemoveServer_Click);
            // 
            // ButtonRemoveGroup
            // 
            this.ButtonRemoveGroup.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRemoveGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonRemoveGroup.BackgroundImage")));
            this.ButtonRemoveGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonRemoveGroup.Enabled = false;
            this.ButtonRemoveGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveGroup.Location = new System.Drawing.Point(361, 51);
            this.ButtonRemoveGroup.Name = "ButtonRemoveGroup";
            this.ButtonRemoveGroup.Size = new System.Drawing.Size(25, 25);
            this.ButtonRemoveGroup.TabIndex = 14;
            this.ButtonRemoveGroup.UseVisualStyleBackColor = false;
            this.ButtonRemoveGroup.Click += new System.EventHandler(this.ButtonRemoveGroup_Click);
            // 
            // ButtonAddGroup
            // 
            this.ButtonAddGroup.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAddGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonAddGroup.BackgroundImage")));
            this.ButtonAddGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddGroup.Location = new System.Drawing.Point(268, 51);
            this.ButtonAddGroup.Name = "ButtonAddGroup";
            this.ButtonAddGroup.Size = new System.Drawing.Size(25, 25);
            this.ButtonAddGroup.TabIndex = 12;
            this.ButtonAddGroup.UseVisualStyleBackColor = false;
            this.ButtonAddGroup.Click += new System.EventHandler(this.ButtonAddGroup_Click);
            // 
            // ButtonReorderGroups
            // 
            this.ButtonReorderGroups.BackColor = System.Drawing.Color.Transparent;
            this.ButtonReorderGroups.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonReorderGroups.BackgroundImage")));
            this.ButtonReorderGroups.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonReorderGroups.Enabled = false;
            this.ButtonReorderGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReorderGroups.Location = new System.Drawing.Point(330, 51);
            this.ButtonReorderGroups.Name = "ButtonReorderGroups";
            this.ButtonReorderGroups.Size = new System.Drawing.Size(25, 25);
            this.ButtonReorderGroups.TabIndex = 16;
            this.ButtonReorderGroups.UseVisualStyleBackColor = false;
            this.ButtonReorderGroups.Click += new System.EventHandler(this.ButtonReorderGroups_Click);
            // 
            // ButtonReorderServers
            // 
            this.ButtonReorderServers.BackColor = System.Drawing.Color.Transparent;
            this.ButtonReorderServers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonReorderServers.BackgroundImage")));
            this.ButtonReorderServers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonReorderServers.Enabled = false;
            this.ButtonReorderServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReorderServers.Location = new System.Drawing.Point(330, 101);
            this.ButtonReorderServers.Name = "ButtonReorderServers";
            this.ButtonReorderServers.Size = new System.Drawing.Size(25, 25);
            this.ButtonReorderServers.TabIndex = 17;
            this.ButtonReorderServers.UseVisualStyleBackColor = false;
            this.ButtonReorderServers.Click += new System.EventHandler(this.ButtonReorderServers_Click);
            // 
            // ButtonEditGroup
            // 
            this.ButtonEditGroup.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEditGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEditGroup.BackgroundImage")));
            this.ButtonEditGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonEditGroup.Enabled = false;
            this.ButtonEditGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditGroup.Location = new System.Drawing.Point(299, 51);
            this.ButtonEditGroup.Name = "ButtonEditGroup";
            this.ButtonEditGroup.Size = new System.Drawing.Size(25, 25);
            this.ButtonEditGroup.TabIndex = 18;
            this.ButtonEditGroup.UseVisualStyleBackColor = false;
            this.ButtonEditGroup.Click += new System.EventHandler(this.ButtonEditGroup_Click);
            // 
            // ButtonEditServer
            // 
            this.ButtonEditServer.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEditServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEditServer.BackgroundImage")));
            this.ButtonEditServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonEditServer.Enabled = false;
            this.ButtonEditServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditServer.Location = new System.Drawing.Point(299, 101);
            this.ButtonEditServer.Name = "ButtonEditServer";
            this.ButtonEditServer.Size = new System.Drawing.Size(25, 25);
            this.ButtonEditServer.TabIndex = 19;
            this.ButtonEditServer.UseVisualStyleBackColor = false;
            this.ButtonEditServer.Click += new System.EventHandler(this.ButtonEditServer_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 234);
            this.Controls.Add(this.ComboBoxServers);
            this.Controls.Add(this.ButtonEditServer);
            this.Controls.Add(this.ButtonEditGroup);
            this.Controls.Add(this.ButtonReorderServers);
            this.Controls.Add(this.ButtonReorderGroups);
            this.Controls.Add(this.ButtonRemoveGroup);
            this.Controls.Add(this.ButtonAddGroup);
            this.Controls.Add(this.ButtonRemoveServer);
            this.Controls.Add(this.ButtonAddServer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonAvvioRemoteDesktop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InitialForm";
            this.Text = "RDBB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxGroups;
        private System.Windows.Forms.ComboBox ComboBoxServers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonAvvioRemoteDesktop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonAddServer;
        private System.Windows.Forms.Button ButtonRemoveServer;
        private System.Windows.Forms.Button ButtonRemoveGroup;
        private System.Windows.Forms.Button ButtonAddGroup;
        private Button ButtonReorderGroups;
        private Button ButtonReorderServers;
        private Button ButtonEditGroup;
        private Button ButtonEditServer;
    }
}


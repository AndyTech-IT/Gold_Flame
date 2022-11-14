namespace Gold_Flame
{
    partial class Form1
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
            this.Add_Player = new System.Windows.Forms.Button();
            this.TouglleServer = new System.Windows.Forms.Button();
            this.ServerTitle_TB = new System.Windows.Forms.TextBox();
            this.Refresh_Servers = new System.Windows.Forms.Button();
            this.Servers_LV = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Add_Player
            // 
            this.Add_Player.Location = new System.Drawing.Point(627, 415);
            this.Add_Player.Name = "Add_Player";
            this.Add_Player.Size = new System.Drawing.Size(161, 23);
            this.Add_Player.TabIndex = 0;
            this.Add_Player.Text = "Новый игрок";
            this.Add_Player.UseVisualStyleBackColor = true;
            this.Add_Player.Click += new System.EventHandler(this.Add_Player_Click);
            // 
            // TouglleServer
            // 
            this.TouglleServer.Location = new System.Drawing.Point(627, 386);
            this.TouglleServer.Name = "TouglleServer";
            this.TouglleServer.Size = new System.Drawing.Size(161, 23);
            this.TouglleServer.TabIndex = 1;
            this.TouglleServer.Text = "Включить сервер";
            this.TouglleServer.UseVisualStyleBackColor = true;
            this.TouglleServer.Click += new System.EventHandler(this.TouglleServer_Click);
            // 
            // ServerTitle_TB
            // 
            this.ServerTitle_TB.Location = new System.Drawing.Point(627, 357);
            this.ServerTitle_TB.Name = "ServerTitle_TB";
            this.ServerTitle_TB.Size = new System.Drawing.Size(161, 23);
            this.ServerTitle_TB.TabIndex = 2;
            this.ServerTitle_TB.Text = "Server";
            this.ServerTitle_TB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ServerTitle_TB_KeyUp);
            this.ServerTitle_TB.Leave += new System.EventHandler(this.ServerTitle_TB_Leave);
            // 
            // Refresh_Servers
            // 
            this.Refresh_Servers.Location = new System.Drawing.Point(713, 12);
            this.Refresh_Servers.Name = "Refresh_Servers";
            this.Refresh_Servers.Size = new System.Drawing.Size(75, 23);
            this.Refresh_Servers.TabIndex = 3;
            this.Refresh_Servers.Text = "Refresh";
            this.Refresh_Servers.UseVisualStyleBackColor = true;
            this.Refresh_Servers.Click += new System.EventHandler(this.Refresh_Servers_Click);
            // 
            // Servers_LV
            // 
            this.Servers_LV.FullRowSelect = true;
            this.Servers_LV.GridLines = true;
            this.Servers_LV.Location = new System.Drawing.Point(519, 41);
            this.Servers_LV.Name = "Servers_LV";
            this.Servers_LV.Size = new System.Drawing.Size(269, 310);
            this.Servers_LV.TabIndex = 4;
            this.Servers_LV.UseCompatibleStateImageBehavior = false;
            this.Servers_LV.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Servers_LV);
            this.Controls.Add(this.Refresh_Servers);
            this.Controls.Add(this.ServerTitle_TB);
            this.Controls.Add(this.TouglleServer);
            this.Controls.Add(this.Add_Player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Add_Player;
        private Button TouglleServer;
        private TextBox ServerTitle_TB;
        private Button Refresh_Servers;
        private ListView Servers_LV;
    }
}
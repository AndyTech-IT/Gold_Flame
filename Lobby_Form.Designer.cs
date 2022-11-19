namespace Gold_Flame
{
    partial class Lobby_Form
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
            System.Windows.Forms.Button Enter_B;
            System.Windows.Forms.Button Host_B;
            System.Windows.Forms.Button Refresh_B;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "255.255.255.255",
            "2",
            "4"}, -1);
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.ColumnHeader columnHeader3;
            System.Windows.Forms.ColumnHeader columnHeader4;
            this.Rooms_LV = new System.Windows.Forms.ListView();
            Enter_B = new System.Windows.Forms.Button();
            Host_B = new System.Windows.Forms.Button();
            Refresh_B = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enter_B
            // 
            Enter_B.Anchor = System.Windows.Forms.AnchorStyles.None;
            Enter_B.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Enter_B.Location = new System.Drawing.Point(147, 405);
            Enter_B.Name = "Enter_B";
            Enter_B.Size = new System.Drawing.Size(184, 38);
            Enter_B.TabIndex = 1;
            Enter_B.Text = "Войти в комнату";
            Enter_B.UseVisualStyleBackColor = true;
            Enter_B.Click += new System.EventHandler(this.Enter_B_Click);
            // 
            // Host_B
            // 
            Host_B.Anchor = System.Windows.Forms.AnchorStyles.None;
            Host_B.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Host_B.Location = new System.Drawing.Point(347, 405);
            Host_B.Name = "Host_B";
            Host_B.Size = new System.Drawing.Size(115, 38);
            Host_B.TabIndex = 3;
            Host_B.Text = "Создать";
            Host_B.UseVisualStyleBackColor = true;
            Host_B.Click += new System.EventHandler(this.Host_B_Click);
            // 
            // Refresh_B
            // 
            Refresh_B.Anchor = System.Windows.Forms.AnchorStyles.None;
            Refresh_B.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Refresh_B.Location = new System.Drawing.Point(11, 405);
            Refresh_B.Name = "Refresh_B";
            Refresh_B.Size = new System.Drawing.Size(115, 38);
            Refresh_B.TabIndex = 2;
            Refresh_B.Text = "Обновить";
            Refresh_B.UseVisualStyleBackColor = true;
            Refresh_B.Click += new System.EventHandler(this.Refresh_B_Click);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            tableLayoutPanel1.Controls.Add(Host_B, 2, 1);
            tableLayoutPanel1.Controls.Add(Refresh_B, 0, 1);
            tableLayoutPanel1.Controls.Add(this.Rooms_LV, 0, 0);
            tableLayoutPanel1.Controls.Add(Enter_B, 1, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.28571F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            tableLayoutPanel1.Size = new System.Drawing.Size(469, 448);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // Rooms_LV
            // 
            this.Rooms_LV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rooms_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3,
            columnHeader4});
            tableLayoutPanel1.SetColumnSpan(this.Rooms_LV, 3);
            this.Rooms_LV.FullRowSelect = true;
            this.Rooms_LV.GridLines = true;
            this.Rooms_LV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Rooms_LV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.Rooms_LV.Location = new System.Drawing.Point(12, 13);
            this.Rooms_LV.MultiSelect = false;
            this.Rooms_LV.Name = "Rooms_LV";
            this.Rooms_LV.Size = new System.Drawing.Size(444, 373);
            this.Rooms_LV.TabIndex = 0;
            this.Rooms_LV.UseCompatibleStateImageBehavior = false;
            this.Rooms_LV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Комната";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Адресс";
            columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Онлайн";
            columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Max";
            columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lobby_Form
            // 
            this.AcceptButton = Enter_B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 448);
            this.Controls.Add(tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Lobby_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список комнат";
            this.Load += new System.EventHandler(this.Lobby_Form_Load);
            tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView Rooms_LV;
    }
}
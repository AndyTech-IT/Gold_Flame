namespace Gold_Flame
{
    partial class Room_Form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.player_Hand1 = new Gold_Flame.Player_Hand();
            this.player_Hand2 = new Gold_Flame.Player_Hand();
            this.player_Hand3 = new Gold_Flame.Player_Hand();
            this.player_Hand4 = new Gold_Flame.Player_Hand();
            this.player_Hand5 = new Gold_Flame.Player_Hand();
            this.cards_Table1 = new Gold_Flame.Cards_Table();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.player_Hand1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.player_Hand2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.player_Hand3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.player_Hand4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.player_Hand5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cards_Table1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1015, 628);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // player_Hand1
            // 
            this.player_Hand1.Active_Cards = new string[] {
        "Test",
        "Test",
        "Test1"};
            this.player_Hand1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player_Hand1.FirstMove = true;
            this.player_Hand1.Invert = false;
            this.player_Hand1.Location = new System.Drawing.Point(679, 421);
            this.player_Hand1.Login = "Login1";
            this.player_Hand1.Name = "player_Hand1";
            this.player_Hand1.Passive_Cards = new string[] {
        "Test",
        "test"};
            this.player_Hand1.Power_Score = 10;
            this.player_Hand1.Size = new System.Drawing.Size(333, 204);
            this.player_Hand1.TabIndex = 0;
            // 
            // player_Hand2
            // 
            this.player_Hand2.Active_Cards = new string[0];
            this.player_Hand2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player_Hand2.FirstMove = false;
            this.player_Hand2.Invert = false;
            this.player_Hand2.Location = new System.Drawing.Point(3, 421);
            this.player_Hand2.Login = "Login";
            this.player_Hand2.Name = "player_Hand2";
            this.player_Hand2.Passive_Cards = new string[0];
            this.player_Hand2.Power_Score = 1;
            this.player_Hand2.Size = new System.Drawing.Size(332, 204);
            this.player_Hand2.TabIndex = 1;
            // 
            // player_Hand3
            // 
            this.player_Hand3.Active_Cards = new string[0];
            this.player_Hand3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player_Hand3.FirstMove = false;
            this.player_Hand3.Invert = true;
            this.player_Hand3.Location = new System.Drawing.Point(3, 3);
            this.player_Hand3.Login = "Login";
            this.player_Hand3.Name = "player_Hand3";
            this.player_Hand3.Passive_Cards = new string[0];
            this.player_Hand3.Power_Score = 5;
            this.player_Hand3.Size = new System.Drawing.Size(332, 203);
            this.player_Hand3.TabIndex = 2;
            // 
            // player_Hand4
            // 
            this.player_Hand4.Active_Cards = new string[0];
            this.player_Hand4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player_Hand4.FirstMove = false;
            this.player_Hand4.Invert = true;
            this.player_Hand4.Location = new System.Drawing.Point(341, 3);
            this.player_Hand4.Login = "Login";
            this.player_Hand4.Name = "player_Hand4";
            this.player_Hand4.Passive_Cards = new string[0];
            this.player_Hand4.Power_Score = 1;
            this.player_Hand4.Size = new System.Drawing.Size(332, 203);
            this.player_Hand4.TabIndex = 3;
            // 
            // player_Hand5
            // 
            this.player_Hand5.Active_Cards = new string[0];
            this.player_Hand5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player_Hand5.FirstMove = false;
            this.player_Hand5.Invert = true;
            this.player_Hand5.Location = new System.Drawing.Point(679, 3);
            this.player_Hand5.Login = "Login";
            this.player_Hand5.Name = "player_Hand5";
            this.player_Hand5.Passive_Cards = new string[0];
            this.player_Hand5.Power_Score = 1;
            this.player_Hand5.Size = new System.Drawing.Size(333, 203);
            this.player_Hand5.TabIndex = 4;
            // 
            // cards_Table1
            // 
            this.cards_Table1.AutoScroll = true;
            this.cards_Table1.Card_Width = 100;
            this.tableLayoutPanel1.SetColumnSpan(this.cards_Table1, 3);
            this.cards_Table1.Curent_Card = "";
            this.cards_Table1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cards_Table1.Location = new System.Drawing.Point(3, 212);
            this.cards_Table1.Name = "cards_Table1";
            this.cards_Table1.Size = new System.Drawing.Size(1009, 203);
            this.cards_Table1.TabIndex = 5;
            // 
            // Room_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 628);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Room_Form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Room_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Room_Form_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Player_Hand player_Hand1;
        private Player_Hand player_Hand2;
        private Player_Hand player_Hand3;
        private Player_Hand player_Hand4;
        private Player_Hand player_Hand5;
        private Cards_Table cards_Table1;
    }
}
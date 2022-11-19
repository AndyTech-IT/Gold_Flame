namespace Gold_Flame
{
    partial class Player_Hand
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_TLP = new System.Windows.Forms.TableLayoutPanel();
            this.Power_L = new System.Windows.Forms.Label();
            this.FirstMove_RB = new System.Windows.Forms.RadioButton();
            this.ActiveCards_LB = new System.Windows.Forms.ListBox();
            this.PassiveCards_LB = new System.Windows.Forms.ListBox();
            this.Login_L = new System.Windows.Forms.Label();
            this.Main_TLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_TLP
            // 
            this.Main_TLP.ColumnCount = 2;
            this.Main_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Main_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Main_TLP.Controls.Add(this.Power_L, 0, 0);
            this.Main_TLP.Controls.Add(this.FirstMove_RB, 1, 0);
            this.Main_TLP.Controls.Add(this.ActiveCards_LB, 0, 1);
            this.Main_TLP.Controls.Add(this.PassiveCards_LB, 1, 1);
            this.Main_TLP.Controls.Add(this.Login_L, 0, 2);
            this.Main_TLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_TLP.Location = new System.Drawing.Point(0, 0);
            this.Main_TLP.Name = "Main_TLP";
            this.Main_TLP.RowCount = 3;
            this.Main_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Main_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Main_TLP.Size = new System.Drawing.Size(348, 286);
            this.Main_TLP.TabIndex = 1;
            // 
            // Power_L
            // 
            this.Power_L.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Power_L.AutoSize = true;
            this.Power_L.Location = new System.Drawing.Point(80, 17);
            this.Power_L.Name = "Power_L";
            this.Power_L.Size = new System.Drawing.Size(13, 15);
            this.Power_L.TabIndex = 0;
            this.Power_L.Text = "1";
            // 
            // FirstMove_RB
            // 
            this.FirstMove_RB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstMove_RB.AutoSize = true;
            this.FirstMove_RB.Location = new System.Drawing.Point(254, 18);
            this.FirstMove_RB.Name = "FirstMove_RB";
            this.FirstMove_RB.Size = new System.Drawing.Size(14, 13);
            this.FirstMove_RB.TabIndex = 1;
            this.FirstMove_RB.TabStop = true;
            this.FirstMove_RB.UseVisualStyleBackColor = true;
            this.FirstMove_RB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FirstMove_RB_MouseDown);
            this.FirstMove_RB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FirstMove_RB_MouseUp);
            // 
            // ActiveCards_LB
            // 
            this.ActiveCards_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveCards_LB.FormattingEnabled = true;
            this.ActiveCards_LB.ItemHeight = 15;
            this.ActiveCards_LB.Location = new System.Drawing.Point(3, 53);
            this.ActiveCards_LB.Name = "ActiveCards_LB";
            this.ActiveCards_LB.Size = new System.Drawing.Size(168, 180);
            this.ActiveCards_LB.TabIndex = 2;
            this.ActiveCards_LB.DoubleClick += new System.EventHandler(this.ActiveCards_LB_DoubleClick);
            // 
            // PassiveCards_LB
            // 
            this.PassiveCards_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PassiveCards_LB.FormattingEnabled = true;
            this.PassiveCards_LB.ItemHeight = 15;
            this.PassiveCards_LB.Location = new System.Drawing.Point(177, 53);
            this.PassiveCards_LB.Name = "PassiveCards_LB";
            this.PassiveCards_LB.Size = new System.Drawing.Size(168, 180);
            this.PassiveCards_LB.TabIndex = 3;
            // 
            // Login_L
            // 
            this.Login_L.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_L.AutoSize = true;
            this.Main_TLP.SetColumnSpan(this.Login_L, 2);
            this.Login_L.Location = new System.Drawing.Point(155, 253);
            this.Login_L.Name = "Login_L";
            this.Login_L.Size = new System.Drawing.Size(37, 15);
            this.Login_L.TabIndex = 4;
            this.Login_L.Text = "Login";
            // 
            // Player_Hand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Main_TLP);
            this.Name = "Player_Hand";
            this.Size = new System.Drawing.Size(348, 286);
            this.Main_TLP.ResumeLayout(false);
            this.Main_TLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label Power_L;
        private TableLayoutPanel Main_TLP;
        private RadioButton FirstMove_RB;
        private ListBox ActiveCards_LB;
        private ListBox PassiveCards_LB;
        private Label Login_L;
    }
}

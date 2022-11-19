namespace Gold_Flame
{
    partial class GameCard
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
            this.Card_Text = new System.Windows.Forms.Label();
            this.Overwrite_B = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Card_Text
            // 
            this.Card_Text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Card_Text.AutoSize = true;
            this.Card_Text.Location = new System.Drawing.Point(63, 54);
            this.Card_Text.Name = "Card_Text";
            this.Card_Text.Size = new System.Drawing.Size(32, 15);
            this.Card_Text.TabIndex = 0;
            this.Card_Text.Text = "Card";
            // 
            // Overwrite_B
            // 
            this.Overwrite_B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Overwrite_B.Location = new System.Drawing.Point(41, 137);
            this.Overwrite_B.Name = "Overwrite_B";
            this.Overwrite_B.Size = new System.Drawing.Size(75, 23);
            this.Overwrite_B.TabIndex = 1;
            this.Overwrite_B.Text = "Накрыть";
            this.Overwrite_B.UseVisualStyleBackColor = true;
            this.Overwrite_B.Click += new System.EventHandler(this.Overwrite_B_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Card_Text, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Overwrite_B, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(158, 174);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // GameCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GameCard";
            this.Size = new System.Drawing.Size(158, 174);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label Card_Text;
        private Button Overwrite_B;
        private TableLayoutPanel tableLayoutPanel1;
    }
}

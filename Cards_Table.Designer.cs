namespace Gold_Flame
{
    partial class Cards_Table
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
            this.Cards_TLP = new System.Windows.Forms.TableLayoutPanel();
            this.Add_Right_B = new System.Windows.Forms.Button();
            this.Add_Left_B = new System.Windows.Forms.Button();
            this.Cards_TLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cards_TLP
            // 
            this.Cards_TLP.AutoSize = true;
            this.Cards_TLP.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Cards_TLP.ColumnCount = 2;
            this.Cards_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Cards_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Cards_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Cards_TLP.Controls.Add(this.Add_Right_B, 1, 0);
            this.Cards_TLP.Controls.Add(this.Add_Left_B, 0, 0);
            this.Cards_TLP.Dock = System.Windows.Forms.DockStyle.Left;
            this.Cards_TLP.Location = new System.Drawing.Point(0, 0);
            this.Cards_TLP.Name = "Cards_TLP";
            this.Cards_TLP.RowCount = 1;
            this.Cards_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Cards_TLP.Size = new System.Drawing.Size(203, 191);
            this.Cards_TLP.TabIndex = 0;
            // 
            // Add_Right_B
            // 
            this.Add_Right_B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_Right_B.Location = new System.Drawing.Point(114, 60);
            this.Add_Right_B.Name = "Add_Right_B";
            this.Add_Right_B.Size = new System.Drawing.Size(75, 70);
            this.Add_Right_B.TabIndex = 0;
            this.Add_Right_B.Text = "<-";
            this.Add_Right_B.UseVisualStyleBackColor = true;
            this.Add_Right_B.Click += new System.EventHandler(this.Add_Right_B_Click);
            // 
            // Add_Left_B
            // 
            this.Add_Left_B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_Left_B.Location = new System.Drawing.Point(13, 60);
            this.Add_Left_B.Name = "Add_Left_B";
            this.Add_Left_B.Size = new System.Drawing.Size(75, 70);
            this.Add_Left_B.TabIndex = 1;
            this.Add_Left_B.Text = "->";
            this.Add_Left_B.UseVisualStyleBackColor = true;
            this.Add_Left_B.Click += new System.EventHandler(this.Add_Left_B_Click);
            // 
            // Cards_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.Cards_TLP);
            this.Name = "Cards_Table";
            this.Size = new System.Drawing.Size(574, 191);
            this.Cards_TLP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel Cards_TLP;
        private Button Add_Right_B;
        private Button Add_Left_B;
    }
}

namespace Gold_Flame
{
    partial class Login_Form
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Submit_B = new System.Windows.Forms.Button();
            this.Password_TB = new System.Windows.Forms.TextBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(this.Name_TB, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(this.Submit_B, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(this.Password_TB, 0, 3);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            tableLayoutPanel1.Size = new System.Drawing.Size(309, 260);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Name_TB
            // 
            this.Name_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Name_TB.Location = new System.Drawing.Point(26, 58);
            this.Name_TB.Margin = new System.Windows.Forms.Padding(5);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(257, 33);
            this.Name_TB.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(130, 25);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 25);
            label1.TabIndex = 1;
            label1.Text = "Имя";
            // 
            // Submit_B
            // 
            this.Submit_B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Submit_B.Location = new System.Drawing.Point(95, 211);
            this.Submit_B.Margin = new System.Windows.Forms.Padding(5);
            this.Submit_B.Name = "Submit_B";
            this.Submit_B.Size = new System.Drawing.Size(118, 38);
            this.Submit_B.TabIndex = 2;
            this.Submit_B.Text = "Войти";
            this.Submit_B.UseVisualStyleBackColor = true;
            this.Submit_B.Click += new System.EventHandler(this.Submit_B_Click);
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(115, 125);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 25);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // Password_TB
            // 
            this.Password_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password_TB.Location = new System.Drawing.Point(25, 158);
            this.Password_TB.Margin = new System.Windows.Forms.Padding(5);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.Size = new System.Drawing.Size(259, 33);
            this.Password_TB.TabIndex = 4;
            // 
            // Login_Form
            // 
            this.AcceptButton = this.Submit_B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 260);
            this.Controls.Add(tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вход";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox Name_TB;
        private Button Submit_B;
        private TextBox Password_TB;
    }
}
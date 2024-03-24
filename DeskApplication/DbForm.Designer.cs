namespace SQLBackupDesk
{
    partial class DbForm
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
            checkedListBox1 = new CheckedListBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            panel2 = new Panel();
            metroButton2 = new ReaLTaiizor.Controls.MetroButton();
            metroButton1 = new ReaLTaiizor.Controls.MetroButton();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(9, 88);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(353, 310);
            checkedListBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(foxLabel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 44);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_database_96;
            pictureBox1.Location = new Point(14, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // foxLabel2
            // 
            foxLabel2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            foxLabel2.ForeColor = Color.FromArgb(76, 88, 100);
            foxLabel2.Location = new Point(58, 12);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(157, 25);
            foxLabel2.TabIndex = 4;
            foxLabel2.Text = "Select Database";
            // 
            // panel2
            // 
            panel2.Controls.Add(metroButton2);
            panel2.Controls.Add(metroButton1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 404);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 46);
            panel2.TabIndex = 2;
            // 
            // metroButton2
            // 
            metroButton2.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroButton2.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroButton2.DisabledForeColor = Color.Gray;
            metroButton2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroButton2.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroButton2.HoverColor = Color.FromArgb(95, 207, 255);
            metroButton2.HoverTextColor = Color.White;
            metroButton2.IsDerivedStyle = true;
            metroButton2.Location = new Point(299, 7);
            metroButton2.Name = "metroButton2";
            metroButton2.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroButton2.NormalColor = Color.FromArgb(65, 177, 225);
            metroButton2.NormalTextColor = Color.White;
            metroButton2.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroButton2.PressColor = Color.FromArgb(35, 147, 195);
            metroButton2.PressTextColor = Color.White;
            metroButton2.Size = new Size(63, 32);
            metroButton2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroButton2.StyleManager = null;
            metroButton2.TabIndex = 1;
            metroButton2.Text = "Cancel";
            metroButton2.ThemeAuthor = "Taiizor";
            metroButton2.ThemeName = "MetroLight";
            metroButton2.Click += metroButton2_Click;
            // 
            // metroButton1
            // 
            metroButton1.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroButton1.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroButton1.DisabledForeColor = Color.Gray;
            metroButton1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroButton1.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroButton1.HoverColor = Color.FromArgb(95, 207, 255);
            metroButton1.HoverTextColor = Color.White;
            metroButton1.IsDerivedStyle = true;
            metroButton1.Location = new Point(175, 7);
            metroButton1.Name = "metroButton1";
            metroButton1.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroButton1.NormalColor = Color.FromArgb(65, 177, 225);
            metroButton1.NormalTextColor = Color.White;
            metroButton1.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroButton1.PressColor = Color.FromArgb(35, 147, 195);
            metroButton1.PressTextColor = Color.White;
            metroButton1.Size = new Size(108, 32);
            metroButton1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroButton1.StyleManager = null;
            metroButton1.TabIndex = 0;
            metroButton1.Text = "Save & Close";
            metroButton1.ThemeAuthor = "Taiizor";
            metroButton1.ThemeName = "MetroLight";
            metroButton1.Click += metroButton1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 63);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(152, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Show System Databases";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // DbForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 450);
            Controls.Add(checkBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(checkedListBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DbForm";
            Text = "Databases";
            Activated += DbForm_Activated;
            Load += DbForm_Load;
            Shown += DbForm_Shown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Panel panel1;
        private Panel panel2;
        private CheckBox checkBox1;
        private ReaLTaiizor.Controls.MetroButton metroButton2;
        private ReaLTaiizor.Controls.MetroButton metroButton1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private PictureBox pictureBox1;
    }
}
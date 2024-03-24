namespace SQLBackupDesk
{
    partial class SqlConnForm
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
            metroButton1 = new ReaLTaiizor.Controls.MetroButton();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            TrustedConnection = new ReaLTaiizor.Controls.MaterialCheckBox();
            isEncrypt = new ReaLTaiizor.Controls.MaterialCheckBox();
            panel4 = new Panel();
            txtpassword = new ReaLTaiizor.Controls.HopeTextBox();
            foxLabel4 = new ReaLTaiizor.Controls.FoxLabel();
            txtuser = new ReaLTaiizor.Controls.HopeTextBox();
            foxLabel3 = new ReaLTaiizor.Controls.FoxLabel();
            hopeRadioButtonSqlAuth = new ReaLTaiizor.Controls.HopeRadioButton();
            hopeRadioButtonWinAuth = new ReaLTaiizor.Controls.HopeRadioButton();
            txtServer = new ReaLTaiizor.Controls.HopeTextBox();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            metroButton2 = new ReaLTaiizor.Controls.MetroButton();
            parrotGroupBox1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
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
            metroButton1.Location = new Point(15, 415);
            metroButton1.Name = "metroButton1";
            metroButton1.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroButton1.NormalColor = Color.FromArgb(65, 177, 225);
            metroButton1.NormalTextColor = Color.White;
            metroButton1.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroButton1.PressColor = Color.FromArgb(35, 147, 195);
            metroButton1.PressTextColor = Color.White;
            metroButton1.Size = new Size(119, 32);
            metroButton1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroButton1.StyleManager = null;
            metroButton1.TabIndex = 10;
            metroButton1.Text = "Test Connection";
            metroButton1.ThemeAuthor = "Taiizor";
            metroButton1.ThemeName = "MetroLight";
            metroButton1.Click += metroButton1_Click;
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BorderColor = Color.White;
            parrotGroupBox1.BorderWidth = 1;
            parrotGroupBox1.Controls.Add(TrustedConnection);
            parrotGroupBox1.Controls.Add(isEncrypt);
            parrotGroupBox1.Controls.Add(panel4);
            parrotGroupBox1.Controls.Add(hopeRadioButtonSqlAuth);
            parrotGroupBox1.Controls.Add(hopeRadioButtonWinAuth);
            parrotGroupBox1.Controls.Add(txtServer);
            parrotGroupBox1.Controls.Add(foxLabel2);
            parrotGroupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            parrotGroupBox1.Location = new Point(15, 3);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new Size(522, 406);
            parrotGroupBox1.TabIndex = 9;
            parrotGroupBox1.TabStop = false;
            parrotGroupBox1.Text = "SQL Database Connection";
            parrotGroupBox1.TextColor = Color.White;
            // 
            // TrustedConnection
            // 
            TrustedConnection.AutoSize = true;
            TrustedConnection.Depth = 0;
            TrustedConnection.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TrustedConnection.Location = new Point(269, 353);
            TrustedConnection.Margin = new Padding(0);
            TrustedConnection.MouseLocation = new Point(-1, -1);
            TrustedConnection.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TrustedConnection.Name = "TrustedConnection";
            TrustedConnection.ReadOnly = false;
            TrustedConnection.Ripple = true;
            TrustedConnection.Size = new Size(196, 37);
            TrustedConnection.TabIndex = 13;
            TrustedConnection.Text = "Trust Server Certificate";
            TrustedConnection.UseAccentColor = false;
            TrustedConnection.UseVisualStyleBackColor = true;
            // 
            // isEncrypt
            // 
            isEncrypt.AutoSize = true;
            isEncrypt.Depth = 0;
            isEncrypt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            isEncrypt.Location = new Point(27, 353);
            isEncrypt.Margin = new Padding(0);
            isEncrypt.MouseLocation = new Point(-1, -1);
            isEncrypt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            isEncrypt.Name = "isEncrypt";
            isEncrypt.ReadOnly = false;
            isEncrypt.Ripple = true;
            isEncrypt.Size = new Size(172, 37);
            isEncrypt.TabIndex = 12;
            isEncrypt.Text = "Encrypt Connection";
            isEncrypt.UseAccentColor = false;
            isEncrypt.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtpassword);
            panel4.Controls.Add(foxLabel4);
            panel4.Controls.Add(txtuser);
            panel4.Controls.Add(foxLabel3);
            panel4.Location = new Point(21, 169);
            panel4.Name = "panel4";
            panel4.Size = new Size(472, 155);
            panel4.TabIndex = 11;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.White;
            txtpassword.BaseColor = Color.FromArgb(44, 55, 66);
            txtpassword.BorderColorA = Color.FromArgb(64, 158, 255);
            txtpassword.BorderColorB = Color.FromArgb(220, 223, 230);
            txtpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.ForeColor = Color.FromArgb(48, 49, 51);
            txtpassword.Hint = "";
            txtpassword.Location = new Point(14, 93);
            txtpassword.MaxLength = 32767;
            txtpassword.Multiline = false;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '\0';
            txtpassword.ScrollBars = ScrollBars.None;
            txtpassword.SelectedText = "";
            txtpassword.SelectionLength = 0;
            txtpassword.SelectionStart = 0;
            txtpassword.Size = new Size(441, 38);
            txtpassword.TabIndex = 15;
            txtpassword.TabStop = false;
            txtpassword.UseSystemPasswordChar = false;
            // 
            // foxLabel4
            // 
            foxLabel4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            foxLabel4.ForeColor = Color.White;
            foxLabel4.Location = new Point(14, 74);
            foxLabel4.Name = "foxLabel4";
            foxLabel4.Size = new Size(84, 25);
            foxLabel4.TabIndex = 14;
            foxLabel4.Text = "Password";
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.White;
            txtuser.BaseColor = Color.FromArgb(44, 55, 66);
            txtuser.BorderColorA = Color.FromArgb(64, 158, 255);
            txtuser.BorderColorB = Color.FromArgb(220, 223, 230);
            txtuser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtuser.ForeColor = Color.FromArgb(48, 49, 51);
            txtuser.Hint = "";
            txtuser.Location = new Point(14, 24);
            txtuser.MaxLength = 32767;
            txtuser.Multiline = false;
            txtuser.Name = "txtuser";
            txtuser.PasswordChar = '\0';
            txtuser.ScrollBars = ScrollBars.None;
            txtuser.SelectedText = "";
            txtuser.SelectionLength = 0;
            txtuser.SelectionStart = 0;
            txtuser.Size = new Size(441, 38);
            txtuser.TabIndex = 13;
            txtuser.TabStop = false;
            txtuser.UseSystemPasswordChar = false;
            // 
            // foxLabel3
            // 
            foxLabel3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            foxLabel3.ForeColor = Color.White;
            foxLabel3.Location = new Point(14, 5);
            foxLabel3.Name = "foxLabel3";
            foxLabel3.Size = new Size(84, 25);
            foxLabel3.TabIndex = 12;
            foxLabel3.Text = "User Name";
            // 
            // hopeRadioButtonSqlAuth
            // 
            hopeRadioButtonSqlAuth.AutoSize = true;
            hopeRadioButtonSqlAuth.CheckedColor = Color.White;
            hopeRadioButtonSqlAuth.DisabledColor = Color.FromArgb(196, 198, 202);
            hopeRadioButtonSqlAuth.DisabledStringColor = Color.FromArgb(186, 187, 189);
            hopeRadioButtonSqlAuth.Enable = true;
            hopeRadioButtonSqlAuth.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            hopeRadioButtonSqlAuth.EnabledStringColor = Color.FromArgb(146, 146, 146);
            hopeRadioButtonSqlAuth.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            hopeRadioButtonSqlAuth.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            hopeRadioButtonSqlAuth.ForeColor = Color.Black;
            hopeRadioButtonSqlAuth.Location = new Point(298, 130);
            hopeRadioButtonSqlAuth.Name = "hopeRadioButtonSqlAuth";
            hopeRadioButtonSqlAuth.Size = new Size(195, 20);
            hopeRadioButtonSqlAuth.TabIndex = 10;
            hopeRadioButtonSqlAuth.Text = "SQL Server Authentication";
            hopeRadioButtonSqlAuth.UseVisualStyleBackColor = true;
            // 
            // hopeRadioButtonWinAuth
            // 
            hopeRadioButtonWinAuth.AutoSize = true;
            hopeRadioButtonWinAuth.Checked = true;
            hopeRadioButtonWinAuth.CheckedColor = Color.White;
            hopeRadioButtonWinAuth.DisabledColor = Color.FromArgb(196, 198, 202);
            hopeRadioButtonWinAuth.DisabledStringColor = Color.FromArgb(186, 187, 189);
            hopeRadioButtonWinAuth.Enable = true;
            hopeRadioButtonWinAuth.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            hopeRadioButtonWinAuth.EnabledStringColor = Color.FromArgb(146, 146, 146);
            hopeRadioButtonWinAuth.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            hopeRadioButtonWinAuth.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            hopeRadioButtonWinAuth.ForeColor = Color.Black;
            hopeRadioButtonWinAuth.Location = new Point(21, 130);
            hopeRadioButtonWinAuth.Name = "hopeRadioButtonWinAuth";
            hopeRadioButtonWinAuth.Size = new Size(178, 20);
            hopeRadioButtonWinAuth.TabIndex = 8;
            hopeRadioButtonWinAuth.TabStop = true;
            hopeRadioButtonWinAuth.Text = "Window Authentication";
            hopeRadioButtonWinAuth.UseVisualStyleBackColor = true;
            // 
            // txtServer
            // 
            txtServer.BackColor = Color.White;
            txtServer.BaseColor = Color.FromArgb(44, 55, 66);
            txtServer.BorderColorA = Color.FromArgb(64, 158, 255);
            txtServer.BorderColorB = Color.FromArgb(220, 223, 230);
            txtServer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtServer.ForeColor = Color.FromArgb(48, 49, 51);
            txtServer.Hint = "";
            txtServer.Location = new Point(21, 73);
            txtServer.MaxLength = 32767;
            txtServer.Multiline = false;
            txtServer.Name = "txtServer";
            txtServer.PasswordChar = '\0';
            txtServer.ScrollBars = ScrollBars.None;
            txtServer.SelectedText = "";
            txtServer.SelectionLength = 0;
            txtServer.SelectionStart = 0;
            txtServer.Size = new Size(472, 38);
            txtServer.TabIndex = 9;
            txtServer.TabStop = false;
            txtServer.UseSystemPasswordChar = false;
            // 
            // foxLabel2
            // 
            foxLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            foxLabel2.ForeColor = Color.White;
            foxLabel2.Location = new Point(21, 54);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(84, 25);
            foxLabel2.TabIndex = 3;
            foxLabel2.Text = "SQL Server";
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
            metroButton2.Location = new Point(294, 416);
            metroButton2.Name = "metroButton2";
            metroButton2.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroButton2.NormalColor = Color.FromArgb(65, 177, 225);
            metroButton2.NormalTextColor = Color.White;
            metroButton2.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroButton2.PressColor = Color.FromArgb(35, 147, 195);
            metroButton2.PressTextColor = Color.White;
            metroButton2.Size = new Size(243, 32);
            metroButton2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroButton2.StyleManager = null;
            metroButton2.TabIndex = 11;
            metroButton2.Text = "Submit & Close";
            metroButton2.ThemeAuthor = "Taiizor";
            metroButton2.ThemeName = "MetroLight";
            metroButton2.Click += metroButton2_Click;
            // 
            // SqlConnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(557, 460);
            Controls.Add(metroButton2);
            Controls.Add(metroButton1);
            Controls.Add(parrotGroupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SqlConnForm";
            Text = "SqlConnection";
            Load += SqlConnForm_Load;
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MetroButton metroButton1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private ReaLTaiizor.Controls.MaterialCheckBox TrustedConnection;
        private ReaLTaiizor.Controls.MaterialCheckBox isEncrypt;
        private Panel panel4;
        private ReaLTaiizor.Controls.HopeTextBox txtpassword;
        private ReaLTaiizor.Controls.FoxLabel foxLabel4;
        private ReaLTaiizor.Controls.HopeTextBox txtuser;
        private ReaLTaiizor.Controls.FoxLabel foxLabel3;
        private ReaLTaiizor.Controls.HopeRadioButton hopeRadioButtonSqlAuth;
        private ReaLTaiizor.Controls.HopeRadioButton hopeRadioButtonWinAuth;
        private ReaLTaiizor.Controls.HopeTextBox txtServer;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.MetroButton metroButton2;
    }
}
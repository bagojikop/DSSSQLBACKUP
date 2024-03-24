namespace SQLBackupDesk
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            lostBorderPanel1 = new ReaLTaiizor.Controls.LostBorderPanel();
            button1 = new Button();
            textBoxServerName = new TextBox();
            lostBorderPanel2 = new ReaLTaiizor.Controls.LostBorderPanel();
            button2 = new Button();
            textBoxDatabases = new TextBox();
            lostBorderPanel3 = new ReaLTaiizor.Controls.LostBorderPanel();
            textBoxDestination = new ReaLTaiizor.Controls.SmallTextBox();
            button3 = new Button();
            lostBorderPanel4 = new ReaLTaiizor.Controls.LostBorderPanel();
            DiffTimepanel = new Panel();
            diffLabel = new ReaLTaiizor.Controls.FoxLabel();
            diffTime = new DateTimePicker();
            foxLabel5 = new ReaLTaiizor.Controls.FoxLabel();
            fullLabel = new ReaLTaiizor.Controls.FoxLabel();
            Fulltime = new DateTimePicker();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            button4 = new Button();
            lostBorderPanel5 = new ReaLTaiizor.Controls.LostBorderPanel();
            MailToggle = new ReaLTaiizor.Controls.HopeToggle();
            MailtextBox = new ReaLTaiizor.Controls.SmallTextBox();
            panel1 = new Panel();
            progressBar1 = new ReaLTaiizor.Controls.HopeProgressBar();
            hopeButton2 = new ReaLTaiizor.Controls.HopeButton();
            hopeButton1 = new ReaLTaiizor.Controls.HopeButton();
            panel2 = new Panel();
            foreverComboBox1 = new ReaLTaiizor.Controls.ForeverComboBox();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            nightButton2 = new ReaLTaiizor.Controls.NightButton();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            nightButton1 = new ReaLTaiizor.Controls.NightButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            timer1 = new System.Windows.Forms.Timer(components);
            lostBorderPanel1.SuspendLayout();
            lostBorderPanel2.SuspendLayout();
            lostBorderPanel3.SuspendLayout();
            lostBorderPanel4.SuspendLayout();
            DiffTimepanel.SuspendLayout();
            lostBorderPanel5.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lostBorderPanel1
            // 
            lostBorderPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lostBorderPanel1.BackColor = Color.FromArgb(63, 63, 70);
            lostBorderPanel1.BorderColor = Color.DodgerBlue;
            lostBorderPanel1.Controls.Add(button1);
            lostBorderPanel1.Controls.Add(textBoxServerName);
            lostBorderPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lostBorderPanel1.ForeColor = Color.Black;
            lostBorderPanel1.Location = new Point(16, 71);
            lostBorderPanel1.Name = "lostBorderPanel1";
            lostBorderPanel1.Padding = new Padding(5);
            lostBorderPanel1.ShowText = true;
            lostBorderPanel1.Size = new Size(1095, 111);
            lostBorderPanel1.TabIndex = 0;
            lostBorderPanel1.Text = "Connect to Microsoft SQL Server (LOCAL)";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = Properties.Resources.icons8_settings_40;
            button1.Location = new Point(1020, 41);
            button1.Name = "button1";
            button1.Size = new Size(51, 47);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxServerName
            // 
            textBoxServerName.BackColor = SystemColors.Control;
            textBoxServerName.BorderStyle = BorderStyle.None;
            textBoxServerName.Location = new Point(34, 32);
            textBoxServerName.Multiline = true;
            textBoxServerName.Name = "textBoxServerName";
            textBoxServerName.ReadOnly = true;
            textBoxServerName.Size = new Size(811, 56);
            textBoxServerName.TabIndex = 0;
            textBoxServerName.TabStop = false;
            // 
            // lostBorderPanel2
            // 
            lostBorderPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lostBorderPanel2.BackColor = Color.FromArgb(63, 63, 70);
            lostBorderPanel2.BorderColor = Color.DodgerBlue;
            lostBorderPanel2.Controls.Add(button2);
            lostBorderPanel2.Controls.Add(textBoxDatabases);
            lostBorderPanel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lostBorderPanel2.ForeColor = Color.Black;
            lostBorderPanel2.Location = new Point(16, 181);
            lostBorderPanel2.Name = "lostBorderPanel2";
            lostBorderPanel2.Padding = new Padding(5);
            lostBorderPanel2.ShowText = true;
            lostBorderPanel2.Size = new Size(1095, 111);
            lostBorderPanel2.TabIndex = 1;
            lostBorderPanel2.Text = "Select Database";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = Properties.Resources.icons8_database_40;
            button2.Location = new Point(1020, 32);
            button2.Name = "button2";
            button2.Size = new Size(51, 47);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxDatabases
            // 
            textBoxDatabases.BackColor = SystemColors.Control;
            textBoxDatabases.BorderStyle = BorderStyle.None;
            textBoxDatabases.Location = new Point(34, 32);
            textBoxDatabases.Multiline = true;
            textBoxDatabases.Name = "textBoxDatabases";
            textBoxDatabases.ReadOnly = true;
            textBoxDatabases.Size = new Size(811, 56);
            textBoxDatabases.TabIndex = 0;
            textBoxDatabases.TabStop = false;
            // 
            // lostBorderPanel3
            // 
            lostBorderPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lostBorderPanel3.BackColor = Color.FromArgb(63, 63, 70);
            lostBorderPanel3.BorderColor = Color.DodgerBlue;
            lostBorderPanel3.Controls.Add(textBoxDestination);
            lostBorderPanel3.Controls.Add(button3);
            lostBorderPanel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lostBorderPanel3.ForeColor = Color.Black;
            lostBorderPanel3.Location = new Point(16, 291);
            lostBorderPanel3.Name = "lostBorderPanel3";
            lostBorderPanel3.Padding = new Padding(5);
            lostBorderPanel3.ShowText = true;
            lostBorderPanel3.Size = new Size(1095, 111);
            lostBorderPanel3.TabIndex = 2;
            lostBorderPanel3.Text = "Store Backups in Selected Destination";
            // 
            // textBoxDestination
            // 
            textBoxDestination.BackColor = Color.Transparent;
            textBoxDestination.BorderColor = Color.FromArgb(180, 180, 180);
            textBoxDestination.CustomBGColor = Color.White;
            textBoxDestination.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDestination.ForeColor = Color.DimGray;
            textBoxDestination.Location = new Point(34, 60);
            textBoxDestination.MaxLength = 32767;
            textBoxDestination.Multiline = false;
            textBoxDestination.Name = "textBoxDestination";
            textBoxDestination.ReadOnly = false;
            textBoxDestination.Size = new Size(814, 28);
            textBoxDestination.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            textBoxDestination.TabIndex = 44;
            textBoxDestination.TextAlignment = HorizontalAlignment.Left;
            textBoxDestination.UseSystemPasswordChar = false;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Image = Properties.Resources.icons8_folder_40;
            button3.Location = new Point(1020, 41);
            button3.Name = "button3";
            button3.Size = new Size(51, 47);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lostBorderPanel4
            // 
            lostBorderPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lostBorderPanel4.BackColor = Color.FromArgb(63, 63, 70);
            lostBorderPanel4.BorderColor = Color.DodgerBlue;
            lostBorderPanel4.Controls.Add(DiffTimepanel);
            lostBorderPanel4.Controls.Add(fullLabel);
            lostBorderPanel4.Controls.Add(Fulltime);
            lostBorderPanel4.Controls.Add(foxLabel1);
            lostBorderPanel4.Controls.Add(button4);
            lostBorderPanel4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lostBorderPanel4.ForeColor = Color.Black;
            lostBorderPanel4.Location = new Point(16, 401);
            lostBorderPanel4.Name = "lostBorderPanel4";
            lostBorderPanel4.Padding = new Padding(5);
            lostBorderPanel4.ShowText = true;
            lostBorderPanel4.Size = new Size(1095, 110);
            lostBorderPanel4.TabIndex = 3;
            lostBorderPanel4.Text = "Schedule Backups";
            // 
            // DiffTimepanel
            // 
            DiffTimepanel.Controls.Add(diffLabel);
            DiffTimepanel.Controls.Add(diffTime);
            DiffTimepanel.Controls.Add(foxLabel5);
            DiffTimepanel.Location = new Point(24, 66);
            DiffTimepanel.Name = "DiffTimepanel";
            DiffTimepanel.Size = new Size(734, 38);
            DiffTimepanel.TabIndex = 8;
            // 
            // diffLabel
            // 
            diffLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            diffLabel.ForeColor = Color.Gray;
            diffLabel.Location = new Point(356, 10);
            diffLabel.Name = "diffLabel";
            diffLabel.Size = new Size(136, 25);
            diffLabel.TabIndex = 10;
            diffLabel.Text = "Every Day";
            // 
            // diffTime
            // 
            diffTime.Enabled = false;
            diffTime.Format = DateTimePickerFormat.Time;
            diffTime.Location = new Point(203, 6);
            diffTime.Name = "diffTime";
            diffTime.Size = new Size(136, 29);
            diffTime.TabIndex = 9;
            // 
            // foxLabel5
            // 
            foxLabel5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            foxLabel5.ForeColor = Color.Gray;
            foxLabel5.Location = new Point(10, 10);
            foxLabel5.Name = "foxLabel5";
            foxLabel5.Size = new Size(225, 25);
            foxLabel5.TabIndex = 8;
            foxLabel5.Text = "Start Differential Backup  At";
            // 
            // fullLabel
            // 
            fullLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            fullLabel.ForeColor = Color.Gray;
            fullLabel.Location = new Point(318, 32);
            fullLabel.Name = "fullLabel";
            fullLabel.Size = new Size(136, 25);
            fullLabel.TabIndex = 7;
            fullLabel.Text = "Every Day";
            // 
            // Fulltime
            // 
            Fulltime.Enabled = false;
            Fulltime.Format = DateTimePickerFormat.Time;
            Fulltime.Location = new Point(174, 28);
            Fulltime.Name = "Fulltime";
            Fulltime.Size = new Size(136, 29);
            Fulltime.TabIndex = 6;
            // 
            // foxLabel1
            // 
            foxLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            foxLabel1.ForeColor = Color.Gray;
            foxLabel1.Location = new Point(34, 32);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(136, 25);
            foxLabel1.TabIndex = 5;
            foxLabel1.Text = "Start Full Backup  At";
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Image = Properties.Resources.icons8_task_planning_40;
            button4.Location = new Point(1020, 41);
            button4.Name = "button4";
            button4.Size = new Size(51, 47);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // lostBorderPanel5
            // 
            lostBorderPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lostBorderPanel5.BackColor = Color.FromArgb(63, 63, 70);
            lostBorderPanel5.BorderColor = Color.DodgerBlue;
            lostBorderPanel5.Controls.Add(MailToggle);
            lostBorderPanel5.Controls.Add(MailtextBox);
            lostBorderPanel5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lostBorderPanel5.ForeColor = Color.Black;
            lostBorderPanel5.Location = new Point(16, 511);
            lostBorderPanel5.Name = "lostBorderPanel5";
            lostBorderPanel5.Padding = new Padding(5);
            lostBorderPanel5.ShowText = true;
            lostBorderPanel5.Size = new Size(1095, 110);
            lostBorderPanel5.TabIndex = 4;
            lostBorderPanel5.Text = "Send Information to Mail";
            // 
            // MailToggle
            // 
            MailToggle.AutoSize = true;
            MailToggle.BaseColor = SystemColors.Control;
            MailToggle.BaseColorA = Color.FromArgb(220, 223, 230);
            MailToggle.BaseColorB = Color.FromArgb(100, 64, 158, 255);
            MailToggle.HeadColorA = SystemColors.Control;
            MailToggle.HeadColorB = Color.White;
            MailToggle.HeadColorC = Color.FromArgb(220, 223, 230);
            MailToggle.HeadColorD = Color.FromArgb(100, 64, 158, 255);
            MailToggle.Location = new Point(191, 6);
            MailToggle.Name = "MailToggle";
            MailToggle.Size = new Size(48, 20);
            MailToggle.TabIndex = 43;
            MailToggle.UseVisualStyleBackColor = true;
            MailToggle.CheckedChanged += MailToggle_CheckedChanged;
            // 
            // MailtextBox
            // 
            MailtextBox.BackColor = Color.Transparent;
            MailtextBox.BorderColor = Color.FromArgb(180, 180, 180);
            MailtextBox.CustomBGColor = Color.White;
            MailtextBox.Enabled = false;
            MailtextBox.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MailtextBox.ForeColor = Color.DimGray;
            MailtextBox.Location = new Point(34, 50);
            MailtextBox.MaxLength = 32767;
            MailtextBox.Multiline = false;
            MailtextBox.Name = "MailtextBox";
            MailtextBox.ReadOnly = false;
            MailtextBox.Size = new Size(814, 28);
            MailtextBox.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            MailtextBox.TabIndex = 6;
            MailtextBox.TextAlignment = HorizontalAlignment.Left;
            MailtextBox.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(hopeButton2);
            panel1.Controls.Add(hopeButton1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 638);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 64);
            panel1.TabIndex = 5;
            // 
            // progressBar1
            // 
            progressBar1.BarColor = Color.FromArgb(220, 223, 230);
            progressBar1.BaseColor = Color.FromArgb(64, 158, 255);
            progressBar1.DangerColor = Color.FromArgb(245, 108, 108);
            progressBar1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            progressBar1.ForeColor = Color.FromArgb(242, 246, 252);
            progressBar1.FullBallonColor = Color.FromArgb(103, 194, 58);
            progressBar1.FullBallonText = "Ok!";
            progressBar1.FullBarColor = Color.FromArgb(103, 194, 58);
            progressBar1.IsError = false;
            progressBar1.Location = new Point(26, 17);
            progressBar1.Name = "progressBar1";
            progressBar1.ProgressBarStyle = ReaLTaiizor.Controls.HopeProgressBar.Style.ToolTip;
            progressBar1.Size = new Size(806, 32);
            progressBar1.TabIndex = 2;
            progressBar1.ValueNumber = 0;
            progressBar1.Visible = false;
            // 
            // hopeButton2
            // 
            hopeButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            hopeButton2.BorderColor = Color.FromArgb(220, 223, 230);
            hopeButton2.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeButton2.DangerColor = Color.FromArgb(245, 108, 108);
            hopeButton2.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeButton2.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeButton2.InfoColor = Color.FromArgb(144, 147, 153);
            hopeButton2.Location = new Point(990, 12);
            hopeButton2.Name = "hopeButton2";
            hopeButton2.PrimaryColor = Color.FromArgb(64, 158, 255);
            hopeButton2.Size = new Size(120, 40);
            hopeButton2.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeButton2.TabIndex = 1;
            hopeButton2.Text = "Close";
            hopeButton2.TextColor = Color.White;
            hopeButton2.WarningColor = Color.FromArgb(230, 162, 60);
            hopeButton2.Click += hopeButton2_Click;
            // 
            // hopeButton1
            // 
            hopeButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            hopeButton1.BorderColor = Color.FromArgb(220, 223, 230);
            hopeButton1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeButton1.DangerColor = Color.FromArgb(245, 108, 108);
            hopeButton1.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeButton1.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeButton1.InfoColor = Color.FromArgb(144, 147, 153);
            hopeButton1.Location = new Point(863, 12);
            hopeButton1.Name = "hopeButton1";
            hopeButton1.PrimaryColor = Color.FromArgb(64, 158, 255);
            hopeButton1.Size = new Size(120, 40);
            hopeButton1.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeButton1.TabIndex = 0;
            hopeButton1.Text = "Save";
            hopeButton1.TextColor = Color.White;
            hopeButton1.WarningColor = Color.FromArgb(230, 162, 60);
            hopeButton1.Click += hopeButton1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(foreverComboBox1);
            panel2.Controls.Add(foxLabel2);
            panel2.Controls.Add(nightButton2);
            panel2.Controls.Add(materialLabel1);
            panel2.Controls.Add(nightButton1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1133, 57);
            panel2.TabIndex = 6;
            // 
            // foreverComboBox1
            // 
            foreverComboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverComboBox1.BaseColor = Color.FromArgb(25, 27, 29);
            foreverComboBox1.BGColor = Color.FromArgb(45, 47, 49);
            foreverComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            foreverComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            foreverComboBox1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            foreverComboBox1.ForeColor = Color.White;
            foreverComboBox1.FormattingEnabled = true;
            foreverComboBox1.HoverColor = Color.FromArgb(35, 168, 109);
            foreverComboBox1.HoverFontColor = Color.White;
            foreverComboBox1.ItemHeight = 18;
            foreverComboBox1.Items.AddRange(new object[] { "Full", "Differential", "Transaction Log" });
            foreverComboBox1.Location = new Point(823, 20);
            foreverComboBox1.Name = "foreverComboBox1";
            foreverComboBox1.Size = new Size(121, 24);
            foreverComboBox1.TabIndex = 5;
            // 
            // foxLabel2
            // 
            foxLabel2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            foxLabel2.ForeColor = Color.White;
            foxLabel2.Location = new Point(16, 12);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(401, 25);
            foxLabel2.TabIndex = 4;
            foxLabel2.Text = "SQL Server Database Backup Schedule";
            // 
            // nightButton2
            // 
            nightButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightButton2.BackColor = Color.Transparent;
            nightButton2.DialogResult = DialogResult.None;
            nightButton2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            nightButton2.ForeColor = Color.DodgerBlue;
            nightButton2.HoverBackColor = Color.FromArgb(128, 128, 255);
            nightButton2.HoverForeColor = Color.White;
            nightButton2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            nightButton2.Location = new Point(972, 7);
            nightButton2.MinimumSize = new Size(144, 47);
            nightButton2.Name = "nightButton2";
            nightButton2.NormalBackColor = Color.FromArgb(128, 128, 255);
            nightButton2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            nightButton2.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            nightButton2.PressedForeColor = Color.White;
            nightButton2.Radius = 20;
            nightButton2.Size = new Size(144, 47);
            nightButton2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nightButton2.TabIndex = 3;
            nightButton2.Text = "Run Now";
            nightButton2.Click += nightButton2_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(20, 0);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(1, 0);
            materialLabel1.TabIndex = 2;
            // 
            // nightButton1
            // 
            nightButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightButton1.BackColor = Color.Transparent;
            nightButton1.DialogResult = DialogResult.None;
            nightButton1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            nightButton1.ForeColor = Color.DodgerBlue;
            nightButton1.HoverBackColor = Color.FromArgb(128, 128, 255);
            nightButton1.HoverForeColor = Color.White;
            nightButton1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            nightButton1.Location = new Point(2230, 6);
            nightButton1.MinimumSize = new Size(144, 47);
            nightButton1.Name = "nightButton1";
            nightButton1.NormalBackColor = Color.FromArgb(128, 128, 255);
            nightButton1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            nightButton1.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            nightButton1.PressedForeColor = Color.White;
            nightButton1.Radius = 20;
            nightButton1.Size = new Size(144, 47);
            nightButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nightButton1.TabIndex = 0;
            nightButton1.Text = "Run Now";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 702);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lostBorderPanel5);
            Controls.Add(lostBorderPanel4);
            Controls.Add(lostBorderPanel3);
            Controls.Add(lostBorderPanel2);
            Controls.Add(lostBorderPanel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SQL Backup Schedule";
            Load += MainForm_Load;
            lostBorderPanel1.ResumeLayout(false);
            lostBorderPanel1.PerformLayout();
            lostBorderPanel2.ResumeLayout(false);
            lostBorderPanel2.PerformLayout();
            lostBorderPanel3.ResumeLayout(false);
            lostBorderPanel4.ResumeLayout(false);
            DiffTimepanel.ResumeLayout(false);
            lostBorderPanel5.ResumeLayout(false);
            lostBorderPanel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.LostBorderPanel lostBorderPanel1;
        private TextBox textBoxServerName;
        private ReaLTaiizor.Controls.LostBorderPanel lostBorderPanel2;
        private TextBox textBoxDatabases;
        private ReaLTaiizor.Controls.LostBorderPanel lostBorderPanel3;
        private ReaLTaiizor.Controls.LostBorderPanel lostBorderPanel4;
        private ReaLTaiizor.Controls.LostBorderPanel lostBorderPanel5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Panel panel2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.NightButton nightButton1;
        private ReaLTaiizor.Controls.NightButton nightButton2;
        private ReaLTaiizor.Controls.HopeButton hopeButton1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.HopeButton hopeButton2;
        private ReaLTaiizor.Controls.SmallTextBox MailtextBox;
        private ReaLTaiizor.Controls.HopeToggle MailToggle;
        private DateTimePicker Fulltime;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private Panel DiffTimepanel;
        private ReaLTaiizor.Controls.FoxLabel foxLabel4;
        private DateTimePicker diffTime;
        private ReaLTaiizor.Controls.FoxLabel foxLabel5;
        private ReaLTaiizor.Controls.FoxLabel foxLabel3;
        private ReaLTaiizor.Controls.SmallTextBox textBoxDestination;
        private ReaLTaiizor.Controls.FoxLabel fullLabel;
        private ReaLTaiizor.Controls.FoxLabel diffLabel;
        private ReaLTaiizor.Controls.ForeverComboBox foreverComboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ReaLTaiizor.Controls.HopeProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}
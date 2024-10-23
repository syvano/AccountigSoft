namespace AccountigSoft
{
    partial class MainFrm
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
            topPanel = new Panel();
            HelpBtn = new Button();
            ToolsBtn = new Button();
            ReportsBtn = new Button();
            AccountingBtn = new Button();
            CloseBtn = new Button();
            MinBtn = new Button();
            bottomPanel = new Panel();
            label2 = new Label();
            DateTimeLabel = new Label();
            UserLabel = new Label();
            UserPictureBox = new PictureBox();
            BackgroundComboBox = new ComboBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            topPanel.SuspendLayout();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = SystemColors.MenuBar;
            topPanel.Controls.Add(HelpBtn);
            topPanel.Controls.Add(ToolsBtn);
            topPanel.Controls.Add(ReportsBtn);
            topPanel.Controls.Add(AccountingBtn);
            topPanel.Controls.Add(CloseBtn);
            topPanel.Controls.Add(MinBtn);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(4, 5, 4, 5);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1871, 153);
            topPanel.TabIndex = 0;
            // 
            // HelpBtn
            // 
            HelpBtn.BackgroundImage = Properties.Resources.butt_background;
            HelpBtn.BackgroundImageLayout = ImageLayout.Stretch;
            HelpBtn.Cursor = Cursors.Hand;
            HelpBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HelpBtn.Image = Properties.Resources.top_Help_butt;
            HelpBtn.Location = new Point(519, 17);
            HelpBtn.Margin = new Padding(4, 5, 4, 5);
            HelpBtn.Name = "HelpBtn";
            HelpBtn.Size = new Size(121, 118);
            HelpBtn.TabIndex = 5;
            HelpBtn.Text = "Help F5";
            HelpBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            HelpBtn.UseVisualStyleBackColor = true;
            // 
            // ToolsBtn
            // 
            ToolsBtn.BackgroundImage = Properties.Resources.butt_background;
            ToolsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ToolsBtn.Cursor = Cursors.Hand;
            ToolsBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ToolsBtn.Image = Properties.Resources.top_Tools_butt;
            ToolsBtn.Location = new Point(377, 17);
            ToolsBtn.Margin = new Padding(4, 5, 4, 5);
            ToolsBtn.Name = "ToolsBtn";
            ToolsBtn.Size = new Size(133, 118);
            ToolsBtn.TabIndex = 4;
            ToolsBtn.Text = "Tools F4";
            ToolsBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            ToolsBtn.UseVisualStyleBackColor = true;
            // 
            // ReportsBtn
            // 
            ReportsBtn.BackgroundImage = Properties.Resources.butt_background;
            ReportsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ReportsBtn.Cursor = Cursors.Hand;
            ReportsBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReportsBtn.Image = Properties.Resources.top_report_butt;
            ReportsBtn.Location = new Point(207, 17);
            ReportsBtn.Margin = new Padding(4, 5, 4, 5);
            ReportsBtn.Name = "ReportsBtn";
            ReportsBtn.Size = new Size(161, 118);
            ReportsBtn.TabIndex = 3;
            ReportsBtn.Text = "Reports F3";
            ReportsBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            ReportsBtn.UseVisualStyleBackColor = true;
            // 
            // AccountingBtn
            // 
            AccountingBtn.BackgroundImage = Properties.Resources.butt_background;
            AccountingBtn.BackgroundImageLayout = ImageLayout.Stretch;
            AccountingBtn.Cursor = Cursors.Hand;
            AccountingBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccountingBtn.Image = Properties.Resources.top_input_butt;
            AccountingBtn.Location = new Point(17, 17);
            AccountingBtn.Margin = new Padding(4, 5, 4, 5);
            AccountingBtn.Name = "AccountingBtn";
            AccountingBtn.Size = new Size(181, 118);
            AccountingBtn.TabIndex = 2;
            AccountingBtn.Text = "Accounting F2";
            AccountingBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            AccountingBtn.UseVisualStyleBackColor = true;
            // 
            // CloseBtn
            // 
            CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseBtn.BackgroundImage = Properties.Resources.Close_butt;
            CloseBtn.BackgroundImageLayout = ImageLayout.Stretch;
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.Location = new Point(1817, 18);
            CloseBtn.Margin = new Padding(4, 5, 4, 5);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(29, 33);
            CloseBtn.TabIndex = 1;
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += closeBtn_Click;
            // 
            // MinBtn
            // 
            MinBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinBtn.BackgroundImage = Properties.Resources.min_butt;
            MinBtn.BackgroundImageLayout = ImageLayout.Stretch;
            MinBtn.Cursor = Cursors.Hand;
            MinBtn.Location = new Point(1784, 18);
            MinBtn.Margin = new Padding(4, 5, 4, 5);
            MinBtn.Name = "MinBtn";
            MinBtn.Size = new Size(29, 33);
            MinBtn.TabIndex = 0;
            MinBtn.UseVisualStyleBackColor = true;
            MinBtn.Click += minBtn_Click;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = SystemColors.MenuBar;
            bottomPanel.Controls.Add(label2);
            bottomPanel.Controls.Add(DateTimeLabel);
            bottomPanel.Controls.Add(UserLabel);
            bottomPanel.Controls.Add(UserPictureBox);
            bottomPanel.Controls.Add(BackgroundComboBox);
            bottomPanel.Controls.Add(label1);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 1082);
            bottomPanel.Margin = new Padding(4, 5, 4, 5);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(1871, 101);
            bottomPanel.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(898, 5);
            label2.Name = "label2";
            label2.Size = new Size(25, 92);
            label2.TabIndex = 5;
            label2.Text = "-";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DateTimeLabel
            // 
            DateTimeLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateTimeLabel.Location = new Point(929, 5);
            DateTimeLabel.Name = "DateTimeLabel";
            DateTimeLabel.Size = new Size(930, 92);
            DateTimeLabel.TabIndex = 4;
            DateTimeLabel.Text = "-";
            DateTimeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserLabel
            // 
            UserLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLabel.Location = new Point(513, 4);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(379, 92);
            UserLabel.TabIndex = 3;
            UserLabel.Text = "-";
            UserLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserPictureBox
            // 
            UserPictureBox.Location = new Point(360, 0);
            UserPictureBox.Name = "UserPictureBox";
            UserPictureBox.Size = new Size(150, 100);
            UserPictureBox.TabIndex = 2;
            UserPictureBox.TabStop = false;
            // 
            // BackgroundComboBox
            // 
            BackgroundComboBox.Cursor = Cursors.Hand;
            BackgroundComboBox.FormattingEnabled = true;
            BackgroundComboBox.Items.AddRange(new object[] { "Image 1", "Image 2", "Image 3", "Image 4", "Image 5", "Image 6" });
            BackgroundComboBox.Location = new Point(144, 28);
            BackgroundComboBox.Name = "BackgroundComboBox";
            BackgroundComboBox.Size = new Size(182, 33);
            BackgroundComboBox.TabIndex = 1;
            BackgroundComboBox.SelectedIndexChanged += BackgroundComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 36);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 0;
            label1.Text = "Background: ";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1871, 1183);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accounting Software";
            WindowState = FormWindowState.Maximized;
            Load += MainFrm_Load;
            topPanel.ResumeLayout(false);
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Panel bottomPanel;
        private Button CloseBtn;
        private Button MinBtn;
        private Button AccountingBtn;
        private Button ReportsBtn;
        private Button HelpBtn;
        private Button ToolsBtn;
        private ComboBox BackgroundComboBox;
        private Label label1;
        private Label UserLabel;
        private PictureBox UserPictureBox;
        private Label label2;
        private Label DateTimeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}
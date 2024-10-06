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
            topPanel = new Panel();
            HelpBtn = new Button();
            ToolsBtn = new Button();
            ReportsBtn = new Button();
            AccountingBtn = new Button();
            CloseBtn = new Button();
            MinBtn = new Button();
            bottomPanel = new Panel();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = SystemColors.ScrollBar;
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
            CloseBtn.BackgroundImageLayout = ImageLayout.Stretch;
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.Image = Properties.Resources._34217_close_delete_remove_icon;
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
            MinBtn.BackgroundImageLayout = ImageLayout.Stretch;
            MinBtn.Cursor = Cursors.Hand;
            MinBtn.Image = Properties.Resources._623091_box_minimize_close_delete_minus_icon__2_;
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
            bottomPanel.BackColor = SystemColors.ScrollBar;
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 1083);
            bottomPanel.Margin = new Padding(4, 5, 4, 5);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(1871, 100);
            bottomPanel.TabIndex = 1;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
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
            topPanel.ResumeLayout(false);
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
    }
}
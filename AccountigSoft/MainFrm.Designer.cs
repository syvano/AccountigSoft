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
            closeBtn = new Button();
            minBtn = new Button();
            bottomPanel = new Panel();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = SystemColors.ScrollBar;
            topPanel.Controls.Add(closeBtn);
            topPanel.Controls.Add(minBtn);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1310, 100);
            topPanel.TabIndex = 0;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeBtn.Location = new Point(1244, 19);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(47, 36);
            closeBtn.TabIndex = 1;
            closeBtn.Text = "close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // minBtn
            // 
            minBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minBtn.Location = new Point(1191, 19);
            minBtn.Name = "minBtn";
            minBtn.Size = new Size(47, 36);
            minBtn.TabIndex = 0;
            minBtn.Text = "min";
            minBtn.UseVisualStyleBackColor = true;
            minBtn.Click += minBtn_Click;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = SystemColors.ScrollBar;
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 650);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(1310, 60);
            bottomPanel.TabIndex = 1;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 710);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button closeBtn;
        private Button minBtn;
    }
}
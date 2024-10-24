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
            TreeNode treeNode1 = new TreeNode("Customers", 1, 1);
            TreeNode treeNode2 = new TreeNode("Sales Invoice", 9, 9);
            TreeNode treeNode3 = new TreeNode("Purchase Bill", 5, 5);
            TreeNode treeNode4 = new TreeNode("Invoices", 3, 3, new TreeNode[] { treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Send Money", 10, 10);
            TreeNode treeNode6 = new TreeNode("Recieve Money", 6, 6);
            TreeNode treeNode7 = new TreeNode("Payments", 4, 4, new TreeNode[] { treeNode5, treeNode6 });
            TreeNode treeNode8 = new TreeNode("Expenses", 2, 2);
            TreeNode treeNode9 = new TreeNode("All Tasks", 8, 8, new TreeNode[] { treeNode1, treeNode4, treeNode7, treeNode8 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
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
            panel1 = new Panel();
            treeView1 = new TreeView();
            imageList1 = new ImageList(components);
            topPanel.SuspendLayout();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = SystemColors.MenuBar;
            topPanel.BackgroundImage = Properties.Resources.butt_background;
            topPanel.BackgroundImageLayout = ImageLayout.Stretch;
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
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(treeView1);
            panel1.Location = new Point(22, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 445);
            panel1.TabIndex = 2;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageList1;
            treeView1.Indent = 40;
            treeView1.ItemHeight = 45;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "customers";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Customers";
            treeNode2.ImageIndex = 9;
            treeNode2.Name = "salesInvoice";
            treeNode2.SelectedImageIndex = 9;
            treeNode2.Text = "Sales Invoice";
            treeNode3.ImageIndex = 5;
            treeNode3.Name = "purchaseBill";
            treeNode3.SelectedImageIndex = 5;
            treeNode3.Text = "Purchase Bill";
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "invoices";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Text = "Invoices";
            treeNode5.ImageIndex = 10;
            treeNode5.Name = "sendMoney";
            treeNode5.SelectedImageIndex = 10;
            treeNode5.Text = "Send Money";
            treeNode6.ImageIndex = 6;
            treeNode6.Name = "recieveMoney";
            treeNode6.SelectedImageIndex = 6;
            treeNode6.Text = "Recieve Money";
            treeNode7.ImageIndex = 4;
            treeNode7.Name = "payments";
            treeNode7.SelectedImageIndex = 4;
            treeNode7.Text = "Payments";
            treeNode8.ImageIndex = 2;
            treeNode8.Name = "expenses";
            treeNode8.SelectedImageIndex = 2;
            treeNode8.Text = "Expenses";
            treeNode9.ImageIndex = 8;
            treeNode9.Name = "allTasks";
            treeNode9.SelectedImageIndex = 8;
            treeNode9.Text = "All Tasks";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode9 });
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(398, 443);
            treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "products.png");
            imageList1.Images.SetKeyName(1, "tree_customers.png");
            imageList1.Images.SetKeyName(2, "tree_expense.png");
            imageList1.Images.SetKeyName(3, "tree_invoice.png");
            imageList1.Images.SetKeyName(4, "tree_payment.png");
            imageList1.Images.SetKeyName(5, "tree_purchase_bill.png");
            imageList1.Images.SetKeyName(6, "tree_receive.png");
            imageList1.Images.SetKeyName(7, "tree_reports.png");
            imageList1.Images.SetKeyName(8, "tree_root.png");
            imageList1.Images.SetKeyName(9, "tree_sale_invoice.png");
            imageList1.Images.SetKeyName(10, "tree_spend.png");
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1871, 1183);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
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
        private Panel panel1;
        private TreeView treeView1;
        private ImageList imageList1;
    }
}
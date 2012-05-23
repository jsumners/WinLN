namespace com.jrfom.winln
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
			this.tabs = new System.Windows.Forms.TabControl();
			this.tabOne = new System.Windows.Forms.TabPage();
			this.tabTwo = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dirWinLnNameTxt = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dirDestNameTxt = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.createDirLinkBtn = new System.Windows.Forms.Button();
			this.dstDirSelectBtn = new System.Windows.Forms.Button();
			this.destDirTxt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.sourceDirSelectBtn = new System.Windows.Forms.Button();
			this.sourceDirTxt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dirRemoveBtn = new System.Windows.Forms.Button();
			this.dirDetailDate = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dirDetailDest = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dirDetailSource = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dirLinksList = new System.Windows.Forms.ListBox();
			this.dirSourceDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.dirDestDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.fileWinLnNameTxt = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.fileCreateBtn = new System.Windows.Forms.Button();
			this.fileDestBtn = new System.Windows.Forms.Button();
			this.fileDestTxt = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.fileSourceBtn = new System.Windows.Forms.Button();
			this.fileSourceTxt = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.fileLinksList = new System.Windows.Forms.ListBox();
			this.fileRemoveBtn = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.fileDetailSource = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.fileDetailDate = new System.Windows.Forms.Label();
			this.fileDetailDest = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.fileSourceDialog = new System.Windows.Forms.OpenFileDialog();
			this.fileDestDialog = new System.Windows.Forms.SaveFileDialog();
			this.tabs.SuspendLayout();
			this.tabOne.SuspendLayout();
			this.tabTwo.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabs
			// 
			this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabs.Controls.Add(this.tabOne);
			this.tabs.Controls.Add(this.tabTwo);
			this.tabs.Location = new System.Drawing.Point(13, 13);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(607, 413);
			this.tabs.TabIndex = 0;
			// 
			// tabOne
			// 
			this.tabOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabOne.Controls.Add(this.groupBox3);
			this.tabOne.Controls.Add(this.fileLinksList);
			this.tabOne.Controls.Add(this.groupBox4);
			this.tabOne.Location = new System.Drawing.Point(4, 25);
			this.tabOne.Name = "tabOne";
			this.tabOne.Padding = new System.Windows.Forms.Padding(3);
			this.tabOne.Size = new System.Drawing.Size(599, 384);
			this.tabOne.TabIndex = 0;
			this.tabOne.Text = "File Links";
			this.tabOne.UseVisualStyleBackColor = true;
			// 
			// tabTwo
			// 
			this.tabTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabTwo.Controls.Add(this.groupBox2);
			this.tabTwo.Controls.Add(this.groupBox1);
			this.tabTwo.Controls.Add(this.dirLinksList);
			this.tabTwo.Location = new System.Drawing.Point(4, 25);
			this.tabTwo.Name = "tabTwo";
			this.tabTwo.Padding = new System.Windows.Forms.Padding(3);
			this.tabTwo.Size = new System.Drawing.Size(599, 384);
			this.tabTwo.TabIndex = 1;
			this.tabTwo.Text = "Dir Links";
			this.tabTwo.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.dirWinLnNameTxt);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.dirDestNameTxt);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.createDirLinkBtn);
			this.groupBox2.Controls.Add(this.dstDirSelectBtn);
			this.groupBox2.Controls.Add(this.destDirTxt);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.sourceDirSelectBtn);
			this.groupBox2.Controls.Add(this.sourceDirTxt);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(208, 167);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(383, 207);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Add Link";
			// 
			// dirWinLnNameTxt
			// 
			this.dirWinLnNameTxt.Location = new System.Drawing.Point(10, 36);
			this.dirWinLnNameTxt.Name = "dirWinLnNameTxt";
			this.dirWinLnNameTxt.Size = new System.Drawing.Size(288, 20);
			this.dirWinLnNameTxt.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(8, 20);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "WinLN Name";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(121, 137);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 13);
			this.label7.TabIndex = 9;
			this.label7.Text = "(optional)";
			// 
			// dirDestNameTxt
			// 
			this.dirDestNameTxt.Location = new System.Drawing.Point(10, 153);
			this.dirDestNameTxt.Name = "dirDestNameTxt";
			this.dirDestNameTxt.Size = new System.Drawing.Size(286, 20);
			this.dirDestNameTxt.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 137);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(107, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Destination Name";
			// 
			// createDirLinkBtn
			// 
			this.createDirLinkBtn.Enabled = false;
			this.createDirLinkBtn.Location = new System.Drawing.Point(303, 178);
			this.createDirLinkBtn.Name = "createDirLinkBtn";
			this.createDirLinkBtn.Size = new System.Drawing.Size(75, 23);
			this.createDirLinkBtn.TabIndex = 6;
			this.createDirLinkBtn.Text = "Create";
			this.createDirLinkBtn.UseVisualStyleBackColor = true;
			this.createDirLinkBtn.Click += new System.EventHandler(this.createDirLinkBtn_Click);
			// 
			// dstDirSelectBtn
			// 
			this.dstDirSelectBtn.Location = new System.Drawing.Point(304, 114);
			this.dstDirSelectBtn.Name = "dstDirSelectBtn";
			this.dstDirSelectBtn.Size = new System.Drawing.Size(75, 23);
			this.dstDirSelectBtn.TabIndex = 5;
			this.dstDirSelectBtn.Text = "Destination";
			this.dstDirSelectBtn.UseVisualStyleBackColor = true;
			this.dstDirSelectBtn.Click += new System.EventHandler(this.dstDirSelectBtn_Click);
			// 
			// destDirTxt
			// 
			this.destDirTxt.Location = new System.Drawing.Point(10, 114);
			this.destDirTxt.Name = "destDirTxt";
			this.destDirTxt.Size = new System.Drawing.Size(288, 20);
			this.destDirTxt.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Destination Parent";
			// 
			// sourceDirSelectBtn
			// 
			this.sourceDirSelectBtn.Location = new System.Drawing.Point(302, 75);
			this.sourceDirSelectBtn.Name = "sourceDirSelectBtn";
			this.sourceDirSelectBtn.Size = new System.Drawing.Size(75, 23);
			this.sourceDirSelectBtn.TabIndex = 2;
			this.sourceDirSelectBtn.Text = "Select";
			this.sourceDirSelectBtn.UseVisualStyleBackColor = true;
			this.sourceDirSelectBtn.Click += new System.EventHandler(this.sourceDirSelectBtn_Click);
			// 
			// sourceDirTxt
			// 
			this.sourceDirTxt.Location = new System.Drawing.Point(11, 75);
			this.sourceDirTxt.Name = "sourceDirTxt";
			this.sourceDirTxt.Size = new System.Drawing.Size(286, 20);
			this.sourceDirTxt.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Source";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.dirRemoveBtn);
			this.groupBox1.Controls.Add(this.dirDetailDate);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dirDetailDest);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.dirDetailSource);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(208, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(383, 154);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Link Details";
			// 
			// dirRemoveBtn
			// 
			this.dirRemoveBtn.Enabled = false;
			this.dirRemoveBtn.Location = new System.Drawing.Point(302, 125);
			this.dirRemoveBtn.Name = "dirRemoveBtn";
			this.dirRemoveBtn.Size = new System.Drawing.Size(75, 23);
			this.dirRemoveBtn.TabIndex = 6;
			this.dirRemoveBtn.Text = "Remove";
			this.dirRemoveBtn.UseVisualStyleBackColor = true;
			this.dirRemoveBtn.Click += new System.EventHandler(this.dirRemoveBtn_Click);
			// 
			// dirDetailDate
			// 
			this.dirDetailDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dirDetailDate.AutoSize = true;
			this.dirDetailDate.Location = new System.Drawing.Point(88, 77);
			this.dirDetailDate.Name = "dirDetailDate";
			this.dirDetailDate.Size = new System.Drawing.Size(35, 13);
			this.dirDetailDate.TabIndex = 5;
			this.dirDetailDate.Text = "label6";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(7, 77);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Date:";
			// 
			// dirDetailDest
			// 
			this.dirDetailDest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dirDetailDest.AutoSize = true;
			this.dirDetailDest.Location = new System.Drawing.Point(88, 46);
			this.dirDetailDest.Name = "dirDetailDest";
			this.dirDetailDest.Size = new System.Drawing.Size(35, 13);
			this.dirDetailDest.TabIndex = 3;
			this.dirDetailDest.Text = "label5";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Destination:";
			// 
			// dirDetailSource
			// 
			this.dirDetailSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dirDetailSource.AutoSize = true;
			this.dirDetailSource.Location = new System.Drawing.Point(88, 20);
			this.dirDetailSource.Name = "dirDetailSource";
			this.dirDetailSource.Size = new System.Drawing.Size(163, 13);
			this.dirDetailSource.TabIndex = 1;
			this.dirDetailSource.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaa";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(7, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Source:";
			// 
			// dirLinksList
			// 
			this.dirLinksList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dirLinksList.FormattingEnabled = true;
			this.dirLinksList.Location = new System.Drawing.Point(7, 7);
			this.dirLinksList.Name = "dirLinksList";
			this.dirLinksList.Size = new System.Drawing.Size(195, 368);
			this.dirLinksList.TabIndex = 0;
			this.dirLinksList.SelectedIndexChanged += new System.EventHandler(this.dirLinksList_SelectedIndexChanged);
			// 
			// fileWinLnNameTxt
			// 
			this.fileWinLnNameTxt.Location = new System.Drawing.Point(10, 36);
			this.fileWinLnNameTxt.Name = "fileWinLnNameTxt";
			this.fileWinLnNameTxt.Size = new System.Drawing.Size(288, 20);
			this.fileWinLnNameTxt.TabIndex = 11;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(8, 20);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 13);
			this.label9.TabIndex = 10;
			this.label9.Text = "WinLN Name";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.fileWinLnNameTxt);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.fileCreateBtn);
			this.groupBox3.Controls.Add(this.fileDestBtn);
			this.groupBox3.Controls.Add(this.fileDestTxt);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.fileSourceBtn);
			this.groupBox3.Controls.Add(this.fileSourceTxt);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Location = new System.Drawing.Point(207, 166);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(383, 207);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Add Link";
			// 
			// fileCreateBtn
			// 
			this.fileCreateBtn.Enabled = false;
			this.fileCreateBtn.Location = new System.Drawing.Point(303, 178);
			this.fileCreateBtn.Name = "fileCreateBtn";
			this.fileCreateBtn.Size = new System.Drawing.Size(75, 23);
			this.fileCreateBtn.TabIndex = 6;
			this.fileCreateBtn.Text = "Create";
			this.fileCreateBtn.UseVisualStyleBackColor = true;
			this.fileCreateBtn.Click += new System.EventHandler(this.fileCreateLinkBtn_Click);
			// 
			// fileDestBtn
			// 
			this.fileDestBtn.Location = new System.Drawing.Point(304, 114);
			this.fileDestBtn.Name = "fileDestBtn";
			this.fileDestBtn.Size = new System.Drawing.Size(75, 23);
			this.fileDestBtn.TabIndex = 5;
			this.fileDestBtn.Text = "Destination";
			this.fileDestBtn.UseVisualStyleBackColor = true;
			this.fileDestBtn.Click += new System.EventHandler(this.destFileSelectBtn_Click);
			// 
			// fileDestTxt
			// 
			this.fileDestTxt.Location = new System.Drawing.Point(10, 114);
			this.fileDestTxt.Name = "fileDestTxt";
			this.fileDestTxt.Size = new System.Drawing.Size(288, 20);
			this.fileDestTxt.TabIndex = 4;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(8, 98);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(112, 13);
			this.label12.TabIndex = 3;
			this.label12.Text = "Destination Parent";
			// 
			// fileSourceBtn
			// 
			this.fileSourceBtn.Location = new System.Drawing.Point(302, 75);
			this.fileSourceBtn.Name = "fileSourceBtn";
			this.fileSourceBtn.Size = new System.Drawing.Size(75, 23);
			this.fileSourceBtn.TabIndex = 2;
			this.fileSourceBtn.Text = "Select";
			this.fileSourceBtn.UseVisualStyleBackColor = true;
			this.fileSourceBtn.Click += new System.EventHandler(this.sourceFileSelectBtn_Click);
			// 
			// fileSourceTxt
			// 
			this.fileSourceTxt.Location = new System.Drawing.Point(11, 75);
			this.fileSourceTxt.Name = "fileSourceTxt";
			this.fileSourceTxt.Size = new System.Drawing.Size(286, 20);
			this.fileSourceTxt.TabIndex = 1;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(8, 59);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(47, 13);
			this.label13.TabIndex = 0;
			this.label13.Text = "Source";
			// 
			// fileLinksList
			// 
			this.fileLinksList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.fileLinksList.FormattingEnabled = true;
			this.fileLinksList.Location = new System.Drawing.Point(6, 6);
			this.fileLinksList.Name = "fileLinksList";
			this.fileLinksList.Size = new System.Drawing.Size(195, 368);
			this.fileLinksList.TabIndex = 3;
			this.fileLinksList.SelectedIndexChanged += new System.EventHandler(this.fileLinksList_SelectedIndexChanged);
			// 
			// fileRemoveBtn
			// 
			this.fileRemoveBtn.Enabled = false;
			this.fileRemoveBtn.Location = new System.Drawing.Point(302, 125);
			this.fileRemoveBtn.Name = "fileRemoveBtn";
			this.fileRemoveBtn.Size = new System.Drawing.Size(75, 23);
			this.fileRemoveBtn.TabIndex = 6;
			this.fileRemoveBtn.Text = "Remove";
			this.fileRemoveBtn.UseVisualStyleBackColor = true;
			this.fileRemoveBtn.Click += new System.EventHandler(this.fileRemoveBtn_Click);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(7, 77);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(38, 13);
			this.label14.TabIndex = 4;
			this.label14.Text = "Date:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(6, 46);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(75, 13);
			this.label15.TabIndex = 2;
			this.label15.Text = "Destination:";
			// 
			// fileDetailSource
			// 
			this.fileDetailSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.fileDetailSource.AutoSize = true;
			this.fileDetailSource.Location = new System.Drawing.Point(88, 20);
			this.fileDetailSource.Name = "fileDetailSource";
			this.fileDetailSource.Size = new System.Drawing.Size(163, 13);
			this.fileDetailSource.TabIndex = 1;
			this.fileDetailSource.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaa";
			// 
			// label17
			// 
			this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(7, 20);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(51, 13);
			this.label17.TabIndex = 0;
			this.label17.Text = "Source:";
			// 
			// fileDetailDate
			// 
			this.fileDetailDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.fileDetailDate.AutoSize = true;
			this.fileDetailDate.Location = new System.Drawing.Point(88, 77);
			this.fileDetailDate.Name = "fileDetailDate";
			this.fileDetailDate.Size = new System.Drawing.Size(35, 13);
			this.fileDetailDate.TabIndex = 5;
			this.fileDetailDate.Text = "label6";
			// 
			// fileDetailDest
			// 
			this.fileDetailDest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.fileDetailDest.AutoSize = true;
			this.fileDetailDest.Location = new System.Drawing.Point(88, 46);
			this.fileDetailDest.Name = "fileDetailDest";
			this.fileDetailDest.Size = new System.Drawing.Size(35, 13);
			this.fileDetailDest.TabIndex = 3;
			this.fileDetailDest.Text = "label5";
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.fileRemoveBtn);
			this.groupBox4.Controls.Add(this.fileDetailDate);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.fileDetailDest);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Controls.Add(this.fileDetailSource);
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Location = new System.Drawing.Point(207, 6);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(383, 154);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Link Details";
			// 
			// fileSourceDialog
			// 
			this.fileSourceDialog.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 438);
			this.Controls.Add(this.tabs);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "WinLN";
			this.tabs.ResumeLayout(false);
			this.tabOne.ResumeLayout(false);
			this.tabTwo.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabOne;
        private System.Windows.Forms.TabPage tabTwo;
        private System.Windows.Forms.ListBox dirLinksList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button createDirLinkBtn;
        private System.Windows.Forms.Button dstDirSelectBtn;
        private System.Windows.Forms.TextBox destDirTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sourceDirSelectBtn;
        private System.Windows.Forms.TextBox sourceDirTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dirDetailSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dirRemoveBtn;
        private System.Windows.Forms.Label dirDetailDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dirDetailDest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog dirSourceDialog;
        private System.Windows.Forms.FolderBrowserDialog dirDestDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dirDestNameTxt;
        private System.Windows.Forms.TextBox dirWinLnNameTxt;
        private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox fileWinLnNameTxt;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button fileCreateBtn;
		private System.Windows.Forms.Button fileDestBtn;
		private System.Windows.Forms.TextBox fileDestTxt;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button fileSourceBtn;
		private System.Windows.Forms.TextBox fileSourceTxt;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ListBox fileLinksList;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button fileRemoveBtn;
		private System.Windows.Forms.Label fileDetailDate;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label fileDetailDest;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label fileDetailSource;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.OpenFileDialog fileSourceDialog;
		private System.Windows.Forms.SaveFileDialog fileDestDialog;
    }
}


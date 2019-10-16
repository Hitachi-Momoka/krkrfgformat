using System.Windows.Forms;

namespace Li.krkrfgformat
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.savePathBox = new System.Windows.Forms.TextBox();
            this.TextPatchShow = new System.Windows.Forms.TextBox();
            this.saveFolderPatch = new System.Windows.Forms.Button();
            this.selectTextFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openOutFolder = new System.Windows.Forms.Button();
            this.formatOne = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mixTab = new System.Windows.Forms.TabControl();
            this.freeMix1 = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.fgPart_4 = new System.Windows.Forms.ListBox();
            this.fgPart_5 = new System.Windows.Forms.ListBox();
            this.fgPart_6 = new System.Windows.Forms.ListBox();
            this.fgPart_3 = new System.Windows.Forms.ListBox();
            this.fgPart_2 = new System.Windows.Forms.ListBox();
            this.fgPart_1 = new System.Windows.Forms.ListBox();
            this.freeMix2 = new System.Windows.Forms.TabPage();
            this.fgPart_12 = new System.Windows.Forms.ListBox();
            this.fgPart_11 = new System.Windows.Forms.ListBox();
            this.fgPart_10 = new System.Windows.Forms.ListBox();
            this.fgPart_9 = new System.Windows.Forms.ListBox();
            this.fgPart_8 = new System.Windows.Forms.ListBox();
            this.fgPart_7 = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.mixTab.SuspendLayout();
            this.freeMix1.SuspendLayout();
            this.freeMix2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(586, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.PictureBox1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.savePathBox);
            this.groupBox1.Controls.Add(this.TextPatchShow);
            this.groupBox1.Controls.Add(this.saveFolderPatch);
            this.groupBox1.Controls.Add(this.selectTextFile);
            this.groupBox1.Location = new System.Drawing.Point(18, 494);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 88);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "路径信息";
            // 
            // savePathBox
            // 
            this.savePathBox.Location = new System.Drawing.Point(118, 50);
            this.savePathBox.Name = "savePathBox";
            this.savePathBox.ReadOnly = true;
            this.savePathBox.Size = new System.Drawing.Size(323, 21);
            this.savePathBox.TabIndex = 13;
            // 
            // TextPatchShow
            // 
            this.TextPatchShow.Location = new System.Drawing.Point(118, 19);
            this.TextPatchShow.Name = "TextPatchShow";
            this.TextPatchShow.ReadOnly = true;
            this.TextPatchShow.Size = new System.Drawing.Size(323, 21);
            this.TextPatchShow.TabIndex = 12;
            // 
            // saveFolderPatch
            // 
            this.saveFolderPatch.Location = new System.Drawing.Point(16, 48);
            this.saveFolderPatch.Name = "saveFolderPatch";
            this.saveFolderPatch.Size = new System.Drawing.Size(81, 22);
            this.saveFolderPatch.TabIndex = 11;
            this.saveFolderPatch.Text = "保存位置";
            this.saveFolderPatch.UseVisualStyleBackColor = true;
            this.saveFolderPatch.Click += new System.EventHandler(this.SaveFolderPatch_Click);
            // 
            // selectTextFile
            // 
            this.selectTextFile.Location = new System.Drawing.Point(16, 20);
            this.selectTextFile.Name = "selectTextFile";
            this.selectTextFile.Size = new System.Drawing.Size(81, 22);
            this.selectTextFile.TabIndex = 8;
            this.selectTextFile.Text = "坐标文件路径";
            this.selectTextFile.UseVisualStyleBackColor = true;
            this.selectTextFile.Click += new System.EventHandler(this.SelectTextFile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.openOutFolder);
            this.groupBox2.Controls.Add(this.formatOne);
            this.groupBox2.Location = new System.Drawing.Point(477, 494);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(94, 87);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "合成";
            // 
            // openOutFolder
            // 
            this.openOutFolder.Location = new System.Drawing.Point(7, 48);
            this.openOutFolder.Name = "openOutFolder";
            this.openOutFolder.Size = new System.Drawing.Size(81, 22);
            this.openOutFolder.TabIndex = 13;
            this.openOutFolder.Text = "打开输出目录";
            this.openOutFolder.UseVisualStyleBackColor = true;
            this.openOutFolder.Click += new System.EventHandler(this.OpenOutFolder_Click);
            // 
            // formatOne
            // 
            this.formatOne.Location = new System.Drawing.Point(7, 20);
            this.formatOne.Name = "formatOne";
            this.formatOne.Size = new System.Drawing.Size(81, 22);
            this.formatOne.TabIndex = 12;
            this.formatOne.Text = "合成选择";
            this.formatOne.UseVisualStyleBackColor = true;
            this.formatOne.Click += new System.EventHandler(this.FormatOne_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(897, 25);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "清空";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton1.Text = "清空所有";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton2.Text = "取消选择";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(39, 22);
            this.toolStripButton3.Text = "Help";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(897, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // mixTab
            // 
            this.mixTab.Controls.Add(this.freeMix1);
            this.mixTab.Controls.Add(this.freeMix2);
            this.mixTab.Location = new System.Drawing.Point(16, 28);
            this.mixTab.Name = "mixTab";
            this.mixTab.SelectedIndex = 0;
            this.mixTab.Size = new System.Drawing.Size(564, 460);
            this.mixTab.TabIndex = 20;
            // 
            // freeMix1
            // 
            this.freeMix1.BackColor = System.Drawing.SystemColors.Control;
            this.freeMix1.Controls.Add(this.checkBox2);
            this.freeMix1.Controls.Add(this.fgPart_4);
            this.freeMix1.Controls.Add(this.fgPart_5);
            this.freeMix1.Controls.Add(this.fgPart_6);
            this.freeMix1.Controls.Add(this.fgPart_3);
            this.freeMix1.Controls.Add(this.fgPart_2);
            this.freeMix1.Controls.Add(this.fgPart_1);
            this.freeMix1.Location = new System.Drawing.Point(4, 22);
            this.freeMix1.Name = "freeMix1";
            this.freeMix1.Padding = new System.Windows.Forms.Padding(3);
            this.freeMix1.Size = new System.Drawing.Size(556, 434);
            this.freeMix1.TabIndex = 0;
            this.freeMix1.Text = "部件1";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(139, 216);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(156, 16);
            this.checkBox2.TabIndex = 36;
            this.checkBox2.Text = "只用图片大小寻找规则  ";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // fgPart_4
            // 
            this.fgPart_4.BackColor = System.Drawing.SystemColors.Control;
            this.fgPart_4.FormattingEnabled = true;
            this.fgPart_4.ItemHeight = 12;
            this.fgPart_4.Location = new System.Drawing.Point(6, 225);
            this.fgPart_4.Name = "fgPart_4";
            this.fgPart_4.Size = new System.Drawing.Size(153, 196);
            this.fgPart_4.TabIndex = 33;
            this.fgPart_4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            this.fgPart_4.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.fgPart_4.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.fgPart_4.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // fgPart_5
            // 
            this.fgPart_5.BackColor = System.Drawing.SystemColors.Control;
            this.fgPart_5.FormattingEnabled = true;
            this.fgPart_5.ItemHeight = 12;
            this.fgPart_5.Location = new System.Drawing.Point(197, 225);
            this.fgPart_5.Name = "fgPart_5";
            this.fgPart_5.Size = new System.Drawing.Size(153, 196);
            this.fgPart_5.TabIndex = 34;
            this.fgPart_5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            this.fgPart_5.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.fgPart_5.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.fgPart_5.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // fgPart_6
            // 
            this.fgPart_6.BackColor = System.Drawing.SystemColors.Control;
            this.fgPart_6.FormattingEnabled = true;
            this.fgPart_6.ItemHeight = 12;
            this.fgPart_6.Location = new System.Drawing.Point(392, 225);
            this.fgPart_6.Name = "fgPart_6";
            this.fgPart_6.Size = new System.Drawing.Size(153, 196);
            this.fgPart_6.TabIndex = 35;
            this.fgPart_6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            this.fgPart_6.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.fgPart_6.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.fgPart_6.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // fgPart_3
            // 
            this.fgPart_3.BackColor = System.Drawing.SystemColors.Control;
            this.fgPart_3.FormattingEnabled = true;
            this.fgPart_3.ItemHeight = 12;
            this.fgPart_3.Location = new System.Drawing.Point(392, 14);
            this.fgPart_3.Name = "fgPart_3";
            this.fgPart_3.Size = new System.Drawing.Size(153, 196);
            this.fgPart_3.TabIndex = 32;
            this.fgPart_3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            this.fgPart_3.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.fgPart_3.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.fgPart_3.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // fgPart_2
            // 
            this.fgPart_2.BackColor = System.Drawing.SystemColors.Control;
            this.fgPart_2.FormattingEnabled = true;
            this.fgPart_2.ItemHeight = 12;
            this.fgPart_2.Location = new System.Drawing.Point(197, 14);
            this.fgPart_2.Name = "fgPart_2";
            this.fgPart_2.Size = new System.Drawing.Size(153, 196);
            this.fgPart_2.TabIndex = 31;
            this.fgPart_2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            this.fgPart_2.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.fgPart_2.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.fgPart_2.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // fgPart_1
            // 
            this.fgPart_1.AllowDrop = true;
            this.fgPart_1.FormattingEnabled = true;
            this.fgPart_1.ItemHeight = 12;
            this.fgPart_1.Location = new System.Drawing.Point(6, 14);
            this.fgPart_1.Name = "fgPart_1";
            this.fgPart_1.Size = new System.Drawing.Size(153, 196);
            this.fgPart_1.TabIndex = 30;
            this.fgPart_1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            this.fgPart_1.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.fgPart_1.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.fgPart_1.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // freeMix2
            // 
            this.freeMix2.BackColor = System.Drawing.SystemColors.Control;
            this.freeMix2.Controls.Add(this.fgPart_12);
            this.freeMix2.Controls.Add(this.fgPart_11);
            this.freeMix2.Controls.Add(this.fgPart_10);
            this.freeMix2.Controls.Add(this.fgPart_9);
            this.freeMix2.Controls.Add(this.fgPart_8);
            this.freeMix2.Controls.Add(this.fgPart_7);
            this.freeMix2.Location = new System.Drawing.Point(4, 22);
            this.freeMix2.Name = "freeMix2";
            this.freeMix2.Padding = new System.Windows.Forms.Padding(3);
            this.freeMix2.Size = new System.Drawing.Size(556, 434);
            this.freeMix2.TabIndex = 1;
            this.freeMix2.Text = "部件2";
            // 
            // fgPart_12
            // 
            this.fgPart_12.BackColor = System.Drawing.SystemColors.Control;
            this.fgPart_12.FormattingEnabled = true;
            this.fgPart_12.ItemHeight = 12;
            this.fgPart_12.Location = new System.Drawing.Point(392, 225);
            this.fgPart_12.Name = "fgPart_12";
            this.fgPart_12.Size = new System.Drawing.Size(153, 196);
            this.fgPart_12.TabIndex = 37;
            this.fgPart_12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            this.fgPart_12.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.fgPart_12.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.fgPart_12.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // fgPart_11
            // 
            this.fgPart_11.BackColor = System.Drawing.SystemColors.Control;
            this.fgPart_11.FormattingEnabled = true;
            this.fgPart_11.ItemHeight = 12;
            this.fgPart_11.Location = new System.Drawing.Point(197, 225);
            this.fgPart_11.Name = "fgPart_11";
            this.fgPart_11.Size = new System.Drawing.Size(153, 196);
            this.fgPart_11.TabIndex = 36;
            this.fgPart_11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            this.fgPart_11.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.fgPart_11.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.fgPart_11.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // fgPart_10
            // 
            this.fgPart_10.BackColor = System.Drawing.SystemColors.Control;
            this.fgPart_10.FormattingEnabled = true;
            this.fgPart_10.ItemHeight = 12;
            this.fgPart_10.Location = new System.Drawing.Point(6, 225);
            this.fgPart_10.Name = "fgPart_10";
            this.fgPart_10.Size = new System.Drawing.Size(153, 196);
            this.fgPart_10.TabIndex = 35;
            this.fgPart_10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            this.fgPart_10.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.fgPart_10.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.fgPart_10.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // fgPart_9
            // 
            this.fgPart_9.BackColor = System.Drawing.SystemColors.Control;
            this.fgPart_9.FormattingEnabled = true;
            this.fgPart_9.ItemHeight = 12;
            this.fgPart_9.Location = new System.Drawing.Point(392, 14);
            this.fgPart_9.Name = "fgPart_9";
            this.fgPart_9.Size = new System.Drawing.Size(153, 196);
            this.fgPart_9.TabIndex = 34;
            this.fgPart_9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            this.fgPart_9.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.fgPart_9.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.fgPart_9.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // fgPart_8
            // 
            this.fgPart_8.BackColor = System.Drawing.SystemColors.Control;
            this.fgPart_8.FormattingEnabled = true;
            this.fgPart_8.ItemHeight = 12;
            this.fgPart_8.Location = new System.Drawing.Point(197, 14);
            this.fgPart_8.Name = "fgPart_8";
            this.fgPart_8.Size = new System.Drawing.Size(153, 196);
            this.fgPart_8.TabIndex = 33;
            this.fgPart_8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            this.fgPart_8.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.fgPart_8.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.fgPart_8.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // fgPart_7
            // 
            this.fgPart_7.BackColor = System.Drawing.SystemColors.Control;
            this.fgPart_7.FormattingEnabled = true;
            this.fgPart_7.ItemHeight = 12;
            this.fgPart_7.Location = new System.Drawing.Point(6, 14);
            this.fgPart_7.Name = "fgPart_7";
            this.fgPart_7.Size = new System.Drawing.Size(153, 196);
            this.fgPart_7.TabIndex = 32;
            this.fgPart_7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            this.fgPart_7.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.fgPart_7.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.fgPart_7.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 606);
            this.Controls.Add(this.mixTab);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "KRKR立绘合成 BY：momoka";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mixTab.ResumeLayout(false);
            this.freeMix1.ResumeLayout(false);
            this.freeMix1.PerformLayout();
            this.freeMix2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public PictureBox pictureBox1;

        private GroupBox groupBox1;

        private TextBox savePathBox;

        private Button saveFolderPatch;

        private Button selectTextFile;

        private GroupBox groupBox2;

        private Button formatOne;

        public TextBox TextPatchShow;

        private ToolStrip toolStrip1;

        private ToolStripButton toolStripButton1;

        private ToolStripSeparator toolStripSeparator2;

        private ToolStripButton toolStripButton2;

        private StatusStrip statusStrip1;

        private TabControl mixTab;

        private ToolStripStatusLabel toolStripStatusLabel1;

        private TabPage freeMix1;

        private ListBox fgPart_6;

        private ListBox fgPart_5;

        private ListBox fgPart_4;

        private ListBox fgPart_3;

        private ListBox fgPart_2;

        private ListBox fgPart_1;

        private TabPage freeMix2;

        private ListBox fgPart_12;

        private ListBox fgPart_11;

        private ListBox fgPart_10;

        private ListBox fgPart_9;

        private ListBox fgPart_8;

        private ListBox fgPart_7;

        private ToolStripButton toolStripButton3;

        private Button openOutFolder;

        private ToolStripSeparator toolStripSeparator1;

        private ToolStripSeparator toolStripSeparator3;

        private CheckBox checkBox2;

        private ToolTip toolTip1;
        #endregion
    }
}


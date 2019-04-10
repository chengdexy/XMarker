namespace XMarker
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoggerList = new System.Windows.Forms.ListBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.OfficeGroup = new System.Windows.Forms.GroupBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.AddOfficeText = new System.Windows.Forms.TextBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.DeleteOfficeButton = new System.Windows.Forms.Button();
            this.AddOfficeButton = new System.Windows.Forms.Button();
            this.OfficeList = new System.Windows.Forms.ListBox();
            this.NumberGroup = new System.Windows.Forms.GroupBox();
            this.EndNumeric = new System.Windows.Forms.NumericUpDown();
            this.NumberEndLabel = new System.Windows.Forms.Label();
            this.StartNumeric = new System.Windows.Forms.NumericUpDown();
            this.NumberStartLabel = new System.Windows.Forms.Label();
            this.SolidGroup = new System.Windows.Forms.GroupBox();
            this.SolidLabel = new System.Windows.Forms.Label();
            this.SolidText = new System.Windows.Forms.TextBox();
            this.MarkRotationNumeric = new System.Windows.Forms.NumericUpDown();
            this.MarkRotationLabel = new System.Windows.Forms.Label();
            this.MarkFontLabel = new System.Windows.Forms.Label();
            this.MarkFontText = new System.Windows.Forms.TextBox();
            this.MarkFontButton = new System.Windows.Forms.Button();
            this.MarkSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.MarkSizeLabel = new System.Windows.Forms.Label();
            this.MarkColorLabel = new System.Windows.Forms.Label();
            this.MarkColorPicture = new System.Windows.Forms.PictureBox();
            this.MarkKindLabel = new System.Windows.Forms.Label();
            this.MarkKindGroup = new System.Windows.Forms.GroupBox();
            this.NumberRadio = new System.Windows.Forms.RadioButton();
            this.ListRadio = new System.Windows.Forms.RadioButton();
            this.SolidRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.TargetText = new System.Windows.Forms.TextBox();
            this.TargetButton = new System.Windows.Forms.Button();
            this.SourceText = new System.Windows.Forms.TextBox();
            this.SourceButton = new System.Windows.Forms.Button();
            this.SourceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TargetFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MarkFontDialog = new System.Windows.Forms.FontDialog();
            this.MarkColorDialog = new System.Windows.Forms.ColorDialog();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ListSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.ListOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.PrintButton = new System.Windows.Forms.Button();
            this.PrintDialog = new System.Windows.Forms.PrintDialog();
            this.groupBox1.SuspendLayout();
            this.OfficeGroup.SuspendLayout();
            this.NumberGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartNumeric)).BeginInit();
            this.SolidGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarkRotationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkSizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkColorPicture)).BeginInit();
            this.MarkKindGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrintButton);
            this.groupBox1.Controls.Add(this.LoggerList);
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Controls.Add(this.OfficeGroup);
            this.groupBox1.Controls.Add(this.NumberGroup);
            this.groupBox1.Controls.Add(this.SolidGroup);
            this.groupBox1.Controls.Add(this.MarkRotationNumeric);
            this.groupBox1.Controls.Add(this.MarkRotationLabel);
            this.groupBox1.Controls.Add(this.MarkFontLabel);
            this.groupBox1.Controls.Add(this.MarkFontText);
            this.groupBox1.Controls.Add(this.MarkFontButton);
            this.groupBox1.Controls.Add(this.MarkSizeNumeric);
            this.groupBox1.Controls.Add(this.MarkSizeLabel);
            this.groupBox1.Controls.Add(this.MarkColorLabel);
            this.groupBox1.Controls.Add(this.MarkColorPicture);
            this.groupBox1.Controls.Add(this.MarkKindLabel);
            this.groupBox1.Controls.Add(this.MarkKindGroup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SourceLabel);
            this.groupBox1.Controls.Add(this.TargetText);
            this.groupBox1.Controls.Add(this.TargetButton);
            this.groupBox1.Controls.Add(this.SourceText);
            this.groupBox1.Controls.Add(this.SourceButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "v1.0";
            // 
            // LoggerList
            // 
            this.LoggerList.BackColor = System.Drawing.Color.Black;
            this.LoggerList.ForeColor = System.Drawing.Color.LightGreen;
            this.LoggerList.FormattingEnabled = true;
            this.LoggerList.ItemHeight = 12;
            this.LoggerList.Location = new System.Drawing.Point(101, 305);
            this.LoggerList.Name = "LoggerList";
            this.LoggerList.Size = new System.Drawing.Size(295, 112);
            this.LoggerList.TabIndex = 24;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(20, 305);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 49);
            this.StartButton.TabIndex = 23;
            this.StartButton.Text = "Go!!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // OfficeGroup
            // 
            this.OfficeGroup.Controls.Add(this.ExportButton);
            this.OfficeGroup.Controls.Add(this.AddOfficeText);
            this.OfficeGroup.Controls.Add(this.ImportButton);
            this.OfficeGroup.Controls.Add(this.DeleteOfficeButton);
            this.OfficeGroup.Controls.Add(this.AddOfficeButton);
            this.OfficeGroup.Controls.Add(this.OfficeList);
            this.OfficeGroup.Location = new System.Drawing.Point(429, 176);
            this.OfficeGroup.Name = "OfficeGroup";
            this.OfficeGroup.Size = new System.Drawing.Size(269, 244);
            this.OfficeGroup.TabIndex = 22;
            this.OfficeGroup.TabStop = false;
            this.OfficeGroup.Text = "单位名称列表";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(222, 184);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(32, 49);
            this.ExportButton.TabIndex = 7;
            this.ExportButton.Text = "导出";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // AddOfficeText
            // 
            this.AddOfficeText.BackColor = System.Drawing.Color.White;
            this.AddOfficeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddOfficeText.Location = new System.Drawing.Point(20, 20);
            this.AddOfficeText.Name = "AddOfficeText";
            this.AddOfficeText.Size = new System.Drawing.Size(158, 21);
            this.AddOfficeText.TabIndex = 6;
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(222, 129);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(32, 49);
            this.ImportButton.TabIndex = 3;
            this.ImportButton.Text = "导入";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // DeleteOfficeButton
            // 
            this.DeleteOfficeButton.Location = new System.Drawing.Point(222, 17);
            this.DeleteOfficeButton.Name = "DeleteOfficeButton";
            this.DeleteOfficeButton.Size = new System.Drawing.Size(32, 23);
            this.DeleteOfficeButton.TabIndex = 2;
            this.DeleteOfficeButton.Text = "-";
            this.DeleteOfficeButton.UseVisualStyleBackColor = true;
            this.DeleteOfficeButton.Click += new System.EventHandler(this.DeleteOfficeButton_Click);
            // 
            // AddOfficeButton
            // 
            this.AddOfficeButton.Location = new System.Drawing.Point(184, 18);
            this.AddOfficeButton.Name = "AddOfficeButton";
            this.AddOfficeButton.Size = new System.Drawing.Size(32, 23);
            this.AddOfficeButton.TabIndex = 1;
            this.AddOfficeButton.Text = "+";
            this.AddOfficeButton.UseVisualStyleBackColor = true;
            this.AddOfficeButton.Click += new System.EventHandler(this.AddOfficeButton_Click);
            // 
            // OfficeList
            // 
            this.OfficeList.FormattingEnabled = true;
            this.OfficeList.HorizontalScrollbar = true;
            this.OfficeList.ItemHeight = 12;
            this.OfficeList.Location = new System.Drawing.Point(20, 47);
            this.OfficeList.Name = "OfficeList";
            this.OfficeList.Size = new System.Drawing.Size(189, 196);
            this.OfficeList.TabIndex = 0;
            // 
            // NumberGroup
            // 
            this.NumberGroup.Controls.Add(this.EndNumeric);
            this.NumberGroup.Controls.Add(this.NumberEndLabel);
            this.NumberGroup.Controls.Add(this.StartNumeric);
            this.NumberGroup.Controls.Add(this.NumberStartLabel);
            this.NumberGroup.Location = new System.Drawing.Point(429, 82);
            this.NumberGroup.Name = "NumberGroup";
            this.NumberGroup.Size = new System.Drawing.Size(269, 88);
            this.NumberGroup.TabIndex = 19;
            this.NumberGroup.TabStop = false;
            this.NumberGroup.Text = "数字序号水印";
            // 
            // EndNumeric
            // 
            this.EndNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.EndNumeric.Location = new System.Drawing.Point(89, 58);
            this.EndNumeric.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.EndNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndNumeric.Name = "EndNumeric";
            this.EndNumeric.Size = new System.Drawing.Size(120, 21);
            this.EndNumeric.TabIndex = 21;
            this.EndNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumberEndLabel
            // 
            this.NumberEndLabel.AutoSize = true;
            this.NumberEndLabel.Location = new System.Drawing.Point(18, 63);
            this.NumberEndLabel.Name = "NumberEndLabel";
            this.NumberEndLabel.Size = new System.Drawing.Size(65, 12);
            this.NumberEndLabel.TabIndex = 20;
            this.NumberEndLabel.Text = "结束序号：";
            // 
            // StartNumeric
            // 
            this.StartNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.StartNumeric.Location = new System.Drawing.Point(89, 31);
            this.StartNumeric.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.StartNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartNumeric.Name = "StartNumeric";
            this.StartNumeric.Size = new System.Drawing.Size(120, 21);
            this.StartNumeric.TabIndex = 19;
            this.StartNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumberStartLabel
            // 
            this.NumberStartLabel.AutoSize = true;
            this.NumberStartLabel.Location = new System.Drawing.Point(18, 36);
            this.NumberStartLabel.Name = "NumberStartLabel";
            this.NumberStartLabel.Size = new System.Drawing.Size(65, 12);
            this.NumberStartLabel.TabIndex = 18;
            this.NumberStartLabel.Text = "开始序号：";
            // 
            // SolidGroup
            // 
            this.SolidGroup.Controls.Add(this.SolidLabel);
            this.SolidGroup.Controls.Add(this.SolidText);
            this.SolidGroup.Location = new System.Drawing.Point(429, 20);
            this.SolidGroup.Name = "SolidGroup";
            this.SolidGroup.Size = new System.Drawing.Size(269, 52);
            this.SolidGroup.TabIndex = 18;
            this.SolidGroup.TabStop = false;
            this.SolidGroup.Text = "固定文本水印";
            // 
            // SolidLabel
            // 
            this.SolidLabel.AutoSize = true;
            this.SolidLabel.Location = new System.Drawing.Point(18, 25);
            this.SolidLabel.Name = "SolidLabel";
            this.SolidLabel.Size = new System.Drawing.Size(65, 12);
            this.SolidLabel.TabIndex = 6;
            this.SolidLabel.Text = "水印文字：";
            // 
            // SolidText
            // 
            this.SolidText.BackColor = System.Drawing.Color.White;
            this.SolidText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolidText.Location = new System.Drawing.Point(89, 20);
            this.SolidText.Name = "SolidText";
            this.SolidText.Size = new System.Drawing.Size(158, 21);
            this.SolidText.TabIndex = 5;
            // 
            // MarkRotationNumeric
            // 
            this.MarkRotationNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MarkRotationNumeric.Location = new System.Drawing.Point(89, 239);
            this.MarkRotationNumeric.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.MarkRotationNumeric.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.MarkRotationNumeric.Name = "MarkRotationNumeric";
            this.MarkRotationNumeric.Size = new System.Drawing.Size(120, 21);
            this.MarkRotationNumeric.TabIndex = 17;
            // 
            // MarkRotationLabel
            // 
            this.MarkRotationLabel.AutoSize = true;
            this.MarkRotationLabel.Location = new System.Drawing.Point(18, 241);
            this.MarkRotationLabel.Name = "MarkRotationLabel";
            this.MarkRotationLabel.Size = new System.Drawing.Size(65, 12);
            this.MarkRotationLabel.TabIndex = 16;
            this.MarkRotationLabel.Text = "倾斜角度：";
            // 
            // MarkFontLabel
            // 
            this.MarkFontLabel.AutoSize = true;
            this.MarkFontLabel.Location = new System.Drawing.Point(18, 271);
            this.MarkFontLabel.Name = "MarkFontLabel";
            this.MarkFontLabel.Size = new System.Drawing.Size(65, 12);
            this.MarkFontLabel.TabIndex = 15;
            this.MarkFontLabel.Text = "水印字体：";
            // 
            // MarkFontText
            // 
            this.MarkFontText.BackColor = System.Drawing.Color.White;
            this.MarkFontText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MarkFontText.Location = new System.Drawing.Point(89, 266);
            this.MarkFontText.Name = "MarkFontText";
            this.MarkFontText.ReadOnly = true;
            this.MarkFontText.Size = new System.Drawing.Size(262, 21);
            this.MarkFontText.TabIndex = 14;
            // 
            // MarkFontButton
            // 
            this.MarkFontButton.Location = new System.Drawing.Point(357, 266);
            this.MarkFontButton.Name = "MarkFontButton";
            this.MarkFontButton.Size = new System.Drawing.Size(39, 23);
            this.MarkFontButton.TabIndex = 13;
            this.MarkFontButton.Text = "...";
            this.MarkFontButton.UseVisualStyleBackColor = true;
            this.MarkFontButton.Click += new System.EventHandler(this.MarkFontButton_Click);
            // 
            // MarkSizeNumeric
            // 
            this.MarkSizeNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MarkSizeNumeric.Location = new System.Drawing.Point(89, 212);
            this.MarkSizeNumeric.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.MarkSizeNumeric.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MarkSizeNumeric.Name = "MarkSizeNumeric";
            this.MarkSizeNumeric.Size = new System.Drawing.Size(120, 21);
            this.MarkSizeNumeric.TabIndex = 12;
            this.MarkSizeNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // MarkSizeLabel
            // 
            this.MarkSizeLabel.AutoSize = true;
            this.MarkSizeLabel.Location = new System.Drawing.Point(18, 214);
            this.MarkSizeLabel.Name = "MarkSizeLabel";
            this.MarkSizeLabel.Size = new System.Drawing.Size(65, 12);
            this.MarkSizeLabel.TabIndex = 11;
            this.MarkSizeLabel.Text = "水印大小：";
            // 
            // MarkColorLabel
            // 
            this.MarkColorLabel.AutoSize = true;
            this.MarkColorLabel.Location = new System.Drawing.Point(18, 183);
            this.MarkColorLabel.Name = "MarkColorLabel";
            this.MarkColorLabel.Size = new System.Drawing.Size(65, 12);
            this.MarkColorLabel.TabIndex = 9;
            this.MarkColorLabel.Text = "水印颜色：";
            // 
            // MarkColorPicture
            // 
            this.MarkColorPicture.BackColor = System.Drawing.Color.Black;
            this.MarkColorPicture.Location = new System.Drawing.Point(89, 176);
            this.MarkColorPicture.Name = "MarkColorPicture";
            this.MarkColorPicture.Size = new System.Drawing.Size(43, 27);
            this.MarkColorPicture.TabIndex = 8;
            this.MarkColorPicture.TabStop = false;
            this.MarkColorPicture.Click += new System.EventHandler(this.MarkColorPicture_Click);
            // 
            // MarkKindLabel
            // 
            this.MarkKindLabel.AutoSize = true;
            this.MarkKindLabel.Location = new System.Drawing.Point(18, 96);
            this.MarkKindLabel.Name = "MarkKindLabel";
            this.MarkKindLabel.Size = new System.Drawing.Size(65, 12);
            this.MarkKindLabel.TabIndex = 7;
            this.MarkKindLabel.Text = "水印种类：";
            // 
            // MarkKindGroup
            // 
            this.MarkKindGroup.Controls.Add(this.NumberRadio);
            this.MarkKindGroup.Controls.Add(this.ListRadio);
            this.MarkKindGroup.Controls.Add(this.SolidRadio);
            this.MarkKindGroup.Location = new System.Drawing.Point(89, 76);
            this.MarkKindGroup.Name = "MarkKindGroup";
            this.MarkKindGroup.Size = new System.Drawing.Size(307, 94);
            this.MarkKindGroup.TabIndex = 6;
            this.MarkKindGroup.TabStop = false;
            // 
            // NumberRadio
            // 
            this.NumberRadio.AutoSize = true;
            this.NumberRadio.Location = new System.Drawing.Point(28, 42);
            this.NumberRadio.Name = "NumberRadio";
            this.NumberRadio.Size = new System.Drawing.Size(71, 16);
            this.NumberRadio.TabIndex = 2;
            this.NumberRadio.TabStop = true;
            this.NumberRadio.Text = "数字序号";
            this.NumberRadio.UseVisualStyleBackColor = true;
            this.NumberRadio.Click += new System.EventHandler(this.NumberRadio_Click);
            // 
            // ListRadio
            // 
            this.ListRadio.AutoSize = true;
            this.ListRadio.Location = new System.Drawing.Point(28, 64);
            this.ListRadio.Name = "ListRadio";
            this.ListRadio.Size = new System.Drawing.Size(95, 16);
            this.ListRadio.TabIndex = 1;
            this.ListRadio.TabStop = true;
            this.ListRadio.Text = "单位名称列表";
            this.ListRadio.UseVisualStyleBackColor = true;
            this.ListRadio.Click += new System.EventHandler(this.ListRadio_Click);
            // 
            // SolidRadio
            // 
            this.SolidRadio.AutoSize = true;
            this.SolidRadio.Location = new System.Drawing.Point(28, 20);
            this.SolidRadio.Name = "SolidRadio";
            this.SolidRadio.Size = new System.Drawing.Size(71, 16);
            this.SolidRadio.TabIndex = 0;
            this.SolidRadio.TabStop = true;
            this.SolidRadio.Text = "固定文本";
            this.SolidRadio.UseVisualStyleBackColor = true;
            this.SolidRadio.Click += new System.EventHandler(this.SolidRadio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "输出文件夹：";
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(30, 25);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(53, 12);
            this.SourceLabel.TabIndex = 4;
            this.SourceLabel.Text = "源文件：";
            // 
            // TargetText
            // 
            this.TargetText.BackColor = System.Drawing.Color.White;
            this.TargetText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TargetText.Location = new System.Drawing.Point(89, 49);
            this.TargetText.Name = "TargetText";
            this.TargetText.ReadOnly = true;
            this.TargetText.Size = new System.Drawing.Size(262, 21);
            this.TargetText.TabIndex = 3;
            // 
            // TargetButton
            // 
            this.TargetButton.Location = new System.Drawing.Point(357, 49);
            this.TargetButton.Name = "TargetButton";
            this.TargetButton.Size = new System.Drawing.Size(39, 23);
            this.TargetButton.TabIndex = 2;
            this.TargetButton.Text = "...";
            this.TargetButton.UseVisualStyleBackColor = true;
            this.TargetButton.Click += new System.EventHandler(this.TargetButton_Click);
            // 
            // SourceText
            // 
            this.SourceText.BackColor = System.Drawing.Color.White;
            this.SourceText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SourceText.Location = new System.Drawing.Point(89, 20);
            this.SourceText.Name = "SourceText";
            this.SourceText.ReadOnly = true;
            this.SourceText.Size = new System.Drawing.Size(262, 21);
            this.SourceText.TabIndex = 1;
            // 
            // SourceButton
            // 
            this.SourceButton.Location = new System.Drawing.Point(357, 20);
            this.SourceButton.Name = "SourceButton";
            this.SourceButton.Size = new System.Drawing.Size(39, 23);
            this.SourceButton.TabIndex = 0;
            this.SourceButton.Text = "...";
            this.SourceButton.UseVisualStyleBackColor = true;
            this.SourceButton.Click += new System.EventHandler(this.SourceButton_Click);
            // 
            // SourceFileDialog
            // 
            this.SourceFileDialog.Filter = "Word文件|*.doc;*.docx";
            // 
            // MarkFontDialog
            // 
            this.MarkFontDialog.FontMustExist = true;
            this.MarkFontDialog.ShowEffects = false;
            // 
            // MarkColorDialog
            // 
            this.MarkColorDialog.AllowFullOpen = false;
            this.MarkColorDialog.Color = System.Drawing.Color.LightGray;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // ListSaveDialog
            // 
            this.ListSaveDialog.DefaultExt = "txt";
            this.ListSaveDialog.Filter = "纯文本文件|*.txt";
            this.ListSaveDialog.Title = "导出单位列表为纯文本文件";
            // 
            // ListOpenDialog
            // 
            this.ListOpenDialog.DefaultExt = "txt";
            this.ListOpenDialog.Filter = "纯文本文件|*.txt";
            this.ListOpenDialog.Title = "导入单位名称列表";
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(20, 360);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 49);
            this.PrintButton.TabIndex = 25;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // PrintDialog
            // 
            this.PrintDialog.UseEXDialog = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "XMarker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.OfficeGroup.ResumeLayout(false);
            this.OfficeGroup.PerformLayout();
            this.NumberGroup.ResumeLayout(false);
            this.NumberGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartNumeric)).EndInit();
            this.SolidGroup.ResumeLayout(false);
            this.SolidGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarkRotationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkSizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkColorPicture)).EndInit();
            this.MarkKindGroup.ResumeLayout(false);
            this.MarkKindGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TargetText;
        private System.Windows.Forms.Button TargetButton;
        private System.Windows.Forms.TextBox SourceText;
        private System.Windows.Forms.Button SourceButton;
        private System.Windows.Forms.OpenFileDialog SourceFileDialog;
        private System.Windows.Forms.FolderBrowserDialog TargetFolderDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.GroupBox MarkKindGroup;
        private System.Windows.Forms.RadioButton NumberRadio;
        private System.Windows.Forms.RadioButton ListRadio;
        private System.Windows.Forms.RadioButton SolidRadio;
        private System.Windows.Forms.Label MarkKindLabel;
        private System.Windows.Forms.Label MarkColorLabel;
        private System.Windows.Forms.PictureBox MarkColorPicture;
        private System.Windows.Forms.Label MarkSizeLabel;
        private System.Windows.Forms.NumericUpDown MarkSizeNumeric;
        private System.Windows.Forms.Label MarkFontLabel;
        private System.Windows.Forms.TextBox MarkFontText;
        private System.Windows.Forms.Button MarkFontButton;
        private System.Windows.Forms.FontDialog MarkFontDialog;
        private System.Windows.Forms.ColorDialog MarkColorDialog;
        private System.Windows.Forms.GroupBox SolidGroup;
        private System.Windows.Forms.Label SolidLabel;
        private System.Windows.Forms.TextBox SolidText;
        private System.Windows.Forms.NumericUpDown MarkRotationNumeric;
        private System.Windows.Forms.Label MarkRotationLabel;
        private System.Windows.Forms.GroupBox OfficeGroup;
        private System.Windows.Forms.GroupBox NumberGroup;
        private System.Windows.Forms.NumericUpDown EndNumeric;
        private System.Windows.Forms.Label NumberEndLabel;
        private System.Windows.Forms.NumericUpDown StartNumeric;
        private System.Windows.Forms.Label NumberStartLabel;
        private System.Windows.Forms.Button DeleteOfficeButton;
        private System.Windows.Forms.Button AddOfficeButton;
        private System.Windows.Forms.ListBox OfficeList;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.TextBox AddOfficeText;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ListBox LoggerList;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.SaveFileDialog ListSaveDialog;
        private System.Windows.Forms.OpenFileDialog ListOpenDialog;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.PrintDialog PrintDialog;
    }
}


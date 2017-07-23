namespace SupremeDiscordMessage
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbFullWebhook = new System.Windows.Forms.CueTextBoxURL();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.tbSenderName = new System.Windows.Forms.CueTextBox();
            this.tbSenderAvatarUrl = new System.Windows.Forms.CueTextBoxURL();
            this.tbBodyMessage = new System.Windows.Forms.CueTextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.pColor = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pasteButton8 = new System.Windows.Forms.PasteButton();
            this.ilButtons = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbWebhooks = new System.Windows.Forms.ComboBox();
            this.bRemoveChannel = new System.Windows.Forms.Button();
            this.pasteButton7 = new System.Windows.Forms.PasteButton();
            this.bCreateChannel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bEditChannelName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bDuplicateChannel = new System.Windows.Forms.Button();
            this.bCopyWebhook = new System.Windows.Forms.CopyButton();
            this.pbSenderAvatar = new System.Windows.Forms.URLContextPicturebox();
            this.contextLabel3 = new System.Windows.Forms.ContextLabel();
            this.contextLabel1 = new System.Windows.Forms.ContextLabel();
            this.contextLabel2 = new System.Windows.Forms.ContextLabel();
            this.cbUseColor = new System.Windows.Forms.CheckBox();
            this.tpMisc = new System.Windows.Forms.TabPage();
            this.urlContextPicturebox1 = new System.Windows.Forms.URLContextPicturebox();
            this.tbThumbnailUrl = new System.Windows.Forms.CueTextBoxURL();
            this.pasteButton3 = new System.Windows.Forms.PasteButton();
            this.tbLink = new System.Windows.Forms.CueTextBoxURL();
            this.pasteButton2 = new System.Windows.Forms.PasteButton();
            this.tbImageUrl = new System.Windows.Forms.CueTextBoxURL();
            this.pasteButton1 = new System.Windows.Forms.PasteButton();
            this.contextLabel12 = new System.Windows.Forms.ContextLabel();
            this.tbTitle = new System.Windows.Forms.CueTextBox();
            this.contextLabel11 = new System.Windows.Forms.ContextLabel();
            this.contextLabel10 = new System.Windows.Forms.ContextLabel();
            this.contextLabel9 = new System.Windows.Forms.ContextLabel();
            this.lTimestamp = new System.Windows.Forms.ContextLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pasteButton6 = new System.Windows.Forms.PasteButton();
            this.tbFooterIconUrl = new System.Windows.Forms.CueTextBoxURL();
            this.contextLabel5 = new System.Windows.Forms.ContextLabel();
            this.contextLabel4 = new System.Windows.Forms.ContextLabel();
            this.tbFooterText = new System.Windows.Forms.CueTextBox();
            this.pbFooterIcon = new System.Windows.Forms.URLContextPicturebox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pasteButton5 = new System.Windows.Forms.PasteButton();
            this.tbAuthorLink = new System.Windows.Forms.CueTextBoxURL();
            this.pasteButton4 = new System.Windows.Forms.PasteButton();
            this.tbAuthorAvatarUrl = new System.Windows.Forms.CueTextBoxURL();
            this.contextLabel8 = new System.Windows.Forms.ContextLabel();
            this.contextLabel7 = new System.Windows.Forms.ContextLabel();
            this.contextLabel6 = new System.Windows.Forms.ContextLabel();
            this.tbAuthorName = new System.Windows.Forms.CueTextBox();
            this.pbAuthorAvatar = new System.Windows.Forms.URLContextPicturebox();
            this.dtpTimestamp = new System.Windows.Forms.DateTimePicker();
            this.tpWebhook = new System.Windows.Forms.TabPage();
            this.bCopyRAW = new System.Windows.Forms.CopyButton();
            this.tbRAW = new FastColoredTextBoxNS.FastColoredTextBox();
            this.bPasteRAW = new System.Windows.Forms.PasteButton();
            this.bExportHook = new System.Windows.Forms.Button();
            this.cbForDiscord = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bExportAllHooks = new System.Windows.Forms.Button();
            this.bExportAllPresets = new System.Windows.Forms.Button();
            this.bExportCurrentPreset = new System.Windows.Forms.Button();
            this.bImport = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbPresets = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bDuplicatePreset = new System.Windows.Forms.Button();
            this.bCreatePreset = new System.Windows.Forms.Button();
            this.bRemovePreset = new System.Windows.Forms.Button();
            this.bEditPresetName = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSenderAvatar)).BeginInit();
            this.tpMisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urlContextPicturebox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFooterIcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuthorAvatar)).BeginInit();
            this.tpWebhook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRAW)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFullWebhook
            // 
            this.tbFullWebhook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFullWebhook.Cue = "Discord webhook";
            this.tbFullWebhook.Location = new System.Drawing.Point(46, 101);
            this.tbFullWebhook.Name = "tbFullWebhook";
            this.tbFullWebhook.Size = new System.Drawing.Size(371, 27);
            this.tbFullWebhook.TabIndex = 112;
            this.tbFullWebhook.TextChanged += new System.EventHandler(this.tbFullWebhook_TextChanged_1);
            // 
            // tbSenderName
            // 
            this.tbSenderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSenderName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSenderName.Cue = "Ник отправителя";
            this.tbSenderName.Location = new System.Drawing.Point(90, 32);
            this.tbSenderName.Name = "tbSenderName";
            this.tbSenderName.Size = new System.Drawing.Size(997, 20);
            this.tbSenderName.TabIndex = 2;
            this.tbSenderName.TextChanged += new System.EventHandler(this.tbSenderName_TextChanged);
            // 
            // tbSenderAvatarUrl
            // 
            this.tbSenderAvatarUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSenderAvatarUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSenderAvatarUrl.Cue = "Url аватарки";
            this.tbSenderAvatarUrl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSenderAvatarUrl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbSenderAvatarUrl.Location = new System.Drawing.Point(125, 86);
            this.tbSenderAvatarUrl.Name = "tbSenderAvatarUrl";
            this.tbSenderAvatarUrl.Size = new System.Drawing.Size(962, 20);
            this.tbSenderAvatarUrl.TabIndex = 3;
            this.tbSenderAvatarUrl.TextChanged += new System.EventHandler(this.tbSenderAvatarUrl_TextChanged);
            // 
            // tbBodyMessage
            // 
            this.tbBodyMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBodyMessage.Cue = "Основной текст";
            this.tbBodyMessage.Location = new System.Drawing.Point(26, 135);
            this.tbBodyMessage.Multiline = true;
            this.tbBodyMessage.Name = "tbBodyMessage";
            this.tbBodyMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbBodyMessage.Size = new System.Drawing.Size(1061, 329);
            this.tbBodyMessage.TabIndex = 4;
            this.tbBodyMessage.TextChanged += new System.EventHandler(this.tbBodyMessage_TextChanged);
            // 
            // bSend
            // 
            this.bSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSend.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSend.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSend.ForeColor = System.Drawing.Color.DarkGreen;
            this.bSend.Location = new System.Drawing.Point(976, 700);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(137, 28);
            this.bSend.TabIndex = 6;
            this.bSend.Text = "Отправить!";
            this.bSend.UseVisualStyleBackColor = false;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // pColor
            // 
            this.pColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pColor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pColor.Location = new System.Drawing.Point(7, 149);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(13, 315);
            this.pColor.TabIndex = 13;
            this.pColor.BackColorChanged += new System.EventHandler(this.pColor_BackColorChanged);
            this.pColor.Click += new System.EventHandler(this.panel1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpMisc);
            this.tabControl1.Controls.Add(this.tpWebhook);
            this.tabControl1.Location = new System.Drawing.Point(12, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1101, 651);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pasteButton8);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.pbSenderAvatar);
            this.tabPage1.Controls.Add(this.contextLabel3);
            this.tabPage1.Controls.Add(this.contextLabel1);
            this.tabPage1.Controls.Add(this.contextLabel2);
            this.tabPage1.Controls.Add(this.cbUseColor);
            this.tabPage1.Controls.Add(this.pColor);
            this.tabPage1.Controls.Add(this.tbBodyMessage);
            this.tabPage1.Controls.Add(this.tbSenderName);
            this.tabPage1.Controls.Add(this.tbSenderAvatarUrl);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1093, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сообщение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pasteButton8
            // 
            this.pasteButton8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pasteButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pasteButton8.ImageIndex = 2;
            this.pasteButton8.ImageList = this.ilButtons;
            this.pasteButton8.Location = new System.Drawing.Point(90, 82);
            this.pasteButton8.Name = "pasteButton8";
            this.pasteButton8.Size = new System.Drawing.Size(28, 28);
            this.pasteButton8.TabIndex = 105;
            this.pasteButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pasteButton8.UseVisualStyleBackColor = false;
            this.pasteButton8.ZContextControl = this.tbSenderAvatarUrl;
            // 
            // ilButtons
            // 
            this.ilButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilButtons.ImageStream")));
            this.ilButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilButtons.Images.SetKeyName(0, "save.png");
            this.ilButtons.Images.SetKeyName(1, "SDCard.png");
            this.ilButtons.Images.SetKeyName(2, "clipboard.png");
            this.ilButtons.Images.SetKeyName(3, "copy.png");
            this.ilButtons.Images.SetKeyName(4, "import.png");
            this.ilButtons.Images.SetKeyName(5, "remove.png");
            this.ilButtons.Images.SetKeyName(6, "add.png");
            this.ilButtons.Images.SetKeyName(7, "ClipboardCopy.png");
            this.ilButtons.Images.SetKeyName(8, "edit.png");
            this.ilButtons.Images.SetKeyName(9, "export.png");
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbWebhooks);
            this.groupBox3.Controls.Add(this.bRemoveChannel);
            this.groupBox3.Controls.Add(this.pasteButton7);
            this.groupBox3.Controls.Add(this.bCreateChannel);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.bEditChannelName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.bDuplicateChannel);
            this.groupBox3.Controls.Add(this.tbFullWebhook);
            this.groupBox3.Controls.Add(this.bCopyWebhook);
            this.groupBox3.Location = new System.Drawing.Point(6, 470);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1166, 144);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Канал";
            // 
            // cbWebhooks
            // 
            this.cbWebhooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWebhooks.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbWebhooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWebhooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWebhooks.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbWebhooks.Location = new System.Drawing.Point(12, 43);
            this.cbWebhooks.Name = "cbWebhooks";
            this.cbWebhooks.Size = new System.Drawing.Size(467, 26);
            this.cbWebhooks.TabIndex = 5;
            this.cbWebhooks.SelectedValueChanged += new System.EventHandler(this.cbWebhooks_SelectedValueChanged);
            // 
            // bRemoveChannel
            // 
            this.bRemoveChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRemoveChannel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bRemoveChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRemoveChannel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRemoveChannel.ForeColor = System.Drawing.Color.DarkGreen;
            this.bRemoveChannel.ImageKey = "remove.png";
            this.bRemoveChannel.ImageList = this.ilButtons;
            this.bRemoveChannel.Location = new System.Drawing.Point(723, 42);
            this.bRemoveChannel.Name = "bRemoveChannel";
            this.bRemoveChannel.Size = new System.Drawing.Size(28, 28);
            this.bRemoveChannel.TabIndex = 109;
            this.bRemoveChannel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bRemoveChannel.UseVisualStyleBackColor = false;
            this.bRemoveChannel.Click += new System.EventHandler(this.bRemoveChannel_Click);
            // 
            // pasteButton7
            // 
            this.pasteButton7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pasteButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pasteButton7.ImageIndex = 2;
            this.pasteButton7.ImageList = this.ilButtons;
            this.pasteButton7.Location = new System.Drawing.Point(12, 100);
            this.pasteButton7.Name = "pasteButton7";
            this.pasteButton7.Size = new System.Drawing.Size(28, 28);
            this.pasteButton7.TabIndex = 110;
            this.pasteButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pasteButton7.UseVisualStyleBackColor = false;
            this.pasteButton7.ZContextControl = this.tbFullWebhook;
            // 
            // bCreateChannel
            // 
            this.bCreateChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCreateChannel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bCreateChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCreateChannel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreateChannel.ForeColor = System.Drawing.Color.DarkGreen;
            this.bCreateChannel.ImageKey = "add.png";
            this.bCreateChannel.ImageList = this.ilButtons;
            this.bCreateChannel.Location = new System.Drawing.Point(485, 42);
            this.bCreateChannel.Name = "bCreateChannel";
            this.bCreateChannel.Size = new System.Drawing.Size(28, 28);
            this.bCreateChannel.TabIndex = 106;
            this.bCreateChannel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCreateChannel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bCreateChannel.UseVisualStyleBackColor = false;
            this.bCreateChannel.Click += new System.EventHandler(this.bCreateChannel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Наименование";
            // 
            // bEditChannelName
            // 
            this.bEditChannelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bEditChannelName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bEditChannelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditChannelName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEditChannelName.ForeColor = System.Drawing.Color.DarkGreen;
            this.bEditChannelName.ImageKey = "edit.png";
            this.bEditChannelName.ImageList = this.ilButtons;
            this.bEditChannelName.Location = new System.Drawing.Point(651, 42);
            this.bEditChannelName.Name = "bEditChannelName";
            this.bEditChannelName.Size = new System.Drawing.Size(66, 28);
            this.bEditChannelName.TabIndex = 108;
            this.bEditChannelName.Text = "Имя";
            this.bEditChannelName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bEditChannelName.UseVisualStyleBackColor = false;
            this.bEditChannelName.Click += new System.EventHandler(this.bEditChannelName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Webhook URL";
            // 
            // bDuplicateChannel
            // 
            this.bDuplicateChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bDuplicateChannel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bDuplicateChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDuplicateChannel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDuplicateChannel.ForeColor = System.Drawing.Color.DarkGreen;
            this.bDuplicateChannel.ImageKey = "copy.png";
            this.bDuplicateChannel.ImageList = this.ilButtons;
            this.bDuplicateChannel.Location = new System.Drawing.Point(519, 42);
            this.bDuplicateChannel.Name = "bDuplicateChannel";
            this.bDuplicateChannel.Size = new System.Drawing.Size(126, 28);
            this.bDuplicateChannel.TabIndex = 107;
            this.bDuplicateChannel.Text = "Дублировать";
            this.bDuplicateChannel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDuplicateChannel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bDuplicateChannel.UseVisualStyleBackColor = false;
            this.bDuplicateChannel.Click += new System.EventHandler(this.bDuplicateChannel_Click);
            // 
            // bCopyWebhook
            // 
            this.bCopyWebhook.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bCopyWebhook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCopyWebhook.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCopyWebhook.ForeColor = System.Drawing.Color.DarkGreen;
            this.bCopyWebhook.ImageKey = "ClipboardCopy.png";
            this.bCopyWebhook.ImageList = this.ilButtons;
            this.bCopyWebhook.Location = new System.Drawing.Point(423, 101);
            this.bCopyWebhook.Name = "bCopyWebhook";
            this.bCopyWebhook.Size = new System.Drawing.Size(113, 28);
            this.bCopyWebhook.TabIndex = 111;
            this.bCopyWebhook.Text = "Копировать";
            this.bCopyWebhook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCopyWebhook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bCopyWebhook.UseVisualStyleBackColor = false;
            this.bCopyWebhook.ZContextControl = this.tbFullWebhook;
            // 
            // pbSenderAvatar
            // 
            this.pbSenderAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSenderAvatar.IsCacheImage = true;
            this.pbSenderAvatar.Location = new System.Drawing.Point(12, 12);
            this.pbSenderAvatar.Name = "pbSenderAvatar";
            this.pbSenderAvatar.Size = new System.Drawing.Size(70, 70);
            this.pbSenderAvatar.TabIndex = 20;
            this.pbSenderAvatar.TabStop = false;
            this.pbSenderAvatar.Text = "Url аватарки";
            this.pbSenderAvatar.ZContextControl = this.tbSenderAvatarUrl;
            // 
            // contextLabel3
            // 
            this.contextLabel3.AutoSize = true;
            this.contextLabel3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextLabel3.ForeColor = System.Drawing.Color.DarkGreen;
            this.contextLabel3.Location = new System.Drawing.Point(30, 116);
            this.contextLabel3.Name = "contextLabel3";
            this.contextLabel3.Size = new System.Drawing.Size(117, 16);
            this.contextLabel3.TabIndex = 19;
            this.contextLabel3.Text = "Основной текст";
            this.contextLabel3.ZContextControl = null;
            // 
            // contextLabel1
            // 
            this.contextLabel1.AutoSize = true;
            this.contextLabel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextLabel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.contextLabel1.Location = new System.Drawing.Point(94, 12);
            this.contextLabel1.Name = "contextLabel1";
            this.contextLabel1.Size = new System.Drawing.Size(124, 16);
            this.contextLabel1.TabIndex = 18;
            this.contextLabel1.Text = "Ник отправителя";
            this.contextLabel1.ZContextControl = this.tbSenderName;
            // 
            // contextLabel2
            // 
            this.contextLabel2.AutoSize = true;
            this.contextLabel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextLabel2.ForeColor = System.Drawing.Color.DarkGreen;
            this.contextLabel2.Location = new System.Drawing.Point(94, 64);
            this.contextLabel2.Name = "contextLabel2";
            this.contextLabel2.Size = new System.Drawing.Size(93, 16);
            this.contextLabel2.TabIndex = 18;
            this.contextLabel2.Text = "Url аватарки";
            this.contextLabel2.ZContextControl = this.tbSenderAvatarUrl;
            // 
            // cbUseColor
            // 
            this.cbUseColor.AutoSize = true;
            this.cbUseColor.Checked = true;
            this.cbUseColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseColor.Location = new System.Drawing.Point(7, 135);
            this.cbUseColor.Name = "cbUseColor";
            this.cbUseColor.Size = new System.Drawing.Size(15, 14);
            this.cbUseColor.TabIndex = 15;
            this.cbUseColor.UseVisualStyleBackColor = true;
            this.cbUseColor.CheckedChanged += new System.EventHandler(this.cbUseColor_CheckedChanged);
            // 
            // tpMisc
            // 
            this.tpMisc.Controls.Add(this.urlContextPicturebox1);
            this.tpMisc.Controls.Add(this.pasteButton3);
            this.tpMisc.Controls.Add(this.pasteButton2);
            this.tpMisc.Controls.Add(this.pasteButton1);
            this.tpMisc.Controls.Add(this.contextLabel12);
            this.tpMisc.Controls.Add(this.contextLabel11);
            this.tpMisc.Controls.Add(this.contextLabel10);
            this.tpMisc.Controls.Add(this.contextLabel9);
            this.tpMisc.Controls.Add(this.lTimestamp);
            this.tpMisc.Controls.Add(this.groupBox2);
            this.tpMisc.Controls.Add(this.groupBox1);
            this.tpMisc.Controls.Add(this.dtpTimestamp);
            this.tpMisc.Controls.Add(this.tbLink);
            this.tpMisc.Controls.Add(this.tbImageUrl);
            this.tpMisc.Controls.Add(this.tbThumbnailUrl);
            this.tpMisc.Controls.Add(this.tbTitle);
            this.tpMisc.Location = new System.Drawing.Point(4, 27);
            this.tpMisc.Name = "tpMisc";
            this.tpMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tpMisc.Size = new System.Drawing.Size(1093, 620);
            this.tpMisc.TabIndex = 2;
            this.tpMisc.Text = "Дополнительно";
            this.tpMisc.UseVisualStyleBackColor = true;
            // 
            // urlContextPicturebox1
            // 
            this.urlContextPicturebox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urlContextPicturebox1.IsCacheImage = true;
            this.urlContextPicturebox1.Location = new System.Drawing.Point(12, 12);
            this.urlContextPicturebox1.Name = "urlContextPicturebox1";
            this.urlContextPicturebox1.Size = new System.Drawing.Size(70, 70);
            this.urlContextPicturebox1.TabIndex = 28;
            this.urlContextPicturebox1.TabStop = false;
            this.urlContextPicturebox1.Text = "Url предпросмотра (справа)";
            this.urlContextPicturebox1.ZContextControl = this.tbThumbnailUrl;
            // 
            // tbThumbnailUrl
            // 
            this.tbThumbnailUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbThumbnailUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbThumbnailUrl.Cue = "Url предпросмотра (справа)";
            this.tbThumbnailUrl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbThumbnailUrl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbThumbnailUrl.Location = new System.Drawing.Point(125, 86);
            this.tbThumbnailUrl.Name = "tbThumbnailUrl";
            this.tbThumbnailUrl.Size = new System.Drawing.Size(952, 20);
            this.tbThumbnailUrl.TabIndex = 2;
            this.tbThumbnailUrl.TextChanged += new System.EventHandler(this.tbThumbnailUrl_TextChanged);
            // 
            // pasteButton3
            // 
            this.pasteButton3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pasteButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pasteButton3.ImageIndex = 2;
            this.pasteButton3.ImageList = this.ilButtons;
            this.pasteButton3.Location = new System.Drawing.Point(90, 187);
            this.pasteButton3.Name = "pasteButton3";
            this.pasteButton3.Size = new System.Drawing.Size(28, 28);
            this.pasteButton3.TabIndex = 27;
            this.pasteButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pasteButton3.UseVisualStyleBackColor = false;
            this.pasteButton3.ZContextControl = this.tbLink;
            // 
            // tbLink
            // 
            this.tbLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLink.Cue = "Ссылка (по клику на заголовке)";
            this.tbLink.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLink.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbLink.Location = new System.Drawing.Point(125, 190);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(952, 20);
            this.tbLink.TabIndex = 4;
            this.tbLink.TextChanged += new System.EventHandler(this.tbLink_TextChanged);
            // 
            // pasteButton2
            // 
            this.pasteButton2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pasteButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pasteButton2.ImageIndex = 2;
            this.pasteButton2.ImageList = this.ilButtons;
            this.pasteButton2.Location = new System.Drawing.Point(90, 134);
            this.pasteButton2.Name = "pasteButton2";
            this.pasteButton2.Size = new System.Drawing.Size(28, 28);
            this.pasteButton2.TabIndex = 26;
            this.pasteButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pasteButton2.UseVisualStyleBackColor = false;
            this.pasteButton2.ZContextControl = this.tbImageUrl;
            // 
            // tbImageUrl
            // 
            this.tbImageUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbImageUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbImageUrl.Cue = "Url картинки (ниже основного текста)";
            this.tbImageUrl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbImageUrl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbImageUrl.Location = new System.Drawing.Point(125, 138);
            this.tbImageUrl.Name = "tbImageUrl";
            this.tbImageUrl.Size = new System.Drawing.Size(952, 20);
            this.tbImageUrl.TabIndex = 3;
            this.tbImageUrl.TextChanged += new System.EventHandler(this.tbImageUrl_TextChanged);
            // 
            // pasteButton1
            // 
            this.pasteButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pasteButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pasteButton1.ImageIndex = 2;
            this.pasteButton1.ImageList = this.ilButtons;
            this.pasteButton1.Location = new System.Drawing.Point(90, 82);
            this.pasteButton1.Name = "pasteButton1";
            this.pasteButton1.Size = new System.Drawing.Size(28, 28);
            this.pasteButton1.TabIndex = 25;
            this.pasteButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pasteButton1.UseVisualStyleBackColor = false;
            this.pasteButton1.ZContextControl = this.tbThumbnailUrl;
            // 
            // contextLabel12
            // 
            this.contextLabel12.AutoSize = true;
            this.contextLabel12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextLabel12.ForeColor = System.Drawing.Color.DarkGreen;
            this.contextLabel12.Location = new System.Drawing.Point(94, 12);
            this.contextLabel12.Name = "contextLabel12";
            this.contextLabel12.Size = new System.Drawing.Size(78, 16);
            this.contextLabel12.TabIndex = 24;
            this.contextLabel12.Text = "Заголовок";
            this.contextLabel12.ZContextControl = this.tbTitle;
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitle.Cue = "Заголовок";
            this.tbTitle.Location = new System.Drawing.Point(90, 32);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(987, 20);
            this.tbTitle.TabIndex = 1;
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // contextLabel11
            // 
            this.contextLabel11.AutoSize = true;
            this.contextLabel11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextLabel11.ForeColor = System.Drawing.Color.DarkGreen;
            this.contextLabel11.Location = new System.Drawing.Point(94, 64);
            this.contextLabel11.Name = "contextLabel11";
            this.contextLabel11.Size = new System.Drawing.Size(199, 16);
            this.contextLabel11.TabIndex = 23;
            this.contextLabel11.Text = "Url предпросмотра (справа)";
            this.contextLabel11.ZContextControl = this.tbThumbnailUrl;
            // 
            // contextLabel10
            // 
            this.contextLabel10.AutoSize = true;
            this.contextLabel10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextLabel10.ForeColor = System.Drawing.Color.DarkGreen;
            this.contextLabel10.Location = new System.Drawing.Point(94, 116);
            this.contextLabel10.Name = "contextLabel10";
            this.contextLabel10.Size = new System.Drawing.Size(271, 16);
            this.contextLabel10.TabIndex = 22;
            this.contextLabel10.Text = "Url картинки (ниже основного текста)";
            this.contextLabel10.ZContextControl = this.tbImageUrl;
            // 
            // contextLabel9
            // 
            this.contextLabel9.AutoSize = true;
            this.contextLabel9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextLabel9.ForeColor = System.Drawing.Color.DarkGreen;
            this.contextLabel9.Location = new System.Drawing.Point(94, 168);
            this.contextLabel9.Name = "contextLabel9";
            this.contextLabel9.Size = new System.Drawing.Size(231, 16);
            this.contextLabel9.TabIndex = 21;
            this.contextLabel9.Text = "Ссылка (по клику на заголовке)";
            this.contextLabel9.ZContextControl = this.tbLink;
            // 
            // lTimestamp
            // 
            this.lTimestamp.AutoSize = true;
            this.lTimestamp.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTimestamp.ForeColor = System.Drawing.Color.DarkGreen;
            this.lTimestamp.Location = new System.Drawing.Point(9, 565);
            this.lTimestamp.Name = "lTimestamp";
            this.lTimestamp.Size = new System.Drawing.Size(112, 16);
            this.lTimestamp.TabIndex = 16;
            this.lTimestamp.Text = "Метка времени";
            this.lTimestamp.ZContextControl = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pasteButton6);
            this.groupBox2.Controls.Add(this.contextLabel5);
            this.groupBox2.Controls.Add(this.contextLabel4);
            this.groupBox2.Controls.Add(this.pbFooterIcon);
            this.groupBox2.Controls.Add(this.tbFooterText);
            this.groupBox2.Controls.Add(this.tbFooterIconUrl);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(2, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1086, 137);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Нижний колонтитул";
            // 
            // pasteButton6
            // 
            this.pasteButton6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pasteButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pasteButton6.ImageIndex = 2;
            this.pasteButton6.ImageList = this.ilButtons;
            this.pasteButton6.Location = new System.Drawing.Point(90, 94);
            this.pasteButton6.Name = "pasteButton6";
            this.pasteButton6.Size = new System.Drawing.Size(28, 28);
            this.pasteButton6.TabIndex = 30;
            this.pasteButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pasteButton6.UseVisualStyleBackColor = false;
            this.pasteButton6.ZContextControl = this.tbFooterIconUrl;
            // 
            // tbFooterIconUrl
            // 
            this.tbFooterIconUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFooterIconUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFooterIconUrl.Cue = "Url иконки";
            this.tbFooterIconUrl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFooterIconUrl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbFooterIconUrl.Location = new System.Drawing.Point(125, 99);
            this.tbFooterIconUrl.Name = "tbFooterIconUrl";
            this.tbFooterIconUrl.Size = new System.Drawing.Size(952, 20);
            this.tbFooterIconUrl.TabIndex = 9;
            this.tbFooterIconUrl.TextChanged += new System.EventHandler(this.tbFooterIconUrl_TextChanged);
            // 
            // contextLabel5
            // 
            this.contextLabel5.AutoSize = true;
            this.contextLabel5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextLabel5.ForeColor = System.Drawing.Color.DarkGreen;
            this.contextLabel5.Location = new System.Drawing.Point(94, 76);
            this.contextLabel5.Name = "contextLabel5";
            this.contextLabel5.Size = new System.Drawing.Size(78, 16);
            this.contextLabel5.TabIndex = 20;
            this.contextLabel5.Text = "Url иконки";
            this.contextLabel5.ZContextControl = this.tbFooterIconUrl;
            // 
            // contextLabel4
            // 
            this.contextLabel4.AutoSize = true;
            this.contextLabel4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextLabel4.ForeColor = System.Drawing.Color.DarkGreen;
            this.contextLabel4.Location = new System.Drawing.Point(94, 24);
            this.contextLabel4.Name = "contextLabel4";
            this.contextLabel4.Size = new System.Drawing.Size(278, 16);
            this.contextLabel4.TabIndex = 19;
            this.contextLabel4.Text = "Текст (обязательное для колонтитула)";
            this.contextLabel4.ZContextControl = this.tbFooterText;
            // 
            // tbFooterText
            // 
            this.tbFooterText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFooterText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFooterText.Cue = "Текст (обязательное для колонтитула)";
            this.tbFooterText.Location = new System.Drawing.Point(90, 44);
            this.tbFooterText.Name = "tbFooterText";
            this.tbFooterText.Size = new System.Drawing.Size(987, 20);
            this.tbFooterText.TabIndex = 8;
            this.tbFooterText.TextChanged += new System.EventHandler(this.tbFooterText_TextChanged);
            // 
            // pbFooterIcon
            // 
            this.pbFooterIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFooterIcon.IsCacheImage = true;
            this.pbFooterIcon.Location = new System.Drawing.Point(12, 24);
            this.pbFooterIcon.Name = "pbFooterIcon";
            this.pbFooterIcon.Size = new System.Drawing.Size(70, 70);
            this.pbFooterIcon.TabIndex = 24;
            this.pbFooterIcon.TabStop = false;
            this.pbFooterIcon.Text = "Url иконки";
            this.pbFooterIcon.ZContextControl = this.tbFooterIconUrl;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pasteButton5);
            this.groupBox1.Controls.Add(this.pasteButton4);
            this.groupBox1.Controls.Add(this.contextLabel8);
            this.groupBox1.Controls.Add(this.contextLabel7);
            this.groupBox1.Controls.Add(this.contextLabel6);
            this.groupBox1.Controls.Add(this.pbAuthorAvatar);
            this.groupBox1.Controls.Add(this.tbAuthorName);
            this.groupBox1.Controls.Add(this.tbAuthorLink);
            this.groupBox1.Controls.Add(this.tbAuthorAvatarUrl);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 190);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автор";
            // 
            // pasteButton5
            // 
            this.pasteButton5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pasteButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pasteButton5.ImageIndex = 2;
            this.pasteButton5.ImageList = this.ilButtons;
            this.pasteButton5.Location = new System.Drawing.Point(90, 146);
            this.pasteButton5.Name = "pasteButton5";
            this.pasteButton5.Size = new System.Drawing.Size(28, 28);
            this.pasteButton5.TabIndex = 29;
            this.pasteButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pasteButton5.UseVisualStyleBackColor = false;
            this.pasteButton5.ZContextControl = this.tbAuthorLink;
            // 
            // tbAuthorLink
            // 
            this.tbAuthorLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAuthorLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAuthorLink.Cue = "Ссылка (по клику на имени)";
            this.tbAuthorLink.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAuthorLink.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbAuthorLink.Location = new System.Drawing.Point(125, 150);
            this.tbAuthorLink.Name = "tbAuthorLink";
            this.tbAuthorLink.Size = new System.Drawing.Size(883, 20);
            this.tbAuthorLink.TabIndex = 7;
            this.tbAuthorLink.TextChanged += new System.EventHandler(this.tbAuthorLink_TextChanged);
            // 
            // pasteButton4
            // 
            this.pasteButton4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pasteButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pasteButton4.ImageIndex = 2;
            this.pasteButton4.ImageList = this.ilButtons;
            this.pasteButton4.Location = new System.Drawing.Point(90, 94);
            this.pasteButton4.Name = "pasteButton4";
            this.pasteButton4.Size = new System.Drawing.Size(28, 28);
            this.pasteButton4.TabIndex = 28;
            this.pasteButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pasteButton4.UseVisualStyleBackColor = false;
            this.pasteButton4.ZContextControl = this.tbAuthorAvatarUrl;
            // 
            // tbAuthorAvatarUrl
            // 
            this.tbAuthorAvatarUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAuthorAvatarUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAuthorAvatarUrl.Cue = "Url аватарки";
            this.tbAuthorAvatarUrl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAuthorAvatarUrl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbAuthorAvatarUrl.Location = new System.Drawing.Point(125, 99);
            this.tbAuthorAvatarUrl.Name = "tbAuthorAvatarUrl";
            this.tbAuthorAvatarUrl.Size = new System.Drawing.Size(952, 20);
            this.tbAuthorAvatarUrl.TabIndex = 6;
            this.tbAuthorAvatarUrl.TextChanged += new System.EventHandler(this.tbAuthorAvatarUrl_TextChanged);
            // 
            // contextLabel8
            // 
            this.contextLabel8.AutoSize = true;
            this.contextLabel8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextLabel8.ForeColor = System.Drawing.Color.DarkGreen;
            this.contextLabel8.Location = new System.Drawing.Point(94, 128);
            this.contextLabel8.Name = "contextLabel8";
            this.contextLabel8.Size = new System.Drawing.Size(203, 16);
            this.contextLabel8.TabIndex = 22;
            this.contextLabel8.Text = "Ссылка (по клику на имени)";
            this.contextLabel8.ZContextControl = this.tbAuthorLink;
            // 
            // contextLabel7
            // 
            this.contextLabel7.AutoSize = true;
            this.contextLabel7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextLabel7.ForeColor = System.Drawing.Color.DarkGreen;
            this.contextLabel7.Location = new System.Drawing.Point(94, 76);
            this.contextLabel7.Name = "contextLabel7";
            this.contextLabel7.Size = new System.Drawing.Size(93, 16);
            this.contextLabel7.TabIndex = 21;
            this.contextLabel7.Text = "Url аватарки";
            this.contextLabel7.ZContextControl = this.tbAuthorAvatarUrl;
            // 
            // contextLabel6
            // 
            this.contextLabel6.AutoSize = true;
            this.contextLabel6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextLabel6.ForeColor = System.Drawing.Color.DarkGreen;
            this.contextLabel6.Location = new System.Drawing.Point(94, 24);
            this.contextLabel6.Name = "contextLabel6";
            this.contextLabel6.Size = new System.Drawing.Size(225, 16);
            this.contextLabel6.TabIndex = 20;
            this.contextLabel6.Text = "Имя (обязательное для автора)";
            this.contextLabel6.ZContextControl = this.tbAuthorName;
            // 
            // tbAuthorName
            // 
            this.tbAuthorName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAuthorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAuthorName.Cue = "Имя (обязательное для автора)";
            this.tbAuthorName.Location = new System.Drawing.Point(90, 44);
            this.tbAuthorName.Name = "tbAuthorName";
            this.tbAuthorName.Size = new System.Drawing.Size(987, 20);
            this.tbAuthorName.TabIndex = 5;
            this.tbAuthorName.TextChanged += new System.EventHandler(this.tbAuthorName_TextChanged);
            // 
            // pbAuthorAvatar
            // 
            this.pbAuthorAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAuthorAvatar.IsCacheImage = true;
            this.pbAuthorAvatar.Location = new System.Drawing.Point(12, 24);
            this.pbAuthorAvatar.Name = "pbAuthorAvatar";
            this.pbAuthorAvatar.Size = new System.Drawing.Size(70, 70);
            this.pbAuthorAvatar.TabIndex = 23;
            this.pbAuthorAvatar.TabStop = false;
            this.pbAuthorAvatar.Text = "Url аватарки";
            this.pbAuthorAvatar.ZContextControl = this.tbAuthorAvatarUrl;
            // 
            // dtpTimestamp
            // 
            this.dtpTimestamp.Checked = false;
            this.dtpTimestamp.CustomFormat = "ddd MMMM dd-го yyyy hh:mm";
            this.dtpTimestamp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimestamp.Location = new System.Drawing.Point(6, 583);
            this.dtpTimestamp.Name = "dtpTimestamp";
            this.dtpTimestamp.ShowCheckBox = true;
            this.dtpTimestamp.Size = new System.Drawing.Size(327, 27);
            this.dtpTimestamp.TabIndex = 10;
            this.dtpTimestamp.ValueChanged += new System.EventHandler(this.dtpTimestamp_ValueChanged);
            // 
            // tpWebhook
            // 
            this.tpWebhook.Controls.Add(this.bCopyRAW);
            this.tpWebhook.Controls.Add(this.bPasteRAW);
            this.tpWebhook.Controls.Add(this.bExportHook);
            this.tpWebhook.Controls.Add(this.cbForDiscord);
            this.tpWebhook.Controls.Add(this.tbRAW);
            this.tpWebhook.Controls.Add(this.label4);
            this.tpWebhook.Controls.Add(this.bExportAllHooks);
            this.tpWebhook.Controls.Add(this.bExportAllPresets);
            this.tpWebhook.Controls.Add(this.bExportCurrentPreset);
            this.tpWebhook.Controls.Add(this.bImport);
            this.tpWebhook.Location = new System.Drawing.Point(4, 27);
            this.tpWebhook.Name = "tpWebhook";
            this.tpWebhook.Padding = new System.Windows.Forms.Padding(3);
            this.tpWebhook.Size = new System.Drawing.Size(1093, 620);
            this.tpWebhook.TabIndex = 1;
            this.tpWebhook.Text = "Импорт-экспорт";
            this.tpWebhook.UseVisualStyleBackColor = true;
            // 
            // bCopyRAW
            // 
            this.bCopyRAW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCopyRAW.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bCopyRAW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCopyRAW.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCopyRAW.ForeColor = System.Drawing.Color.DarkGreen;
            this.bCopyRAW.ImageKey = "ClipboardCopy.png";
            this.bCopyRAW.ImageList = this.ilButtons;
            this.bCopyRAW.Location = new System.Drawing.Point(726, 538);
            this.bCopyRAW.Name = "bCopyRAW";
            this.bCopyRAW.Size = new System.Drawing.Size(113, 28);
            this.bCopyRAW.TabIndex = 4;
            this.bCopyRAW.Text = "Копировать";
            this.bCopyRAW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCopyRAW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bCopyRAW.UseVisualStyleBackColor = false;
            this.bCopyRAW.ZContextControl = this.tbRAW;
            // 
            // tbRAW
            // 
            this.tbRAW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRAW.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.tbRAW.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\n";
            this.tbRAW.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.tbRAW.BackBrush = null;
            this.tbRAW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRAW.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.tbRAW.CharHeight = 14;
            this.tbRAW.CharWidth = 8;
            this.tbRAW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRAW.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbRAW.IsReplaceMode = false;
            this.tbRAW.Language = FastColoredTextBoxNS.Language.JS;
            this.tbRAW.LeftBracket = '(';
            this.tbRAW.LeftBracket2 = '{';
            this.tbRAW.Location = new System.Drawing.Point(6, 26);
            this.tbRAW.Name = "tbRAW";
            this.tbRAW.Paddings = new System.Windows.Forms.Padding(0);
            this.tbRAW.RightBracket = ')';
            this.tbRAW.RightBracket2 = '}';
            this.tbRAW.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tbRAW.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("tbRAW.ServiceColors")));
            this.tbRAW.Size = new System.Drawing.Size(1081, 506);
            this.tbRAW.TabIndex = 1;
            this.tbRAW.Zoom = 100;
            // 
            // bPasteRAW
            // 
            this.bPasteRAW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bPasteRAW.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bPasteRAW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPasteRAW.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.bPasteRAW.ForeColor = System.Drawing.Color.DarkGreen;
            this.bPasteRAW.ImageIndex = 2;
            this.bPasteRAW.ImageList = this.ilButtons;
            this.bPasteRAW.Location = new System.Drawing.Point(845, 538);
            this.bPasteRAW.Name = "bPasteRAW";
            this.bPasteRAW.Size = new System.Drawing.Size(113, 28);
            this.bPasteRAW.TabIndex = 5;
            this.bPasteRAW.Text = "Вставить";
            this.bPasteRAW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bPasteRAW.UseVisualStyleBackColor = false;
            this.bPasteRAW.ZContextControl = this.tbRAW;
            // 
            // bExportHook
            // 
            this.bExportHook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bExportHook.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bExportHook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExportHook.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExportHook.ForeColor = System.Drawing.Color.Brown;
            this.bExportHook.ImageKey = "export.png";
            this.bExportHook.ImageList = this.ilButtons;
            this.bExportHook.Location = new System.Drawing.Point(262, 566);
            this.bExportHook.Name = "bExportHook";
            this.bExportHook.Size = new System.Drawing.Size(110, 48);
            this.bExportHook.TabIndex = 7;
            this.bExportHook.Text = "Экспорт канала";
            this.bExportHook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bExportHook.UseVisualStyleBackColor = false;
            this.bExportHook.Click += new System.EventHandler(this.bExportHook_Click);
            // 
            // cbForDiscord
            // 
            this.cbForDiscord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbForDiscord.AutoSize = true;
            this.cbForDiscord.Checked = true;
            this.cbForDiscord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbForDiscord.Location = new System.Drawing.Point(8, 538);
            this.cbForDiscord.Name = "cbForDiscord";
            this.cbForDiscord.Size = new System.Drawing.Size(195, 22);
            this.cbForDiscord.TabIndex = 16;
            this.cbForDiscord.Text = "Экспорт для Discord";
            this.cbForDiscord.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(6, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Окно обмена";
            // 
            // bExportAllHooks
            // 
            this.bExportAllHooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bExportAllHooks.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bExportAllHooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExportAllHooks.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExportAllHooks.ForeColor = System.Drawing.Color.Brown;
            this.bExportAllHooks.ImageKey = "export.png";
            this.bExportAllHooks.ImageList = this.ilButtons;
            this.bExportAllHooks.Location = new System.Drawing.Point(378, 566);
            this.bExportAllHooks.Name = "bExportAllHooks";
            this.bExportAllHooks.Size = new System.Drawing.Size(134, 48);
            this.bExportAllHooks.TabIndex = 8;
            this.bExportAllHooks.Text = "Экспорт всех каналов";
            this.bExportAllHooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bExportAllHooks.UseVisualStyleBackColor = false;
            this.bExportAllHooks.Click += new System.EventHandler(this.bExportAllHooks_Click);
            // 
            // bExportAllPresets
            // 
            this.bExportAllPresets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bExportAllPresets.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bExportAllPresets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExportAllPresets.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExportAllPresets.ForeColor = System.Drawing.Color.DarkGreen;
            this.bExportAllPresets.ImageKey = "export.png";
            this.bExportAllPresets.ImageList = this.ilButtons;
            this.bExportAllPresets.Location = new System.Drawing.Point(124, 566);
            this.bExportAllPresets.Name = "bExportAllPresets";
            this.bExportAllPresets.Size = new System.Drawing.Size(132, 48);
            this.bExportAllPresets.TabIndex = 6;
            this.bExportAllPresets.Text = "Экспорт всех пресетов";
            this.bExportAllPresets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bExportAllPresets.UseVisualStyleBackColor = false;
            this.bExportAllPresets.Click += new System.EventHandler(this.bExportAllPresets_Click);
            // 
            // bExportCurrentPreset
            // 
            this.bExportCurrentPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bExportCurrentPreset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bExportCurrentPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExportCurrentPreset.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExportCurrentPreset.ForeColor = System.Drawing.Color.DarkGreen;
            this.bExportCurrentPreset.ImageKey = "export.png";
            this.bExportCurrentPreset.ImageList = this.ilButtons;
            this.bExportCurrentPreset.Location = new System.Drawing.Point(8, 566);
            this.bExportCurrentPreset.Name = "bExportCurrentPreset";
            this.bExportCurrentPreset.Size = new System.Drawing.Size(110, 48);
            this.bExportCurrentPreset.TabIndex = 3;
            this.bExportCurrentPreset.Text = "Экспорт пресета";
            this.bExportCurrentPreset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bExportCurrentPreset.UseVisualStyleBackColor = false;
            this.bExportCurrentPreset.Click += new System.EventHandler(this.bExportCurrentPreset_Click);
            // 
            // bImport
            // 
            this.bImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bImport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bImport.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bImport.ForeColor = System.Drawing.Color.DarkGreen;
            this.bImport.ImageKey = "import.png";
            this.bImport.ImageList = this.ilButtons;
            this.bImport.Location = new System.Drawing.Point(994, 538);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(93, 28);
            this.bImport.TabIndex = 2;
            this.bImport.Text = "Импорт";
            this.bImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bImport.UseVisualStyleBackColor = false;
            this.bImport.Click += new System.EventHandler(this.bImport_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "refresh");
            // 
            // cbPresets
            // 
            this.cbPresets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPresets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPresets.Location = new System.Drawing.Point(88, 7);
            this.cbPresets.Name = "cbPresets";
            this.cbPresets.Size = new System.Drawing.Size(428, 26);
            this.cbPresets.TabIndex = 1;
            this.cbPresets.SelectedValueChanged += new System.EventHandler(this.cbPresets_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Пресет:";
            // 
            // bDuplicatePreset
            // 
            this.bDuplicatePreset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bDuplicatePreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDuplicatePreset.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDuplicatePreset.ForeColor = System.Drawing.Color.DarkGreen;
            this.bDuplicatePreset.ImageKey = "copy.png";
            this.bDuplicatePreset.ImageList = this.ilButtons;
            this.bDuplicatePreset.Location = new System.Drawing.Point(556, 6);
            this.bDuplicatePreset.Name = "bDuplicatePreset";
            this.bDuplicatePreset.Size = new System.Drawing.Size(126, 28);
            this.bDuplicatePreset.TabIndex = 102;
            this.bDuplicatePreset.Text = "Дублировать";
            this.bDuplicatePreset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bDuplicatePreset.UseVisualStyleBackColor = false;
            this.bDuplicatePreset.Click += new System.EventHandler(this.bDuplicatePreset_Click);
            // 
            // bCreatePreset
            // 
            this.bCreatePreset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bCreatePreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCreatePreset.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreatePreset.ForeColor = System.Drawing.Color.DarkGreen;
            this.bCreatePreset.ImageKey = "add.png";
            this.bCreatePreset.ImageList = this.ilButtons;
            this.bCreatePreset.Location = new System.Drawing.Point(522, 6);
            this.bCreatePreset.Name = "bCreatePreset";
            this.bCreatePreset.Size = new System.Drawing.Size(28, 28);
            this.bCreatePreset.TabIndex = 101;
            this.bCreatePreset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCreatePreset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bCreatePreset.UseVisualStyleBackColor = false;
            this.bCreatePreset.Click += new System.EventHandler(this.bCreatePreset_Click);
            // 
            // bRemovePreset
            // 
            this.bRemovePreset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bRemovePreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRemovePreset.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRemovePreset.ForeColor = System.Drawing.Color.DarkGreen;
            this.bRemovePreset.ImageKey = "remove.png";
            this.bRemovePreset.ImageList = this.ilButtons;
            this.bRemovePreset.Location = new System.Drawing.Point(760, 6);
            this.bRemovePreset.Name = "bRemovePreset";
            this.bRemovePreset.Size = new System.Drawing.Size(28, 28);
            this.bRemovePreset.TabIndex = 104;
            this.bRemovePreset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bRemovePreset.UseVisualStyleBackColor = false;
            this.bRemovePreset.Click += new System.EventHandler(this.bRemovePreset_Click);
            // 
            // bEditPresetName
            // 
            this.bEditPresetName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bEditPresetName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditPresetName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEditPresetName.ForeColor = System.Drawing.Color.DarkGreen;
            this.bEditPresetName.ImageKey = "edit.png";
            this.bEditPresetName.ImageList = this.ilButtons;
            this.bEditPresetName.Location = new System.Drawing.Point(688, 6);
            this.bEditPresetName.Name = "bEditPresetName";
            this.bEditPresetName.Size = new System.Drawing.Size(66, 28);
            this.bEditPresetName.TabIndex = 103;
            this.bEditPresetName.Text = "Имя";
            this.bEditPresetName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bEditPresetName.UseVisualStyleBackColor = false;
            this.bEditPresetName.Click += new System.EventHandler(this.bEditName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1121, 737);
            this.Controls.Add(this.bRemovePreset);
            this.Controls.Add(this.cbPresets);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bCreatePreset);
            this.Controls.Add(this.bEditPresetName);
            this.Controls.Add(this.bDuplicatePreset);
            this.Controls.Add(this.bSend);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(963, 776);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord Supreme Message Sender v0.1 by ASiCorp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSenderAvatar)).EndInit();
            this.tpMisc.ResumeLayout(false);
            this.tpMisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urlContextPicturebox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFooterIcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuthorAvatar)).EndInit();
            this.tpWebhook.ResumeLayout(false);
            this.tpWebhook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRAW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.CueTextBox tbSenderName;
        private System.Windows.Forms.CueTextBox tbBodyMessage;
        internal System.Windows.Forms.Button bSend;
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpWebhook;
        private System.Windows.Forms.CheckBox cbUseColor;
        private System.Windows.Forms.TabPage tpMisc;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CueTextBox tbTitle;
        private System.Windows.Forms.DateTimePicker dtpTimestamp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CueTextBox tbAuthorName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CueTextBox tbFooterText;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPresets;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button bDuplicatePreset;
        private System.Windows.Forms.ImageList ilButtons;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button bImport;
        private FastColoredTextBoxNS.FastColoredTextBox tbRAW;
        private System.Windows.Forms.ContextLabel lTimestamp;
        private System.Windows.Forms.ContextLabel contextLabel2;
        private System.Windows.Forms.ContextLabel contextLabel1;
        private System.Windows.Forms.ContextLabel contextLabel3;
        private System.Windows.Forms.ContextLabel contextLabel5;
        private System.Windows.Forms.ContextLabel contextLabel4;
        private System.Windows.Forms.ContextLabel contextLabel8;
        private System.Windows.Forms.ContextLabel contextLabel7;
        private System.Windows.Forms.ContextLabel contextLabel6;
        private System.Windows.Forms.ContextLabel contextLabel12;
        private System.Windows.Forms.ContextLabel contextLabel11;
        private System.Windows.Forms.ContextLabel contextLabel10;
        private System.Windows.Forms.ContextLabel contextLabel9;
        private System.Windows.Forms.URLContextPicturebox pbSenderAvatar;
        private System.Windows.Forms.URLContextPicturebox pbFooterIcon;
        private System.Windows.Forms.URLContextPicturebox pbAuthorAvatar;
        private System.Windows.Forms.PasteButton pasteButton1;
        private System.Windows.Forms.PasteButton pasteButton3;
        private System.Windows.Forms.PasteButton pasteButton2;
        private System.Windows.Forms.PasteButton pasteButton5;
        private System.Windows.Forms.PasteButton pasteButton4;
        private System.Windows.Forms.PasteButton pasteButton6;
        private System.Windows.Forms.URLContextPicturebox urlContextPicturebox1;
        private System.Windows.Forms.PasteButton pasteButton7;
        internal System.Windows.Forms.Button bRemoveChannel;
        private System.Windows.Forms.ComboBox cbWebhooks;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button bCreateChannel;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button bDuplicateChannel;
        internal System.Windows.Forms.Button bCreatePreset;
        internal System.Windows.Forms.Button bRemovePreset;
        private System.Windows.Forms.PasteButton pasteButton8;
        internal System.Windows.Forms.Button bEditPresetName;
        internal System.Windows.Forms.Button bEditChannelName;
        private System.Windows.Forms.CheckBox cbForDiscord;
        internal System.Windows.Forms.Button bExportCurrentPreset;
        private System.Windows.Forms.CueTextBoxURL tbFullWebhook;
        private System.Windows.Forms.CueTextBoxURL tbSenderAvatarUrl;
        private System.Windows.Forms.CueTextBoxURL tbThumbnailUrl;
        private System.Windows.Forms.CueTextBoxURL tbImageUrl;
        private System.Windows.Forms.CueTextBoxURL tbLink;
        private System.Windows.Forms.CueTextBoxURL tbAuthorAvatarUrl;
        private System.Windows.Forms.CueTextBoxURL tbAuthorLink;
        private System.Windows.Forms.CueTextBoxURL tbFooterIconUrl;
        internal System.Windows.Forms.Button bExportAllPresets;
        internal System.Windows.Forms.Button bExportHook;
        internal System.Windows.Forms.Button bExportAllHooks;
        private System.Windows.Forms.PasteButton bPasteRAW;
        internal System.Windows.Forms.CopyButton bCopyRAW;
        internal System.Windows.Forms.CopyButton bCopyWebhook;
    }
}


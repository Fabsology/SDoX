namespace SDoX
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.documentationTitle = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DocumentationViewBox = new VPKSoft.RichTextEdit.RichTextBoxExtended();
            this.DocumentCreated = new System.Windows.Forms.Label();
            this.DocumentLastUpdated = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.EditorAuthorBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.EditorTitleBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel4 = new System.Windows.Forms.Panel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EditorContentBox = new VPKSoft.RichTextEdit.RichTextBoxWithToolStrip();
            this.label6 = new System.Windows.Forms.Label();
            this.EditorDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.searchbar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.documentationListView = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FileTitle = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton7 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 495);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.DocumentationViewBox);
            this.tabPage1.Controls.Add(this.DocumentCreated);
            this.tabPage1.Controls.Add(this.DocumentLastUpdated);
            this.tabPage1.Controls.Add(this.AuthorLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Documentation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 311);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(0, 19);
            this.materialLabel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.documentationTitle);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 44);
            this.panel2.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.materialRaisedButton6);
            this.panel7.Location = new System.Drawing.Point(282, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(123, 36);
            this.panel7.TabIndex = 9;
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.AutoSize = true;
            this.materialRaisedButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.Icon = null;
            this.materialRaisedButton6.Location = new System.Drawing.Point(0, 0);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(123, 36);
            this.materialRaisedButton6.TabIndex = 7;
            this.materialRaisedButton6.Text = "Export to PDF";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            this.materialRaisedButton6.Click += new System.EventHandler(this.materialRaisedButton6_Click);
            // 
            // documentationTitle
            // 
            this.documentationTitle.AutoSize = true;
            this.documentationTitle.Depth = 0;
            this.documentationTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.documentationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.documentationTitle.Location = new System.Drawing.Point(6, 14);
            this.documentationTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.documentationTitle.Name = "documentationTitle";
            this.documentationTitle.Size = new System.Drawing.Size(0, 19);
            this.documentationTitle.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.materialCheckBox1);
            this.panel1.Controls.Add(this.materialRaisedButton3);
            this.panel1.Location = new System.Drawing.Point(417, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 42);
            this.panel1.TabIndex = 7;
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Depth = 0;
            this.deleteButton.Enabled = false;
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(108, 3);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Primary = true;
            this.deleteButton.Size = new System.Drawing.Size(69, 36);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.BackColor = System.Drawing.Color.White;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(110, 7);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(64, 30);
            this.materialCheckBox1.TabIndex = 6;
            this.materialCheckBox1.Text = "Allow";
            this.materialCheckBox1.UseVisualStyleBackColor = false;
            this.materialCheckBox1.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(183, 3);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(161, 36);
            this.materialRaisedButton3.TabIndex = 5;
            this.materialRaisedButton3.Text = "Edit this Document";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // DocumentationViewBox
            // 
            this.DocumentationViewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentationViewBox.EnableAutoDragDrop = true;
            this.DocumentationViewBox.Location = new System.Drawing.Point(3, 45);
            this.DocumentationViewBox.Name = "DocumentationViewBox";
            this.DocumentationViewBox.Size = new System.Drawing.Size(762, 387);
            this.DocumentationViewBox.TabIndex = 6;
            this.DocumentationViewBox.Text = "";
            // 
            // DocumentCreated
            // 
            this.DocumentCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentCreated.AutoSize = true;
            this.DocumentCreated.ForeColor = System.Drawing.Color.Gray;
            this.DocumentCreated.Location = new System.Drawing.Point(564, 450);
            this.DocumentCreated.Name = "DocumentCreated";
            this.DocumentCreated.Size = new System.Drawing.Size(47, 13);
            this.DocumentCreated.TabIndex = 4;
            this.DocumentCreated.Text = "Created:";
            // 
            // DocumentLastUpdated
            // 
            this.DocumentLastUpdated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentLastUpdated.AutoSize = true;
            this.DocumentLastUpdated.ForeColor = System.Drawing.Color.Gray;
            this.DocumentLastUpdated.Location = new System.Drawing.Point(382, 450);
            this.DocumentLastUpdated.Name = "DocumentLastUpdated";
            this.DocumentLastUpdated.Size = new System.Drawing.Size(74, 13);
            this.DocumentLastUpdated.TabIndex = 3;
            this.DocumentLastUpdated.Text = "Last Updated:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.ForeColor = System.Drawing.Color.Gray;
            this.AuthorLabel.Location = new System.Drawing.Point(6, 450);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.AuthorLabel.TabIndex = 1;
            this.AuthorLabel.Text = "Author:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.EditorDescriptionBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.materialRaisedButton7);
            this.panel6.Controls.Add(this.EditorAuthorBox);
            this.panel6.Controls.Add(this.EditorTitleBox);
            this.panel6.Location = new System.Drawing.Point(18, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(746, 63);
            this.panel6.TabIndex = 11;
            // 
            // EditorAuthorBox
            // 
            this.EditorAuthorBox.Depth = 0;
            this.EditorAuthorBox.Hint = "Author";
            this.EditorAuthorBox.Location = new System.Drawing.Point(3, 32);
            this.EditorAuthorBox.MaxLength = 32767;
            this.EditorAuthorBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditorAuthorBox.Name = "EditorAuthorBox";
            this.EditorAuthorBox.PasswordChar = '\0';
            this.EditorAuthorBox.SelectedText = "";
            this.EditorAuthorBox.SelectionLength = 0;
            this.EditorAuthorBox.SelectionStart = 0;
            this.EditorAuthorBox.Size = new System.Drawing.Size(308, 23);
            this.EditorAuthorBox.TabIndex = 1;
            this.EditorAuthorBox.TabStop = false;
            this.EditorAuthorBox.UseSystemPasswordChar = false;
            // 
            // EditorTitleBox
            // 
            this.EditorTitleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditorTitleBox.Depth = 0;
            this.EditorTitleBox.Hint = "Title";
            this.EditorTitleBox.Location = new System.Drawing.Point(3, 5);
            this.EditorTitleBox.MaxLength = 32767;
            this.EditorTitleBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditorTitleBox.Name = "EditorTitleBox";
            this.EditorTitleBox.PasswordChar = '\0';
            this.EditorTitleBox.SelectedText = "";
            this.EditorTitleBox.SelectionLength = 0;
            this.EditorTitleBox.SelectionStart = 0;
            this.EditorTitleBox.Size = new System.Drawing.Size(671, 23);
            this.EditorTitleBox.TabIndex = 0;
            this.EditorTitleBox.TabStop = false;
            this.EditorTitleBox.UseSystemPasswordChar = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.materialRaisedButton1);
            this.panel4.Location = new System.Drawing.Point(704, 417);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 52);
            this.panel4.TabIndex = 10;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(3, 10);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(55, 36);
            this.materialRaisedButton1.TabIndex = 7;
            this.materialRaisedButton1.Text = "Save";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EditorContentBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 341);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Content";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(689, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 9);
            this.label2.TabIndex = 1;
            this.label2.Text = "Show RTF";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EditorContentBox
            // 
            this.EditorContentBox.AcceptsTab = true;
            this.EditorContentBox.AllowDrop = true;
            this.EditorContentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditorContentBox.AutomaticColorText = "Automatic";
            this.EditorContentBox.ColorButtonForeground = System.Drawing.Color.Black;
            this.EditorContentBox.ColorGlyph = System.Drawing.Color.Blue;
            this.EditorContentBox.ImageFilter = "Images files|*.bmp;*.png;*.jpg;*.jpeg|Bitmaps|*.bmp|Portable Network Graphics|*.p" +
    "ng|Jpeg|*.jpg;*.jpeg";
            this.EditorContentBox.Location = new System.Drawing.Point(9, 19);
            this.EditorContentBox.MoreColorsText = "More colors...";
            this.EditorContentBox.Name = "EditorContentBox";
            this.EditorContentBox.Size = new System.Drawing.Size(744, 316);
            this.EditorContentBox.TabIndex = 0;
            this.EditorContentBox.WordWrap = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Description";
            // 
            // EditorDescriptionBox
            // 
            this.EditorDescriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditorDescriptionBox.Location = new System.Drawing.Point(6, 427);
            this.EditorDescriptionBox.Name = "EditorDescriptionBox";
            this.EditorDescriptionBox.Size = new System.Drawing.Size(695, 39);
            this.EditorDescriptionBox.TabIndex = 4;
            this.EditorDescriptionBox.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.documentationListView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 469);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Overview";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.searchbar);
            this.panel5.Location = new System.Drawing.Point(6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(670, 30);
            this.panel5.TabIndex = 6;
            // 
            // searchbar
            // 
            this.searchbar.Depth = 0;
            this.searchbar.Hint = "Search";
            this.searchbar.Location = new System.Drawing.Point(3, 1);
            this.searchbar.MaxLength = 32767;
            this.searchbar.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchbar.Name = "searchbar";
            this.searchbar.PasswordChar = '\0';
            this.searchbar.SelectedText = "";
            this.searchbar.SelectionLength = 0;
            this.searchbar.SelectionStart = 0;
            this.searchbar.Size = new System.Drawing.Size(318, 23);
            this.searchbar.TabIndex = 0;
            this.searchbar.TabStop = false;
            this.searchbar.UseSystemPasswordChar = false;
            this.searchbar.TextChanged += new System.EventHandler(this.searchbar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 9);
            this.label1.TabIndex = 5;
            this.label1.Text = "Double click to open";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.materialRaisedButton2);
            this.panel3.Location = new System.Drawing.Point(679, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(85, 42);
            this.panel3.TabIndex = 4;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(3, 3);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(79, 36);
            this.materialRaisedButton2.TabIndex = 2;
            this.materialRaisedButton2.Text = "Refresh";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // documentationListView
            // 
            this.documentationListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documentationListView.HideSelection = false;
            this.documentationListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.documentationListView.Location = new System.Drawing.Point(6, 45);
            this.documentationListView.Name = "documentationListView";
            this.documentationListView.Size = new System.Drawing.Size(756, 418);
            this.documentationListView.TabIndex = 3;
            this.documentationListView.UseCompatibleStateImageBehavior = false;
            this.documentationListView.View = System.Windows.Forms.View.Details;
            this.documentationListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.documentationListView_MouseDoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "SdoX File|*.SDoX";
            this.openFileDialog1.FileName = "SDox.SDox";
            this.openFileDialog1.Filter = "SDoX File|*.SDoX";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton4.AutoSize = true;
            this.materialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Icon = null;
            this.materialRaisedButton4.Location = new System.Drawing.Point(697, 71);
            this.materialRaisedButton4.Margin = new System.Windows.Forms.Padding(0);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(85, 36);
            this.materialRaisedButton4.TabIndex = 3;
            this.materialRaisedButton4.Text = "Save File";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton5.AutoSize = true;
            this.materialRaisedButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Icon = null;
            this.materialRaisedButton5.Location = new System.Drawing.Point(591, 71);
            this.materialRaisedButton5.Margin = new System.Windows.Forms.Padding(0);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(87, 36);
            this.materialRaisedButton5.TabIndex = 4;
            this.materialRaisedButton5.Text = "Open File";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            this.materialRaisedButton5.Click += new System.EventHandler(this.materialRaisedButton5_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "SDoX File|*.SDoX";
            this.saveFileDialog1.Filter = "SDoX File|*.SDoX";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SDoX.Properties.Resources.FAVICON_32;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FileTitle
            // 
            this.FileTitle.AutoSize = true;
            this.FileTitle.BackColor = System.Drawing.Color.White;
            this.FileTitle.Depth = 0;
            this.FileTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.FileTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FileTitle.Location = new System.Drawing.Point(12, 71);
            this.FileTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.FileTitle.Name = "FileTitle";
            this.FileTitle.Size = new System.Drawing.Size(87, 19);
            this.FileTitle.TabIndex = 6;
            this.FileTitle.Text = "SDoX.SDoX";
            // 
            // materialRaisedButton7
            // 
            this.materialRaisedButton7.AutoSize = true;
            this.materialRaisedButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton7.Depth = 0;
            this.materialRaisedButton7.Icon = null;
            this.materialRaisedButton7.Location = new System.Drawing.Point(680, 14);
            this.materialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton7.Name = "materialRaisedButton7";
            this.materialRaisedButton7.Primary = true;
            this.materialRaisedButton7.Size = new System.Drawing.Size(63, 36);
            this.materialRaisedButton7.TabIndex = 2;
            this.materialRaisedButton7.Text = "Clear";
            this.materialRaisedButton7.UseVisualStyleBackColor = true;
            this.materialRaisedButton7.Click += new System.EventHandler(this.materialRaisedButton7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.FileTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialRaisedButton5);
            this.Controls.Add(this.materialRaisedButton4);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "SDoX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label DocumentCreated;
        private System.Windows.Forms.Label DocumentLastUpdated;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox EditorDescriptionBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.ListView documentationListView;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private VPKSoft.RichTextEdit.RichTextBoxWithToolStrip EditorContentBox;
        private VPKSoft.RichTextEdit.RichTextBoxExtended DocumentationViewBox;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton deleteButton;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel documentationTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField searchbar;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField EditorAuthorBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField EditorTitleBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel FileTitle;
        private System.Windows.Forms.Panel panel7;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton7;
    }
}


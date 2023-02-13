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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.documentationTitle = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DocumentationViewBox = new VPKSoft.RichTextEdit.RichTextBoxExtended();
            this.DocumentCreated = new System.Windows.Forms.Label();
            this.DocumentLastUpdated = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EditorContentBox = new VPKSoft.RichTextEdit.RichTextBoxWithToolStrip();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EditorDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EditorAuthorBox = new System.Windows.Forms.TextBox();
            this.EditorTitleBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.documentationListView = new System.Windows.Forms.ListView();
            this.searchbar = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 362);
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
            this.tabPage1.Size = new System.Drawing.Size(768, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Documentation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.documentationTitle);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 44);
            this.panel2.TabIndex = 8;
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
            this.DocumentationViewBox.Location = new System.Drawing.Point(3, 45);
            this.DocumentationViewBox.Name = "DocumentationViewBox";
            this.DocumentationViewBox.Size = new System.Drawing.Size(762, 262);
            this.DocumentationViewBox.TabIndex = 6;
            this.DocumentationViewBox.Text = "";
            // 
            // DocumentCreated
            // 
            this.DocumentCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentCreated.AutoSize = true;
            this.DocumentCreated.ForeColor = System.Drawing.Color.Gray;
            this.DocumentCreated.Location = new System.Drawing.Point(564, 317);
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
            this.DocumentLastUpdated.Location = new System.Drawing.Point(382, 317);
            this.DocumentLastUpdated.Name = "DocumentLastUpdated";
            this.DocumentLastUpdated.Size = new System.Drawing.Size(74, 13);
            this.DocumentLastUpdated.TabIndex = 3;
            this.DocumentLastUpdated.Text = "Last Updated:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.EditorDescriptionBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.EditorAuthorBox);
            this.tabPage2.Controls.Add(this.EditorTitleBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.materialRaisedButton1);
            this.panel4.Location = new System.Drawing.Point(704, 284);
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
            this.groupBox1.Controls.Add(this.EditorContentBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 218);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Content";
            // 
            // EditorContentBox
            // 
            this.EditorContentBox.AcceptsTab = true;
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
            this.EditorContentBox.Size = new System.Drawing.Size(744, 193);
            this.EditorContentBox.TabIndex = 0;
            this.EditorContentBox.WordWrap = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Author";
            // 
            // EditorDescriptionBox
            // 
            this.EditorDescriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditorDescriptionBox.Location = new System.Drawing.Point(6, 294);
            this.EditorDescriptionBox.Name = "EditorDescriptionBox";
            this.EditorDescriptionBox.Size = new System.Drawing.Size(695, 39);
            this.EditorDescriptionBox.TabIndex = 4;
            this.EditorDescriptionBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Title";
            // 
            // EditorAuthorBox
            // 
            this.EditorAuthorBox.Location = new System.Drawing.Point(67, 33);
            this.EditorAuthorBox.Name = "EditorAuthorBox";
            this.EditorAuthorBox.Size = new System.Drawing.Size(133, 20);
            this.EditorAuthorBox.TabIndex = 1;
            // 
            // EditorTitleBox
            // 
            this.EditorTitleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditorTitleBox.Location = new System.Drawing.Point(67, 7);
            this.EditorTitleBox.Name = "EditorTitleBox";
            this.EditorTitleBox.Size = new System.Drawing.Size(695, 20);
            this.EditorTitleBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.documentationListView);
            this.tabPage3.Controls.Add(this.searchbar);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 336);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Overview";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.documentationListView.Location = new System.Drawing.Point(6, 42);
            this.documentationListView.Name = "documentationListView";
            this.documentationListView.Size = new System.Drawing.Size(756, 288);
            this.documentationListView.TabIndex = 3;
            this.documentationListView.UseCompatibleStateImageBehavior = false;
            this.documentationListView.View = System.Windows.Forms.View.Details;
            this.documentationListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.documentationListView_MouseDoubleClick);
            // 
            // searchbar
            // 
            this.searchbar.Location = new System.Drawing.Point(6, 12);
            this.searchbar.Name = "searchbar";
            this.searchbar.Size = new System.Drawing.Size(338, 20);
            this.searchbar.TabIndex = 1;
            this.searchbar.TextChanged += new System.EventHandler(this.searchbar_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "SdoX File|*.SDoX";
            this.openFileDialog1.FileName = "SDox.SDox";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 311);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(0, 18);
            this.materialLabel1.TabIndex = 1;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.ForeColor = System.Drawing.Color.Gray;
            this.AuthorLabel.Location = new System.Drawing.Point(6, 317);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.AuthorLabel.TabIndex = 1;
            this.AuthorLabel.Text = "Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 9);
            this.label1.TabIndex = 5;
            this.label1.Text = "Double click to open";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "SDoX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label DocumentCreated;
        private System.Windows.Forms.Label DocumentLastUpdated;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox searchbar;
        private System.Windows.Forms.TextBox EditorAuthorBox;
        private System.Windows.Forms.TextBox EditorTitleBox;
        private System.Windows.Forms.RichTextBox EditorDescriptionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
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
    }
}


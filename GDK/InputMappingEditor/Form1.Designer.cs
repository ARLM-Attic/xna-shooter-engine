namespace InputMappingEditor
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.keyCombo = new System.Windows.Forms.ComboBox();
            this.keyComboLabel = new System.Windows.Forms.Label();
            this.keyEnable = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineDocumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutEngineGDKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseCombo = new System.Windows.Forms.ComboBox();
            this.mouseComboLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mouseEnable = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.controllerCombo = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.controllerComboLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputNameBox = new System.Windows.Forms.TextBox();
            this.controllerEnable = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inputList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.removeInputButton = new System.Windows.Forms.ToolStripButton();
            this.addInputButton = new System.Windows.Forms.ToolStripButton();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validateInputMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.keyCombo);
            this.groupBox2.Controls.Add(this.keyComboLabel);
            this.groupBox2.Controls.Add(this.keyEnable);
            this.groupBox2.Location = new System.Drawing.Point(16, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 56);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // keyCombo
            // 
            this.keyCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.keyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyCombo.Enabled = false;
            this.keyCombo.FormattingEnabled = true;
            this.keyCombo.Location = new System.Drawing.Point(136, 21);
            this.keyCombo.Name = "keyCombo";
            this.keyCombo.Size = new System.Drawing.Size(293, 21);
            this.keyCombo.TabIndex = 16;
            this.keyCombo.SelectedIndexChanged += new System.EventHandler(this.InputMapChanged);
            // 
            // keyComboLabel
            // 
            this.keyComboLabel.AutoSize = true;
            this.keyComboLabel.Enabled = false;
            this.keyComboLabel.Location = new System.Drawing.Point(36, 24);
            this.keyComboLabel.Name = "keyComboLabel";
            this.keyComboLabel.Size = new System.Drawing.Size(94, 13);
            this.keyComboLabel.TabIndex = 15;
            this.keyComboLabel.Text = "Keyboard Button";
            // 
            // keyEnable
            // 
            this.keyEnable.AutoSize = true;
            this.keyEnable.Location = new System.Drawing.Point(9, 1);
            this.keyEnable.Name = "keyEnable";
            this.keyEnable.Size = new System.Drawing.Size(118, 17);
            this.keyEnable.TabIndex = 14;
            this.keyEnable.Text = "Keyboard Binding";
            this.keyEnable.UseVisualStyleBackColor = true;
            this.keyEnable.CheckedChanged += new System.EventHandler(this.InputMapChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.openMenuItem,
            this.toolStripSeparator1,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.toolStripSeparator4,
            this.validateInputMapToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(174, 22);
            this.saveAsMenuItem.Text = "Save As...";
            this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(171, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitMenuItem.Text = "&Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineDocumentationToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutEngineGDKToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // onlineDocumentationToolStripMenuItem
            // 
            this.onlineDocumentationToolStripMenuItem.Name = "onlineDocumentationToolStripMenuItem";
            this.onlineDocumentationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.onlineDocumentationToolStripMenuItem.Text = "Online Documentation...";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(201, 6);
            // 
            // aboutEngineGDKToolStripMenuItem
            // 
            this.aboutEngineGDKToolStripMenuItem.Name = "aboutEngineGDKToolStripMenuItem";
            this.aboutEngineGDKToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.aboutEngineGDKToolStripMenuItem.Text = "About Engine GDK...";
            // 
            // mouseCombo
            // 
            this.mouseCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mouseCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mouseCombo.Enabled = false;
            this.mouseCombo.FormattingEnabled = true;
            this.mouseCombo.Location = new System.Drawing.Point(136, 21);
            this.mouseCombo.Name = "mouseCombo";
            this.mouseCombo.Size = new System.Drawing.Size(293, 21);
            this.mouseCombo.TabIndex = 16;
            this.mouseCombo.SelectedIndexChanged += new System.EventHandler(this.InputMapChanged);
            // 
            // mouseComboLabel
            // 
            this.mouseComboLabel.AutoSize = true;
            this.mouseComboLabel.Enabled = false;
            this.mouseComboLabel.Location = new System.Drawing.Point(36, 24);
            this.mouseComboLabel.Name = "mouseComboLabel";
            this.mouseComboLabel.Size = new System.Drawing.Size(73, 13);
            this.mouseComboLabel.TabIndex = 15;
            this.mouseComboLabel.Text = "Mouse Input";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 1);
            this.panel1.TabIndex = 0;
            // 
            // mouseEnable
            // 
            this.mouseEnable.AutoSize = true;
            this.mouseEnable.Location = new System.Drawing.Point(9, 1);
            this.mouseEnable.Name = "mouseEnable";
            this.mouseEnable.Size = new System.Drawing.Size(105, 17);
            this.mouseEnable.TabIndex = 14;
            this.mouseEnable.Text = "Mouse Binding";
            this.mouseEnable.UseVisualStyleBackColor = true;
            this.mouseEnable.CheckedChanged += new System.EventHandler(this.InputMapChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.mouseCombo);
            this.groupBox3.Controls.Add(this.mouseComboLabel);
            this.groupBox3.Controls.Add(this.mouseEnable);
            this.groupBox3.Location = new System.Drawing.Point(16, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 56);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // controllerCombo
            // 
            this.controllerCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.controllerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controllerCombo.Enabled = false;
            this.controllerCombo.FormattingEnabled = true;
            this.controllerCombo.Location = new System.Drawing.Point(136, 21);
            this.controllerCombo.Name = "controllerCombo";
            this.controllerCombo.Size = new System.Drawing.Size(293, 21);
            this.controllerCombo.TabIndex = 16;
            this.controllerCombo.SelectedIndexChanged += new System.EventHandler(this.InputMapChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(1, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(526, 1);
            this.panel5.TabIndex = 1;
            // 
            // controllerComboLabel
            // 
            this.controllerComboLabel.AutoSize = true;
            this.controllerComboLabel.Enabled = false;
            this.controllerComboLabel.Location = new System.Drawing.Point(36, 24);
            this.controllerComboLabel.Name = "controllerComboLabel";
            this.controllerComboLabel.Size = new System.Drawing.Size(90, 13);
            this.controllerComboLabel.TabIndex = 15;
            this.controllerComboLabel.Text = "Controller Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // inputNameBox
            // 
            this.inputNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNameBox.Location = new System.Drawing.Point(55, 10);
            this.inputNameBox.Name = "inputNameBox";
            this.inputNameBox.Size = new System.Drawing.Size(460, 22);
            this.inputNameBox.TabIndex = 3;
            this.inputNameBox.TextChanged += new System.EventHandler(this.InputMapChanged);
            // 
            // controllerEnable
            // 
            this.controllerEnable.AutoSize = true;
            this.controllerEnable.Location = new System.Drawing.Point(9, 1);
            this.controllerEnable.Name = "controllerEnable";
            this.controllerEnable.Size = new System.Drawing.Size(122, 17);
            this.controllerEnable.TabIndex = 14;
            this.controllerEnable.Text = "Controller Binding";
            this.controllerEnable.UseVisualStyleBackColor = true;
            this.controllerEnable.CheckedChanged += new System.EventHandler(this.InputMapChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.controllerCombo);
            this.groupBox1.Controls.Add(this.controllerComboLabel);
            this.groupBox1.Controls.Add(this.controllerEnable);
            this.groupBox1.Location = new System.Drawing.Point(16, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 56);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(204, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 502);
            this.panel2.TabIndex = 1;
            // 
            // inputList
            // 
            this.inputList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.inputList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputList.FullRowSelect = true;
            this.inputList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.inputList.HideSelection = false;
            this.inputList.Location = new System.Drawing.Point(0, 27);
            this.inputList.MultiSelect = false;
            this.inputList.Name = "inputList";
            this.inputList.Size = new System.Drawing.Size(204, 476);
            this.inputList.TabIndex = 4;
            this.inputList.UseCompatibleStateImageBehavior = false;
            this.inputList.View = System.Windows.Forms.View.Details;
            this.inputList.SelectedIndexChanged += new System.EventHandler(this.inputList_SelectedIndexChanged);
            this.inputList.SizeChanged += new System.EventHandler(this.inputList_SizeChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Inputs";
            this.columnHeader1.Width = 204;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 1);
            this.panel3.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeInputButton,
            this.addInputButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(204, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "Input Mapping Editor";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.inputList);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.inputNameBox);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Size = new System.Drawing.Size(736, 503);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 503);
            this.panel4.TabIndex = 0;
            // 
            // removeInputButton
            // 
            this.removeInputButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.removeInputButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeInputButton.Image = global::InputMappingEditor.Properties.Resources._112_Minus_Orange_16x16_72;
            this.removeInputButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeInputButton.Name = "removeInputButton";
            this.removeInputButton.Size = new System.Drawing.Size(23, 22);
            this.removeInputButton.Text = "Remove";
            // 
            // addInputButton
            // 
            this.addInputButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.addInputButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addInputButton.Image = global::InputMappingEditor.Properties.Resources._112_Plus_Green_16x16_72;
            this.addInputButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addInputButton.Name = "addInputButton";
            this.addInputButton.Size = new System.Drawing.Size(23, 22);
            this.addInputButton.Text = "Add";
            this.addInputButton.Click += new System.EventHandler(this.addInputButton_Click);
            // 
            // newMenuItem
            // 
            this.newMenuItem.Image = global::InputMappingEditor.Properties.Resources.NewDocument;
            this.newMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenuItem.Size = new System.Drawing.Size(174, 22);
            this.newMenuItem.Text = "&New";
            this.newMenuItem.Click += new System.EventHandler(this.newMenuItem_Click);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Image = global::InputMappingEditor.Properties.Resources.OpenFile;
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(174, 22);
            this.openMenuItem.Text = "&Open...";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Image = global::InputMappingEditor.Properties.Resources.saveHS;
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(174, 22);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // validateInputMapToolStripMenuItem
            // 
            this.validateInputMapToolStripMenuItem.Enabled = false;
            this.validateInputMapToolStripMenuItem.Image = global::InputMappingEditor.Properties.Resources.CheckGrammarHS;
            this.validateInputMapToolStripMenuItem.Name = "validateInputMapToolStripMenuItem";
            this.validateInputMapToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.validateInputMapToolStripMenuItem.Text = "Validate Input Map";
            this.validateInputMapToolStripMenuItem.Click += new System.EventHandler(this.validateInputMapToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "Untitled";
            this.saveFileDialog.Filter = "Input Mapping Files|*.input|All Files|*.*";
            this.saveFileDialog.Title = "Save Input Mapping File";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Input Mapping Files|*.input|All Files|*.*";
            this.openFileDialog.Title = "Open Input Mapping File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 527);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Untitled - Input Mapping Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox keyCombo;
        private System.Windows.Forms.Label keyComboLabel;
        private System.Windows.Forms.CheckBox keyEnable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineDocumentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aboutEngineGDKToolStripMenuItem;
        private System.Windows.Forms.ComboBox mouseCombo;
        private System.Windows.Forms.Label mouseComboLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox mouseEnable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox controllerCombo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label controllerComboLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNameBox;
        private System.Windows.Forms.CheckBox controllerEnable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton removeInputButton;
        private System.Windows.Forms.ToolStripButton addInputButton;
        private System.Windows.Forms.ListView inputList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem validateInputMapToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}


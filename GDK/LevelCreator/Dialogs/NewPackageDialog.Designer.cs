namespace Packager.Dialogs
{
    partial class NewPackageDialog
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("New Compiled Package", 0);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("New Open Package", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPackageDialog));
            this.packageSettingsPanel = new System.Windows.Forms.Panel();
            this.locationCombobox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.pkgTextbox = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.pkgNameLabel = new System.Windows.Forms.Label();
            this.pkgType = new System.Windows.Forms.ListView();
            this.newPackageImages = new System.Windows.Forms.ImageList();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionSeparatorPanel = new System.Windows.Forms.Panel();
            this.pkgTypeDescription = new System.Windows.Forms.Label();
            this.pkgTypeName = new System.Windows.Forms.Label();
            this.packageTypeSeparatorPanel = new System.Windows.Forms.Panel();
            this.packageSettingsPanel.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // packageSettingsPanel
            // 
            this.packageSettingsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.packageSettingsPanel.Controls.Add(this.locationCombobox);
            this.packageSettingsPanel.Controls.Add(this.okButton);
            this.packageSettingsPanel.Controls.Add(this.cancelButton);
            this.packageSettingsPanel.Controls.Add(this.browseButton);
            this.packageSettingsPanel.Controls.Add(this.pkgTextbox);
            this.packageSettingsPanel.Controls.Add(this.locationLabel);
            this.packageSettingsPanel.Controls.Add(this.pkgNameLabel);
            this.packageSettingsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.packageSettingsPanel.Location = new System.Drawing.Point(0, 160);
            this.packageSettingsPanel.Name = "packageSettingsPanel";
            this.packageSettingsPanel.Size = new System.Drawing.Size(565, 119);
            this.packageSettingsPanel.TabIndex = 0;
            // 
            // locationCombobox
            // 
            this.locationCombobox.FormattingEnabled = true;
            this.locationCombobox.Location = new System.Drawing.Point(137, 40);
            this.locationCombobox.Name = "locationCombobox";
            this.locationCombobox.Size = new System.Drawing.Size(310, 21);
            this.locationCombobox.TabIndex = 10;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(397, 84);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(478, 84);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(453, 40);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 7;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // pkgTextbox
            // 
            this.pkgTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pkgTextbox.Location = new System.Drawing.Point(137, 13);
            this.pkgTextbox.Name = "pkgTextbox";
            this.pkgTextbox.Size = new System.Drawing.Size(310, 22);
            this.pkgTextbox.TabIndex = 5;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(50, 44);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(51, 13);
            this.locationLabel.TabIndex = 4;
            this.locationLabel.Text = "Location";
            // 
            // pkgNameLabel
            // 
            this.pkgNameLabel.AutoSize = true;
            this.pkgNameLabel.Location = new System.Drawing.Point(50, 16);
            this.pkgNameLabel.Name = "pkgNameLabel";
            this.pkgNameLabel.Size = new System.Drawing.Size(81, 13);
            this.pkgNameLabel.TabIndex = 3;
            this.pkgNameLabel.Text = "Package Name";
            // 
            // pkgType
            // 
            this.pkgType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pkgType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pkgType.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.pkgType.LargeImageList = this.newPackageImages;
            this.pkgType.Location = new System.Drawing.Point(12, 12);
            this.pkgType.Name = "pkgType";
            this.pkgType.Scrollable = false;
            this.pkgType.Size = new System.Drawing.Size(347, 142);
            this.pkgType.TabIndex = 1;
            this.pkgType.TileSize = new System.Drawing.Size(340, 34);
            this.pkgType.UseCompatibleStateImageBehavior = false;
            this.pkgType.View = System.Windows.Forms.View.Tile;
            this.pkgType.SelectedIndexChanged += new System.EventHandler(this.pkgType_SelectedIndexChanged);
            // 
            // newPackageImages
            // 
            this.newPackageImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("newPackageImages.ImageStream")));
            this.newPackageImages.TransparentColor = System.Drawing.Color.Transparent;
            this.newPackageImages.Images.SetKeyName(0, "Package_32x32.png");
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionPanel.Controls.Add(this.panel1);
            this.descriptionPanel.Controls.Add(this.descriptionSeparatorPanel);
            this.descriptionPanel.Controls.Add(this.pkgTypeDescription);
            this.descriptionPanel.Controls.Add(this.pkgTypeName);
            this.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.descriptionPanel.Location = new System.Drawing.Point(365, 0);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(200, 160);
            this.descriptionPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(1, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 1);
            this.panel1.TabIndex = 3;
            // 
            // descriptionSeparatorPanel
            // 
            this.descriptionSeparatorPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.descriptionSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.descriptionSeparatorPanel.Location = new System.Drawing.Point(0, 0);
            this.descriptionSeparatorPanel.Name = "descriptionSeparatorPanel";
            this.descriptionSeparatorPanel.Size = new System.Drawing.Size(1, 160);
            this.descriptionSeparatorPanel.TabIndex = 2;
            // 
            // pkgTypeDescription
            // 
            this.pkgTypeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pkgTypeDescription.Location = new System.Drawing.Point(3, 30);
            this.pkgTypeDescription.Name = "pkgTypeDescription";
            this.pkgTypeDescription.Size = new System.Drawing.Size(181, 124);
            this.pkgTypeDescription.TabIndex = 1;
            this.pkgTypeDescription.Text = "Creates a new compiled package project. This package type creates a single, binar" +
                "y file containing all of the package\'s resources.";
            // 
            // pkgTypeName
            // 
            this.pkgTypeName.AutoSize = true;
            this.pkgTypeName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgTypeName.Location = new System.Drawing.Point(4, 13);
            this.pkgTypeName.Name = "pkgTypeName";
            this.pkgTypeName.Size = new System.Drawing.Size(130, 13);
            this.pkgTypeName.TabIndex = 0;
            this.pkgTypeName.Text = "New Compiled Package";
            // 
            // packageTypeSeparatorPanel
            // 
            this.packageTypeSeparatorPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.packageTypeSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.packageTypeSeparatorPanel.Location = new System.Drawing.Point(0, 159);
            this.packageTypeSeparatorPanel.Name = "packageTypeSeparatorPanel";
            this.packageTypeSeparatorPanel.Size = new System.Drawing.Size(365, 1);
            this.packageTypeSeparatorPanel.TabIndex = 3;
            // 
            // NewPackageDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(565, 279);
            this.Controls.Add(this.packageTypeSeparatorPanel);
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.pkgType);
            this.Controls.Add(this.packageSettingsPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPackageDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Package";
            this.Load += new System.EventHandler(this.NewPackageDialog_Load);
            this.packageSettingsPanel.ResumeLayout(false);
            this.packageSettingsPanel.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel packageSettingsPanel;
        private System.Windows.Forms.TextBox pkgTextbox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label pkgNameLabel;
        private System.Windows.Forms.ListView pkgType;
        private System.Windows.Forms.ImageList newPackageImages;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Label pkgTypeName;
        private System.Windows.Forms.Label pkgTypeDescription;
        private System.Windows.Forms.Panel descriptionSeparatorPanel;
        private System.Windows.Forms.Panel packageTypeSeparatorPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox locationCombobox;

    }
}
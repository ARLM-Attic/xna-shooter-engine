using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Packager.Dialogs
{
    public partial class NewPackageDialog : Form
    {
        private string newCompiledDescription = "Creates a new compiled package project. This package type " +
            "creates a single, binary file containing all of the package's contents.";

        private string newOpenDescription = "Creates a new open package project. This package type creates " +
            "a free-standing folder containing the package structure and contents.";

        public NewPackageDialog()
        {
            InitializeComponent();

            Win32Api.ApplyEffectsToListView(pkgType);
        }

        private void NewPackageDialog_Load(object sender, EventArgs e)
        {
            // Select the default package type
            pkgType.Items[0].Selected = true;
        }

        private void pkgType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string ProjectName
        {
            get { return pkgTextbox.Text; }
        }

        public string ProjectLocation
        {
            get { return locationCombobox.Text; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Packager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region ToolStrip and Menu Items

        private void newPackageMenuItem_Click(object sender, EventArgs e)
        {
            // Create and open the new package dialog
            Dialogs.NewPackageDialog npd = new Dialogs.NewPackageDialog();

            DialogResult dr = npd.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Project.ProjectHelper helper = new Project.ProjectHelper();

                helper.ProjectCreated += new EventHandler(helper_ProjectCreated);

                helper.CreateNewProject(npd.ProjectName, npd.ProjectLocation, Project.PackageType.Compiled);
            }
        }

        void helper_ProjectCreated(object sender, EventArgs e)
        {
            UpdateStatus("Project Created");
        }

        private void BuildPackage_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void VerifyPackage_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region UI Threading

        private delegate void UpdateStatusDelegate(string Status);

        public void UpdateStatus(string Status)
        {
            if (!InvokeRequired)
            {
                statusLabel.Text = Status;
            }
            else
            {
                // Get on the right thread
                this.Invoke(new UpdateStatusDelegate(UpdateStatus), Status);
            }
        }

        #endregion

    }
}

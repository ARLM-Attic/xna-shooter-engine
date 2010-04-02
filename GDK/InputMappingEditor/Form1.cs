using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Engine.Input;
using System.Xml;

namespace InputMappingEditor
{
    public partial class Form1 : Form
    {
        // Defines whether or not to prevent updating any InputMappings
        private bool ProtectInputMappings;

        // Defines whether or not there are changes made that haven't been saved
        private bool UnsavedChanges;

        // The path of the open file. Null if it's a new/unsaved doc.
        private string CurrentFile;

        public Form1()
        {
            InitializeComponent();

            // Apply fancy Windows 7 styling to the inputList
            Win32Api.ApplyEffectsToListView(inputList);

            // Set the binding ComboBoxes to use their respective binding enum objects
            keyCombo.DataSource = Enum.GetNames(typeof(Microsoft.Xna.Framework.Input.Keys));
            mouseCombo.DataSource = Enum.GetNames(typeof(Engine.Input.MouseButtons));
            controllerCombo.DataSource = Enum.GetNames(typeof(Microsoft.Xna.Framework.Input.Buttons));

            // Allow updating of InputMappings
            ProtectInputMappings = false;
            UnsavedChanges = false;
            CurrentFile = null;
        }

        private void UpdateInputMapping()
        {
            // Update the InputMapping object and save it
            if(inputList.SelectedItems.Count > 0)
            {
                InputMapping map = (InputMapping)inputList.SelectedItems[0].Tag;

                map.Name = inputNameBox.Text;
                map.IsKeyboardBindingEnabled = keyEnable.Checked;
                map.IsControllerBindingEnabled = controllerEnable.Checked;
                map.IsMouseBindingEnabled = mouseEnable.Checked;

                map.KeyboardMapping = (Microsoft.Xna.Framework.Input.Keys)Enum.Parse(
                                typeof(Microsoft.Xna.Framework.Input.Keys),
                                keyCombo.SelectedItem.ToString());

                map.MouseMapping = (Engine.Input.MouseButtons)Enum.Parse(
                            typeof(Engine.Input.MouseButtons),
                            mouseCombo.SelectedItem.ToString());

                map.ControllerMapping = (Microsoft.Xna.Framework.Input.Buttons)Enum.Parse(
                                typeof(Microsoft.Xna.Framework.Input.Buttons),
                                controllerCombo.SelectedItem.ToString());

                inputList.SelectedItems[0].Tag = map;
                inputList.SelectedItems[0].Text = map.Name;

                // We've got unsaved changes!
                UnsavedChanges = true;
            }

            // Update UI elements
            keyComboLabel.Enabled = keyEnable.Checked;
            keyCombo.Enabled = keyEnable.Checked;

            mouseComboLabel.Enabled = mouseEnable.Checked;
            mouseCombo.Enabled = mouseEnable.Checked;

            controllerComboLabel.Enabled = controllerEnable.Checked;
            controllerCombo.Enabled = controllerEnable.Checked;
        }

        private void SaveInputMapping(string Path)
        {
            // Create a new XML document
            XmlDocument doc = new XmlDocument();

            // Create an <InputMappings> root tag
            XmlElement inputRoot = doc.CreateElement("InputMappings");

            foreach (ListViewItem inputItem in inputList.Items)
            {
                // Get our InputMapping object
                InputMapping map = (InputMapping)inputItem.Tag;

                // Create the necessary elements
                XmlElement inputElement = doc.CreateElement("InputMapping");

                XmlAttribute inputName = doc.CreateAttribute("Name");

                XmlElement inputKbEnabled = doc.CreateElement("IsKeyboardBindingEnabled");
                XmlElement inputMouseEnabled = doc.CreateElement("IsMouseBindingEnabled");
                XmlElement inputControllerEnabled = doc.CreateElement("IsControllerBindingEnabled");

                XmlElement inputKbBinding = doc.CreateElement("KeyboardBinding");
                XmlElement inputMouseBinding = doc.CreateElement("MouseBinding");
                XmlElement inputControllerBinding = doc.CreateElement("ControllerBinding");

                // Set the proper values
                inputName.Value = map.Name;
                inputElement.Attributes.Append(inputName); // Add the Name attribute

                inputKbEnabled.InnerText = map.IsKeyboardBindingEnabled.ToString();
                inputMouseEnabled.InnerText = map.IsMouseBindingEnabled.ToString();
                inputControllerEnabled.InnerText = map.IsControllerBindingEnabled.ToString();

                inputKbBinding.InnerText = map.KeyboardMapping.ToString();
                inputMouseBinding.InnerText = map.MouseMapping.ToString();
                inputControllerBinding.InnerText = map.ControllerMapping.ToString();

                // Add the elements together
                inputElement.AppendChild(inputKbEnabled);
                inputElement.AppendChild(inputMouseEnabled);
                inputElement.AppendChild(inputControllerEnabled);
                inputElement.AppendChild(inputKbBinding);
                inputElement.AppendChild(inputMouseBinding);
                inputElement.AppendChild(inputControllerBinding);

                // Add <InputMapping> tag to the root node
                inputRoot.AppendChild(inputElement);
            }

            // Add the root at the beginning of the document
            doc.AppendChild(inputRoot);

            // Save the document to disk
            doc.Save(Path);

            CurrentFile = Path;
            UpdateTitleBar();
        }

        public void OpenInputMapping(string Path)
        {
            inputList.Items.Clear();

            try
            {
                List<InputMapping> maps;
                maps = Engine.Input.InputManager.LoadInputMapping(Path);

                // Add the loaded InputMappings
                foreach (InputMapping map in maps)
                {
                    ListViewItem inputItem = new ListViewItem(map.Name);
                    inputItem.Tag = map;

                    inputList.Items.Add(inputItem);
                }

                CurrentFile = Path;
                UpdateTitleBar();
            }
            catch (Exception ex)
            {
                // An error occurred. Let the user know.
                MessageBox.Show("An error occurred opening the file. Please verify the file is an Input Mapping definition file.",
                    "Error Opening File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InputMapChanged(object sender, EventArgs e)
        {
            // Ensure we can't update the InputMappings if write protection is on
            if (!ProtectInputMappings)
            {
                UpdateInputMapping();
            }
        }

        private void inputList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // BUG FIX: This is to fix a bug where selected bindings would be
            //          applied to all input items, not just the selected one.
            //          The fix prevents any InputMapping updating from occuring
            //          while we're switching the editor between items.
            ProtectInputMappings = true; // Prevent updating of InputMappings

            if (inputList.SelectedItems.Count > 0)
            {
                
                InputMapping mapping = (InputMapping)inputList.SelectedItems[0].Tag;

                inputNameBox.Text = mapping.Name;

                keyEnable.Checked = mapping.IsKeyboardBindingEnabled;
                mouseEnable.Checked = mapping.IsMouseBindingEnabled;
                controllerEnable.Checked = mapping.IsControllerBindingEnabled;

                keyCombo.SelectedItem = Enum.GetName(
                                            typeof(Microsoft.Xna.Framework.Input.Keys),
                                            mapping.KeyboardMapping);

                mouseCombo.SelectedItem = Enum.GetName(
                                            typeof(Engine.Input.MouseButtons), mapping.MouseMapping);

                controllerCombo.SelectedItem = Enum.GetName(
                                            typeof(Microsoft.Xna.Framework.Input.Buttons), mapping.ControllerMapping);

                // Update UI elements
                keyComboLabel.Enabled = keyEnable.Checked;
                keyCombo.Enabled = keyEnable.Checked;

                mouseComboLabel.Enabled = mouseEnable.Checked;
                mouseCombo.Enabled = mouseEnable.Checked;

                controllerComboLabel.Enabled = controllerEnable.Checked;
                controllerCombo.Enabled = controllerEnable.Checked;
            }

            // Allow updating of InputMappings again since we're done switching items
            ProtectInputMappings = false;
        }

        private void addInputButton_Click(object sender, EventArgs e)
        {
            // Create an InputMapping object to attach to the ListViewItem
            InputMapping mapping = new InputMapping();

            // Create some default values for the input mapping
            mapping.Name = "New Input Definition";
            mapping.IsControllerBindingEnabled = false;
            mapping.IsKeyboardBindingEnabled = false;
            mapping.IsMouseBindingEnabled = false;
            mapping.KeyboardMapping = Microsoft.Xna.Framework.Input.Keys.W;
            mapping.MouseMapping = Engine.Input.MouseButtons.LeftButton;
            mapping.ControllerMapping = Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickUp;

            // Create a ListViewItem for the inputList
            ListViewItem inputItem = new ListViewItem(mapping.Name);
            inputItem.Tag = mapping; // Attach our InputMapping object

            // Add the item to the inputList
            inputList.Items.Add(inputItem);
        }

        private void inputList_SizeChanged(object sender, EventArgs e)
        {
            inputList.Columns[0].Width = inputList.Width;
        }

        #region Menu Items

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            // Show the save dialog if the file hasn't been saved yet
            if (CurrentFile == null)
            {
                DialogResult dr = saveFileDialog.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    SaveInputMapping(saveFileDialog.FileName);
                }
            }
            else
            {
                // Save to our existing CurrentFile path
                SaveInputMapping(CurrentFile);
            }
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                SaveInputMapping(saveFileDialog.FileName);
            }
        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            if (UnsavedChanges)
            {
                DialogResult dr = MessageBox.Show(
                        "There are unsaved changes. Would you like to save the file before exiting?", "Unsaved Changes",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    saveMenuItem_Click(this, new EventArgs());
                }
            }

            inputList.Items.Clear();
            CurrentFile = null;

            UpdateTitleBar();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            if (UnsavedChanges)
            {
                DialogResult dr = MessageBox.Show(
                        "There are unsaved changes. Would you like to save the file before exiting?", "Unsaved Changes",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    saveMenuItem_Click(this, new EventArgs());
                }
            }

            DialogResult openDialogResult = openFileDialog.ShowDialog();

            if (openDialogResult == System.Windows.Forms.DialogResult.OK)
            {
                OpenInputMapping(openFileDialog.FileName);
            }
        }

        private void validateInputMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Validate the InputMappings to ensure there are no conflicts

            // Not yet implemented.
            throw new NotImplementedException();
        }

        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UnsavedChanges)
            {
                DialogResult dr = MessageBox.Show(
                        "There are unsaved changes. Would you like to save the file before exiting?", "Unsaved Changes",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    saveMenuItem_Click(this, new EventArgs());
                }
            }
        }

        private void UpdateTitleBar()
        {
            if (CurrentFile != null)
            {
                string[] pathArgs = CurrentFile.Split('\\');

                this.Text = pathArgs[pathArgs.Count() - 1] + " - Input Mapping Editor";
            }
            else
            {
                this.Text = "Untitled - Input Mapping Editor";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();

            if ((args.Count() > 1) && (args[1].EndsWith(".input")))
            {
                OpenInputMapping(args[1]);
            }
        }
    }
}

/*
    Program Name: MultiTexteditor.cs
    Author: Irina Nazarova
    Date: Apr 15, 2021
    Description: This application combines several forms into 1 mdi form

 
 */


using Lab3;
using Lab4;
using Lab5;
using CE1;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectForNETD
{
    public partial class formMain : Form
    {

        public formMain()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// This event will open formAverageUnits
        /// </summary>
        private void openAverageUnitsWindowsMenuClick(object sender, EventArgs e)
        {
            // create formUnitsShipped object
            formUnitsShipped unitsForm = formUnitsShipped.Instance;

            // It is a child of the main form
            unitsForm.MdiParent = this;

            // Show the form
            unitsForm.Show();
            // Set focus to it
            unitsForm.Focus();
        }

        /// <summary>
        /// This event will open formCarInventory
        /// </summary>
        private void openCarListWindowsMenuClick(object sender, EventArgs e)
        {
            // create formCarInventory object
            formCarInventory carForm = formCarInventory.Instance;
            // It is a child of a main form
            carForm.MdiParent = this;

            // Show the form
            carForm.Show();
            // Set focus to it
            carForm.Focus();
        }


        /// <summary>
        /// This event will open new text editor window
        /// </summary>
        private void newFileMenuClick(object sender, EventArgs e)
        {
            // create formTextEditor object
            formTextEditor textForm = new formTextEditor();
            // It is a child of a main form
            textForm.MdiParent = this;

            // Show text editor
            textForm.Show();
            // Set focus to it
            textForm.Focus();
        }

        /// <summary>
        /// This event will open a help window
        /// </summary>
        private void aboutHelpMenuClick(object sender, EventArgs e)
        {
            // Display info about the assignment in a message box
            MessageBox.Show("\n\n\tThe Final Project\t\n\tIrina Nazarova\t\n\n", "Info");
        }

        /// <summary>
        /// this even will determine which window is focused and close it
        /// </summary>
        private void closeFileMenuClick(object sender, EventArgs e)
        {
            // determine which form is active
            Form activeChild = this.ActiveMdiChild;

            // If nothing is active: 
            if (activeChild == null)
            {
                // Error message displayed
                MessageBox.Show("No application can be closed", "Error");
            }
            // If there is an active window
            else
            {
                // Close it
                activeChild.Close();
            }

            
            
        }


        /// <summary>
        /// If a text editor is focused, save the file
        /// </summary>
        private void saveFileMenuClick(object sender, EventArgs e)
        {
            // Try to do the following steps: 
            try
            {
                // Determine which form is active
                Form activeForm = this.ActiveMdiChild;
                // if there is an active form:
                if (activeForm != null)
                {
                    // convert it to editor type
                    formTextEditor editor = (formTextEditor)activeForm;
                    // Call menuFileSaveClick event from Lab5 namespace
                    editor.menuFileSaveClick(sender, e);
                }
                // If there is no form in focus:
                else
                {
                    // Error message is displayed
                    MessageBox.Show("Text Editor must be opened!", "Error");
                }
            }
            // If conversion to text editor failed: 
            catch
            {
                // Error message is displayed
                MessageBox.Show("Text Editor must be active", "Error");
            }

        }

 
  

        /// <summary>
        /// This event will display all forms in cascade view
        /// </summary>
        private void cascadeWindowMenuClick(object sender, EventArgs e)
        {
            // Cascade view
            this.LayoutMdi(MdiLayout.Cascade);
        }

        /// <summary>
        /// This event will display all forms in tile vertical view
        /// </summary>
        private void tileVerticalWindowsMenuClick(object sender, EventArgs e)
        {
            // Tile Vertical view
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        /// <summary>
        /// This event will display all forms in tile horizontal view
        /// </summary>
        private void tileHorizontalWindowsMenuClick(object sender, EventArgs e)
        {
            // Tile Horizontal view
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }


        /// <summary>
        /// Thius event will determine of the focused form is editor.
        /// If it is, the file will be saved to the chosen directory
        /// </summary>
        private void saveAsFileMenuClick(object sender, EventArgs e)
        {
            // try to do the following steps: 
            try
            {
                // Determine which form is active
                Form activeForm = this.ActiveMdiChild;
                // if there is a form in focus: 
                if (activeForm != null)
                {
                    // try to convert it to formTextEditor object
                    formTextEditor editor = (formTextEditor)activeForm;
                    // Call menyFileSaveAsClick from namespace Lab5
                    editor.menuFileSaveAsClick(sender, e);
                }
                // If there is no active form: 
                else
                {
                    // Display error message
                    MessageBox.Show("Text Editor must be opened!", "Error");
                }
            }
            // If conversion fails:
            catch
            {
                // Display error message
                MessageBox.Show("Text Editor must be active", "Error");
            }
        }


        /// <summary>
        /// this event will open text editor in the main form
        /// </summary>
        private void openFileMenuClick(object sender, EventArgs e)
        {
            // Create fromTextEditor object
            formTextEditor textForm = new formTextEditor();
            
            // Call menuFileOpenClick event from namespace Lab5
            textForm.menuFileOpenClick(sender, e);
            // This object is a child of a main form
            textForm.MdiParent = this;

            // Show the form
            textForm.Show();
            // Set focus to it
            textForm.Focus();

        }


        /// <summary>
        /// This event will open the form with a secret information about you 
        /// </summary>
        private void youKnowWhatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create formAwesomeness object
            formAwesomeness aForm = formAwesomeness.Instance;

            // It is a main form's child
            aForm.MdiParent = this;

            // Show the form
            aForm.Show();
            // Set focus to it
            aForm.Focus();

        }


        /// <summary>
        /// This event will cut text from text editor 
        /// </summary>
        private void cutEditMenuClick(object sender, EventArgs e)
        {
            // try to complete the following steps:
            try
            {
                // determine which form is active
                Form activeForm = this.ActiveMdiChild;
                // If there is an active form: 
                if (activeForm != null)
                {
                    // convert it to form text editor
                    formTextEditor editor = (formTextEditor)activeForm;
                    // Call menuEditCutClick from Lab5 namespace
                    editor.menuEditCutClick(sender, e);
                }
                // If there is nothing in focus: 
                else
                {
                    // Error message will be displayed
                    MessageBox.Show("Text Editor must be opened!", "Error");
                }
            }
            // If conversion fails: 
            catch
            {
                // Error message
                MessageBox.Show("Text Editor must be active", "Error");
            }

        }


        /// <summary>
        /// This event will coopy selected text
        /// </summary>
        private void copyEditMenuClick(object sender, EventArgs e)
        {
            // Try to do the following steps:
            try
            {
                // Determine which form is active
                Form activeForm = this.ActiveMdiChild;
                // If there is smth in focus:
                if (activeForm != null)
                {
                    // Convert active form to text editor
                    formTextEditor editor = (formTextEditor)activeForm;
                    // Call menuEditCopyClick from namespace Lab5
                    editor.menuEditCopyClick(sender, e);
                }
                // If there are no active forms
                else
                {
                    // Error message
                    MessageBox.Show("Text Editor must be opened!", "Error");
                }
            }
            // If conversion fails:
            catch
            {
                // Error message
                MessageBox.Show("Text Editor must be active", "Error");
            }
        }

        /// <summary>
        /// this event will paste the text from the clipboard
        /// </summary>
        private void pasteEditMenu_Click(object sender, EventArgs e)
        {
            // Try to do the following steps:
            try
            {
                // Determine which form is active
                Form activeForm = this.ActiveMdiChild;
                // If there is smth in focus:
                if (activeForm != null)
                {
                    // Convert active form to text editor
                    formTextEditor editor = (formTextEditor)activeForm;
                    // Call menuEditPasteClick from namespace Lab5
                    editor.menuEditPasteClick(sender, e);
                }
                // If there are no active forms
                else
                {
                    // Error message
                    MessageBox.Show("Text Editor must be opened!", "Error");
                }
            }
            // If conversion fails: 
            catch
            {
                // Error message
                MessageBox.Show("Text Editor must be active", "Error");
            }
        }

        /// <summary>
        /// This event will close the main form
        /// </summary>
        private void exitFileMenuClick(object sender, EventArgs e)
        {
            // Close the main form
            this.Close();
        }


  
        /// <summary>
        /// New button on the tool strip will open a new Text editor
        /// </summary>
        private void newToolStripButtonClick(object sender, EventArgs e)
        {
            // create new editor
            newFileMenuClick(sender, e);
        }


        /// <summary>
        /// Open button on the tool strip will open an existing Text editor
        /// </summary>
        private void openToolStripButtonClick(object sender, EventArgs e)
        {
            // open text editor
            openFileMenuClick(sender, e);
        }


        /// <summary>
        /// save button on the tool strip will Save the file to the particular location
        /// </summary>
        private void saveToolStripButtonClick(object sender, EventArgs e)
        {
            // Save File
            saveFileMenuClick(sender, e);
        }
    }
}

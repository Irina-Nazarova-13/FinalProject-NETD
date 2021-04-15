//Program Name: Awesomeness.cs
//Author: Irina Nazarova
//Date: Jan 13, 2021
//Last Modified: Apr 15, 2021
//Description: Window with the question if you are awesome appears as well 
//              as two options 'Yes' or 'No'. If you hover over 'No' button
//              it moves to the right so that nobody could click it. If you clcik 
//              yes the program shows you a confirmation window


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CE1
{
    public partial class formAwesomeness : Form
    {
        public formAwesomeness()
        {
            InitializeComponent();
        }

        // Create static field of formAwesomeness type
        public static formAwesomeness instance;

        /// <summary>
        /// The Left 'No' button disappears when you hover over it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNoLeft_Click(object sender, EventArgs e)
        {
            //Make the Left 'No' button invisible when the mouse enteres this button
            buttonNoLeft.Visible = false;

            //Make the Right 'No' button visible when the mouse enter the Left 'No' button
            buttonNoRight.Visible = true;

        }

        /// <summary>
        /// When 'Yes' button is clicked the confirmation window appears, then application is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonYes_Click(object sender, EventArgs e)
        {
            //Open the Message box to confirm that you're awesome
            MessageBox.Show("Yes, you are awesome!");

            //Close the Message Box
            Close();
        }

        /// <summary>
        /// The Right 'No' button disappears when you hover over it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNoRight_Click(object sender, EventArgs e)
        {
            //Make the Right 'No' button invisible when the mouse enetrs this button
            buttonNoRight.Visible = false;

            //Make the Left 'No' button visible when the mouse enteres the Rigth 'No' button
            buttonNoLeft.Visible = true;
        }


        /// <summary>
        /// Instance property return instance of the awesomeness form
        /// </summary>
        public static formAwesomeness Instance
        {
            // read-only
            get
            {
                // if there is no awesomeness form:
                if (instance == null)
                {
                    // Create new instance
                    instance = new formAwesomeness();

                }
                // return instance
                return instance;
            }
        }
    }
}

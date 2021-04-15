/*  Program Name: formCarInventory.cs
 *  Author: Irina Nazarova
 *  Date: Mar 12, 2021
 *  Last Modified: Apr 15, 2021 
 *  Description: This form application will let the user to enter the car manufacturer, its model, price,
 *               the year it was made, and whether this car is new. The application will validate the entered data
 *               and let the user know if the data was not valid. If the values fit criteria, the program will
 *               display the data in the list view.
  
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class formCarInventory : Form
    {


        // DECLARATIONS

        // Declare the constant that will hold the minimum value for the price.
        const decimal MINIMUM_PRICE = 0;
        // Declare a list of objects that will hold car objects
        private List<Car> carList = new List<Car>();

        // Set variable id to -1. This variable is used to check wether the car is selected
        int id = -1;

        // Create instance field
        private static formCarInventory instance;


        public formCarInventory()
        {
            InitializeComponent();
        }




        /// <summary>
        /// Button Close closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Close the Form
            this.Close();
        }



        /// <summary>
        ///  When you click Submit button, the datat entered is processed.
        ///  If it is valid, the info about the car is added to the listView,
        ///  and a short description is displayed in the richBoxMessage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            // Declare the variable year
            int year;

            // Clear the richTextBoxNessage
            richTextBoxMessage.Clear();

            // If the data is valid, continue processing  
            if (Validation())
            {
                // Declare the variable price
                decimal price;
                // Store the value of price in the variable price
                Decimal.TryParse(textBoxPrice.Text, out price);

                
                // Store the value of year in the year variable
                Int32.TryParse(comboBoxYear.Text, out year);

                // If the car is selected (if the car selected, then id would not be -1):
                if (id == -1)
                {
                    // Create a new object of the class Car and add it to the list of cars
                    carList.Add(new Car(comboBoxMake.Text, textBoxModel.Text, year, price, checkBoxNew.Checked));
                }
                // If there is a car selected:
                else
                {
                    // Get data from the input controls and make them attributes to an existing car
                    carList[id - 1].CarID = id;
                    carList[id - 1].CarMake = comboBoxMake.Text;
                    carList[id - 1].CarModel = textBoxModel.Text;
                    carList[id - 1].CarYear = year;
                    carList[id - 1].CarPrice = price;
                    carList[id - 1].IsNew = checkBoxNew.Checked;
                }

                // Set id variable to the initial value
                id = -1;
                // Empty the listViewOutput in order to input the values later on from scratch 
                listViewOutput.Items.Clear();
                // Call the function DisplayCars() in order to fill listView with car info
                DisplayCars();
                // Call the function ClearInput to clear all the input fields.
                ClearInput();

            }
        }


        /// <summary>
        /// DisplayCars() function display th einfo about each car in listViewOutput
        /// </summary>
        private void DisplayCars()
        {

            // Go through each object in carList
            for (int counter = 0; counter < carList.Count; counter++)
            {
                // Create a new item called item
                ListViewItem item = new ListViewItem();

                // This is a checkbox. The item is checked if the car is new
                item.Checked = carList[counter].IsNew;

                // Create subitem of a car ID
                item.SubItems.Add(carList[counter].CarID.ToString());
                // Create subitem of a car manufacturer
                item.SubItems.Add(carList[counter].CarMake);
                // Create subitem of a car model
                item.SubItems.Add(carList[counter].CarModel);
                // Create subitem ofa year the car was made
                item.SubItems.Add(carList[counter].CarYear.ToString());
                // Create subitem of a price of the car
                item.SubItems.Add("$" + carList[counter].CarPrice.ToString());

                // Create a tag for object Car
                item.Tag = carList[counter];


                // Add the item to the listView
                listViewOutput.Items.Add(item);

            }



        }


        /// <summary>
        /// Validation() function will validate ecch input field. 
        /// If teh data is invalid, an error message will be displayed. 
        /// If data fits the conditions, the function will return true
        /// </summary>
        /// <returns></returns>
        private bool Validation()
        {
            // If there is nothing in the comboBoxMake: 
            if (comboBoxMake.Text == "")
            {
                // Display an error message and return false
                labelError.Text = "Please choose car manufacturer";
                return false;

            }
            // If there is data in the comboBox: 
            else
            {
                // If there is nothing in the textBoxModel: 
                if (textBoxModel.Text == "")
                {
                    // Display an error message and return false
                    labelError.Text = "Please enter the model of the car";
                    return false;
                }
                // If there is data in the comboBoxYear: 
                else
                {
                    // If there is nothing in the comboBoxYear: 
                    if (comboBoxYear.Text == "")
                    {
                        // Display an error message and return false
                        labelError.Text = "Choose the Year";
                        return false;
                    }
                    // If there is data in the textBoxYear: 
                    else
                    {
                        // If there is nothing in the textBoxPrice: 
                        if (textBoxPrice.Text == "")
                        {
                            // Display an error message and return false
                            labelError.Text = "Please enter the price of a car";
                            return false;
                        }
                        // If there is something in the textBoxPrice: 
                        else
                        {
                            // Declare the variable value, to hold the value of price, if it does not fail the casting
                            decimal value;
                            // If the entered price is not numerical: 
                            if (!Decimal.TryParse(textBoxPrice.Text, out value))
                            {
                                // Display an error message and return false
                                labelError.Text = "The price must be a numeric value";
                                return false;
                            }
                            // If the entered price is a number: 
                            else
                            {
                                // Check if the number lies in the appropriate range: 
                                if (value >= MINIMUM_PRICE)
                                {
                                    // If the price value variable is positive or 0, return true
                                    return true;
                                }
                                // If the value is negative: 
                                else
                                {
                                    // Display an error message and return false
                                    labelError.Text = "The price must not be less than 0";
                                    return false;
                                }
                            }

                        }
                    }
                }

            }

        }


        /// <summary>
        /// ClearInput() function clears the input fields and error label
        /// </summary>
        private void ClearInput()
        {
            // Let the comboBoxMake display nothing
            comboBoxMake.SelectedIndex = -1;
            // Let the textBoxModel display nothing
            textBoxModel.Text = "";
            // Let the comboBoxYear display nothing
            comboBoxYear.SelectedIndex = -1;
            // Let the textBoxPrice display nothing
            textBoxPrice.Text = "";
            // Uncheck the checkbox
            checkBoxNew.Checked = false;
            // Clear the error label
            labelError.Text = "";
        }

        /// <summary>
        /// If the Reset button is clicked, the form sets to the default state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Call ClearInput function to clear the input
            ClearInput();
            // Clear the carList
            carList.Clear();
            // Set carCounter Car Class attribute to 0
            Car.ResetCarCounter();
            // Clear the items in the listView
            listViewOutput.Items.Clear();
            // Clear the discription of the last entered car
            richTextBoxMessage.Text = "";
        }

        private void CarChosen(object sender, EventArgs e)
        {
            // Avoid error
            try
            {
                // Determine which item was selected, use the Tag
                var item = (Car)listViewOutput.SelectedItems[0].Tag;
                
                // If there is an item selected: 
                if (item != null)
                {
                    // Display the car's data in the input fields
                    comboBoxMake.Text = item.CarMake;
                    textBoxModel.Text = item.CarModel;
                    comboBoxYear.Text = item.CarYear.ToString();
                    textBoxPrice.Text = item.CarPrice.ToString();
                    checkBoxNew.Checked = item.IsNew;

                    // Set id varibale to the ID of selected car
                    id = item.CarID;

                    // Display a short description of the car. The last (latest entered) car's data will stay in the textBox
                    richTextBoxMessage.Text = item.GetCarData();
                }

            }
            // Ignore error
            catch
            {
                
            }
            
        }


        /// <summary>
        /// Instance property returns the object of formCarInventory class
        /// </summary>
        public static formCarInventory Instance
        {
            // read-only
            get
            {
                // If there are no instances:
                if (instance == null)
                {
                    // create an instance
                    instance = new formCarInventory();
          
                }
                // Return instance
                return instance;
            }
        }


    }
}

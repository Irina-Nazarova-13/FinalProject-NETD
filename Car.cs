/*  Program Name: Car.cs
 *  Author: Irina Nazarova
 *  Date: Mar 12, 2021
 *  Description: This is a program for the class Car
  
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    // Declare the Car class
    class Car
    {
        // Declare class fields

        // carCounter is a static variable representing the number of Car objects
        private static int carCounter = 0;
        // carID variable hold the ID of a particular Car object
        private int carID = 0;
        // carMake variable hold the manufacturer of a particular Car object
        private string carMake = "";
        // carModel variable hold the model of a particular Car object
        private string carModel;
        // carYear variable hold the year when a particular car was created
        private int carYear = 0;
        // carPrice variable hold the price of a particular Car object
        private decimal carPrice = 0;
        // isNew variable indicates whether the car is new or not
        private bool isNew = false;

        /// <summary>
        ///  ResetCarCounter static method resets the carCounter variable when the form is reset
        /// </summary>
        public static void ResetCarCounter()
        {
            // Set carCounter variable to 0
            carCounter = 0;
        }
   

        /// <summary>
        /// This is a default construictor. When the object is created,
        /// the ID is assigned to it
        /// </summary>
        public Car()
        {
            // The number of cars is incremented by 1
            carCounter += 1;
            // ID is created for a created car
            carID = carCounter;
        }
            
        /// <summary>
        /// This is a custom constructor, it takes values for make, model, year price and new status
        /// and assigns those values to the corresponding object fields 
        /// This constructor calls the default constructor when the object is created
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="price"></param>
        /// <param name="newStatus"></param>
        public Car(string make, string model, int year, decimal price, bool newStatus):this()
        {
            carMake = make;
            carModel = model;
            carYear = year;
            carPrice = price;
            isNew = newStatus;
        }

        /// <summary>
        /// CarMake property is a property that returns and sets the car's manufacturer
        /// </summary>
        public string CarMake
        {
            get{ return carMake; }
            set { carMake = value; }
        }


        /// <summary>
        /// CarModel property is a property that returns and sets the car's model
        /// </summary>
        public string CarModel
        {
            get { return carModel; }
            set { carModel = value; }
        }


        /// <summary>
        /// CarYear property is a property that returns and sets the year the car was made
        /// </summary>
        public int CarYear
        {
            get { return carYear; }
            set { carYear = value; }
        }

        /// <summary>
        /// CarPrice property is a property that returns and sets the car's price
        /// </summary>
        public decimal CarPrice
        {
            get { return carPrice; }
            set { carPrice = value; }
        }

        /// <summary>
        /// IsNew property is a property that returns and sets the car's new status
        /// </summary>
        public bool IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }

        /// <summary>
        /// CarID property is  a property that returns and sets the car's ID
        /// </summary>
        public int CarID
        {
            get { return carID; }
            set { carID = value; }
        }

        /// <summary>
        /// GetCarData method returns a string variable that contains the description of a car
        /// </summary>
        /// <returns></returns>
        public string GetCarData()
        {
            return "The car's manufacturer is " + carMake.ToString() + 
                    ". The model of the car is " + carModel.ToString() +
                    ". The year of manufacturing is " + carYear.ToString() + 
                    ". The car costs " + carPrice.ToString() + " dollars" +
                    (isNew ? ". It is a new car!" : ". It is an old car");
        }
    }
}

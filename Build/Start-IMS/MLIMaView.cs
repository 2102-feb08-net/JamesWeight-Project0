using System;
using Controller;

namespace View
{   
    // MVC - Model for View Concept
    // ==========
    // Separation of Concerns
    // SOLID - Single Responsibility Principle
    public class ViewRoutines
    {
        private string _data = "Welcome to the MLiMa Order Center";
        // Screen to User
        public void MenuInterface()
        {   
            // Screen of Tasks
            Console.WriteLine
            ( new String('=', _data.Length) + (char)13 + (char)10
              + _data + (char)13 + (char)10
              + new String('=', _data.Length) + (char)13 + (char)10
              + "Choose your task..." + (char)13 + (char)10
              + (char)13 + (char)10              
              + "1) Order" + (char)13 + (char)10
              + "2) Add Customer" + (char)13 + (char)10
              + "3) Search Customers by Name" + (char)13 + (char)10
              + "4) Display Details of an Order" + (char)13 + (char)10              
              + "5) Display All Order History of a Store" + (char)13 + (char)10 
              + "6) Display Details of an Order" + (char)13 + (char)10 
              + "7) Display Details of a Customer" + (char)13 + (char)10
              + new String('=', _data.Length) + (char)13 + (char)10
            );
            // Wait for User Selection
            string UserSelection = Console.ReadLine();
            if (UserSelection.Length == 1)
            {
                ControllerRoutines _instantiateView = new ControllerRoutines();
                _instantiateView.Selection(UserSelection);
            }else{
                Console.WriteLine("Only a Digit Number is Accepted...");
                // 
                ViewRoutines _instantiateView = new ViewRoutines();
                _instantiateView.MenuInterface();
            }
        }
        // Structural Integrity Test
        public void Display()
        {
            Console.WriteLine("TDD-StructuralIntegrityView");
        }
    }
}

// Revature Intellectual Property and Resource:
//  Batch -> 2102-feb08-net
//
//  Project0 - Feb 12, 2021 Received Original Specifications
//           - Feb 18, 2021 Received Requested Specifications
//           - Feb 24, 2021 Requested Deliverable
//
//  Project Lead - Revature Corporate Trainor Nick Escalon
//  Project Deliverable - Developer & Author -
//                        Revature Engineering Associate James Weight
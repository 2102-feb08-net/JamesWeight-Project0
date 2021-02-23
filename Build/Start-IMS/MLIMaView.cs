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
        public void MenuInterface(int MenuLogic)
        {   
            // Screen of Tasks
            if (MenuLogic == 0){
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
                  + "5) Display History of Oders at a Store" + (char)13 + (char)10 
                  + "6) Display Details of an Order" + (char)13 + (char)10 
                  + "7) Display Details of a Customer" + (char)13 + (char)10
                  + "8) Exit" + (char)13 + (char)10
                  + new String('=', _data.Length) + (char)13 + (char)10
                );
            }
            // Wait for User Selection
            string UserSelection = Console.ReadLine();
            // Exception Handling -1 as NULL: Allocated and Not Used as Empty or Nothing,
            //                     0 as Accepted
            // 'Try' Logic
            int MessageType = -1;
            if (UserSelection.Length == 1)
            {
                MessageType = 0;
                if (UserSelection != "1" &&
                    UserSelection != "2" &&
                    UserSelection != "3" &&
                    UserSelection != "4" &&
                    UserSelection != "5" &&
                    UserSelection != "6" &&
                    UserSelection != "7" &&
                    UserSelection != "8") MessageType = 2;
            }else{
                MessageType = 1;
            }
            // 'Catch' Logic
            if (MessageType == 1) Console.WriteLine("Only a Digit is Accepted...");
            if (MessageType == 2) Console.WriteLine("An input of 1 through 8 is Needed...");
            // if Accepted
            if (MessageType == 0){
                ControllerRoutines _instantiateLogic = new ControllerRoutines();
                _instantiateLogic.Selection(UserSelection);
            }
            // 'Finally' Logic of Try-Catch with Screen Update
            if (UserSelection == "8")
            {
                int ExitCode = 0;
                System.Environment.Exit(ExitCode);
            }else{
                ViewRoutines _instantiateView = new ViewRoutines();
                _instantiateView.MenuInterface(int.Parse(UserSelection));
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
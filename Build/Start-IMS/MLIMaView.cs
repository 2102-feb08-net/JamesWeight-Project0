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
        // Data utilized by Methods
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
                  + (char)13 + (char)10              
                  + "Choose your task..." + (char)13 + (char)10
                  + (char)13 + (char)10              
                  + "1) Order" + (char)13 + (char)10
                  + "2) Add Customer" + (char)13 + (char)10
                  + "3) Search Customers by Name" + (char)13 + (char)10
                  + "4) Display Details of an Order" + (char)13 + (char)10              
                  + "5) Display History of Orders at a Store" + (char)13 + (char)10 
                  + "6) Display History of a Customer" + (char)13 + (char)10
                  + new String('=', _data.Length) + (char)13 + (char)10
                  + "A) Serialize Data" + (char)13 + (char)10
                  + "B) DeSerialize Data" + (char)13 + (char)10
                  + "C) Retrieve SQL" + (char)13 + (char)10
                  + new String('=', _data.Length) + (char)13 + (char)10
                  + "0) Exit" + (char)13 + (char)10
                  + new String('-', _data.Length) + (char)13 + (char)10
                );
            }
            // Timing Asynchronous Loop
            do
            {
                int KeyPress = Console.Read();
                try
                {
                    MenuLogic = KeyPress;
                }
                catch
                {
                    MenuLogic = KeyPress;
                }   
            }
            while (MenuLogic == 0);
            // if Key Pressed
            bool Selection = false;
            if (MenuLogic >= 48 && MenuLogic <= 55) Selection = true;
            if (MenuLogic >= 65 && MenuLogic <= 67) Selection = true;
            // Decision Flow as Asynchronous
            if (Selection)
            {
                // Transfer
                ControllerRoutines _instantiateLogic = new ControllerRoutines();
                _instantiateLogic.Selection(MenuLogic);
            }else{
                // Transfer 
                ViewRoutines _instantiateView = new ViewRoutines();
                _instantiateView.MenuInterface(0);
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
using System;
using DB;
using View;

namespace Controller
{
    // MVC - Model for Controller Concept
    // ===========
    // Separation of Concerns
    // SOLID - Single Responsibility Principle
    public class ControllerRoutines
    {
        // Data utilized by Methods
        private string _data = String.Empty;
        // Handler for User Selection via View
        public void Selection(int Character)
        {
            // Retrieve Data for Utilization
               DBroutines _instantiateData = new DBroutines();
                string _data = _instantiateData.ReadData(Character);
            // Switch - Case Selection
            switch(Character)
            {
                case 49:
                    // Console.WriteLine(Character); // Unit Test
                    break;
                case 50:
                    // Console.WriteLine(Character); // Unit Test
                    break;
                case 51:
                   // Console.WriteLine(Character); // Unit Test
                    break;
                case 52:
                    // Console.WriteLine(Character); // Unit Test
                    break;
                case 53:
                    // Console.WriteLine(Character); // Unit Test
                    break;
                case 54:
                    // Console.WriteLine(Character); // Unit Test
                    break;
                case 48:
                    // Messaging Declaration to Close Applicational Program
                    Console.WriteLine("Shutting Down Program and Closing Application...");
                    System.Environment.Exit(0);
                    break;
                case 65:
                    // Console.WriteLine("Being Developed"); // Unit Test
                    break;
                case 66:
                    // Console.WriteLine("Being Developed"); // Unit Test
                    break;
                case 67:
                    // Console.WriteLine("Being Developed"); // Unit Test
                    break;
                default:
                    // Exception Handling
                    Console.WriteLine("Exception...");
                break;
            }
            // Transfer 
            ViewRoutines _instantiateView = new ViewRoutines();
            _instantiateView.MenuInterface(0);
        }
        // Structural Integrity Test
        public void Display()
        {
            Console.WriteLine("TDD-StructuralIntegrityController");
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
using System;

namespace Controller
{
    // MVC - Model for Controller Concept
    // ===========
    // Separation of Concerns
    // SOLID - Single Responsibility Principle
    public class ControllerRoutines
    {
        // Handler for User Selection via View
        public void Selection(string character)
        {
            Console.WriteLine(character);
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
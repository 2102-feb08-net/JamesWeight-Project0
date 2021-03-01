using System;

namespace OrderLibrary
{
    interface IInterface
    {
        void BusinessLogic();
    }

    internal class Routines : IInterface
    {
        private int ID { get; set; }  // Primary Key

        private int CustomerID { get; set; } // Foreign Key
        private int StoreID { get; set; } // Foreign Key
        private int ProductID { get; set; } // Foreign Key

        private int DealsPercentageReduction { get; set; } // Special Deal
        private int DealsAmountReduction { get; set; } // Special Deal

        private string Record { get; set; } // Date Time Offset UTC

        public void BusinessLogic()
        {
            // New Line
            Console.WriteLine(" ");
            // Message to User
            Console.WriteLine("Validation on Orders."); // SI - TDD
        }
    }
}

// Revature Intellectual Property and Resource:
//  Batch -> 2102-feb08-net
//
//  Project0 - Feb 12, 2021 Received Original Specifications
//           - Feb 18, 2021 Received Requested Specifications
//           - Feb 24, 2021 Requested Deliverable
//           - Mar 1, 2021  Deliverable
//
//  Project Lead - Revature Corporate Trainor Nick Escalona
//  Project Deliverable - Developer & Author -
//                        Revature Engineering Associate James Weight
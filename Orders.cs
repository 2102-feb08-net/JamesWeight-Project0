using System;

namespace OrderLibrary
{
    internal class Routines
    {
        private int ID { get; set; }  // Primary Key
        private int CustomerID { get; set; } // Foreign Key
        private int StoreID { get; set; } // Foreign Key

        internal void Interface(){
            Console.WriteLine("Orders.");
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
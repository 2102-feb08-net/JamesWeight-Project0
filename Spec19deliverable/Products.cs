/* using System;

namespace ProductLibrary
{
    interface IInterface
    {
        void InterfaceBusinessLogic(int[] ID, int[] LocationID, int[] Price, int[] Quantity, string[] Name, string[] Description);
    }

    internal class Routines : IInterface
    {
        private int[] ID { get; set; }  // Primary Key

        private int[] LocationID { get; set; }  // Zipcode of Store
        private int[] Price { get; set; }  // In U.S. Dollars
        private int[] Quantity { get; set; }  // In Stock at LocationID

        private string[] Name { get; set; }    // VarChar(100)
        private string[] Description { get; set; } // VarChar(300)

        public void InterfaceBusinessLogic(int[] ID, int[] LocationID, int[] Price, int[] Quantity, string[] Name, string[] Description){
            // Console.WriteLine("Products."); // SI - TDD
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
//                        Revature Engineering Associate James Weight */
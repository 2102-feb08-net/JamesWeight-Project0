/* using System;

namespace LocationLibrary
{
    interface IInterface
    {
        void InterfaceBusinessLogic(int[] ID, long[] Phone, string[] Name, string[] Address, string[] eMail);
    }

    internal class Routines : IInterface
    {
        private int[] ID { get; set; }         // Primary Key

        private long[] Phone { get; set; }     // 12 Digit Internation Code

        private string[] Name { get; set; }    // VarChar(100)
        private string[] Address { get; set; } // VarChar(300)
        private string[] eMail { get; set; }   // VarChar(100)

        public void InterfaceBusinessLogic(int[] ID, long[] Phone, string[] Name, string[] Address, string[] eMail){
            // Console.WriteLine("Locations."); // SI - TDD
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
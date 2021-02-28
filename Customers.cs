using System;

namespace CustomerLibrary
{
    interface IInterface
    {
        void InterfaceBusinessLogic();
    }

    internal class Routines : IInterface
    {
        private int ID { get; set; }         // Primary Key

        private long Phone { get; set; }     // 12 Digit Internation Code
        private int HomeStore { get; set; }  // Integer

        private string Name { get; set; }    // VarChar(100)
        private string Address { get; set; } // VarChar(300)
        private string eMail { get; set; }   // VarChar(100)

        public void InterfaceBusinessLogic(){
           // Console.WriteLine("Customers."); // SI - TDD
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
using System;
using System.IO;

using CustomerLibrary;
using ProductLibrary;
using LocationLibrary;

using OrderLibrary;

using System.Data.SqlClient;

namespace Application
{
    internal class Start
    {
        static void Main()
        {   
            // Connection Information
            string Pointer = File.ReadAllText("./MLiMa.Info");
            Console.WriteLine(Pointer);
            // End Program & Close Connections
            // bool Complete = false;
            // Establish DB
             SqlConnection DBconnect = new SqlConnection(Pointer);

             DBconnect.Open();
            // Main Iteration of User Interface
            /*
            do
            {
                // checked for Key Pressed as ASCII
                int Key = Console.Read();
                // Flow-Chart Pointers
                if (Key == 48) Complete = true; 
            }
            while (!Complete);
            */
            // Console.WriteLine(Complete);
            // Close Resources
             DBconnect.Close();
            // Structural Integrity Test
            /*
            CustomerLibrary.Routines _instantiateView1 = new CustomerLibrary.Routines();
            _instantiateView1.Interface();
            ProductLibrary.Routines _instantiateView2 = new ProductLibrary.Routines();
            _instantiateView2.Interface();
            LocationLibrary.Routines _instantiateView3 = new LocationLibrary.Routines();
            _instantiateView3.Interface();

            OrderLibrary.Routines _instantiateView0 = new OrderLibrary.Routines();
            _instantiateView0.Interface();
            */
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


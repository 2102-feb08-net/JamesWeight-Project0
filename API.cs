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
            //
            // Console.WriteLine(Pointer); // Test
            //
            // Register to End Program & Close Connections
            bool Complete = false;
            // Establish DB
            SqlConnection DBconnect = new SqlConnection(Pointer);
            // Open ResourceDB
            DBconnect.Open();
            // Title
            Console.WriteLine(" " + (char)13 + (char)10 + " ");
            string _data = "Welcome to the Market Locations Inventory Management Application";
            Console.WriteLine(_data + (char)13 + (char)10);
            // Display Menu
            DisplayMenu(_data);
            // Main Iteration of User Interface
            do
            {
                // check for Key Pressed as ASCII
                int Key = Console.Read();
                // Flow-Chart Pointers
                if (Key == 48) Complete = true;
                if (Key == 57) DisplayMenu(_data);
            }
            while (!Complete);
            // Close ResourceDB
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
        // Display Menu Method
        static void DisplayMenu(string Data)
        {
            // Menu
            Console.WriteLine
            (
                new String('=', Data.Length) + (char)13 + (char)10
                + (char)13 + (char)10              
                + "Choose your task via KeyPress and then Press 'Enter'." + (char)13 + (char)10
                + (char)13 + (char)10              
                + "1) Order" + (char)13 + (char)10
                + "2) Add Customer" + (char)13 + (char)10
                + "3) Search Customers by Name" + (char)13 + (char)10
                + "4) Display Details of an Order" + (char)13 + (char)10              
                + "5) Display History of Orders at a Store" + (char)13 + (char)10 
                + "6) Display History of a Customer" + (char)13 + (char)10
                + new String('=', Data.Length) + (char)13 + (char)10
                + "A) Serialize Data" + (char)13 + (char)10
                + "B) DeSerialize Data" + (char)13 + (char)10
                + new String('-', Data.Length) + (char)13 + (char)10
                + "0) Exit" + (char)13 + (char)10
                + "9) Redisplay Menu" + (char)13 + (char)10
            );
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


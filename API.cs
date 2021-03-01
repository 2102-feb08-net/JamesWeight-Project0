using System;
using System.IO;

namespace Application
{
    internal class Start
    {
        static void Main()
        {   
            // Business Logic from Class Libraries
            CustomerLibrary.Routines _logicCL = new CustomerLibrary.Routines(); _logicCL.BusinessLogic();
            ProductLibrary.Routines _logicPL = new ProductLibrary.Routines(); _logicPL.BusinessLogic();
            LocationLibrary.Routines _logicLL = new LocationLibrary.Routines(); _logicLL.BusinessLogic();
            OrderLibrary.Routines _logicOL = new OrderLibrary.Routines(); _logicOL.BusinessLogic();
            // Register to End Program
            bool _complete = false;
            // Title
            Console.WriteLine(" " + (char)13 + (char)10 + " ");
            string _data = "Welcome to the Market Locations Inventory Management Application";
            Console.WriteLine(_data + (char)13 + (char)10);
            // Display Menu
            DisplayMenu(_data);
            // Toggle Mode
            bool _entityMode = false;
            // Main Iteration of User Interface
            do
            {
                // check for Key Pressed as ASCII
                int _key = Console.Read();
                // Flow-Chart Pointers
                if (_key == 48) _complete = true;
                // ----------
                if (_key == 55){ _entityMode = true; Console.WriteLine("Linq - Entity Frame-work Core Mode"); }
                if (_key == 56){ _entityMode = false; Console.WriteLine("System.Data.SQLclient Mode"); }
                if (_key == 57) DisplayMenu(_data);
                // ----- U / u ----- Customer Functions
                if (_key == 85 || _key == 117){
                    if (_entityMode){

                    }else{
                        // Request Data
                        string[] _send = {"Reference #", "Name", "Address", "Phone Number", "eMail Address", "Home Store Preference"}; 
                        // DataBase Routines
                        DBlayer.Start _logicDB = new DBlayer.Start(); _logicDB.DBprocess("SELECT * FROM Customers", 6, _send, 0);
                    }
                }
                // ----- I / i----- Location Functions
                if (_key == 73 || _key == 105){
                    if (_entityMode){

                    }else{
                        // Request Data
                        string[] _send = {"Reference #", "Name", "Address", "Phone Number", "eMail Address"}; 
                        // DataBase Routines
                        DBlayer.Start _logicDB = new DBlayer.Start(); _logicDB.DBprocess("SELECT * FROM Customers", 6, _send, 0);
                    }
                }
                // ----- I / i ----- Product Functions
                if (_key == 79 || _key == 111){
                    if (_entityMode){

                    }else{
                        // Request Data
                        string[] _send = {"Reference #", "At Location Identifier", "Name", "Description", "Price", "Quantity In Location"}; 
                        // DataBase Routines
                        DBlayer.Start _logicDB = new DBlayer.Start(); _logicDB.DBprocess("SELECT * FROM Customers", 6, _send, 0);
                    }
                }
                // ----- I / i ----- Order Functions
                if (_key == 80 || _key == 112){
                    if (_entityMode){

                    }else{
                        // Request Data
                        string[] _send = {"Reference #", "Customer Reference #", "Location Reference #", "Product Reference #", "Record Date", "Percentage Off", "Reduced Amount"}; 
                        // DataBase Routines
                        DBlayer.Start _logicDB = new DBlayer.Start(); _logicDB.DBprocess("SELECT * FROM Customers", 6, _send, 0);
                    }
                }
            }
            while (!_complete);
        }
        // Display Menu Method
        static void DisplayMenu(string _data)
        {
            // Menu
            Console.WriteLine
            (
                new String('=', _data.Length) + (char)13 + (char)10
                + (char)13 + (char)10              
                + "Choose your task via KeyPress and then Press 'Enter'." + (char)13 + (char)10
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
                + new String('=', _data.Length) + (char)13 + (char)10
                + "U) View Table Customers" + (char)13 + (char)10 // 85, 117
                + "I) View Table Locations" + (char)13 + (char)10 // 73, 105
                + "O) View Table Products" + (char)13 + (char)10 // 79, 111
                + "P) View Table Orders" + (char)13 + (char)10 // 80, 112
                + new String('-', _data.Length) + (char)13 + (char)10 //
                + "0) Exit" + (char)13 + (char)10 // 48
                + new String('-', _data.Length) + (char)13 + (char)10 //
                + "7) Linq EF Core FW Mode" + (char)13 + (char)10 // 55
                + "8) System.Data.SQLclient Mode" + (char)13 + (char)10 // 56
                + "9) Redisplay Menu" + (char)13 + (char)10 // 57
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


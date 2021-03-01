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
            // Business Logic from Class Libraries
            CustomerLibrary.Routines _logicCL = new CustomerLibrary.Routines(); _logicCL.InterfaceBusinessLogic();
            ProductLibrary.Routines _logicPL = new ProductLibrary.Routines(); _logicPL.InterfaceBusinessLogic();
            LocationLibrary.Routines _logicLL = new LocationLibrary.Routines(); _logicLL.InterfaceBusinessLogic();
            OrderLibrary.Routines _logicOL = new OrderLibrary.Routines(); _logicOL.InterfaceBusinessLogic();
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
                        SQLquery("SELECT * FROM Customers", 6, _send, 0);
                    }
                }
                // ----- I / i----- Location Functions
                if (_key == 73 || _key == 105){
                    if (_entityMode){

                    }else{
                        // Request Data
                        string[] _send = {"Reference #", "Name", "Address", "Phone Number", "eMail Address"}; 
                        SQLquery("SELECT * FROM Locations", 5, _send, 1);
                    }
                }
                // ----- I / i ----- Product Functions
                if (_key == 79 || _key == 111){
                    if (_entityMode){

                    }else{
                        // Request Data
                        string[] _send = {"Reference #", "At Location Identifier", "Name", "Description", "Price", "Quantity In Location"}; 
                        SQLquery("SELECT * FROM Locations", 6, _send, 2);
                    }
                }
                // ----- I / i ----- Order Functions
                if (_key == 80 || _key == 112){
                    if (_entityMode){

                    }else{
                        // Request Data
                        string[] _send = {"Reference #", "Customer Reference #", "Location Reference #", "Product Reference #", "Record Date", "Percentage Off", "Reduced Amount"}; 
                        SQLquery("SELECT * FROM Locations", 7, _send, 2);
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
                + "I) View Table Locations" + (char)13 + (char)10
                + "O) View Table Products" + (char)13 + (char)10
                + "P) View Table Orders" + (char)13 + (char)10
                + new String('-', _data.Length) + (char)13 + (char)10 //
                + "0) Exit" + (char)13 + (char)10 // 48
                + new String('-', _data.Length) + (char)13 + (char)10 //
                + "7) Linq EF Core FW Mode" + (char)13 + (char)10 // 55
                + "8) System.Data.SQLclient Mode" + (char)13 + (char)10 // 56
                + "9) Redisplay Menu" + (char)13 + (char)10 // 57
            );
        }
        // System.Data.SQLclient
        static void SQLquery(string _query, int _length, string[] _key, int _businessFlow){
            // Inform
            Console.WriteLine("Processing Query for Customers" + (char)13 + (char)10);
            // Connection Information
            string _pointer = File.ReadAllText("./MLiMa.Info");

            //
            // Console.WriteLine(Pointer); // Test
            //

            // Establish DB
            try
            {
                using (SqlConnection _connectDB = new SqlConnection(_pointer))
                {
                    // Open ResourceDB
                    _connectDB.Open();
                    // Send Instruction
                    using (SqlCommand _instructionDB = new SqlCommand(_query, _connectDB))
                    {
                        // Read Instruction
                        SqlDataReader _readData = _instructionDB.ExecuteReader();
                        // Display Data while TRUE
                        while (_readData.Read())
                        {
                            for (int _index = 0; _index < _length; _index ++)
                            {
                                Console.WriteLine(_key[_index] + ": " + _readData[_index]);
                            }
                        // New Line
                        Console.WriteLine();
                        }
                        // Close DataReader
                        _readData.Close();
                    }
                    // New Line
                    Console.WriteLine();
                    // Close Connection
                    _connectDB.Close();
                }
            }
            // Exception Handling
            catch
            {
                // New Line
                Console.WriteLine(" ");
                // Message for User                
                Console.WriteLine("Recovered...");
            }
            // Continue
            finally
            {
                // New Line
                Console.WriteLine(" ");
                // Message For User                
                Console.WriteLine("Menu Option?" + (char)13 + (char)10);
            }
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


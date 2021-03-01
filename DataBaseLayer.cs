using System;
using System.IO;

using System.Data.SqlClient;

namespace DBlayer
{
    internal class Start
    {
        // System.Data.SQLclient
        internal void DBprocess(string _query, int _length, string[] _key, int _dataSet)
        {
            // Inform
            Console.WriteLine("Processing Query for Customers" + (char)13 + (char)10);
            // Connection Information
            string _pointer = File.ReadAllText("./Database.Connection");

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
                            // Store Last Record Entry as Current
                            if (_dataSet == 0)
                            {
                                // Instantiation
                                CustomerLibrary.Routines _instanceLR = new CustomerLibrary.Routines();
                                _instanceLR.BusinessLogic();
                            }
                            if (_dataSet == 1)
                            {
                                // Instantiation
                                LocationLibrary.Routines _instanceLR = new LocationLibrary.Routines();
                                _instanceLR.BusinessLogic();
                            }
                            if (_dataSet == 2)
                            {
                                // Instantiation
                                ProductLibrary.Routines _instanceLR = new ProductLibrary.Routines();
                                _instanceLR.BusinessLogic();
                            }
                            if (_dataSet == 3)
                            {
                                // Instantiation
                                OrderLibrary.Routines _instanceLR = new OrderLibrary.Routines();
                                _instanceLR.BusinessLogic();
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


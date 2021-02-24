using System;
using System.IO;
using System.Text;

namespace DB
{   
    // Interface to retrieve the value
    // from the KeyWord in the Conduit
    interface DataRetrieval
    {
        string ReadData(int Character);
    }
    // Database Routines
    public class DBroutines : DataRetrieval
    {   
        // Data utilized by Methods
        private string _data = String.Empty;
        // Localized Common Conduit
        public string ReadData(int Character){
            // Exception Handler -> Try-Catch
            try
            {
                _data = File.ReadAllText(@"Conduit.Channel");
            }
            catch
            {
                // Creating Data
                if (Character >= 49 && Character <= 54)
                {
                    Console.WriteLine
                    ( new String('=', _data.Length) + (char)13 + (char)10
                      + "Building Data..." // + Character.ToString()
                      + (char)13 + (char)10
                    );
                    // Import Data
                    if (Character == 49) _data = File.ReadAllText(@"Orders.Screen");
                    if (Character == 50) _data = File.ReadAllText(@"Customers.Screen");
                    if (Character == 51) _data = File.ReadAllText(@"Search.Screen");
                    if (Character == 52) _data = File.ReadAllText(@"DisplayDetails.Screen");
                    if (Character == 53) _data = File.ReadAllText(@"DisplayHistoryLocation.Screen");
                    if (Character == 54) _data = File.ReadAllText(@"DisplayHistoryCustomer.Screen");
                    Console.WriteLine(_data);
                    Console.ReadLine();
                }
            }

            return _data;
        }
        // Structural Integrity Test
        public void Display()
        {
            Console.WriteLine("TDD-StructuralIntegrity-DB");
        }
        static void Main(){} // Required
    }
}

// Revature Intellectual Property and Resource:
//  Batch -> 2102-feb08-net
//
//  Project0 - Feb 12, 2021 Received Original Specifications
//           - Feb 18, 2021 Received Requested Specifications
//           - Feb 24, 2021 Requested Deliverable
//
//  Project Lead - Revature Corporate Trainor Nick Escalon
//  Project Deliverable - Developer & Author -
//                        Revature Engineering Associate James Weight
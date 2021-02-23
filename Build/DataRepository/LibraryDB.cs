using System;

namespace DB
{   
    // Interfaces to define the DataSet in Memory
    public interface Store
    {
        int ID{ get; set; } // PK, Unique
        int ZipCode{ get; set; }
    }
    public interface Customer{
        int ID{ get; set; } // PK, Unique
        string FirstName{ get; set; }
        string LastName{ get; set; }
        string Address{ get; set; }
        string AddressAdditional{ get; set; }    
    }
    public interface Location
    {
        int ID{ get; set; } // PK, Unique as ZipCode
        string City{ get; set; }
        string State{ get; set; }
    }
    public interface Product
    {
        int ID{ get; set; }
        string Description{ get; set; }
        float Price{ get; set; }
    }
    // Database Routines
    public class DBroutines
    {   
        // Structural Integrity Test
        public void Display()
        {
            Console.WriteLine("TDD-StructuralIntegrity-DB");
        }
        // Required
        static void Main(){ }
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
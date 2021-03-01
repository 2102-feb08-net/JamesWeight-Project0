using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace FileIOlayer
{
    internal class Routines
    {
        // Serialize into XML
        internal bool Serialization(object _readData){
            Console.WriteLine(_readData);

            return true;
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
using System;

namespace OrderLibrary
{
    internal class Routines
    {
        private int ID { get; set; }  // Primary Key
        private int CustomerID { get; set; } // Foreign Key
        private int StoreID { get; set; } // Foreign Key

        internal void Interface(){
            Console.WriteLine("Order.");
        }
    }
}
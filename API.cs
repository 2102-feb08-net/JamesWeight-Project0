using System;
using OrderLibrary;
using ProductLibrary;
using System.Data.SqlClient;

namespace Application
{
    internal class Start
    {
        static void Main()
        {
            
   //SqlConnection test;
   //string connectionString = "";
   string test = new SqlConnection("LocalHost");
   //cnn.Open();
   //Console.WriteLine("Connection Open  !");
   //cnn.Close();

            OrderLibrary.Routines _instantiateView1 = new OrderLibrary.Routines();
            _instantiateView1.Interface();
            LocationLibrary.Routines _instantiateView2 = new LocationLibrary.Routines();
            _instantiateView2.Interface();
            ProductLibrary.Routines _instantiateView3 = new ProductLibrary.Routines();
            _instantiateView3.Interface();        }
    }
}



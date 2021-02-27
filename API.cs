using System;
using OrderLibrary;
using ProductLibrary;

namespace Application
{
    internal class Start
    {
        static void Main()
        {
            /*
   string connectionString;
   SqlConnection cnn;
   connectionString = "localhost";
   cnn = new SqlConnection(connectionString);
   cnn.Open();
   Console.WriteLine("Connection Open  !");
   cnn.Close();*/

            OrderLibrary.Routines _instantiateView1 = new OrderLibrary.Routines();
            _instantiateView1.Interface();
            LocationLibrary.Routines _instantiateView2 = new LocationLibrary.Routines();
            _instantiateView2.Interface();
            ProductLibrary.Routines _instantiateView3 = new ProductLibrary.Routines();
            _instantiateView3.Interface();        }
    }
}
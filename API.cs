using System;
using DomainLibraryA;
using DomainLibraryB;

namespace Application
{
    internal class Program
    {
        internal static void Main()
        {
            var ctx = new SContext();
            var student = new Student() { StudentName = "Bill" };

            Console.WriteLine(student.StudentName + (char)13 + (char)10 + ctx.Height);
        }
    }
}
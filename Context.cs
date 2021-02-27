using System;
using System.Collections.Generic;

namespace DomainLibraryB
{
    public class SContext
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
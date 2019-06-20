using System;

namespace Polymorphism_Exercise_1
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Opening Connection for Oracle");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Connection for Oracle");
        }
    }
}
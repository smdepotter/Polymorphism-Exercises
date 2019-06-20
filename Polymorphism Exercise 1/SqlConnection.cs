using System;

namespace Polymorphism_Exercise_1
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {

            Console.WriteLine("Opening Connection for SQL");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Connection for SQL");
        }
    }
}
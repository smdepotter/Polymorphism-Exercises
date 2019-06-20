using System;
using System.Diagnostics;

namespace Polymorphism_Exercise_1
{
    public abstract class DbConnection
    {
        private string _connectionString;
        private readonly Stopwatch _stopwatch = new Stopwatch();


        protected DbConnection(string connectionString)
        {

            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("Please send a connection string that isn't null or blank");

            //replaced TimeSpan with Stopwatch
            _stopwatch.Start();
            Console.WriteLine("Starting Connection to Server...");
            if (_stopwatch.ElapsedMilliseconds >= 5000)
                throw new TimeoutException("The database didn't respond in over 5 seconds");

            _connectionString = connectionString;
            Console.WriteLine("Connected");
        }

        public abstract void Open();
        public abstract void Close();
    }
}
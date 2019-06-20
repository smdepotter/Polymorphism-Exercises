using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Exercise_1
{
    class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (string.IsNullOrWhiteSpace(instruction))
                throw new InvalidOperationException("Please provide an instruction");

            _dbConnection = dbConnection ?? throw new InvalidOperationException("Please provide a connection");
            _instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine("You've run the instruction: " + _instruction);
            _dbConnection.Close();
        }
    }
}

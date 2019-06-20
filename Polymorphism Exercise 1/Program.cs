using System;

namespace Polymorphism_Exercise_1
{
    class Program
    {
        

        static void Main()
        {
            var sqlDb = new DbCommand(new SqlConnection("Open"), "DoSQLStuff");
            sqlDb.Execute();

            var oracleDb = new DbCommand(new OracleConnection("Open"), "DoOracleStuff");
            oracleDb.Execute();



        }
    }
}

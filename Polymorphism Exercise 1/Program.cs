namespace Polymorphism_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("Open");
            var oracle = new OracleConnection("Open");
            sql.Open();
            sql.Close();
            oracle.Open();
            oracle.Close();

        }
    }
}

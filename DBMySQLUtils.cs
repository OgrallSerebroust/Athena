using MySql.Data.MySqlClient;

namespace AthenaNewGeneration;

public static class DbMySqlUtils
{
    public static MySqlConnection GetDbConnection(string host, string database, string username,
        string password)
    {
        var connString = $"Server={host};Database={database};User Id={username};password={password}";
        MySqlConnection conn = new(connString);
        return conn;
    }
}
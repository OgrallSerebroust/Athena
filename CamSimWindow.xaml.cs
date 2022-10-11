using System;
using System.Data.Common;
using System.Windows;
using MySql.Data.MySqlClient;

namespace AthenaNewGeneration;

public partial class CamSimWindow
{
    public CamSimWindow()
    {
        InitializeComponent();
        DataContext = new ViewModel();
    }

    private void MakeDonate(object sender, RoutedEventArgs e)
    {
        Random randomizer = new();
        var ourDonate = (short)randomizer.Next(1, 500);
        OurDonatShowing.Text = ourDonate.ToString();
        var conn = DbUtils.GetDbConnection();
        conn.Open();
        try
        {
            QueryDonatesList(conn);
        }
        catch (Exception exception)
        {
            MessageBox.Show($"Error: {exception.Message}/n{exception.StackTrace}");
        }
        finally
        {
            conn.Close();
            conn.Dispose();
        }
    }

    private static void QueryDonatesList(MySqlConnection connection)
    {
        const string query = "SELECT * FROM DonatesPrises";
        MySqlCommand command = new();
        command.Connection = connection;
        command.CommandText = query;
        using(DbDataReader reader = command.ExecuteReader())
        {
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    var value = reader.GetString(1);
                    MessageBox.Show(value);
                }
            }
        }
    }
}
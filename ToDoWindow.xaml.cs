using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MySql.Data.MySqlClient;

namespace AthenaNewGeneration;

public partial class ToDoWindow : Window
{
    public ToDoWindow()
    {
        InitializeComponent();
    }

    private void AddTask(object sender, RoutedEventArgs e)
    {
        Test.AppendText("GettingConnection...");
        MySqlConnection conn = DbUtils.GetDbConnection();
        try
        {
            Test.AppendText("Opening Connection");
            conn.Open();
            Test.AppendText("Connection successful!");
        }
        catch(Exception exception)
        {
            Test.AppendText("Error: " + exception.Message);
        }

        Console.Read();
    }
}
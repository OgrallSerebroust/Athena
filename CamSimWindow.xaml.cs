using System;
using System.Windows;
using System.Windows.Threading;

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
    }
}
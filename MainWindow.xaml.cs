using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AthenaNewGeneration
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelectSpecialTask(string taskString)
        {
            /*if (taskString == "Hello")
            {
                Process.Start(@"D:\Python\python", @"D:\MyProjects\AthenaNewGeneration\test.py");
            }*/

            switch (taskString)
            {
                case "Hello":
                    Process.Start(@"D:\Python\python", @"D:\MyProjects\AthenaNewGeneration\test.py");
                    break;
                case "To do":
                    ToDoWindow toDoWindow = new ToDoWindow();
                    toDoWindow.Owner = this;
                    toDoWindow.Show();
                    break;
                case "Game":
                    CamSimWindow camSimWindow = new CamSimWindow();
                    camSimWindow.Owner = this;
                    camSimWindow.Show();
                    break;
            }
        }

        private void TextBoxConfirmTask(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                MessageBox.Show(TextBoxSpecialTask.Text);
                SelectSpecialTask(TextBoxSpecialTask.Text);
            }
        }
    }
}
﻿using System.Configuration;
using System.Data;
using System.Windows;

namespace PROGRAMMING_PART2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        public static void Nain()
        {
            App app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }

}

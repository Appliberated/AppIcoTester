// <copyright file="Program.cs" company="Appliberated">
// Copyright � Appliberated. All rights reserved.
// </copyright>

namespace AppIcoTester
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The main program class of the application.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

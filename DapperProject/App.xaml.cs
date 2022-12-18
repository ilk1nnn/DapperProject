using DapperProject.Data_Access.Abstractions;
using DapperProject.Data_Access.Concrets;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DapperProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IUnitOfWork DB;

        public App()
        {
            DB = new UnitOfWork();
        }


    }
}

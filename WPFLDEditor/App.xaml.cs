﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPFLDEditor
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

    }
    public class variable
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
    }
    public class EditorLD
    {
        public int NumberNet { get; set; }
        public int num { get; set; }
    }
    public class Ramazan
    {
        public string Stroka { get; set; }

    }

}

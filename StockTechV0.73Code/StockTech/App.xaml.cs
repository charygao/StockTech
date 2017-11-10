﻿
//Copyright (c) 2010-2012, 王旭明 youkes.com
//All rights reserved.
//MIT licence.
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using StockTech.Py;

namespace StockTech
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            PyEngine.Inst.init();
            
        }

    }
}

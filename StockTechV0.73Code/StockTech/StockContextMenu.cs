//Copyright (c) 2010-2012, 王旭明 youkes.com
//All rights reserved.
//MIT licence.
//v0.72
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace StockTech
{
    class StockContextMenu : ContextMenu
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        public StockContextMenu()
        {
          
        }


        public void addMenu(string txt)
        {

            MenuItem item = new MenuItem();
            item.Header = txt;

            item.Click += new System.Windows.RoutedEventHandler(item_Click);
            this.Items.Add(item);

        }

        void item_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            var headText = (string)item.Header;

            if (OnMenuItemClicked != null)
            {
                OnMenuItemClicked(headText);
            }

        }

        public delegate void MenuItemClickedHandler(string txt);
        public event MenuItemClickedHandler OnMenuItemClicked;
      

    }

}

﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Diakszovetkezet
{
    /// <summary>
    /// Interaction logic for wndRendszerAdmin.xaml
    /// </summary>
    public partial class wndRendszerAdmin : Window
    {
        public wndRendszerAdmin()
        {
            InitializeComponent();
        }
        //<summary>
        //Modell osztály szükséges a listview listáinak feltöltéséhez
        //<summary>
        class lvElmenetsMunka
        {
            string Munka, Cégnév, Helyszín, Helyekszáma, Munkakezdet, Munkavége, Munkakör; 
        }

        //<summary>
        //Ebbe a listába fogjuk betölteni azokat az adatokat amiket a Munkák kilistázására fogunk használni.
        //<summary>
        List<lvElmenetsMunka> lElements = new List<lvElmenetsMunka>();
    }
}

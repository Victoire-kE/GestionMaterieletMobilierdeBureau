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
using System.Windows.Navigation;
using System.Windows.Shapes;
using GestionMatetMob.Formulaire;

namespace GestionMatetMob.Formulaire
{
    /// <summary>
    /// Logique d'interaction pour User_List_Produit.xaml
    /// </summary>
    public partial class User_List_Produit : UserControl
    {
        public User_List_Produit()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AjoutArticle a1 = new AjoutArticle();
            a1.Show();
           
           

        }
    }
}

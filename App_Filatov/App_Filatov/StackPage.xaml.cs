﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Filatov
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackPage : ContentPage
    {
        public StackPage()
        {
            InitializeComponent();
        }
        int clik = 0;
        private void Btn_Clicked(object sender, EventArgs e)
        {
            //btn.Text= "Huraaa!";
            clik++;
            btn.Text = clik.ToString();
            if (clik % 5 == 0)
            {
                //lbl.IsVisible = false;
                lbl.Text = "";
            }
            else;
            {
                //lbl.IsVisible = true;
                lbl.Text = "Nupp!";
            }
        }
        private void btn2_Clicked(object sender, EventArgs e)
        {
            clik = 0;
            btn.Text = clik.ToString();
        }

    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Theraputic.Models;
using Theraputic.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Theraputic.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}
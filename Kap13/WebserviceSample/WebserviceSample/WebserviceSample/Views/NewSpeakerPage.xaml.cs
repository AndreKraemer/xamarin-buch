using System;
using System.Collections.Generic;
using System.ComponentModel;
using WebserviceSample.Models;
using WebserviceSample.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebserviceSample.Views
{
    public partial class NewSpeakerPage : ContentPage
    {
        public Speaker Speaker { get; set; }

        public NewSpeakerPage()
        {
            InitializeComponent();
            BindingContext = new NewSpeakerViewModel();
        }
    }
}
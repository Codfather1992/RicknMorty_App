using MauiMicroMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicknMorty_App.ViewModels
{
    class TestPageViewModel : MauiMicroViewModel
    {
        public TestPageViewModel(ViewModelContext context) : base(context)
        {
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}

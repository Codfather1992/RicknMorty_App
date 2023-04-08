using MauiMicroMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicknMorty_App.ViewModels
{
    class MainPageViewModel : MauiMicroViewModel
    {
        public MainPageViewModel(ViewModelContext context) : base(context)
        {
        }
        public override void OnAppearing()
        {
            base.OnAppearing();
        }
        public void MoveToNewScreen() { 

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewsXF
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel _mainViewModel;
        public MainPage()
        {
            InitializeComponent();
            _mainViewModel = new MainViewModel(stackLayout,cv);
            BindingContext = _mainViewModel;
           
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
           // _mainViewModel.StackLayoutView(stackLayout);
        }
    }
}

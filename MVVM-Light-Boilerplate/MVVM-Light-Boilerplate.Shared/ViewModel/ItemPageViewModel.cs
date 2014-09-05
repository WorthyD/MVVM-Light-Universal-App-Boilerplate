using GalaSoft.MvvmLight;
using MVVM_Light_Boilerplate.Contracts;
using MVVM_Light_Boilerplate.DataModel;
using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MVVM_Light_Boilerplate.ViewModel
{
    public class ItemPageViewModel : ViewModelBase, IViewModel
    {

        private SampleDataItem _item;

        public SampleDataItem Item 
        {
            get
            {
                return _item;
            }
            set
            {
                Set(() => Item, ref _item, value);
            }
        }



        public ItemPageViewModel(Common.NavigationHelper navHelper)
        {
        }

        public async void Initialize(object parameter)
        {
            this.Item  = await SampleDataSource.GetItemAsync(parameter.ToString());
        }
    }
}

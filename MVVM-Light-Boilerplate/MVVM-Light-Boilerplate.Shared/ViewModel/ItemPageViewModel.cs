using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
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

        public RelayCommand GoBack { get; set; }
 
        private Common.NavigationHelper _navHelper;

        public Common.NavigationHelper NavigationHelper
        {
            get
            {
                return _navHelper;
            }
            set
            {
                Set(() => NavigationHelper, ref _navHelper, value);
            }
        }

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
            this.NavigationHelper = navHelper;
            this.InitializeCommands();
        }

        private void InitializeCommands()
        {
            GoBack = new RelayCommand(() =>
            {
                NavigationHelper.GoBack();
            });
 
        }

        public async void Initialize(object parameter)
        {
            this.Item  = await SampleDataSource.GetItemAsync(parameter.ToString());
        }
    }
}

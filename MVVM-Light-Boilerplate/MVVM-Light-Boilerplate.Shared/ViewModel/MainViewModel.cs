using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MVVM_Light_Boilerplate.DataModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;

namespace MVVM_Light_Boilerplate.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string _helloWorld;

        public string HelloWorld
        {
            get
            {
                return _helloWorld;
            }
            set
            {
                Set(() => HelloWorld, ref _helloWorld, value);
            }
        }

        private SampleDataGroup _gData;

        public SampleDataGroup GData
        {
            get
            {
                return _gData;
            }
            set
            {
                Set(() => GData, ref _gData, value);
            }
        }

       

        public  MainViewModel()
        {
            HelloWorld = IsInDesignMode
                ? "Runs in design mode"
                : "Runs in runtime mode";
            GetData();
        }
        public async void GetData()
        {
            GData = await SampleDataSource.GetGroupAsync("Group-4");
        }


        public const string LastPositionPropertyName = "LastPosition";

        private string _lastPosition = "Click somewhere";
        private RelayCommand _showPositionCommand;

        public string LastPosition
        {
            get
            {
                return _lastPosition;
            }
            set
            {
                Set(() => LastPosition, ref _lastPosition, value);
            }
        }

        public RelayCommand ShowPositionCommand
        {
            get
            {
                return _showPositionCommand
                        ?? (_showPositionCommand = new RelayCommand(
                ()=>
                            {
                            Debug.WriteLine("click");
                            }));
            }
        }

        private RelayCommand<ItemClickEventArgs> _itemClick;
        public RelayCommand<ItemClickEventArgs> ItemClick
        {
            get
            {
                return _itemClick
                        ?? (_itemClick = new RelayCommand<ItemClickEventArgs>(
                            item =>
                            {
                                var x = (SampleDataItem)item.ClickedItem;
                            Debug.WriteLine("click -" + x.Title );

                            }));
            }
 
        }


    }
}

﻿using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using MVVM_Light_Boilerplate.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Light_Boilerplate.ViewModel
{
    public class ViewModelLocator
    {
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public ItemPageViewModel ItemPage
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ItemPageViewModel>();
            }
        }


        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<ItemPageViewModel>();
            SimpleIoc.Default.Register<NavigationHelper>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Light_Boilerplate.Contracts
{
    public interface IView
    {
        IViewModel ViewModel { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    using Windows.UI.Xaml.Controls;

    public interface INavigationService
    {
        void Navigate(string pageName);
        Frame Frame { get; set; }
    }
}

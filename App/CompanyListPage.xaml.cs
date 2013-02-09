using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Grouped Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234231

namespace App
{
    using Contracts.View;
    using Contracts.ViewModel;

    using global::App.Common;

    /// <summary>
    /// A page that displays a grouped collection of items.
    /// </summary>
    public sealed partial class CompanyListPage : LayoutAwarePage, ICompanyListPage
    {
        public CompanyListPage()
        {
            this.InitializeComponent();
        }

        public IViewModel ViewModel
        {
            get
            {
                return this.DataContext as ICompanyViewModel;
            }
        }
    }
}

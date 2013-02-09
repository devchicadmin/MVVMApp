using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    using Contracts.View;

    using GalaSoft.MvvmLight.Ioc;

    using Windows.UI.Xaml.Controls;

    public class NavigationService : INavigationService
    {
        private Frame frame;

        public Frame Frame
        {
            get
            {
                return frame;
            }
            set
            {
                frame = value;
                frame.Navigated += OnFrameNavigated;
            }
        }

        private void OnFrameNavigated(object sender, Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            var view = e.Content as IView;
            var viewModel = view.ViewModel;
            viewModel.Initialize();

        }

        /// <summary>
        /// Navigates to a specified page 
        /// </summary>
        /// <param name="pageName">
        /// The page name.
        /// </param>
        public void Navigate(string pageName)
        {
            switch (pageName)
            {

                case "CompanyListPage":
                    var mainPageType = SimpleIoc.Default.GetInstance<ICompanyListPage>();
                    Frame.Navigate(mainPageType.GetType());
                    break;
                case "EmployeeListPage": 
                    var editPageType = SimpleIoc.Default.GetInstance<IEmployeeListPage>();
                    Frame.Navigate(editPageType.GetType());
                    break;
                default:
                    var defaultPageType = SimpleIoc.Default.GetInstance<ICompanyListPage>();
                    Frame.Navigate(defaultPageType.GetType());
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVVMApp
{
    using Contracts.Services;
    using Contracts.View;
    using Contracts.ViewModel;

    using GalaSoft.MvvmLight.Ioc;

    using Microsoft.Practices.ServiceLocation;

    using ViewModels;

    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<INavigationService, NavigationService>();
            SimpleIoc.Default.Register<ICompanyListPage, CompanyListPage>();
            SimpleIoc.Default.Register<IEmployeeListPage, EmployeeListPage>();
            SimpleIoc.Default.Register<ICompanyViewModel, CompanyListViewModel>(true);
            SimpleIoc.Default.Register<IEmployeeViewModel, EmployeeListViewModel>(true);

        }

        public CompanyListViewModel CompanyListViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ICompanyViewModel>() as CompanyListViewModel;
            }
        }

        public EmployeeListViewModel EmployeeListViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<IEmployeeViewModel>() as EmployeeListViewModel;
            }
        }
    }
}

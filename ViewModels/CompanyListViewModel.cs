using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    using System.Collections.ObjectModel;

    using Business;

    using Contracts.Services;
    using Contracts.ViewModel;

    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;
    using GalaSoft.MvvmLight.Ioc;
    using GalaSoft.MvvmLight.Messaging;

    public class CompanyListViewModel : ViewModelBase, ICompanyViewModel
    {
        private INavigationService navigationService;

        public RelayCommand<Company> ItemClickCommand { get; set; }

        public ObservableCollection<Company> CompanyList { get; set; }

        private Company selectedCompany;

        public Company SelectedCompany
        {
            get
            {
                return selectedCompany;
            }
            set
            {
                selectedCompany = value;
                this.RaisePropertyChanged(() => this.SelectedCompany);
            }
        }

        /// <summary>
        /// The initialize.
        /// </summary>
        public void Initialize()
        {
            navigationService = SimpleIoc.Default.GetInstance<INavigationService>();

            InitializeCommands();

            LoadCompanies();


        }

        private void LoadCompanies()
        {
            this.CompanyList = new ObservableCollection<Company>();


            this.CompanyList.Add(new Company() { AddressLine1 = "1 Apple Tree Lane", Name = "ABC Company", Id = new Guid("0E42F677-4C74-4342-B3A5-172067A3EC1E") });
            this.CompanyList.Add(new Company() { AddressLine1 = "52 High Street", Name = "ZYX Company", Id = new Guid("1DE83E5B-00A7-45AA-AE00-A5EEF32AC8BB") });

        }


        private void InitializeCommands()
        {
            ItemClickCommand = new RelayCommand<Company>((item) =>
            {
                Messenger.Default.Send<CompanySelectedMessage>(new CompanySelectedMessage() { CompanyId = item.Id });
                navigationService.Navigate("EmployeeListPage");
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    using System.Collections.ObjectModel;

    using Business;

    using Contracts.ViewModel;

    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Messaging;

    public class EmployeeListViewModel : ViewModelBase,IEmployeeViewModel 
    {
        public ObservableCollection<Employee> EmployeeList { get; set; }

        private Guid selectedCompanyId { get; set; }

        public EmployeeListViewModel()
        {
           this.InitializeMessenger();
            this.LoadEmployees();
        }

        private void LoadEmployees()
        {
            EmployeeList = new ObservableCollection<Employee>();
            EmployeeList.Add(new Employee() { Name = "Ben Brown", Department = "IT Services", CompanyId = new Guid("0E42F677-4C74-4342-B3A5-172067A3EC1E") });
            EmployeeList.Add(new Employee() { Name = "James Laque", Department = "HR", CompanyId = new Guid("0E42F677-4C74-4342-B3A5-172067A3EC1E") });
            EmployeeList.Add(new Employee() { Name = "Hannah Chapman", Department = "Finance", CompanyId = new Guid("0E42F677-4C74-4342-B3A5-172067A3EC1E") });
            EmployeeList.Add(new Employee() { Name = "Katherine Jenkins", Department = "IT Services", CompanyId = new Guid("0E42F677-4C74-4342-B3A5-172067A3EC1E") });
            EmployeeList.Add(new Employee() { Name = "David Wild", Department = "Sales", CompanyId = new Guid("0E42F677-4C74-4342-B3A5-172067A3EC1E") });
            EmployeeList.Add(new Employee() { Name = "Tom Button", Department = "Sales", CompanyId = new Guid("0E42F677-4C74-4342-B3A5-172067A3EC1E") });

            EmployeeList.Add(new Employee() { Name = "test4", Department = "IT Services", CompanyId = new Guid("1DE83E5B-00A7-45AA-AE00-A5EEF32AC8BB") });
            EmployeeList.Add(new Employee() { Name = "test5", Department = "IT Services", CompanyId = new Guid("1DE83E5B-00A7-45AA-AE00-A5EEF32AC8BB") });


            
        }
       
        public void Initialize()
        {
            
        }

        /// <summary>
        /// The initialize messenger which passes selected objects from page to page
        /// </summary>
        private void InitializeMessenger()
        {
            Messenger.Default.Register<CompanySelectedMessage>(this, this.OnCompanySelectedMessageReceived);
   
        }

        private void OnCompanySelectedMessageReceived(CompanySelectedMessage message)
        {
            this.selectedCompanyId = message.CompanyId;

            this.EmployeeList = new ObservableCollection<Employee>((from p in EmployeeList where p.CompanyId == this.selectedCompanyId select p));

        }
    }
}

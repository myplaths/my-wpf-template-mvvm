using Default_WPF_MVVM_Pattern_Implemented.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Default_WPF_MVVM_Pattern_Implemented.ViewModels
{
    public class MainWindowModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel;
        public BaseViewModel SelectedViewModel
        {
            get
            {
                return _selectedViewModel;
            }
            set
            {
                _selectedViewModel = value; OnPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public ICommand TestCommand { get; set; }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(Name));}
        }
        public MainWindowModel()
        {
            
            Name = "Default";
            TestCommand = new DelegateCommand(Test);
        }

        private void Test()
        {
            SelectedViewModel = new SecondPageViewModel();

        }
    }
}

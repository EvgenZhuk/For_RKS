using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using For_RKS.Model;

namespace For_RKS.ViewModel
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Command selectedCommand;

        public ObservableCollection<Command> Commands { get; set; }
        public Command SelectedCommand
        {
            get { return selectedCommand; }
            set
            {
                selectedCommand = value;
                OnPropertyChanged("SelectedCommand");
            }
        }

     

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

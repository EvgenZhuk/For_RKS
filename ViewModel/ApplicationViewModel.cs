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

        // данный конструктор как временное решение до реализации считывания XML
        public ApplicationViewModel()
        {
            Commands = new ObservableCollection<Command>
            {
                new Command {Name="ВКЛ ПРИБОР", Code="0xAAA3"},
                new Command {Name="ОТКЛ ПРИБОР", Code="0xBBB2"},
                new Command {Name="ЗАПУСТИТЬ ТЕСТ", Code="0xCCC1"},
                new Command {Name="ОСТАНОВИТЬ ТЕСТ", Code="0x88DD"},
                new Command {Name="ШТАТНЫЙ РЕЖИМ", Code="0xFF55"}
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

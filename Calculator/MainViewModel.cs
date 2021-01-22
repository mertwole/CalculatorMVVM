using System.ComponentModel;
using System.Windows.Input;

namespace Calculator
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        MainModel model = new MainModel();

        public string EvaluatedValue
        {
            get { return model.Evaluate(); }
        }

        ICommand press_command;
        public ICommand PressCommand
        {
            get
            {
                if (press_command == null)
                    press_command = new RelayCommand(
                        (parameter) =>
                        {
                            model.Input(parameter.ToString());
                            OnPropertyChanged("EvaluatedValue");
                        }
                    );
                return press_command;
            }
        }
    }
}

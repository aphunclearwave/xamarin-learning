using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin101
{
    public class TapMeButtonViewModel : INotifyPropertyChanged
    {
        string _buttonText;
        public string ButtonText
        {
            private set
            {
                _buttonText = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(ButtonText)));
                }
            }
            get
            {
                return _buttonText;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand TapMeCommand { get; private set; }


        public TapMeButtonViewModel()
        {
            ButtonText = "Tap me!!";
            TapMeCommand = new Command(OnTapMeTapped);
        }

        public void OnTapMeTapped()
        {
            ButtonText = "You Tapped Me!";
        }
    }
}
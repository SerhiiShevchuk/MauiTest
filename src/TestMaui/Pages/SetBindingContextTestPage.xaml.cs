using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestMaui.Pages;

public partial class SetBindingContextTestPage : ContentPage
{
    public SetBindingContextTestPageViewModel Model
    {
        get => BindingContext as SetBindingContextTestPageViewModel;
        set => BindingContext = value;
    }

    public SetBindingContextTestPage()
	{
		InitializeComponent();
	}

    public class SetBindingContextTestPageViewModel : INotifyPropertyChanged
    {
        private string _value = "InitialValue";
        public string Value
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }

        public SetBindingContextTestPageViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
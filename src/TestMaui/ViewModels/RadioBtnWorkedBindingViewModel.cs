using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestMaui.ViewModels
{
    public class RadioBtnWorkedBindingViewModel : INotifyPropertyChanged
    {
        public string GroupName { get; set; } = "Group";

        private string selection = "Dog";

        public string Selection
        {
            get => selection;
            set { SetProperty(ref selection, value); }
        }

        private string firstItem;
        public string FirstItem
        {
            get => firstItem;
            set { SetProperty(ref firstItem, value); }
        }

        private string secondItem;
        public string SecondItem
        {
            get => secondItem;
            set { SetProperty(ref secondItem, value); }
        }

        public RadioBtnWorkedBindingViewModel()
        {
            FirstItem = "Dog";

            SecondItem = "Cet";

            Selection = SecondItem;
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

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

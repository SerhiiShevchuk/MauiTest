using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestMaui.Models;

namespace TestMaui.ViewModels
{
    public class RadioBtnBindingTestViewModel : INotifyPropertyChanged
    {
        public string GroupName { get; set; } = "TestGroup";

        private object selection;

        public object Selection
        {
            get => selection;
            set { SetProperty(ref selection, value); }
        }


        public object FirstItem { get; set; } = new ValueModel { Id =1, Value= "FirstItem" };

        public object SecondItem { get; set; } = new ValueModel { Id = 2, Value = "SecondItem" };

        public RadioBtnBindingTestViewModel()
        {
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

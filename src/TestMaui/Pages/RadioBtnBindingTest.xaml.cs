using System.ComponentModel;
using TestMaui.ViewModels;

namespace TestMaui.Pages;

public partial class RadioBtnBindingTest : ContentPage
{
    //public RadioBtnWorkedBindingViewModel SimplModel
    //{
    //    get => BindingContext as RadioBtnWorkedBindingViewModel;
    //    set => BindingContext = value;
    //}

    public RadioBtnWorkedBindingViewModel SimplModel { get; set; }
    public RadioBtnBindingTestViewModel TestModel { get; set; }


    public RadioBtnBindingTest()
	{
        InitializeComponent();

        SimplModel = new RadioBtnWorkedBindingViewModel();
        TestModel = new RadioBtnBindingTestViewModel();

        BindingContext = TestModel;

        //InitializeComponent();
        //BindingContext = new AnimalViewModel
        //{
        //    GroupName = "animals",
        //    Selection = "Monkey"
        //};
    }
}

public class AnimalViewModel : INotifyPropertyChanged
{
    string groupName;
    object selection;

    public string GroupName
    {
        get => groupName;
        set
        {
            groupName = value;
            OnPropertyChanged(nameof(GroupName));
        }
    }

    public object Selection
    {
        get => selection;
        set
        {
            selection = value;
            OnPropertyChanged(nameof(Selection));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
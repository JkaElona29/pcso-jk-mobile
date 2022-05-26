using CommunityToolkit.Mvvm.ComponentModel;

namespace pcso_jk.ViewModel;

public partial class LoginViewModel : BaseViewModel
{
    [ObservableProperty]
    private string username;
}
using pcso_jk.View;

namespace pcso_jk;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
        Shell.Current.GoToAsync("//Login");
    }
}
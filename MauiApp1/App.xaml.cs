namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		Application.Current.UserAppTheme = AppTheme.Light;

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        var window = base.CreateWindow(activationState);
        if (window != null)
        {
            window.Title = "elBarto Task List";
        }

        return window;
    }
}

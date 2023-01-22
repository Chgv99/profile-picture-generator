using MetroLog;
using Microsoft.Extensions.Logging;

namespace MauiApp1;

public partial class App : Application
{
    #region FIELDS
    string name = "Task List Manager";
    #endregion

    public string Name { get => name; }

    public const int WindowWidth = 600;
    public const int WindowHeight = 600;

    ILogger<App> logger;

    public App(ILogger<App> logger)
	{
		InitializeComponent();
        this.logger = logger;

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        var window = base.CreateWindow(activationState);

        const int newWidth = WindowWidth;
        const int newHeight = WindowHeight;

        logger.LogInformation("Width: " + Microsoft.Maui.Devices.DeviceDisplay.MainDisplayInfo.Width);
        window.X = Microsoft.Maui.Devices.DeviceDisplay.MainDisplayInfo.Width / 2;
        window.Y = Microsoft.Maui.Devices.DeviceDisplay.MainDisplayInfo.Height / 2;

        window.Title = name;

        window.Width = newWidth;
        window.Height = newHeight;

        //SetWinNoResizable();
        window.MinimumHeight = newHeight;
        window.MinimumWidth = newHeight;

        window.MaximumHeight = newHeight;
        window.MaximumWidth = newHeight;

        return window;
    }
}

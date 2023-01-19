namespace MauiApp1;

public partial class App : Application
{
    private string name = "Task List Manager";

    public string Name { get => name; }

    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
		var window = base.CreateWindow(activationState);

		const int newWidth = 600;
        const int newHeight = 600;

		window.X = 0;
        window.Y = 0;

		window.Title = Name;

		window.Width = newWidth;
		window.Height = newHeight;

        //SetWinNoResizable();
		window.MinimumHeight = newHeight;
        window.MinimumWidth = newHeight;

        window.MaximumHeight = newHeight;
        window.MaximumWidth = newHeight;

        return window;
    }

    /*public void SetWinNoResizable()
    {
        Microsoft.Maui.Handlers.WindowHandler.Mapper
            .AppendToMapping(nameof(IWindow),
            (handler, view) => 
        {
#if WINDOWS
            var nativeWindow = handler.PlatformView;
            IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
            WindowId WindowId = Win32Interop.GetWindowIdFromWindow(windowHandle);
            AppWindow appWindow = AppWindow.GetFromWindowId(WindowId);
            var presenter = appWindow.Presenter as OverlappedPresenter;
            presenter.IsResizable = false;
#endif
        });
    }*/
}

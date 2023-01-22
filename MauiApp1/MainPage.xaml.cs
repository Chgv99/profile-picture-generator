using MetroLog;
using Microsoft.Extensions.Logging;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	ILogger<MainPage> logger;

	public MainPage(ILogger<MainPage> logger)
	{
		InitializeComponent();
		this.logger = logger;
	}

	/*private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
        logger.LogInformation("Width: " + Microsoft.Maui.Devices.DeviceDisplay.MainDisplayInfo.Width);

        if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}*/
}


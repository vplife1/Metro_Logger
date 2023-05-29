using MetroLog.Maui;
using Microsoft.Extensions.Logging;

namespace MetroLoggerPOC;

public partial class MainPage : ContentPage
{
	int count = 0;

	ILogger<MainPage> _logger;
	public MainPage(ILogger<MainPage> logger)
	{
		InitializeComponent();
		BindingContext = new LogController();
		var info = new LogController();
		_logger = logger;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";


		_logger.LogInformation($"Number of clicked Count:{count}");
		

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void CounterBtn_Clicked(object sender, EventArgs e)
    {
		
    }
}


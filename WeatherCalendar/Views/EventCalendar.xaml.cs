using WeatherCalendar.ViewModels;

namespace WeatherCalendar.Views;

public partial class EventCalendar : ContentPage
{
	public EventCalendar()
	{
            InitializeComponent();
            BindingContext = new EventCalendarExampleViewModel();
	}
}
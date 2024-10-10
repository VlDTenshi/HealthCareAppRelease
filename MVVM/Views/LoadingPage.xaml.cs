namespace HealthCare.MVVM.Views;

public partial class LoadingPage : ContentPage
{
	public LoadingPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        //Wait for 5 sec to navigate to another page
        await Task.Delay(5000);


        //Go to the new page
        await Navigation.PushAsync(new MainPage());

        //Delete current page from the stack pf navigation
        Navigation.RemovePage(this);
    }
}
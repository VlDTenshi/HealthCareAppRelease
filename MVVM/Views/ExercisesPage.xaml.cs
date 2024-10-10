using HealthCare.MVVM.ViewModels;

namespace HealthCare.MVVM.Views;

public partial class ExercisesPage : ContentPage
{
	public ExercisesViewModel _viewModel;
	public ExercisesPage(ExercisesViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		this.BindingContext = viewModel;
	}

    protected override void OnAppearing()
    {
		base.OnAppearing();
		{
			_viewModel.GetExercisesListCommand.Execute(null);
		}
    }
}
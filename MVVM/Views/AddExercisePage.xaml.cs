using HealthCare.MVVM.ViewModels;

namespace HealthCare.MVVM.Views;

public partial class AddExercisePage : ContentPage
{
	public AddExercisePage(AddExerciseViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}
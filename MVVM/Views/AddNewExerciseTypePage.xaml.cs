using HealthCare.MVVM.ViewModels;

namespace HealthCare.MVVM.Views;

public partial class AddNewExerciseTypePage : ContentPage
{
	public AddNewExerciseTypeViewModel viewModel;
	public AddNewExerciseTypePage(AddNewExerciseTypeViewModel model)
	{
		InitializeComponent();
		this.BindingContext = viewModel = model;
	}
}
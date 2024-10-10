using HealthCare.MVVM.ViewModels;

namespace HealthCare.MVVM.Views;

public partial class ExerciseLocationTypePage : ContentPage
{
	public ExerciseLocationTypeViewModel viewModel;
	public ExerciseLocationTypePage(ExerciseLocationTypeViewModel model)
	{
		InitializeComponent();
		this.BindingContext = viewModel = model;
	}
}
using HealthCare.MVVM.ViewModels;

namespace HealthCare.MVVM.Views;

public partial class ExerciseTypePage : ContentPage
{
	private ExerciseTypeViewModel viewModel;
	public ExerciseTypePage(ExerciseTypeViewModel model)
	{
		InitializeComponent();
		this.BindingContext = viewModel = model;
	}
}
using HealthCare.MVVM.ViewModels;

namespace HealthCare.MVVM.Views;

public partial class AddNewExerciseLocationTypePage : ContentPage
{
    public AddNewExerciseLocationTypeViewModel viewModel;
    public AddNewExerciseLocationTypePage(AddNewExerciseLocationTypeViewModel model)
	{
		InitializeComponent();
		this.BindingContext = model = viewModel;
	}
}
using CommunityToolkit.Maui;
using HealthCare.DbContext;
using HealthCare.MVVM.ViewModels;
using HealthCare.MVVM.Views;
using HealthCare.Services;
using Microsoft.Extensions.Logging;

namespace HealthCare
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            //Services
            builder.Services.AddSingleton<ApplicationDbContext>();
            builder.Services.AddSingleton<IExerciseService, ExerciseService>();

            //Views
            builder.Services.AddSingleton<ExercisesPage>();
            builder.Services.AddTransient<AddExercisePage>();
            builder.Services.AddTransient<ExerciseTypePage>();
            builder.Services.AddTransient<AddNewExerciseTypePage>();
            builder.Services.AddTransient<ExerciseLocationTypePage>();
            builder.Services.AddTransient<AddNewExerciseLocationTypePage>();

            //ViewModels
            builder.Services.AddSingleton<ExercisesViewModel>();
            builder.Services.AddTransient<AddExerciseViewModel>();
            builder.Services.AddTransient<ExerciseTypeViewModel>();
            builder.Services.AddTransient<AddNewExerciseTypeViewModel>();
            builder.Services.AddTransient<ExerciseLocationTypeViewModel>();
            builder.Services.AddTransient<AddNewExerciseLocationTypeViewModel>();

            return builder.Build();
        }
    }
}

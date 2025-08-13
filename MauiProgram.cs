using Microsoft.Extensions.Logging;

namespace ProjetoSorveteria
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Inter_18pt-Bold.ttf", "InterBold");
                    fonts.AddFont("Inter_18pt-Regular.ttf", "Inter");
                    fonts.AddFont("Inter_18pt-SemiBold.ttf", "InterSemiBold");
                    fonts.AddFont("SourceCodePro-Bold.ttf", "SourceBold");
                    fonts.AddFont("SourceCodePro-Regular.ttf", "Source");
                    fonts.AddFont("SourceCodePro-SemiBold.ttf", "SourceSemiBold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

﻿using Microsoft.Extensions.Logging;

namespace Spotiffyy;

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
                fonts.AddFont("MaterialIconsOutlined-Regular.otf", "MaterialOutlined");
                fonts.AddFont("MaterialIconsRound-Regular.otf", "MaterialRound");
                fonts.AddFont("MaterialIconsSharp-Regular.otf", "MaterialSharp");
                fonts.AddFont("MaterialIconsTwoTone-Regular.otf", "MaterialTwoTone");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

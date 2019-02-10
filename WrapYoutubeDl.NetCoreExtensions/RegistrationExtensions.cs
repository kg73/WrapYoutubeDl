using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace WrapYoutubeDl.NetCoreExtensions
{
	public static class RegistrationExtensions
	{
		public static IServiceCollection AddYoutubeAudioDownloader(this IServiceCollection services, Action<YoutubeAudioDownloaderOptions> options)
		{
			services.Configure<YoutubeAudioDownloaderOptions>(options);
			services.AddTransient<YoutubeAudioDownloader>();
			return services;
		}
	}
}

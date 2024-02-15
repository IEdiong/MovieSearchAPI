using System;
namespace MovieSearchAPI.Extensions
{
	public static class ServiceExtensions
	{
		public static void ConfigureCors(this IServiceCollection services)
		{
			services.AddCors(options =>
			{
				options.AddPolicy("CorsPolicy", builder =>
				builder.WithOrigins("https://movie-search-je.vercel.app")
				.WithMethods("GET")
				.AllowAnyHeader());
			});
		}
	}
}


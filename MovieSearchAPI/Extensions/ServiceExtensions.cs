using System;
namespace MovieSearchAPI.Extensions
{
	public static class ServiceExtensions
	{
		public static void ConfigureCors(this IServiceCollection services)
		{
			services.AddCors(options =>
			{
				options.AddPolicy("AllowMyLocalhost", builder =>
				builder.WithOrigins("http://localhost:3000")
				.WithMethods("GET")
				.AllowAnyHeader());

				options.AddPolicy("AllowMyLiveApp", builder =>
				builder.WithOrigins("https://movie-search-je.vercel.app")
				.WithMethods("GET")
				.AllowAnyHeader());
			});
        }
	}
}


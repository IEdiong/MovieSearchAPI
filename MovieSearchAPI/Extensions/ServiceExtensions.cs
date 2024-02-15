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
				builder.AllowAnyOrigin()
				.WithMethods("GET")
				.AllowAnyHeader());
			});
		}
	}
}


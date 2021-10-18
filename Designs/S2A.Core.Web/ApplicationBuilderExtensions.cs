﻿using Microsoft.AspNetCore.Builder;

namespace S2A.Core.Web
{
    /// <summary>
    /// Extensions for <see cref="IApplicationBuilder"/>
    /// </summary>
    public static class ApplicationBuilderExtensions
    {
        /// <summary>
        /// Builds the Framework Construct and sets the Framework.Provider from the <see cref="IApplicationBuilder"/>
        /// </summary>
        /// <param name="app">The application builder</param>
        /// <returns></returns>
        public static IApplicationBuilder UseFramework(this IApplicationBuilder app)
        {
            // Build the framework as at this point we know the provider is available
            Framework.Construction.Build(app.ApplicationServices);

            // Return app for chaining
            return app;
        }
    }
}

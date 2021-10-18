﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace S2A.Core
{
    /// <summary>
    /// The core services that could be available in the Framework
    /// for quick and easy access anywhere in code.
    /// </summary>
    /// <example>
    /// <code>
    ///     using static S2A.FrameworkDI
    ///     
    ///     Logger.Log(Configuration["something"]);
    /// </code>
    /// </example>
    public static class FrameworkDI
    {
        /// <summary>
        /// Gets the configuration
        /// </summary>
        public static IConfiguration Configuration => Framework.Provider?.GetService<IConfiguration>();

        /// <summary>
        /// Gets the default logger
        /// </summary>
        public static ILogger Logger => Framework.Provider?.GetService<ILogger>();

        /// <summary>
        /// Gets the logger factory for creating loggers
        /// </summary>
        public static ILoggerFactory LoggerFactory => Framework.Provider?.GetService<ILoggerFactory>();

        /// <summary>
        /// Gets the framework environment
        /// </summary>
        public static IFrameworkEnvironment FrameworkEnvironment => Framework.Provider?.GetService<IFrameworkEnvironment>();

        /// <summary>
        /// Gets the framework exception handler
        /// </summary>
        public static IErrorHandler ExceptionHandler => Framework.Provider?.GetService<IErrorHandler>();
    }

}

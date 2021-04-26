using Microsoft.AspNetCore.Builder;
using Sknowed.PublicApi.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sknowed.PublicApi.Extensions
{
    public static class MiddlewareRegistration
    {
        public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<ExceptionHandlerMiddleware>();
            return builder;
        }
    }
}

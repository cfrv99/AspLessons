using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreLesson.Middlewares.Middlewares
{
    public class MyCustomMiddleware
    {
        private readonly RequestDelegate next;

        public MyCustomMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if(context.Request.Path.Value == "/sikfiqar")
            {
                await next(context);
            }
            else
            {
                context.Response.StatusCode = 404;
            }
        }
    }
}

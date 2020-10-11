using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace pizza.Custom
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            Console.WriteLine("/!\\ WARNING!! " + context.Exception);
            context.HttpContext.Response.StatusCode = 500;
            context.Exception = null;

            base.OnException(context);
        }
    }
}
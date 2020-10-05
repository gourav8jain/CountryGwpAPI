using System;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CountryGwpAPI.Controllers
{
    [ApiController]
    public class ErrorController : ControllerBase
    {
        private readonly ILogger<ErrorController> _logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            _logger = logger;
        }

        [HttpPost("/error-local-development")]
        public IActionResult ErrorLocalDevelopment(
            [FromServices] IWebHostEnvironment webHostEnvironment)
        {
            if (webHostEnvironment.EnvironmentName != "Development")
            {
                throw new InvalidOperationException(
                    "This shouldn't be invoked in non-development environments.");
            }

            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();

            _logger.LogError(context.Error.Message);
            _logger.LogError(context.Error.StackTrace);

            if (context.Error.GetType().Name == "ApiException")
            {
                return Problem(
                    detail: context.Error.StackTrace,
                    title: context.Error.Message,
                    statusCode: (int?)((Exception_Handling.ApiException)context.Error).StatusCode);
            }

            return Problem(
                detail: context.Error.StackTrace,
                title: context.Error.Message);

        }

        [HttpPost("/error")]
        public IActionResult Error()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();

            _logger.LogError(context.Error.Message);
            _logger.LogError(context.Error.StackTrace);

            if (context.Error.GetType().Name == "ApiException")
            {
                return Problem(
                    detail: context.Error.StackTrace,
                    title: context.Error.Message,
                    statusCode: (int?)((Exception_Handling.ApiException)context.Error).StatusCode);
            }

            return Problem(
                detail: context.Error.StackTrace,
                title: context.Error.Message);


        }
    }
}

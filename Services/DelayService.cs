using BlazorApp.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class DelayService : IAsyncActionFilter
    {
        private int _delayInMs;
        public DelayService(IConfiguration configuration)
        {
            _delayInMs = configuration.GetValue<int>("ApiDelayDuration", 0);
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await Task.Delay(_delayInMs);
        }

    }
}

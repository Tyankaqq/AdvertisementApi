using AdvertisementApi.Models;
using Lab3.Models;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Lab3
{
    public class TestMiddleware
    {
        private readonly RequestDelegate _nextDelegate;

        public TestMiddleware(RequestDelegate next)
        {
            _nextDelegate = next;
        }

        public async Task Invoke(HttpContext context, AdvertisementContext dataContext)
        {
            if (context.Request.Path == "/test")
            {
                await context.Response.WriteAsync($"There are {dataContext.Broadcasts.Count()} broadcasts\n");
                await context.Response.WriteAsync($"There are {dataContext.AdvertisementOrders.Count()} advertisement orders\n");
            }
            else
            {
                await _nextDelegate(context);
            }
        }
    }
}

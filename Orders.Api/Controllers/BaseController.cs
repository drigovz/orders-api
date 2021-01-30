using System;
using Microsoft.AspNetCore.Mvc;

namespace Orders.Api.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IServiceProvider _serviceProvider;

        public BaseController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
    }
}

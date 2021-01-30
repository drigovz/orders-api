using System;
using Microsoft.AspNetCore.Mvc;

namespace Orders.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class OrdersController : BaseController
    {
        public OrdersController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace NextDotNetApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthyController : ControllerBase
    {
        private readonly ILogger<HealthyController> _logger;

        public HealthyController(ILogger<HealthyController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetHealthStatus")]
        public IActionResult Get()
        {
            var response = new
            {
                Status = "Success",
                Timestamp = DateTime.UtcNow,
                Service = "NextDotNetApi",
                Version = "1.0.0",
                Message = "API is healthy and running"
            };

            return Ok(response);
        }
    }
}

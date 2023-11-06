using Dependency_Injection_Demo.Services.AddScoped;
using Dependency_Injection_Demo.Services.AddSingleton;
using Dependency_Injection_Demo.Services.AddTransient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //private readonly IMyService _transientService;
       // private readonly IMyService _scopedService;
       // private readonly ILogger<ValuesController> _logger;
        private readonly ISingletonService _singletonService;
        private readonly ISingletonService _singletonService1;

        // private readonly ITransientService _transientService;
        // private readonly IScopedService _scopedService;

        public ValuesController(
            ISingletonService singletonService, ISingletonService singletonService1)
        {
            //_logger = logger;
            _singletonService = singletonService;
            _singletonService1 = singletonService1;
            // _transientService = transientService;
            // _scopedService = scopedService;
            //_transientService = transientService;
            //_scopedService = scopedService;
        }

        [HttpPost]
        public IActionResult Post()
        {
            _singletonService.Insert($"new data {new Random().Next()}");
            var lst = _singletonService1.GetList();
            return Ok(lst);
        }
    }
    
}

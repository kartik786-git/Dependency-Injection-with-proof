using Dependency_Injection_Demo.Services.AddScoped;
using Dependency_Injection_Demo.Services.AddSingleton;
using Dependency_Injection_Demo.Services.AddTransient;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISingletonService singletonService;
        private readonly ITransientService transientService;
        private readonly IScopedService scopedService;


        public HomeController(ILogger<HomeController> logger)
            //ISingletonService singletonService, 
            //ITransientService transientService, 
            //IScopedService scopedService)
        {
            _logger = logger;
            //this.singletonService = singletonService;
            //this.transientService = transientService;
            //this.scopedService = scopedService;
        }

        public IActionResult Index()
        {
            //Guid sing_instanceId = singletonService.GetInstanceId();
            //ViewBag.sing_instanceId = sing_instanceId;
            //_logger.LogWarning($"sing_instanceId : {sing_instanceId}");
            //Guid tran_instanceId = transientService.GetInstanceId();
            //ViewBag.tran_instanceId = tran_instanceId;
            //_logger.LogWarning($"tran_instanceId : {tran_instanceId}");
           // Guid scope_instanceId = scopedService.GetInstanceId();
           // _logger.LogWarning($"scope_instanceId : {scope_instanceId}");
           // ViewBag.scope_instanceId = scope_instanceId;

            return View();
        }

        public IActionResult Privacy()
        {
            Guid sing_instanceId = singletonService.GetInstanceId();
            _logger.LogWarning($"sing_instanceId : {sing_instanceId}");

            Guid tran_instanceId = transientService.GetInstanceId();
            _logger.LogWarning($"tran_instanceId : {tran_instanceId}");

            Guid scope_instanceId = scopedService.GetInstanceId();
            _logger.LogWarning($"scope_instanceId : {scope_instanceId}");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Dependency_Injection_Demo.Model;
using Dependency_Injection_Demo.Services.AddScoped;
using Dependency_Injection_Demo.Services.AddSingleton;
using Dependency_Injection_Demo.Services.AddTransient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata;

namespace Dependency_Injection_Demo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly ISingletonService singletonService;
        private readonly ITransientService transientService;
        private readonly IScopedService scopedService;

        public IndexModel(ILogger<IndexModel> logger, 
            ISingletonService singletonService, 
            ITransientService transientService, 
            IScopedService scopedService)
        {
            _logger = logger;
            this.singletonService = singletonService;
            this.transientService = transientService;
            this.scopedService = scopedService;
            
        }

        [BindProperty]
        public List<DIViewModel> DIViewModels { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            Guid sing_instanceId = singletonService.GetInstanceId();
            _logger.LogWarning($"sing_instanceId : {sing_instanceId = sing_instanceId}");
            DIViewModels.Add(new DIViewModel
            {
                instanceCreateId = sing_instanceId,
                instanceName = "AddSingleton instance",
                listCount = singletonService.GetList().Count,
                Lists = singletonService.GetList()
                
            });
            Guid tran_instanceId = transientService.GetInstanceId();
            _logger.LogWarning($"tran_instanceId : {tran_instanceId}");
            DIViewModels.Add(new DIViewModel
            {
                instanceCreateId = tran_instanceId,
                instanceName = "AddTransient instance",
                listCount = transientService.GetList().Count,
                Lists = transientService.GetList()

            });
            Guid scope_instanceId = scopedService.GetInstanceId();
            _logger.LogWarning($"scope_instanceId : {scope_instanceId}");

            DIViewModels.Add(new DIViewModel
            {
                instanceCreateId = scope_instanceId,
                instanceName = "AddScoped instance",
                listCount = scopedService.GetList().Count,
                Lists = scopedService.GetList()

            });

            singletonService.Insert("add data for AddSingleton");
            transientService.Insert("add data for AddTransient");
            scopedService.Insert("add data AddScoped");

            return Page();
        }
    }
}

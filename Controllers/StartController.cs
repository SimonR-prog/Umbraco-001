using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common.Controllers;

namespace Umbraco_001.Controllers;

public class StartController : RenderController
{
    public StartController(ILogger<RenderController> logger) 
    { 
        
    }

    public override IActionResult Index()
    {
        return View();
    }
}

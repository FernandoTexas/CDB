using Microsoft.AspNetCore.Mvc;
using Application.Services;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Domain;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CdbController : ControllerBase
    {
        private readonly ICdbAppService _cdbAppService;

        public CdbController(ICdbAppService cdbAppService)
        {
            _cdbAppService = cdbAppService;
        }

        [HttpGet]        
        [Route("cdb")]
        public async Task<IActionResult> Index([FromQuery] CdbViweModel cdb)
        {

            var resultadoCDB = await _cdbAppService.CalculaCDB(cdb);
            return Ok(resultadoCDB);            
        }
    }
}

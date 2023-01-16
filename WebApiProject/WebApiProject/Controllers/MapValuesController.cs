using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiProject.Model;
using WebApiProject.Model.Context;

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapValuesController : ControllerBase
    {
        private readonly ProjectDBContext _dbContext;

        public MapValuesController(ProjectDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssetsDetail>>> GetAssetsDetail()
        {
            if (_dbContext.AssetsDetail == null)
            {
                return NotFound();
            }
            return await _dbContext.AssetsDetail.ToListAsync();
        }
    }
}

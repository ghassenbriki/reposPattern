using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using reposPattern.Entities;
using reposPattern.Interfaces;
using reposPattern.UnitOfWork;

namespace reposPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeveloperController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

       /* public IActionResult GetPopularDevelopers([FromQuery] int count)
        {
            var popularDevelopers = _unitOfWork.Developers.GetPopularDevelopers(count);
            return Ok(popularDevelopers);
        }*/

        [HttpPost]
        public IActionResult AddDeveloperAndProject()
        {
            var developer = new Developer
            {
                Followers = 35,
                Name = "Ghassen Briki"
            };
            var project = new Project
            {
                Name = "Dotnet project"
            };
            _unitOfWork.Developers.Add(developer);
            _unitOfWork.Projects.Add(project);
            _unitOfWork.Complete();
            return Ok();
        }
    }

   
}

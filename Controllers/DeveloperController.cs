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

       

        [HttpPost]
        public IActionResult AddDeveloper()
        {
            var developer = new Developer
            {
                Followers = 35,
                Name = "Ghassen Briki"
            };
            /*var project = new Project
            {
                Name = "Dotnet project"
            };
            */
            _unitOfWork.Developers.Add(developer);
            //_unitOfWork.Projects.Add(project);

            /*var obj = _unitOfWork.Developers.Find(e => e.Name == "Ghassen Briki");
            foreach (Developer o in obj)
                {
                Console.WriteLine(o.Name);
            }*/
            _unitOfWork.Complete();
            _unitOfWork.Dispose();
            return Ok();
        }
    }

   
}

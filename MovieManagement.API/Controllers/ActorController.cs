using Microsoft.AspNetCore.Mvc;
using MovieManagement.Domain.Repository;

namespace MovieManagement.API.Controllers
{
    [Route("api/actors")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        readonly IUnitOfWork _unitOfWork;
        public ActorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var listOfActor = _unitOfWork.Actor.GetAll();
            return Ok(listOfActor);
        }

        [HttpGet("movies")]
        public IActionResult GetWithMovies()
        {
            var actorRepo = _unitOfWork.Actor.GetActorsWithMovies().ToList();
            return Ok(actorRepo);
        } 

        [HttpDelete("actor/{actorId}")] 
        public IActionResult Remove(int actorId)
        {
            return Ok(_unitOfWork.Actor.Remove(actorId));
        }

        [HttpGet("{actorId}")]
        public IActionResult Get(int actorId)
        {
            return Ok(_unitOfWork.Actor.GetById(actorId));
        }

    }
}
 
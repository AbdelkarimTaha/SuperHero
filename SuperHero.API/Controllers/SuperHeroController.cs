using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SuperHero.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<SuperHero>> GetSuperHeroes()
        {
            return new List<SuperHero>
            {
                new SuperHero()
                {
                    Id = 1,
                    FirstName = "kareem",
                    LastName = "Taha",
                    Place = "Shoubra"
                },
                new SuperHero()
                {
                    Id = 2,
                    FirstName = "Israa",
                    LastName = "Said",
                    Place = "Shoubra"
                }
            };
        }
    }
}

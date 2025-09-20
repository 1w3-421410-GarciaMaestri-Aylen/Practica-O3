using Microsoft.AspNetCore.Mvc;
using ParcialWebApi.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParcialWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudController : ControllerBase
    {
        private readonly ISolicitudRepository _Irepository;
        public SolicitudController(ISolicitudRepository Irepository)
        {
            _Irepository = Irepository;
        }
        // GET: api/<SolicitudController>
        [HttpGet]
        public IActionResult Get()
        {
           
        }

        // GET api/<SolicitudController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SolicitudController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SolicitudController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /* DELETE api/<SolicitudController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        } */
    }
}

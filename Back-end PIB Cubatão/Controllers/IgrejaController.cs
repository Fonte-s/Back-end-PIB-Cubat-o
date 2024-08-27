using Back_end_PIB_Cubatão.Context;
using Back_end_PIB_Cubatão.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Back_end_PIB_Cubatão.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IgrejaController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;

        public IgrejaController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;

        }
        [HttpGet("{id:int}", Name = "BuscarIgreja")]
        [Authorize]
        public ActionResult<Igreja> Get(int id)
        {
            var igreja = _context.Igrejas.FirstOrDefault(p => p.IgrejaID == id);
            if (igreja == null)
            {
                return NotFound("Igreja Não Encontrada.....");
            }
            return Ok(igreja);
        }

        [HttpPut("{id:int}", Name = "IncluirUmaIgreja")]
        public ActionResult Put(int id, Igreja igreja)
        {
            if (id != igreja.IgrejaID)
            {
                return BadRequest();
            }

            _context.Entry(igreja).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Ok(igreja);
        }


        [HttpDelete("{id:int}", Name = "DeletarUmaIgreja")]

        public ActionResult Delete(int id)
        {
            var igreja = _context.Igrejas.FirstOrDefault(c => c.IgrejaID == id);

            if (igreja is null)
            {
                return NotFound("Igreja não localizada....");
            }
            _context.Igrejas.Remove(igreja);
            _context.SaveChanges();

            return Ok(igreja);
        }
    }
    }

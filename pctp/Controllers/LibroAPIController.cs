using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using pctp.Models.Dto;
using prova999.Logging;

namespace pctp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroAPIController : ControllerBase
    {
        private readonly ILogging _logger;
        public LibroAPIController(ILogging logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<LibroDTO>> GetLibros()
        {
            _logger.Log("Getting all libros", "");
            return Ok(LibroStore.libroList);
        }

        [HttpGet("{id:int}", Name = "GetLibro")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<LibroDTO> GetLibro(int id)
        {
            if (id == 0)
            {
                _logger.Log("Get Libro Error with Id" + id, "error");
                return BadRequest();
            }

            var libro = LibroStore.libroList.FirstOrDefault(u => u.Id == id);
            if (libro == null)
            {
                return NotFound();
            }

            return Ok(libro);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<LibroDTO> CreateLibro([FromBody] LibroDTO libroDTO)
        {
            if (LibroStore.libroList.Any(u => u.Name.ToLower() == libroDTO.Name.ToLower()))
            {
                ModelState.AddModelError("", "Libro already exists!");
                return BadRequest(ModelState);
            }

            if (libroDTO == null)
            {
                return BadRequest(libroDTO);
            }
            if (libroDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            var newId = (LibroStore.libroList.OrderByDescending(u => u.Id).FirstOrDefault()?.Id ?? 0) + 1;
            libroDTO.Id = newId;
            LibroStore.libroList.Add(libroDTO);

            return CreatedAtRoute("GetLibro", new { id = libroDTO.Id }, libroDTO);
        }

        [HttpDelete("{id:int}", Name = "DeleteLibro")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteLibro(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var libro = LibroStore.libroList.FirstOrDefault(u => u.Id == id);
            if (libro == null)
            {
                return NotFound();
            }
            LibroStore.libroList.Remove(libro);
            return NoContent();
        }

        [HttpPut("{id:int}", Name = "UpdateLibro")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateLibro(int id, [FromBody] LibroDTO libroDTO)
        {
            if (libroDTO == null || id != libroDTO.Id)
            {
                return BadRequest();
            }
            var libro = LibroStore.libroList.FirstOrDefault(u => u.Id == id);
            if (libro == null)
            {
                return NotFound();
            }

            libro.Name = libroDTO.Name;
            libro.Sqft = libroDTO.Sqft;
            libro.Occupancy = libroDTO.Occupancy;

            return NoContent();
        }

        [HttpPatch("{id:int}", Name = "UpdatePartialLibro")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdatePartialLibro(int id, [FromBody] JsonPatchDocument<LibroDTO> patchDTO)
        {
            if (patchDTO == null || id <= 0)
            {
                return BadRequest();
            }
            var libro = LibroStore.libroList.FirstOrDefault(u => u.Id == id);
            if (libro == null)
            {
                return NotFound();
            }

            var libroToPatch = new LibroDTO
            {
                Id = libro.Id,
                Name = libro.Name,
                Sqft = libro.Sqft,
                Occupancy = libro.Occupancy
            };

            patchDTO.ApplyTo(libroToPatch, ModelState);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            libro.Name = libroToPatch.Name;
            libro.Sqft = libroToPatch.Sqft;
            libro.Occupancy = libroToPatch.Occupancy;

            return NoContent();
        }
    }
}

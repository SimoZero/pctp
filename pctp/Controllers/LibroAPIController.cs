using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using pctp.Models;
using pctp.Models.Dto;
using pctp.Data;
using prova999.Logging;
using System.Collections.Generic;
using System.Linq;

namespace pctp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroAPIController : ControllerBase
    {
        private readonly ILogging _logger;
        private readonly ApplicationDbContext _context;

        public LibroAPIController(ILogging logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<LibroDTO>> GetLibros()
        {
            _logger.Log("Getting all libros", "");
            var libros = _context.Libri.ToList();
            var libroDTOs = libros.Select(libro => new LibroDTO
            {
                Isbn = libro.Isbn,
                Titolo = libro.Titolo,
                Img = libro.Img,
                Autore = libro.Autore,
                Genere = libro.Genere,
                Anno = libro.Anno
            });

            return Ok(libroDTOs);
        }

        [HttpGet("{isbn}", Name = "GetLibro")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<LibroDTO> GetLibro(string isbn)
        {
            if (string.IsNullOrEmpty(isbn))
            {
                _logger.Log("Get Libro Error with Isbn " + isbn, "error");
                return BadRequest();
            }

            var libro = _context.Libri.FirstOrDefault(u => u.Isbn == isbn);
            if (libro == null)
            {
                return NotFound();
            }

            var libroDTO = new LibroDTO
            {
                Isbn = libro.Isbn,
                Titolo = libro.Titolo,
                Img = libro.Img,
                Autore = libro.Autore,
                Genere = libro.Genere,
                Anno = libro.Anno
            };

            return Ok(libroDTO);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<LibroDTO> CreateLibro([FromBody] LibroDTO libroDTO)
        {
            if (libroDTO == null)
            {
                return BadRequest(libroDTO);
            }

            var libro = new Libro
            {
                Isbn = libroDTO.Isbn,
                Titolo = libroDTO.Titolo,
                Img = libroDTO.Img,
                Autore = libroDTO.Autore,
                Genere = libroDTO.Genere,
                Anno = libroDTO.Anno
            };

            _context.Libri.Add(libro);
            _context.SaveChanges();

            return CreatedAtRoute("GetLibro", new { isbn = libroDTO.Isbn }, libroDTO);
        }

        [HttpDelete("{isbn}", Name = "DeleteLibro")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteLibro(string isbn)
        {
            if (string.IsNullOrEmpty(isbn))
            {
                return BadRequest();
            }

            var libro = _context.Libri.FirstOrDefault(u => u.Isbn == isbn);
            if (libro == null)
            {
                return NotFound();
            }

            _context.Libri.Remove(libro);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPut("{isbn}", Name = "UpdateLibro")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateLibro(string isbn, [FromBody] LibroDTO libroDTO)
        {
            if (libroDTO == null || isbn != libroDTO.Isbn)
            {
                return BadRequest();
            }

            var libro = _context.Libri.FirstOrDefault(u => u.Isbn == isbn);
            if (libro == null)
            {
                return NotFound();
            }

            libro.Titolo = libroDTO.Titolo;
            libro.Img = libroDTO.Img;
            libro.Autore = libroDTO.Autore;
            libro.Genere = libroDTO.Genere;
            libro.Anno = libroDTO.Anno;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpPatch("{isbn}", Name = "UpdatePartialLibro")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdatePartialLibro(string isbn, [FromBody] JsonPatchDocument<LibroDTO> patchDTO)
        {
            if (patchDTO == null || string.IsNullOrEmpty(isbn))
            {
                return BadRequest();
            }

            var libro = _context.Libri.FirstOrDefault(u => u.Isbn == isbn);
            if (libro == null)
            {
                return NotFound();
            }

            var libroToPatch = new LibroDTO
            {
                Isbn = libro.Isbn,
                Titolo = libro.Titolo,
                Img = libro.Img,
                Autore = libro.Autore,
                Genere = libro.Genere,
                Anno = libro.Anno
            };

            patchDTO.ApplyTo(libroToPatch, ModelState);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            libro.Titolo = libroToPatch.Titolo;
            libro.Img = libroToPatch.Img;
            libro.Autore = libroToPatch.Autore;
            libro.Genere = libroToPatch.Genere;
            libro.Anno = libroToPatch.Anno;

            _context.SaveChanges();

            return NoContent();
        }
    }
}

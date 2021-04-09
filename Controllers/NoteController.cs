using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NoteCloud.Entities;
using NoteCloud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteCloud.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : Controller
    {
        private readonly NoteCloudContext noteCloudContext;
        private readonly IMapper noteMapper;

        public NoteController(NoteCloudContext noteCloudContext, IMapper noteMapper)
        {
            this.noteCloudContext = noteCloudContext;
            this.noteMapper = noteMapper;
        }

        [HttpGet]
        public ActionResult<List<NoteDto>> Get()
        {
            var notes = noteCloudContext.Notes.ToList();
            var notesDto = noteMapper.Map<List<Note>,List<NoteDto>>(notes);

            return Ok(notesDto);
        }

        [HttpGet("Edit")]
        public ActionResult Edit([FromQuery] int id)
        {
            return Ok($"Edit: {id}");
        }

        [HttpGet("Details")]
        public ActionResult Details([FromQuery] int id)
        {
            return Ok($"Details: {id}");
        }

        [HttpGet("Delete")]
        public ActionResult Delete([FromQuery] int id)
        {
            return Ok($"Delete: {id}");
        }

        [HttpGet("Create")]
        public ActionResult Create([FromQuery] int id)
        {
            return Ok($"Create: {id}");
        }

        [HttpGet("show")]
        public IActionResult Show()
        {
            return View(noteCloudContext.Notes.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<NoteDto> Get(int id)
        {
            var note = noteCloudContext.Notes.FirstOrDefault<Note>(n => n.Id == id);

            if (note == null)
            {
                return NotFound("Not found.");
            }

            var noteDto = noteMapper.Map<Note, NoteDto>(note);

            return Ok(noteDto);
        }

        [HttpPost]
        public ActionResult Post([FromBody] NoteDto noteDto)
        {
            var note = noteMapper.Map<NoteDto, Note>(noteDto);

            noteCloudContext.Notes.Add(note);
            noteCloudContext.SaveChanges();

            return Created($"note/{note.Id}", null);
        }
    }
}

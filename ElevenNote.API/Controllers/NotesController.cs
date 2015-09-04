using ElevenNote.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace ElevenNote.API.Controllers
{
    [Authorize]
    public class NotesController : ApiController
    {   
        /// <summary>
        /// Gets all the notes for the current user.
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetNotes()
        {
            var services = new NoteService();
            var userId = User.Identity.GetUserId();
            var notes = services.GetAllForUser(Guid.Parse(userId));

            return Ok(notes);
        }
    }
}

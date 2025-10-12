using DatingApp.Data;
using DatingApp.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace DatingApp.Controllers
{
    [Authorize]
    public class MembersController : BaseApiController
    {
        private readonly DataContext _context;

        public MembersController(DataContext context)
        {
            _context = context;
        }

        // GET: api/members
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetMembers()
        {
            return await _context.Users.ToListAsync();
        }

        // GET: api/members/123cx
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetMember(string id)
        {
            var member = await _context.Users.FindAsync(id);

            if (member == null) return NotFound();

            return member;
        }

        }
    }


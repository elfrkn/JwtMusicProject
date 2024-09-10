using JwtMusic.Application.Interfaces.MusicInterfaces;
using JwtMusic.Domain.Entities;
using JwtMusic.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtMusic.Persistence.Repositories.MusicRepositories
{
    public class MusicRepository : IMusicRepository
    {
        private readonly JwtMusicContext _context;

        public MusicRepository(JwtMusicContext context)
        {
            _context = context;
        }

        public async Task<List<Music>> GetMusicByRoleId()
        {
            var roleId = await _context.AppUsers.Select(x => x.AppRoleId).FirstOrDefaultAsync();
            var values = await _context.Musics.Where(x => x.AppRoleId == roleId).ToListAsync();
            return values;
        }
    }
}

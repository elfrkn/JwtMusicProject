using JwtMusic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtMusic.Application.Interfaces.MusicInterfaces
{
    public interface IMusicRepository
    {
        Task<List<Music>> GetMusicByRoleId();


    }
}

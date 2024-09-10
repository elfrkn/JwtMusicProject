using JwtMusic.Application.Interfaces;
using JwtMusic.Application.Interfaces.MusicInterfaces;
using JwtMusic.Application.Mediator.Queries;
using JwtMusic.Application.Mediator.Results;
using JwtMusic.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtMusic.Application.Mediator.Handlers
{
    public class GetMusicByRoleIdQueryHandler : IRequestHandler<GetMusicByRoleIdQuery, List<GetMusicByRoleIdQueryResult>>
    {
        private readonly IMusicRepository _musicRepository;

        public GetMusicByRoleIdQueryHandler(IMusicRepository musicRepository)
        {
            _musicRepository = musicRepository;
        }

        public async Task<List<GetMusicByRoleIdQueryResult>> Handle(GetMusicByRoleIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _musicRepository.GetMusicByRoleId();
            return values.Select(x => new GetMusicByRoleIdQueryResult
            {
                AppRoleId = x.AppRoleId,
                AudioUrl = x.AudioUrl,
                ImageUrl = x.ImageUrl,
                MusicId = x.MusicId,
                MusicName = x.MusicName
            }).ToList();
        }
    }
}

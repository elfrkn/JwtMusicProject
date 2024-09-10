using JwtMusic.Application.Interfaces;
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
    public class GetMusicQueryHandler : IRequestHandler<GetMusicQuery, List<GetMusicQueryResult>>
    {
        private readonly IRepository<Music> _repository;

        public GetMusicQueryHandler(IRepository<Music> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetMusicQueryResult>> Handle(GetMusicQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetMusicQueryResult
            {
                AppRoleId = x.AppRoleId,
                MusicId = x.MusicId,
                MusicName = x.MusicName,
                AudioUrl = x.AudioUrl,
                ImageUrl = x.ImageUrl
            }).ToList();
        }
    }
}

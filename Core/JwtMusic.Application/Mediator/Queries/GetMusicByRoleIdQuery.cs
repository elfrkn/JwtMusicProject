using JwtMusic.Application.Mediator.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtMusic.Application.Mediator.Queries
{
    public class GetMusicByRoleIdQuery : IRequest<List<GetMusicByRoleIdQueryResult>>
    {
    }
}

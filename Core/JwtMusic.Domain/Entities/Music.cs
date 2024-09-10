using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtMusic.Domain.Entities
{
    public class Music
    {
        public int MusicId { get; set; }
        public string MusicName { get; set; }
        public string ImageUrl { get; set; }
        public string AudioUrl { get; set; }
        public int AppRoleId { get; set; }
        public AppRole AppRole { get; set; }

    }
}

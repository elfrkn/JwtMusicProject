namespace JwtMusic.WebUI.Dtos
{
    public class ResultMusicListDto
    {
        public int MusicId { get; set; }
        public string MusicName { get; set; }
        public string ImageUrl { get; set; }
        public string AudioUrl { get; set; }
        public int AppRoleId { get; set; }
    }
}

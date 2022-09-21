namespace RemoteDesktopButBetter.Models
{
    public class Server
    {
        public int Index { get; set; }
        public string Name { get; set; } = null!;
        public string IPAddress { get; set; } = null!;
        public string Fullname { get; set; } = null!;
    }
}

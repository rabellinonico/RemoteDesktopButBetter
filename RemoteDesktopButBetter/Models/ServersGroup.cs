namespace RemoteDesktopButBetter.Models
{
    public class ServersGroup
    {
        public int Index { get; set; }
        public string Name { get; set; } = null!;
        public List<Server> Servers { get; set; } = null!;
    }
}

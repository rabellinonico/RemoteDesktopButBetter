using RemoteDesktopButBetter.Models;
using System.Text.Json;

namespace RemoteDesktopButBetter.Helpers
{
    static class GlobalClass
    {

        private static List<ServersGroup> _aziende = new();
        private static readonly string _appdatafilepath = Path.Combine(Application.UserAppDataPath, "servers.txt");

        public static List<ServersGroup> Aziende
        {
            get { return _aziende; }
            set { _aziende = value; }
        }
        public static void AddAzienda(ServersGroup a)
        {
            if (a.Index == 0)
            {
                a.Index = Aziende.Count > 0 ? Aziende.Max(x => x.Index) + 1 : 1;
            }
            Aziende.Add(a);
            SalvaAziende();
        }
        public static void RemoveAzienda(ServersGroup a)
        {
            Aziende.Remove(a);
            SalvaAziende();
        }
        public static void AddServer(ServersGroup a, Server s)
        {
            Aziende.Remove(a);

            if (s.Index == 0)
            {
                s.Index = a.Servers.Count > 0 ? a.Servers.Max(x => x.Index) + 1 : 1;
            }

            a.Servers.Add(s);
            Aziende.Add(a);
            SalvaAziende();
        }
        public static void RemoveServer(ServersGroup a, Server s)
        {
            Aziende.Remove(a);
            a.Servers.Remove(s);
            Aziende.Add(a);
            SalvaAziende();
        }
        public static void SalvaAziende()
        {
            string jsonString = JsonSerializer.Serialize(Aziende);
            File.WriteAllText(AppDataFilePath, jsonString);
        }
        public static void LeggiAziende()
        {
            string jsonString = File.ReadAllText(AppDataFilePath);
            Aziende = JsonSerializer.Deserialize<List<ServersGroup>>(jsonString)!;
            Aziende = Aziende.OrderBy(x => x.Index).ToList();
        }
        public static string AppDataFilePath
        {
            get { return _appdatafilepath; }
        }
    }
}

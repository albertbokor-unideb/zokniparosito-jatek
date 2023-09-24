using System.Net.NetworkInformation;

namespace zokniParosito.Models
{
    public class Leaderboard
    {
        public int ID { get; set; }
        public DateTime Datum { get; set; }
        public string JatekosNev { get; set; }
        public TimeSpan RekordIdo { get; set; }
        public int PalyaID { get; set; }
    }
}

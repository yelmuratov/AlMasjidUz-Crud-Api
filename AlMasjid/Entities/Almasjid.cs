namespace AlMasjid.Entities
{
    public class Almasjid
    {
        required public int Id { get; set; }
        public string name { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Fajr { get; set; }
        public string Duhr { get; set; }
        public string Asr { get; set; }
        public string Magrib { get; set; }
        public string Isha { get; set; }
    }
}

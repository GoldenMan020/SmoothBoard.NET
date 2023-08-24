namespace SmoothBoard.NET.Models
{
    public class Opdrachtgever
    {
        public int ID { get; set; }

        public string name { get; set; }

        public string adres { get; set; }

        public int telefoonnummer { get; set; }

        public string email { get; set; }

        public DateOnly brengDatum { get; set; }



    }
}

namespace restaurantApi.Models
{
    public class Reservation
    {
        public int id { get; set; }
        public int NbreClient { get; set; }
        public string NomDuReservateur { get; set; }
        public DateTime DateTime { get; set; }
        public string email { get; set; }
    }
}

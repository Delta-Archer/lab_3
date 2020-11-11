namespace Lab_3.Models
{
    public class Mobiles
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public Companies Company { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
    }
}
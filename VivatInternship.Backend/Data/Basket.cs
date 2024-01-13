namespace VivatInternship.Backend.Data
{
    public class Basket
    {
        public long UniqueBasketId { get; set; }
        public string OwnerId { get; set; }
        public DateTimeOffset CreatedTimestamp { get; set; }
        public DateTimeOffset ModifiedTimestamp { get; set; }
        public List<Item> Items { get; set; }
        public double Total { get; set; }
    }
}

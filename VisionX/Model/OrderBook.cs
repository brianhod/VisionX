namespace VisionX.Model
{
    public class Ask
    {
        public string side { get; set; }
        public string quantity { get; set; }
        public string price { get; set; }
        public string currencyPair { get; set; }
        public int orderCount { get; set; }
    }

    public class Bid
    {
        public string side { get; set; }
        public string quantity { get; set; }
        public string price { get; set; }
        public string currencyPair { get; set; }
        public int orderCount { get; set; }
    }

    public class OrderBook
    {
        public List<Ask> Asks { get; set; }
        public List<Bid> Bids { get; set; }
        public DateTime LastChange { get; set; }
        public int SequenceNumber { get; set; }
    }
}

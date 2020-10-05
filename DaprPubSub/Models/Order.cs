namespace DaprPubSub.Models
{
    public class Order
    {
        public string Id { get; set; }
        public string Reference { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Ref: {Reference}, Prod: {Product}, Qty: {Quantity}, Price: {Price}";
        }
    }
}
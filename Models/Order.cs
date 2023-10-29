namespace ReabrProject.Models
{
    public class Order
    {
        private List<int> ShakesPrices;
        public int SumShakes;
        public Guid OrderId = Guid.NewGuid();
        public string CustomerName;
        public DateTime OrderDate;
        public Boolean Sales;
    }
}

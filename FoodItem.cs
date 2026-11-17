namespace CanteenOrdering
{
    public class FoodItem
    {
        public string Name { get; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }
        public bool IsAvailable { get; private set; }

        public FoodItem(string name, decimal price, int stockQuantity)
        {
            Name = name;
            Price = price >= 0 ? price : 0;
            StockQuantity = stockQuantity >= 0 ? stockQuantity : 0;
            IsAvailable = StockQuantity > 0;
        }

        public bool UpdateStock(int quantityChange)
        {
            int newStock = StockQuantity + quantityChange;
            if (newStock >= 0)
            {
                StockQuantity = newStock;
                IsAvailable = StockQuantity > 0;
                return true;
            }
            return false;
        }

        public bool ApplyDiscount(decimal percentage)
        {
            if (percentage >= 0 && percentage <= 100)
            {
                decimal discountAmount = Price * (percentage / 100);
                Price -= discountAmount;
                return true;
            }
            return false;
        }

        public string GetDetails()
        {
            string status = IsAvailable ? "Available" : "Not Available";
            return $"{Name} — ₱{Price:F2} — Stock: {StockQuantity} — {status}";
        }
    }
}

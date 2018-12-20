namespace DorfladenBBZW.Models
{
    public class Product
    {
        public Product(
            string id,
            string name,
            decimal specialOffer,
            decimal originalPrice,
            string imageName,
            string description)
        {
            this.Id = id;
            this.Name = name;
            this.SpecialOffer = specialOffer;
            this.OriginalPrice = originalPrice;
            this.ImageName = imageName;
            this.Description = description;
        }

        public string Id { get; }

        public string Name { get; }

        public decimal SpecialOffer { get; }

        public decimal OriginalPrice { get; }

        public string ImageName { get; }

        public string Description { get; }
    }
}
using System.Collections.Generic;
using System.Linq;
using DorfladenBBZW.Models;
using DorfladenBBZW.Transformers;

namespace DorfladenBBZW.Persistency
{
    public class ProductsPersistency
    {
        private readonly FileContentReader fileContentReader;
        private readonly FileContentToItemsTransformer toItemsTransformer;
        private readonly LineToProductTransformer toProductsTransformer;

        public ProductsPersistency()
        {
            this.fileContentReader = new FileContentReader();
            this.toItemsTransformer = new FileContentToItemsTransformer();
            this.toProductsTransformer = new LineToProductTransformer();
        }

        public IReadOnlyCollection<Product> GetAll()
        {
            var fileContent = this.fileContentReader.ReadFromAppData("products.csv");
            var items = this.toItemsTransformer.Transform(fileContent);
            var products = this.toProductsTransformer.Transform(items);

            return products.ToArray();
        }

        public Product GetById(string productId)
        {
            return this.GetAll()
                .Single(p => p.Id == productId);
        }
    }
}
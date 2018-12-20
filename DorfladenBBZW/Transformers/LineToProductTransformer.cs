using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using DorfladenBBZW.Models;

namespace DorfladenBBZW.Transformers
{
    public class LineToProductTransformer
    {
        public IEnumerable<Product> Transform(IEnumerable<string> input)
        {
            return input
                .Select(i => i.Split(';').ToArray())
                .Select(p => new Product(
                    p[0],
                    p[1],
                    decimal.Parse(p[2], NumberStyles.Number, CultureInfo.InvariantCulture),
                    decimal.Parse(p[3], NumberStyles.Number, CultureInfo.InvariantCulture),
                    p[4],
                    p[5]));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace DorfladenBBZW.Transformers
{
    public class FileContentToItemsTransformer
    {
        public IReadOnlyCollection<string> Transform(string fileContent)
        {
            var lines = fileContent
                .Split(new[] { "\n" }, StringSplitOptions.None);

            return lines
                .Skip(1)
                .ToArray();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionViewSamples.Models
{
    public class ItemGroup: List<Item>
    {
        public string Name { get; private set; }

        public ItemGroup(string name, List<Item> items): base(items)
        {
            Name = name;
        }
    }
}

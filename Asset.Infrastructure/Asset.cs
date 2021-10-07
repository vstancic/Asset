using System;

namespace Asset.Infrastructure
{
    public class Asset
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
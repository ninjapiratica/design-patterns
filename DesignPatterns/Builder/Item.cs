using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    public class Item
    {
        public string Value { get; set; }
        public object Config { get; set; }

        public override string ToString()
        {
            var props = Config.GetType().GetProperties();

            var configStrings = new List<string>();
            foreach (var prop in props)
            {
                var val = prop.GetValue(Config);
                configStrings.Add($"{prop.Name}:{val}");
            }

            return $"{Value} - {{{string.Join(",", configStrings)}}}";
        }
    }
}

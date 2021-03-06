using System.Collections.Generic;

namespace TTConfTool.Shared
{
    public class SearchFilter
    {
        public List<KeyValuePair<string, string>> Value { get; set; }

        public SearchFilter()
        {
            Value = new List<KeyValuePair<string, string>>();
        }
    }
}

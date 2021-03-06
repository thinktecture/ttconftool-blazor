using System.Collections.Generic;

namespace TTConfTool.Shared
{
    public class SearchFilter
    {
        private List<KeyValuePair<string, string>> _value { get; set; }

        public SearchFilter()
        {
            _value = new List<KeyValuePair<string, string>>();
        }

        public void Add(string key, string value)
        {
            _value.Add(new KeyValuePair<string, string>(key, value));
        }

        public void Clear()
        {
            _value.Clear();
        }

        public List<KeyValuePair<string, string>> GetValue()
        {
            return _value;
        }
    }
}
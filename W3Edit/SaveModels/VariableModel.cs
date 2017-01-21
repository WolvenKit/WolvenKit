using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace W3SavegameEditor.Models
{
    public class VariableModel
    {
        public int Index { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Value { get; set; }

        public string DebugString { get; set; }

        public List<VariableModel> Children { get; set; }

        public override string ToString()
        {
            return DebugString;
        }
    }
}
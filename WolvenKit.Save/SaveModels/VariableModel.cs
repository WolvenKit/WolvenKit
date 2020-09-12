using System.Collections.ObjectModel;

namespace WolvenKit.W3SavegameEditor.Core.SaveModels
{
    public class VariableModel
    {
        public int Index { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Value { get; set; }

        public string DebugString { get; set; }

        public ObservableCollection<VariableModel> Children { get; set; }

        public override string ToString()
        {
            return DebugString;
        }
    }
}
using System.Collections.ObjectModel;

namespace WolvenKit.W3SavegameEditor.Core.SaveModels
{
    public class VariableModel
    {
        #region Properties

        public ObservableCollection<VariableModel> Children { get; set; }
        public string DebugString { get; set; }
        public int Index { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Value { get; set; }

        #endregion Properties

        #region Methods

        public override string ToString()
        {
            return DebugString;
        }

        #endregion Methods
    }
}

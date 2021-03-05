using System.Collections.ObjectModel;

namespace WolvenKit.W3SavegameEditor.Models
{
    public class SavegameDataModel
    {
        #region Properties

        public ObservableCollection<string> VariableNames { get; set; }
        public ObservableCollection<VariableModel> Variables { get; set; }
        public int Version1 { get; set; }
        public int Version2 { get; set; }
        public int Version3 { get; set; }

        #endregion Properties
    }
}

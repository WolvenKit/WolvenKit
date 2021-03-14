using System.IO;
using WolvenKit.Common.Model;

namespace WolvenKit.Common
{
    public class FileSavedEventArgs
    {
        #region Properties

        public IWolvenkitFile File { get; set; }
        public string FileName { get; set; }
        public Stream Stream { get; set; }

        #endregion Properties
    }
}

using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.Common.Model
{
    /// <summary>
    /// Interface for all Files openable in Wkit
    /// Cr2w files, Srt files
    /// </summary>
    public interface IWolvenkitFile : INotifyPropertyChanged
    {
        #region Properties

        List<ICR2WBuffer> Buffers { get; }
        List<ICR2WExport> Chunks { get; }
        string FileName { get; set; }
        List<ICR2WImport> Imports { get; }

        public bool IsDirty { get; set; }

        #endregion Properties

        //List<ICR2WEmbedded> Embedded { get; }

        #region Methods

        Task<EFileReadErrorCodes> Read(BinaryReader file);

        void Write(BinaryWriter writer);

        #endregion Methods
    }
}

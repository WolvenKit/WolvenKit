using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using FastMember;
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
        List<ICR2WName> Names { get; }
        List<ICR2WBuffer> Buffers { get; }
        List<ICR2WExport> Chunks { get; }
        string FileName { get; set; }
        List<ICR2WImport> Imports { get; }

        public bool IsDirty { get; set; }

        #endregion Properties

        //List<ICR2WEmbedded> Embedded { get; }
        public List<string> UnknownTypes { get; }
        public List<string> UnknownVars { get; set; }

        #region Methods

        Task<EFileReadErrorCodes> Read(BinaryReader file);

        void Write(BinaryWriter writer);

        public ICR2WExport CreateChunk(string type, int chunkindex = 0, ICR2WExport parent = null,
            ICR2WExport virtualparent = null, IEditableVariable cvar = null);


        #endregion Methods
    }

    
}

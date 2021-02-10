using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.Common.Model
{
    /// <summary>
    /// Interface for all Files openable in Wkit
    /// Cr2w files, Srt files
    /// </summary>
    public interface IWolvenkitFile : INotifyPropertyChanged
    {
        string FileName { get; set; }

        List<ICR2WExport> Chunks { get; }

        Task<EFileReadErrorCodes> Read(BinaryReader file);

        void Write(BinaryWriter writer);

    }
}

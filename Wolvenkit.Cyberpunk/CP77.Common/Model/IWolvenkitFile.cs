using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Model
{
    /// <summary>
    /// Interface for all Files openable in Wkit
    /// Cr2w files, Srt files
    /// </summary>
    public interface IWolvenkitFile : INotifyPropertyChanged
    {
        string FileName { get; set; }

        //Task<EFileReadErrorCodes> Read(BinaryReader file);
        EFileReadErrorCodes Read(BinaryReader file);

        void Write(BinaryWriter writer);

    }
}

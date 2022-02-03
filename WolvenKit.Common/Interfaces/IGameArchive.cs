using System.Collections.Generic;
using ProtoBuf;

namespace WolvenKit.Common
{
    [ProtoContract]
    public interface IGameArchive
    {
        #region Properties

        public string ArchiveAbsolutePath { get; set; }

        public Dictionary<ulong, IGameFile> Files { get; }
        public string Name { get; }
        EArchiveType TypeName { get; }


        #endregion Properties
    }

    public interface ICyberGameArchive : IGameArchive
    {



    }

    public interface IWitcherGameArchive : IGameArchive
    {


    }
}

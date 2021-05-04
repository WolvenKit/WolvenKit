using System.Runtime.InteropServices;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.RED4.CR2W
{
    /// <summary>
    ///
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct CR2WImport
    {
        [FieldOffset(0)]
        public uint depotPath;

        [FieldOffset(4)]
        public ushort className;

        [FieldOffset(6)]
        public ushort flags;
    }

    public class CR2WImportWrapper : ICR2WImport
    {
        #region ctor

        public CR2WImportWrapper(CR2WImport import, CR2WFile cr2w)
        {
            _import = import;
            _cr2w = cr2w;
        }

        #endregion ctor

        #region Fields

        private readonly CR2WFile _cr2w;
        private CR2WImport _import;

        #endregion Fields

        #region Properties

        public CR2WImport Import => _import;

        #endregion Properties

        #region properties

        public ushort ClassName => _import.className;

        public string ClassNameStr => _cr2w.Names.Count <= _import.className
            ? _cr2w.Names[_import.className].Str
            : "NAME NOT FOUND";

        public uint DepotPath => _import.depotPath;

        public string DepotPathStr => _cr2w.StringDictionary.ContainsKey(_import.depotPath)
            ? _cr2w.StringDictionary[_import.depotPath]
            : "PATH NOT FOUND";

        public ushort Flags => _import.flags;

        #endregion properties

        #region methods

        public override string ToString() => DepotPathStr;

        #endregion methods
    }
}

using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.Interfaces.RED3
{
    public interface ILocalizedString
    {

    }

    public interface IPtrAccessor : IChunkPtrAccessor
    {

    }

   

    public interface ISoftAccessor
    {
        string DepotPath { get; set; }
        string ClassName { get; set; }
        ushort Flags { get; set; }

        string REDName { get; }
        string REDType { get; }
    }

    

    
}

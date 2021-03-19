using System.IO;
using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class physicsMaterialLibraryResource : physicsMaterialLibraryResource_
    {
        private CArrayVLQInt32<CName> _resourceNames;
        private CArrayCompressed<CHandle<physicsMaterialResource>> _resourceHandles;

        [Ordinal(1000)]
        [REDBuffer]
        public CArrayVLQInt32<CName> ResourceNames
        {
            get => GetProperty(ref _resourceNames);
            set => SetProperty(ref _resourceNames, value);
        }

        [Ordinal(1001)]
        [REDBuffer(true)]
        public CArrayCompressed<CHandle<physicsMaterialResource>> ResourceHandles
        {
            get => GetProperty(ref _resourceHandles);
            set => SetProperty(ref _resourceHandles, value);
        }

        public physicsMaterialLibraryResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            ResourceHandles = new CArrayCompressed<CHandle<physicsMaterialResource>>(cr2w, this, nameof(ResourceHandles))
                { IsSerialized = true };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            ResourceHandles.Read(file, 0, ResourceNames.Count);

        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            ResourceHandles.Write(file);

        }
    }
}

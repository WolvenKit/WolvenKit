using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsMaterialLibraryResource_ : CResource
	{
		private CHandle<physicsMaterialResource> _defaultMaterial;
		private DataBuffer _collectionData;

		[Ordinal(1)] 
		[RED("defaultMaterial")] 
		public CHandle<physicsMaterialResource> DefaultMaterial
		{
			get => GetProperty(ref _defaultMaterial);
			set => SetProperty(ref _defaultMaterial, value);
		}

		[Ordinal(2)] 
		[RED("collectionData")] 
		public DataBuffer CollectionData
		{
			get => GetProperty(ref _collectionData);
			set => SetProperty(ref _collectionData, value);
		}

		public physicsMaterialLibraryResource_(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

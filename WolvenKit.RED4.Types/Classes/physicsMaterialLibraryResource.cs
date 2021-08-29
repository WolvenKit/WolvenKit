using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsMaterialLibraryResource : CResource
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
	}
}

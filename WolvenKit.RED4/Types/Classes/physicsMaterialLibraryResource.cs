using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsMaterialLibraryResource : CResource
	{
		[Ordinal(1)] 
		[RED("defaultMaterial")] 
		public CHandle<physicsMaterialResource> DefaultMaterial
		{
			get => GetPropertyValue<CHandle<physicsMaterialResource>>();
			set => SetPropertyValue<CHandle<physicsMaterialResource>>(value);
		}

		[Ordinal(2)] 
		[RED("collectionData")] 
		public DataBuffer CollectionData
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		public physicsMaterialLibraryResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

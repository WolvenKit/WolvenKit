using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCookedPrefabData : CResource
	{
		[Ordinal(1)] 
		[RED("precookedDependencies")] 
		public CArray<CResourceAsyncReference<CResource>> PrecookedDependencies
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}

		[Ordinal(2)] 
		[RED("dependencies")] 
		public CArray<CResourceReference<CResource>> Dependencies
		{
			get => GetPropertyValue<CArray<CResourceReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceReference<CResource>>>(value);
		}

		public worldCookedPrefabData()
		{
			PrecookedDependencies = new();
			Dependencies = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCookedPrefabData : CResource
	{
		private CArray<CResourceAsyncReference<CResource>> _precookedDependencies;
		private CArray<CResourceReference<CResource>> _dependencies;

		[Ordinal(1)] 
		[RED("precookedDependencies")] 
		public CArray<CResourceAsyncReference<CResource>> PrecookedDependencies
		{
			get => GetProperty(ref _precookedDependencies);
			set => SetProperty(ref _precookedDependencies, value);
		}

		[Ordinal(2)] 
		[RED("dependencies")] 
		public CArray<CResourceReference<CResource>> Dependencies
		{
			get => GetProperty(ref _dependencies);
			set => SetProperty(ref _dependencies, value);
		}
	}
}

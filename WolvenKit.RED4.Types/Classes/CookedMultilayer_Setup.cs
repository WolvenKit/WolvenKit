using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CookedMultilayer_Setup : CResource
	{
		private CArray<CResourceReference<Multilayer_Setup>> _dependencies;

		[Ordinal(1)] 
		[RED("dependencies")] 
		public CArray<CResourceReference<Multilayer_Setup>> Dependencies
		{
			get => GetProperty(ref _dependencies);
			set => SetProperty(ref _dependencies, value);
		}
	}
}

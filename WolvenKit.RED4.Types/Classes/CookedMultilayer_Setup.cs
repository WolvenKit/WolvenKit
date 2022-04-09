using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CookedMultilayer_Setup : CResource
	{
		[Ordinal(1)] 
		[RED("dependencies")] 
		public CArray<CResourceReference<Multilayer_Setup>> Dependencies
		{
			get => GetPropertyValue<CArray<CResourceReference<Multilayer_Setup>>>();
			set => SetPropertyValue<CArray<CResourceReference<Multilayer_Setup>>>(value);
		}

		public CookedMultilayer_Setup()
		{
			Dependencies = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

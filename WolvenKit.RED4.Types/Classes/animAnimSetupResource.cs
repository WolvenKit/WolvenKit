using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimSetupResource : CResource
	{
		[Ordinal(1)] 
		[RED("dependencies")] 
		public CArray<CResourceReference<animAnimSet>> Dependencies
		{
			get => GetPropertyValue<CArray<CResourceReference<animAnimSet>>>();
			set => SetPropertyValue<CArray<CResourceReference<animAnimSet>>>(value);
		}

		public animAnimSetupResource()
		{
			Dependencies = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnRidResourceHandler : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public scnRidResourceId Id
		{
			get => GetPropertyValue<scnRidResourceId>();
			set => SetPropertyValue<scnRidResourceId>(value);
		}

		[Ordinal(1)] 
		[RED("ridResource")] 
		public CResourceReference<scnRidResource> RidResource
		{
			get => GetPropertyValue<CResourceReference<scnRidResource>>();
			set => SetPropertyValue<CResourceReference<scnRidResource>>(value);
		}

		public scnRidResourceHandler()
		{
			Id = new() { Id = 4294967295 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

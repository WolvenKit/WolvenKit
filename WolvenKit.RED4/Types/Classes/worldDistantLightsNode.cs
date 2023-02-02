using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDistantLightsNode : worldNode
	{
		[Ordinal(4)] 
		[RED("data")] 
		public CResourceAsyncReference<CDistantLightsResource> Data
		{
			get => GetPropertyValue<CResourceAsyncReference<CDistantLightsResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CDistantLightsResource>>(value);
		}

		public worldDistantLightsNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

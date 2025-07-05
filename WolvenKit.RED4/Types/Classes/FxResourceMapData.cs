using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FxResourceMapData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("key")] 
		public CName Key
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("resource")] 
		public gameFxResource Resource
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		public FxResourceMapData()
		{
			Resource = new gameFxResource();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

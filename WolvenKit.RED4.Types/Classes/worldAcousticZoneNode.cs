using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAcousticZoneNode : worldNode
	{
		[Ordinal(4)] 
		[RED("isBlocker")] 
		public CBool IsBlocker
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("tagName")] 
		public CName TagName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("tagSpread")] 
		public CFloat TagSpread
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldAcousticZoneNode()
		{
			TagSpread = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

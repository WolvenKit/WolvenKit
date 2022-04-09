using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HighlightObjectEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("reason")] 
		public CName Reason
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public HighlightObjectEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

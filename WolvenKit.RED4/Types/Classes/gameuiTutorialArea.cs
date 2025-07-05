using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiTutorialArea : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("bracketID")] 
		public CName BracketID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiTutorialArea()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

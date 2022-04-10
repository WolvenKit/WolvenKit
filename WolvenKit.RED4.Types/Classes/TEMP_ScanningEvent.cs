using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TEMP_ScanningEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("clue")] 
		public CName Clue
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("showUI")] 
		public CBool ShowUI
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TEMP_ScanningEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

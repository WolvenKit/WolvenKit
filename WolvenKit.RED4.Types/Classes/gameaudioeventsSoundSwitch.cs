using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioeventsSoundSwitch : redEvent
	{
		[Ordinal(0)] 
		[RED("switchName")] 
		public CName SwitchName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("switchValue")] 
		public CName SwitchValue
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameaudioeventsSoundSwitch()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GyroTutorialUIEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("actionPatternTutorialName")] 
		public CName ActionPatternTutorialName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public GyroTutorialUIEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questContentSwitch_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] 
		[RED("switchName")] 
		public CName SwitchName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questContentSwitch_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

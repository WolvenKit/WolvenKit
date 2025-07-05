using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_EnumSwitch : animAnimNode_InputSwitch
	{
		[Ordinal(18)] 
		[RED("enumName")] 
		public CName EnumName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimNode_EnumSwitch()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

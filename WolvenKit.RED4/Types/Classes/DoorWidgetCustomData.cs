using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DoorWidgetCustomData : WidgetCustomData
	{
		[Ordinal(0)] 
		[RED("passcode")] 
		public CInt32 Passcode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("card")] 
		public CName Card
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("isPasswordKnown")] 
		public CBool IsPasswordKnown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DoorWidgetCustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LcdScreenBlackBoardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] 
		[RED("MessegeData")] 
		public gamebbScriptID_Variant MessegeData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public LcdScreenBlackBoardDef()
		{
			MessegeData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

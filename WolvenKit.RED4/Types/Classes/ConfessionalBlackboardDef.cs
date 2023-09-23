using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ConfessionalBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] 
		[RED("IsConfessing")] 
		public gamebbScriptID_Bool IsConfessing
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public ConfessionalBlackboardDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

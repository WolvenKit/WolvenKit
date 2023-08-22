using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IntercomBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] 
		[RED("DisplayString")] 
		public gamebbScriptID_String DisplayString
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(8)] 
		[RED("EnableActions")] 
		public gamebbScriptID_Bool EnableActions
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(9)] 
		[RED("Status")] 
		public gamebbScriptID_Variant Status
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public IntercomBlackboardDef()
		{
			DisplayString = new gamebbScriptID_String();
			EnableActions = new gamebbScriptID_Bool();
			Status = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

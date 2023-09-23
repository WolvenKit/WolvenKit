using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HUDManagerDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("ShowHudHintMessege")] 
		public gamebbScriptID_Bool ShowHudHintMessege
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("HudHintMessegeContent")] 
		public gamebbScriptID_String HudHintMessegeContent
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		public HUDManagerDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

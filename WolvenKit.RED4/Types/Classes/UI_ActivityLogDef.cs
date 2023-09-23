using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_ActivityLogDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("activityLogHide")] 
		public gamebbScriptID_Bool ActivityLogHide
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public UI_ActivityLogDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

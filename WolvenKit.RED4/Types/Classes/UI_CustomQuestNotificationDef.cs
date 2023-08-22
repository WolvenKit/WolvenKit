using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_CustomQuestNotificationDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("data")] 
		public gamebbScriptID_Variant Data
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_CustomQuestNotificationDef()
		{
			Data = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

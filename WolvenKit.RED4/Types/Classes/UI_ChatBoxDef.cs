using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_ChatBoxDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("TextList")] 
		public gamebbScriptID_Variant TextList
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_ChatBoxDef()
		{
			TextList = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

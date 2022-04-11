using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_CodexSystemDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("CodexUpdated")] 
		public gamebbScriptID_Variant CodexUpdated
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_CodexSystemDef()
		{
			CodexUpdated = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

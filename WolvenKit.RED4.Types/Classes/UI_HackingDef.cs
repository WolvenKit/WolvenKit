using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_HackingDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("ammoIndicator")] 
		public gamebbScriptID_Bool AmmoIndicator
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public UI_HackingDef()
		{
			AmmoIndicator = new();
		}
	}
}

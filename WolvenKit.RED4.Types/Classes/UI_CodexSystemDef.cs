using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_CodexSystemDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _codexUpdated;

		[Ordinal(0)] 
		[RED("CodexUpdated")] 
		public gamebbScriptID_Variant CodexUpdated
		{
			get => GetProperty(ref _codexUpdated);
			set => SetProperty(ref _codexUpdated, value);
		}
	}
}

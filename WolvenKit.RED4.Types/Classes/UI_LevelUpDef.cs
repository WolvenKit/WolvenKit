using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_LevelUpDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _level;

		[Ordinal(0)] 
		[RED("level")] 
		public gamebbScriptID_Variant Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}
	}
}

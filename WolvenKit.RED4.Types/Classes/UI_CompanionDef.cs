using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_CompanionDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _flatHeadSpawned;

		[Ordinal(0)] 
		[RED("flatHeadSpawned")] 
		public gamebbScriptID_Bool FlatHeadSpawned
		{
			get => GetProperty(ref _flatHeadSpawned);
			set => SetProperty(ref _flatHeadSpawned, value);
		}
	}
}

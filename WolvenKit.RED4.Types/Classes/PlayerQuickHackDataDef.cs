using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerQuickHackDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _cachedQuickHackList;

		[Ordinal(0)] 
		[RED("CachedQuickHackList")] 
		public gamebbScriptID_Variant CachedQuickHackList
		{
			get => GetProperty(ref _cachedQuickHackList);
			set => SetProperty(ref _cachedQuickHackList, value);
		}
	}
}

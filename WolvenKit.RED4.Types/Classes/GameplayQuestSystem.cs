using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplayQuestSystem : gameScriptableSystem
	{
		private CArray<CHandle<GamplayQuestData>> _quests;

		[Ordinal(0)] 
		[RED("quests")] 
		public CArray<CHandle<GamplayQuestData>> Quests
		{
			get => GetProperty(ref _quests);
			set => SetProperty(ref _quests, value);
		}
	}
}

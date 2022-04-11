using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplayQuestSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("quests")] 
		public CArray<CHandle<GamplayQuestData>> Quests
		{
			get => GetPropertyValue<CArray<CHandle<GamplayQuestData>>>();
			set => SetPropertyValue<CArray<CHandle<GamplayQuestData>>>(value);
		}

		public GameplayQuestSystem()
		{
			Quests = new();
		}
	}
}

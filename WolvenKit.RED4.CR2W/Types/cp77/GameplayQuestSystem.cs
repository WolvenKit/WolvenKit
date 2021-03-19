using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayQuestSystem : gameScriptableSystem
	{
		private CArray<CHandle<GamplayQuestData>> _quests;

		[Ordinal(0)] 
		[RED("quests")] 
		public CArray<CHandle<GamplayQuestData>> Quests
		{
			get => GetProperty(ref _quests);
			set => SetProperty(ref _quests, value);
		}

		public GameplayQuestSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

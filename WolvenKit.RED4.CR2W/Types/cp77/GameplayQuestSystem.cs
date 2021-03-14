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
			get
			{
				if (_quests == null)
				{
					_quests = (CArray<CHandle<GamplayQuestData>>) CR2WTypeManager.Create("array:handle:GamplayQuestData", "quests", cr2w, this);
				}
				return _quests;
			}
			set
			{
				if (_quests == value)
				{
					return;
				}
				_quests = value;
				PropertySet(this);
			}
		}

		public GameplayQuestSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

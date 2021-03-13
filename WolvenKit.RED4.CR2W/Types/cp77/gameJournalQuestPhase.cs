using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestPhase : gameJournalContainerEntry
	{
		[Ordinal(2)] [RED("locationPrefabRef")] public NodeRef LocationPrefabRef { get; set; }

		public gameJournalQuestPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

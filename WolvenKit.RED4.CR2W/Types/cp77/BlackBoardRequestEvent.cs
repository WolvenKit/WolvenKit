using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BlackBoardRequestEvent : redEvent
	{
		[Ordinal(0)] [RED("blackBoard")] public CHandle<gameIBlackboard> BlackBoard { get; set; }
		[Ordinal(1)] [RED("storageClass")] public CEnum<gameScriptedBlackboardStorage> StorageClass { get; set; }
		[Ordinal(2)] [RED("entryTag")] public CName EntryTag { get; set; }

		public BlackBoardRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

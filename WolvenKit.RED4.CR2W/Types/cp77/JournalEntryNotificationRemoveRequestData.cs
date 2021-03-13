using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JournalEntryNotificationRemoveRequestData : IScriptable
	{
		[Ordinal(0)] [RED("entryHash")] public CUInt32 EntryHash { get; set; }

		public JournalEntryNotificationRemoveRequestData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

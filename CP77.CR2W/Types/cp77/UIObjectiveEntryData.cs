using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UIObjectiveEntryData : CVariable
	{
		[Ordinal(0)]  [RED("counter")] public CString Counter { get; set; }
		[Ordinal(1)]  [RED("isOptional")] public CBool IsOptional { get; set; }
		[Ordinal(2)]  [RED("isTracked")] public CBool IsTracked { get; set; }
		[Ordinal(3)]  [RED("name")] public CString Name { get; set; }
		[Ordinal(4)]  [RED("state")] public CEnum<gameJournalEntryState> State { get; set; }
		[Ordinal(5)]  [RED("type")] public CEnum<UIObjectiveEntryType> Type { get; set; }

		public UIObjectiveEntryData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SPresetTimetableEntry : CVariable
	{
		[Ordinal(0)]  [RED("arrayPosition")] public CInt32 ArrayPosition { get; set; }
		[Ordinal(1)]  [RED("entryID")] public CUInt32 EntryID { get; set; }
		[Ordinal(2)]  [RED("time")] public SSimpleGameTime Time { get; set; }
		[Ordinal(3)]  [RED("useTime")] public CBool UseTime { get; set; }

		public SPresetTimetableEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

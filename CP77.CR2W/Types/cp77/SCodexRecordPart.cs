using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SCodexRecordPart : CVariable
	{
		[Ordinal(0)]  [RED("PartContent")] public CString PartContent { get; set; }
		[Ordinal(1)]  [RED("PartName")] public CName PartName { get; set; }
		[Ordinal(2)]  [RED("Unlocked")] public CBool Unlocked { get; set; }

		public SCodexRecordPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

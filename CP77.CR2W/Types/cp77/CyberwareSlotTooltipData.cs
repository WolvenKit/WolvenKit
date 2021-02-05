using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CyberwareSlotTooltipData : ATooltipData
	{
		[Ordinal(0)]  [RED("Empty")] public CBool Empty { get; set; }
		[Ordinal(1)]  [RED("Name")] public CString Name { get; set; }
		[Ordinal(2)]  [RED("Description")] public CString Description { get; set; }
		[Ordinal(3)]  [RED("IconPath")] public CString IconPath { get; set; }

		public CyberwareSlotTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

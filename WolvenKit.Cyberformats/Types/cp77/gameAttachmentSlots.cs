using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameAttachmentSlots : entIComponent
	{
		[Ordinal(3)] [RED("animParams")] public CArray<gameAnimParamSlotsOption> AnimParams { get; set; }

		public gameAttachmentSlots(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

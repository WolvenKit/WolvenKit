using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entHardTransformBinding : entITransformBinding
	{
		[Ordinal(3)] [RED("slotName")] public CName SlotName { get; set; }

		public entHardTransformBinding(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

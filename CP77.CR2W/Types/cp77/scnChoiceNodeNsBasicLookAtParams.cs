using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsBasicLookAtParams : scnChoiceNodeNsLookAtParams
	{
		[Ordinal(0)]  [RED("offset")] public Vector3 Offset { get; set; }
		[Ordinal(1)]  [RED("slotName")] public CName SlotName { get; set; }

		public scnChoiceNodeNsBasicLookAtParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

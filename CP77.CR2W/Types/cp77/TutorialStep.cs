using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TutorialStep : CVariable
	{
		[Ordinal(0)]  [RED("allowedActions")] public CArray<CName> AllowedActions { get; set; }
		[Ordinal(1)]  [RED("description")] public CString Description { get; set; }
		[Ordinal(2)]  [RED("pointerRotation")] public CFloat PointerRotation { get; set; }
		[Ordinal(3)]  [RED("pointerXPos")] public CFloat PointerXPos { get; set; }
		[Ordinal(4)]  [RED("pointerYPos")] public CFloat PointerYPos { get; set; }
		[Ordinal(5)]  [RED("showPointer")] public CBool ShowPointer { get; set; }

		public TutorialStep(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animLookAtRequestForPart : CVariable
	{
		[Ordinal(0)] [RED("bodyPart")] public CName BodyPart { get; set; }
		[Ordinal(1)] [RED("request")] public animLookAtRequest Request { get; set; }
		[Ordinal(2)] [RED("attachLeftHandToRightHand")] public CInt32 AttachLeftHandToRightHand { get; set; }
		[Ordinal(3)] [RED("attachRightHandToLeftHand")] public CInt32 AttachRightHandToLeftHand { get; set; }

		public animLookAtRequestForPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

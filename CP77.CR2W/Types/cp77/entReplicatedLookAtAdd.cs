using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entReplicatedLookAtAdd : entReplicatedLookAtData
	{
		[Ordinal(0)]  [RED("bodyPart")] public CName BodyPart { get; set; }
		[Ordinal(1)]  [RED("request")] public animLookAtRequest Request { get; set; }
		[Ordinal(2)]  [RED("targetPositionProvider")] public CHandle<entIPositionProvider> TargetPositionProvider { get; set; }
		[Ordinal(3)]  [RED("ref")] public animLookAtRef Ref { get; set; }

		public entReplicatedLookAtAdd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

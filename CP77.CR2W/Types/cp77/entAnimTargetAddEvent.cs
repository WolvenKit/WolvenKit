using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entAnimTargetAddEvent : redEvent
	{
		[Ordinal(0)] [RED("targetPositionProvider")] public CHandle<entIPositionProvider> TargetPositionProvider { get; set; }
		[Ordinal(1)] [RED("bodyPart")] public CName BodyPart { get; set; }

		public entAnimTargetAddEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

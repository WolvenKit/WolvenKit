using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animCurvePathBakerUserInput : CVariable
	{
		[Ordinal(0)]  [RED("controllersSetupName")] public CName ControllersSetupName { get; set; }
		[Ordinal(1)]  [RED("useStart")] public CBool UseStart { get; set; }
		[Ordinal(2)]  [RED("useStop")] public CBool UseStop { get; set; }
		[Ordinal(3)]  [RED("blendTime")] public CFloat BlendTime { get; set; }

		public animCurvePathBakerUserInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

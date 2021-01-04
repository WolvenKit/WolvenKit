using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsCameraOverrideSettings : CVariable
	{
		[Ordinal(0)]  [RED("overrideDof")] public CBool OverrideDof { get; set; }
		[Ordinal(1)]  [RED("overrideFov")] public CBool OverrideFov { get; set; }
		[Ordinal(2)]  [RED("resetDof")] public CBool ResetDof { get; set; }
		[Ordinal(3)]  [RED("resetFov")] public CBool ResetFov { get; set; }

		public scneventsCameraOverrideSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

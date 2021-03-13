using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsCameraOverrideSettings : CVariable
	{
		[Ordinal(0)] [RED("overrideFov")] public CBool OverrideFov { get; set; }
		[Ordinal(1)] [RED("overrideDof")] public CBool OverrideDof { get; set; }
		[Ordinal(2)] [RED("resetFov")] public CBool ResetFov { get; set; }
		[Ordinal(3)] [RED("resetDof")] public CBool ResetDof { get; set; }

		public scneventsCameraOverrideSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

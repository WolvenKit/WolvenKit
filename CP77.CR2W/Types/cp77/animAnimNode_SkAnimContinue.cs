using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkAnimContinue : animAnimNode_SkAnim
	{
		[Ordinal(18)] [RED("Input")] public animPoseLink Input { get; set; }
		[Ordinal(19)] [RED("popSafeCutTag")] public CName PopSafeCutTag { get; set; }

		public animAnimNode_SkAnimContinue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

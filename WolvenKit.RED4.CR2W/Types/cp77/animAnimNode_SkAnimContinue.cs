using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkAnimContinue : animAnimNode_SkAnim
	{
		[Ordinal(30)] [RED("Input")] public animPoseLink Input { get; set; }
		[Ordinal(31)] [RED("popSafeCutTag")] public CName PopSafeCutTag { get; set; }

		public animAnimNode_SkAnimContinue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

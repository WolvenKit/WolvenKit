using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workTransitionAnim : CVariable
	{
		[Ordinal(0)] [RED("fromIdle")] public CName FromIdle { get; set; }
		[Ordinal(1)] [RED("toIdle")] public CName ToIdle { get; set; }
		[Ordinal(2)] [RED("transitionAnim")] public CName TransitionAnim { get; set; }

		public workTransitionAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

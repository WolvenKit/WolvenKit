using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForceEmptyHandsDecisions : UpperBodyTransition
	{
		[Ordinal(0)] [RED("stateBodyDone")] public CBool StateBodyDone { get; set; }

		public ForceEmptyHandsDecisions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

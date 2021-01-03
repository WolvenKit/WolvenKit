using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ClimbDecisions : LocomotionGroundDecisions
	{
		[Ordinal(0)]  [RED("stateBodyDone")] public CBool StateBodyDone { get; set; }

		public ClimbDecisions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

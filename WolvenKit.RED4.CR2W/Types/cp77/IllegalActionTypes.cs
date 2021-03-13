using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IllegalActionTypes : CVariable
	{
		[Ordinal(0)] [RED("regularActions")] public CBool RegularActions { get; set; }
		[Ordinal(1)] [RED("quickHacks")] public CBool QuickHacks { get; set; }
		[Ordinal(2)] [RED("skillChecks")] public CBool SkillChecks { get; set; }

		public IllegalActionTypes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

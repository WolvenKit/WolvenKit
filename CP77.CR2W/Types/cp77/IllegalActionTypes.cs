using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class IllegalActionTypes : CVariable
	{
		[Ordinal(0)]  [RED("quickHacks")] public CBool QuickHacks { get; set; }
		[Ordinal(1)]  [RED("regularActions")] public CBool RegularActions { get; set; }
		[Ordinal(2)]  [RED("skillChecks")] public CBool SkillChecks { get; set; }

		public IllegalActionTypes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

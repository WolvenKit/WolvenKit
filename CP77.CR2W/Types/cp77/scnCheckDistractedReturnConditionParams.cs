using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnCheckDistractedReturnConditionParams : CVariable
	{
		[Ordinal(0)]  [RED("distracted")] public CBool Distracted { get; set; }
		[Ordinal(1)]  [RED("target")] public CEnum<scnDistractedConditionTarget> Target { get; set; }

		public scnCheckDistractedReturnConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

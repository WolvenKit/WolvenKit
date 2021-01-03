using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnCheckPlayerTargetEntityDistanceReturnCondition : scnIReturnCondition
	{
		[Ordinal(0)]  [RED("params")] public scnCheckPlayerTargetEntityDistanceReturnConditionParams Params { get; set; }

		public scnCheckPlayerTargetEntityDistanceReturnCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

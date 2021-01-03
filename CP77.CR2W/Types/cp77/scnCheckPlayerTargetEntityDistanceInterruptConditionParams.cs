using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnCheckPlayerTargetEntityDistanceInterruptConditionParams : CVariable
	{
		[Ordinal(0)]  [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }
		[Ordinal(1)]  [RED("distance")] public CFloat Distance { get; set; }
		[Ordinal(2)]  [RED("targetEntity")] public gameEntityReference TargetEntity { get; set; }

		public scnCheckPlayerTargetEntityDistanceInterruptConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

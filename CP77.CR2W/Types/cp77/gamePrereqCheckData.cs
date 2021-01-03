using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamePrereqCheckData : CVariable
	{
		[Ordinal(0)]  [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }
		[Ordinal(1)]  [RED("contextObject")] public CString ContextObject { get; set; }
		[Ordinal(2)]  [RED("prereqType")] public CEnum<gameEPrerequisiteType> PrereqType { get; set; }
		[Ordinal(3)]  [RED("valueToCompare")] public CFloat ValueToCompare { get; set; }

		public gamePrereqCheckData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

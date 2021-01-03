using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSetProgress_NodeType : questIAchievementManagerNodeType
	{
		[Ordinal(0)]  [RED("achievement")] public TweakDBID Achievement { get; set; }
		[Ordinal(1)]  [RED("currentValue")] public CUInt32 CurrentValue { get; set; }
		[Ordinal(2)]  [RED("factName")] public CString FactName { get; set; }
		[Ordinal(3)]  [RED("maxValue")] public CUInt32 MaxValue { get; set; }

		public questSetProgress_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

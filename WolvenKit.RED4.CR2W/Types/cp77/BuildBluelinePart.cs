using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BuildBluelinePart : gameinteractionsvisBluelinePart
	{
		[Ordinal(2)] [RED("record")] public CHandle<gamedataPlayerBuild_Record> Record { get; set; }
		[Ordinal(3)] [RED("lhsValue")] public CInt32 LhsValue { get; set; }
		[Ordinal(4)] [RED("rhsValue")] public CInt32 RhsValue { get; set; }
		[Ordinal(5)] [RED("comparisonOperator")] public CEnum<ECompareOp> ComparisonOperator { get; set; }

		public BuildBluelinePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

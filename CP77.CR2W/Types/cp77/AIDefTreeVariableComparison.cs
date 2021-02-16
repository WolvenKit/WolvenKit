using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIDefTreeVariableComparison : LibTreeDefTreeVariableBoolBase
	{
		[Ordinal(2)] [RED("exportAsProperty")] public CBool ExportAsProperty { get; set; }
		[Ordinal(3)] [RED("referenceVariableId")] public CUInt16 ReferenceVariableId { get; set; }
		[Ordinal(4)] [RED("referenceVariableName")] public CName ReferenceVariableName { get; set; }
		[Ordinal(5)] [RED("referenceVariableShortName")] public CName ReferenceVariableShortName { get; set; }
		[Ordinal(6)] [RED("referenceType")] public CName ReferenceType { get; set; }
		[Ordinal(7)] [RED("operator")] public CEnum<EComparisonType> Operator { get; set; }
		[Ordinal(8)] [RED("referenceValue")] public CVariant ReferenceValue { get; set; }

		public AIDefTreeVariableComparison(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

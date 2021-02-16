using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SFakeFeatureChoice : CVariable
	{
		[Ordinal(0)] [RED("choiceID")] public CString ChoiceID { get; set; }
		[Ordinal(1)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(2)] [RED("disableOnUse")] public CBool DisableOnUse { get; set; }
		[Ordinal(3)] [RED("factToEnableName")] public CName FactToEnableName { get; set; }
		[Ordinal(4)] [RED("factOnUse")] public SFactOperationData FactOnUse { get; set; }
		[Ordinal(5)] [RED("factsOnUse")] public CArray<SFactOperationData> FactsOnUse { get; set; }
		[Ordinal(6)] [RED("affectedComponents")] public CArray<SComponentOperationData> AffectedComponents { get; set; }
		[Ordinal(7)] [RED("callbackID")] public CUInt32 CallbackID { get; set; }

		public SFakeFeatureChoice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

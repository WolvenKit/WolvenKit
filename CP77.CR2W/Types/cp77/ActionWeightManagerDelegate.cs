using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ActionWeightManagerDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] [RED("actionsConditions")] public CArray<CName> ActionsConditions { get; set; }
		[Ordinal(1)] [RED("actionsWeights")] public CArray<CInt32> ActionsWeights { get; set; }
		[Ordinal(2)] [RED("lowestWeight")] public CInt32 LowestWeight { get; set; }
		[Ordinal(3)] [RED("selectedActionIndex")] public CInt32 SelectedActionIndex { get; set; }

		public ActionWeightManagerDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TweakAIActionSmartComposite : TweakAIActionAbstract
	{
		[Ordinal(27)]  [RED("smartComposite")] public TweakDBID SmartComposite { get; set; }
		[Ordinal(28)]  [RED("smartCompositeRecord")] public wCHandle<gamedataAIActionSmartComposite_Record> SmartCompositeRecord { get; set; }
		[Ordinal(29)]  [RED("interruptionRequested")] public CBool InterruptionRequested { get; set; }
		[Ordinal(30)]  [RED("conditionSuccessfulCheckTimeStamp")] public CFloat ConditionSuccessfulCheckTimeStamp { get; set; }
		[Ordinal(31)]  [RED("conditionCheckTimeStamp")] public CFloat ConditionCheckTimeStamp { get; set; }
		[Ordinal(32)]  [RED("conditionCheckRandomizedInterval")] public CFloat ConditionCheckRandomizedInterval { get; set; }
		[Ordinal(33)]  [RED("iteration")] public CUInt32 Iteration { get; set; }
		[Ordinal(34)]  [RED("nodeIterator")] public CInt32 NodeIterator { get; set; }
		[Ordinal(35)]  [RED("currentNodeIterator")] public CInt32 CurrentNodeIterator { get; set; }
		[Ordinal(36)]  [RED("currentNodeType")] public CEnum<ETweakAINodeType> CurrentNodeType { get; set; }
		[Ordinal(37)]  [RED("currentNode")] public wCHandle<gamedataAINode_Record> CurrentNode { get; set; }

		public TweakAIActionSmartComposite(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TweakAIActionSmartComposite : TweakAIActionAbstract
	{
		[Ordinal(0)]  [RED("conditionCheckRandomizedInterval")] public CFloat ConditionCheckRandomizedInterval { get; set; }
		[Ordinal(1)]  [RED("conditionCheckTimeStamp")] public CFloat ConditionCheckTimeStamp { get; set; }
		[Ordinal(2)]  [RED("conditionSuccessfulCheckTimeStamp")] public CFloat ConditionSuccessfulCheckTimeStamp { get; set; }
		[Ordinal(3)]  [RED("currentNode")] public wCHandle<gamedataAINode_Record> CurrentNode { get; set; }
		[Ordinal(4)]  [RED("currentNodeIterator")] public CInt32 CurrentNodeIterator { get; set; }
		[Ordinal(5)]  [RED("currentNodeType")] public CEnum<ETweakAINodeType> CurrentNodeType { get; set; }
		[Ordinal(6)]  [RED("interruptionRequested")] public CBool InterruptionRequested { get; set; }
		[Ordinal(7)]  [RED("iteration")] public CUInt32 Iteration { get; set; }
		[Ordinal(8)]  [RED("nodeIterator")] public CInt32 NodeIterator { get; set; }
		[Ordinal(9)]  [RED("smartComposite")] public TweakDBID SmartComposite { get; set; }
		[Ordinal(10)]  [RED("smartCompositeRecord")] public wCHandle<gamedataAIActionSmartComposite_Record> SmartCompositeRecord { get; set; }

		public TweakAIActionSmartComposite(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

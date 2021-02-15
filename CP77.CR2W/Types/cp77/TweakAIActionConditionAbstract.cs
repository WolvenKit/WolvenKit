using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TweakAIActionConditionAbstract : AIbehaviorconditionScript
	{
		[Ordinal(0)] [RED("actionRecord")] public wCHandle<gamedataAIAction_Record> ActionRecord { get; set; }
		[Ordinal(1)] [RED("actionDebugName")] public CString ActionDebugName { get; set; }

		public TweakAIActionConditionAbstract(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

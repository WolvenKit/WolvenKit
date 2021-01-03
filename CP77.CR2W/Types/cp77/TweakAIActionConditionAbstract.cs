using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TweakAIActionConditionAbstract : AIbehaviorconditionScript
	{
		[Ordinal(0)]  [RED("actionDebugName")] public CString ActionDebugName { get; set; }
		[Ordinal(1)]  [RED("actionRecord")] public wCHandle<gamedataAIAction_Record> ActionRecord { get; set; }

		public TweakAIActionConditionAbstract(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

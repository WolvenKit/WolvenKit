using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIStackSignalCondition : AIbehaviorStackScriptPassiveExpressionDefinition
	{
		[Ordinal(0)] [RED("signalName")] public CName SignalName { get; set; }

		public AIStackSignalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

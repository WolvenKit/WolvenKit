using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBlackboardPrereq : gameIComparisonPrereq
	{
		[Ordinal(1)] [RED("blackboardValue")] public gameBlackboardPropertyBindingDefinition BlackboardValue { get; set; }
		[Ordinal(2)] [RED("value")] public CVariant Value { get; set; }

		public gameBlackboardPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

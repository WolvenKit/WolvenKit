using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameBlackboardPrereq : gameIComparisonPrereq
	{
		[Ordinal(0)]  [RED("blackboardValue")] public gameBlackboardPropertyBindingDefinition BlackboardValue { get; set; }
		[Ordinal(1)]  [RED("value")] public CVariant Value { get; set; }

		public gameBlackboardPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSwitchNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(0)]  [RED("behaviour")] public CEnum<questESwitchBehaviourType> Behaviour { get; set; }
		[Ordinal(1)]  [RED("conditions")] public CArray<questConditionItem> Conditions { get; set; }

		public questSwitchNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

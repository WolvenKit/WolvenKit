using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSwitchNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(0)]  [RED("behaviour")] public CEnum<questESwitchBehaviourType> Behaviour { get; set; }
		[Ordinal(1)]  [RED("conditions")] public CArray<questConditionItem> Conditions { get; set; }

		public questSwitchNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

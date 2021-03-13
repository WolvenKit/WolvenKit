using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questClearForcedBehavioursNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] [RED("puppet")] public gameEntityReference Puppet { get; set; }

		public questClearForcedBehavioursNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

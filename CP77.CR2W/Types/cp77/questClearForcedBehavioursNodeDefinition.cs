using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questClearForcedBehavioursNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(0)]  [RED("puppet")] public gameEntityReference Puppet { get; set; }

		public questClearForcedBehavioursNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

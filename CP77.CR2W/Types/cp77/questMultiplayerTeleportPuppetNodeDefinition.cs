using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerTeleportPuppetNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(0)]  [RED("params")] public questMultiplayerTeleportPuppetParams Params { get; set; }

		public questMultiplayerTeleportPuppetNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

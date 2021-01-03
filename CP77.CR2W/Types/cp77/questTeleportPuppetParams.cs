using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questTeleportPuppetParams : CVariable
	{
		[Ordinal(0)]  [RED("destinationOffset")] public Vector3 DestinationOffset { get; set; }
		[Ordinal(1)]  [RED("destinationRef")] public CHandle<questUniversalRef> DestinationRef { get; set; }

		public questTeleportPuppetParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

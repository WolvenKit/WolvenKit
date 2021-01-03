using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questTeleportPuppetParamsV1 : questAICommandParams
	{
		[Ordinal(0)]  [RED("destinationOffset")] public Vector3 DestinationOffset { get; set; }
		[Ordinal(1)]  [RED("destinationRef")] public CHandle<questUniversalRef> DestinationRef { get; set; }
		[Ordinal(2)]  [RED("doNavTest")] public CBool DoNavTest { get; set; }
		[Ordinal(3)]  [RED("healAtTeleport")] public CBool HealAtTeleport { get; set; }
		[Ordinal(4)]  [RED("resetLookAt")] public CBool ResetLookAt { get; set; }
		[Ordinal(5)]  [RED("useFastTravelMechanism")] public CBool UseFastTravelMechanism { get; set; }

		public questTeleportPuppetParamsV1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

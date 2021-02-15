using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questTeleportPuppetParamsV1 : questAICommandParams
	{
		[Ordinal(0)] [RED("destinationRef")] public CHandle<questUniversalRef> DestinationRef { get; set; }
		[Ordinal(1)] [RED("destinationOffset")] public Vector3 DestinationOffset { get; set; }
		[Ordinal(2)] [RED("doNavTest")] public CBool DoNavTest { get; set; }
		[Ordinal(3)] [RED("resetLookAt")] public CBool ResetLookAt { get; set; }
		[Ordinal(4)] [RED("useFastTravelMechanism")] public CBool UseFastTravelMechanism { get; set; }
		[Ordinal(5)] [RED("healAtTeleport")] public CBool HealAtTeleport { get; set; }

		public questTeleportPuppetParamsV1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIDriveToNodeCommandHandler : AICommandHandlerBase
	{
		[Ordinal(0)]  [RED("forceGreenLights")] public CHandle<AIArgumentMapping> ForceGreenLights { get; set; }
		[Ordinal(1)]  [RED("outIsPlayer")] public CHandle<AIArgumentMapping> OutIsPlayer { get; set; }
		[Ordinal(2)]  [RED("outNeedDriver")] public CHandle<AIArgumentMapping> OutNeedDriver { get; set; }
		[Ordinal(3)]  [RED("outNodeRef")] public CHandle<AIArgumentMapping> OutNodeRef { get; set; }
		[Ordinal(4)]  [RED("outSecureTimeOut")] public CHandle<AIArgumentMapping> OutSecureTimeOut { get; set; }
		[Ordinal(5)]  [RED("outTrafficTryNeighborsForEnd")] public CHandle<AIArgumentMapping> OutTrafficTryNeighborsForEnd { get; set; }
		[Ordinal(6)]  [RED("outTrafficTryNeighborsForStart")] public CHandle<AIArgumentMapping> OutTrafficTryNeighborsForStart { get; set; }
		[Ordinal(7)]  [RED("outUseKinematic")] public CHandle<AIArgumentMapping> OutUseKinematic { get; set; }
		[Ordinal(8)]  [RED("outUseTraffic")] public CHandle<AIArgumentMapping> OutUseTraffic { get; set; }
		[Ordinal(9)]  [RED("portals")] public CHandle<AIArgumentMapping> Portals { get; set; }

		public AIDriveToNodeCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

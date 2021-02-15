using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MovableDevice : InteractiveDevice
	{
		[Ordinal(93)] [RED("workspotSideName")] public CName WorkspotSideName { get; set; }
		[Ordinal(94)] [RED("sideTriggerNames")] public CArray<CName> SideTriggerNames { get; set; }
		[Ordinal(95)] [RED("triggerComponents")] public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents { get; set; }
		[Ordinal(96)] [RED("offMeshConnectionsToOpenNames")] public CArray<CName> OffMeshConnectionsToOpenNames { get; set; }
		[Ordinal(97)] [RED("offMeshConnectionsToOpen")] public CArray<CHandle<AIOffMeshConnectionComponent>> OffMeshConnectionsToOpen { get; set; }
		[Ordinal(98)] [RED("additionalMeshComponent")] public CHandle<entMeshComponent> AdditionalMeshComponent { get; set; }
		[Ordinal(99)] [RED("UseWorkspotComponentPosition")] public CBool UseWorkspotComponentPosition { get; set; }
		[Ordinal(100)] [RED("shouldMoveRight")] public CBool ShouldMoveRight { get; set; }

		public MovableDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
